namespace DVLD.Features.Persons.Forms
{
    partial class PersonsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.PersonsDataGridView = new System.Windows.Forms.DataGridView();
            this.AddPersonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Persons";
            // 
            // PersonsDataGridView
            // 
            this.PersonsDataGridView.AllowUserToAddRows = false;
            this.PersonsDataGridView.AllowUserToDeleteRows = false;
            this.PersonsDataGridView.AllowUserToOrderColumns = true;
            this.PersonsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonsDataGridView.Location = new System.Drawing.Point(12, 166);
            this.PersonsDataGridView.Name = "PersonsDataGridView";
            this.PersonsDataGridView.ReadOnly = true;
            this.PersonsDataGridView.Size = new System.Drawing.Size(1427, 708);
            this.PersonsDataGridView.TabIndex = 1;
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(1277, 25);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(162, 95);
            this.AddPersonButton.TabIndex = 2;
            this.AddPersonButton.Text = "add Person";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // PersonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 886);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.PersonsDataGridView);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Persons";
            this.Load += new System.EventHandler(this.PersonsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PersonsDataGridView;
        private System.Windows.Forms.Button AddPersonButton;
    }
}