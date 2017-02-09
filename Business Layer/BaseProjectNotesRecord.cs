﻿// This class is "generated" and will be overwritten.
// Your customizations should be made in ProjectNotesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="ProjectNotesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ProjectNotesTable"></see> class.
/// </remarks>
/// <seealso cref="ProjectNotesTable"></seealso>
/// <seealso cref="ProjectNotesRecord"></seealso>
public class BaseProjectNotesRecord : PrimaryKeyRecord
{

	public readonly static ProjectNotesTable TableUtils = ProjectNotesTable.Instance;

	// Constructors
 
	protected BaseProjectNotesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ProjectNotesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ProjectNotesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ProjectNotesRecord_ReadRecord); 
	}

	protected BaseProjectNotesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ProjectNotesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ProjectNotesRecord ProjectNotesRec = (ProjectNotesRecord)sender;
        if(ProjectNotesRec != null && !ProjectNotesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ProjectNotesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ProjectNotesRecord ProjectNotesRec = (ProjectNotesRecord)sender;
        Validate_Inserting();
        if(ProjectNotesRec != null && !ProjectNotesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ProjectNotesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ProjectNotesRecord ProjectNotesRec = (ProjectNotesRecord)sender;
        Validate_Updating();
        if(ProjectNotesRec != null && !ProjectNotesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's ProjectNotes_.ProjectNotesId field.
	/// </summary>
	public ColumnValue GetProjectNotesIdValue()
	{
		return this.GetValue(TableUtils.ProjectNotesIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ProjectNotes_.ProjectNotesId field.
	/// </summary>
	public Int32 GetProjectNotesIdFieldValue()
	{
		return this.GetValue(TableUtils.ProjectNotesIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ProjectNotes_.Note field.
	/// </summary>
	public ColumnValue GetNoteValue()
	{
		return this.GetValue(TableUtils.NoteColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ProjectNotes_.Note field.
	/// </summary>
	public string GetNoteFieldValue()
	{
		return this.GetValue(TableUtils.NoteColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectNotes_.Note field.
	/// </summary>
	public void SetNoteFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NoteColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectNotes_.Note field.
	/// </summary>
	public void SetNoteFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NoteColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ProjectNotes_.ProjectId field.
	/// </summary>
	public ColumnValue GetProjectIdValue()
	{
		return this.GetValue(TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ProjectNotes_.ProjectId field.
	/// </summary>
	public Int32 GetProjectIdFieldValue()
	{
		return this.GetValue(TableUtils.ProjectIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectNotes_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectNotes_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectNotes_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectNotes_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectNotes_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjectIdColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's ProjectNotes_.ProjectNotesId field.
	/// </summary>
	public Int32 ProjectNotesId
	{
		get
		{
			return this.GetValue(TableUtils.ProjectNotesIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProjectNotesIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProjectNotesIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProjectNotesIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectNotes_.ProjectNotesId field.
	/// </summary>
	public string ProjectNotesIdDefault
	{
		get
		{
			return TableUtils.ProjectNotesIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ProjectNotes_.Note field.
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
	/// This is a convenience method that allows direct modification of the value of the record's ProjectNotes_.Note field.
	/// </summary>
	public string NoteDefault
	{
		get
		{
			return TableUtils.NoteColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ProjectNotes_.ProjectId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's ProjectNotes_.ProjectId field.
	/// </summary>
	public string ProjectIdDefault
	{
		get
		{
			return TableUtils.ProjectIdColumn.DefaultValue;
		}
	}


#endregion
}

}
