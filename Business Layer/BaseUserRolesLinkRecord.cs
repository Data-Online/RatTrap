// This class is "generated" and will be overwritten.
// Your customizations should be made in UserRolesLinkRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="UserRolesLinkRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="UserRolesLinkTable"></see> class.
/// </remarks>
/// <seealso cref="UserRolesLinkTable"></seealso>
/// <seealso cref="UserRolesLinkRecord"></seealso>
public class BaseUserRolesLinkRecord : PrimaryKeyRecord, IUserRoleRecord
{

	public readonly static UserRolesLinkTable TableUtils = UserRolesLinkTable.Instance;

	// Constructors
 
	protected BaseUserRolesLinkRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.UserRolesLinkRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.UserRolesLinkRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.UserRolesLinkRecord_ReadRecord); 
	}

	protected BaseUserRolesLinkRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void UserRolesLinkRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                UserRolesLinkRecord UserRolesLinkRec = (UserRolesLinkRecord)sender;
        if(UserRolesLinkRec != null && !UserRolesLinkRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void UserRolesLinkRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                UserRolesLinkRecord UserRolesLinkRec = (UserRolesLinkRecord)sender;
        Validate_Inserting();
        if(UserRolesLinkRec != null && !UserRolesLinkRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void UserRolesLinkRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                UserRolesLinkRecord UserRolesLinkRec = (UserRolesLinkRecord)sender;
        Validate_Updating();
        if(UserRolesLinkRec != null && !UserRolesLinkRec.IsReadOnly ){
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

#region "IUserRecord Members"

	//Get the user's unique identifier
	public string GetUserId()
	{
		return this.GetString(((BaseClasses.IUserTable)this.TableAccess).UserIdColumn);
	}

#endregion




#region "IUserRoleRecord Members"

	//Get the role to which this user belongs
	public string GetUserRole()
	{
		return this.GetString(((BaseClasses.IUserRoleTable)this.TableAccess).UserRoleColumn);
	}

#endregion


#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's UserRolesLink_.UserRolesId field.
	/// </summary>
	public ColumnValue GetUserRolesIdValue()
	{
		return this.GetValue(TableUtils.UserRolesIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's UserRolesLink_.UserRolesId field.
	/// </summary>
	public Int32 GetUserRolesIdFieldValue()
	{
		return this.GetValue(TableUtils.UserRolesIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's UserRolesLink_.UserId field.
	/// </summary>
	public ColumnValue GetUserId0Value()
	{
		return this.GetValue(TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's UserRolesLink_.UserId field.
	/// </summary>
	public Int32 GetUserId0FieldValue()
	{
		return this.GetValue(TableUtils.UserId0Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UserRolesLink_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UserRolesLink_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(string val)
	{
		this.SetString(val, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UserRolesLink_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UserRolesLink_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UserRolesLink_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's UserRolesLink_.RoleId field.
	/// </summary>
	public ColumnValue GetRoleIdValue()
	{
		return this.GetValue(TableUtils.RoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's UserRolesLink_.RoleId field.
	/// </summary>
	public Int32 GetRoleIdFieldValue()
	{
		return this.GetValue(TableUtils.RoleIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UserRolesLink_.RoleId field.
	/// </summary>
	public void SetRoleIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UserRolesLink_.RoleId field.
	/// </summary>
	public void SetRoleIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.RoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UserRolesLink_.RoleId field.
	/// </summary>
	public void SetRoleIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UserRolesLink_.RoleId field.
	/// </summary>
	public void SetRoleIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UserRolesLink_.RoleId field.
	/// </summary>
	public void SetRoleIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RoleIdColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's UserRolesLink_.UserRolesId field.
	/// </summary>
	public Int32 UserRolesId
	{
		get
		{
			return this.GetValue(TableUtils.UserRolesIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UserRolesIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UserRolesIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UserRolesIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UserRolesLink_.UserRolesId field.
	/// </summary>
	public string UserRolesIdDefault
	{
		get
		{
			return TableUtils.UserRolesIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's UserRolesLink_.UserId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's UserRolesLink_.UserId field.
	/// </summary>
	public string UserId0Default
	{
		get
		{
			return TableUtils.UserId0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's UserRolesLink_.RoleId field.
	/// </summary>
	public Int32 RoleId
	{
		get
		{
			return this.GetValue(TableUtils.RoleIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RoleIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RoleIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RoleIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's UserRolesLink_.RoleId field.
	/// </summary>
	public string RoleIdDefault
	{
		get
		{
			return TableUtils.RoleIdColumn.DefaultValue;
		}
	}


#endregion
}

}
