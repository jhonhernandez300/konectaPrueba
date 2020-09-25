using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allus.Front.Bases
{
    public class ButtonsMenu : Fwk.Bases.Entity
    {
        public string ID { get; set; }
        public string Text { get; set; }
        public string Component { get; set; }
    }

    public class ButtonsMenuList : Fwk.Bases.Entities<ButtonsMenu>
    {

       /* public ButtonsMenu getButtons(string archivo)
        {
            ButtonsMenu buM = new ButtonsMenu();
            //FileStream fs = new FileStream(archivo, FileMode.Open);

            //buM = (ButtonsMenu)Common.Deserialize(typeof(ButtonsMenu), archivo);
            buM = (ButtonsMenu)Common.Deserialize(typeof(ArrayOfButtonsMenu), archivo);
            
            return buM;
        }*/

    }
}
