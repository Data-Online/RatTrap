// This class is "generated" and will be overwritten.
// Your customizations should be made in TrapsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="TrapsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="TrapsTable"></see> class.
/// </remarks>
/// <seealso cref="TrapsTable"></seealso>
/// <seealso cref="TrapsRecord"></seealso>
public class BaseTrapsRecord : PrimaryKeyRecord
{

	public readonly static TrapsTable TableUtils = TrapsTable.Instance;

	// Constructors
 
	protected BaseTrapsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.TrapsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.TrapsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.TrapsRecord_ReadRecord); 
	}

	protected BaseTrapsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void TrapsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                TrapsRecord TrapsRec = (TrapsRecord)sender;
        if(TrapsRec != null && !TrapsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void TrapsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                TrapsRecord TrapsRec = (TrapsRecord)sender;
        Validate_Inserting();
        if(TrapsRec != null && !TrapsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void TrapsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                TrapsRecord TrapsRec = (TrapsRecord)sender;
        Validate_Updating();
        if(TrapsRec != null && !TrapsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Traps_.TrapId field.
	/// </summary>
	public ColumnValue GetTrapIdValue()
	{
		return this.GetValue(TableUtils.TrapIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.TrapId field.
	/// </summary>
	public Int32 GetTrapIdFieldValue()
	{
		return this.GetValue(TableUtils.TrapIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.TrapTypeId field.
	/// </summary>
	public ColumnValue GetTrapTypeIdValue()
	{
		return this.GetValue(TableUtils.TrapTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.TrapTypeId field.
	/// </summary>
	public Int32 GetTrapTypeIdFieldValue()
	{
		return this.GetValue(TableUtils.TrapTypeIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.TrapTypeId field.
	/// </summary>
	public void SetTrapTypeIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TrapTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.TrapTypeId field.
	/// </summary>
	public void SetTrapTypeIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.TrapTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.TrapTypeId field.
	/// </summary>
	public void SetTrapTypeIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.TrapTypeId field.
	/// </summary>
	public void SetTrapTypeIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.TrapTypeId field.
	/// </summary>
	public void SetTrapTypeIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapTypeIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.GroupId field.
	/// </summary>
	public ColumnValue GetGroupIdValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.GroupId field.
	/// </summary>
	public Int32 GetGroupIdFieldValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.Active field.
	/// </summary>
	public ColumnValue GetActiveValue()
	{
		return this.GetValue(TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.Active field.
	/// </summary>
	public bool GetActiveFieldValue()
	{
		return this.GetValue(TableUtils.ActiveColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.Active field.
	/// </summary>
	public void SetActiveFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.Active field.
	/// </summary>
	public void SetActiveFieldValue(string val)
	{
		this.SetString(val, TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.Active field.
	/// </summary>
	public void SetActiveFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ActiveColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.LocationId field.
	/// </summary>
	public ColumnValue GetLocationIdValue()
	{
		return this.GetValue(TableUtils.LocationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.LocationId field.
	/// </summary>
	public Int32 GetLocationIdFieldValue()
	{
		return this.GetValue(TableUtils.LocationIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.LocationId field.
	/// </summary>
	public void SetLocationIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LocationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.LocationId field.
	/// </summary>
	public void SetLocationIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.LocationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.LocationId field.
	/// </summary>
	public void SetLocationIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LocationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.LocationId field.
	/// </summary>
	public void SetLocationIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LocationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.LocationId field.
	/// </summary>
	public void SetLocationIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LocationIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.ProjectId field.
	/// </summary>
	public ColumnValue GetProjectIdValue()
	{
		return this.GetValue(TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.ProjectId field.
	/// </summary>
	public Int32 GetProjectIdFieldValue()
	{
		return this.GetValue(TableUtils.ProjectIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjectIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.TrapIdentifierId field.
	/// </summary>
	public ColumnValue GetTrapIdentifierIdValue()
	{
		return this.GetValue(TableUtils.TrapIdentifierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.TrapIdentifierId field.
	/// </summary>
	public Int32 GetTrapIdentifierIdFieldValue()
	{
		return this.GetValue(TableUtils.TrapIdentifierIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.TrapIdentifierId field.
	/// </summary>
	public void SetTrapIdentifierIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TrapIdentifierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.TrapIdentifierId field.
	/// </summary>
	public void SetTrapIdentifierIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.TrapIdentifierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.TrapIdentifierId field.
	/// </summary>
	public void SetTrapIdentifierIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapIdentifierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.TrapIdentifierId field.
	/// </summary>
	public void SetTrapIdentifierIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapIdentifierIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.TrapIdentifierId field.
	/// </summary>
	public void SetTrapIdentifierIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapIdentifierIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.Deleted field.
	/// </summary>
	public ColumnValue GetDeletedValue()
	{
		return this.GetValue(TableUtils.DeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Traps_.Deleted field.
	/// </summary>
	public Int32 GetDeletedFieldValue()
	{
		return this.GetValue(TableUtils.DeletedColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.Deleted field.
	/// </summary>
	public void SetDeletedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.Deleted field.
	/// </summary>
	public void SetDeletedFieldValue(string val)
	{
		this.SetString(val, TableUtils.DeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.Deleted field.
	/// </summary>
	public void SetDeletedFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.Deleted field.
	/// </summary>
	public void SetDeletedFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DeletedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.Deleted field.
	/// </summary>
	public void SetDeletedFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DeletedColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Traps_.TrapId field.
	/// </summary>
	public Int32 TrapId
	{
		get
		{
			return this.GetValue(TableUtils.TrapIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TrapIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TrapIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TrapIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.TrapId field.
	/// </summary>
	public string TrapIdDefault
	{
		get
		{
			return TableUtils.TrapIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Traps_.TrapTypeId field.
	/// </summary>
	public Int32 TrapTypeId
	{
		get
		{
			return this.GetValue(TableUtils.TrapTypeIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TrapTypeIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TrapTypeIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TrapTypeIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.TrapTypeId field.
	/// </summary>
	public string TrapTypeIdDefault
	{
		get
		{
			return TableUtils.TrapTypeIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Traps_.GroupId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.GroupId field.
	/// </summary>
	public string GroupIdDefault
	{
		get
		{
			return TableUtils.GroupIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Traps_.Active field.
	/// </summary>
	public bool Active
	{
		get
		{
			return this.GetValue(TableUtils.ActiveColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ActiveColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ActiveSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ActiveColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.Active field.
	/// </summary>
	public string ActiveDefault
	{
		get
		{
			return TableUtils.ActiveColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Traps_.LocationId field.
	/// </summary>
	public Int32 LocationId
	{
		get
		{
			return this.GetValue(TableUtils.LocationIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LocationIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LocationIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LocationIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.LocationId field.
	/// </summary>
	public string LocationIdDefault
	{
		get
		{
			return TableUtils.LocationIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Traps_.ProjectId field.
	/// </summary>
	public Int32 ProjectId
	{
		get
		{
			return this.GetValue(TableUtils.ProjectIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProjectIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProjectIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProjectIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.ProjectId field.
	/// </summary>
	public string ProjectIdDefault
	{
		get
		{
			return TableUtils.ProjectIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Traps_.TrapIdentifierId field.
	/// </summary>
	public Int32 TrapIdentifierId
	{
		get
		{
			return this.GetValue(TableUtils.TrapIdentifierIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TrapIdentifierIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TrapIdentifierIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TrapIdentifierIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.TrapIdentifierId field.
	/// </summary>
	public string TrapIdentifierIdDefault
	{
		get
		{
			return TableUtils.TrapIdentifierIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Traps_.Deleted field.
	/// </summary>
	public Int32 Deleted
	{
		get
		{
			return this.GetValue(TableUtils.DeletedColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DeletedColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DeletedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DeletedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Traps_.Deleted field.
	/// </summary>
	public string DeletedDefault
	{
		get
		{
			return TableUtils.DeletedColumn.DefaultValue;
		}
	}


#endregion
}

}
