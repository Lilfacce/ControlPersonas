using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPersonas
{
    public partial class Form1 : Form
    {
        //Clase  objeto
        //Instanciar la clase




        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Clase objeto
        //Instanciar una clase:
        //Crear un objeto de esa clase
        Persona persona = new Persona();

        private void buttonIngreso_Click(object sender, EventArgs e)
        {

            persona.Dpi = textBoxDpi.Text;
            persona.Nombre = textBoxNombre.Text;
            persona.Apellido = textBoxApellido.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            labelDpi.Text = persona.Dpi;
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelFecha.Text = persona.FechaNacimiento.ToShortDateString();
            label5.Text = persona.Edad().ToString();

            labelDpi.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelFecha.Visible = true;
            label5.Visible = true;
        }

        private void buttonPrimeraMayuscula_Click(object sender, EventArgs e)
        {
            persona.PrimeraMayuscula();
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.NormalizarNombre();
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;

        }
    }
}