using DVLD_Business;
using DVLD_Presentation.Global;
using DVLD_Presentation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Features.AddPerson.Forms
{
    public partial class AddPersonForm : Form
    {

        public AddPersonForm()
        {
            InitializeComponent();
        }

        // Variables 
        public string selectedImagePath = "";
        private DataTable? _countriesDataTable;


        // Functions
        private DataTable _loadCountries()
        {
            return CountryBusiness.getAllCountries();
        }

        public string imageProcess(string imagePath)
        {
            // Check if the imagePath is null or empty
            if (string.IsNullOrWhiteSpace(imagePath))
            {
                throw new ArgumentException("The image path cannot be null or empty.", nameof(imagePath));
            }

            // Check if the file exists at the given path
            if (!File.Exists(imagePath))
            {
                throw new FileNotFoundException("The specified image file does not exist.", imagePath);
            }

            // Generate a new GUID for the image name
            string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(imagePath);

            // Define the destination folder path
            string destinationFolder = @"C:\DVLD_CACHED_IMAGES";

            // Ensure the destination folder exists
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            // Combine the destination folder with the new file name to create the new path
            string newFilePath = Path.Combine(destinationFolder, newFileName);

            // Copy the image to the new path
            File.Copy(imagePath, newFilePath);

            // Return the new file path
            return newFilePath;
        }

        private void _set_up_date_picker()
        {

            DateTimePicker dateTimePicker1 = new DateTimePicker();

            DateOfBirthDatePicker.MaxDate = DateTime.Today.AddYears(-18);

            DateOfBirthDatePicker.MinDate = DateTime.Today.AddYears(-140);

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPersonForm_Load(object sender, EventArgs e)
        {

            RemoveImageButton.Visible = false;
            _set_up_date_picker();
            _countriesDataTable = _loadCountries();

            foreach (DataRow row in _countriesDataTable!.Rows)
            {
                CountriesDropDown.Items.Add(row["CountryName"]);
            }

            CountriesDropDown.SelectedIndex = 184;


            MaleReadioButton.Checked = true;
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(FirstNameTextBox, e, AddPersonErrorProvider, "Please Enter The First Name");
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(SecondNameTextBox, e, AddPersonErrorProvider, "Please Enter The Second Name");
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(LastNameTextBox, e, AddPersonErrorProvider, "Please Eneter The Last Name");
        }

        private void txtNO_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(NationalNumberTextBox, e, AddPersonErrorProvider, "Please Enter The National Number");
        }

        private void dtBirth_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(NationalNumberTextBox, e, AddPersonErrorProvider, "Please Select The Date Of Birth");
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(PhoneNumberTextBox, e, AddPersonErrorProvider, "Please Enter The Phone Number");
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(AddressTextBox, e, AddPersonErrorProvider, "Please Enter The Address");
        }

        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonPictureBox.Image = null;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (Functions.IsValidEmail(EmailTextBox.Text))
            {

                AddPersonErrorProvider.SetError(EmailTextBox, string.Empty); // Clear the error
            }
            else
            {
                AddPersonErrorProvider.SetError(EmailTextBox, "Invalid email address");
            }
        }

        private void MaleReadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MaleReadioButton.Checked)
            {
                PersonPictureBox.Image = Resources.Male_512;
            }
        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FemaleRadioButton.Checked)
            {
                PersonPictureBox.Image = Resources.Female_512;
            }
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to select an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter to allow only image file types
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select an Image";

            // Allow only one file to be selected
            openFileDialog.Multiselect = false;

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                 selectedImagePath = openFileDialog.FileName;
                PersonPictureBox.Image = Image.FromFile(selectedImagePath);
                RemoveImageButton.Visible = true;

                // Optionally, set the PictureBox size mode to stretch
                PersonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void RemoveImageButton_Click(object sender, EventArgs e)
        {
            RemoveImageButton.Visible = false;
            PersonPictureBox.Image = Resources.Male_512;
        }

        private void NationalNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PersonsBusiness.isPersonExistByNationalNumber(NationalNumberTextBox.Text))
            {
                AddPersonErrorProvider.SetError(NationalNumberTextBox, "This Person Is Already Exist !");
            }
            else
            {
                AddPersonErrorProvider.SetError(NationalNumberTextBox, string.Empty); // Clear the error
            }
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            GendorEnum selectedGendor = (MaleReadioButton.Checked == true) ? GendorEnum.Male : GendorEnum.Female;
            PersonModel newPersonToAdd = new PersonModel(
                  NationalNumberTextBox.Text ,  FirstNameTextBox.Text , SecondNameTextBox.Text ,  ThridNameTextBox.Text
                  ,LastNameTextBox.Text , DateOfBirthDatePicker.Value , selectedGendor, PhoneNumberTextBox.Text,
                  EmailTextBox.Text , imageProcess(selectedImagePath) , AddressTextBox.Text , CountriesDropDown.SelectedIndex
                );
            PersonsBusiness.addPerson(newPersonToAdd);

        }
    }
}
