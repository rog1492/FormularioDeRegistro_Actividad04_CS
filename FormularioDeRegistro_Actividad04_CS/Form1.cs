using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioDeRegistro_Actividad04_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            string apellido = txbApellido.Text;
            string telefono = txbTelefono.Text;
            string edad = txbEdad.Text;
            string estatura = txbEstatura.Text;
            string genero= "";
            if (rbMasculino.Checked) 
            {
                genero = "Masculino";
            }
            else if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }
            else if (rbOtros.Checked)
            {
                genero = "Otro";
            }

            if(Convert.ToInt64(telefono) > 9999999999 || Convert.ToInt64(telefono) < 1000000000)
            {
                MessageBox.Show("Teléfono inválido, Ingrese un numero telefonico valido", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            string mensaje = $"Nombre: {nombre}\nApellido: {apellido}\nTeléfono: {telefono}\nEdad: {edad}\nEstatura: {estatura}\nGénero: {genero}";

            string rutaFile = "C:\\Users\\broth\\Desktop\\Practica04\\Practica04.txt";
            bool ArchivoExiste = File.Exists(rutaFile);

            using (StreamWriter Escritor = new StreamWriter(rutaFile, true))
            {
                if (ArchivoExiste) 
                {
                    Escritor.WriteLine();
                }
                Escritor.WriteLine(mensaje);
            }
            MessageBox.Show(mensaje, "Registro de Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbNombre.Clear();
            txbApellido.Clear();
            txbTelefono.Clear();
            txbEdad.Clear();
            txbEstatura.Clear();
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            rbOtros.Checked = false;
        }
    }
}

