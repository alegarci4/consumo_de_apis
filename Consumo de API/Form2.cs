using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_3Mayo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //metodo sincrono (simula un dekay)
        private void HacerCafe()
        {
            Thread.Sleep(5000);

        }
        private void TostarPan()
        {
            Thread.Sleep(5000);

        }
        private void ExprimirJugo()
        {
            Thread.Sleep(5000);

        }

        //Metodo async (version en paralelo)
        private async Task HacerCafeAsync()
        {
            await Task.Delay(5000);//5  segundos asincrono 
        }
        private async Task TostarPanAsync()
        {
            await Task.Delay(5000);//5  segundos asincrono 
        }
        private async Task ExprimirJugoAsync()
        {
            await Task.Delay(5000);//5  segundos asincrono 
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Indicando sincrono (bloqueanre)";
            Refresh();
            //tarea 1 hacer cafe 
            lblCafe.Text = "Iniciando sincrono (bloqueante)";
            HacerCafe();
            Refresh();
            lblCafe.Text = "Cafe listo";
            //tarea 2 hacer tostadas
            lblTostadas.Text = "Haciendo tostadas";
            TostarPan();
            Refresh();
            lblTostadas.Text = "Tostadas listas";
            //tarea 3 hacer jugo
            lblJugo.Text = "Haciendo jugo";
            ExprimirJugo();
            Refresh();
            lblJugo.Text = "Jugo listo";

        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            //version asincrona no bloqueante 
            lblEstado.Text = "Inciando Asincrono";
            Refresh();
            //Inicando todas las tareas en paralelo 
            var taskCafe = HacerCafeAsync();
            var taskTostadas = TostarPanAsync();
            var taskJugo = ExprimirJugoAsync();
            //Actualizar UI mientras se hacen las tareas 
            lblCafe.Text = "Haciendo cafe";
            lblTostadas.Text = "Haciendo tostadas";
            lblJugo.Text = "Haciendo jugo";
            //Esperar a que todas las tareas terminen
            await Task.WhenAll(taskCafe, taskTostadas, taskJugo);
            Refresh();
            //Actualizar UI cuando todas las tareas terminen
            lblCafe.Text = "Cafe listo";
            lblTostadas.Text = "Tostadas listas";
            lblJugo.Text = "Jugo listo";
            
        }
    }
}
