
namespace Cronometru4
{
    partial class FormSettings
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
            this.rdBtnFormat0 = new System.Windows.Forms.RadioButton();
            this.rdBtnFormat1 = new System.Windows.Forms.RadioButton();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnLightMode = new System.Windows.Forms.Button();
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tip Cronometru";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdBtnFormat0
            // 
            this.rdBtnFormat0.AutoSize = true;
            this.rdBtnFormat0.Checked = true;
            this.rdBtnFormat0.Location = new System.Drawing.Point(226, 93);
            this.rdBtnFormat0.Name = "rdBtnFormat0";
            this.rdBtnFormat0.Size = new System.Drawing.Size(14, 13);
            this.rdBtnFormat0.TabIndex = 4;
            this.rdBtnFormat0.TabStop = true;
            this.rdBtnFormat0.UseVisualStyleBackColor = true;
            this.rdBtnFormat0.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdBtnFormat1
            // 
            this.rdBtnFormat1.AutoSize = true;
            this.rdBtnFormat1.Location = new System.Drawing.Point(296, 93);
            this.rdBtnFormat1.Name = "rdBtnFormat1";
            this.rdBtnFormat1.Size = new System.Drawing.Size(14, 13);
            this.rdBtnFormat1.TabIndex = 5;
            this.rdBtnFormat1.UseVisualStyleBackColor = true;
            this.rdBtnFormat1.CheckedChanged += new System.EventHandler(this.rdBtnFormat1_CheckedChanged);
            // 
            // btnLightMode
            // 
            this.btnLightMode.Location = new System.Drawing.Point(120, 178);
            this.btnLightMode.Name = "btnLightMode";
            this.btnLightMode.Size = new System.Drawing.Size(77, 23);
            this.btnLightMode.TabIndex = 6;
            this.btnLightMode.Text = "Light Mode";
            this.btnLightMode.UseVisualStyleBackColor = true;
            this.btnLightMode.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.Location = new System.Drawing.Point(252, 178);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(83, 23);
            this.btnDarkMode.TabIndex = 8;
            this.btnDarkMode.Text = "Dark Mode";
            this.btnDarkMode.UseVisualStyleBackColor = true;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDarkMode);
            this.Controls.Add(this.btnLightMode);
            this.Controls.Add(this.rdBtnFormat0);
            this.Controls.Add(this.rdBtnFormat1);
            this.Controls.Add(this.label1);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton rdBtnFormat0;
        public System.Windows.Forms.RadioButton rdBtnFormat1;
        public System.Windows.Forms.ColorDialog colorDialog;
        public System.Windows.Forms.Button btnLightMode;
        private System.Windows.Forms.Button btnDarkMode;
    }
}