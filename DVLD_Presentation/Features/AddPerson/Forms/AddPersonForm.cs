using DVLD_Business;
using DVLD_Presentation.Global;
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
        private DataTable? _countriesDataTable;


        // Functions For This Form

        // get countries for the dropDpown
        private void _loadCountries()
        {
            _countriesDataTable = CountryBusiness.getAllCountries();
        }


        private void _set_up_date_picker()
        {

            DateTimePicker dateTimePicker1 = new DateTimePicker();

            dtBirth.MaxDate = DateTime.Today.AddYears(-18);

            dtBirth.MinDate = DateTime.Today.AddYears(-140);

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPersonForm_Load(object sender, EventArgs e)
        {
            _set_up_date_picker();
            _loadCountries();
            // load coutnries to the dropDown

            foreach (DataRow row in _countriesDataTable!.Rows)
            {
                CountriesDropDown.Items.Add(row["CountryName"]);
            }

            CountriesDropDown.SelectedIndex = 184;
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(txtFirstName, e, AddPersonErrorProvider);
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(txtSecondName, e, AddPersonErrorProvider);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(txtLastName, e, AddPersonErrorProvider);
        }

        private void txtNO_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(txtNO, e, AddPersonErrorProvider);
        }

        private void dtBirth_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(txtNO, e, AddPersonErrorProvider);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(txtPhone, e, AddPersonErrorProvider);
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            Functions.TextValidation(txtAddress, e, AddPersonErrorProvider);
        }

        private void linkImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                string selectedImagePath = openFileDialog.FileName;
                picPerson.Image = Image.FromFile(selectedImagePath);

                // Optionally, set the PictureBox size mode to stretch
                picPerson.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picPerson.Image = null;
        }
    }
}
