﻿<%@ Control Language="C#" AutoEventWireup="false" Codebehind="Menu_Item.ascx.cs" Inherits="RatTrap.UI.Menu_Item" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="Selectors" Namespace="RatTrap" Assembly="RatTrap" %>
<table cellspacing="0" cellpadding="0" border="0" onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);"><tr><td class="mTL"><img src="../Images/space.gif" height="5" width="5" alt="" /></td><td class="mT"><img src="../Images/space.gif" height="5" width="2" alt="" /></td><td class="mTR"><img src="../Images/space.gif" height="5" width="5" alt="" /></td></tr><tr><td class="mL"><img src="../Images/space.gif" height="14" width="5" alt="" /></td><td class="mC"><asp:LinkButton CommandName="Redirect" runat="server" id="_Button" cssclass="menu">		
	</asp:LinkButton></td><td class="mR"><img src="../Images/space.gif" height="14" width="5" alt="" /></td></tr><tr><td class="mBL"><img src="../Images/space.gif" height="3" width="5" alt="" /></td><td class="mB"><img src="../Images/space.gif" height="3" width="2" alt="" /></td><td class="mBR"><img src="../Images/space.gif" height="3" width="5" alt="" /></td></tr></table>