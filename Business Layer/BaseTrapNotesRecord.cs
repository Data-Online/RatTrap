// This class is "generated" and will be overwritten.
// Your customizations should be made in TrapNotesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="TrapNotesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="TrapNotesTable"></see> class.
/// </remarks>
/// <seealso cref="TrapNotesTable"></seealso>
/// <seealso cref="TrapNotesRecord"></seealso>
public class BaseTrapNotesRecord : PrimaryKeyRecord
{

	public readonly static TrapNotesTable TableUtils = TrapNotesTable.Instance;

	// Constructors
 
	protected BaseTrapNotesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.TrapNotesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.TrapNotesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.TrapNotesRecord_ReadRecord); 
	}

	protected BaseTrapNotesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void TrapNotesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                TrapNotesRecord TrapNotesRec = (TrapNotesRecord)sender;
        if(TrapNotesRec != null && !TrapNotesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void TrapNotesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                TrapNotesRecord TrapNotesRec = (TrapNotesRecord)sender;
        Validate_Inserting();
        if(TrapNotesRec != null && !TrapNotesRec.IsReadOnly ){
               TrapNotesRec.Parse(EvaluateFormula("UserID()",this,null),TrapNotesTable.CreatedBy);
       TrapNotesRec.Parse(EvaluateFormula("Today()",this,null),TrapNotesTable.CreatedOn);
        }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void TrapNotesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                TrapNotesRecord TrapNotesRec = (TrapNotesRecord)sender;
        Validate_Updating();
        if(TrapNotesRec != null && !TrapNotesRec.IsReadOnly ){
               TrapNotesRec.Parse(EvaluateFormula("UserID()",this,null),TrapNotesTable.UpdatedBy);
       TrapNotesRec.Parse(EvaluateFormula("Today()",this,null),TrapNotesTable.UpdatedOn);
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
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.NoteId field.
	/// </summary>
	public ColumnValue GetNoteIdValue()
	{
		return this.GetValue(TableUtils.NoteIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.NoteId field.
	/// </summary>
	public Int32 GetNoteIdFieldValue()
	{
		return this.GetValue(TableUtils.NoteIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.TrapId field.
	/// </summary>
	public ColumnValue GetTrapIdValue()
	{
		return this.GetValue(TableUtils.TrapIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.TrapId field.
	/// </summary>
	public Int32 GetTrapIdFieldValue()
	{
		return this.GetValue(TableUtils.TrapIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.TrapId field.
	/// </summary>
	public void SetTrapIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TrapIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.TrapId field.
	/// </summary>
	public void SetTrapIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.TrapIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.TrapId field.
	/// </summary>
	public void SetTrapIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.TrapId field.
	/// </summary>
	public void SetTrapIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.TrapId field.
	/// </summary>
	public void SetTrapIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.Note field.
	/// </summary>
	public ColumnValue GetNoteValue()
	{
		return this.GetValue(TableUtils.NoteColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.Note field.
	/// </summary>
	public string GetNoteFieldValue()
	{
		return this.GetValue(TableUtils.NoteColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.Note field.
	/// </summary>
	public void SetNoteFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NoteColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.Note field.
	/// </summary>
	public void SetNoteFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NoteColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.CreatedBy field.
	/// </summary>
	public ColumnValue GetCreatedByValue()
	{
		return this.GetValue(TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.CreatedBy field.
	/// </summary>
	public Int32 GetCreatedByFieldValue()
	{
		return this.GetValue(TableUtils.CreatedByColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(string val)
	{
		this.SetString(val, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedByColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.CreatedOn field.
	/// </summary>
	public ColumnValue GetCreatedOnValue()
	{
		return this.GetValue(TableUtils.CreatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.CreatedOn field.
	/// </summary>
	public DateTime GetCreatedOnFieldValue()
	{
		return this.GetValue(TableUtils.CreatedOnColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.CreatedOn field.
	/// </summary>
	public void SetCreatedOnFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CreatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.CreatedOn field.
	/// </summary>
	public void SetCreatedOnFieldValue(string val)
	{
		this.SetString(val, TableUtils.CreatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.CreatedOn field.
	/// </summary>
	public void SetCreatedOnFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedOnColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.UpdatedBy field.
	/// </summary>
	public ColumnValue GetUpdatedByValue()
	{
		return this.GetValue(TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.UpdatedBy field.
	/// </summary>
	public Int32 GetUpdatedByFieldValue()
	{
		return this.GetValue(TableUtils.UpdatedByColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(string val)
	{
		this.SetString(val, TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UpdatedByColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.UpdatedOn field.
	/// </summary>
	public ColumnValue GetUpdatedOnValue()
	{
		return this.GetValue(TableUtils.UpdatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapNotes_.UpdatedOn field.
	/// </summary>
	public DateTime GetUpdatedOnFieldValue()
	{
		return this.GetValue(TableUtils.UpdatedOnColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.UpdatedOn field.
	/// </summary>
	public void SetUpdatedOnFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UpdatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.UpdatedOn field.
	/// </summary>
	public void SetUpdatedOnFieldValue(string val)
	{
		this.SetString(val, TableUtils.UpdatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.UpdatedOn field.
	/// </summary>
	public void SetUpdatedOnFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UpdatedOnColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapNotes_.NoteId field.
	/// </summary>
	public Int32 NoteId
	{
		get
		{
			return this.GetValue(TableUtils.NoteIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NoteIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NoteIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NoteIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.NoteId field.
	/// </summary>
	public string NoteIdDefault
	{
		get
		{
			return TableUtils.NoteIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapNotes_.TrapId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.TrapId field.
	/// </summary>
	public string TrapIdDefault
	{
		get
		{
			return TableUtils.TrapIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapNotes_.Note field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.Note field.
	/// </summary>
	public string NoteDefault
	{
		get
		{
			return TableUtils.NoteColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapNotes_.CreatedBy field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.CreatedBy field.
	/// </summary>
	public string CreatedByDefault
	{
		get
		{
			return TableUtils.CreatedByColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapNotes_.CreatedOn field.
	/// </summary>
	public DateTime CreatedOn
	{
		get
		{
			return this.GetValue(TableUtils.CreatedOnColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CreatedOnColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CreatedOnSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CreatedOnColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.CreatedOn field.
	/// </summary>
	public string CreatedOnDefault
	{
		get
		{
			return TableUtils.CreatedOnColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapNotes_.UpdatedBy field.
	/// </summary>
	public Int32 UpdatedBy
	{
		get
		{
			return this.GetValue(TableUtils.UpdatedByColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UpdatedByColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UpdatedBySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UpdatedByColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.UpdatedBy field.
	/// </summary>
	public string UpdatedByDefault
	{
		get
		{
			return TableUtils.UpdatedByColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapNotes_.UpdatedOn field.
	/// </summary>
	public DateTime UpdatedOn
	{
		get
		{
			return this.GetValue(TableUtils.UpdatedOnColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UpdatedOnColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UpdatedOnSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UpdatedOnColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapNotes_.UpdatedOn field.
	/// </summary>
	public string UpdatedOnDefault
	{
		get
		{
			return TableUtils.UpdatedOnColumn.DefaultValue;
		}
	}


#endregion
}

}
