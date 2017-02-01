// This class is "generated" and will be overwritten.
// Your customizations should be made in ProjectsGroupsLinkRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="ProjectsGroupsLinkRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ProjectsGroupsLinkTable"></see> class.
/// </remarks>
/// <seealso cref="ProjectsGroupsLinkTable"></seealso>
/// <seealso cref="ProjectsGroupsLinkRecord"></seealso>
public class BaseProjectsGroupsLinkRecord : PrimaryKeyRecord
{

	public readonly static ProjectsGroupsLinkTable TableUtils = ProjectsGroupsLinkTable.Instance;

	// Constructors
 
	protected BaseProjectsGroupsLinkRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ProjectsGroupsLinkRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ProjectsGroupsLinkRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ProjectsGroupsLinkRecord_ReadRecord); 
	}

	protected BaseProjectsGroupsLinkRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ProjectsGroupsLinkRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ProjectsGroupsLinkRecord ProjectsGroupsLinkRec = (ProjectsGroupsLinkRecord)sender;
        if(ProjectsGroupsLinkRec != null && !ProjectsGroupsLinkRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ProjectsGroupsLinkRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ProjectsGroupsLinkRecord ProjectsGroupsLinkRec = (ProjectsGroupsLinkRecord)sender;
        Validate_Inserting();
        if(ProjectsGroupsLinkRec != null && !ProjectsGroupsLinkRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ProjectsGroupsLinkRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ProjectsGroupsLinkRecord ProjectsGroupsLinkRec = (ProjectsGroupsLinkRecord)sender;
        Validate_Updating();
        if(ProjectsGroupsLinkRec != null && !ProjectsGroupsLinkRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's ProjectsGroupsLink_.ProjectsGroupsLink field.
	/// </summary>
	public ColumnValue GetProjectsGroupsLinkValue()
	{
		return this.GetValue(TableUtils.ProjectsGroupsLinkColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ProjectsGroupsLink_.ProjectsGroupsLink field.
	/// </summary>
	public Int32 GetProjectsGroupsLinkFieldValue()
	{
		return this.GetValue(TableUtils.ProjectsGroupsLinkColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ProjectsGroupsLink_.GroupId field.
	/// </summary>
	public ColumnValue GetGroupIdValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ProjectsGroupsLink_.GroupId field.
	/// </summary>
	public Int32 GetGroupIdFieldValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectsGroupsLink_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectsGroupsLink_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectsGroupsLink_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectsGroupsLink_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectsGroupsLink_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ProjectsGroupsLink_.ProjectId field.
	/// </summary>
	public ColumnValue GetProjectIdValue()
	{
		return this.GetValue(TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ProjectsGroupsLink_.ProjectId field.
	/// </summary>
	public Int32 GetProjectIdFieldValue()
	{
		return this.GetValue(TableUtils.ProjectIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectsGroupsLink_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectsGroupsLink_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectsGroupsLink_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectsGroupsLink_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectsGroupsLink_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjectIdColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's ProjectsGroupsLink_.ProjectsGroupsLink field.
	/// </summary>
	public Int32 ProjectsGroupsLink
	{
		get
		{
			return this.GetValue(TableUtils.ProjectsGroupsLinkColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProjectsGroupsLinkColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProjectsGroupsLinkSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProjectsGroupsLinkColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ProjectsGroupsLink_.ProjectsGroupsLink field.
	/// </summary>
	public string ProjectsGroupsLinkDefault
	{
		get
		{
			return TableUtils.ProjectsGroupsLinkColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ProjectsGroupsLink_.GroupId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's ProjectsGroupsLink_.GroupId field.
	/// </summary>
	public string GroupIdDefault
	{
		get
		{
			return TableUtils.GroupIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ProjectsGroupsLink_.ProjectId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's ProjectsGroupsLink_.ProjectId field.
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
