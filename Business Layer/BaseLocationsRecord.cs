// This class is "generated" and will be overwritten.
// Your customizations should be made in LocationsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// The generated superclass for the <see cref="LocationsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="LocationsTable"></see> class.
/// </remarks>
/// <seealso cref="LocationsTable"></seealso>
/// <seealso cref="LocationsRecord"></seealso>
public class BaseLocationsRecord : PrimaryKeyRecord
{

	public readonly static LocationsTable TableUtils = LocationsTable.Instance;

	// Constructors
 
	protected BaseLocationsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.LocationsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.LocationsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.LocationsRecord_ReadRecord); 
	}

	protected BaseLocationsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void LocationsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                LocationsRecord LocationsRec = (LocationsRecord)sender;
        if(LocationsRec != null && !LocationsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void LocationsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                LocationsRecord LocationsRec = (LocationsRecord)sender;
        Validate_Inserting();
        if(LocationsRec != null && !LocationsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void LocationsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                LocationsRecord LocationsRec = (LocationsRecord)sender;
        Validate_Updating();
        if(LocationsRec != null && !LocationsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Locations_.LocationId field.
	/// </summary>
	public ColumnValue GetLocationIdValue()
	{
		return this.GetValue(TableUtils.LocationIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.LocationId field.
	/// </summary>
	public Int32 GetLocationIdFieldValue()
	{
		return this.GetValue(TableUtils.LocationIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.Lat field.
	/// </summary>
	public ColumnValue GetLatValue()
	{
		return this.GetValue(TableUtils.LatColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.Lat field.
	/// </summary>
	public Int32 GetLatFieldValue()
	{
		return this.GetValue(TableUtils.LatColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Lat field.
	/// </summary>
	public void SetLatFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LatColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Lat field.
	/// </summary>
	public void SetLatFieldValue(string val)
	{
		this.SetString(val, TableUtils.LatColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Lat field.
	/// </summary>
	public void SetLatFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LatColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Lat field.
	/// </summary>
	public void SetLatFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LatColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Lat field.
	/// </summary>
	public void SetLatFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LatColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.Long field.
	/// </summary>
	public ColumnValue GetLong0Value()
	{
		return this.GetValue(TableUtils.Long0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.Long field.
	/// </summary>
	public Int32 GetLong0FieldValue()
	{
		return this.GetValue(TableUtils.Long0Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Long field.
	/// </summary>
	public void SetLong0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Long0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Long field.
	/// </summary>
	public void SetLong0FieldValue(string val)
	{
		this.SetString(val, TableUtils.Long0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Long field.
	/// </summary>
	public void SetLong0FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Long0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Long field.
	/// </summary>
	public void SetLong0FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Long0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Long field.
	/// </summary>
	public void SetLong0FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Long0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.Description field.
	/// </summary>
	public ColumnValue GetDescriptionValue()
	{
		return this.GetValue(TableUtils.DescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.Description field.
	/// </summary>
	public string GetDescriptionFieldValue()
	{
		return this.GetValue(TableUtils.DescriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Description field.
	/// </summary>
	public void SetDescriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Description field.
	/// </summary>
	public void SetDescriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DescriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.GroupId field.
	/// </summary>
	public ColumnValue GetGroupIdValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.GroupId field.
	/// </summary>
	public Int32 GetGroupIdFieldValue()
	{
		return this.GetValue(TableUtils.GroupIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.GroupId field.
	/// </summary>
	public void SetGroupIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GroupIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.Latitude field.
	/// </summary>
	public ColumnValue GetLatitudeValue()
	{
		return this.GetValue(TableUtils.LatitudeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.Latitude field.
	/// </summary>
	public Decimal GetLatitudeFieldValue()
	{
		return this.GetValue(TableUtils.LatitudeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Latitude field.
	/// </summary>
	public void SetLatitudeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LatitudeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Latitude field.
	/// </summary>
	public void SetLatitudeFieldValue(string val)
	{
		this.SetString(val, TableUtils.LatitudeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Latitude field.
	/// </summary>
	public void SetLatitudeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LatitudeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Latitude field.
	/// </summary>
	public void SetLatitudeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LatitudeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Latitude field.
	/// </summary>
	public void SetLatitudeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LatitudeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.Longitude field.
	/// </summary>
	public ColumnValue GetLongitudeValue()
	{
		return this.GetValue(TableUtils.LongitudeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.Longitude field.
	/// </summary>
	public Decimal GetLongitudeFieldValue()
	{
		return this.GetValue(TableUtils.LongitudeColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Longitude field.
	/// </summary>
	public void SetLongitudeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LongitudeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Longitude field.
	/// </summary>
	public void SetLongitudeFieldValue(string val)
	{
		this.SetString(val, TableUtils.LongitudeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Longitude field.
	/// </summary>
	public void SetLongitudeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LongitudeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Longitude field.
	/// </summary>
	public void SetLongitudeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LongitudeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Longitude field.
	/// </summary>
	public void SetLongitudeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LongitudeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.Address field.
	/// </summary>
	public ColumnValue GetAddressValue()
	{
		return this.GetValue(TableUtils.AddressColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Locations_.Address field.
	/// </summary>
	public string GetAddressFieldValue()
	{
		return this.GetValue(TableUtils.AddressColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Address field.
	/// </summary>
	public void SetAddressFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AddressColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Address field.
	/// </summary>
	public void SetAddressFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AddressColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Locations_.LocationId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.LocationId field.
	/// </summary>
	public string LocationIdDefault
	{
		get
		{
			return TableUtils.LocationIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Locations_.Lat field.
	/// </summary>
	public Int32 Lat
	{
		get
		{
			return this.GetValue(TableUtils.LatColumn).ToInt32();
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
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Lat field.
	/// </summary>
	public string LatDefault
	{
		get
		{
			return TableUtils.LatColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Locations_.Long field.
	/// </summary>
	public Int32 Long0
	{
		get
		{
			return this.GetValue(TableUtils.Long0Column).ToInt32();
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
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Long field.
	/// </summary>
	public string Long0Default
	{
		get
		{
			return TableUtils.Long0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Locations_.Description field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Description field.
	/// </summary>
	public string DescriptionDefault
	{
		get
		{
			return TableUtils.DescriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Locations_.GroupId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.GroupId field.
	/// </summary>
	public string GroupIdDefault
	{
		get
		{
			return TableUtils.GroupIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Locations_.Latitude field.
	/// </summary>
	public Decimal Latitude
	{
		get
		{
			return this.GetValue(TableUtils.LatitudeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LatitudeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LatitudeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LatitudeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Latitude field.
	/// </summary>
	public string LatitudeDefault
	{
		get
		{
			return TableUtils.LatitudeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Locations_.Longitude field.
	/// </summary>
	public Decimal Longitude
	{
		get
		{
			return this.GetValue(TableUtils.LongitudeColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LongitudeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LongitudeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LongitudeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Longitude field.
	/// </summary>
	public string LongitudeDefault
	{
		get
		{
			return TableUtils.LongitudeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Locations_.Address field.
	/// </summary>
	public string Address
	{
		get
		{
			return this.GetValue(TableUtils.AddressColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AddressColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AddressSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AddressColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Locations_.Address field.
	/// </summary>
	public string AddressDefault
	{
		get
		{
			return TableUtils.AddressColumn.DefaultValue;
		}
	}


#endregion
}

}
