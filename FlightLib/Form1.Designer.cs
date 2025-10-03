namespace FlightLib
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ida = new System.Windows.Forms.TextBox();
            this.xia = new System.Windows.Forms.TextBox();
            this.yia = new System.Windows.Forms.TextBox();
            this.xfa = new System.Windows.Forms.TextBox();
            this.yfa = new System.Windows.Forms.TextBox();
            this.va = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flightPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posición actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posición final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Velocidad";
            // 
            // ida
            // 
            this.ida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ida.Location = new System.Drawing.Point(186, 61);
            this.ida.Name = "ida";
            this.ida.Size = new System.Drawing.Size(100, 22);
            this.ida.TabIndex = 4;
            // 
            // xia
            // 
            this.xia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xia.Location = new System.Drawing.Point(186, 102);
            this.xia.Name = "xia";
            this.xia.Size = new System.Drawing.Size(100, 22);
            this.xia.TabIndex = 5;
            // 
            // yia
            // 
            this.yia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yia.Location = new System.Drawing.Point(357, 102);
            this.yia.Name = "yia";
            this.yia.Size = new System.Drawing.Size(100, 22);
            this.yia.TabIndex = 6;
            // 
            // xfa
            // 
            this.xfa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xfa.Location = new System.Drawing.Point(186, 136);
            this.xfa.Name = "xfa";
            this.xfa.Size = new System.Drawing.Size(100, 22);
            this.xfa.TabIndex = 7;
            // 
            // yfa
            // 
            this.yfa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yfa.Location = new System.Drawing.Point(357, 136);
            this.yfa.Name = "yfa";
            this.yfa.Size = new System.Drawing.Size(100, 22);
            this.yfa.TabIndex = 8;
            // 
            // va
            // 
            this.va.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.va.Location = new System.Drawing.Point(186, 170);
            this.va.Name = "va";
            this.va.Size = new System.Drawing.Size(100, 22);
            this.va.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Introducir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightPlanToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flightPlanToolStripMenuItem
            // 
            this.flightPlanToolStripMenuItem.Name = "flightPlanToolStripMenuItem";
            this.flightPlanToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.flightPlanToolStripMenuItem.Text = "FlightPlan";
            this.flightPlanToolStripMenuItem.Click += new System.EventHandler(this.flightPlanToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.va);
            this.Controls.Add(this.yfa);
            this.Controls.Add(this.xfa);
            this.Controls.Add(this.yia);
            this.Controls.Add(this.xia);
            this.Controls.Add(this.ida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ida;
        private System.Windows.Forms.TextBox xia;
        private System.Windows.Forms.TextBox yia;
        private System.Windows.Forms.TextBox xfa;
        private System.Windows.Forms.TextBox yfa;
        private System.Windows.Forms.TextBox va;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flightPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.Label label5;
    }
}