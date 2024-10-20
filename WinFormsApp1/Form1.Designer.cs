namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTipoVehiculo = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            lblCapacidadCarga = new Label();
            lblPasajeros = new Label();
            btnAgregar = new Button();
            btnIniciar = new Button();
            btnMoverse = new Button();
            btnDetenerse = new Button();
            cboTipoVehiculo = new ComboBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtCarga = new TextBox();
            txtPasajeros = new TextBox();
            txtBateria = new TextBox();
            lblBateria = new Label();
            btnCargar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Location = new Point(53, 80);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(151, 25);
            lblTipoVehiculo.TabIndex = 0;
            lblTipoVehiculo.Text = "Tipo de vehiculo: ";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(53, 143);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(64, 25);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(53, 197);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(78, 25);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo:";
            // 
            // lblCapacidadCarga
            // 
            lblCapacidadCarga.AutoSize = true;
            lblCapacidadCarga.Location = new Point(53, 260);
            lblCapacidadCarga.Name = "lblCapacidadCarga";
            lblCapacidadCarga.Size = new Size(172, 25);
            lblCapacidadCarga.TabIndex = 3;
            lblCapacidadCarga.Text = "Capacidad de carga:";
            // 
            // lblPasajeros
            // 
            lblPasajeros.AutoSize = true;
            lblPasajeros.Location = new Point(58, 260);
            lblPasajeros.Name = "lblPasajeros";
            lblPasajeros.Size = new Size(89, 25);
            lblPasajeros.TabIndex = 4;
            lblPasajeros.Text = "Pasajeros:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(505, 80);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(641, 136);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 34);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnMoverse
            // 
            btnMoverse.Location = new Point(505, 134);
            btnMoverse.Name = "btnMoverse";
            btnMoverse.Size = new Size(112, 34);
            btnMoverse.TabIndex = 7;
            btnMoverse.Text = "Moverse";
            btnMoverse.UseVisualStyleBackColor = true;
            btnMoverse.Click += btnMoverse_Click;
            // 
            // btnDetenerse
            // 
            btnDetenerse.Location = new Point(505, 188);
            btnDetenerse.Name = "btnDetenerse";
            btnDetenerse.Size = new Size(112, 34);
            btnDetenerse.TabIndex = 8;
            btnDetenerse.Text = "Detenerse";
            btnDetenerse.UseVisualStyleBackColor = true;
            btnDetenerse.Click += btnDetenerse_Click;
            // 
            // cboTipoVehiculo
            // 
            cboTipoVehiculo.FormattingEnabled = true;
            cboTipoVehiculo.Items.AddRange(new object[] { "Auto", "Camión", "Motocicleta", "Vehiculo Electrico" });
            cboTipoVehiculo.Location = new Point(269, 82);
            cboTipoVehiculo.Name = "cboTipoVehiculo";
            cboTipoVehiculo.Size = new Size(182, 33);
            cboTipoVehiculo.TabIndex = 9;
            cboTipoVehiculo.SelectedIndexChanged += cboTipoVehiculo_SelectedIndexChanged;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(269, 138);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(181, 31);
            txtMarca.TabIndex = 10;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(270, 197);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(180, 31);
            txtModelo.TabIndex = 11;
            // 
            // txtCarga
            // 
            txtCarga.Location = new Point(270, 260);
            txtCarga.Name = "txtCarga";
            txtCarga.Size = new Size(139, 31);
            txtCarga.TabIndex = 12;
            // 
            // txtPasajeros
            // 
            txtPasajeros.Location = new Point(270, 260);
            txtPasajeros.Name = "txtPasajeros";
            txtPasajeros.Size = new Size(150, 31);
            txtPasajeros.TabIndex = 13;
            // 
            // txtBateria
            // 
            txtBateria.Location = new Point(270, 260);
            txtBateria.Name = "txtBateria";
            txtBateria.Size = new Size(150, 31);
            txtBateria.TabIndex = 14;
            txtBateria.TextChanged += txtBateria_TextChanged;
            // 
            // lblBateria
            // 
            lblBateria.AutoSize = true;
            lblBateria.Location = new Point(53, 260);
            lblBateria.Name = "lblBateria";
            lblBateria.Size = new Size(146, 25);
            lblBateria.TabIndex = 15;
            lblBateria.Text = "Carga de bateria:";
            lblBateria.Click += label6_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(641, 82);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(112, 34);
            btnCargar.TabIndex = 16;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(641, 188);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnCargar);
            Controls.Add(lblBateria);
            Controls.Add(txtBateria);
            Controls.Add(txtPasajeros);
            Controls.Add(txtCarga);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(cboTipoVehiculo);
            Controls.Add(btnDetenerse);
            Controls.Add(btnMoverse);
            Controls.Add(btnIniciar);
            Controls.Add(btnAgregar);
            Controls.Add(lblPasajeros);
            Controls.Add(lblCapacidadCarga);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(lblTipoVehiculo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoVehiculo;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblCapacidadCarga;
        private Label lblPasajeros;
        private Button btnAgregar;
        private Button btnIniciar;
        private Button btnMoverse;
        private Button btnDetenerse;
        private ComboBox cboTipoVehiculo;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtCarga;
        private TextBox txtPasajeros;
        private TextBox txtBateria;
        private Label lblBateria;
        private Button btnCargar;
        private Button btnSalir;
    }
}
