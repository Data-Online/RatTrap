// This class is "generated" and will be overwritten.
// Your customizations should be made in TrapRecordsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="TrapRecordsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="TrapRecordsTable"></see> class.
/// </remarks>
/// <seealso cref="TrapRecordsTable"></seealso>
/// <seealso cref="TrapRecordsRecord"></seealso>
public class BaseTrapRecordsRecord : PrimaryKeyRecord
{

	public readonly static TrapRecordsTable TableUtils = TrapRecordsTable.Instance;

	// Constructors
 
	protected BaseTrapRecordsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.TrapRecordsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.TrapRecordsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.TrapRecordsRecord_ReadRecord); 
	}

	protected BaseTrapRecordsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void TrapRecordsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                TrapRecordsRecord TrapRecordsRec = (TrapRecordsRecord)sender;
        if(TrapRecordsRec != null && !TrapRecordsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void TrapRecordsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                TrapRecordsRecord TrapRecordsRec = (TrapRecordsRecord)sender;
        Validate_Inserting();
        if(TrapRecordsRec != null && !TrapRecordsRec.IsReadOnly ){
               TrapRecordsRec.Parse(EvaluateFormula("UserID()",this,null),TrapRecordsTable.CreatedBy);
       TrapRecordsRec.Parse(EvaluateFormula("Today()",this,null),TrapRecordsTable.CreatedOn);
        }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void TrapRecordsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                TrapRecordsRecord TrapRecordsRec = (TrapRecordsRecord)sender;
        Validate_Updating();
        if(TrapRecordsRec != null && !TrapRecordsRec.IsReadOnly ){
               TrapRecordsRec.Parse(EvaluateFormula("UserID()",this,null),TrapRecordsTable.UpdatedBy);
       TrapRecordsRec.Parse(EvaluateFormula("Today()",this,null),TrapRecordsTable.UpdatedOn);
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
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.TrapRecordId field.
	/// </summary>
	public ColumnValue GetTrapRecordIdValue()
	{
		return this.GetValue(TableUtils.TrapRecordIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.TrapRecordId field.
	/// </summary>
	public Int32 GetTrapRecordIdFieldValue()
	{
		return this.GetValue(TableUtils.TrapRecordIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.TrapId field.
	/// </summary>
	public ColumnValue GetTrapIdValue()
	{
		return this.GetValue(TableUtils.TrapIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.TrapId field.
	/// </summary>
	public Int32 GetTrapIdFieldValue()
	{
		return this.GetValue(TableUtils.TrapIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.TrapId field.
	/// </summary>
	public void SetTrapIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TrapIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.TrapId field.
	/// </summary>
	public void SetTrapIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.TrapIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.TrapId field.
	/// </summary>
	public void SetTrapIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.TrapId field.
	/// </summary>
	public void SetTrapIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.TrapId field.
	/// </summary>
	public void SetTrapIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.BaitType field.
	/// </summary>
	public ColumnValue GetBaitTypeValue()
	{
		return this.GetValue(TableUtils.BaitTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.BaitType field.
	/// </summary>
	public Int32 GetBaitTypeFieldValue()
	{
		return this.GetValue(TableUtils.BaitTypeColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.BaitType field.
	/// </summary>
	public void SetBaitTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BaitTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.BaitType field.
	/// </summary>
	public void SetBaitTypeFieldValue(string val)
	{
		this.SetString(val, TableUtils.BaitTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.BaitType field.
	/// </summary>
	public void SetBaitTypeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BaitTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.BaitType field.
	/// </summary>
	public void SetBaitTypeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BaitTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.BaitType field.
	/// </summary>
	public void SetBaitTypeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BaitTypeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.DateOfCheck field.
	/// </summary>
	public ColumnValue GetDateOfCheckValue()
	{
		return this.GetValue(TableUtils.DateOfCheckColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.DateOfCheck field.
	/// </summary>
	public DateTime GetDateOfCheckFieldValue()
	{
		return this.GetValue(TableUtils.DateOfCheckColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.DateOfCheck field.
	/// </summary>
	public void SetDateOfCheckFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DateOfCheckColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.DateOfCheck field.
	/// </summary>
	public void SetDateOfCheckFieldValue(string val)
	{
		this.SetString(val, TableUtils.DateOfCheckColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.DateOfCheck field.
	/// </summary>
	public void SetDateOfCheckFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DateOfCheckColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.Species field.
	/// </summary>
	public ColumnValue GetSpeciesValue()
	{
		return this.GetValue(TableUtils.SpeciesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.Species field.
	/// </summary>
	public Int32 GetSpeciesFieldValue()
	{
		return this.GetValue(TableUtils.SpeciesColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Species field.
	/// </summary>
	public void SetSpeciesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SpeciesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Species field.
	/// </summary>
	public void SetSpeciesFieldValue(string val)
	{
		this.SetString(val, TableUtils.SpeciesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Species field.
	/// </summary>
	public void SetSpeciesFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SpeciesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Species field.
	/// </summary>
	public void SetSpeciesFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SpeciesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Species field.
	/// </summary>
	public void SetSpeciesFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SpeciesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.Sex field.
	/// </summary>
	public ColumnValue GetSexValue()
	{
		return this.GetValue(TableUtils.SexColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.Sex field.
	/// </summary>
	public Int32 GetSexFieldValue()
	{
		return this.GetValue(TableUtils.SexColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Sex field.
	/// </summary>
	public void SetSexFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SexColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Sex field.
	/// </summary>
	public void SetSexFieldValue(string val)
	{
		this.SetString(val, TableUtils.SexColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Sex field.
	/// </summary>
	public void SetSexFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SexColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Sex field.
	/// </summary>
	public void SetSexFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SexColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Sex field.
	/// </summary>
	public void SetSexFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SexColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.Comment field.
	/// </summary>
	public ColumnValue GetCommentValue()
	{
		return this.GetValue(TableUtils.CommentColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.Comment field.
	/// </summary>
	public string GetCommentFieldValue()
	{
		return this.GetValue(TableUtils.CommentColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Comment field.
	/// </summary>
	public void SetCommentFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CommentColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Comment field.
	/// </summary>
	public void SetCommentFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CommentColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.LocationId field.
	/// </summary>
	public ColumnValue GetLocationIdValue()
	{
		return this.GetValue(TableUtils.LocationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.LocationId field.
	/// </summary>
	public Int32 GetLocationIdFieldValue()
	{
		return this.GetValue(TableUtils.LocationIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.LocationId field.
	/// </summary>
	public void SetLocationIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LocationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.LocationId field.
	/// </summary>
	public void SetLocationIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.LocationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.LocationId field.
	/// </summary>
	public void SetLocationIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LocationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.LocationId field.
	/// </summary>
	public void SetLocationIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LocationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.LocationId field.
	/// </summary>
	public void SetLocationIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LocationIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.ProjectId field.
	/// </summary>
	public ColumnValue GetProjectIdValue()
	{
		return this.GetValue(TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.ProjectId field.
	/// </summary>
	public Int32 GetProjectIdFieldValue()
	{
		return this.GetValue(TableUtils.ProjectIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjectIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.ProjectId field.
	/// </summary>
	public void SetProjectIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjectIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.GroupId field.
	/// </summary>
	public ColumnValue GetGroupIdValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.GroupId field.
	/// </summary>
	public Int32 GetGroupIdFieldValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.TrapTypeId field.
	/// </summary>
	public ColumnValue GetTrapTypeIdValue()
	{
		return this.GetValue(TableUtils.TrapTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.TrapTypeId field.
	/// </summary>
	public Int32 GetTrapTypeIdFieldValue()
	{
		return this.GetValue(TableUtils.TrapTypeIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.TrapTypeId field.
	/// </summary>
	public void SetTrapTypeIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TrapTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.TrapTypeId field.
	/// </summary>
	public void SetTrapTypeIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.TrapTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.TrapTypeId field.
	/// </summary>
	public void SetTrapTypeIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.TrapTypeId field.
	/// </summary>
	public void SetTrapTypeIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.TrapTypeId field.
	/// </summary>
	public void SetTrapTypeIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrapTypeIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.UserId field.
	/// </summary>
	public ColumnValue GetUserId0Value()
	{
		return this.GetValue(TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.UserId field.
	/// </summary>
	public Int32 GetUserId0FieldValue()
	{
		return this.GetValue(TableUtils.UserId0Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(string val)
	{
		this.SetString(val, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UserId field.
	/// </summary>
	public void SetUserId0FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.UpdatedBy field.
	/// </summary>
	public ColumnValue GetUpdatedByValue()
	{
		return this.GetValue(TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.UpdatedBy field.
	/// </summary>
	public Int32 GetUpdatedByFieldValue()
	{
		return this.GetValue(TableUtils.UpdatedByColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(string val)
	{
		this.SetString(val, TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UpdatedByColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.UpdatedOn field.
	/// </summary>
	public ColumnValue GetUpdatedOnValue()
	{
		return this.GetValue(TableUtils.UpdatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.UpdatedOn field.
	/// </summary>
	public DateTime GetUpdatedOnFieldValue()
	{
		return this.GetValue(TableUtils.UpdatedOnColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UpdatedOn field.
	/// </summary>
	public void SetUpdatedOnFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UpdatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UpdatedOn field.
	/// </summary>
	public void SetUpdatedOnFieldValue(string val)
	{
		this.SetString(val, TableUtils.UpdatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UpdatedOn field.
	/// </summary>
	public void SetUpdatedOnFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UpdatedOnColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.CreatedBy field.
	/// </summary>
	public ColumnValue GetCreatedByValue()
	{
		return this.GetValue(TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.CreatedBy field.
	/// </summary>
	public Int32 GetCreatedByFieldValue()
	{
		return this.GetValue(TableUtils.CreatedByColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(string val)
	{
		this.SetString(val, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedByColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.CreatedOn field.
	/// </summary>
	public ColumnValue GetCreatedOnValue()
	{
		return this.GetValue(TableUtils.CreatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TrapRecords_.CreatedOn field.
	/// </summary>
	public DateTime GetCreatedOnFieldValue()
	{
		return this.GetValue(TableUtils.CreatedOnColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.CreatedOn field.
	/// </summary>
	public void SetCreatedOnFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CreatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.CreatedOn field.
	/// </summary>
	public void SetCreatedOnFieldValue(string val)
	{
		this.SetString(val, TableUtils.CreatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.CreatedOn field.
	/// </summary>
	public void SetCreatedOnFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedOnColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.TrapRecordId field.
	/// </summary>
	public Int32 TrapRecordId
	{
		get
		{
			return this.GetValue(TableUtils.TrapRecordIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TrapRecordIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TrapRecordIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TrapRecordIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.TrapRecordId field.
	/// </summary>
	public string TrapRecordIdDefault
	{
		get
		{
			return TableUtils.TrapRecordIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.TrapId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.TrapId field.
	/// </summary>
	public string TrapIdDefault
	{
		get
		{
			return TableUtils.TrapIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.BaitType field.
	/// </summary>
	public Int32 BaitType
	{
		get
		{
			return this.GetValue(TableUtils.BaitTypeColumn).ToInt32();
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.BaitType field.
	/// </summary>
	public string BaitTypeDefault
	{
		get
		{
			return TableUtils.BaitTypeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.DateOfCheck field.
	/// </summary>
	public DateTime DateOfCheck
	{
		get
		{
			return this.GetValue(TableUtils.DateOfCheckColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DateOfCheckColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DateOfCheckSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DateOfCheckColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.DateOfCheck field.
	/// </summary>
	public string DateOfCheckDefault
	{
		get
		{
			return TableUtils.DateOfCheckColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.Species field.
	/// </summary>
	public Int32 Species
	{
		get
		{
			return this.GetValue(TableUtils.SpeciesColumn).ToInt32();
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Species field.
	/// </summary>
	public string SpeciesDefault
	{
		get
		{
			return TableUtils.SpeciesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.Sex field.
	/// </summary>
	public Int32 Sex
	{
		get
		{
			return this.GetValue(TableUtils.SexColumn).ToInt32();
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Sex field.
	/// </summary>
	public string SexDefault
	{
		get
		{
			return TableUtils.SexColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.Comment field.
	/// </summary>
	public string Comment
	{
		get
		{
			return this.GetValue(TableUtils.CommentColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CommentColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CommentSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CommentColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.Comment field.
	/// </summary>
	public string CommentDefault
	{
		get
		{
			return TableUtils.CommentColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.LocationId field.
	/// </summary>
	public Int32 LocationId
	{
		get
		{
			return this.GetValue(TableUtils.LocationIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LocationIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LocationIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LocationIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.LocationId field.
	/// </summary>
	public string LocationIdDefault
	{
		get
		{
			return TableUtils.LocationIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.ProjectId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.ProjectId field.
	/// </summary>
	public string ProjectIdDefault
	{
		get
		{
			return TableUtils.ProjectIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.GroupId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.GroupId field.
	/// </summary>
	public string GroupIdDefault
	{
		get
		{
			return TableUtils.GroupIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.TrapTypeId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.TrapTypeId field.
	/// </summary>
	public string TrapTypeIdDefault
	{
		get
		{
			return TableUtils.TrapTypeIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.UserId field.
	/// </summary>
	public Int32 UserId0
	{
		get
		{
			return this.GetValue(TableUtils.UserId0Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UserId0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UserId0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UserId0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UserId field.
	/// </summary>
	public string UserId0Default
	{
		get
		{
			return TableUtils.UserId0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.UpdatedBy field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UpdatedBy field.
	/// </summary>
	public string UpdatedByDefault
	{
		get
		{
			return TableUtils.UpdatedByColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.UpdatedOn field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.UpdatedOn field.
	/// </summary>
	public string UpdatedOnDefault
	{
		get
		{
			return TableUtils.UpdatedOnColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.CreatedBy field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.CreatedBy field.
	/// </summary>
	public string CreatedByDefault
	{
		get
		{
			return TableUtils.CreatedByColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TrapRecords_.CreatedOn field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TrapRecords_.CreatedOn field.
	/// </summary>
	public string CreatedOnDefault
	{
		get
		{
			return TableUtils.CreatedOnColumn.DefaultValue;
		}
	}


#endregion
}

}
