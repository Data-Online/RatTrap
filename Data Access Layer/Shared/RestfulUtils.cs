using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using BaseClasses.Data;
using Newtonsoft.Json;
using System.Threading.Tasks;


using BaseClasses.Utils;

namespace RatTrap.Data
{
    public class RestfulUtils
    {
        public static void ParseData(List<KeyValuePair<string, string>> values, ref SqlBuilderColumnSelection requestedCols, ref SqlBuilderColumnSelection workingSelCols,
            ref SqlBuilderColumnSelection distinctSelCols, ref OrderBy orderBy, ref KeylessVirtualTable table)
        {
            foreach (KeyValuePair<string, string> value in values)
            {
                switch (value.Key)
                {
                    case "SelectColumns":
                        JSONDataSource jsonDS = JsonConvert.DeserializeObject<JSONDataSource>(value.Value);
                        ConstructDataSourceObjectFromPostRequest(jsonDS, ref requestedCols, ref workingSelCols, ref distinctSelCols, ref orderBy, ref table);
                        break;
                }
            }
        }

        public static void ConstructDataSourceObjectFromPostRequest(JSONDataSource jsonDS, ref SqlBuilderColumnSelection requestedCols, ref SqlBuilderColumnSelection workingSelCols,
            ref SqlBuilderColumnSelection distinctSelCols, ref OrderBy orderBy, ref KeylessVirtualTable table)
        {
            DataSource ds = new DataSource();
            ds.Initialize(jsonDS.Name, DatabaseObjects.GetTableObject(jsonDS.Table), jsonDS.PageSize, jsonDS.PageIndex, jsonDS.GenerateTotal);

            if ((jsonDS.JSelectItems != null))
            {
                foreach (JDataSourceSelectItem jsonSItem in jsonDS.JSelectItems)
                {
                    ds.AddSelectItem(ConstructSelectItemFromPostRequest(jsonSItem));
                }
            }

            requestedCols = new SqlBuilderColumnSelection(jsonDS.ExpandForeignKeyColumns, jsonDS.IsDistinct);
            workingSelCols = new SqlBuilderColumnSelection(jsonDS.ExpandForeignKeyColumns, jsonDS.IsDistinct);
            distinctSelCols = new SqlBuilderColumnSelection(jsonDS.ExpandForeignKeyColumns, jsonDS.IsDistinct);

            List<BaseColumn> columnsList = null;
            if (jsonDS.isTotalRecordArray)
            {
                columnsList = ds.CreateColumnSelectionsForTotal(ref requestedCols, ref workingSelCols, ref distinctSelCols);
            }
            else
            {
                columnsList = ds.CreateColumnSelections(ref requestedCols, ref workingSelCols, ref distinctSelCols);
            }
            table = ds.CreateVirtualTable(columnsList.ToArray());

            if ((jsonDS.JOrderByList != null))
            {
                foreach (JOrderBy jsonOrderBy in jsonDS.JOrderByList)
                {
                    ds.AddAggregateOrderBy(jsonOrderBy.ColumnName, OrderByItem.ToOrderDir(jsonOrderBy.OrderDirection));
                }
            }
            ds.UpdateOrderBy(columnsList);
            orderBy = ds.OrderBy;
        }

        public static SelectItem ConstructSelectItemFromPostRequest(JDataSourceSelectItem jsonSItem)
        {
            SelectItem sItem = null;
            if (!string.IsNullOrEmpty(jsonSItem.ColumnName) && !string.IsNullOrEmpty(jsonSItem.TableName))
            {
                BaseTable table = DatabaseObjects.GetTableObject(jsonSItem.TableName);
                sItem = new SelectItem(table.TableDefinition.ColumnList.GetByCodeName(jsonSItem.ColumnName), table, jsonSItem.Distinct, jsonSItem.AsClause, jsonSItem.TableAlias);
            }
            else if (!string.IsNullOrEmpty(jsonSItem.ItemType) && !string.IsNullOrEmpty(jsonSItem.TableName))
            {
                if (!string.IsNullOrEmpty(jsonSItem.AsClause))
                {
                    if (!string.IsNullOrEmpty(jsonSItem.TableAlias))
                    {
                        sItem = new SelectItem(BaseClasses.Data.SelectItem.ItemTypeDefinition.GetItemType(jsonSItem.ItemType), DatabaseObjects.GetTableObject(jsonSItem.TableName), jsonSItem.AsClause, jsonSItem.TableAlias);
                    }
                    else
                    {
                        sItem = new SelectItem(BaseClasses.Data.SelectItem.ItemTypeDefinition.GetItemType(jsonSItem.ItemType), DatabaseObjects.GetTableObject(jsonSItem.TableName), jsonSItem.AsClause);
                    }
                }
                else
                {
                    sItem = new SelectItem(BaseClasses.Data.SelectItem.ItemTypeDefinition.GetItemType(jsonSItem.ItemType), DatabaseObjects.GetTableObject(jsonSItem.TableName));
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(jsonSItem.Operation))
                {
                    if ((jsonSItem.LeftItem != null) && (jsonSItem.RightItem == null))
                    {
                        sItem = new SelectItem(jsonSItem.Operation, ConstructSelectItemFromPostRequest(jsonSItem.LeftItem), jsonSItem.AsClause);
                    }
                    else if ((jsonSItem.LeftItem != null) && (jsonSItem.RightItem != null))
                    {
                        sItem = new SelectItem(jsonSItem.Operation, ConstructSelectItemFromPostRequest(jsonSItem.LeftItem), ConstructSelectItemFromPostRequest(jsonSItem.RightItem), jsonSItem.AsClause);
                    }
                }
            }

            return sItem;
        }

        public static long GetRecordCount(JSONTable jt)
        {
            BaseTable bt = null;
            BaseFilter join = null;
            SqlFilter whereFilter = null;
            OrderBy orderBy = null;
            GroupBy groupBy = null;

            ConstructTableObjectFromPostRequest(jt, ref bt, ref whereFilter, ref join, ref orderBy, ref groupBy);

            long count = bt.GetRecordListCount(join, whereFilter, groupBy, orderBy);
            return count;
        }

        public static void ConstructTableObjectFromPostRequest(JSONTable jt, ref BaseTable bt, ref SqlFilter whereFilter, ref BaseFilter join, ref OrderBy orderBy, ref GroupBy groupBy)
        {
            bt = (BaseTable)DatabaseObjects.GetTableObject(jt.TableName);

            ColumnList selCols = new ColumnList();
            if ((jt.JSelectColumns != null))
            {
                foreach (JTableSelectColumn col in jt.JSelectColumns)
                {
                    selCols.Add(col.ColumnName, true);
                }

                bt.SelectedColumns.Clear();
                bt.SelectedColumns.AddRange(selCols);
            }
            
            if (jt.JWhereClause != null && jt.JWhereClause.Trim() != "")
            {
                whereFilter = new SqlFilter(jt.JWhereClause);
            }

            if ((jt.JOrderByList != null))
            {
                foreach (JOrderBy jOrderBy in jt.JOrderByList)
                {
                    orderBy = new OrderBy(true, false);
                    orderBy.Add(bt.TableDefinition.ColumnList.GetByCodeName(jOrderBy.ColumnName), OrderByItem.ToOrderDir(jOrderBy.OrderDirection));
                }
            }

            if ((jt.JGroupByList != null))
            {
                foreach (JTableGroupBy jGroupBy in jt.JGroupByList)
                {
                    groupBy = new GroupBy(true, false);
                    groupBy.Add(bt.TableDefinition.ColumnList.GetByCodeName(jGroupBy.ColumnName));
                }
            }
        }

        public static ArrayList GetRecords(JSONTable jt)
        {
            BaseTable bt = null;
            int pageIndex = 0;
            int pageSize = 0;
            int totalRows = 0;
            BaseFilter join = null;
            SqlFilter whereFilter = null;
            OrderBy orderBy = null;

            ConstructTableObjectFromPostRequest(jt, ref bt, ref pageIndex, ref pageSize, ref totalRows, ref whereFilter, ref join, ref orderBy);

            ArrayList recList = bt.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize, ref totalRows);
            return recList;
        }

        public static void ConstructTableObjectFromPostRequest(JSONTable jt, ref BaseTable bt, ref int pageIndex, ref int pageSize, ref int totalRows,
                                                                ref SqlFilter whereFilter, ref BaseFilter join, ref OrderBy orderBy)
        {
            pageIndex = jt.PageIndex;
            pageSize = jt.PageSize;
            totalRows = jt.TotalRows;

            bt = (BaseTable)DatabaseObjects.GetTableObject(jt.TableName);

            ColumnList selCols = new ColumnList();
            foreach (JTableSelectColumn col in jt.JSelectColumns)
            {
                selCols.Add(bt.TableDefinition.ColumnList.GetByCodeName(col.ColumnName), true);
            }

            bt.SelectedColumns.Clear();
            bt.SelectedColumns.AddRange(selCols);
            
            if ((jt.JOrderByList != null))
            {
                foreach (JOrderBy jOrderBy in jt.JOrderByList)
                {
                    orderBy = new OrderBy(true, false);
                    orderBy.Add(bt.TableDefinition.ColumnList.GetByCodeName(jOrderBy.ColumnName), OrderByItem.ToOrderDir(jOrderBy.OrderDirection));
                }
            }

            if (jt.JWhereClause != null && jt.JWhereClause.Trim() != "")
            {
                whereFilter = new SqlFilter(jt.JWhereClause);
            }

        }

        public static string SaveRecord(JSONRecord jr, ref string errMsg)
        {
            PrimaryKeyRecord rec = null;
            ConstructRecordObjectFromPostSaveRequest(jr, ref  rec);

            try
            {
                DbUtils.StartTransaction();

                rec.Save();
                DbUtils.CommitTransaction();
            }
            catch (Exception ex)
            {
                DbUtils.RollBackTransaction();
                errMsg = ex.Message;

                return string.Empty;
            }
            finally
            {
                DbUtils.EndTransaction();
            }

            return rec.GetID().ToXmlString();
        }

        public static void ConstructRecordObjectFromPostSaveRequest(JSONRecord jr, ref PrimaryKeyRecord rec)
        {
            PrimaryKeyTable t = (PrimaryKeyTable)DatabaseObjects.GetTableObject(jr.TableName);
            t.ResetSelectedColumns();

            rec = new PrimaryKeyRecord(t);
            rec.IsExistsInDatabase = jr.IsExistsInDatabase;            
            
            if ((jr.JRecordValues != null))
            {
                foreach (JRecordValue jRecordValue in jr.JRecordValues)
                {
                   BaseColumn bc = t.TableDefinition.ColumnList.GetByCodeName(jRecordValue.ColumnName);                    
                   if (!bc.IsValuesReadOnly)
                   {
                       rec.Parse(jRecordValue.ColumnValue, bc);
                   }
                   else if (t.TableDefinition.IsPrimaryKeyElement(bc))
                   {
                       KeyValue kv = new KeyValue();
                       kv.AddElement(jRecordValue.ColumnName, jRecordValue.ColumnValue.ToString());
                       rec.PrimaryKeyValue = kv;
                   }
                }
            }
        }

        public static void DeleteRecord(JSONRecord jr, ref string errMsg)
        {
            PrimaryKeyTable pk = null;
            List<KeyValue> kvList = new List<KeyValue>();
            ConstructRecordObjectFromPostDeleteRequest(jr, ref  pk, ref kvList);

            try
            {
                foreach (KeyValue kv in kvList)
                {
                    DbUtils.StartTransaction();

                    pk.DeleteOneRecord(kv);

                    DbUtils.CommitTransaction();
                }                
            }
            catch (Exception ex)
            {
                DbUtils.RollBackTransaction();
                errMsg = ex.Message;
            }
            finally
            {
                DbUtils.EndTransaction();
            }
        }

        public static void ConstructRecordObjectFromPostDeleteRequest(JSONRecord jr, ref PrimaryKeyTable pk, ref List<KeyValue> kvList)
        {
            pk = (PrimaryKeyTable)DatabaseObjects.GetTableObject(jr.TableName);
            
            if ((jr.JRecordValues != null))
            {
                foreach (JRecordValue jRecordValue in jr.JRecordValues)
                {
                    KeyValue kv = new KeyValue();
                    kv.AddElement(jRecordValue.ColumnName, jRecordValue.ColumnValue.ToString());                    
                    kvList.Add(kv);
                }
            }
        }
    }
}
