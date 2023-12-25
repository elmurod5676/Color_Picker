namespace ColorPicker
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
            this.Rbar = new System.Windows.Forms.HScrollBar();
            this.Gbar = new System.Windows.Forms.HScrollBar();
            this.Bbar = new System.Windows.Forms.HScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorviewer = new System.Windows.Forms.Panel();
            this.Rlabel = new System.Windows.Forms.Label();
            this.Glabel = new System.Windows.Forms.Label();
            this.Blabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showcolor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rbar
            // 
            this.Rbar.Location = new System.Drawing.Point(135, 250);
            this.Rbar.Maximum = 264;
            this.Rbar.Name = "Rbar";
            this.Rbar.Size = new System.Drawing.Size(512, 28);
            this.Rbar.TabIndex = 0;
            this.Rbar.ValueChanged += new System.EventHandler(this.Rbar_ValueChanged);
            // 
            // Gbar
            // 
            this.Gbar.Location = new System.Drawing.Point(135, 285);
            this.Gbar.Maximum = 264;
            this.Gbar.Name = "Gbar";
            this.Gbar.Size = new System.Drawing.Size(512, 28);
            this.Gbar.TabIndex = 1;
            this.Gbar.ValueChanged += new System.EventHandler(this.Gbar_ValueChanged);
            // 
            // Bbar
            // 
            this.Bbar.Location = new System.Drawing.Point(135, 319);
            this.Bbar.Maximum = 264;
            this.Bbar.Name = "Bbar";
            this.Bbar.Size = new System.Drawing.Size(512, 28);
            this.Bbar.TabIndex = 2;
            this.Bbar.ValueChanged += new System.EventHandler(this.Bbar_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.colorviewer);
            this.panel1.Location = new System.Drawing.Point(135, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 202);
            this.panel1.TabIndex = 3;
            // 
            // colorviewer
            // 
            this.colorviewer.Location = new System.Drawing.Point(160, 50);
            this.colorviewer.Name = "colorviewer";
            this.colorviewer.Size = new System.Drawing.Size(169, 118);
            this.colorviewer.TabIndex = 4;
            // 
            // Rlabel
            // 
            this.Rlabel.AutoSize = true;
            this.Rlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rlabel.ForeColor = System.Drawing.Color.Red;
            this.Rlabel.Location = new System.Drawing.Point(651, 253);
            this.Rlabel.Name = "Rlabel";
            this.Rlabel.Size = new System.Drawing.Size(20, 22);
            this.Rlabel.TabIndex = 4;
            this.Rlabel.Text = "0";
            // 
            // Glabel
            // 
            this.Glabel.AutoSize = true;
            this.Glabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Glabel.ForeColor = System.Drawing.Color.Green;
            this.Glabel.Location = new System.Drawing.Point(651, 289);
            this.Glabel.Name = "Glabel";
            this.Glabel.Size = new System.Drawing.Size(20, 22);
            this.Glabel.TabIndex = 5;
            this.Glabel.Text = "0";
            // 
            // Blabel
            // 
            this.Blabel.AutoSize = true;
            this.Blabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blabel.ForeColor = System.Drawing.Color.Blue;
            this.Blabel.Location = new System.Drawing.Point(651, 321);
            this.Blabel.Name = "Blabel";
            this.Blabel.Size = new System.Drawing.Size(20, 22);
            this.Blabel.TabIndex = 6;
            this.Blabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(101, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(101, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(102, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "B";
            // 
            // showcolor
            // 
            this.showcolor.AutoSize = true;
            this.showcolor.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcolor.ForeColor = System.Drawing.Color.White;
            this.showcolor.Location = new System.Drawing.Point(365, 363);
            this.showcolor.Name = "showcolor";
            this.showcolor.Size = new System.Drawing.Size(48, 22);
            this.showcolor.TabIndex = 10;
            this.showcolor.Text = "color";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showcolor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Blabel);
            this.Controls.Add(this.Glabel);
            this.Controls.Add(this.Rlabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bbar);
            this.Controls.Add(this.Gbar);
            this.Controls.Add(this.Rbar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar Rbar;
        private System.Windows.Forms.HScrollBar Gbar;
        private System.Windows.Forms.HScrollBar Bbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel colorviewer;
        private System.Windows.Forms.Label Rlabel;
        private System.Windows.Forms.Label Glabel;
        private System.Windows.Forms.Label Blabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label showcolor;
    }
}

