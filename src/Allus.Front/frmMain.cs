using Allus.Front.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Allus.Front
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            frmBase fb = new frmBase();
            fb.panel_DERECHO = this.splitContainer1.Panel2;
            fb.panel_IZQUIERDO = this.splitContainer1.Panel1;
            fb.CargarBotones();
            fb.Show();
            
           
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //void Init()
        //{
        //    this.panel_IZQUIERDO = this.splitContainer1.Panel1;
        //    this.panel_DERECHO = this.splitContainer1.Panel2;
        //    this.CargarBotones();
        //}
    }
}
