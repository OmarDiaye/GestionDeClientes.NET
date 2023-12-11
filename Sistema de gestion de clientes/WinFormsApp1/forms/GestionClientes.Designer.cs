namespace WinFormsApp1
{
    partial class GestionClientes
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
            listClientes = new ListBox();
            txtNombre = new TextBox();
            label1 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblTarjetaDeCredito = new Label();
            txtTarjetaDeCredito = new TextBox();
            btnEditar = new Button();
            label2 = new Label();
            lblId = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 20;
            listClientes.Location = new Point(39, 28);
            listClientes.Margin = new Padding(3, 4, 3, 4);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(367, 484);
            listClientes.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(501, 63);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 67);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(585, 263);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 41);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(321, 521);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(414, 105);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(501, 101);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(194, 27);
            txtApellido.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(414, 144);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(501, 140);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(194, 27);
            txtTelefono.TabIndex = 7;
            // 
            // lblTarjetaDeCredito
            // 
            lblTarjetaDeCredito.AutoSize = true;
            lblTarjetaDeCredito.Location = new Point(414, 183);
            lblTarjetaDeCredito.Name = "lblTarjetaDeCredito";
            lblTarjetaDeCredito.Size = new Size(125, 20);
            lblTarjetaDeCredito.TabIndex = 10;
            lblTarjetaDeCredito.Text = "Tarjeta de credito";
            // 
            // txtTarjetaDeCredito
            // 
            txtTarjetaDeCredito.Location = new Point(465, 207);
            txtTarjetaDeCredito.Margin = new Padding(3, 4, 3, 4);
            txtTarjetaDeCredito.Name = "txtTarjetaDeCredito";
            txtTarjetaDeCredito.Size = new Size(229, 27);
            txtTarjetaDeCredito.TabIndex = 9;
            txtTarjetaDeCredito.TextChanged += txtTarjetaDeCredito_TextChanged;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(220, 521);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 28);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 13;
            label2.Text = "ID: ";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(550, 28);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 20);
            lblId.TabIndex = 14;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(110, 520);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 600);
            Controls.Add(btnAgregar);
            Controls.Add(lblId);
            Controls.Add(label2);
            Controls.Add(btnEditar);
            Controls.Add(lblTarjetaDeCredito);
            Controls.Add(txtTarjetaDeCredito);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(listClientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionClientes";
            Text = "Form1";
            Load += GestionClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listClientes;
        private TextBox txtNombre;
        private Label label1;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblTarjetaDeCredito;
        private TextBox txtTarjetaDeCredito;
        private Button btnEditar;
        private Label label2;
        private Label lblId;
        private Button btnAgregar;
    }
}