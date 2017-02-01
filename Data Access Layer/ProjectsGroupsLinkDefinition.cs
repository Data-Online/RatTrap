using System;

namespace RatTrap.Business
{

/// <summary>
/// Contains embedded schema and configuration data that is used by the 
/// <see cref="ProjectsGroupsLinkTable">RatTrap.ProjectsGroupsLinkTable</see> class
/// to initialize the class's TableDefinition.
/// </summary>
/// <seealso cref="ProjectsGroupsLinkTable"></seealso>
public class ProjectsGroupsLinkDefinition
{
#region "Definition (XML) for ProjectsGroupsLinkDefinition table"
	//Next 117 lines contain Table Definition (XML) for table "ProjectsGroupsLinkDefinition"
	private static string _DefinitionString = "";
	
#endregion

	/// <summary>
	/// Gets the embedded schema and configuration data for the  
	/// <see cref="ProjectsGroupsLinkTable"></see>
	/// class's TableDefinition.
	/// </summary>
	/// <remarks>This function is only called once at runtime.</remarks>
	/// <returns>An XML string.</returns>
	public static string GetXMLString()
	{
		if(_DefinitionString == "")
		{
			         System.Text.StringBuilder tbf = new System.Text.StringBuilder();
         tbf.Append(@"<XMLDefinition Generator=""Iron Speed Designer"" Version=""12.2"" Type=""GENERIC"">");
         tbf.Append(  @"<ColumnDefinition>");
         tbf.Append(    @"<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">");
         tbf.Append(      @"<columnName>ProjectsGroupsLink</columnName>");
         tbf.Append(      @"<columnUIName>Projects Groups Link</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>Y</columnIndex>");
         tbf.Append(      @"<columnUnique>Y</columnUnique>");
         tbf.Append(      @"<columnFunction>notrim</columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>Y</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed>Y</columnComputed>");
         tbf.Append(      @"<columnIdentity>Y</columnIdentity>");
         tbf.Append(      @"<columnReadOnly>Y</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>Y</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive>N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">");
         tbf.Append(      @"<columnName>GroupId</columnName>");
         tbf.Append(      @"<columnUIName>Group</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction>notrim</columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>N</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed>N</columnComputed>");
         tbf.Append(      @"<columnIdentity>N</columnIdentity>");
         tbf.Append(      @"<columnReadOnly>N</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>N</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive>N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(      @"<foreignKey>");
         tbf.Append(        @"<columnFKName>FK_ProjectsGroupsLink_Groups</columnFKName>");
         tbf.Append(        @"<columnFKTable>RatTrap.Business.GroupsTable, RatTrap.Business</columnFKTable>");
         tbf.Append(        @"<columnFKOwner>dbo</columnFKOwner>");
         tbf.Append(        @"<columnFKColumn>GroupId</columnFKColumn>");
         tbf.Append(        @"<columnFKColumnDisplay>GroupName</columnFKColumnDisplay>");
         tbf.Append(        @"<foreignKeyType>Explicit</foreignKeyType>");
         tbf.Append(      "</foreignKey>");
         tbf.Append(      @"<applyDFKA>Y</applyDFKA>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">");
         tbf.Append(      @"<columnName>ProjectId</columnName>");
         tbf.Append(      @"<columnUIName>Project</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction>notrim</columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>N</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed>N</columnComputed>");
         tbf.Append(      @"<columnIdentity>N</columnIdentity>");
         tbf.Append(      @"<columnReadOnly>N</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>N</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive>N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(      @"<foreignKey>");
         tbf.Append(        @"<columnFKName>FK_ProjectsGroupsLink_Projects</columnFKName>");
         tbf.Append(        @"<columnFKTable>RatTrap.Business.ProjectsTable, RatTrap.Business</columnFKTable>");
         tbf.Append(        @"<columnFKOwner>dbo</columnFKOwner>");
         tbf.Append(        @"<columnFKColumn>ProjectId</columnFKColumn>");
         tbf.Append(        @"<columnFKColumnDisplay>Description</columnFKColumnDisplay>");
         tbf.Append(        @"<foreignKeyType>Explicit</foreignKeyType>");
         tbf.Append(      "</foreignKey>");
         tbf.Append(      @"<applyDFKA>Y</applyDFKA>");
         tbf.Append(    "</Column>");
         tbf.Append(  "</ColumnDefinition>");
         tbf.Append(  @"<TableName>ProjectsGroupsLink</TableName>");
         tbf.Append(  @"<Version></Version>");
         tbf.Append(  @"<Owner>dbo</Owner>");
         tbf.Append(  @"<TableAliasName>ProjectsGroupsLink_</TableAliasName>");
         tbf.Append(  @"<ConnectionName>DatabaseTheRatTrap</ConnectionName>");
         tbf.Append(  @"<PagingMethod>RowNum</PagingMethod>");
         tbf.Append(  @"<canCreateRecords Source=""Database"">Y</canCreateRecords>");
         tbf.Append(  @"<canEditRecords Source=""Database"">Y</canEditRecords>");
         tbf.Append(  @"<canDeleteRecords Source=""Database"">Y</canDeleteRecords>");
         tbf.Append(  @"<canViewRecords Source=""Database"">Y</canViewRecords>");
         tbf.Append(  @"<ConcurrencyMethod>BinaryChecksum</ConcurrencyMethod>");
         tbf.Append(  @"<AppShortName>RatTrap</AppShortName>");
         tbf.Append(  @"<FolderName>ProjectsGroupsLink</FolderName>");
         tbf.Append(  @"<MenuName>Projects Groups Link</MenuName>");
         tbf.Append(  @"<QSPath>../ProjectsGroupsLink/ProjectsGroupsLink-QuickSelector.aspx</QSPath>");
         tbf.Append(  @"<TableCodeName>ProjectsGroupsLink</TableCodeName>");
         tbf.Append(  @"<TableStoredProcPrefix>pRatTrapProjectsGroupsLink</TableStoredProcPrefix>");
         tbf.Append("</XMLDefinition>");
         _DefinitionString = tbf.ToString();
	
		}	
		return _DefinitionString;		
	}
}

}
