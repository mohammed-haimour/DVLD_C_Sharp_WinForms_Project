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
            OpenAddPersonFormButton = new Button();
            PersonsDataGridView = new DataGridView();
            pictureBox1 = new PictureBox();
            FormTitleText = new Label();
            Tools = new GroupBox();
            RemovePersonButton = new Button();
            EditPersonButton = new Button();
            EmailPersonButton = new Button();
            PersonPhoneCallButton = new Button();
            PreviewPersonButton = new Button();
            AddPersonButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PersonsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Tools.SuspendLayout();
            SuspendLayout();
            // 
            // OpenAddPersonFormButton
            // 
            OpenAddPersonFormButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OpenAddPersonFormButton.Image = Properties.Resources.Add_New_User_72;
            OpenAddPersonFormButton.ImageAlign = ContentAlignment.MiddleRight;
            OpenAddPersonFormButton.Location = new Point(21, 52);
            OpenAddPersonFormButton.Name = "OpenAddPersonFormButton";
            OpenAddPersonFormButton.Size = new Size(297, 63);
            OpenAddPersonFormButton.TabIndex = 1;
            OpenAddPersonFormButton.Text = "Add New Person";
            OpenAddPersonFormButton.TextAlign = ContentAlignment.MiddleLeft;
            OpenAddPersonFormButton.UseVisualStyleBackColor = true;
            OpenAddPersonFormButton.Click += OpenAddPersonFormButton_Click;
            // 
            // PersonsDataGridView
            // 
            PersonsDataGridView.AllowUserToAddRows = false;
            PersonsDataGridView.AllowUserToDeleteRows = false;
            PersonsDataGridView.Anchor = AnchorStyles.None;
            PersonsDataGridView.BackgroundColor = Color.FromArgb(224, 224, 224);
            PersonsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            PersonsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            PersonsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonsDataGridView.EnableHeadersVisualStyles = false;
            PersonsDataGridView.GridColor = SystemColors.InactiveBorder;
            PersonsDataGridView.Location = new Point(21, 121);
            PersonsDataGridView.MultiSelect = false;
            PersonsDataGridView.Name = "PersonsDataGridView";
            PersonsDataGridView.ReadOnly = true;
            PersonsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            PersonsDataGridView.RowHeadersVisible = false;
            PersonsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            PersonsDataGridView.ScrollBars = ScrollBars.Vertical;
            PersonsDataGridView.Size = new Size(1299, 477);
            PersonsDataGridView.StandardTab = true;
            PersonsDataGridView.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User_32__2;
            pictureBox1.Location = new Point(26, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 34);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // FormTitleText
            // 
            FormTitleText.AutoSize = true;
            FormTitleText.Font = new Font("Consolas", 23.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormTitleText.ForeColor = Color.Blue;
            FormTitleText.Location = new Point(63, 9);
            FormTitleText.Name = "FormTitleText";
            FormTitleText.Size = new Size(255, 37);
            FormTitleText.TabIndex = 33;
            FormTitleText.Text = "Manage Persons";
            // 
            // Tools
            // 
            Tools.Controls.Add(RemovePersonButton);
            Tools.Controls.Add(EditPersonButton);
            Tools.Controls.Add(EmailPersonButton);
            Tools.Controls.Add(PersonPhoneCallButton);
            Tools.Controls.Add(PreviewPersonButton);
            Tools.Controls.Add(AddPersonButton);
            Tools.Location = new Point(1069, 9);
            Tools.Name = "Tools";
            Tools.Size = new Size(251, 100);
            Tools.TabIndex = 35;
            Tools.TabStop = false;
            Tools.Text = "Tools";
            // 
            // RemovePersonButton
            // 
            RemovePersonButton.BackgroundImageLayout = ImageLayout.None;
            RemovePersonButton.FlatAppearance.BorderColor = Color.White;
            RemovePersonButton.FlatAppearance.BorderSize = 0;
            RemovePersonButton.FlatStyle = FlatStyle.Flat;
            RemovePersonButton.Image = Properties.Resources.remove1;
            RemovePersonButton.ImageAlign = ContentAlignment.MiddleLeft;
            RemovePersonButton.Location = new Point(6, 68);
            RemovePersonButton.Name = "RemovePersonButton";
            RemovePersonButton.Size = new Size(116, 24);
            RemovePersonButton.TabIndex = 0;
            RemovePersonButton.Text = "Remove ";
            RemovePersonButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RemovePersonButton.UseVisualStyleBackColor = true;
            RemovePersonButton.Click += RemovePersonButton_Click;
            // 
            // EditPersonButton
            // 
            EditPersonButton.BackgroundImageLayout = ImageLayout.None;
            EditPersonButton.FlatAppearance.BorderColor = Color.White;
            EditPersonButton.FlatAppearance.BorderSize = 0;
            EditPersonButton.FlatStyle = FlatStyle.Flat;
            EditPersonButton.Image = Properties.Resources.pen;
            EditPersonButton.ImageAlign = ContentAlignment.MiddleLeft;
            EditPersonButton.Location = new Point(6, 43);
            EditPersonButton.Name = "EditPersonButton";
            EditPersonButton.Size = new Size(107, 23);
            EditPersonButton.TabIndex = 0;
            EditPersonButton.Text = "Edit ";
            EditPersonButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            EditPersonButton.UseVisualStyleBackColor = true;
            EditPersonButton.Click += EditPersonButton_Click;
            // 
            // EmailPersonButton
            // 
            EmailPersonButton.BackgroundImageLayout = ImageLayout.None;
            EmailPersonButton.FlatAppearance.BorderColor = Color.White;
            EmailPersonButton.FlatAppearance.BorderSize = 0;
            EmailPersonButton.FlatStyle = FlatStyle.Flat;
            EmailPersonButton.Image = Properties.Resources.email;
            EmailPersonButton.ImageAlign = ContentAlignment.MiddleLeft;
            EmailPersonButton.Location = new Point(140, 68);
            EmailPersonButton.Name = "EmailPersonButton";
            EmailPersonButton.Size = new Size(92, 27);
            EmailPersonButton.TabIndex = 0;
            EmailPersonButton.Text = "Email";
            EmailPersonButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            EmailPersonButton.UseVisualStyleBackColor = true;
            EmailPersonButton.Click += EmailPersonButton_Click;
            // 
            // PersonPhoneCallButton
            // 
            PersonPhoneCallButton.BackgroundImageLayout = ImageLayout.None;
            PersonPhoneCallButton.FlatAppearance.BorderColor = Color.White;
            PersonPhoneCallButton.FlatAppearance.BorderSize = 0;
            PersonPhoneCallButton.FlatStyle = FlatStyle.Flat;
            PersonPhoneCallButton.Image = Properties.Resources.phone_call;
            PersonPhoneCallButton.ImageAlign = ContentAlignment.MiddleLeft;
            PersonPhoneCallButton.Location = new Point(139, 41);
            PersonPhoneCallButton.Name = "PersonPhoneCallButton";
            PersonPhoneCallButton.Size = new Size(92, 27);
            PersonPhoneCallButton.TabIndex = 0;
            PersonPhoneCallButton.Text = "Phone Call";
            PersonPhoneCallButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PersonPhoneCallButton.UseVisualStyleBackColor = true;
            PersonPhoneCallButton.Click += PersonPhoneCallButton_Click;
            // 
            // PreviewPersonButton
            // 
            PreviewPersonButton.BackgroundImageLayout = ImageLayout.None;
            PreviewPersonButton.FlatAppearance.BorderColor = Color.White;
            PreviewPersonButton.FlatAppearance.BorderSize = 0;
            PreviewPersonButton.FlatStyle = FlatStyle.Flat;
            PreviewPersonButton.Image = Properties.Resources.eye;
            PreviewPersonButton.ImageAlign = ContentAlignment.MiddleLeft;
            PreviewPersonButton.Location = new Point(140, 15);
            PreviewPersonButton.Name = "PreviewPersonButton";
            PreviewPersonButton.Size = new Size(92, 27);
            PreviewPersonButton.TabIndex = 0;
            PreviewPersonButton.Text = "Preview";
            PreviewPersonButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PreviewPersonButton.UseVisualStyleBackColor = true;
            // 
            // AddPersonButton
            // 
            AddPersonButton.BackgroundImageLayout = ImageLayout.None;
            AddPersonButton.FlatAppearance.BorderColor = Color.White;
            AddPersonButton.FlatAppearance.BorderSize = 0;
            AddPersonButton.FlatStyle = FlatStyle.Flat;
            AddPersonButton.Image = Properties.Resources.add;
            AddPersonButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddPersonButton.Location = new Point(6, 15);
            AddPersonButton.Name = "AddPersonButton";
            AddPersonButton.Size = new Size(92, 27);
            AddPersonButton.TabIndex = 0;
            AddPersonButton.Text = "Add ";
            AddPersonButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddPersonButton.UseVisualStyleBackColor = true;
            AddPersonButton.Click += AddPersonButton_Click;
            // 
            // ManagePersonsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 610);
            Controls.Add(Tools);
            Controls.Add(pictureBox1);
            Controls.Add(FormTitleText);
            Controls.Add(PersonsDataGridView);
            Controls.Add(OpenAddPersonFormButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManagePersonsForm";
            Text = "ManagePersonsForm";
            Load += ManagePersonsForm_Load;
            ((System.ComponentModel.ISupportInitialize)PersonsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Tools.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button OpenAddPersonFormButton;
        private DataGridView PersonsDataGridView;
        private PictureBox pictureBox1;
        private Label FormTitleText;
        private GroupBox Tools;
        private Button AddPersonButton;
        private Button RemovePersonButton;
        private Button EditPersonButton;
        private Button EmailPersonButton;
        private Button PersonPhoneCallButton;
        private Button PreviewPersonButton;
    }
}