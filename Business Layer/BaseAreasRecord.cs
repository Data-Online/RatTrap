// This class is "generated" and will be overwritten.
// Your customizations should be made in AreasRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="AreasRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="AreasTable"></see> class.
/// </remarks>
/// <seealso cref="AreasTable"></seealso>
/// <seealso cref="AreasRecord"></seealso>
public class BaseAreasRecord : PrimaryKeyRecord
{

	public readonly static AreasTable TableUtils = AreasTable.Instance;

	// Constructors
 
	protected BaseAreasRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.AreasRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.AreasRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.AreasRecord_ReadRecord); 
	}

	protected BaseAreasRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void AreasRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                AreasRecord AreasRec = (AreasRecord)sender;
        if(AreasRec != null && !AreasRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void AreasRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                AreasRecord AreasRec = (AreasRecord)sender;
        Validate_Inserting();
        if(AreasRec != null && !AreasRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void AreasRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                AreasRecord AreasRec = (AreasRecord)sender;
        Validate_Updating();
        if(AreasRec != null && !AreasRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Areas_.AreaId field.
	/// </summary>
	public ColumnValue GetAreaIdValue()
	{
		return this.GetValue(TableUtils.AreaIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Areas_.AreaId field.
	/// </summary>
	public Int32 GetAreaIdFieldValue()
	{
		return this.GetValue(TableUtils.AreaIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Areas_.Lat field.
	/// </summary>
	public ColumnValue GetLatValue()
	{
		return this.GetValue(TableUtils.LatColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Areas_.Lat field.
	/// </summary>
	public string GetLatFieldValue()
	{
		return this.GetValue(TableUtils.LatColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Areas_.Lat field.
	/// </summary>
	public void SetLatFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LatColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Areas_.Lat field.
	/// </summary>
	public void SetLatFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LatColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Areas_.Long field.
	/// </summary>
	public ColumnValue GetLong0Value()
	{
		return this.GetValue(TableUtils.Long0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Areas_.Long field.
	/// </summary>
	public string GetLong0FieldValue()
	{
		return this.GetValue(TableUtils.Long0Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Areas_.Long field.
	/// </summary>
	public void SetLong0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Long0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Areas_.Long field.
	/// </summary>
	public void SetLong0FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Long0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Areas_.Notes field.
	/// </summary>
	public ColumnValue GetNotesValue()
	{
		return this.GetValue(TableUtils.NotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Areas_.Notes field.
	/// </summary>
	public Int32 GetNotesFieldValue()
	{
		return this.GetValue(TableUtils.NotesColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Areas_.Notes field.
	/// </summary>
	public void SetNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Areas_.Notes field.
	/// </summary>
	public void SetNotesFieldValue(string val)
	{
		this.SetString(val, TableUtils.NotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Areas_.Notes field.
	/// </summary>
	public void SetNotesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Areas_.Notes field.
	/// </summary>
	public void SetNotesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Areas_.Notes field.
	/// </summary>
	public void SetNotesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NotesColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Areas_.AreaId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Areas_.AreaId field.
	/// </summary>
	public string AreaIdDefault
	{
		get
		{
			return TableUtils.AreaIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Areas_.Lat field.
	/// </summary>
	public string Lat
	{
		get
		{
			return this.GetValue(TableUtils.LatColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LatColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LatSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LatColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Areas_.Lat field.
	/// </summary>
	public string LatDefault
	{
		get
		{
			return TableUtils.LatColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Areas_.Long field.
	/// </summary>
	public string Long0
	{
		get
		{
			return this.GetValue(TableUtils.Long0Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Long0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Long0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Long0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Areas_.Long field.
	/// </summary>
	public string Long0Default
	{
		get
		{
			return TableUtils.Long0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Areas_.Notes field.
	/// </summary>
	public Int32 Notes
	{
		get
		{
			return this.GetValue(TableUtils.NotesColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Areas_.Notes field.
	/// </summary>
	public string NotesDefault
	{
		get
		{
			return TableUtils.NotesColumn.DefaultValue;
		}
	}


#endregion
}

}
