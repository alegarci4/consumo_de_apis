using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Clase_3Mayo
{
    public partial class Form3 : Form
    {
        private HttpClient cliente = new HttpClient();

        public Form3()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnConsulta_Click(object sender, EventArgs e)
        {
            string pokemonName = txtNombre.Text.ToLower();
            string url = $"https://pokeapi.co/api/v2/pokemon/{pokemonName}";

            try
            {
                string response = await cliente.GetStringAsync(url);
                JObject data = JObject.Parse(response);
                lblNombre.Text = data["name"].ToString();
                lblPeso.Text = $"Peso:{data["weight"]}";
                lblAltura.Text = $"Altura:{data["height"]}";
                string imagenUrl = data["sprites"]["front_default"].ToString();
                pictureBox1.Load(imagenUrl);
                //lblPeso.Text = "prueba";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pokemon no encontrado" + ex.Message);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void buttonArchivo_Click(object sender, EventArgs e)
        {
            buttonArchivo.Click += buttonArchivo_Click;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo de texto (*.txt)|*.txt";
                saveFileDialog.Title = "Guardar información del personaje";
                saveFileDialog.FileName = "Resultado de Consulta.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("Nombre: " + lblNombre.Text);
                        writer.WriteLine("Peso: " + lblPeso.Text);
                        writer.WriteLine("Altura: " + lblAltura.Text);
                    }

                    MessageBox.Show("Información guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
