
namespace ProyectoFinal.Forms
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.btnSuma = new Guna.UI2.WinForms.Guna2Button();
            this.btnResta = new Guna.UI2.WinForms.Guna2Button();
            this.btnMulti = new Guna.UI2.WinForms.Guna2Button();
            this.btnDivision = new Guna.UI2.WinForms.Guna2Button();
            this.btnRaiz = new Guna.UI2.WinForms.Guna2Button();
            this.btnSiete = new Guna.UI2.WinForms.Guna2Button();
            this.btnOcho = new Guna.UI2.WinForms.Guna2Button();
            this.btnNueve = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCuatro = new Guna.UI2.WinForms.Guna2Button();
            this.btnCinco = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeis = new Guna.UI2.WinForms.Guna2Button();
            this.btnUno = new Guna.UI2.WinForms.Guna2Button();
            this.btnDos = new Guna.UI2.WinForms.Guna2Button();
            this.btnTres = new Guna.UI2.WinForms.Guna2Button();
            this.btnEquals = new Guna.UI2.WinForms.Guna2Button();
            this.btnPunto = new Guna.UI2.WinForms.Guna2Button();
            this.btnCero = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalir = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panel1.SuspendLayout();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnEquals);
            this.panel1.Controls.Add(this.btnPunto);
            this.panel1.Controls.Add(this.btnCero);
            this.panel1.Controls.Add(this.btnUno);
            this.panel1.Controls.Add(this.btnDos);
            this.panel1.Controls.Add(this.btnTres);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnCuatro);
            this.panel1.Controls.Add(this.btnCinco);
            this.panel1.Controls.Add(this.btnSeis);
            this.panel1.Controls.Add(this.btnRaiz);
            this.panel1.Controls.Add(this.btnSiete);
            this.panel1.Controls.Add(this.btnOcho);
            this.panel1.Controls.Add(this.btnNueve);
            this.panel1.Controls.Add(this.btnDivision);
            this.panel1.Controls.Add(this.btnMulti);
            this.panel1.Controls.Add(this.btnResta);
            this.panel1.Controls.Add(this.btnSuma);
            this.panel1.Controls.Add(this.txtScreen);
            this.panel1.Controls.Add(this.txtResultado);
            this.panel1.Controls.Add(this.panelBarra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 405);
            this.panel1.TabIndex = 0;
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.panelBarra.Controls.Add(this.btnSalir);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(236, 23);
            this.panelBarra.TabIndex = 0;
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseDown);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtResultado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtResultado.Location = new System.Drawing.Point(9, 29);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(218, 30);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtScreen
            // 
            this.txtScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.txtScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.txtScreen.ForeColor = System.Drawing.SystemColors.Window;
            this.txtScreen.Location = new System.Drawing.Point(9, 61);
            this.txtScreen.Multiline = true;
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.ReadOnly = true;
            this.txtScreen.Size = new System.Drawing.Size(218, 43);
            this.txtScreen.TabIndex = 2;
            this.txtScreen.Text = "0";
            this.txtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSuma
            // 
            this.btnSuma.CheckedState.Parent = this.btnSuma;
            this.btnSuma.CustomImages.Parent = this.btnSuma;
            this.btnSuma.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuma.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuma.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuma.DisabledState.Parent = this.btnSuma;
            this.btnSuma.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.btnSuma.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.Color.White;
            this.btnSuma.HoverState.Parent = this.btnSuma;
            this.btnSuma.Location = new System.Drawing.Point(9, 116);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.ShadowDecoration.Parent = this.btnSuma;
            this.btnSuma.Size = new System.Drawing.Size(50, 50);
            this.btnSuma.TabIndex = 3;
            this.btnSuma.Text = "+";
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.CheckedState.Parent = this.btnResta;
            this.btnResta.CustomImages.Parent = this.btnResta;
            this.btnResta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResta.DisabledState.Parent = this.btnResta;
            this.btnResta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.btnResta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.Color.White;
            this.btnResta.HoverState.Parent = this.btnResta;
            this.btnResta.Location = new System.Drawing.Point(65, 116);
            this.btnResta.Name = "btnResta";
            this.btnResta.ShadowDecoration.Parent = this.btnResta;
            this.btnResta.Size = new System.Drawing.Size(50, 50);
            this.btnResta.TabIndex = 4;
            this.btnResta.Text = "-";
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.CheckedState.Parent = this.btnMulti;
            this.btnMulti.CustomImages.Parent = this.btnMulti;
            this.btnMulti.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMulti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMulti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMulti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMulti.DisabledState.Parent = this.btnMulti;
            this.btnMulti.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.btnMulti.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.Color.White;
            this.btnMulti.HoverState.Parent = this.btnMulti;
            this.btnMulti.Location = new System.Drawing.Point(177, 116);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.ShadowDecoration.Parent = this.btnMulti;
            this.btnMulti.Size = new System.Drawing.Size(50, 50);
            this.btnMulti.TabIndex = 5;
            this.btnMulti.Text = "×";
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.CheckedState.Parent = this.btnDivision;
            this.btnDivision.CustomImages.Parent = this.btnDivision;
            this.btnDivision.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDivision.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDivision.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDivision.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDivision.DisabledState.Parent = this.btnDivision;
            this.btnDivision.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.btnDivision.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.White;
            this.btnDivision.HoverState.Parent = this.btnDivision;
            this.btnDivision.Location = new System.Drawing.Point(121, 116);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.ShadowDecoration.Parent = this.btnDivision;
            this.btnDivision.Size = new System.Drawing.Size(50, 50);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "÷";
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.CheckedState.Parent = this.btnRaiz;
            this.btnRaiz.CustomImages.Parent = this.btnRaiz;
            this.btnRaiz.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRaiz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRaiz.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRaiz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRaiz.DisabledState.Parent = this.btnRaiz;
            this.btnRaiz.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.btnRaiz.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.ForeColor = System.Drawing.Color.White;
            this.btnRaiz.HoverState.Parent = this.btnRaiz;
            this.btnRaiz.Location = new System.Drawing.Point(177, 172);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.ShadowDecoration.Parent = this.btnRaiz;
            this.btnRaiz.Size = new System.Drawing.Size(50, 50);
            this.btnRaiz.TabIndex = 10;
            this.btnRaiz.Text = "√";
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.CheckedState.Parent = this.btnSiete;
            this.btnSiete.CustomImages.Parent = this.btnSiete;
            this.btnSiete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSiete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSiete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSiete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSiete.DisabledState.Parent = this.btnSiete;
            this.btnSiete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnSiete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.ForeColor = System.Drawing.Color.White;
            this.btnSiete.HoverState.Parent = this.btnSiete;
            this.btnSiete.Location = new System.Drawing.Point(9, 172);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.ShadowDecoration.Parent = this.btnSiete;
            this.btnSiete.Size = new System.Drawing.Size(50, 50);
            this.btnSiete.TabIndex = 9;
            this.btnSiete.Text = "7";
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.CheckedState.Parent = this.btnOcho;
            this.btnOcho.CustomImages.Parent = this.btnOcho;
            this.btnOcho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOcho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOcho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOcho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOcho.DisabledState.Parent = this.btnOcho;
            this.btnOcho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnOcho.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.ForeColor = System.Drawing.Color.White;
            this.btnOcho.HoverState.Parent = this.btnOcho;
            this.btnOcho.Location = new System.Drawing.Point(65, 172);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.ShadowDecoration.Parent = this.btnOcho;
            this.btnOcho.Size = new System.Drawing.Size(50, 50);
            this.btnOcho.TabIndex = 8;
            this.btnOcho.Text = "8";
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.CheckedState.Parent = this.btnNueve;
            this.btnNueve.CustomImages.Parent = this.btnNueve;
            this.btnNueve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNueve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNueve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNueve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNueve.DisabledState.Parent = this.btnNueve;
            this.btnNueve.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnNueve.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.ForeColor = System.Drawing.Color.White;
            this.btnNueve.HoverState.Parent = this.btnNueve;
            this.btnNueve.Location = new System.Drawing.Point(121, 172);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.ShadowDecoration.Parent = this.btnNueve;
            this.btnNueve.Size = new System.Drawing.Size(50, 50);
            this.btnNueve.TabIndex = 7;
            this.btnNueve.Text = "9";
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.CheckedState.Parent = this.btnCerrar;
            this.btnCerrar.CustomImages.Parent = this.btnCerrar;
            this.btnCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrar.DisabledState.Parent = this.btnCerrar;
            this.btnCerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.HoverState.Parent = this.btnCerrar;
            this.btnCerrar.Location = new System.Drawing.Point(177, 228);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ShadowDecoration.Parent = this.btnCerrar;
            this.btnCerrar.Size = new System.Drawing.Size(50, 50);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "←";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.CheckedState.Parent = this.btnCuatro;
            this.btnCuatro.CustomImages.Parent = this.btnCuatro;
            this.btnCuatro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCuatro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCuatro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCuatro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCuatro.DisabledState.Parent = this.btnCuatro;
            this.btnCuatro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnCuatro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.ForeColor = System.Drawing.Color.White;
            this.btnCuatro.HoverState.Parent = this.btnCuatro;
            this.btnCuatro.Location = new System.Drawing.Point(9, 228);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.ShadowDecoration.Parent = this.btnCuatro;
            this.btnCuatro.Size = new System.Drawing.Size(50, 50);
            this.btnCuatro.TabIndex = 13;
            this.btnCuatro.Text = "4";
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.CheckedState.Parent = this.btnCinco;
            this.btnCinco.CustomImages.Parent = this.btnCinco;
            this.btnCinco.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCinco.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCinco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCinco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCinco.DisabledState.Parent = this.btnCinco;
            this.btnCinco.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnCinco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.Color.White;
            this.btnCinco.HoverState.Parent = this.btnCinco;
            this.btnCinco.Location = new System.Drawing.Point(65, 228);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.ShadowDecoration.Parent = this.btnCinco;
            this.btnCinco.Size = new System.Drawing.Size(50, 50);
            this.btnCinco.TabIndex = 12;
            this.btnCinco.Text = "5";
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.CheckedState.Parent = this.btnSeis;
            this.btnSeis.CustomImages.Parent = this.btnSeis;
            this.btnSeis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeis.DisabledState.Parent = this.btnSeis;
            this.btnSeis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnSeis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.Color.White;
            this.btnSeis.HoverState.Parent = this.btnSeis;
            this.btnSeis.Location = new System.Drawing.Point(121, 228);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.ShadowDecoration.Parent = this.btnSeis;
            this.btnSeis.Size = new System.Drawing.Size(50, 50);
            this.btnSeis.TabIndex = 11;
            this.btnSeis.Text = "6";
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnUno
            // 
            this.btnUno.CheckedState.Parent = this.btnUno;
            this.btnUno.CustomImages.Parent = this.btnUno;
            this.btnUno.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUno.DisabledState.Parent = this.btnUno;
            this.btnUno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnUno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.ForeColor = System.Drawing.Color.White;
            this.btnUno.HoverState.Parent = this.btnUno;
            this.btnUno.Location = new System.Drawing.Point(9, 284);
            this.btnUno.Name = "btnUno";
            this.btnUno.ShadowDecoration.Parent = this.btnUno;
            this.btnUno.Size = new System.Drawing.Size(50, 50);
            this.btnUno.TabIndex = 17;
            this.btnUno.Text = "1";
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.CheckedState.Parent = this.btnDos;
            this.btnDos.CustomImages.Parent = this.btnDos;
            this.btnDos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDos.DisabledState.Parent = this.btnDos;
            this.btnDos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnDos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.ForeColor = System.Drawing.Color.White;
            this.btnDos.HoverState.Parent = this.btnDos;
            this.btnDos.Location = new System.Drawing.Point(65, 284);
            this.btnDos.Name = "btnDos";
            this.btnDos.ShadowDecoration.Parent = this.btnDos;
            this.btnDos.Size = new System.Drawing.Size(50, 50);
            this.btnDos.TabIndex = 16;
            this.btnDos.Text = "2";
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnTres
            // 
            this.btnTres.CheckedState.Parent = this.btnTres;
            this.btnTres.CustomImages.Parent = this.btnTres;
            this.btnTres.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTres.DisabledState.Parent = this.btnTres;
            this.btnTres.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnTres.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.Color.White;
            this.btnTres.HoverState.Parent = this.btnTres;
            this.btnTres.Location = new System.Drawing.Point(121, 284);
            this.btnTres.Name = "btnTres";
            this.btnTres.ShadowDecoration.Parent = this.btnTres;
            this.btnTres.Size = new System.Drawing.Size(50, 50);
            this.btnTres.TabIndex = 15;
            this.btnTres.Text = "3";
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.CheckedState.Parent = this.btnEquals;
            this.btnEquals.CustomImages.Parent = this.btnEquals;
            this.btnEquals.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEquals.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEquals.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEquals.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEquals.DisabledState.Parent = this.btnEquals;
            this.btnEquals.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnEquals.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.White;
            this.btnEquals.HoverState.Parent = this.btnEquals;
            this.btnEquals.Location = new System.Drawing.Point(177, 284);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.ShadowDecoration.Parent = this.btnEquals;
            this.btnEquals.Size = new System.Drawing.Size(50, 106);
            this.btnEquals.TabIndex = 22;
            this.btnEquals.Text = "=";
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.CheckedState.Parent = this.btnPunto;
            this.btnPunto.CustomImages.Parent = this.btnPunto;
            this.btnPunto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPunto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPunto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPunto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPunto.DisabledState.Parent = this.btnPunto;
            this.btnPunto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnPunto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.Color.White;
            this.btnPunto.HoverState.Parent = this.btnPunto;
            this.btnPunto.Location = new System.Drawing.Point(121, 340);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.ShadowDecoration.Parent = this.btnPunto;
            this.btnPunto.Size = new System.Drawing.Size(50, 50);
            this.btnPunto.TabIndex = 21;
            this.btnPunto.Text = ".";
            // 
            // btnCero
            // 
            this.btnCero.CheckedState.Parent = this.btnCero;
            this.btnCero.CustomImages.Parent = this.btnCero;
            this.btnCero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCero.DisabledState.Parent = this.btnCero;
            this.btnCero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnCero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.ForeColor = System.Drawing.Color.White;
            this.btnCero.HoverState.Parent = this.btnCero;
            this.btnCero.Location = new System.Drawing.Point(9, 340);
            this.btnCero.Name = "btnCero";
            this.btnCero.ShadowDecoration.Parent = this.btnCero;
            this.btnCero.Size = new System.Drawing.Size(106, 50);
            this.btnCero.TabIndex = 19;
            this.btnCero.Text = "0";
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.btnSalir.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.BorderColor2 = System.Drawing.Color.HotPink;
            this.btnSalir.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.btnSalir.BorderSize = 2;
            this.btnSalir.GradientAngle = 50F;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(208, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(19, 19);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 405);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCalculadora";
            this.Text = "FrmCalculadora";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.TextBox txtScreen;
        private System.Windows.Forms.TextBox txtResultado;
        private Guna.UI2.WinForms.Guna2Button btnEquals;
        private Guna.UI2.WinForms.Guna2Button btnPunto;
        private Guna.UI2.WinForms.Guna2Button btnCero;
        private Guna.UI2.WinForms.Guna2Button btnUno;
        private Guna.UI2.WinForms.Guna2Button btnDos;
        private Guna.UI2.WinForms.Guna2Button btnTres;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2Button btnCuatro;
        private Guna.UI2.WinForms.Guna2Button btnCinco;
        private Guna.UI2.WinForms.Guna2Button btnSeis;
        private Guna.UI2.WinForms.Guna2Button btnRaiz;
        private Guna.UI2.WinForms.Guna2Button btnSiete;
        private Guna.UI2.WinForms.Guna2Button btnOcho;
        private Guna.UI2.WinForms.Guna2Button btnNueve;
        private Guna.UI2.WinForms.Guna2Button btnDivision;
        private Guna.UI2.WinForms.Guna2Button btnMulti;
        private Guna.UI2.WinForms.Guna2Button btnResta;
        private Guna.UI2.WinForms.Guna2Button btnSuma;
        private RJCodeAdvance.RJControls.RJCircularPictureBox btnSalir;
    }
}