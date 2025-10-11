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
            this.SuspendLayout();
            // 
            // miPanel
            // 
            this.miPanel.Location = new System.Drawing.Point(356, 190);
            this.miPanel.Name = "miPanel";
            this.miPanel.Size = new System.Drawing.Size(200, 100);
            this.miPanel.TabIndex = 0;
            // 
            // FormSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.miPanel);
            this.Name = "FormSimulacion";
            this.Text = "Simulacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel miPanel;
    }
}