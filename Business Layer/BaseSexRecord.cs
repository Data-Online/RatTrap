// This class is "generated" and will be overwritten.
// Your customizations should be made in SexRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="SexRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="SexTable"></see> class.
/// </remarks>
/// <seealso cref="SexTable"></seealso>
/// <seealso cref="SexRecord"></seealso>
public class BaseSexRecord : PrimaryKeyRecord
{

	public readonly static SexTable TableUtils = SexTable.Instance;

	// Constructors
 
	protected BaseSexRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.SexRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.SexRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.SexRecord_ReadRecord); 
	}

	protected BaseSexRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void SexRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                SexRecord SexRec = (SexRecord)sender;
        if(SexRec != null && !SexRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void SexRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                SexRecord SexRec = (SexRecord)sender;
        Validate_Inserting();
        if(SexRec != null && !SexRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void SexRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                SexRecord SexRec = (SexRecord)sender;
        Validate_Updating();
        if(SexRec != null && !SexRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Sex_.SexId field.
	/// </summary>
	public ColumnValue GetSexIdValue()
	{
		return this.GetValue(TableUtils.SexIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sex_.SexId field.
	/// </summary>
	public Int32 GetSexIdFieldValue()
	{
		return this.GetValue(TableUtils.SexIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sex_.Sex field.
	/// </summary>
	public ColumnValue GetSexValue()
	{
		return this.GetValue(TableUtils.SexColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sex_.Sex field.
	/// </summary>
	public string GetSexFieldValue()
	{
		return this.GetValue(TableUtils.SexColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sex_.Sex field.
	/// </summary>
	public void SetSexFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SexColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sex_.Sex field.
	/// </summary>
	public void SetSexFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SexColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sex_.SexId field.
	/// </summary>
	public Int32 SexId
	{
		get
		{
			return this.GetValue(TableUtils.SexIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SexIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SexIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SexIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sex_.SexId field.
	/// </summary>
	public string SexIdDefault
	{
		get
		{
			return TableUtils.SexIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sex_.Sex field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Sex_.Sex field.
	/// </summary>
	public string SexDefault
	{
		get
		{
			return TableUtils.SexColumn.DefaultValue;
		}
	}


#endregion
}

}
