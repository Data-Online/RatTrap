using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace RatTrap
{
	
	#region "Section 1: Place your customizations here."

    public partial class Global : BaseGlobal
    {
        // protected void Session_Start(object sender, EventArgs e)
        // {
        // }

        // protected void Application_BeginRequest(object sender, EventArgs e)
        // {
        // }

        // protected void Application_EndRequest(object sender, EventArgs e)
        // {
        // }

        // protected void Application_AuthenticateRequest(object sender, EventArgs e)
        // {
        // }

        // protected void Application_Error(object sender, EventArgs e)
        // {
        // }

        // protected void Session_End(object sender, EventArgs e)
        // {
        // }

        // protected void Application_End(object sender, EventArgs e)
        // {
        // }
        
        #region Web Form Designer generated code

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Global()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
        }

        #endregion
    }

    #endregion
    
    #region "Section 2: Do not modify this section."

    public class BaseGlobal : BaseClasses.Global
    {        
        protected override void Application_Start(object sender, EventArgs e)
        {
            base.Application_Start(sender, e);

            

            
        } 
    }

    #endregion
	
}
