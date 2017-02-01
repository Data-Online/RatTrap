// This class is "generated" and will be overwritten.
// Your customizations should be made in UsersGroupsLinkRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="UsersGroupsLinkRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="UsersGroupsLinkTable"></see> class.
/// </remarks>
/// <seealso cref="UsersGroupsLinkTable"></seealso>
/// <seealso cref="UsersGroupsLinkRecord"></seealso>
public class BaseUsersGroupsLinkRecord : PrimaryKeyRecord
{

	public readonly static UsersGroupsLinkTable TableUtils = UsersGroupsLinkTable.Instance;

	// Constructors
 
	protected BaseUsersGroupsLinkRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.UsersGroupsLinkRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.UsersGroupsLinkRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.UsersGroupsLinkRecord_ReadRecord); 
	}

	protected BaseUsersGroupsLinkRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void UsersGroupsLinkRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                UsersGroupsLinkRecord UsersGroupsLinkRec = (UsersGroupsLinkRecord)sender;
        if(UsersGroupsLinkRec != null && !UsersGroupsLinkRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void UsersGroupsLinkRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                UsersGroupsLinkRecord UsersGroupsLinkRec = (UsersGroupsLinkRecord)sender;
        Validate_Inserting();
        if(UsersGroupsLinkRec != null && !UsersGroupsLinkRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void UsersGroupsLinkRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                UsersGroupsLinkRecord UsersGroupsLinkRec = (UsersGroupsLinkRecord)sender;
        Validate_Updating();
        if(UsersGroupsLinkRec != null && !UsersGroupsLinkRec.IsReadOnly ){
                }
    
    }

   //Evaluates Validate when->Inserting formulas specified at the data access layer
	protected virtual void Validate_Inserting()
	{
		string fullValidationMessage = "";
		string validationMessage = "";
		
		string formula = "";if (formula == "") formula = "";


		if(validationMessage != "" && validationMessage.ToLower() != "true")
            fullValidationMessage = fullValidationMessage + validationMessage + "\r\n"; 
		
        if(fullValidationMessage != "")
			throw new Exception(fullValidationMessage);
	}
 
	//Evaluates Validate when->Updating formulas specified at the data access layer
	protected virtual void Validate_Updating()
	{
		string fullValidationMessage = "";
		string validationMessage = "";
		
		string formula = "";if (formula == "") formula = "";


		if(validationMessage != "" && validationMessage.ToLower() != "true")
            fullValidationMessage = fullValidationMessage + validationMessage + "\r\n"; 
		
        if(fullValidationMessage != "")
			throw new Exception(fullValidationMessage);
	}
	public virtual string EvaluateFormula(string formula, BaseRecord  dataSourceForEvaluate, string format)
    {
        Data.BaseFormulaEvaluator e = new Data.BaseFormulaEvaluator();
        
        // All variables referred to in the formula are expected to be
        // properties of the DataSource.  For example, referring to
        // UnitPrice as a variable will refer to DataSource.UnitPrice
        e.DataSource = dataSourceForEvaluate;

        Object resultObj = e.Evaluate(formula);
        if(resultObj == null) 
			return "";
        return resultObj.ToString();
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's UsersGroupsLink_.UserGroupsId field.
	/// </summary>
	public ColumnValue GetUserGroupsIdValue()
	{
		return this.GetValue(TableUtils.UserGroupsIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's UsersGroupsLink_.UserGroupsId field.
	/// </summary>
	public Int32 GetUserGroupsIdFieldValue()
	{
		return this.GetValue(TableUtils.UserGroupsIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's UsersGroupsLink_.UserId field.
	/// </summary>
	public ColumnValue GetUserId0Value()
	{
		return this.GetValue(TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's UsersGroupsLink_.UserId field.
	/// </summary>
	public Int32 GetUserId0FieldValue()
	{
		return this.GetValue(TableUtils.UserId0Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UsersGroupsLink_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UsersGroupsLink_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(string val)
	{
		this.SetString(val, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UsersGroupsLink_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UsersGroupsLink_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UsersGroupsLink_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's UsersGroupsLink_.GroupId field.
	/// </summary>
	public ColumnValue GetGroupIdValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's UsersGroupsLink_.GroupId field.
	/// </summary>
	public Int32 GetGroupIdFieldValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UsersGroupsLink_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UsersGroupsLink_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UsersGroupsLink_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UsersGroupsLink_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UsersGroupsLink_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's UsersGroupsLink_.UserGroupsId field.
	/// </summary>
	public Int32 UserGroupsId
	{
		get
		{
			return this.GetValue(TableUtils.UserGroupsIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UserGroupsIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UserGroupsIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UserGroupsIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UsersGroupsLink_.UserGroupsId field.
	/// </summary>
	public string UserGroupsIdDefault
	{
		get
		{
			return TableUtils.UserGroupsIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's UsersGroupsLink_.UserId field.
	/// </summary>
	public Int32 UserId0
	{
		get
		{
			return this.GetValue(TableUtils.UserId0Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UserId0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UserId0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UserId0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UsersGroupsLink_.UserId field.
	/// </summary>
	public string UserId0Default
	{
		get
		{
			return TableUtils.UserId0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's UsersGroupsLink_.GroupId field.
	/// </summary>
	public Int32 GroupId
	{
		get
		{
			return this.GetValue(TableUtils.GroupIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.GroupIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GroupIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GroupIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UsersGroupsLink_.GroupId field.
	/// </summary>
	public string GroupIdDefault
	{
		get
		{
			return TableUtils.GroupIdColumn.DefaultValue;
		}
	}


#endregion
}

}
