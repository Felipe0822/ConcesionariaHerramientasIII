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
            SuspendLayout();
            // 
            // btnMazda
            // 
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
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(198, 56);
            label2.Name = "label2";
            label2.Size = new Size(407, 40);
            label2.TabIndex = 3;
            label2.Text = "Seleccione la marca deseada";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmMarcas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMazda);
            Name = "frmMarcas";
            Text = "Marcas";
            Load += frmMarcas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMazda;
        private Label label1;
        private Label label2;
    }
}