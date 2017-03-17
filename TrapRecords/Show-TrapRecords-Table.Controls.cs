
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// Show_TrapRecords_Table.aspx page.  The Row or RecordControl classes are the 
// ideal place to add code customizations. For example, you can override the LoadData, 
// CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#region "Using statements"    

using Microsoft.VisualBasic;
using BaseClasses.Web.UI.WebControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Utils;
using ReportTools.ReportCreator;
using ReportTools.Shared;

        
using RatTrap.Business;
using RatTrap.Data;
using RatTrap.UI;
using RatTrap;
		

#endregion

  
namespace RatTrap.UI.Controls.Show_TrapRecords_Table
{
  

#region "Section 1: Place your customizations here."

    
public class TrapRecordsTableControlRow : BaseTrapRecordsTableControlRow
{
      
        // The BaseTrapRecordsTableControlRow implements code for a ROW within the
        // the TrapRecordsTableControl table.  The BaseTrapRecordsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of TrapRecordsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class TrapRecordsTableControl : BaseTrapRecordsTableControl
{
    // The BaseTrapRecordsTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The TrapRecordsTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the TrapRecordsTableControlRow control on the Show_TrapRecords_Table page.
// Do not modify this class. Instead override any method in TrapRecordsTableControlRow.
public class BaseTrapRecordsTableControlRow : RatTrap.UI.BaseApplicationRecordControl
{
        public BaseTrapRecordsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in TrapRecordsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in TrapRecordsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.DeleteRowButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "RatTrap") + "\"));");            
        
              // Register the event handlers.

          
                    this.DeleteRowButton.Click += DeleteRowButton_Click;
                        
                    this.EditRowButton.Click += EditRowButton_Click;
                        
                    this.GroupId.Click += GroupId_Click;
                        
                    this.ProjectId.Click += ProjectId_Click;
                        
                    this.TrapTypeId.Click += TrapTypeId_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseTheRatTrap%dbo.TrapRecords record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = TrapRecordsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseTrapRecordsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new TrapRecordsRecord();
            
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetBaitType();
                SetBaitTypeLabel();
                SetComment();
                SetCommentLabel();
                SetDateOfCheck();
                SetDateOfCheckLabel();
                
                
                SetGroupId();
                SetGroupIdLabel();
                SetLocationId();
                SetLocationIdLabel();
                SetProjectId();
                SetProjectIdLabel();
                SetSex();
                SetSexLabel();
                SetSpecies();
                SetSpeciesLabel();
                SetTrapTypeId();
                SetTrapTypeIdLabel();
                SetDeleteRowButton();
              
                SetEditRowButton();
              

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void SetBaitType()
        {
            
                    
            // Set the BaitType Literal on the webpage with value from the
            // DatabaseTheRatTrap%dbo.TrapRecords database record.

            // this.DataSource is the DatabaseTheRatTrap%dbo.TrapRecords record retrieved from the database.
            // this.BaitType is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BaitTypeSpecified) {
                								
                // If the BaitType is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.BaitType);
               if(_isExpandableNonCompositeForeignKey &&TrapRecordsTable.BaitType.IsApplyDisplayAs)
                                  
                     formattedValue = TrapRecordsTable.GetDFKA(this.DataSource.BaitType.ToString(),TrapRecordsTable.BaitType, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(TrapRecordsTable.BaitType);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BaitType.Text = formattedValue;
                   
            } 
            
            else {
            
                // BaitType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BaitType.Text = TrapRecordsTable.BaitType.Format(TrapRecordsTable.BaitType.DefaultValue);
            		
            }
            
            // If the BaitType is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BaitType.Text == null ||
                this.BaitType.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BaitType.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetComment()
        {
            
                    
            // Set the Comment Literal on the webpage with value from the
            // DatabaseTheRatTrap%dbo.TrapRecords database record.

            // this.DataSource is the DatabaseTheRatTrap%dbo.TrapRecords record retrieved from the database.
            // this.Comment is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CommentSpecified) {
                								
                // If the Comment is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TrapRecordsTable.Comment);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if(formattedValue != null){
                    int popupThreshold = (int)(50);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(300)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(300);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(TrapRecordsTable.Comment.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"RatTrap.Business.TrapRecordsTable, RatTrap.Business\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"Comment\\\", \\\"Comment\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "RatTrap") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(300))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                        }
                    }
                    else{
                        if (maxLength == (int)(300)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                    }
                }
                
                this.Comment.Text = formattedValue;
                   
            } 
            
            else {
            
                // Comment is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Comment.Text = TrapRecordsTable.Comment.Format(TrapRecordsTable.Comment.DefaultValue);
            		
            }
            
            // If the Comment is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Comment.Text == null ||
                this.Comment.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Comment.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetDateOfCheck()
        {
            
                    
            // Set the DateOfCheck Literal on the webpage with value from the
            // DatabaseTheRatTrap%dbo.TrapRecords database record.

            // this.DataSource is the DatabaseTheRatTrap%dbo.TrapRecords record retrieved from the database.
            // this.DateOfCheck is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.DateOfCheckSpecified) {
                								
                // If the DateOfCheck is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(TrapRecordsTable.DateOfCheck);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.DateOfCheck.Text = formattedValue;
                   
            } 
            
            else {
            
                // DateOfCheck is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.DateOfCheck.Text = TrapRecordsTable.DateOfCheck.Format(TrapRecordsTable.DateOfCheck.DefaultValue);
            		
            }
            
            // If the DateOfCheck is NULL or blank, then use the value specified  
            // on Properties.
            if (this.DateOfCheck.Text == null ||
                this.DateOfCheck.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.DateOfCheck.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetGroupId()
        {
            
                    
            // Set the GroupId LinkButton on the webpage with value from the
            // DatabaseTheRatTrap%dbo.TrapRecords database record.

            // this.DataSource is the DatabaseTheRatTrap%dbo.TrapRecords record retrieved from the database.
            // this.GroupId is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.GroupIdSpecified) {
                								
                // If the GroupId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.GroupId);
               if(_isExpandableNonCompositeForeignKey &&TrapRecordsTable.GroupId.IsApplyDisplayAs)
                                  
                     formattedValue = TrapRecordsTable.GetDFKA(this.DataSource.GroupId.ToString(),TrapRecordsTable.GroupId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(TrapRecordsTable.GroupId);
                                  
                                
                this.GroupId.Text = formattedValue;
                
                  this.GroupId.ToolTip = "Go to " + this.GroupId.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // GroupId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.GroupId.Text = TrapRecordsTable.GroupId.Format(TrapRecordsTable.GroupId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetLocationId()
        {
            
                    
            // Set the LocationId Literal on the webpage with value from the
            // DatabaseTheRatTrap%dbo.TrapRecords database record.

            // this.DataSource is the DatabaseTheRatTrap%dbo.TrapRecords record retrieved from the database.
            // this.LocationId is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LocationIdSpecified) {
                								
                // If the LocationId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.LocationId);
               if(_isExpandableNonCompositeForeignKey &&TrapRecordsTable.LocationId.IsApplyDisplayAs)
                                  
                     formattedValue = TrapRecordsTable.GetDFKA(this.DataSource.LocationId.ToString(),TrapRecordsTable.LocationId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(TrapRecordsTable.LocationId);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LocationId.Text = formattedValue;
                   
            } 
            
            else {
            
                // LocationId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LocationId.Text = TrapRecordsTable.LocationId.Format(TrapRecordsTable.LocationId.DefaultValue);
            		
            }
            
            // If the LocationId is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LocationId.Text == null ||
                this.LocationId.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LocationId.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetProjectId()
        {
            
                    
            // Set the ProjectId LinkButton on the webpage with value from the
            // DatabaseTheRatTrap%dbo.TrapRecords database record.

            // this.DataSource is the DatabaseTheRatTrap%dbo.TrapRecords record retrieved from the database.
            // this.ProjectId is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ProjectIdSpecified) {
                								
                // If the ProjectId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.ProjectId);
               if(_isExpandableNonCompositeForeignKey &&TrapRecordsTable.ProjectId.IsApplyDisplayAs)
                                  
                     formattedValue = TrapRecordsTable.GetDFKA(this.DataSource.ProjectId.ToString(),TrapRecordsTable.ProjectId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(TrapRecordsTable.ProjectId);
                                  
                                
                this.ProjectId.Text = formattedValue;
                
                  this.ProjectId.ToolTip = "Go to " + this.ProjectId.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // ProjectId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ProjectId.Text = TrapRecordsTable.ProjectId.Format(TrapRecordsTable.ProjectId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetSex()
        {
            
                    
            // Set the Sex Literal on the webpage with value from the
            // DatabaseTheRatTrap%dbo.TrapRecords database record.

            // this.DataSource is the DatabaseTheRatTrap%dbo.TrapRecords record retrieved from the database.
            // this.Sex is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SexSpecified) {
                								
                // If the Sex is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.Sex);
               if(_isExpandableNonCompositeForeignKey &&TrapRecordsTable.Sex.IsApplyDisplayAs)
                                  
                     formattedValue = TrapRecordsTable.GetDFKA(this.DataSource.Sex.ToString(),TrapRecordsTable.Sex, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(TrapRecordsTable.Sex);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Sex.Text = formattedValue;
                   
            } 
            
            else {
            
                // Sex is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Sex.Text = TrapRecordsTable.Sex.Format(TrapRecordsTable.Sex.DefaultValue);
            		
            }
            
            // If the Sex is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Sex.Text == null ||
                this.Sex.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Sex.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetSpecies()
        {
            
                    
            // Set the Species Literal on the webpage with value from the
            // DatabaseTheRatTrap%dbo.TrapRecords database record.

            // this.DataSource is the DatabaseTheRatTrap%dbo.TrapRecords record retrieved from the database.
            // this.Species is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.SpeciesSpecified) {
                								
                // If the Species is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.Species);
               if(_isExpandableNonCompositeForeignKey &&TrapRecordsTable.Species.IsApplyDisplayAs)
                                  
                     formattedValue = TrapRecordsTable.GetDFKA(this.DataSource.Species.ToString(),TrapRecordsTable.Species, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(TrapRecordsTable.Species);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Species.Text = formattedValue;
                   
            } 
            
            else {
            
                // Species is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Species.Text = TrapRecordsTable.Species.Format(TrapRecordsTable.Species.DefaultValue);
            		
            }
            
            // If the Species is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Species.Text == null ||
                this.Species.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Species.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTrapTypeId()
        {
            
                    
            // Set the TrapTypeId LinkButton on the webpage with value from the
            // DatabaseTheRatTrap%dbo.TrapRecords database record.

            // this.DataSource is the DatabaseTheRatTrap%dbo.TrapRecords record retrieved from the database.
            // this.TrapTypeId is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TrapTypeIdSpecified) {
                								
                // If the TrapTypeId is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.TrapTypeId);
               if(_isExpandableNonCompositeForeignKey &&TrapRecordsTable.TrapTypeId.IsApplyDisplayAs)
                                  
                     formattedValue = TrapRecordsTable.GetDFKA(this.DataSource.TrapTypeId.ToString(),TrapRecordsTable.TrapTypeId, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(TrapRecordsTable.TrapTypeId);
                                  
                                
                this.TrapTypeId.Text = formattedValue;
                
                  this.TrapTypeId.ToolTip = "Go to " + this.TrapTypeId.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // TrapTypeId is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TrapTypeId.Text = TrapRecordsTable.TrapTypeId.Format(TrapRecordsTable.TrapTypeId.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetBaitTypeLabel()
                  {
                  
                    
        }
                
        public virtual void SetCommentLabel()
                  {
                  
                    
        }
                
        public virtual void SetDateOfCheckLabel()
                  {
                  
                        this.DateOfCheckLabel.Text = EvaluateFormula("\"Date Checked\"");
                      
                    
        }
                
        public virtual void SetGroupIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetLocationIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetProjectIdLabel()
                  {
                  
                    
        }
                
        public virtual void SetSexLabel()
                  {
                  
                    
        }
                
        public virtual void SetSpeciesLabel()
                  {
                  
                    
        }
                
        public virtual void SetTrapTypeIdLabel()
                  {
                  
                    
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
                // add datasource as variables for formula evaluation
                  TrapRecordsTableControl panel;
                panel = (TrapRecordsTableControl)(this.GetParentTableControl());
                  
                e.Variables.Add("TrapRecordsCountQuery", panel.TrapRecordsCountQuery);                                                       
                        
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "RatTrap"));
                }
            }
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((TrapRecordsTableControl)MiscUtils.GetParentControlObject(this, "TrapRecordsTableControl")).DataChanged = true;
                ((TrapRecordsTableControl)MiscUtils.GetParentControlObject(this, "TrapRecordsTableControl")).ResetData = true;
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetBaitType();
            GetComment();
            GetDateOfCheck();
            GetGroupId();
            GetLocationId();
            GetProjectId();
            GetSex();
            GetSpecies();
            GetTrapTypeId();
        }
        
        
        public virtual void GetBaitType()
        {
            
        }
                
        public virtual void GetComment()
        {
            
        }
                
        public virtual void GetDateOfCheck()
        {
            
        }
                
        public virtual void GetGroupId()
        {
            
        }
                
        public virtual void GetLocationId()
        {
            
        }
                
        public virtual void GetProjectId()
        {
            
        }
                
        public virtual void GetSex()
        {
            
        }
                
        public virtual void GetSpecies()
        {
            
        }
                
        public virtual void GetTrapTypeId()
        {
            
        }
                

      // To customize, override this method in TrapRecordsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersTrapRecordsTableControl = false;
            hasFiltersTrapRecordsTableControl = hasFiltersTrapRecordsTableControl && false; // suppress warning
      
            return null;
        
        }
        
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          TrapRecordsTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((TrapRecordsTableControl)MiscUtils.GetParentControlObject(this, "TrapRecordsTableControl")).DataChanged = true;
            ((TrapRecordsTableControl)MiscUtils.GetParentControlObject(this, "TrapRecordsTableControl")).ResetData = true;
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
    
        // Generate set method for buttons
        
        public virtual void SetDeleteRowButton()                
              
        {
        
   
        }
            
        public virtual void SetEditRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void DeleteRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.Delete();
              
            }
      this.Page.CommitTransaction(sender);
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void EditRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../TrapRecords/Edit-TrapRecords.aspx?TrapRecords={PK}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for LinkButton
        public virtual void GroupId_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Groups/Show-Groups.aspx?Groups={TrapRecordsTableControlRow:FK:VFK_TrapRecords_GroupId_1}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for LinkButton
        public virtual void ProjectId_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Projects/Show-Projects.aspx?Projects={TrapRecordsTableControlRow:FK:VFK_TrapRecords_ProjectId_1}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for LinkButton
        public virtual void TrapTypeId_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../TrapTypes/Show-TrapTypes.aspx?TrapTypes={TrapRecordsTableControlRow:FK:VFK_TrapRecords_TrapTypeId_1}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseTrapRecordsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseTrapRecordsTableControlRow_Rec"] = value;
            }
        }
        
        public TrapRecordsRecord DataSource {
            get {
                return (TrapRecordsRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal BaitType {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BaitType");
            }
        }
            
        public System.Web.UI.WebControls.Literal BaitTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BaitTypeLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Comment {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Comment");
            }
        }
            
        public System.Web.UI.WebControls.Literal CommentLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CommentLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal DateOfCheck {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DateOfCheck");
            }
        }
            
        public System.Web.UI.WebControls.Literal DateOfCheckLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DateOfCheckLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton DeleteRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DeleteRowButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton EditRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EditRowButton");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton GroupId {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GroupId");
            }
        }
            
        public System.Web.UI.WebControls.Literal GroupIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GroupIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LocationId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LocationId");
            }
        }
            
        public System.Web.UI.WebControls.Literal LocationIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LocationIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ProjectId {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ProjectId");
            }
        }
            
        public System.Web.UI.WebControls.Literal ProjectIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ProjectIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Sex {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Sex");
            }
        }
            
        public System.Web.UI.WebControls.Literal SexLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SexLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Species {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Species");
            }
        }
            
        public System.Web.UI.WebControls.Literal SpeciesLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SpeciesLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton TrapTypeId {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TrapTypeId");
            }
        }
            
        public System.Web.UI.WebControls.Literal TrapTypeIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TrapTypeIdLabel");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        TrapRecordsRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "RatTrap"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    TrapRecordsRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "RatTrap"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual TrapRecordsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return TrapRecordsTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            throw new Exception(Page.GetResourceValue("Err:RetrieveRec", "RatTrap"));
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the TrapRecordsTableControl control on the Show_TrapRecords_Table page.
// Do not modify this class. Instead override any method in TrapRecordsTableControl.
public class BaseTrapRecordsTableControl : RatTrap.UI.BaseApplicationTableControl
{
         
       public BaseTrapRecordsTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                
                  if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                  {
                  initialVal = "";
                  }
                
                if  (this.InSession(this.SortControl)) 				
                    initialVal = this.GetFromSession(this.SortControl);
                
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.SortControl.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.SortControl.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.DateOfCheckFromFilter)) 				
                    initialVal = this.GetFromSession(this.DateOfCheckFromFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"DateOfCheckFrom\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.DateOfCheckFromFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.DateOfCheckToFilter)) 				
                    initialVal = this.GetFromSession(this.DateOfCheckToFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"DateOfCheckTo\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.DateOfCheckToFilter.Text = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.GroupIdFilter)) 				
                    initialVal = this.GetFromSession(this.GroupIdFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"GroupId\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] GroupIdFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in GroupIdFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.GroupIdFilter.Items.Add(item);
                            this.GroupIdFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.GroupIdFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.ProjectIdFilter)) 				
                    initialVal = this.GetFromSession(this.ProjectIdFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ProjectId\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    string[] ProjectIdFilteritemListFromSession = initialVal.Split(',');
                    int index = 0;
                    foreach (string item in ProjectIdFilteritemListFromSession)
                    {
                        if (index == 0 && item.ToString().Equals(""))
                        {
                            // do nothing
                        }
                        else
                        {
                            this.ProjectIdFilter.Items.Add(item);
                            this.ProjectIdFilter.Items[index].Selected = true;
                            index += 1;
                        }
                    }
                    foreach (ListItem listItem in this.ProjectIdFilter.Items)
                    {
                        listItem.Selected = true;
                    }
                        
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.Pagination.FirstPage.Click += Pagination_FirstPage_Click;
                        
                    this.Pagination.LastPage.Click += Pagination_LastPage_Click;
                        
                    this.Pagination.NextPage.Click += Pagination_NextPage_Click;
                        
                    this.Pagination.PageSizeButton.Click += Pagination_PageSizeButton_Click;
                        
                    this.Pagination.PreviousPage.Click += Pagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
            // Setup the button events.
          
                    this.ExcelButton.Click += ExcelButton_Click;
                        
                    this.ImportButton.Click += ImportButton_Click;
                        
                    this.NewButton.Click += NewButton_Click;
                        
                    this.PDFButton.Click += PDFButton_Click;
                        
                    this.ResetButton.Click += ResetButton_Click;
                        
                    this.WordButton.Click += WordButton_Click;
                        
                    this.ActionsButton.Button.Click += ActionsButton_Click;
                        
                    this.FilterButton.Button.Click += FilterButton_Click;
                        
                    this.FiltersButton.Button.Click += FiltersButton_Click;
                        
            this.SortControl.SelectedIndexChanged += new EventHandler(SortControl_SelectedIndexChanged);
            
              this.GroupIdFilter.SelectedIndexChanged += GroupIdFilter_SelectedIndexChanged;                  
                
              this.ProjectIdFilter.SelectedIndexChanged += ProjectIdFilter_SelectedIndexChanged;                  
                        
        
         //' Setup events for others
               
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(RatTrap.Business.TrapRecordsRecord);
                      this.DataSource = (TrapRecordsRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / Convert.ToDouble(this.PageSize)));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (TrapRecordsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(RatTrap.Business.TrapRecordsRecord);
                    this.DataSource = (TrapRecordsRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, this.PageSize);
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual TrapRecordsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(TrapRecordsTable.Column1, true);          
            // selCols.Add(TrapRecordsTable.Column2, true);          
            // selCols.Add(TrapRecordsTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return TrapRecordsTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                TrapRecordsTable databaseTable = new TrapRecordsTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(TrapRecordsRecord)) as TrapRecordsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(TrapRecordsTable.Column1, true);          
            // selCols.Add(TrapRecordsTable.Column2, true);          
            // selCols.Add(TrapRecordsTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return TrapRecordsTable.GetRecordCount(join, where);
            else
            {
                TrapRecordsTable databaseTable = new TrapRecordsTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          base.DataBind();
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
          
                  LoadData_TrapRecordsCountQuery();
       
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();     

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TrapRecordsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            TrapRecordsTableControlRow recControl = (TrapRecordsTableControlRow)(repItem.FindControl("TrapRecordsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                
                
                SetDateOfCheckLabel1();
                
                
                
                
                
                SetGroupIdFilter();
                SetGroupIdLabel1();
                
                SetLabel();
                
                
                
                SetProjectIdFilter();
                SetProjectIdLabel1();
                
                SetSortByLabel();
                SetSortControl();
                
                SetTrapRecordsCountControl();
                
                
                SetExcelButton();
              
                SetImportButton();
              
                SetNewButton();
              
                SetPDFButton();
              
                SetResetButton();
              
                SetWordButton();
              
                SetActionsButton();
              
                SetFilterButton();
              
                SetFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.ExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "RatTrap") + "'));");
        else
          this.ExcelButton.Attributes.Remove("onClick");
      
    }
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(TrapRecordsTable.BaitType, this.DataSource);
            this.Page.PregetDfkaRecords(TrapRecordsTable.GroupId, this.DataSource);
            this.Page.PregetDfkaRecords(TrapRecordsTable.LocationId, this.DataSource);
            this.Page.PregetDfkaRecords(TrapRecordsTable.ProjectId, this.DataSource);
            this.Page.PregetDfkaRecords(TrapRecordsTable.Sex, this.DataSource);
            this.Page.PregetDfkaRecords(TrapRecordsTable.Species, this.DataSource);
            this.Page.PregetDfkaRecords(TrapRecordsTable.TrapTypeId, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"ExcelButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PDFButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"WordButton"));
                                
        }
        

        
          public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

          public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
          {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();

            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            if (includeDS)
            {
                
                // add datasource as variables for formula evaluation
                    
                if (TrapRecordsCountQuery != null) e.Variables.Add("TrapRecordsCountQuery", TrapRecordsCountQuery);                                                       
                    
            }

            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
        
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
           
        public virtual void ResetControl()
        {


            
            this.GroupIdFilter.ClearSelection();
            
            this.ProjectIdFilter.ClearSelection();
            
            this.SortControl.ClearSelection();
            
            this.DateOfCheckFromFilter.Text = "";
            
            this.DateOfCheckToFilter.Text = "";
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
               
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
            if (DbUtils.GetCreatedRecords(this.DataSource).Length > 0)                      
                    
            {
                this.Pagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Pagination.CurrentPage.Text = "0";
            }
            this.Pagination.PageSize.Text = this.PageSize.ToString();
            this.Pagination.TotalPages.Text = this.TotalPages.ToString();
    
            // Bind the buttons for TrapRecordsTableControl pagination.
        
            this.Pagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Pagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Pagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Pagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Pagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (TrapRecordsTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (TrapRecordsTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            TrapRecordsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.DateOfCheckFromFilter)) {
                string val = MiscUtils.GetSelectedValue(this.DateOfCheckFromFilter, this.GetFromSession(this.DateOfCheckFromFilter));
                DateTime d = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT);
                    
                val = d.ToShortDateString() + " " + "00:00:00";
                wc.iAND(TrapRecordsTable.DateOfCheck, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, val, false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.DateOfCheckToFilter)) {
                string val = MiscUtils.GetSelectedValue(this.DateOfCheckToFilter, this.GetFromSession(this.DateOfCheckToFilter));
                DateTime d = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT);
                    
                val = d.ToShortDateString() + " " + "23:59:59";
                wc.iAND(TrapRecordsTable.DateOfCheck, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, val, false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.GroupIdFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.GroupIdFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.GroupIdFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(TrapRecordsTable.GroupId, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.ProjectIdFilter)) {
                        
                int selectedItemCount = 0;
                foreach (ListItem item in this.ProjectIdFilter.Items){
                    if (item.Selected) {
                        selectedItemCount += 1;
                        
                          
                    }
                }
                WhereClause filter = new WhereClause();
                foreach (ListItem item in this.ProjectIdFilter.Items){
                    if ((item.Selected) && ((item.Value == "--ANY--") || (item.Value == "--PLEASE_SELECT--")) && (selectedItemCount > 1)){
                        item.Selected = false;
                    }
                    if (item.Selected){
                        filter.iOR(TrapRecordsTable.ProjectId, BaseFilter.ComparisonOperator.EqualsTo, item.Value, false, false);
                    }
                }
                wc.iAND(filter);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            TrapRecordsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
            string DateOfCheckFromFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "DateOfCheckFromFilter_Ajax"];
            if (MiscUtils.IsValueSelected(DateOfCheckFromFilterSelectedValue)) {
                DateTime d = DateParser.ParseDate(DateOfCheckFromFilterSelectedValue, DateColumn.DEFAULT_FORMAT);
                DateOfCheckFromFilterSelectedValue = d.ToShortDateString() + " " + "00:00:00";
                    
                wc.iAND(TrapRecordsTable.DateOfCheck, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, DateOfCheckFromFilterSelectedValue, false, false);
                    
            }         
            string DateOfCheckToFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "DateOfCheckToFilter_Ajax"];
            if (MiscUtils.IsValueSelected(DateOfCheckToFilterSelectedValue)) {
                DateTime d = DateParser.ParseDate(DateOfCheckToFilterSelectedValue, DateColumn.DEFAULT_FORMAT);
                DateOfCheckToFilterSelectedValue = d.ToShortDateString() + " " + "23:59:59";
                    
                wc.iAND(TrapRecordsTable.DateOfCheck, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, DateOfCheckToFilterSelectedValue, false, false);
                    
            }         
      String GroupIdFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "GroupIdFilter_Ajax"];
            if (MiscUtils.IsValueSelected(GroupIdFilterSelectedValue)) {

              
        if (GroupIdFilterSelectedValue != null){
                        string[] GroupIdFilteritemListFromSession = GroupIdFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in GroupIdFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(TrapRecordsTable.GroupId, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      
      String ProjectIdFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ProjectIdFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ProjectIdFilterSelectedValue)) {

              
        if (ProjectIdFilterSelectedValue != null){
                        string[] ProjectIdFilteritemListFromSession = ProjectIdFilterSelectedValue.Split(',');
                        int index = 0;
                        WhereClause filter = new WhereClause();
                        foreach (string item in ProjectIdFilteritemListFromSession)
                        {
                            if (index == 0 && item.ToString().Equals(""))
                            {
                            }
                            else
                            {
                                filter.iOR(TrapRecordsTable.ProjectId, BaseFilter.ComparisonOperator.EqualsTo, item, false, false);
                                index += 1;
                            }
                        }
                        wc.iAND(filter);
        }
                
      }
                      

            return wc;
        }

        
          
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }          
          
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    
                    resultList.Add(itemToAdd);
          								
                    isAdded = true;
                }
            }
            return isAdded;
        }        
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.Pagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Pagination.PageSize.Text);
                } catch (Exception ) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TrapRecordsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                TrapRecordsTableControlRow recControl = (TrapRecordsTableControlRow)(repItem.FindControl("TrapRecordsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      TrapRecordsRecord rec = new TrapRecordsRecord();
        
                        if (recControl.BaitType.Text != "") {
                            rec.Parse(recControl.BaitType.Text, TrapRecordsTable.BaitType);
                  }
                
                        if (recControl.Comment.Text != "") {
                            rec.Parse(recControl.Comment.Text, TrapRecordsTable.Comment);
                  }
                
                        if (recControl.DateOfCheck.Text != "") {
                            rec.Parse(recControl.DateOfCheck.Text, TrapRecordsTable.DateOfCheck);
                  }
                
                        if (recControl.GroupId.Text != "") {
                            rec.Parse(recControl.GroupId.Text, TrapRecordsTable.GroupId);
                  }
                
                        if (recControl.LocationId.Text != "") {
                            rec.Parse(recControl.LocationId.Text, TrapRecordsTable.LocationId);
                  }
                
                        if (recControl.ProjectId.Text != "") {
                            rec.Parse(recControl.ProjectId.Text, TrapRecordsTable.ProjectId);
                  }
                
                        if (recControl.Sex.Text != "") {
                            rec.Parse(recControl.Sex.Text, TrapRecordsTable.Sex);
                  }
                
                        if (recControl.Species.Text != "") {
                            rec.Parse(recControl.Species.Text, TrapRecordsTable.Species);
                  }
                
                        if (recControl.TrapTypeId.Text != "") {
                            rec.Parse(recControl.TrapTypeId.Text, TrapRecordsTable.TrapTypeId);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new TrapRecordsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(RatTrap.Business.TrapRecordsRecord);
                this.DataSource = (TrapRecordsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(TrapRecordsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(TrapRecordsTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        
        public virtual void SetDateOfCheckLabel1()
                  {
                  
                        this.DateOfCheckLabel1.Text = EvaluateFormula("\"Date Checked\"");
                      
                    
        }
                
        public virtual void SetGroupIdLabel1()
                  {
                  
                    
        }
                
        public virtual void SetLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.Label.Text = "Some value";
                    
                    
        }
                
        public virtual void SetProjectIdLabel1()
                  {
                  
                    
        }
                
        public virtual void SetSortByLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.SortByLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetTrapRecordsCountControl()
                  {
                  
                        this.TrapRecordsCountControl.Text = EvaluateFormula("LOOKUP(TrapRecordsCountQuery, \"\")");
                    
                    
        }
                
        public virtual WhereClause CreateWhereClause_TrapRecordsCountQuery()
        
        {
            WhereClause wc = new WhereClause();
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design tithis.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

                      
            return wc;
        }
      
        public virtual void LoadData_TrapRecordsCountQuery()
        
        {
          
              if (!(this.ResetData || this.DataChanged || _TrapRecordsCountQuery.DataChanged) && this.Page.IsPostBack  && this.Page.Request["__EVENTTARGET"] != "isd_geo_location") return;
        
              _TrapRecordsCountQuery.DataChanged = true;
          
              this._TrapRecordsCountQuery.Initialize("TrapRecordsCountQuery", TrapRecordsTable.Instance, 0, 0);
            
               
              // Add the primary key of the record
              WhereClause wc = CreateWhereClause_TrapRecordsCountQuery();
              this._TrapRecordsCountQuery.WhereClause.iAND(wc);                      
          
              // Define selects
          
                    this._TrapRecordsCountQuery.AddSelectItem(new SelectItem(SelectItem.Operation.COUNT, new SelectItem(SelectItem.ItemType.AllColumns, TrapRecordsTable.Instance, "TrapRecordsCount", ""), "TrapRecordsCount"));
              
              // Define joins if there are any
          
              this._TrapRecordsCountQuery.LoadData(false, this._TrapRecordsCountQuery.PageSize, this._TrapRecordsCountQuery.PageIndex);                       
                        
        }
      
        private DataSource _TrapRecordsCountQuery = new DataSource();
        public DataSource TrapRecordsCountQuery
        {
            get
            {
                return _TrapRecordsCountQuery;
             }
        }
      
        public virtual void SetSortControl()
        {
            
                this.PopulateSortControl(MiscUtils.GetSelectedValue(this.SortControl,  GetFromSession(this.SortControl)), 500);					
                    

        }
            
        public virtual void SetGroupIdFilter()
        {
            
            ArrayList GroupIdFilterselectedFilterItemList = new ArrayList();
            string GroupIdFilteritemsString = null;
            if (this.InSession(this.GroupIdFilter))
                GroupIdFilteritemsString = this.GetFromSession(this.GroupIdFilter);
            
            if (GroupIdFilteritemsString != null)
            {
                string[] GroupIdFilteritemListFromSession = GroupIdFilteritemsString.Split(',');
                foreach (string item in GroupIdFilteritemListFromSession)
                {
                    GroupIdFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateGroupIdFilter(MiscUtils.GetSelectedValueList(this.GroupIdFilter, GroupIdFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Groups/Groups-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.GroupIdFilter.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= Groups.GroupName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("GroupId")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.GroupIdFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(GroupIdFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        public virtual void SetProjectIdFilter()
        {
            
            ArrayList ProjectIdFilterselectedFilterItemList = new ArrayList();
            string ProjectIdFilteritemsString = null;
            if (this.InSession(this.ProjectIdFilter))
                ProjectIdFilteritemsString = this.GetFromSession(this.ProjectIdFilter);
            
            if (ProjectIdFilteritemsString != null)
            {
                string[] ProjectIdFilteritemListFromSession = ProjectIdFilteritemsString.Split(',');
                foreach (string item in ProjectIdFilteritemListFromSession)
                {
                    ProjectIdFilterselectedFilterItemList.Add(item);
                }
            }
              
            			
            this.PopulateProjectIdFilter(MiscUtils.GetSelectedValueList(this.ProjectIdFilter, ProjectIdFilterselectedFilterItemList), 500);
                    
              string url = this.ModifyRedirectUrl("../Projects/Projects-QuickSelector.aspx", "", true);
              
              url = this.Page.ModifyRedirectUrl(url, "", true);                                  
              
              url += "?Target=" + this.ProjectIdFilter.ClientID + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= Projects.Description")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("ProjectId")+ "&EmptyValue=" + (this.Page as BaseApplicationPage).Encrypt("--ANY--") + "&EmptyDisplayText=" + (this.Page as BaseApplicationPage).Encrypt(this.Page.GetResourceValue("Txt:All")) + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup");
              
              this.ProjectIdFilter.Attributes["onClick"] = "initializePopupPage(this, '" + url + "', " + Convert.ToString(ProjectIdFilter.AutoPostBack).ToLower() + ", event); return false;";
                  
                             
        }
            
        // Get the filters' data for SortControl.
                
        protected virtual void PopulateSortControl(string selectedValue, int maxItems)
                    
        {
            
              
                this.SortControl.Items.Clear();
                
              // 1. Setup the static list items
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Bait Type {Txt:Ascending}"), "BaitType Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Bait Type {Txt:Descending}"), "BaitType Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Comment {Txt:Ascending}"), "Comment Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Comment {Txt:Descending}"), "Comment Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Checked {Txt:Ascending}"), "DateOfCheck Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Date Checked {Txt:Descending}"), "DateOfCheck Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Group {Txt:Ascending}"), "GroupId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Group {Txt:Descending}"), "GroupId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Location {Txt:Ascending}"), "LocationId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Location {Txt:Descending}"), "LocationId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project {Txt:Ascending}"), "ProjectId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Project {Txt:Descending}"), "ProjectId Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sex {Txt:Ascending}"), "Sex Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Sex {Txt:Descending}"), "Sex Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Species {Txt:Ascending}"), "Species Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Species {Txt:Descending}"), "Species Desc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Trap Type {Txt:Ascending}"), "TrapTypeId Asc"));
              
                this.SortControl.Items.Add(new ListItem(this.Page.ExpandResourceValue("Trap Type {Txt:Descending}"), "TrapTypeId Desc"));
              
            try
            {          
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.SortControl, selectedValue);

               
            }
            catch
            {
            }
              
            if (this.SortControl.SelectedValue != null && this.SortControl.Items.FindByValue(this.SortControl.SelectedValue) == null)
                this.SortControl.SelectedValue = null;
              
        }
            
        // Get the filters' data for GroupIdFilter.
                
        protected virtual void PopulateGroupIdFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_GroupIdFilter();            
            this.GroupIdFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_GroupIdFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "RatTrap");

            GroupsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = GroupsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (GroupsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.GroupIdSpecified) 
                        {
                            cvalue = itemValue.GroupId.ToString();
                            if (counter < maxItems && this.GroupIdFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.GroupId);
                                if(_isExpandableNonCompositeForeignKey && TrapRecordsTable.GroupId.IsApplyDisplayAs)
                                     fvalue = TrapRecordsTable.GetDFKA(itemValue, TrapRecordsTable.GroupId);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(GroupsTable.GroupId);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.GroupIdFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.GroupIdFilter.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
        
                      
            try
            {
      
                
            }
            catch
            {
            }
            
            
            this.GroupIdFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.GroupIdFilter.Items.Count == 0)
                this.GroupIdFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "RatTrap"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.GroupIdFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        // Get the filters' data for ProjectIdFilter.
                
        protected virtual void PopulateProjectIdFilter(ArrayList selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            WhereClause wc = this.CreateWhereClause_ProjectIdFilter();            
            this.ProjectIdFilter.Items.Clear();
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ProjectIdFilter function.
            // It is better to customize the where clause there.
             
            OrderBy orderBy = new OrderBy(false, false);
            

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "RatTrap");

            ProjectsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = ProjectsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (ProjectsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.ProjectIdSpecified) 
                        {
                            cvalue = itemValue.ProjectId.ToString();
                            if (counter < maxItems && this.ProjectIdFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.ProjectId);
                                if(_isExpandableNonCompositeForeignKey && TrapRecordsTable.ProjectId.IsApplyDisplayAs)
                                     fvalue = TrapRecordsTable.GetDFKA(itemValue, TrapRecordsTable.ProjectId);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(ProjectsTable.ProjectId);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ProjectIdFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ProjectIdFilter.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
        
                      
            try
            {
      
                
            }
            catch
            {
            }
            
            
            this.ProjectIdFilter.SetFieldMaxLength(50);
                                 
                  
            // Add the selected value.
            if (this.ProjectIdFilter.Items.Count == 0)
                this.ProjectIdFilter.Items.Add(new ListItem(Page.GetResourceValue("Txt:All", "RatTrap"), "--ANY--"));
            
            // Mark all items to be selected.
            foreach (ListItem item in this.ProjectIdFilter.Items)
            {
                item.Selected = true;
            }
                               
        }
            
        public virtual WhereClause CreateWhereClause_GroupIdFilter()
        {
            // Create a where clause for the filter GroupIdFilter.
            // This function is called by the Populate method to load the items 
            // in the GroupIdFilterQuickSelector
        
            ArrayList GroupIdFilterselectedFilterItemList = new ArrayList();
            string GroupIdFilteritemsString = null;
            if (this.InSession(this.GroupIdFilter))
                GroupIdFilteritemsString = this.GetFromSession(this.GroupIdFilter);
            
            if (GroupIdFilteritemsString != null)
            {
                string[] GroupIdFilteritemListFromSession = GroupIdFilteritemsString.Split(',');
                foreach (string item in GroupIdFilteritemListFromSession)
                {
                    GroupIdFilterselectedFilterItemList.Add(item);
                }
            }
              
            GroupIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.GroupIdFilter, GroupIdFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (GroupIdFilterselectedFilterItemList == null || GroupIdFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in GroupIdFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(GroupsTable.GroupId, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
                }
            }
            return wc;
        
        }
      
        public virtual WhereClause CreateWhereClause_ProjectIdFilter()
        {
            // Create a where clause for the filter ProjectIdFilter.
            // This function is called by the Populate method to load the items 
            // in the ProjectIdFilterQuickSelector
        
            ArrayList ProjectIdFilterselectedFilterItemList = new ArrayList();
            string ProjectIdFilteritemsString = null;
            if (this.InSession(this.ProjectIdFilter))
                ProjectIdFilteritemsString = this.GetFromSession(this.ProjectIdFilter);
            
            if (ProjectIdFilteritemsString != null)
            {
                string[] ProjectIdFilteritemListFromSession = ProjectIdFilteritemsString.Split(',');
                foreach (string item in ProjectIdFilteritemListFromSession)
                {
                    ProjectIdFilterselectedFilterItemList.Add(item);
                }
            }
              
            ProjectIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ProjectIdFilter, ProjectIdFilterselectedFilterItemList); 
            WhereClause wc = new WhereClause();
            if (ProjectIdFilterselectedFilterItemList == null || ProjectIdFilterselectedFilterItemList.Count == 0)
                wc.RunQuery = false;
            else            
            {
                foreach (string item in ProjectIdFilterselectedFilterItemList)
                {
            	  
                    wc.iOR(ProjectsTable.ProjectId, BaseFilter.ComparisonOperator.EqualsTo, item);                  
                  
                                 
                }
            }
            return wc;
        
        }
      

    
        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    this.LoadData();
                    this.DataBind();					
                    
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            this.SaveToSession(this.SortControl, this.SortControl.SelectedValue);
                  
            this.SaveToSession(this.DateOfCheckFromFilter, this.DateOfCheckFromFilter.Text);
                  
            this.SaveToSession(this.DateOfCheckToFilter, this.DateOfCheckToFilter.Text);
                  
            ArrayList GroupIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.GroupIdFilter, null);
            string GroupIdFilterSessionString = "";
            if (GroupIdFilterselectedFilterItemList != null){
                foreach (string item in GroupIdFilterselectedFilterItemList){
                    GroupIdFilterSessionString = String.Concat(GroupIdFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.GroupIdFilter, GroupIdFilterSessionString);
                  
            ArrayList ProjectIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ProjectIdFilter, null);
            string ProjectIdFilterSessionString = "";
            if (ProjectIdFilterselectedFilterItemList != null){
                foreach (string item in ProjectIdFilterselectedFilterItemList){
                    ProjectIdFilterSessionString = String.Concat(ProjectIdFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession(this.ProjectIdFilter, ProjectIdFilterSessionString);
                  
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
            this.SaveToSession(this.SortControl, this.SortControl.SelectedValue);
                  
      this.SaveToSession("DateOfCheckFromFilter_Ajax", this.DateOfCheckFromFilter.Text);
              
      this.SaveToSession("DateOfCheckToFilter_Ajax", this.DateOfCheckToFilter.Text);
              
            ArrayList GroupIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.GroupIdFilter, null);
            string GroupIdFilterSessionString = "";
            if (GroupIdFilterselectedFilterItemList != null){
                foreach (string item in GroupIdFilterselectedFilterItemList){
                    GroupIdFilterSessionString = String.Concat(GroupIdFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("GroupIdFilter_Ajax", GroupIdFilterSessionString);
          
            ArrayList ProjectIdFilterselectedFilterItemList = MiscUtils.GetSelectedValueList(this.ProjectIdFilter, null);
            string ProjectIdFilterSessionString = "";
            if (ProjectIdFilterselectedFilterItemList != null){
                foreach (string item in ProjectIdFilterselectedFilterItemList){
                    ProjectIdFilterSessionString = String.Concat(ProjectIdFilterSessionString ,"," , item);
                }
            }
            this.SaveToSession("ProjectIdFilter_Ajax", ProjectIdFilterSessionString);
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SortControl);
            this.RemoveFromSession(this.DateOfCheckFromFilter);
            this.RemoveFromSession(this.DateOfCheckToFilter);
            this.RemoveFromSession(this.GroupIdFilter);
            this.RemoveFromSession(this.ProjectIdFilter);
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["TrapRecordsTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Pagination");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["TrapRecordsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetImportButton()                
              
        {
        							
                    this.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=TrapRecords" ;
                    this.ImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.ImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetNewButton()                
              
        {
        
              try
              {
                    string url = "../TrapRecords/Add-TrapRecords.aspx?TabVisible=False&SaveAndNewVisible=False";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "TrapRecordsTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "TrapRecordsTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                       
                    this.NewButton.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, NewButton_ClickNewButton_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetPDFButton()                
              
        {
        
   
        }
            
        public virtual void SetResetButton()                
              
        {
        
   
        }
            
        public virtual void SetWordButton()                
              
        {
        
   
        }
            
        public virtual void SetActionsButton()                
              
        {
        
   
        }
            
        public virtual void SetFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "FiltersButton"));
         themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(GroupIdFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(ProjectIdFilter))
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Pagination_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_LastPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_NextPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for LinkButton
        public virtual void Pagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Pagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Pagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Pagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        

        // Generate the event handling functions for sorting events.
        

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void ExcelButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            
            // To customize the columns or the format, override this function in Section 1 of the page
            // and modify it to your liking.
            // Build the where clause based on the current filter and search criteria
            // Create the Order By clause based on the user's current sorting preference.
            
                WhereClause wc = null;
                wc = CreateWhereClause();
                OrderBy orderBy = null;
              
                orderBy = CreateOrderBy();
              
              bool done = false;
              object val = "";
              CompoundFilter join = CreateCompoundJoinFilter();
              
              // Read pageSize records at a time and write out the Excel file.
              int totalRowsReturned = 0;


              this.TotalRecords = TrapRecordsTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             TrapRecordsTable.BaitType,
             TrapRecordsTable.DateOfCheck,
             TrapRecordsTable.Species,
             TrapRecordsTable.Sex,
             TrapRecordsTable.Comment,
             TrapRecordsTable.LocationId,
             TrapRecordsTable.ProjectId,
             TrapRecordsTable.GroupId,
             TrapRecordsTable.TrapTypeId,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(TrapRecordsTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(TrapRecordsTable.Instance, wc, orderBy, columns,join);

                //  Read pageSize records at a time and write out the CSV file.
                while (!done)
                {
                ArrayList recList = dataForCSV.GetRows(exportData.pageSize);
                if (recList == null)
                break; //we are done

                totalRowsReturned = recList.Count;
                foreach (BaseRecord rec in recList)
                {
                foreach (BaseColumn col in dataForCSV.ColumnList)
                {
                if (col == null)
                continue;

                if (!dataForCSV.IncludeInExport(col))
                continue;

                val = rec.GetValue(col).ToString();
                exportData.WriteColumnData(val, dataForCSV.IsString(col));
                }
                exportData.WriteNewRow();
                }

                //  If we already are below the pageSize, then we are done.
                if (totalRowsReturned < exportData.pageSize)
                {
                done = true;
                }
                }
                exportData.FinishExport(this.Page.Response);
              
              }
              else
              {
              // Create an instance of the ExportDataToExcel class with the table class, where clause and order by.
              ExportDataToExcel excelReport = new ExportDataToExcel(TrapRecordsTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(TrapRecordsTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(TrapRecordsTable.BaitType, "Default"));
             data.ColumnList.Add(new ExcelColumn(TrapRecordsTable.DateOfCheck, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(TrapRecordsTable.Species, "Default"));
             data.ColumnList.Add(new ExcelColumn(TrapRecordsTable.Sex, "Default"));
             data.ColumnList.Add(new ExcelColumn(TrapRecordsTable.Comment, "Default"));
             data.ColumnList.Add(new ExcelColumn(TrapRecordsTable.LocationId, "Default"));
             data.ColumnList.Add(new ExcelColumn(TrapRecordsTable.ProjectId, "Default"));
             data.ColumnList.Add(new ExcelColumn(TrapRecordsTable.GroupId, "Default"));
             data.ColumnList.Add(new ExcelColumn(TrapRecordsTable.TrapTypeId, "Default"));


              //  First write out the Column Headers
              foreach (ExcelColumn col in data.ColumnList)
              {
              width = excelReport.GetExcelCellWidth(col);
              if (data.IncludeInExport(col))
              {
              excelReport.AddColumnToExcelBook(columnCounter, col.ToString(), excelReport.GetExcelDataType(col), width, excelReport.GetDisplayFormat(col));
              columnCounter++;
              }
              }
              
              while (!done)
              {
              ArrayList recList = data.GetRows(excelReport.pageSize);

              if (recList == null)
              {
              break;
              }
              totalRowsReturned = recList.Count;

              foreach (BaseRecord rec in recList)
              {
              excelReport.AddRowToExcelBook();
              columnCounter = 0;
              foreach (ExcelColumn col in data.ColumnList)
              {
              if (!data.IncludeInExport(col))
              continue;

              Boolean _isExpandableNonCompositeForeignKey = col.DisplayColumn.TableDefinition.IsExpandableNonCompositeForeignKey(col.DisplayColumn);
              if (_isExpandableNonCompositeForeignKey && col.DisplayColumn.IsApplyDisplayAs)
              {
                val = TrapRecordsTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
                if (String.IsNullOrEmpty(val as string))
                {
                  val = rec.Format(col.DisplayColumn);
                }
              }
              else
                val = excelReport.GetValueForExcelExport(col, rec);
              
              excelReport.AddCellToExcelRow(columnCounter, excelReport.GetExcelDataType(col), val, col.DisplayFormat);

              columnCounter++;
              }
              }

              // If we already are below the pageSize, then we are done.
              if (totalRowsReturned < excelReport.pageSize)
              {
              done = true;
              }
              }
              excelReport.SaveExcelBook(this.Page.Response);
              }
            
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void ImportButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void NewButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../TrapRecords/Add-TrapRecords.aspx?TabVisible=False&SaveAndNewVisible=False";
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      
                    url = url + "&RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("Popup") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(this, "TrapRecordsTableControl_PostbackTracker").ClientID);                           
                                
                string javascriptCall = "";
                
                    javascriptCall = "initializePopupPage(document.getElementById('" + MiscUtils.FindControlRecursively(this, "TrapRecordsTableControl_PostbackTracker").ClientID + "'), '" + url + "', true, event);";                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "NewButton_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void PDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-TrapRecords-Table.PDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "TrapRecords";
                // If Show-TrapRecords-Table.PDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(TrapRecordsTable.BaitType.Name, ReportEnum.Align.Left, "${BaitType}", ReportEnum.Align.Left, 28);
                 report.AddColumn(TrapRecordsTable.DateOfCheck.Name, ReportEnum.Align.Left, "${DateOfCheck}", ReportEnum.Align.Left, 20);
                 report.AddColumn(TrapRecordsTable.Species.Name, ReportEnum.Align.Left, "${Species}", ReportEnum.Align.Left, 28);
                 report.AddColumn(TrapRecordsTable.Sex.Name, ReportEnum.Align.Left, "${Sex}", ReportEnum.Align.Left, 15);
                 report.AddColumn(TrapRecordsTable.Comment.Name, ReportEnum.Align.Left, "${Comment}", ReportEnum.Align.Left, 28);
                 report.AddColumn(TrapRecordsTable.LocationId.Name, ReportEnum.Align.Left, "${LocationId}", ReportEnum.Align.Left, 17);
                 report.AddColumn(TrapRecordsTable.ProjectId.Name, ReportEnum.Align.Left, "${ProjectId}", ReportEnum.Align.Left, 20);
                 report.AddColumn(TrapRecordsTable.GroupId.Name, ReportEnum.Align.Left, "${GroupId}", ReportEnum.Align.Left, 16);
                 report.AddColumn(TrapRecordsTable.TrapTypeId.Name, ReportEnum.Align.Left, "${TrapTypeId}", ReportEnum.Align.Left, 18);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "RatTrap");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = TrapRecordsTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = TrapRecordsTable.GetRecordCount(joinFilter,whereClause);
                TrapRecordsRecord[] records = null;
                
                do
                {
                    
                    records = TrapRecordsTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( TrapRecordsRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 if (BaseClasses.Utils.MiscUtils.IsNull(record.BaitType)){
                                 report.AddData("${BaitType}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.BaitType);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.BaitType.ToString(), TrapRecordsTable.BaitType,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.BaitType.IsApplyDisplayAs){
                                     report.AddData("${BaitType}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${BaitType}", record.Format(TrapRecordsTable.BaitType), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${DateOfCheck}", record.Format(TrapRecordsTable.DateOfCheck), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.Species)){
                                 report.AddData("${Species}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.Species);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.Species.ToString(), TrapRecordsTable.Species,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.Species.IsApplyDisplayAs){
                                     report.AddData("${Species}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${Species}", record.Format(TrapRecordsTable.Species), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.Sex)){
                                 report.AddData("${Sex}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.Sex);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.Sex.ToString(), TrapRecordsTable.Sex,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.Sex.IsApplyDisplayAs){
                                     report.AddData("${Sex}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${Sex}", record.Format(TrapRecordsTable.Sex), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${Comment}", record.Format(TrapRecordsTable.Comment), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.LocationId)){
                                 report.AddData("${LocationId}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.LocationId);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.LocationId.ToString(), TrapRecordsTable.LocationId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.LocationId.IsApplyDisplayAs){
                                     report.AddData("${LocationId}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${LocationId}", record.Format(TrapRecordsTable.LocationId), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ProjectId)){
                                 report.AddData("${ProjectId}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.ProjectId);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.ProjectId.ToString(), TrapRecordsTable.ProjectId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.ProjectId.IsApplyDisplayAs){
                                     report.AddData("${ProjectId}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ProjectId}", record.Format(TrapRecordsTable.ProjectId), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.GroupId)){
                                 report.AddData("${GroupId}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.GroupId);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.GroupId.ToString(), TrapRecordsTable.GroupId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.GroupId.IsApplyDisplayAs){
                                     report.AddData("${GroupId}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${GroupId}", record.Format(TrapRecordsTable.GroupId), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.TrapTypeId)){
                                 report.AddData("${TrapTypeId}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.TrapTypeId);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.TrapTypeId.ToString(), TrapRecordsTable.TrapTypeId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.TrapTypeId.IsApplyDisplayAs){
                                     report.AddData("${TrapTypeId}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${TrapTypeId}", record.Format(TrapRecordsTable.TrapTypeId), ReportEnum.Align.Left);
                                 }
                             }

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                	
                
                report.Close();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".pdf", report.ReportInByteArray, 0, true);
            
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void ResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.GroupIdFilter.ClearSelection();
            
              this.ProjectIdFilter.ClearSelection();
            
           
            this.SortControl.ClearSelection();
          
              this.DateOfCheckFromFilter.Text = "";
            
              this.DateOfCheckToFilter.Text = "";
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
                  
              }
                

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
                
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void WordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("Show-TrapRecords-Table.WordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "TrapRecords";
                // If Show-TrapRecords-Table.WordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(TrapRecordsTable.BaitType.Name, ReportEnum.Align.Left, "${BaitType}", ReportEnum.Align.Left, 28);
                 report.AddColumn(TrapRecordsTable.DateOfCheck.Name, ReportEnum.Align.Left, "${DateOfCheck}", ReportEnum.Align.Left, 20);
                 report.AddColumn(TrapRecordsTable.Species.Name, ReportEnum.Align.Left, "${Species}", ReportEnum.Align.Left, 28);
                 report.AddColumn(TrapRecordsTable.Sex.Name, ReportEnum.Align.Left, "${Sex}", ReportEnum.Align.Left, 15);
                 report.AddColumn(TrapRecordsTable.Comment.Name, ReportEnum.Align.Left, "${Comment}", ReportEnum.Align.Left, 28);
                 report.AddColumn(TrapRecordsTable.LocationId.Name, ReportEnum.Align.Left, "${LocationId}", ReportEnum.Align.Left, 17);
                 report.AddColumn(TrapRecordsTable.ProjectId.Name, ReportEnum.Align.Left, "${ProjectId}", ReportEnum.Align.Left, 20);
                 report.AddColumn(TrapRecordsTable.GroupId.Name, ReportEnum.Align.Left, "${GroupId}", ReportEnum.Align.Left, 16);
                 report.AddColumn(TrapRecordsTable.TrapTypeId.Name, ReportEnum.Align.Left, "${TrapTypeId}", ReportEnum.Align.Left, 18);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = TrapRecordsTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "RatTrap");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = TrapRecordsTable.GetColumnList();
                TrapRecordsRecord[] records = null;
                do
                {
                    records = TrapRecordsTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( TrapRecordsRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.BaitType)){
                                 report.AddData("${BaitType}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.BaitType);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.BaitType.ToString(), TrapRecordsTable.BaitType,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.BaitType.IsApplyDisplayAs){
                                     report.AddData("${BaitType}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${BaitType}", record.Format(TrapRecordsTable.BaitType), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${DateOfCheck}", record.Format(TrapRecordsTable.DateOfCheck), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.Species)){
                                 report.AddData("${Species}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.Species);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.Species.ToString(), TrapRecordsTable.Species,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.Species.IsApplyDisplayAs){
                                     report.AddData("${Species}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${Species}", record.Format(TrapRecordsTable.Species), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.Sex)){
                                 report.AddData("${Sex}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.Sex);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.Sex.ToString(), TrapRecordsTable.Sex,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.Sex.IsApplyDisplayAs){
                                     report.AddData("${Sex}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${Sex}", record.Format(TrapRecordsTable.Sex), ReportEnum.Align.Left, 300);
                                 }
                             }
                             report.AddData("${Comment}", record.Format(TrapRecordsTable.Comment), ReportEnum.Align.Left, 300);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.LocationId)){
                                 report.AddData("${LocationId}", "",ReportEnum.Align.Left, 300);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.LocationId);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.LocationId.ToString(), TrapRecordsTable.LocationId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.LocationId.IsApplyDisplayAs){
                                     report.AddData("${LocationId}", _DFKA,ReportEnum.Align.Left, 300);
                                 }else{
                                     report.AddData("${LocationId}", record.Format(TrapRecordsTable.LocationId), ReportEnum.Align.Left, 300);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.ProjectId)){
                                 report.AddData("${ProjectId}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.ProjectId);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.ProjectId.ToString(), TrapRecordsTable.ProjectId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.ProjectId.IsApplyDisplayAs){
                                     report.AddData("${ProjectId}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${ProjectId}", record.Format(TrapRecordsTable.ProjectId), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.GroupId)){
                                 report.AddData("${GroupId}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.GroupId);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.GroupId.ToString(), TrapRecordsTable.GroupId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.GroupId.IsApplyDisplayAs){
                                     report.AddData("${GroupId}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${GroupId}", record.Format(TrapRecordsTable.GroupId), ReportEnum.Align.Left);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.TrapTypeId)){
                                 report.AddData("${TrapTypeId}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = TrapRecordsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(TrapRecordsTable.TrapTypeId);
                                 _DFKA = TrapRecordsTable.GetDFKA(record.TrapTypeId.ToString(), TrapRecordsTable.TrapTypeId,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  TrapRecordsTable.TrapTypeId.IsApplyDisplayAs){
                                     report.AddData("${TrapTypeId}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${TrapTypeId}", record.Format(TrapRecordsTable.TrapTypeId), ReportEnum.Align.Left);
                                 }
                             }

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                report.save();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".doc", report.ReportInByteArray, 0, true);
          
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void ActionsButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FilterButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void FiltersButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        


        // Generate the event handling functions for filter and search events.
        
        // event handler for OrderSort
        protected virtual void SortControl_SelectedIndexChanged(object sender, EventArgs args)
        {
              
                  string SelVal1 = this.SortControl.SelectedValue.ToUpper();
                  string[] words1 = SelVal1.Split(' ');
                  if (SelVal1 != "" )
                  {
                  SelVal1 = SelVal1.Replace(words1[words1.Length - 1], "").TrimEnd();
                  foreach (BaseClasses.Data.BaseColumn ColumnNam in TrapRecordsTable.GetColumns())
                  {
                  if (ColumnNam.Name.ToUpper().Equals(SelVal1))
                  {
                  SelVal1 = ColumnNam.InternalName;
                  }
                  }
                  }

                
                OrderByItem sd = this.CurrentSortOrder.Find(TrapRecordsTable.GetColumnByName(SelVal1));
                if (sd == null || this.CurrentSortOrder.Items != null)
                {
                // First time sort, so add sort order for Discontinued.
                if (TrapRecordsTable.GetColumnByName(SelVal1) != null)
                {
                  this.CurrentSortOrder.Reset();
                }

                //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

                
                  if (SelVal1 != "--PLEASE_SELECT--" && TrapRecordsTable.GetColumnByName(SelVal1) != null)
                  {
                    if (words1[words1.Length - 1].Contains("ASC"))
                  {
                  this.CurrentSortOrder.Add(TrapRecordsTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc);
                    }
                    else
                    {
                      if (words1[words1.Length - 1].Contains("DESC"))
                  {
                  this.CurrentSortOrder.Add(TrapRecordsTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc );
                      }
                    }
                  }
                
                }
                this.DataChanged = true;
              				
        }
            
        // event handler for FieldFilter
        protected virtual void GroupIdFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void ProjectIdFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = TrapRecordsTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                          
                }
                this._TotalRecords = value;
            }
        }

      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / Convert.ToDouble(this.PageSize)));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  TrapRecordsRecord[] DataSource {
             
            get {
                return (TrapRecordsRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public RatTrap.UI.IThemeButtonWithArrow ActionsButton {
            get {
                return (RatTrap.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActionsButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox DateOfCheckFromFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DateOfCheckFromFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal DateOfCheckLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DateOfCheckLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox DateOfCheckToFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DateOfCheckToFilter");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExcelButton");
            }
        }
        
        public RatTrap.UI.IThemeButton FilterButton {
            get {
                return (RatTrap.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FilterButton");
            }
        }
        
        public RatTrap.UI.IThemeButtonWithArrow FiltersButton {
            get {
                return (RatTrap.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FiltersButton");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector GroupIdFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GroupIdFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal GroupIdLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GroupIdLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ImportButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ImportButton");
            }
        }
        
        public System.Web.UI.WebControls.Label Label {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Label");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton NewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NewButton");
            }
        }
        
        public RatTrap.UI.IPaginationMedium Pagination {
            get {
                return (RatTrap.UI.IPaginationMedium)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Pagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PDFButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PDFButton");
            }
        }
        
        public BaseClasses.Web.UI.WebControls.QuickSelector ProjectIdFilter {
            get {
                return (BaseClasses.Web.UI.WebControls.QuickSelector)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ProjectIdFilter");
            }
        }              
        
        public System.Web.UI.WebControls.Literal ProjectIdLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ProjectIdLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ResetButton");
            }
        }
        
        public System.Web.UI.WebControls.Label SortByLabel {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortByLabel");
            }
        }
        
          public System.Web.UI.WebControls.DropDownList SortControl {
          get {
          return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SortControl");
          }
          }
        
        public System.Web.UI.WebControls.Literal Title0 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title0");
            }
        }
        
        public System.Web.UI.WebControls.Literal TrapRecordsCountControl {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TrapRecordsCountControl");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton WordButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "WordButton");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
        }
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                TrapRecordsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "RatTrap"));
                }

        TrapRecordsRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                TrapRecordsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "RatTrap"));
                }

        TrapRecordsRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual TrapRecordsTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual TrapRecordsTableControlRow[] GetSelectedRecordControls()
        {
        
            return (TrapRecordsTableControlRow[])((new ArrayList()).ToArray(Type.GetType("RatTrap.UI.Controls.Show_TrapRecords_Table.TrapRecordsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            TrapRecordsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "RatTrap"));
            }
            
            foreach (TrapRecordsTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual TrapRecordsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "TrapRecordsTableControlRow");
	          List<TrapRecordsTableControlRow> list = new List<TrapRecordsTableControlRow>();
	          foreach (TrapRecordsTableControlRow recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
        }

        public new BaseApplicationPage Page 
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }
        
                

        
        
#endregion


    }
  

#endregion
    
  
}

  