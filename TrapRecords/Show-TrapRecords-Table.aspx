<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Show-TrapRecords-Table.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenuFull.master" Inherits="RatTrap.UI.Show_TrapRecords_Table" %>
<%@ Register Tagprefix="RatTrap" Namespace="RatTrap.UI.Controls.Show_TrapRecords_Table" Assembly="RatTrap" %>

<%@ Register Tagprefix="RatTrap" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="RatTrap" TagName="PaginationMedium" Src="../Shared/PaginationMedium.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="RatTrap" Assembly="RatTrap" %>

<%@ Register Tagprefix="RatTrap" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      <asp:UpdateProgress runat="server" id="UpdatePanel1_UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1">
			<ProgressTemplate>
				<div class="ajaxUpdatePanel">
				</div>
				<div style="position:absolute; padding:30px;" class="updatingContainer">
					<img src="../Images/updating.gif" alt="Updating" />
				</div>
			</ProgressTemplate>
		</asp:UpdateProgress>
		<asp:UpdatePanel runat="server" id="UpdatePanel1" UpdateMode="Conditional">
			<ContentTemplate>

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td>
                        <RatTrap:TrapRecordsTableControl runat="server" id="TrapRecordsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Trap Records&quot;) %>">	</asp:Literal>
                      </td><td class="dht" valign="middle"><img src="../Images/space.gif" alt="" /></td><td class="dht" valign="middle" style="font-size:10pt"><asp:Label runat="server" id="Label" Text="Total records">	</asp:Label></td><td class="dht" valign="middle" style="font-size:10pt"><asp:Literal runat="server" id="TrapRecordsCountControl">	</asp:Literal></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="NewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" redirectstyle="Popup" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;RatTrap&quot;) %>" visible="False">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="PDFButton" causesvalidation="False" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;RatTrap&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="WordButton" causesvalidation="False" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;RatTrap&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ExcelButton" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;RatTrap&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ImportButton" causesvalidation="False" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src=&#39;../Images/ButtonBarImport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarImportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;RatTrap&quot;) %>" visible="False">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><RatTrap:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;RatTrap&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;RatTrap&quot;) %>"></RatTrap:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <RatTrap:ThemeButtonWithArrow runat="server" id="FiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;FiltersDiv&#39;,&#39;FiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;RatTrap&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;RatTrap&quot;) %>"></RatTrap:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="DateOfCheckLabel1" Text="EvaluateFormula(&quot;= \&quot;Date Checked\&quot;&quot;, true)">	</asp:Literal></td><td class="popupTableCellValue" colspan="2"><asp:TextBox runat="server" id="DateOfCheckFromFilter" columns="15" cssclass="Filter_Input" onkeyup="DateFormat(this, this.value, event.keyCode, &#39;d/mm/yyyy&#39;)" timestring="&quot;00:00:00&quot;" AutoPostback="False" style="vertical-align:middle">	</asp:TextBox>
	<Selectors:CalendarExtendarClass runat="server" ID="DateOfCheckFromFilterCalenderExtender" TargetControlID="DateOfCheckFromFilter" CssClass="MyCalendar" Format="d">
	</Selectors:CalendarExtendarClass> <span class="rft"><%# GetResourceValue("Txt:To", "RatTrap") %></span> <asp:TextBox runat="server" id="DateOfCheckToFilter" columns="15" cssclass="Filter_Input" onkeyup="DateFormat(this, this.value, event.keyCode, &#39;d/mm/yyyy&#39;)" timestring="&quot;23:59:59&quot;" AutoPostback="False" style="vertical-align:middle">	</asp:TextBox>
	<Selectors:CalendarExtendarClass runat="server" ID="DateOfCheckToFilterCalenderExtender" TargetControlID="DateOfCheckToFilter" CssClass="MyCalendar" Format="d">
	</Selectors:CalendarExtendarClass></td><td class="popupTableCellValue"><RatTrap:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;RatTrap&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;RatTrap&quot;) %>" postback="False"></RatTrap:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;RatTrap&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="GroupIdLabel1" Text="Group">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<BaseClasses:QuickSelector runat="server" id="GroupIdFilter" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</BaseClasses:QuickSelector><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="ProjectIdLabel1" Text="Project">	</asp:Literal></td><td class="popupTableCellValue" colspan="2"><BaseClasses:QuickSelector runat="server" id="ProjectIdFilter" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</BaseClasses:QuickSelector></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;RatTrap&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="SortControl" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="TrapRecordsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="2" style="display:none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="TrapRecordsTableControlRepeater">		<ITEMTEMPLATE>		<RatTrap:TrapRecordsTableControlRow runat="server" id="TrapRecordsTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" rowspan="4" colspan="2"><asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;RatTrap&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="DeleteRowButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;RatTrap&quot;) %>">		
	</asp:ImageButton></td><td class="tableCellLabel"><asp:Literal runat="server" id="LocationIdLabel" Text="Location">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LocationId"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="TrapTypeIdLabel" Text="Trap Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="TrapTypeId" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="DateOfCheckLabel" Text="EvaluateFormula(&quot;= \&quot;Date Checked\&quot;&quot;, true)">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="DateOfCheck"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="BaitTypeLabel" Text="Bait Type">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="BaitType"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="SpeciesLabel" Text="Species">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Species"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="SexLabel" Text="Sex">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Sex"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="GroupIdLabel" Text="Group">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="GroupId" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="ProjectIdLabel" Text="Project">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="ProjectId" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="CommentLabel" Text="Comment">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><asp:Literal runat="server" id="Comment"></asp:Literal></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="8"></td></tr></RatTrap:TrapRecordsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <RatTrap:PaginationMedium runat="server" id="Pagination"></RatTrap:PaginationMedium>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="TrapRecordsTableControl_PostbackTracker" runat="server" />
</RatTrap:TrapRecordsTableControl>

            </td></tr></table>
      </ContentTemplate>
</asp:UpdatePanel>

    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                