namespace PjtReproductor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macTrackBar1Duracion = new XComponent.SliderBar.MACTrackBar();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.lblTimerFI = new System.Windows.Forms.Label();
            this.lblTimerIN = new System.Windows.Forms.Label();
            this.btnVolumen = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            this.btnRetr = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.macTrackBar2Volumen = new XComponent.SliderBar.MACTrackBar();
            this.tmSlider = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reproductorToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // reproductorToolStripMenuItem
            // 
            this.reproductorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.detenerToolStripMenuItem});
            this.reproductorToolStripMenuItem.Name = "reproductorToolStripMenuItem";
            this.reproductorToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.reproductorToolStripMenuItem.Text = "Reproductor";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.pausarToolStripMenuItem.Text = "Pausar";
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.detenerToolStripMenuItem.Text = "Detener";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // macTrackBar1Duracion
            // 
            this.macTrackBar1Duracion.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBar1Duracion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBar1Duracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.macTrackBar1Duracion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar1Duracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar1Duracion.IndentHeight = 6;
            this.macTrackBar1Duracion.LargeChange = 1;
            this.macTrackBar1Duracion.Location = new System.Drawing.Point(148, 15);
            this.macTrackBar1Duracion.Maximum = 100;
            this.macTrackBar1Duracion.Minimum = 0;
            this.macTrackBar1Duracion.Name = "macTrackBar1Duracion";
            this.macTrackBar1Duracion.Size = new System.Drawing.Size(434, 30);
            this.macTrackBar1Duracion.TabIndex = 1;
            this.macTrackBar1Duracion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar1Duracion.TickColor = System.Drawing.Color.White;
            this.macTrackBar1Duracion.TickHeight = 1;
            this.macTrackBar1Duracion.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.macTrackBar1Duracion.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBar1Duracion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar1Duracion.TrackLineHeight = 3;
            this.macTrackBar1Duracion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar1Duracion.Value = 0;
            this.macTrackBar1Duracion.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar1Duracion_ValueChanged);
            // 
            // Media
            // 
            this.Media.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(0, 24);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(683, 381);
            this.Media.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblVolumen);
            this.panel1.Controls.Add(this.lblTimerFI);
            this.panel1.Controls.Add(this.lblTimerIN);
            this.panel1.Controls.Add(this.btnVolumen);
            this.panel1.Controls.Add(this.btnSig);
            this.panel1.Controls.Add(this.btnRetr);
            this.panel1.Controls.Add(this.btnPlayPause);
            this.panel1.Controls.Add(this.macTrackBar1Duracion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 59);
            this.panel1.TabIndex = 3;
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(652, 28);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(19, 13);
            this.lblVolumen.TabIndex = 9;
            this.lblVolumen.Text = "00";
            // 
            // lblTimerFI
            // 
            this.lblTimerFI.AutoSize = true;
            this.lblTimerFI.Location = new System.Drawing.Point(543, 38);
            this.lblTimerFI.Name = "lblTimerFI";
            this.lblTimerFI.Size = new System.Drawing.Size(28, 13);
            this.lblTimerFI.TabIndex = 8;
            this.lblTimerFI.Text = "0:00";
            // 
            // lblTimerIN
            // 
            this.lblTimerIN.AutoSize = true;
            this.lblTimerIN.Location = new System.Drawing.Point(157, 38);
            this.lblTimerIN.Name = "lblTimerIN";
            this.lblTimerIN.Size = new System.Drawing.Size(28, 13);
            this.lblTimerIN.TabIndex = 7;
            this.lblTimerIN.Text = "0:00";
            // 
            // btnVolumen
            // 
            this.btnVolumen.BackgroundImage = global::PjtReproductor.Properties.Resources.Speaker_32;
            this.btnVolumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolumen.FlatAppearance.BorderSize = 0;
            this.btnVolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumen.Location = new System.Drawing.Point(620, 21);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(26, 26);
            this.btnVolumen.TabIndex = 6;
            this.btnVolumen.UseVisualStyleBackColor = true;
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click);
            // 
            // btnSig
            // 
            this.btnSig.BackgroundImage = global::PjtReproductor.Properties.Resources.Double_Right_32;
            this.btnSig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSig.FlatAppearance.BorderSize = 0;
            this.btnSig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSig.Location = new System.Drawing.Point(86, 15);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(29, 26);
            this.btnSig.TabIndex = 5;
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRetr
            // 
            this.btnRetr.BackgroundImage = global::PjtReproductor.Properties.Resources.Double_Left_32;
            this.btnRetr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetr.FlatAppearance.BorderSize = 0;
            this.btnRetr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRetr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetr.Location = new System.Drawing.Point(3, 15);
            this.btnRetr.Name = "btnRetr";
            this.btnRetr.Size = new System.Drawing.Size(29, 26);
            this.btnRetr.TabIndex = 4;
            this.btnRetr.UseVisualStyleBackColor = true;
            this.btnRetr.Click += new System.EventHandler(this.btnRetr_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackgroundImage = global::PjtReproductor.Properties.Resources.Circled_Play_48;
            this.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Location = new System.Drawing.Point(38, 6);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(42, 45);
            this.btnPlayPause.TabIndex = 3;
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // macTrackBar2Volumen
            // 
            this.macTrackBar2Volumen.BackColor = System.Drawing.Color.White;
            this.macTrackBar2Volumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBar2Volumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.macTrackBar2Volumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar2Volumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar2Volumen.IndentHeight = 6;
            this.macTrackBar2Volumen.Location = new System.Drawing.Point(637, 309);
            this.macTrackBar2Volumen.Maximum = 100;
            this.macTrackBar2Volumen.Minimum = 0;
            this.macTrackBar2Volumen.Name = "macTrackBar2Volumen";
            this.macTrackBar2Volumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.macTrackBar2Volumen.Size = new System.Drawing.Size(24, 115);
            this.macTrackBar2Volumen.TabIndex = 7;
            this.macTrackBar2Volumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar2Volumen.TickColor = System.Drawing.Color.White;
            this.macTrackBar2Volumen.TickHeight = 1;
            this.macTrackBar2Volumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.macTrackBar2Volumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.macTrackBar2Volumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar2Volumen.TrackLineHeight = 3;
            this.macTrackBar2Volumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar2Volumen.Value = 0;
            this.macTrackBar2Volumen.Visible = false;
            this.macTrackBar2Volumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar2Volumen_ValueChanged);
            this.macTrackBar2Volumen.MouseLeave += new System.EventHandler(this.macTrackBar2Volumen_MouseLeave);
            // 
            // tmSlider
            // 
            this.tmSlider.Tick += new System.EventHandler(this.tmSlider_Tick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(0, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(10, 13);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 464);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.macTrackBar2Volumen);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private XComponent.SliderBar.MACTrackBar macTrackBar1Duracion;
        private AxWMPLib.AxWindowsMediaPlayer Media;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolumen;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.Button btnRetr;
        private System.Windows.Forms.Button btnPlayPause;
        private XComponent.SliderBar.MACTrackBar macTrackBar2Volumen;
        private System.Windows.Forms.Label lblTimerIN;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Label lblTimerFI;
        private System.Windows.Forms.Timer tmSlider;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem reproductorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo;
    }
}

