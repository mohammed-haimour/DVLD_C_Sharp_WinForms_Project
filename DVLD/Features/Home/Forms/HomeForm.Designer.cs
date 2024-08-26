namespace DVLD
{
    partial class DVLDHomePageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DVLDHomePageForm));
            this.OpenPersosnFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenPersosnFormButton
            // 
            this.OpenPersosnFormButton.Location = new System.Drawing.Point(93, 116);
            this.OpenPersosnFormButton.Name = "OpenPersosnFormButton";
            this.OpenPersosnFormButton.Size = new System.Drawing.Size(242, 91);
            this.OpenPersosnFormButton.TabIndex = 0;
            this.OpenPersosnFormButton.Text = "open Persosns Form Button";
            this.OpenPersosnFormButton.UseVisualStyleBackColor = true;
            this.OpenPersosnFormButton.Click += new System.EventHandler(this.OpenPersosnFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "DVLD";
            // 
            // DVLDHomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 952);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenPersosnFormButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DVLDHomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenPersosnFormButton;
        private System.Windows.Forms.Label label1;
    }
}

