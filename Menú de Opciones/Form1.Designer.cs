namespace Menú_de_Opciones
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIntroducir = new System.Windows.Forms.Button();
            this.vtext = new System.Windows.Forms.TextBox();
            this.yf = new System.Windows.Forms.TextBox();
            this.xf = new System.Windows.Forms.TextBox();
            this.yi = new System.Windows.Forms.TextBox();
            this.xi = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flightPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introducirDatosDeVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distanciaDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textDistancia = new System.Windows.Forms.TextBox();
            this.textTiempo = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIntroducir
            // 
            this.btnIntroducir.Location = new System.Drawing.Point(780, 512);
            this.btnIntroducir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIntroducir.Name = "btnIntroducir";
            this.btnIntroducir.Size = new System.Drawing.Size(107, 35);
            this.btnIntroducir.TabIndex = 36;
            this.btnIntroducir.Text = "Introducir";
            this.btnIntroducir.UseVisualStyleBackColor = true;
            this.btnIntroducir.Click += new System.EventHandler(this.button1_Click);
            // 
            // vtext
            // 
            this.vtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vtext.Location = new System.Drawing.Point(209, 224);
            this.vtext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vtext.Name = "vtext";
            this.vtext.Size = new System.Drawing.Size(112, 26);
            this.vtext.TabIndex = 35;
            // 
            // yf
            // 
            this.yf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yf.Location = new System.Drawing.Point(402, 181);
            this.yf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yf.Name = "yf";
            this.yf.Size = new System.Drawing.Size(112, 26);
            this.yf.TabIndex = 34;
            // 
            // xf
            // 
            this.xf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xf.Location = new System.Drawing.Point(209, 181);
            this.xf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xf.Name = "xf";
            this.xf.Size = new System.Drawing.Size(112, 26);
            this.xf.TabIndex = 33;
            // 
            // yi
            // 
            this.yi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yi.Location = new System.Drawing.Point(402, 139);
            this.yi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yi.Name = "yi";
            this.yi.Size = new System.Drawing.Size(112, 26);
            this.yi.TabIndex = 32;
            // 
            // xi
            // 
            this.xi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xi.Location = new System.Drawing.Point(209, 139);
            this.xi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xi.Name = "xi";
            this.xi.Size = new System.Drawing.Size(112, 26);
            this.xi.TabIndex = 31;
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Location = new System.Drawing.Point(209, 88);
            this.id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(112, 26);
            this.id.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Velocidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Posición final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Posición inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Identificador";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightPlanToolStripMenuItem,
            this.simulaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 33);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flightPlanToolStripMenuItem
            // 
            this.flightPlanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introducirDatosDeVueloToolStripMenuItem,
            this.distanciaDeSeguridadToolStripMenuItem});
            this.flightPlanToolStripMenuItem.Name = "flightPlanToolStripMenuItem";
            this.flightPlanToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.flightPlanToolStripMenuItem.Text = "Opciones";
            this.flightPlanToolStripMenuItem.Click += new System.EventHandler(this.flightPlanToolStripMenuItem_Click);
            // 
            // introducirDatosDeVueloToolStripMenuItem
            // 
            this.introducirDatosDeVueloToolStripMenuItem.Name = "introducirDatosDeVueloToolStripMenuItem";
            this.introducirDatosDeVueloToolStripMenuItem.Size = new System.Drawing.Size(435, 34);
            this.introducirDatosDeVueloToolStripMenuItem.Text = "Introducir datos de vuelo";
            this.introducirDatosDeVueloToolStripMenuItem.Click += new System.EventHandler(this.introducirDatosDeVueloToolStripMenuItem_Click);
            // 
            // distanciaDeSeguridadToolStripMenuItem
            // 
            this.distanciaDeSeguridadToolStripMenuItem.Name = "distanciaDeSeguridadToolStripMenuItem";
            this.distanciaDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(435, 34);
            this.distanciaDeSeguridadToolStripMenuItem.Text = "Distancia de seguridad y tiempo de ciclo";
            this.distanciaDeSeguridadToolStripMenuItem.Click += new System.EventHandler(this.distanciaDeSeguridadToolStripMenuItem_Click);
            // 
            // simulaciónToolStripMenuItem
            // 
            this.simulaciónToolStripMenuItem.Name = "simulaciónToolStripMenuItem";
            this.simulaciónToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.simulaciónToolStripMenuItem.Text = "Simulación";
            this.simulaciónToolStripMenuItem.Click += new System.EventHandler(this.simulaciónToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(178, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "X:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(371, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Y:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(666, 512);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 35);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Distancia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tiempo de ciclo";
            // 
            // textDistancia
            // 
            this.textDistancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDistancia.Location = new System.Drawing.Point(209, 361);
            this.textDistancia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textDistancia.Name = "textDistancia";
            this.textDistancia.Size = new System.Drawing.Size(112, 26);
            this.textDistancia.TabIndex = 44;
            // 
            // textTiempo
            // 
            this.textTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTiempo.Location = new System.Drawing.Point(209, 408);
            this.textTiempo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTiempo.Name = "textTiempo";
            this.textTiempo.Size = new System.Drawing.Size(112, 26);
            this.textTiempo.TabIndex = 45;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.textTiempo);
            this.Controls.Add(this.textDistancia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIntroducir);
            this.Controls.Add(this.vtext);
            this.Controls.Add(this.yf);
            this.Controls.Add(this.xf);
            this.Controls.Add(this.yi);
            this.Controls.Add(this.xi);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIntroducir;
        private System.Windows.Forms.TextBox vtext;
        private System.Windows.Forms.TextBox yf;
        private System.Windows.Forms.TextBox xf;
        private System.Windows.Forms.TextBox yi;
        private System.Windows.Forms.TextBox xi;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flightPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem introducirDatosDeVueloToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem distanciaDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textDistancia;
        private System.Windows.Forms.TextBox textTiempo;
        private System.Windows.Forms.ToolStripMenuItem simulaciónToolStripMenuItem;
    }
}

