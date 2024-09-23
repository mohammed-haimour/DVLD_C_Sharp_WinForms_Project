using DVLD_Business;
using DVLD_Presentation.Global;
using DVLD_Presentation.Properties;
using Microsoft.IdentityModel.Tokens;
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
    public partial class Add_UpdatePersonForm : Form
    {
        // Variables 
        private DataTable? _countriesDataTable;
        private CrudOprations _currentFormMode;
        private PersonModel? _personToUpdate;

        public Add_UpdatePersonForm()
        {
            // add mode
            InitializeComponent();
            _setUpCountriesDropDown();
            _activateAddMode();
        }

        public Add_UpdatePersonForm(int personId)
        {
            // update mode
            InitializeComponent();
            _setUpCountriesDropDown();
            _activateUpdateMode(personId);
        }

        // Functions
        private void _activateAddMode() {
            _currentFormMode = CrudOprations.create;
        }
        private void _activateUpdateMode(int personId)
        {
            _currentFormMode = CrudOprations.update;
            _changeUiToUpdateMode(personId);
            PersonModel? person = PersonsBusiness.getPersonById(personId);
            _personToUpdate = person;
            if (person != null)
            {
                _fillFieldsWithValuesFromPersonModel(person);
            }
        }
        private void _changeUiToUpdateMode(int personId)
        {
            PersonIdText.Text = $"{personId}";
            FormTitleText.Text = "Update Person Info.";
            AddImageButton.Text = "Change Image";
            CloseFormButton.Text = "Close";
            AddPersonButton.Text = "Update";
            this.Text = "Update Person - DVLD";
        }
        private void _fillFieldsWithValuesFromPersonModel(PersonModel person)
        {
            FirstNameTextBox.Text = person.FirstName;
            SecondNameTextBox.Text = person.SecondName;
            ThirdNameTextBox.Text = person.ThirdName;
            LastNameTextBox.Text = person.LastName;
            NationalNumberTextBox.Text = person.NationalId;
            DateOfBirthDatePicker.Value = person.DateOfBirth;
            if (person.PersonGendor == GendorEnum.Male)
            {
                MaleReadioButton.Checked = true;
                FemaleRadioButton.Checked = false;
            }
            else
            {
                MaleReadioButton.Checked = false;
                FemaleRadioButton.Checked = true;
            }
            PhoneNumberTextBox.Text = person.PhoneNumber;
            EmailTextBox.Text = person.Email;
            AddressTextBox.Text = person.Address;
            CountriesDropDown.SelectedIndex = person.NationalityCountryId;
            if (person.ImagePath != null)
            {
                PersonPictureBox.ImageLocation = person.ImagePath.ToString()!;
                PersonPictureBox.Tag = person.ImagePath;
                RemoveImageButton.Visible = true;
            }
            else {
                PersonPictureBox.Tag = null;
                RemoveImageButton.Visible = false;
            }
        }
        private DataTable _loadCountries()
        {
            return CountryBusiness.getAllCountries();
        }
        private void _setUpCountriesDropDown()
        {
            _countriesDataTable = _loadCountries();

            foreach (DataRow row in _countriesDataTable!.Rows)
            {
                CountriesDropDown.Items.Add(row["CountryName"]);
            }
        }
        private string? _imageProcess(string? imagePath)
        {
            if (imagePath != null)
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
            else
            {
                return null;
            }
        }
        private void _set_up_date_picker()
        {

            DateTimePicker dateTimePicker1 = new DateTimePicker();

            DateOfBirthDatePicker.MaxDate = DateTime.Today.AddYears(-18);

            DateOfBirthDatePicker.MinDate = DateTime.Today.AddYears(-140);

        }

        // ------------------
        private void AddPersonForm_Load(object sender, EventArgs e)
        {
            _set_up_date_picker();

            if (_currentFormMode == CrudOprations.create)
            {
                CountriesDropDown.SelectedIndex = 184;
                MaleReadioButton.Checked = true;
                RemoveImageButton.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(FirstNameTextBox, e, AddPersonErrorProvider, "Please Enter The First Name"); // you are still slow ,, why ???
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
            PersonPictureBox.Tag = null;
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
            if (MaleReadioButton.Checked && PersonPictureBox.Tag == null)
            {
                PersonPictureBox.Image = Resources.male_user;


            }
        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FemaleRadioButton.Checked && PersonPictureBox.Tag == null)
            {
                PersonPictureBox.Image = Resources.famale_user;
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
                PersonPictureBox.Tag = openFileDialog.FileName;
                PersonPictureBox.ImageLocation = PersonPictureBox.Tag.ToString()!;
                RemoveImageButton.Visible = true;

            }
        }

        private void RemoveImageButton_Click(object sender, EventArgs e)
        {

            RemoveImageButton.Visible = false;
            PersonPictureBox.Image = null;
            PersonPictureBox.Tag = null;
            if (MaleReadioButton.Checked)
            {
                PersonPictureBox.Image = Resources.male_user;
            }
            else
            {
                PersonPictureBox.Image = Resources.famale_user;
            }
        }

        private void NationalNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PersonsBusiness.isPersonExistByNationalNumber(NationalNumberTextBox.Text) && _currentFormMode == CrudOprations.create)
            {
                AddPersonErrorProvider.SetError(NationalNumberTextBox, "This Person Is Already Exist !");
            }
            else
            {
                AddPersonErrorProvider.SetError(NationalNumberTextBox, string.Empty); 
            }
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string ? imagePath = null;

                if (_currentFormMode == CrudOprations.update)
                {
                    if (_personToUpdate?.ImagePath != null) {
                        imagePath = _personToUpdate!.ImagePath;
                    }
                    if (_personToUpdate!.ImagePath?.ToString() != PersonPictureBox.Tag?.ToString())
                    {
                        imagePath = _imageProcess(PersonPictureBox.Tag?.ToString() ?? null);

                        if (_personToUpdate.ImagePath != null)
                        {
                            File.Delete(_personToUpdate.ImagePath!);
                        }
                    }

                } 
                else if(_currentFormMode == CrudOprations.create)
                {
                    imagePath = _imageProcess(PersonPictureBox.Tag?.ToString() ?? null);
                }

                PersonModel newPerson = new PersonModel((short)(PersonIdText.Text == "Unknown" ? -1 : int.Parse(PersonIdText.Text)),
                     NationalNumberTextBox.Text, FirstNameTextBox.Text, SecondNameTextBox.Text, ThirdNameTextBox.Text
                     , LastNameTextBox.Text, DateOfBirthDatePicker.Value, (MaleReadioButton.Checked == true) ? GendorEnum.Male : GendorEnum.Female, PhoneNumberTextBox.Text,
                     EmailTextBox.Text, imagePath, AddressTextBox.Text, CountriesDropDown.SelectedIndex
                   );

                // Save 
                int result = PersonsBusiness.save(newPerson, (_currentFormMode == CrudOprations.create) ? CrudOprations.create : CrudOprations.update);

                if (result != -1)
                {
                    MessageBox.Show($"Person Saved Successfully Id : {result}", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _activateUpdateMode(result);
                }
                else
                {
                    MessageBox.Show("Failed To Save The Person", "Failure !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ManagePersonsForm managePersonsForm = new ManagePersonsForm();
                managePersonsForm.loadPersons();
            }
        }

        private void CountriesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
