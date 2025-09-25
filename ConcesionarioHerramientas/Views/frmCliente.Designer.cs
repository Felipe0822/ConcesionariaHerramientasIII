namespace ConcesionarioHerramientas.Views
{
    partial class frmCliente
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCedula = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            btnContinuar = new Button();
            lblAuto = new Label();
            btnSalir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top;
            txtNombre.Location = new Point(326, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top;
            txtApellido.Location = new Point(326, 115);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 1;
            txtApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCedula
            // 
            txtCedula.Anchor = AnchorStyles.Top;
            txtCedula.Location = new Point(326, 165);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "Cedula";
            txtCedula.Size = new Size(125, 27);
            txtCedula.TabIndex = 2;
            txtCedula.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top;
            txtDireccion.Location = new Point(326, 222);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Dirección";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 3;
            txtDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top;
            txtTelefono.Location = new Point(326, 280);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 4;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Location = new Point(326, 331);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 5;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // btnContinuar
            // 
            btnContinuar.Anchor = AnchorStyles.Top;
            btnContinuar.Location = new Point(288, 380);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(94, 29);
            btnContinuar.TabIndex = 6;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // lblAuto
            // 
            lblAuto.Anchor = AnchorStyles.Top;
            lblAuto.AutoSize = true;
            lblAuto.Location = new Point(513, 165);
            lblAuto.Name = "lblAuto";
            lblAuto.Size = new Size(50, 20);
            lblAuto.TabIndex = 7;
            lblAuto.Text = "label1";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top;
            btnSalir.Location = new Point(404, 380);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(513, 118);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 9;
            label1.Text = "Estas comprando:";
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(lblAuto);
            Controls.Add(btnContinuar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtCedula);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "frmCliente";
            Text = "Cliente";
            WindowState = FormWindowState.Maximized;
            Load += frmCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCedula;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Button btnContinuar;
        private Label lblAuto;
        private Button btnSalir;
        private Label label1;
    }
}