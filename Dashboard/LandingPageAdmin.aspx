<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="LandingPageAdmin.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenuFull.master" Inherits="RatTrap.UI.LandingPageAdmin" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="Selectors" Namespace="RatTrap" Assembly="RatTrap" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td>&nbsp;</td><td></td><td></td><td></td><td></td><td></td><td></td></tr><tr><td>&nbsp;</td><td></td><td></td><td></td><td></td><td></td><td></td></tr><tr><td>&nbsp;</td><td><asp:ImageButton runat="server" id="UsersButton" causesvalidation="False" commandname="Custom" imageurl="../Images/Users.png">		
	</asp:ImageButton></td><td>&nbsp;</td><td><asp:ImageButton runat="server" id="GroupsButton" causesvalidation="False" commandname="Custom" imageurl="../Images/Groups.png">		
	</asp:ImageButton></td><td>&nbsp;</td><td><asp:ImageButton runat="server" id="ProjectsButton" causesvalidation="False" commandname="Custom" imageurl="../Images/Projects.png">		
	</asp:ImageButton></td><td>&nbsp;</td></tr><tr><td></td><td><asp:Label runat="server" id="Label" Text="Users">	</asp:Label></td><td>&nbsp;</td><td><asp:Label runat="server" id="Label1" Text="Groups">	</asp:Label></td><td></td><td><asp:Label runat="server" id="Label3" Text="Projects">	</asp:Label></td><td></td></tr><tr><td></td><td>&nbsp;</td><td></td><td></td><td></td><td></td><td></td></tr><tr><td></td><td><asp:ImageButton runat="server" id="TrapsButton" causesvalidation="False" commandname="Custom" imageurl="../Images/Traps.png">		
	</asp:ImageButton></td><td></td><td><asp:ImageButton runat="server" id="TrapsButton1" causesvalidation="False" commandname="Custom" imageurl="../Images/UploadTrapData.png">		
	</asp:ImageButton></td><td></td><td><asp:ImageButton runat="server" id="TrapRecordsButton" causesvalidation="False" commandname="Custom" imageurl="../Images/TrapRecords.png">		
	</asp:ImageButton></td><td></td></tr><tr><td></td><td><asp:Label runat="server" id="Label4" Text="Manage Traps">	</asp:Label></td><td></td><td><asp:Label runat="server" id="Label6" Text="Upload Trap Data">	</asp:Label></td><td></td><td><asp:Label runat="server" id="Label5" Text="Trap Records">	</asp:Label></td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr><tr><td></td><td><asp:ImageButton runat="server" id="MyGroupsButton" causesvalidation="False" commandname="Custom" imageurl="../Images/MyGroups.png">		
	</asp:ImageButton></td><td></td><td></td><td></td><td></td><td></td></tr><tr><td></td><td><asp:Label runat="server" id="Label2" Text="Group Data">	</asp:Label></td><td></td><td></td><td></td><td></td><td></td></tr></table>
      </ContentTemplate>
</asp:UpdatePanel>

    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                