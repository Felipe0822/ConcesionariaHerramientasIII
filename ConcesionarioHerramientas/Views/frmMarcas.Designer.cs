namespace ConcesionarioHerramientas.Views
{
    partial class frmMarcas
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
            btnMazda = new Button();
            label1 = new Label();
            label2 = new Label();
            btoPorche = new Button();
            btnChevrolet = new Button();
            btnRenault = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnMazda
            // 
            btnMazda.Anchor = AnchorStyles.Top;
            btnMazda.Location = new Point(332, 131);
            btnMazda.Name = "btnMazda";
            btnMazda.Size = new Size(106, 34);
            btnMazda.TabIndex = 0;
            btnMazda.Text = "Mazda";
            btnMazda.UseVisualStyleBackColor = true;
            btnMazda.Click += btnMazda_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 71);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 2;
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(198, 56);
            label2.Name = "label2";
            label2.Size = new Size(407, 40);
            label2.TabIndex = 3;
            label2.Text = "Seleccione la marca deseada";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btoPorche
            // 
            btoPorche.Anchor = AnchorStyles.Top;
            btoPorche.Location = new Point(332, 200);
            btoPorche.Name = "btoPorche";
            btoPorche.Size = new Size(106, 34);
            btoPorche.TabIndex = 4;
            btoPorche.Text = "Porsche";
            btoPorche.UseVisualStyleBackColor = true;
            btoPorche.Click += btoPorche_Click;
            // 
            // btnChevrolet
            // 
            btnChevrolet.Anchor = AnchorStyles.Top;
            btnChevrolet.Location = new Point(332, 268);
            btnChevrolet.Name = "btnChevrolet";
            btnChevrolet.Size = new Size(106, 34);
            btnChevrolet.TabIndex = 5;
            btnChevrolet.Text = "Chevrolet";
            btnChevrolet.UseVisualStyleBackColor = true;
            btnChevrolet.Click += btnChevrolet_Click;
            // 
            // btnRenault
            // 
            btnRenault.Anchor = AnchorStyles.Top;
            btnRenault.Location = new Point(332, 342);
            btnRenault.Name = "btnRenault";
            btnRenault.Size = new Size(106, 34);
            btnRenault.TabIndex = 6;
            btnRenault.Text = "Renault";
            btnRenault.UseVisualStyleBackColor = true;
            btnRenault.Click += btnRenault_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top;
            btnSalir.Location = new Point(546, 226);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 34);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmMarcas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnRenault);
            Controls.Add(btnChevrolet);
            Controls.Add(btoPorche);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMazda);
            Name = "frmMarcas";
            Text = "Marcas";
            WindowState = FormWindowState.Maximized;
            Load += frmMarcas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMazda;
        private Label label1;
        private Label label2;
        private Button btoPorche;
        private Button btnChevrolet;
        private Button btnRenault;
        private Button btnSalir;
    }
}