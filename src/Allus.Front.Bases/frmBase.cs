using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Allus.Front.Bases
{
    public partial class frmBase : Form
    {
        private List<string> controls = new List<string>();
        public Panel panel_IZQUIERDO;
        public Panel panel_DERECHO;
        public ucBase CurrentControl = null;
        public frmBase()
        {
            InitializeComponent();
        }

        public void CargarBotones()
        {
            ///Cargar aqui los btones configurados en el archivo 
            ButtonsMenuList btnList = null;
            
            System.Windows.Forms.Button btnItem = null;

            String str = Fwk.HelperFunctions.FileFunctions.OpenTextFile(@"ButtonsMenu.xml");
            btnList = Fwk.HelperFunctions.SerializationFunctions.DeserializeFromXml(typeof(ButtonsMenuList), str) as ButtonsMenuList;


            #region agregamos los botones aqui
            int tabIndex = 100;
            int yLoc = 40;            

            foreach (ButtonsMenu item in btnList)
            {
                btnItem = new Button();
                btnItem.Location = new System.Drawing.Point(30, yLoc);

                btnItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                btnItem.Name = string.Concat("btnEmpleado_", tabIndex++.ToString());
                btnItem.Size = new System.Drawing.Size(260, 41);
                btnItem.TabIndex = 0;
                btnItem.Text = item.Text;
                btnItem.UseVisualStyleBackColor = true;
                btnItem.Tag = item;
                panel_IZQUIERDO.Controls.Add(btnItem);

                yLoc = yLoc + yLoc + 10;

                btnItem.Click += BtnItem_Click;                     
            }

            #endregion

        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            ButtonsMenu wButtonsMenu = (ButtonsMenu)(((System.Windows.Forms.ButtonBase)(sender)).Tag);
            if (wButtonsMenu != null)
            {
                AddContronToPannel(wButtonsMenu);

                /*if (Convert.ToInt32(wButtonsMenu.ID) == 10001)
                {


                }*/
            }
        }

        void btnItem_MouseClick(object sender, MouseEventArgs e)
        {
            ButtonsMenu wButtonsMenu = (ButtonsMenu)(((System.Windows.Forms.ButtonBase)(sender)).Tag);
            if (wButtonsMenu != null)
            {
                AddContronToPannel(wButtonsMenu);

                /*if (Convert.ToInt32(wButtonsMenu.ID) == 10001)
                { 
                    
                        
                }*/
            }

        }


        public void AddContronToPannel(ButtonsMenu item)
        {
            ucBase ctrl = (ucBase)Fwk.HelperFunctions.ReflectionFunctions.CreateInstance(item.Component);
            ctrl.Parent = panel_DERECHO;
            ctrl.Key = item.ID;
            panel_DERECHO.Controls.Add(ctrl);
            ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            ctrl.OnExitControlEvent += new ExitControlHandler(ctrl_OnExitControlEvent);
            ctrl.BringToFront();
            ctrl.Refresh();
            
        }

        private void ctrl_OnExitControlEvent(ucBase luncherControl)
        {
            if (panel_DERECHO.Contains(luncherControl))
            {
                RemoveControlFromPannel((ucBase)luncherControl);
            }
        }
        public void RemoveControlFromPannel(ucBase ctrl)
        {
            if (ctrl != null)
            {
                if (panel_DERECHO.Contains(ctrl))
                {
                    panel_DERECHO.Controls.Remove(ctrl);
                    ctrl.Dispose();

                }
            }



        }

        private void frmBase_Load(object sender, EventArgs e)
        {

        }
    }
}
