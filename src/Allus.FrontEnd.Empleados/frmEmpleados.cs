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

namespace Allus.FrontEnd.Empleados
{
    public partial class frmEmpleados : ucBase
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                      
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            btnExit.Text = "Guardar";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se guardó con éxito el empleado");
        }
    }
}
