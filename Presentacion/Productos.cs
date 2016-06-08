using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Docente frm = new Docente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            Alumno frm = new Alumno();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            Catalogo frm = new Catalogo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            Asignatura frm = new Asignatura();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

        
