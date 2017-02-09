// This class is "generated" and will be overwritten.
// Your customizations should be made in SpeciesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="SpeciesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="SpeciesTable"></see> class.
/// </remarks>
/// <seealso cref="SpeciesTable"></seealso>
/// <seealso cref="SpeciesRecord"></seealso>
public class BaseSpeciesRecord : PrimaryKeyRecord
{

	public readonly static SpeciesTable TableUtils = SpeciesTable.Instance;

	// Constructors
 
	protected BaseSpeciesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.SpeciesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.SpeciesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.SpeciesRecord_ReadRecord); 
	}

	protected BaseSpeciesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void SpeciesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                SpeciesRecord SpeciesRec = (SpeciesRecord)sender;
        if(SpeciesRec != null && !SpeciesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void SpeciesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                SpeciesRecord SpeciesRec = (SpeciesRecord)sender;
        Validate_Inserting();
        if(SpeciesRec != null && !SpeciesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void SpeciesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                SpeciesRecord SpeciesRec = (SpeciesRecord)sender;
        Validate_Updating();
        if(SpeciesRec != null && !SpeciesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Species_.SpeciesId field.
	/// </summary>
	public ColumnValue GetSpeciesIdValue()
	{
		return this.GetValue(TableUtils.SpeciesIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Species_.SpeciesId field.
	/// </summary>
	public Int32 GetSpeciesIdFieldValue()
	{
		return this.GetValue(TableUtils.SpeciesIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Species_.Species field.
	/// </summary>
	public ColumnValue GetSpeciesValue()
	{
		return this.GetValue(TableUtils.SpeciesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Species_.Species field.
	/// </summary>
	public string GetSpeciesFieldValue()
	{
		return this.GetValue(TableUtils.SpeciesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Species_.Species field.
	/// </summary>
	public void SetSpeciesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SpeciesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Species_.Species field.
	/// </summary>
	public void SetSpeciesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SpeciesColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Species_.SpeciesId field.
	/// </summary>
	public Int32 SpeciesId
	{
		get
		{
			return this.GetValue(TableUtils.SpeciesIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SpeciesIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SpeciesIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SpeciesIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Species_.SpeciesId field.
	/// </summary>
	public string SpeciesIdDefault
	{
		get
		{
			return TableUtils.SpeciesIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Species_.Species field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Species_.Species field.
	/// </summary>
	public string SpeciesDefault
	{
		get
		{
			return TableUtils.SpeciesColumn.DefaultValue;
		}
	}


#endregion
}

}
