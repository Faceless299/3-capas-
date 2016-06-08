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
    public partial class Docente : Form
    {
        public Docente()
        {
            InitializeComponent();
        }
        private void Docente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AccesoLogica.ObtenerProductos();
        }
    }
}
