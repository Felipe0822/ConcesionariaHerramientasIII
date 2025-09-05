namespace ConcesionarioHerramientas
{
    partial class frmMenu
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
            btnSalir = new Button();
            btnVerMarcas = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(344, 275);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 34);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnVerMarcas
            // 
            btnVerMarcas.Location = new Point(344, 200);
            btnVerMarcas.Name = "btnVerMarcas";
            btnVerMarcas.Size = new Size(123, 34);
            btnVerMarcas.TabIndex = 1;
            btnVerMarcas.Text = "Ver marcas";
            btnVerMarcas.UseVisualStyleBackColor = true;
            btnVerMarcas.Click += btnVerMarcas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 101);
            label1.Name = "label1";
            label1.Size = new Size(425, 40);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido a la concesionaria";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 450);
            Controls.Add(label1);
            Controls.Add(btnVerMarcas);
            Controls.Add(btnSalir);
            Name = "Menu";
            Text = "Menú";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnVerMarcas;
        private Label label1;
    }
}
