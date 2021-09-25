using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuintaClase
{
    public partial class MntoPersonas : Form
    {
        public MntoPersonas()
        {
            InitializeComponent();
        }

        private void Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                BPersona bPersona = new BPersona();
                Persona persona = new Persona
                {
                    Nombres = txtNombre.Text,
                    Apellidos = txtApellido.Text,
                    FechaIngreso = dtpFechaIngreso.Value,
                    FechaNacimiento = dtpFechaNacimiento.Value

                };
                bPersona.InsPersona(persona);
                Limpiar();
                MessageBox.Show("Inserto correctamente");

            }
            catch (Exception)
            {
                //Escribir log de errores
                MessageBox.Show("Error, Comunicarse con el Administrador");
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            dtpFechaIngreso.Value = DateTime.Now;
            dtpFechaNacimiento.Value = DateTime.Now;
        }
    }
}
