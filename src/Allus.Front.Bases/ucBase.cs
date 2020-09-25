using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allus.Front.Bases
{
        public delegate void ExitControlHandler(ucBase luncherControl);
    public partial class ucBase : UserControl
    {
        /// <summary>
        /// Envento lanzado por el control al Parent form para indicar que se a precionado algun boton de salir
        /// u ocurrio alguna señal qeu cerrar el user control
        /// </summary>
        public event ExitControlHandler OnExitControlEvent;
        public ucBase()
        {
            InitializeComponent();
        }

        public string Key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual void Exit()
        {
            if (OnExitControlEvent != null)
                OnExitControlEvent(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Exit();
        }
    }
}
