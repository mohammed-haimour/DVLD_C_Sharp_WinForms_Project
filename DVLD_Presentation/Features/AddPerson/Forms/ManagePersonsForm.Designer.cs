namespace DVLD_Presentation.Features.AddPerson.Forms
{
    partial class ManagePersonsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePersonsForm));
            label1 = new Label();
            OpenAddPersonFormButton = new Button();
            PersonsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PersonsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Manage Persons";
            // 
            // OpenAddPersonFormButton
            // 
            OpenAddPersonFormButton.Location = new Point(112, 5);
            OpenAddPersonFormButton.Name = "OpenAddPersonFormButton";
            OpenAddPersonFormButton.Size = new Size(89, 23);
            OpenAddPersonFormButton.TabIndex = 1;
            OpenAddPersonFormButton.Text = "add person + ";
            OpenAddPersonFormButton.UseVisualStyleBackColor = true;
            OpenAddPersonFormButton.Click += OpenAddPersonFormButton_Click;
            // 
            // PersonsDataGridView
            // 
            PersonsDataGridView.AllowUserToAddRows = false;
            PersonsDataGridView.AllowUserToDeleteRows = false;
            PersonsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonsDataGridView.Location = new Point(12, 34);
            PersonsDataGridView.Name = "PersonsDataGridView";
            PersonsDataGridView.ReadOnly = true;
            PersonsDataGridView.Size = new Size(1342, 355);
            PersonsDataGridView.TabIndex = 2;
            // 
            // ManagePersonsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 400);
            Controls.Add(PersonsDataGridView);
            Controls.Add(OpenAddPersonFormButton);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManagePersonsForm";
            Text = "ManagePersonsForm";
            Load += ManagePersonsForm_Load;
            ((System.ComponentModel.ISupportInitialize)PersonsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button OpenAddPersonFormButton;
        private DataGridView PersonsDataGridView;
    }
}