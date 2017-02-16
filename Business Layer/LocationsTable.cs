// This is a "safe" class, meaning that it is created once 
// and never overwritten. Any custom code you add to this class 
// will be preserved when you regenerate your application.
//
// Typical customizations that may be done in this class include
//  - adding custom event handlers
//  - overriding base class methods

using System;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace RatTrap.Business
{

/// <summary>
/// Provides access to the schema information and record data of a database table (or view).
/// See <see cref="BaseLocationsTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseLocationsTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseLocationsTable"></seealso>
/// <seealso cref="BaseLocationsSqlTable"></seealso>
/// <seealso cref="LocationsSqlTable"></seealso>
/// <seealso cref="LocationsDefinition"></seealso>
/// <seealso cref="LocationsRecord"></seealso>
/// <seealso cref="BaseLocationsRecord"></seealso>
[SerializableAttribute()]
public class LocationsTable : BaseLocationsTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="LocationsTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="LocationsTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="LocationsTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(LocationsTable_SerializationHelper)); //No other values need to be added
    }

#region "Class LocationsTable_SerializationHelper"

    [SerializableAttribute()]
    private class LocationsTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return LocationsTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="LocationsTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="LocationsTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static LocationsTable Instance = new LocationsTable();

    public LocationsTable()
    {
    }


} // End class LocationsTable

}
