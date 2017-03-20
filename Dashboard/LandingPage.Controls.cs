
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// LandingPage.aspx page.  The Row or RecordControl classes are the 
// ideal place to add code customizations. For example, you can override the LoadData, 
// CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#region "Using statements"    

using Microsoft.VisualBasic;
using BaseClasses.Web.UI.WebControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Utils;
using ReportTools.ReportCreator;
using ReportTools.Shared;

        
using RatTrap.Business;
using RatTrap.Data;
using RatTrap.UI;
using RatTrap;
		

#endregion

  
namespace RatTrap.UI.Controls.LandingPage
{
  

#region "Section 1: Place your customizations here."

    
public class UsersGroupsLinkTableControlRow : BaseUsersGroupsLinkTableControlRow
{
      
        // The BaseUsersGroupsLinkTableControlRow implements code for a ROW within the
        // the UsersGroupsLinkTableControl table.  The BaseUsersGroupsLinkTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of UsersGroupsLinkTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class UsersGroupsLinkTableControl : BaseUsersGroupsLinkTableControl
{
    // The BaseUsersGroupsLinkTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The UsersGroupsLinkTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the UsersGroupsLinkTableControlRow control on the LandingPage page.
// Do not modify this class. Instead override any method in UsersGroupsLinkTableControlRow.
public class BaseUsersGroupsLinkTableControlRow : RatTrap.UI.BaseApplicationRecordControl
{
        public BaseUsersGroupsLinkTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in UsersGroupsLinkTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in UsersGroupsLinkTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseTheRatTrap%dbo.UsersGroupsLink record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = UsersGroupsLinkTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseUsersGroupsLinkTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new UsersGroupsLinkRecord();
            
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            //This is to make sure all the controls will be invisible if no record is present in the cell
            
            // LoadData for DataSource for chart and report if they exist
          
                  LoadData_View_Trap_SummaryCountQuery1();
       
                  LoadData_View_Trap_SummaryCountQuery2();
       
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetGroupId();
                SetUserId0();
                
                
                

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            
                if (this.DataSource.GetID() == null)
                  this.IsNewRecord = false;
              

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        SetView_Trap_SummaryCountChart1();
        
        }
        
        
        public virtual string GetImageWithOverlaidText(string imgFieldName, object otherFieldName, string redirectURL) {
        
            return this.Page.GetImageWithOverlaidText(imgFieldName, this.DataSource, otherFieldName, redirectURL);
        }
    
        public virtual void SetGroupId()
        {
            
                    
            // Set the GroupId Literal on the webpage with value from the
            // DatabaseTheRatTrap%dbo.UsersGroupsLink database record.

            // this.DataSource is the DatabaseTheRatTrap%dbo.UsersGroupsLink record retrieved from the database.
            // this.GroupId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.GroupIdSpecified) {
                								
                // If the GroupId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = UsersGroupsLinkTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(UsersGroupsLinkTable.GroupId);
               if(_isExpandableNonCompositeForeignKey &&UsersGroupsLinkTable.GroupId.IsApplyDisplayAs)
                                  
                     formattedValue = UsersGroupsLinkTable.GetDFKA(this.DataSource.GroupId.ToString(),UsersGroupsLinkTable.GroupId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(UsersGroupsLinkTable.GroupId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.GroupId.Text = formattedValue;
                   
            } 
            
            else {
            
                // GroupId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.GroupId.Text = UsersGroupsLinkTable.GroupId.Format(UsersGroupsLinkTable.GroupId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetUserId0()
        {
            
                    
            // Set the UserId Literal on the webpage with value from the
            // DatabaseTheRatTrap%dbo.UsersGroupsLink database record.

            // this.DataSource is the DatabaseTheRatTrap%dbo.UsersGroupsLink record retrieved from the database.
            // this.UserId0 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.UserId0Specified) {
                								
                // If the UserId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = UsersGroupsLinkTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(UsersGroupsLinkTable.UserId0);
               if(_isExpandableNonCompositeForeignKey &&UsersGroupsLinkTable.UserId0.IsApplyDisplayAs)
                                  
                     formattedValue = UsersGroupsLinkTable.GetDFKA(this.DataSource.UserId0.ToString(),UsersGroupsLinkTable.UserId0, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(UsersGroupsLinkTable.UserId0);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.UserId0.Text = formattedValue;
                   
            } 
            
            else {
            
                // UserId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.UserId0.Text = UsersGroupsLinkTable.UserId0.Format(UsersGroupsLinkTable.UserId0.DefaultValue);
            		
            }
            
            // If the UserId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.UserId0.Text == null ||
                this.UserId0.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.UserId0.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetView_Trap_SummaryCountChart1()           
                
        {
                
            if (!View_Trap_SummaryCountQuery2.DataChanged) return;
          
            System.Web.UI.DataVisualization.Charting.Chart chartControl = View_Trap_SummaryCountChart1;
            
            // clear ChartAreas, Legends, Series, and Titles.  Otherwise, exception happens during postback
            chartControl.ChartAreas.Clear();
            chartControl.Legends.Clear();
            chartControl.Series.Clear();
            chartControl.Titles.Clear();
            
            // collect data to be displayed on the chart
            
            string[] indexArray = View_Trap_SummaryCountQuery2.GetComposedStringColumn("Species", EvaluateFormulaDelegate, EvaluateFormula("Resource(\"Txt:RemainderLabel\")"));
            
            decimal[] valueArray = View_Trap_SummaryCountQuery2.GetComposedDecimalColumn("View_Trap_SummaryCount", EvaluateFormulaDelegate,true);
              
            // define redirect URL
            string[] legendURL = View_Trap_SummaryCountQuery2.GetComposedStringColumn("\"../view_Trap-Summary/Show-View-Trap-Summary-Table.aspx?Species=\" + UrlEncode(Species.ToString())", EvaluateFormulaDelegate, "");
            string[] dataPointURL = View_Trap_SummaryCountQuery2.GetComposedStringColumn("\"../view_Trap-Summary/Show-View-Trap-Summary-Table.aspx?Species=\" + UrlEncode(Species.ToString())", EvaluateFormulaDelegate, "");
          
          
            
            // Reverse the index and value in order to show smallest first              
                
            // -1 because we want to leave the remainder label at last                  
            if (indexArray != null) Array.Reverse(indexArray, 0, indexArray.Length - 1);
            if (valueArray != null) Array.Reverse(valueArray, 0, valueArray.Length - 1);
            if (legendURL != null) Array.Reverse(legendURL, 0, legendURL.Length - 1);
            if (dataPointURL != null) Array.Reverse(dataPointURL, 0, dataPointURL.Length - 1);
                
            // define the chart properties based on the setting you have set on the Properties Windows and the Application Generation Option Dialog.          
            int barThickness = 15;
            string chartType = "Column";
            bool usePalette = false;
            System.Web.UI.DataVisualization.Charting.ChartColorPalette palette = (System.Web.UI.DataVisualization.Charting.ChartColorPalette)(System.Web.UI.DataVisualization.Charting.ChartColorPalette.Parse(typeof(System.Web.UI.DataVisualization.Charting.ChartColorPalette), "Bright"));
            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("Blue");
            System.Drawing.Color backGroundColor = System.Drawing.ColorTranslator.FromHtml("White");
            System.Drawing.Color gridColor = System.Drawing.ColorTranslator.FromHtml("LightGray");
            string fontFamily = "Arial";
            System.Drawing.Color fontColor = System.Drawing.ColorTranslator.FromHtml("Black");
            System.Drawing.Color internalLabelColor = System.Drawing.ColorTranslator.FromHtml("White");
            string showInsideBar = "Label inside bar";
            string title = EvaluateFormula("\"Trap Summary\" + \"  x  \" + \"Species\"");
            string indexAxisTitle = EvaluateFormula("\"Species\"");
            string valueAxisTitle = EvaluateFormula("\"Trap Summary\"");
            int labelAngle = -50;
            
            bool generatePercentage = false;
                        
            string labelFormat = "0";
            string chartTitleFontSize = "";
            string axisTitleFontSize = "";
            string scaleFontSize = "";
            string labelInsideFontSize = "";
            string customProperties = "";
            
            System.Collections.Generic.List<object> args = new System.Collections.Generic.List<object>();
            args.Add(chartControl);
            args.Add(indexArray);
            args.Add(valueArray);
            args.Add(legendURL);
            args.Add(dataPointURL);
            args.Add(barThickness);
            args.Add(chartType);
            args.Add(usePalette);
            args.Add(palette);
            args.Add(color);
            args.Add(backGroundColor);
            args.Add(gridColor);
            args.Add(fontFamily);
            args.Add(fontColor);
            args.Add(internalLabelColor);
            args.Add(showInsideBar);
            args.Add(title);
            args.Add(indexAxisTitle);
            args.Add(valueAxisTitle);
            args.Add(labelAngle);
            args.Add(generatePercentage);
            args.Add(labelFormat);
            args.Add(chartTitleFontSize);
            args.Add(axisTitleFontSize);
            args.Add(scaleFontSize);
            args.Add(labelInsideFontSize);
            args.Add(customProperties);
            
            this.Page.InitializeChartControl(args.ToArray());
            
        }      
      
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
                // add datasource as variables for formula evaluation
                  UsersGroupsLinkTableControl panel;
                panel = (UsersGroupsLinkTableControl)(this.GetParentTableControl());
                  
                if (View_Trap_SummaryCountQuery1 != null) e.Variables.Add("View_Trap_SummaryCountQuery1", View_Trap_SummaryCountQuery1);                                                       
                        
                if (View_Trap_SummaryCountQuery2 != null) e.Variables.Add("View_Trap_SummaryCountQuery2", View_Trap_SummaryCountQuery2);                                                       
                        
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "RatTrap"));
                }
            }
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((UsersGroupsLinkTableControl)MiscUtils.GetParentControlObject(this, "UsersGroupsLinkTableControl")).DataChanged = true;
                ((UsersGroupsLinkTableControl)MiscUtils.GetParentControlObject(this, "UsersGroupsLinkTableControl")).ResetData = true;
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetGroupId();
            GetUserId0();
        }
        
        
        public virtual void GetGroupId()
        {
            
        }
                
        public virtual void GetUserId0()
        {
            
        }
                

      // To customize, override this method in UsersGroupsLinkTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersUsersGroupsLinkTableControl = false;
            hasFiltersUsersGroupsLinkTableControl = hasFiltersUsersGroupsLinkTableControl && false; // suppress warning
      
            return null;
        
        }
        
        
        private DataSource _View_Trap_SummaryCountQuery1 = new DataSource();
        public DataSource View_Trap_SummaryCountQuery1
        {
            get
            {
                return _View_Trap_SummaryCountQuery1;
             }
        }
      
        private DataSource _View_Trap_SummaryCountQuery2 = new DataSource();
        public DataSource View_Trap_SummaryCountQuery2
        {
            get
            {
                return _View_Trap_SummaryCountQuery2;
             }
        }
      
        public virtual void LoadData_View_Trap_SummaryCountQuery1()
        
        {
          UsersGroupsLinkTableControl tableCtrl = (UsersGroupsLinkTableControl) this.GetParentTableControl(); 
              if (!(tableCtrl.ResetData || tableCtrl.DataChanged || _View_Trap_SummaryCountQuery1.DataChanged) && this.Page.IsPostBack) return;            
          
              _View_Trap_SummaryCountQuery1.DataChanged = true;
          
              this._View_Trap_SummaryCountQuery1.Initialize("View_Trap_SummaryCountQuery1", View_Trap_SummaryView.Instance, 0, 0);                                            
              
               
              // Add the primary key of the record
              WhereClause wc = CreateWhereClause_View_Trap_SummaryCountQuery1();
              this._View_Trap_SummaryCountQuery1.WhereClause.iAND(wc);                      
          
              // Define selects
          
              this._View_Trap_SummaryCountQuery1.AddSelectItem(new SelectItem(View_Trap_SummaryView.Species, View_Trap_SummaryView.Instance, false, "", ""));
              
                    this._View_Trap_SummaryCountQuery1.AddSelectItem(new SelectItem(SelectItem.Operation.COUNT, new SelectItem(SelectItem.ItemType.AllColumns, View_Trap_SummaryView.Instance, "View_Trap_SummaryCount", ""), "View_Trap_SummaryCount"));
              
              // Define joins if there are any
          
              this._View_Trap_SummaryCountQuery1.AddAggregateOrderBy("View_Trap_SummaryCount", OrderByItem.OrderDir.Desc);
              
              this._View_Trap_SummaryCountQuery1.LoadData(false, this._View_Trap_SummaryCountQuery1.PageSize, this._View_Trap_SummaryCountQuery1.PageIndex);                       
                        
        }
      
        public virtual void LoadData_View_Trap_SummaryCountQuery2()
        
        {
          UsersGroupsLinkTableControl tableCtrl = (UsersGroupsLinkTableControl) this.GetParentTableControl(); 
              if (!(tableCtrl.ResetData || tableCtrl.DataChanged || _View_Trap_SummaryCountQuery2.DataChanged) && this.Page.IsPostBack) return;            
          
              _View_Trap_SummaryCountQuery2.DataChanged = true;
          
              this._View_Trap_SummaryCountQuery2.Initialize("View_Trap_SummaryCountQuery2", View_Trap_SummaryView.Instance, 0, 0);                                            
              
               
              // Add the primary key of the record
              WhereClause wc = CreateWhereClause_View_Trap_SummaryCountQuery2();
              this._View_Trap_SummaryCountQuery2.WhereClause.iAND(wc);                      
          
              // Define selects
          
              this._View_Trap_SummaryCountQuery2.AddSelectItem(new SelectItem(View_Trap_SummaryView.Species, View_Trap_SummaryView.Instance, false, "", ""));
              
                    this._View_Trap_SummaryCountQuery2.AddSelectItem(new SelectItem(SelectItem.Operation.COUNT, new SelectItem(SelectItem.ItemType.AllColumns, View_Trap_SummaryView.Instance, "View_Trap_SummaryCount", ""), "View_Trap_SummaryCount"));
              
              // Define joins if there are any
          
              this._View_Trap_SummaryCountQuery2.AddJoin(View_Trap_SummaryView.GroupId, View_Trap_SummaryView.Instance, "", UsersGroupsLinkTable.GroupId, UsersGroupsLinkTable.Instance, "");
          
              this._View_Trap_SummaryCountQuery2.AddAggregateOrderBy("View_Trap_SummaryCount", OrderByItem.OrderDir.Desc);
              
              this._View_Trap_SummaryCountQuery2.LoadData(false, this._View_Trap_SummaryCountQuery2.PageSize, this._View_Trap_SummaryCountQuery2.PageIndex);                       
                        
        }
      
        public virtual WhereClause CreateWhereClause_View_Trap_SummaryCountQuery1()
        
        {
            WhereClause wc = new WhereClause();
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design tithis.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

                      
            return wc;
        }
      
        public virtual WhereClause CreateWhereClause_View_Trap_SummaryCountQuery2()
        
        {
            WhereClause wc = new WhereClause();
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design tithis.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

          
      KeyValue selectedRecordKeyValue = new KeyValue();
    
          KeyValue usersGroupsLinkRecordObj = null;
          // make variable assignment here to avoid possible incorrect compiler warning
          KeyValue tmp = usersGroupsLinkRecordObj;
          usersGroupsLinkRecordObj = tmp;
        UsersGroupsLinkTableControlRow usersGroupsLinkTableControlObjRow = (MiscUtils.GetParentControlObject(this, "UsersGroupsLinkTableControlRow") as UsersGroupsLinkTableControlRow);
          
              if (usersGroupsLinkTableControlObjRow != null && usersGroupsLinkTableControlObjRow.GetRecord() != null)
              {
              wc.iAND(UsersGroupsLinkTable.UserGroupsId, BaseFilter.ComparisonOperator.EqualsTo, usersGroupsLinkTableControlObjRow.GetRecord().UserGroupsId.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["View_Trap_SummaryCountQuery2WhereClause"] = selectedRecordKeyValue.ToXmlString();
                
            return wc;
        }
      
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          UsersGroupsLinkTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((UsersGroupsLinkTableControl)MiscUtils.GetParentControlObject(this, "UsersGroupsLinkTableControl")).DataChanged = true;
            ((UsersGroupsLinkTableControl)MiscUtils.GetParentControlObject(this, "UsersGroupsLinkTableControl")).ResetData = true;
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
    
        // Generate set method for buttons
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseUsersGroupsLinkTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseUsersGroupsLinkTableControlRow_Rec"] = value;
            }
        }
        
        public UsersGroupsLinkRecord DataSource {
            get {
                return (UsersGroupsLinkRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal GroupId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GroupId");
            }
        }
            
        public System.Web.UI.WebControls.Literal UserId0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UserId0");
            }
        }
            
        public System.Web.UI.DataVisualization.Charting.Chart View_Trap_SummaryCountChart1 {
            get {
                return (System.Web.UI.DataVisualization.Charting.Chart)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "View_Trap_SummaryCountChart1");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        UsersGroupsLinkRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "RatTrap"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    UsersGroupsLinkRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "RatTrap"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual UsersGroupsLinkRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return UsersGroupsLinkTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            throw new Exception(Page.GetResourceValue("Err:RetrieveRec", "RatTrap"));
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the UsersGroupsLinkTableControl control on the LandingPage page.
// Do not modify this class. Instead override any method in UsersGroupsLinkTableControl.
public class BaseUsersGroupsLinkTableControl : RatTrap.UI.BaseApplicationTableControl
{
         
       public BaseUsersGroupsLinkTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
        }


        this.VerticalColumns = Convert.ToInt32(this.GetFromSession(this, "Vertical_Columns", "3"));
      

    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));            
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.Pagination.FirstPage.Click += Pagination_FirstPage_Click;
                        
                    this.Pagination.LastPage.Click += Pagination_LastPage_Click;
                        
                    this.Pagination.NextPage.Click += Pagination_NextPage_Click;
                        
                    this.Pagination.PageSizeButton.Click += Pagination_PageSizeButton_Click;
                        
                    this.Pagination.PreviousPage.Click += Pagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
                  
        
         //' Setup events for others
               
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(RatTrap.Business.UsersGroupsLinkRecord);
                      this.DataSource = (UsersGroupsLinkRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / (Convert.ToDouble(this.PageSize * this.VerticalColumns))));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (UsersGroupsLinkTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(RatTrap.Business.UsersGroupsLinkRecord);
                    this.DataSource = (UsersGroupsLinkRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, (this.PageSize * this.VerticalColumns));
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual UsersGroupsLinkRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(UsersGroupsLinkTable.Column1, true);          
            // selCols.Add(UsersGroupsLinkTable.Column2, true);          
            // selCols.Add(UsersGroupsLinkTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return UsersGroupsLinkTable.GetRecords(join, where, orderBy, this.PageIndex, (this.PageSize * this.VerticalColumns));
                 
            }
            else
            {
                UsersGroupsLinkTable databaseTable = new UsersGroupsLinkTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(UsersGroupsLinkRecord)) as UsersGroupsLinkRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(UsersGroupsLinkTable.Column1, true);          
            // selCols.Add(UsersGroupsLinkTable.Column2, true);          
            // selCols.Add(UsersGroupsLinkTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return UsersGroupsLinkTable.GetRecordCount(join, where);
            else
            {
                UsersGroupsLinkTable databaseTable = new UsersGroupsLinkTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
      public virtual UsersGroupsLinkRecord[] CopyArray(int index, UsersGroupsLinkRecord[,] recs, int columns)
      {
        UsersGroupsLinkRecord[] recsCopy = new UsersGroupsLinkRecord[columns];
        for (int counter = 0; counter <= columns - 1; counter++)
        {
            recsCopy[counter] = recs[index, counter];
        }
        return recsCopy;
      }

      public virtual int CalculateRows(int dataSourceLength, int columns, int pageSize)
      {
        return BaseClasses.Utils.MiscUtils.CalculateRows(dataSourceLength, columns, pageSize);
      }
    
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          if (PageIndex == 0) {
	      base.DataBind();
          }
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
          
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();     

            // Setup the pagination controls.
            BindPaginationControls();

    
        
            int pageSize = this.PageSize;

            int rows = CalculateRows(DataSource.Length, this.VerticalColumns, pageSize);
            UsersGroupsLinkRecord[,] recs = new UsersGroupsLinkRecord[Convert.ToInt32(rows - 1) + 1, this.VerticalColumns];

            int hColumns = 0;
            for (int counter = 0; counter <= Convert.ToInt32(rows - 1); counter++)
            {
              for (int innerCounter = 0; innerCounter <= this.VerticalColumns - 1; innerCounter++)
              {
                if (DataSource.Length > hColumns)
                {
                  recs[counter, innerCounter] = DataSource[hColumns];
                  hColumns += 1;
                }
              }
            }
            
            UsersGroupsLinkRecord[] HColDataSource = new UsersGroupsLinkRecord[Convert.ToInt32(rows)];

            // Bind the repeater with the list of records to expand the UI.
            
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UsersGroupsLinkTableControlRepeater");
            if (rep == null) return;

            if (PageIndex == 0) {
	            List<Object> ds = new List<Object>();
	            for (int i = 0; i <= 100; i++) {
	              ds.Add(new object());
	            }
	            rep.DataSource = ds;
	            rep.DataBind();
            }
            
            System.Web.UI.WebControls.Repeater rep1 = (System.Web.UI.WebControls.Repeater)BaseClasses.Utils.MiscUtils.FindControlRecursively(rep.Items[PageIndex], "UsersGroupsLinkTableControlRepeater1");
            rep1.DataSource = HColDataSource;
            rep1.DataBind();
            
            int index = 0;
            int remainingDLength = DataSource.Length;
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep1.Items)
            {
            
            
              // Loop through all rows in the table, set its DataSource and call DataBind().

              if (remainingDLength > this.VerticalColumns)
              {
                remainingDLength = remainingDLength - this.VerticalColumns;
              }

              UsersGroupsLinkRecord[] VColDataSource = new UsersGroupsLinkRecord[this.VerticalColumns];

              System.Web.UI.WebControls.Repeater repControl = (System.Web.UI.WebControls.Repeater)repItem.FindControl("UsersGroupsLinkTableControlCellRepeater");
              if (repControl == null)
                  break;
              repControl.DataSource = VColDataSource;
              repControl.DataBind();

              UsersGroupsLinkRecord[] recsCopy = CopyArray(index, recs, this.VerticalColumns);
              int indexInnerRep = 0;
              foreach (System.Web.UI.WebControls.RepeaterItem innerRepItem in repControl.Items) {
                UsersGroupsLinkTableControlRow recControl = (UsersGroupsLinkTableControlRow)innerRepItem.FindControl("UsersGroupsLinkTableControlRow");
                recControl.DataSource = recsCopy[indexInnerRep];
                if (this.UIData.Count > indexInnerRep) {
                  recControl.PreviousUIData = this.UIData[indexInnerRep];
                }
                if (recControl.DataSource != null){
                  recControl.DataBind();
                  
                    recControl.Visible = !this.InDeletedRecordIds(recControl);
                  
                }else{
                  recControl.DataBind();
                  recControl.IsNewRecord = false;
                }
                indexInnerRep += 1;
              }
              index += 1;
            }
      
    
            // Call the Set methods for each controls on the panel
        
                
                
                  // Update session indicate which row is selected
                  bool shouldResetControl = true;
                  
                  if (rep1.Items.Count > 0){
                  System.Web.UI.WebControls.Repeater repControl = (System.Web.UI.WebControls.Repeater)rep1.Items[0].FindControl("UsersGroupsLinkTableControlCellRepeater");  
                  
                  foreach (System.Web.UI.WebControls.RepeaterItem innerRepItem in repControl.Items)
                  {
                  UsersGroupsLinkTableControlRow recControl = (UsersGroupsLinkTableControlRow)(innerRepItem.FindControl("UsersGroupsLinkTableControlRow"));
                  string keyValueInSession = this.GetFromSession(this, "selectedRowID", null);
                  if (keyValueInSession != null){
                  foreach (System.Web.UI.WebControls.RepeaterItem repItem in repControl.Items)
                  {
                  KeyValue keyValue = new KeyValue();
                  UsersGroupsLinkTableControlRow row = (UsersGroupsLinkTableControlRow)(repItem.FindControl("UsersGroupsLinkTableControlRow"));
                  
                        if (row.RecordUniqueId != null || row.DataSource != null){
                        if (row.GetRecord().UserGroupsIdSpecified){
                        keyValue.AddElement(UsersGroupsLinkTable.UserGroupsId.InternalName, row.GetRecord().UserGroupsId.ToString());
                        }
                        }
                      
                  if (keyValueInSession == keyValue.ToXmlString() && KeyValue.XmlToKey(keyValueInSession) != null)
                  shouldResetControl = false;
                  }
                  }

                  if (shouldResetControl){
                  // Reset Session for ChildPanel's CreateWhereClause
                  KeyValue keyValue = new KeyValue();

                  
                        if (recControl.GetRecord().UserGroupsIdSpecified){
                        keyValue.AddElement(UsersGroupsLinkTable.UserGroupsId.InternalName, recControl.GetRecord().UserGroupsId.ToString());
                        }
                      

                  this.SaveToSession(this, "selectedRowID", keyValue.ToXmlString());
                  keyValueInSession = keyValue.ToXmlString();
                  }

                  // Update image for update panels button
                  
                  foreach (System.Web.UI.WebControls.RepeaterItem repItem in repControl.Items)
                  {
                  KeyValue keyValue = new KeyValue();
                  UsersGroupsLinkTableControlRow row = (UsersGroupsLinkTableControlRow)(repItem.FindControl("UsersGroupsLinkTableControlRow"));
                  
                        if (row.RecordUniqueId != null || row.DataSource != null){
                        if (row.GetRecord().UserGroupsIdSpecified){
                        
                        keyValue.AddElement(UsersGroupsLinkTable.UserGroupsId.InternalName, row.GetRecord().UserGroupsId.ToString());
                        }
                        }
                      
                  // if keyvalue of this row is same as session or if both keyval of this row and the keyval in session are both null,
                  // then mark this row
                  
                  if (keyValueInSession == keyValue.ToXmlString() || (keyValue.Count == 0  && keyValueInSession == null)){
                  
                  break;
                  
                  }
                  }
                  
                  }
                  }
                
           else
           {
              RemoveFromSession(this, "selectedRowID");
           }
            
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
                    
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(UsersGroupsLinkTable.GroupId, this.DataSource);
            this.Page.PregetDfkaRecords(UsersGroupsLinkTable.UserId0, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
                
        }
        

        
          public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

          public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
          {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();

            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            if (includeDS)
            {
                
            }

            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
        
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
           
        public virtual void ResetControl()
        {


            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
               
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
            if (DbUtils.GetCreatedRecords(this.DataSource).Length > 0)                      
                    
            {
                this.Pagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination.CurrentPage.Text = "0";
            }
            this.Pagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for UsersGroupsLinkTableControl pagination.
        
            this.Pagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (UsersGroupsLinkTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (UsersGroupsLinkTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            UsersGroupsLinkTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
               
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            UsersGroupsLinkTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Get the static clause defined at design time on the Table Panel Wizard
            WhereClause qc = this.CreateQueryClause();
            if (qc != null) {
                wc.iAND(qc);
            }
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          

            return wc;
        }

        
        protected virtual WhereClause CreateQueryClause()
        {
            // Create a where clause for the Static clause defined at design time.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("USERID()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"RatTrap.Business.UsersGroupsLinkTable, RatTrap.Business").TableDefinition.ColumnList.GetByUniqueName(@"UsersGroupsLink_.UserId"), EvaluateFormula("USERID()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
         if (EvaluateFormula("USERID()", false) == "--PLEASE_SELECT--" || EvaluateFormula("USERID()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
          
          
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }          
          
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    
                    resultList.Add(itemToAdd);
          								
                    isAdded = true;
                }
            }
            return isAdded;
        }        
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.Pagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination.PageSize.Text);
                } catch (Exception ) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UsersGroupsLinkTableControlRepeater"));
              if (rep == null){return;}
              UsersGroupsLinkTableControlRow[] recControls = this.GetRecordControls();
                foreach (UsersGroupsLinkTableControlRow recControl in recControls) 
		{
              
                // Loop through all rows in the table, set its DataSource and call DataBind().
                
                    if (recControl.Visible && recControl.IsNewRecord) {
      UsersGroupsLinkRecord rec = new UsersGroupsLinkRecord();
        
                        if (recControl.GroupId.Text != "") {
                            rec.Parse(recControl.GroupId.Text, UsersGroupsLinkTable.GroupId);
                  }
                
                        if (recControl.UserId0.Text != "") {
                            rec.Parse(recControl.UserId0.Text, UsersGroupsLinkTable.UserId0);
                  }
                
                      newUIDataList.Add(recControl.PreservedUIData());
                      newRecordList.Add(rec);
                    }
                  }
                }
      
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new UsersGroupsLinkRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(RatTrap.Business.UsersGroupsLinkRecord);
                this.DataSource = (UsersGroupsLinkRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(UsersGroupsLinkTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(UsersGroupsLinkTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        

    
        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    this.LoadData();
                    this.DataBind();					
                    
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
            this.SaveToSession(this, "Vertical_Columns", this.VerticalColumns.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
      this.RemoveFromSession(this, "Vertical_Columns");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["UsersGroupsLinkTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            if (ViewState["Vertical_Columns"] != null) {
              this.VerticalColumns = (int)ViewState["Vertical_Columns"];
            }
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["UsersGroupsLinkTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
      this.ViewState["Vertical_Columns"] = this.VerticalColumns;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
           
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_LastPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_NextPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for LinkButton
        public virtual void Pagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        

        // Generate the event handling functions for sorting events.
        

        // Generate the event handling functions for button events.
        


        // Generate the event handling functions for filter and search events.
        
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = UsersGroupsLinkTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / (Convert.ToDouble(this.PageSize) * Convert.ToDouble(this.VerticalColumns))));
                          
                }
                this._TotalRecords = value;
            }
        }

      
        private int _VerticalColumns;
        public int VerticalColumns
        {
            get {
                return _VerticalColumns;
            }
            set {
                this._VerticalColumns = value;
            }
        }
      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / (Convert.ToDouble(this.PageSize) * Convert.ToDouble(this.VerticalColumns))));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  UsersGroupsLinkRecord[] DataSource {
             
            get {
                return (UsersGroupsLinkRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public RatTrap.UI.IInfinitePagination Pagination {
            get {
                return (RatTrap.UI.IInfinitePagination)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
        }
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                UsersGroupsLinkTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "RatTrap"));
                }

        UsersGroupsLinkRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                UsersGroupsLinkTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "RatTrap"));
                }

        UsersGroupsLinkRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual UsersGroupsLinkTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual UsersGroupsLinkTableControlRow[] GetSelectedRecordControls()
        {
        
            return (UsersGroupsLinkTableControlRow[])((new ArrayList()).ToArray(Type.GetType("RatTrap.UI.Controls.LandingPage.UsersGroupsLinkTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            UsersGroupsLinkTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "RatTrap"));
            }
            
            foreach (UsersGroupsLinkTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual UsersGroupsLinkTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "UsersGroupsLinkTableControlRow");
	          List<UsersGroupsLinkTableControlRow> list = new List<UsersGroupsLinkTableControlRow>();
	          foreach (UsersGroupsLinkTableControlRow recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
        }

        public new BaseApplicationPage Page 
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }
        
                

        
        
#endregion


    }
  

#endregion
    
  
}

  