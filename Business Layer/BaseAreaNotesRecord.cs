// This class is "generated" and will be overwritten.
// Your customizations should be made in AreaNotesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="AreaNotesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="AreaNotesTable"></see> class.
/// </remarks>
/// <seealso cref="AreaNotesTable"></seealso>
/// <seealso cref="AreaNotesRecord"></seealso>
public class BaseAreaNotesRecord : PrimaryKeyRecord
{

	public readonly static AreaNotesTable TableUtils = AreaNotesTable.Instance;

	// Constructors
 
	protected BaseAreaNotesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.AreaNotesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.AreaNotesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.AreaNotesRecord_ReadRecord); 
	}

	protected BaseAreaNotesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void AreaNotesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                AreaNotesRecord AreaNotesRec = (AreaNotesRecord)sender;
        if(AreaNotesRec != null && !AreaNotesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void AreaNotesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                AreaNotesRecord AreaNotesRec = (AreaNotesRecord)sender;
        Validate_Inserting();
        if(AreaNotesRec != null && !AreaNotesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void AreaNotesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                AreaNotesRecord AreaNotesRec = (AreaNotesRecord)sender;
        Validate_Updating();
        if(AreaNotesRec != null && !AreaNotesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's AreaNotes_.AreaNotesId field.
	/// </summary>
	public ColumnValue GetAreaNotesIdValue()
	{
		return this.GetValue(TableUtils.AreaNotesIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AreaNotes_.AreaNotesId field.
	/// </summary>
	public Int32 GetAreaNotesIdFieldValue()
	{
		return this.GetValue(TableUtils.AreaNotesIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AreaNotes_.Note field.
	/// </summary>
	public ColumnValue GetNoteValue()
	{
		return this.GetValue(TableUtils.NoteColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AreaNotes_.Note field.
	/// </summary>
	public string GetNoteFieldValue()
	{
		return this.GetValue(TableUtils.NoteColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AreaNotes_.Note field.
	/// </summary>
	public void SetNoteFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NoteColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AreaNotes_.Note field.
	/// </summary>
	public void SetNoteFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NoteColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AreaNotes_.AreaId field.
	/// </summary>
	public ColumnValue GetAreaIdValue()
	{
		return this.GetValue(TableUtils.AreaIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AreaNotes_.AreaId field.
	/// </summary>
	public Int32 GetAreaIdFieldValue()
	{
		return this.GetValue(TableUtils.AreaIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AreaNotes_.AreaId field.
	/// </summary>
	public void SetAreaIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AreaIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AreaNotes_.AreaId field.
	/// </summary>
	public void SetAreaIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.AreaIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AreaNotes_.AreaId field.
	/// </summary>
	public void SetAreaIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AreaIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AreaNotes_.AreaId field.
	/// </summary>
	public void SetAreaIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AreaIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AreaNotes_.AreaId field.
	/// </summary>
	public void SetAreaIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AreaIdColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's AreaNotes_.AreaNotesId field.
	/// </summary>
	public Int32 AreaNotesId
	{
		get
		{
			return this.GetValue(TableUtils.AreaNotesIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AreaNotesIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AreaNotesIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AreaNotesIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AreaNotes_.AreaNotesId field.
	/// </summary>
	public string AreaNotesIdDefault
	{
		get
		{
			return TableUtils.AreaNotesIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AreaNotes_.Note field.
	/// </summary>
	public string Note
	{
		get
		{
			return this.GetValue(TableUtils.NoteColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NoteColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NoteSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NoteColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AreaNotes_.Note field.
	/// </summary>
	public string NoteDefault
	{
		get
		{
			return TableUtils.NoteColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AreaNotes_.AreaId field.
	/// </summary>
	public Int32 AreaId
	{
		get
		{
			return this.GetValue(TableUtils.AreaIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AreaIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AreaIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AreaIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AreaNotes_.AreaId field.
	/// </summary>
	public string AreaIdDefault
	{
		get
		{
			return TableUtils.AreaIdColumn.DefaultValue;
		}
	}


#endregion
}

}
