
namespace ProyectoFinal.Forms
{
    partial class FrmPresentation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresentation));
            this.barra = new Guna.UI2.WinForms.Guna2Panel();
            this.panelButtons = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelContenedorForm = new Guna.UI2.WinForms.Guna2Panel();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.btnDashboard = new RJCodeAdvance.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBarra = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtTIme = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIngresos = new RJCodeAdvance.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGastos = new RJCodeAdvance.RJControls.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaldo = new RJCodeAdvance.RJControls.RJButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPdf = new RJCodeAdvance.RJControls.RJButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.barra.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.barra.Controls.Add(this.pictureBox1);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.ShadowDecoration.Parent = this.barra;
            this.barra.Size = new System.Drawing.Size(1184, 39);
            this.barra.TabIndex = 0;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelButtons.Controls.Add(this.pictureBox3);
            this.panelButtons.Controls.Add(this.panel5);
            this.panelButtons.Controls.Add(this.btnPdf);
            this.panelButtons.Controls.Add(this.panel4);
            this.panelButtons.Controls.Add(this.btnSaldo);
            this.panelButtons.Controls.Add(this.panel3);
            this.panelButtons.Controls.Add(this.btnGastos);
            this.panelButtons.Controls.Add(this.panel2);
            this.panelButtons.Controls.Add(this.btnIngresos);
            this.panelButtons.Controls.Add(this.pictureBox2);
            this.panelButtons.Controls.Add(this.btnBarra);
            this.panelButtons.Controls.Add(this.panel1);
            this.panelButtons.Controls.Add(this.btnDashboard);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 39);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.ShadowDecoration.Parent = this.panelButtons;
            this.panelButtons.Size = new System.Drawing.Size(249, 622);
            this.panelButtons.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.panelContenedorForm);
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(249, 39);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(935, 622);
            this.guna2Panel3.TabIndex = 2;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.guna2Panel4.Controls.Add(this.labelFecha);
            this.guna2Panel4.Controls.Add(this.labelHora);
            this.guna2Panel4.Controls.Add(this.lblEstado);
            this.guna2Panel4.Controls.Add(this.label1);
            this.guna2Panel4.Controls.Add(this.lblNombre);
            this.guna2Panel4.Controls.Add(this.rjCircularPictureBox1);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 532);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(935, 90);
            this.guna2Panel4.TabIndex = 1;
            // 
            // panelContenedorForm
            // 
            this.panelContenedorForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelContenedorForm.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorForm.Name = "panelContenedorForm";
            this.panelContenedorForm.ShadowDecoration.Parent = this.panelContenedorForm;
            this.panelContenedorForm.Size = new System.Drawing.Size(935, 532);
            this.panelContenedorForm.TabIndex = 2;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjCircularPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(17, 4);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(81, 81);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            this.rjCircularPictureBox1.Click += new System.EventHandler(this.rjCircularPictureBox1_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnDashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.BorderSize = 0;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-2, 171);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(251, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "DashBoard";
            this.btnDashboard.TextColor = System.Drawing.Color.White;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel1.Location = new System.Drawing.Point(-10, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnBarra
            // 
            this.btnBarra.Image = ((System.Drawing.Image)(resources.GetObject("btnBarra.Image")));
            this.btnBarra.Location = new System.Drawing.Point(215, 0);
            this.btnBarra.Name = "btnBarra";
            this.btnBarra.Size = new System.Drawing.Size(34, 31);
            this.btnBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBarra.TabIndex = 2;
            this.btnBarra.TabStop = false;
            this.btnBarra.Click += new System.EventHandler(this.btnBarra_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(104, 7);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(122, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellidos";
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstado.Location = new System.Drawing.Point(105, 57);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado";
            // 
            // labelHora
            // 
            this.labelHora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.labelHora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHora.Location = new System.Drawing.Point(701, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(205, 54);
            this.labelHora.TabIndex = 4;
            this.labelHora.Text = "21:49:45";
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFecha.Location = new System.Drawing.Point(717, 54);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(174, 15);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1151, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(115, 580);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dtTIme
            // 
            this.dtTIme.Enabled = true;
            this.dtTIme.Tick += new System.EventHandler(this.dtTIme_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel2.Location = new System.Drawing.Point(-10, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 40);
            this.panel2.TabIndex = 5;
            // 
            // btnIngresos
            // 
            this.btnIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnIngresos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnIngresos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIngresos.BorderRadius = 0;
            this.btnIngresos.BorderSize = 0;
            this.btnIngresos.FlatAppearance.BorderSize = 0;
            this.btnIngresos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresos.ForeColor = System.Drawing.Color.White;
            this.btnIngresos.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresos.Image")));
            this.btnIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresos.Location = new System.Drawing.Point(-2, 217);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(251, 40);
            this.btnIngresos.TabIndex = 4;
            this.btnIngresos.Text = "Ingresos";
            this.btnIngresos.TextColor = System.Drawing.Color.White;
            this.btnIngresos.UseVisualStyleBackColor = false;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel3.Location = new System.Drawing.Point(-10, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 40);
            this.panel3.TabIndex = 7;
            // 
            // btnGastos
            // 
            this.btnGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnGastos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGastos.BorderRadius = 0;
            this.btnGastos.BorderSize = 0;
            this.btnGastos.FlatAppearance.BorderSize = 0;
            this.btnGastos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastos.ForeColor = System.Drawing.Color.White;
            this.btnGastos.Image = ((System.Drawing.Image)(resources.GetObject("btnGastos.Image")));
            this.btnGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastos.Location = new System.Drawing.Point(-2, 263);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(251, 40);
            this.btnGastos.TabIndex = 6;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.TextColor = System.Drawing.Color.White;
            this.btnGastos.UseVisualStyleBackColor = false;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel4.Location = new System.Drawing.Point(-10, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 40);
            this.panel4.TabIndex = 9;
            // 
            // btnSaldo
            // 
            this.btnSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnSaldo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnSaldo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSaldo.BorderRadius = 0;
            this.btnSaldo.BorderSize = 0;
            this.btnSaldo.FlatAppearance.BorderSize = 0;
            this.btnSaldo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaldo.ForeColor = System.Drawing.Color.White;
            this.btnSaldo.Image = ((System.Drawing.Image)(resources.GetObject("btnSaldo.Image")));
            this.btnSaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaldo.Location = new System.Drawing.Point(-2, 309);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(251, 40);
            this.btnSaldo.TabIndex = 8;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.TextColor = System.Drawing.Color.White;
            this.btnSaldo.UseVisualStyleBackColor = false;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel5.Location = new System.Drawing.Point(-10, 355);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(11, 40);
            this.panel5.TabIndex = 11;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnPdf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnPdf.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPdf.BorderRadius = 0;
            this.btnPdf.BorderSize = 0;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnPdf.Image")));
            this.btnPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPdf.Location = new System.Drawing.Point(-2, 355);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(251, 40);
            this.btnPdf.TabIndex = 10;
            this.btnPdf.Text = "PDF";
            this.btnPdf.TextColor = System.Drawing.Color.White;
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(64, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 89);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // FrmPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPresentation";
            this.Text = "FrmPresentation";
            this.barra.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel barra;
        private Guna.UI2.WinForms.Guna2Panel panelButtons;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJButton btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel panelContenedorForm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.PictureBox btnBarra;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer dtTIme;
        private System.Windows.Forms.Panel panel5;
        private RJCodeAdvance.RJControls.RJButton btnPdf;
        private System.Windows.Forms.Panel panel4;
        private RJCodeAdvance.RJControls.RJButton btnSaldo;
        private System.Windows.Forms.Panel panel3;
        private RJCodeAdvance.RJControls.RJButton btnGastos;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton btnIngresos;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}