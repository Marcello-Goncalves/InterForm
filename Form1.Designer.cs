namespace InterForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButtonSystem = new System.Windows.Forms.RadioButton();
            this.radioButtonEnglish = new System.Windows.Forms.RadioButton();
            this.radioButtonPortuguese = new System.Windows.Forms.RadioButton();
            this.radioButtonSpanish = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonSystem
            // 
            this.radioButtonSystem.AutoSize = true;
            this.radioButtonSystem.Location = new System.Drawing.Point(9, 1);
            this.radioButtonSystem.Name = "radioButtonSystem";
            this.radioButtonSystem.Size = new System.Drawing.Size(63, 19);
            this.radioButtonSystem.TabIndex = 0;
            this.radioButtonSystem.TabStop = true;
            this.radioButtonSystem.Text = "System";
            this.radioButtonSystem.UseVisualStyleBackColor = true;
            this.radioButtonSystem.CheckedChanged += new System.EventHandler(this.radioButtonSystem_CheckedChanged);
            // 
            // radioButtonEnglish
            // 
            this.radioButtonEnglish.AutoSize = true;
            this.radioButtonEnglish.Location = new System.Drawing.Point(8, 77);
            this.radioButtonEnglish.Name = "radioButtonEnglish";
            this.radioButtonEnglish.Size = new System.Drawing.Size(38, 19);
            this.radioButtonEnglish.TabIndex = 3;
            this.radioButtonEnglish.TabStop = true;
            this.radioButtonEnglish.Text = "En";
            this.radioButtonEnglish.UseVisualStyleBackColor = true;
            this.radioButtonEnglish.CheckedChanged += new System.EventHandler(this.radioButtonEnglish_CheckedChanged);
            // 
            // radioButtonPortuguese
            // 
            this.radioButtonPortuguese.AutoSize = true;
            this.radioButtonPortuguese.Location = new System.Drawing.Point(8, 26);
            this.radioButtonPortuguese.Name = "radioButtonPortuguese";
            this.radioButtonPortuguese.Size = new System.Drawing.Size(36, 19);
            this.radioButtonPortuguese.TabIndex = 1;
            this.radioButtonPortuguese.TabStop = true;
            this.radioButtonPortuguese.Text = "Pt";
            this.radioButtonPortuguese.UseVisualStyleBackColor = true;
            this.radioButtonPortuguese.CheckedChanged += new System.EventHandler(this.radioButtonPortuguese_CheckedChanged);
            // 
            // radioButtonSpanish
            // 
            this.radioButtonSpanish.AutoSize = true;
            this.radioButtonSpanish.Location = new System.Drawing.Point(8, 51);
            this.radioButtonSpanish.Name = "radioButtonSpanish";
            this.radioButtonSpanish.Size = new System.Drawing.Size(36, 19);
            this.radioButtonSpanish.TabIndex = 2;
            this.radioButtonSpanish.TabStop = true;
            this.radioButtonSpanish.Text = "Es";
            this.radioButtonSpanish.UseVisualStyleBackColor = true;
            this.radioButtonSpanish.CheckedChanged += new System.EventHandler(this.radioButtonSpanish_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(174, 101);
            this.Controls.Add(this.radioButtonSpanish);
            this.Controls.Add(this.radioButtonPortuguese);
            this.Controls.Add(this.radioButtonEnglish);
            this.Controls.Add(this.radioButtonSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Inter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioButtonSystem;
        private RadioButton radioButtonEnglish;
        private RadioButton radioButtonPortuguese;
        private RadioButton radioButtonSpanish;
    }
}