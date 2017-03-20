// This class is "generated" and will be overwritten.
// Your customizations should be made in View_Trap_SummaryRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="View_Trap_SummaryRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="View_Trap_SummaryView"></see> class.
/// </remarks>
/// <seealso cref="View_Trap_SummaryView"></seealso>
/// <seealso cref="View_Trap_SummaryRecord"></seealso>
public class BaseView_Trap_SummaryRecord : PrimaryKeyRecord
{

	public readonly static View_Trap_SummaryView TableUtils = View_Trap_SummaryView.Instance;

	// Constructors
 
	protected BaseView_Trap_SummaryRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.View_Trap_SummaryRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.View_Trap_SummaryRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.View_Trap_SummaryRecord_ReadRecord); 
	}

	protected BaseView_Trap_SummaryRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void View_Trap_SummaryRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                View_Trap_SummaryRecord View_Trap_SummaryRec = (View_Trap_SummaryRecord)sender;
        if(View_Trap_SummaryRec != null && !View_Trap_SummaryRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void View_Trap_SummaryRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                View_Trap_SummaryRecord View_Trap_SummaryRec = (View_Trap_SummaryRecord)sender;
        Validate_Inserting();
        if(View_Trap_SummaryRec != null && !View_Trap_SummaryRec.IsReadOnly ){
               View_Trap_SummaryRec.Parse(EvaluateFormula("UserID()",this,null),View_Trap_SummaryView.CreatedBy);
        }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void View_Trap_SummaryRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                View_Trap_SummaryRecord View_Trap_SummaryRec = (View_Trap_SummaryRecord)sender;
        Validate_Updating();
        if(View_Trap_SummaryRec != null && !View_Trap_SummaryRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.Sex field.
	/// </summary>
	public ColumnValue GetSexValue()
	{
		return this.GetValue(TableUtils.SexColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.Sex field.
	/// </summary>
	public string GetSexFieldValue()
	{
		return this.GetValue(TableUtils.SexColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.Sex field.
	/// </summary>
	public void SetSexFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SexColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.Sex field.
	/// </summary>
	public void SetSexFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SexColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.Species field.
	/// </summary>
	public ColumnValue GetSpeciesValue()
	{
		return this.GetValue(TableUtils.SpeciesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.Species field.
	/// </summary>
	public string GetSpeciesFieldValue()
	{
		return this.GetValue(TableUtils.SpeciesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.Species field.
	/// </summary>
	public void SetSpeciesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SpeciesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.Species field.
	/// </summary>
	public void SetSpeciesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SpeciesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.BaitType field.
	/// </summary>
	public ColumnValue GetBaitTypeValue()
	{
		return this.GetValue(TableUtils.BaitTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.BaitType field.
	/// </summary>
	public string GetBaitTypeFieldValue()
	{
		return this.GetValue(TableUtils.BaitTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.BaitType field.
	/// </summary>
	public void SetBaitTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BaitTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.BaitType field.
	/// </summary>
	public void SetBaitTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BaitTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.CreatedBy field.
	/// </summary>
	public ColumnValue GetCreatedByValue()
	{
		return this.GetValue(TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.CreatedBy field.
	/// </summary>
	public Int32 GetCreatedByFieldValue()
	{
		return this.GetValue(TableUtils.CreatedByColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(string val)
	{
		this.SetString(val, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedByColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.GroupId field.
	/// </summary>
	public ColumnValue GetGroupIdValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.GroupId field.
	/// </summary>
	public Int32 GetGroupIdFieldValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.UserId field.
	/// </summary>
	public ColumnValue GetUserId0Value()
	{
		return this.GetValue(TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.UserId field.
	/// </summary>
	public Int32 GetUserId0FieldValue()
	{
		return this.GetValue(TableUtils.UserId0Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(string val)
	{
		this.SetString(val, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.TrapRecordId field.
	/// </summary>
	public ColumnValue GetTrapRecordIdValue()
	{
		return this.GetValue(TableUtils.TrapRecordIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's view_Trap_Summary_.TrapRecordId field.
	/// </summary>
	public Int32 GetTrapRecordIdFieldValue()
	{
		return this.GetValue(TableUtils.TrapRecordIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.TrapRecordId field.
	/// </summary>
	public void SetTrapRecordIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TrapRecordIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.TrapRecordId field.
	/// </summary>
	public void SetTrapRecordIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.TrapRecordIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.TrapRecordId field.
	/// </summary>
	public void SetTrapRecordIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapRecordIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.TrapRecordId field.
	/// </summary>
	public void SetTrapRecordIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapRecordIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.TrapRecordId field.
	/// </summary>
	public void SetTrapRecordIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapRecordIdColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Trap_Summary_.Sex field.
	/// </summary>
	public string Sex
	{
		get
		{
			return this.GetValue(TableUtils.SexColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SexColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SexSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SexColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.Sex field.
	/// </summary>
	public string SexDefault
	{
		get
		{
			return TableUtils.SexColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Trap_Summary_.Species field.
	/// </summary>
	public string Species
	{
		get
		{
			return this.GetValue(TableUtils.SpeciesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SpeciesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SpeciesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SpeciesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.Species field.
	/// </summary>
	public string SpeciesDefault
	{
		get
		{
			return TableUtils.SpeciesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Trap_Summary_.BaitType field.
	/// </summary>
	public string BaitType
	{
		get
		{
			return this.GetValue(TableUtils.BaitTypeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BaitTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BaitTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BaitTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.BaitType field.
	/// </summary>
	public string BaitTypeDefault
	{
		get
		{
			return TableUtils.BaitTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Trap_Summary_.CreatedBy field.
	/// </summary>
	public Int32 CreatedBy
	{
		get
		{
			return this.GetValue(TableUtils.CreatedByColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CreatedByColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CreatedBySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CreatedByColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.CreatedBy field.
	/// </summary>
	public string CreatedByDefault
	{
		get
		{
			return TableUtils.CreatedByColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Trap_Summary_.GroupId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.GroupId field.
	/// </summary>
	public string GroupIdDefault
	{
		get
		{
			return TableUtils.GroupIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Trap_Summary_.UserId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.UserId field.
	/// </summary>
	public string UserId0Default
	{
		get
		{
			return TableUtils.UserId0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's view_Trap_Summary_.TrapRecordId field.
	/// </summary>
	public Int32 TrapRecordId
	{
		get
		{
			return this.GetValue(TableUtils.TrapRecordIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TrapRecordIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TrapRecordIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TrapRecordIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's view_Trap_Summary_.TrapRecordId field.
	/// </summary>
	public string TrapRecordIdDefault
	{
		get
		{
			return TableUtils.TrapRecordIdColumn.DefaultValue;
		}
	}


#endregion
}

}
