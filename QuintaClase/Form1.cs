using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Business;

namespace QuintaClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BPersona bPersona = new BPersona();


            var result = bPersona.GetPersonas(
                new Persona
                {
                    Apellidos = txtApellidos.Text,
                    Nombres = txtNombres.Text
                }
                );

            dgvPersonas.DataSource = result;
            dgvPersonas.Refresh();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MntoPersonas mntoPersonas = new MntoPersonas();
            mntoPersonas.ShowDialog();
        }
    }
}
