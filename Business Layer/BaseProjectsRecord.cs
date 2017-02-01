// This class is "generated" and will be overwritten.
// Your customizations should be made in ProjectsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="ProjectsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ProjectsTable"></see> class.
/// </remarks>
/// <seealso cref="ProjectsTable"></seealso>
/// <seealso cref="ProjectsRecord"></seealso>
public class BaseProjectsRecord : PrimaryKeyRecord
{

	public readonly static ProjectsTable TableUtils = ProjectsTable.Instance;

	// Constructors
 
	protected BaseProjectsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ProjectsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ProjectsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ProjectsRecord_ReadRecord); 
	}

	protected BaseProjectsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ProjectsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ProjectsRecord ProjectsRec = (ProjectsRecord)sender;
        if(ProjectsRec != null && !ProjectsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ProjectsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ProjectsRecord ProjectsRec = (ProjectsRecord)sender;
        Validate_Inserting();
        if(ProjectsRec != null && !ProjectsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ProjectsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ProjectsRecord ProjectsRec = (ProjectsRecord)sender;
        Validate_Updating();
        if(ProjectsRec != null && !ProjectsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Projects_.ProjectId field.
	/// </summary>
	public ColumnValue GetProjectIdValue()
	{
		return this.GetValue(TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Projects_.ProjectId field.
	/// </summary>
	public Int32 GetProjectIdFieldValue()
	{
		return this.GetValue(TableUtils.ProjectIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Projects_.Description field.
	/// </summary>
	public ColumnValue GetDescriptionValue()
	{
		return this.GetValue(TableUtils.DescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Projects_.Description field.
	/// </summary>
	public string GetDescriptionFieldValue()
	{
		return this.GetValue(TableUtils.DescriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Projects_.Description field.
	/// </summary>
	public void SetDescriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Projects_.Description field.
	/// </summary>
	public void SetDescriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DescriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Projects_.AreaId field.
	/// </summary>
	public ColumnValue GetAreaIdValue()
	{
		return this.GetValue(TableUtils.AreaIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Projects_.AreaId field.
	/// </summary>
	public Int32 GetAreaIdFieldValue()
	{
		return this.GetValue(TableUtils.AreaIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Projects_.AreaId field.
	/// </summary>
	public void SetAreaIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AreaIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Projects_.AreaId field.
	/// </summary>
	public void SetAreaIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.AreaIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Projects_.AreaId field.
	/// </summary>
	public void SetAreaIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AreaIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Projects_.AreaId field.
	/// </summary>
	public void SetAreaIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AreaIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Projects_.AreaId field.
	/// </summary>
	public void SetAreaIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AreaIdColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Projects_.ProjectId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Projects_.ProjectId field.
	/// </summary>
	public string ProjectIdDefault
	{
		get
		{
			return TableUtils.ProjectIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Projects_.Description field.
	/// </summary>
	public string Description
	{
		get
		{
			return this.GetValue(TableUtils.DescriptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DescriptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DescriptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DescriptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Projects_.Description field.
	/// </summary>
	public string DescriptionDefault
	{
		get
		{
			return TableUtils.DescriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Projects_.AreaId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Projects_.AreaId field.
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
