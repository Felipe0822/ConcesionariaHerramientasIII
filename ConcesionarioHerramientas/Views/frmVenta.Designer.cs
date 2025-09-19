namespace ConcesionarioHerramientas.Views
{
    partial class frmVenta
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
            checkBox1 = new CheckBox();
            btoConfirmar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(147, 146);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btoConfirmar
            // 
            btoConfirmar.Location = new Point(266, 185);
            btoConfirmar.Name = "btoConfirmar";
            btoConfirmar.Size = new Size(94, 29);
            btoConfirmar.TabIndex = 1;
            btoConfirmar.Text = "Confirmar ";
            btoConfirmar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 85);
            label1.Name = "label1";
            label1.Size = new Size(313, 20);
            label1.TabIndex = 2;
            label1.Text = "Estas seguro que quieres compar el auntomvil";
            // 
           
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 364);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btoConfirmar);
            Controls.Add(checkBox1);
            Name = "frmVenta";
            Text = "frmVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button btoConfirmar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}