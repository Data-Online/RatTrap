// This class is "generated" and will be overwritten.
// Your customizations should be made in TrapTypesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="TrapTypesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="TrapTypesTable"></see> class.
/// </remarks>
/// <seealso cref="TrapTypesTable"></seealso>
/// <seealso cref="TrapTypesRecord"></seealso>
public class BaseTrapTypesRecord : PrimaryKeyRecord
{

	public readonly static TrapTypesTable TableUtils = TrapTypesTable.Instance;

	// Constructors
 
	protected BaseTrapTypesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.TrapTypesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.TrapTypesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.TrapTypesRecord_ReadRecord); 
	}

	protected BaseTrapTypesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void TrapTypesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                TrapTypesRecord TrapTypesRec = (TrapTypesRecord)sender;
        if(TrapTypesRec != null && !TrapTypesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void TrapTypesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                TrapTypesRecord TrapTypesRec = (TrapTypesRecord)sender;
        Validate_Inserting();
        if(TrapTypesRec != null && !TrapTypesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void TrapTypesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                TrapTypesRecord TrapTypesRec = (TrapTypesRecord)sender;
        Validate_Updating();
        if(TrapTypesRec != null && !TrapTypesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's TrapTypes_.TrapTypeId field.
	/// </summary>
	public ColumnValue GetTrapTypeIdValue()
	{
		return this.GetValue(TableUtils.TrapTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapTypes_.TrapTypeId field.
	/// </summary>
	public Int32 GetTrapTypeIdFieldValue()
	{
		return this.GetValue(TableUtils.TrapTypeIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapTypes_.TrapType field.
	/// </summary>
	public ColumnValue GetTrapTypeValue()
	{
		return this.GetValue(TableUtils.TrapTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapTypes_.TrapType field.
	/// </summary>
	public string GetTrapTypeFieldValue()
	{
		return this.GetValue(TableUtils.TrapTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapTypes_.TrapType field.
	/// </summary>
	public void SetTrapTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TrapTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapTypes_.TrapType field.
	/// </summary>
	public void SetTrapTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapTypeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapTypes_.TrapTypeId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapTypes_.TrapTypeId field.
	/// </summary>
	public string TrapTypeIdDefault
	{
		get
		{
			return TableUtils.TrapTypeIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapTypes_.TrapType field.
	/// </summary>
	public string TrapType
	{
		get
		{
			return this.GetValue(TableUtils.TrapTypeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TrapTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TrapTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TrapTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapTypes_.TrapType field.
	/// </summary>
	public string TrapTypeDefault
	{
		get
		{
			return TableUtils.TrapTypeColumn.DefaultValue;
		}
	}


#endregion
}

}
