namespace MertekEgysegValto
{
    partial class Fo_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fo_Form));
            this.pnl_fejlec = new System.Windows.Forms.Panel();
            this.btn_konyha = new System.Windows.Forms.Button();
            this.btn_kemia = new System.Windows.Forms.Button();
            this.btn_fizika = new System.Windows.Forms.Button();
            this.lbl_cim = new System.Windows.Forms.Label();
            this.kemiaControl1 = new MertekEgysegValto.KemiaControl();
            this.fizikaControl1 = new MertekEgysegValto.FizikaControl();
            this.konyhaControl1 = new MertekEgysegValto.KonyhaControl();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_fejlec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_fejlec
            // 
            this.pnl_fejlec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(145)))), ((int)(((byte)(126)))));
            this.pnl_fejlec.Controls.Add(this.button1);
            this.pnl_fejlec.Controls.Add(this.btn_konyha);
            this.pnl_fejlec.Controls.Add(this.btn_kemia);
            this.pnl_fejlec.Controls.Add(this.btn_fizika);
            this.pnl_fejlec.Controls.Add(this.lbl_cim);
            this.pnl_fejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_fejlec.Location = new System.Drawing.Point(0, 0);
            this.pnl_fejlec.Name = "pnl_fejlec";
            this.pnl_fejlec.Size = new System.Drawing.Size(800, 136);
            this.pnl_fejlec.TabIndex = 0;
            // 
            // btn_konyha
            // 
            this.btn_konyha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(145)))), ((int)(((byte)(126)))));
            this.btn_konyha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_konyha.FlatAppearance.BorderSize = 0;
            this.btn_konyha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_konyha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_konyha.ForeColor = System.Drawing.Color.Black;
            this.btn_konyha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_konyha.Location = new System.Drawing.Point(264, 101);
            this.btn_konyha.Name = "btn_konyha";
            this.btn_konyha.Size = new System.Drawing.Size(70, 35);
            this.btn_konyha.TabIndex = 1;
            this.btn_konyha.Text = "konyhai";
            this.btn_konyha.UseVisualStyleBackColor = false;
            this.btn_konyha.Click += new System.EventHandler(this.btn_konyha_Click);
            // 
            // btn_kemia
            // 
            this.btn_kemia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(145)))), ((int)(((byte)(126)))));
            this.btn_kemia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kemia.FlatAppearance.BorderSize = 0;
            this.btn_kemia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kemia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kemia.ForeColor = System.Drawing.Color.Black;
            this.btn_kemia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kemia.Location = new System.Drawing.Point(197, 101);
            this.btn_kemia.Name = "btn_kemia";
            this.btn_kemia.Size = new System.Drawing.Size(70, 35);
            this.btn_kemia.TabIndex = 1;
            this.btn_kemia.Text = "kémiai";
            this.btn_kemia.UseVisualStyleBackColor = false;
            this.btn_kemia.Click += new System.EventHandler(this.btn_kemia_Click);
            // 
            // btn_fizika
            // 
            this.btn_fizika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(54)))));
            this.btn_fizika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fizika.FlatAppearance.BorderSize = 0;
            this.btn_fizika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fizika.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_fizika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(156)))), ((int)(((byte)(92)))));
            this.btn_fizika.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_fizika.Location = new System.Drawing.Point(130, 101);
            this.btn_fizika.Name = "btn_fizika";
            this.btn_fizika.Size = new System.Drawing.Size(70, 35);
            this.btn_fizika.TabIndex = 1;
            this.btn_fizika.Text = "fizikai";
            this.btn_fizika.UseVisualStyleBackColor = false;
            this.btn_fizika.Click += new System.EventHandler(this.btn_fizika_Click);
            // 
            // lbl_cim
            // 
            this.lbl_cim.AutoSize = true;
            this.lbl_cim.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cim.Location = new System.Drawing.Point(258, 9);
            this.lbl_cim.Name = "lbl_cim";
            this.lbl_cim.Size = new System.Drawing.Size(275, 32);
            this.lbl_cim.TabIndex = 0;
            this.lbl_cim.Text = "Mértékegység váltó";
            // 
            // kemiaControl1
            // 
            this.kemiaControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(54)))));
            this.kemiaControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kemiaControl1.Location = new System.Drawing.Point(0, 136);
            this.kemiaControl1.Name = "kemiaControl1";
            this.kemiaControl1.Size = new System.Drawing.Size(800, 314);
            this.kemiaControl1.TabIndex = 2;
            // 
            // fizikaControl1
            // 
            this.fizikaControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(54)))));
            this.fizikaControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fizikaControl1.Location = new System.Drawing.Point(0, 136);
            this.fizikaControl1.Name = "fizikaControl1";
            this.fizikaControl1.Size = new System.Drawing.Size(800, 314);
            this.fizikaControl1.TabIndex = 1;
            // 
            // konyhaControl1
            // 
            this.konyhaControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(54)))));
            this.konyhaControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.konyhaControl1.Location = new System.Drawing.Point(0, 136);
            this.konyhaControl1.Name = "konyhaControl1";
            this.konyhaControl1.Size = new System.Drawing.Size(800, 314);
            this.konyhaControl1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(758, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.konyhaControl1);
            this.Controls.Add(this.kemiaControl1);
            this.Controls.Add(this.fizikaControl1);
            this.Controls.Add(this.pnl_fejlec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fo_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_fejlec.ResumeLayout(false);
            this.pnl_fejlec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_fejlec;
        private System.Windows.Forms.Button btn_kemia;
        private System.Windows.Forms.Button btn_fizika;
        private System.Windows.Forms.Label lbl_cim;
        private System.Windows.Forms.Button btn_konyha;
        private FizikaControl fizikaControl1;
        private KemiaControl kemiaControl1;
        private KonyhaControl konyhaControl1;
        private System.Windows.Forms.Button button1;
    }
}

