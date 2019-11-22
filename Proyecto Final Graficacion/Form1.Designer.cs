namespace Proyecto_Final_Graficacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZmenos = new System.Windows.Forms.Button();
            this.btnXmenos = new System.Windows.Forms.Button();
            this.btYmenos = new System.Windows.Forms.Button();
            this.btnZmas = new System.Windows.Forms.Button();
            this.btnYmas = new System.Windows.Forms.Button();
            this.btnXmas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(131, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1720, 642);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(334, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1240, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "MODELADO DE UNA CASA CON DIRECTX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnZmenos
            // 
            this.btnZmenos.BackColor = System.Drawing.Color.Honeydew;
            this.btnZmenos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnZmenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZmenos.Font = new System.Drawing.Font("Corbel", 15F);
            this.btnZmenos.ForeColor = System.Drawing.Color.DarkRed;
            this.btnZmenos.Location = new System.Drawing.Point(1161, 916);
            this.btnZmenos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZmenos.Name = "btnZmenos";
            this.btnZmenos.Size = new System.Drawing.Size(266, 57);
            this.btnZmenos.TabIndex = 18;
            this.btnZmenos.Text = "Z (-)";
            this.btnZmenos.UseVisualStyleBackColor = false;
            this.btnZmenos.Click += new System.EventHandler(this.btnZmenos_Click);
            // 
            // btnXmenos
            // 
            this.btnXmenos.BackColor = System.Drawing.Color.White;
            this.btnXmenos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXmenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXmenos.Font = new System.Drawing.Font("Corbel", 15F);
            this.btnXmenos.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnXmenos.Location = new System.Drawing.Point(305, 916);
            this.btnXmenos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXmenos.Name = "btnXmenos";
            this.btnXmenos.Size = new System.Drawing.Size(266, 57);
            this.btnXmenos.TabIndex = 17;
            this.btnXmenos.Text = "X (-)";
            this.btnXmenos.UseVisualStyleBackColor = false;
            this.btnXmenos.Click += new System.EventHandler(this.btnXmenos_Click_1);
            // 
            // btYmenos
            // 
            this.btYmenos.BackColor = System.Drawing.Color.Honeydew;
            this.btYmenos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btYmenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btYmenos.Font = new System.Drawing.Font("Corbel", 15F);
            this.btYmenos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btYmenos.Location = new System.Drawing.Point(723, 916);
            this.btYmenos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btYmenos.Name = "btYmenos";
            this.btYmenos.Size = new System.Drawing.Size(266, 57);
            this.btYmenos.TabIndex = 16;
            this.btYmenos.Text = "Y (-)";
            this.btYmenos.UseVisualStyleBackColor = false;
            this.btYmenos.Click += new System.EventHandler(this.btYmenos_Click);
            // 
            // btnZmas
            // 
            this.btnZmas.BackColor = System.Drawing.Color.Honeydew;
            this.btnZmas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnZmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZmas.Font = new System.Drawing.Font("Corbel", 15F);
            this.btnZmas.ForeColor = System.Drawing.Color.DarkRed;
            this.btnZmas.Location = new System.Drawing.Point(1161, 834);
            this.btnZmas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZmas.Name = "btnZmas";
            this.btnZmas.Size = new System.Drawing.Size(266, 57);
            this.btnZmas.TabIndex = 15;
            this.btnZmas.Text = "Z (+)";
            this.btnZmas.UseVisualStyleBackColor = false;
            this.btnZmas.Click += new System.EventHandler(this.btnZmas_Click);
            // 
            // btnYmas
            // 
            this.btnYmas.BackColor = System.Drawing.Color.Honeydew;
            this.btnYmas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnYmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYmas.Font = new System.Drawing.Font("Corbel", 15F);
            this.btnYmas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnYmas.Location = new System.Drawing.Point(723, 834);
            this.btnYmas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYmas.Name = "btnYmas";
            this.btnYmas.Size = new System.Drawing.Size(266, 57);
            this.btnYmas.TabIndex = 14;
            this.btnYmas.Text = "Y (+)";
            this.btnYmas.UseVisualStyleBackColor = false;
            this.btnYmas.Click += new System.EventHandler(this.btnYmas_Click);
            // 
            // btnXmas
            // 
            this.btnXmas.BackColor = System.Drawing.Color.White;
            this.btnXmas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXmas.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXmas.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnXmas.Location = new System.Drawing.Point(305, 834);
            this.btnXmas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXmas.Name = "btnXmas";
            this.btnXmas.Size = new System.Drawing.Size(266, 57);
            this.btnXmas.TabIndex = 13;
            this.btnXmas.Text = "X (+)";
            this.btnXmas.UseVisualStyleBackColor = false;
            this.btnXmas.Click += new System.EventHandler(this.btnXmas_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.btnXmas);
            this.Controls.Add(this.btnZmas);
            this.Controls.Add(this.btnZmenos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYmas);
            this.Controls.Add(this.btYmenos);
            this.Controls.Add(this.btnXmenos);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirectX: Modelado de casa con desplazamiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZmenos;
        private System.Windows.Forms.Button btnXmenos;
        private System.Windows.Forms.Button btYmenos;
        private System.Windows.Forms.Button btnZmas;
        private System.Windows.Forms.Button btnYmas;
        private System.Windows.Forms.Button btnXmas;
    }
}

