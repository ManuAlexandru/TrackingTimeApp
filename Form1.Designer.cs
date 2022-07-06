
namespace Cronometru4
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnPauza = new System.Windows.Forms.Button();
            this.panouAfisare = new System.Windows.Forms.Panel();
            this.afisareSecundePauza = new System.Windows.Forms.Label();
            this.afisareSecunde = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.afisareDate = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panouAfisare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afisareDate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(361, 223);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(190, 37);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(722, 47);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnPauza
            // 
            this.btnPauza.Location = new System.Drawing.Point(37, 37);
            this.btnPauza.Name = "btnPauza";
            this.btnPauza.Size = new System.Drawing.Size(75, 23);
            this.btnPauza.TabIndex = 4;
            this.btnPauza.Text = "S_Pauza";
            this.btnPauza.UseVisualStyleBackColor = true;
            this.btnPauza.Click += new System.EventHandler(this.button1_Click);
            // 
            // panouAfisare
            // 
            this.panouAfisare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panouAfisare.Controls.Add(this.afisareSecundePauza);
            this.panouAfisare.Controls.Add(this.afisareSecunde);
            this.panouAfisare.Controls.Add(this.btnPauza);
            this.panouAfisare.Controls.Add(this.btnStop);
            this.panouAfisare.Location = new System.Drawing.Point(249, 146);
            this.panouAfisare.Name = "panouAfisare";
            this.panouAfisare.Size = new System.Drawing.Size(305, 70);
            this.panouAfisare.TabIndex = 5;
            // 
            // afisareSecundePauza
            // 
            this.afisareSecundePauza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.afisareSecundePauza.Location = new System.Drawing.Point(37, 8);
            this.afisareSecundePauza.Name = "afisareSecundePauza";
            this.afisareSecundePauza.Size = new System.Drawing.Size(75, 23);
            this.afisareSecundePauza.TabIndex = 9;
            this.afisareSecundePauza.Text = "00:00:00";
            this.afisareSecundePauza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // afisareSecunde
            // 
            this.afisareSecunde.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.afisareSecunde.Location = new System.Drawing.Point(190, 8);
            this.afisareSecunde.Name = "afisareSecunde";
            this.afisareSecunde.Size = new System.Drawing.Size(75, 23);
            this.afisareSecunde.TabIndex = 8;
            this.afisareSecunde.Text = "00:00:00";
            this.afisareSecunde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(51, 47);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // afisareDate
            // 
            this.afisareDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.afisareDate.Location = new System.Drawing.Point(39, 286);
            this.afisareDate.Name = "afisareDate";
            this.afisareDate.RowTemplate.Height = 25;
            this.afisareDate.Size = new System.Drawing.Size(428, 184);
            this.afisareDate.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panouAfisare);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 522);
            this.panel1.TabIndex = 8;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(961, 523);
            this.Controls.Add(this.afisareDate);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panouAfisare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.afisareDate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.Button btnAdmin;
        public System.Windows.Forms.Button btnPauza;
        public System.Windows.Forms.Panel panouAfisare;
        public System.Windows.Forms.Button btnSettings;
        public System.Windows.Forms.DataGridView afisareDate;
        public System.Windows.Forms.Label afisareSecunde;
        public System.Windows.Forms.Label afisareSecundePauza;
        public System.Windows.Forms.Panel panel1;
    }
}

