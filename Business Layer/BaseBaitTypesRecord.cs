// This class is "generated" and will be overwritten.
// Your customizations should be made in BaitTypesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="BaitTypesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="BaitTypesTable"></see> class.
/// </remarks>
/// <seealso cref="BaitTypesTable"></seealso>
/// <seealso cref="BaitTypesRecord"></seealso>
public class BaseBaitTypesRecord : PrimaryKeyRecord
{

	public readonly static BaitTypesTable TableUtils = BaitTypesTable.Instance;

	// Constructors
 
	protected BaseBaitTypesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.BaitTypesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.BaitTypesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.BaitTypesRecord_ReadRecord); 
	}

	protected BaseBaitTypesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void BaitTypesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                BaitTypesRecord BaitTypesRec = (BaitTypesRecord)sender;
        if(BaitTypesRec != null && !BaitTypesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void BaitTypesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                BaitTypesRecord BaitTypesRec = (BaitTypesRecord)sender;
        Validate_Inserting();
        if(BaitTypesRec != null && !BaitTypesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void BaitTypesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                BaitTypesRecord BaitTypesRec = (BaitTypesRecord)sender;
        Validate_Updating();
        if(BaitTypesRec != null && !BaitTypesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's BaitTypes_.BaitTypeId field.
	/// </summary>
	public ColumnValue GetBaitTypeIdValue()
	{
		return this.GetValue(TableUtils.BaitTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's BaitTypes_.BaitTypeId field.
	/// </summary>
	public Int32 GetBaitTypeIdFieldValue()
	{
		return this.GetValue(TableUtils.BaitTypeIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's BaitTypes_.BaitType field.
	/// </summary>
	public ColumnValue GetBaitTypeValue()
	{
		return this.GetValue(TableUtils.BaitTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's BaitTypes_.BaitType field.
	/// </summary>
	public string GetBaitTypeFieldValue()
	{
		return this.GetValue(TableUtils.BaitTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's BaitTypes_.BaitType field.
	/// </summary>
	public void SetBaitTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BaitTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's BaitTypes_.BaitType field.
	/// </summary>
	public void SetBaitTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BaitTypeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's BaitTypes_.BaitTypeId field.
	/// </summary>
	public Int32 BaitTypeId
	{
		get
		{
			return this.GetValue(TableUtils.BaitTypeIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BaitTypeIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BaitTypeIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BaitTypeIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's BaitTypes_.BaitTypeId field.
	/// </summary>
	public string BaitTypeIdDefault
	{
		get
		{
			return TableUtils.BaitTypeIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's BaitTypes_.BaitType field.
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
	/// This is a convenience method that allows direct modification of the value of the record's BaitTypes_.BaitType field.
	/// </summary>
	public string BaitTypeDefault
	{
		get
		{
			return TableUtils.BaitTypeColumn.DefaultValue;
		}
	}


#endregion
}

}
