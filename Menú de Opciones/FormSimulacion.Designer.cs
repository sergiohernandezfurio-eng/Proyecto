namespace Menú_de_Opciones
{
    partial class FormSimulacion
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
            this.miPanel = new System.Windows.Forms.Panel();
            this.btnCiclo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // miPanel
            // 
            this.miPanel.Location = new System.Drawing.Point(14, 15);
            this.miPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.miPanel.Name = "miPanel";
            this.miPanel.Size = new System.Drawing.Size(726, 520);
            this.miPanel.TabIndex = 0;
            this.miPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.miPanel_Paint);
            // 
            // btnCiclo
            // 
            this.btnCiclo.Location = new System.Drawing.Point(765, 250);
            this.btnCiclo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCiclo.Name = "btnCiclo";
            this.btnCiclo.Size = new System.Drawing.Size(111, 40);
            this.btnCiclo.TabIndex = 1;
            this.btnCiclo.Text = "Un Ciclo";
            this.btnCiclo.UseVisualStyleBackColor = true;
            this.btnCiclo.Click += new System.EventHandler(this.btnCiclo_Click);
            // 
            // FormSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnCiclo);
            this.Controls.Add(this.miPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSimulacion";
            this.Text = "Simulacion";
            this.Load += new System.EventHandler(this.FormSimulacion_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel miPanel;
        private System.Windows.Forms.Button btnCiclo;
    }
}