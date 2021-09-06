using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PjtReproductor
{
    public partial class Form1 : Form
    {

        
        int vl = 50;
        public OpenFileDialog archivo = new OpenFileDialog();
        int play = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          lblVolumen.Text=  (macTrackBar2Volumen.Value=Media.settings.volume = vl).ToString();
            this.Media.uiMode = "none";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            macTrackBar1Duracion.Value = macTrackBar1Duracion.Value + 10;
        }

        private void btnVolumen_Click(object sender, EventArgs e)
        {
            macTrackBar2Volumen.Visible = true;
        }

        private void macTrackBar2Volumen_MouseLeave(object sender, EventArgs e)
        {
            macTrackBar2Volumen.Visible = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (play == 1)
            {
                AbrirMusica();
                play = 2;
            }
            else if (play==2)
            {
                Media.Ctlcontrols.pause();
                tmSlider.Stop();
               
                btnPlayPause.BackgroundImage = Properties.Resources.Resume_Button_32;
                play = 3;
            }
            else if (play == 3)
            {
                Media.Ctlcontrols.play();
                tmSlider.Start();

                btnPlayPause.BackgroundImage = Properties.Resources.Pause_48;
                play = 2;
            }




        }
        
        public void AbrirMusica()
        {
            
            try
            {
                
                Media.URL = @"" + ruta;
                Media.Ctlcontrols.play();

                this.Visible = true;
                tmSlider.Start();

                macTrackBar1Duracion.Enabled = true;

                btnPlayPause.BackgroundImage = Properties.Resources.Pause_48;

            }
            catch 
            {

                
            }
            
                    
            }

        private void macTrackBar1Duracion_ValueChanged(object sender, decimal value)
        {
            macTrackBar1Duracion.Maximum = (int)Media.currentMedia.duration;

            if (macTrackBar1Duracion.Value == (int)Media.Ctlcontrols.currentPosition)
            {

            }
            else
            {

                Media.Ctlcontrols.currentPosition = macTrackBar1Duracion.Value;

            }

        }

        
        private void tmSlider_Tick(object sender, EventArgs e)
        {
            try
            {
                macTrackBar1Duracion.Value = (int)Media.Ctlcontrols.currentPosition;
                lblTimerIN.Text = Media.Ctlcontrols.currentPositionString;
                lblTimerFI.Text = Media.currentMedia.durationString;
            }
            catch 
            {

               
            }
            
        }

        private void btnRetr_Click(object sender, EventArgs e)
        {
            if ((macTrackBar1Duracion.Value = macTrackBar1Duracion.Value - 15) < 0)
            {
                macTrackBar1Duracion.Value = 0;
            }
            else
            {
                macTrackBar1Duracion.Value = macTrackBar1Duracion.Value - 15;
            }
            
        }
        string ruta; // variable donde se guardara la ruta del archivo multimedia

        public void AbrirArchivo() // metodo para buscar el archivo multimedia para abrir
        {

            archivo.Filter = "Archivo files|*.mp3;*.mp4;.*;";
            DialogResult dres1 = archivo.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            ruta = archivo.FileName;
            lblTitulo.Text = archivo.SafeFileName;


        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirArchivo();

                if (ruta != "")
                {
                    play = 2;
                    AbrirMusica();

                }
                else
                {
                    
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            
         
        }

        private void macTrackBar2Volumen_ValueChanged(object sender, decimal value)
        {
            Media.settings.volume = macTrackBar2Volumen.Value;



            lblVolumen.Text = Media.settings.volume.ToString();
        }
    }

    }

            

