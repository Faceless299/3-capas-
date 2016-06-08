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
    public partial class Asignatura : Form
    {
        public Asignatura()
        {
            InitializeComponent();
        }

        private void Asignatura_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AccesoLogica.obtenerasignatura ();
        }
    }
}
