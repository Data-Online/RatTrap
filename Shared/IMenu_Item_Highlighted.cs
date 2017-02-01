
using Microsoft.VisualBasic;
  
namespace RatTrap.UI
{

  

    public interface IMenu_Item_Highlighted {

#region Interface Properties
        
        System.Web.UI.WebControls.LinkButton Button {get;}
                
      bool Visible {get; set;}
      string ID {get; set;}
         

#endregion

    }

  
}
  