
using Microsoft.VisualBasic;
  
namespace RatTrap.UI
{

  

    public interface IMenuFull {

#region Interface Properties
        System.Web.UI.WebControls.Menu MultiLevelMenu {get;}
                
      bool Visible {get; set;}
      string ID {get; set;}
         

#endregion

    }

  
}
  