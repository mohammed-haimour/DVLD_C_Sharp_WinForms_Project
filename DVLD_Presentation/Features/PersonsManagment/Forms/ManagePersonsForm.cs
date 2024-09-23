using DVLD_Business;
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
    public partial class ManagePersonsForm : Form
    {
        public ManagePersonsForm()
        {
            InitializeComponent();
        }

        public DataTable loadPersons()
        {
            return PersonsBusiness.getAll();
        }

        public void _refreshPersonsDataGridView()
        {
            PersonsDataGridView.DataSource = loadPersons();
        }

        private void ManagePersonsForm_Load(object sender, EventArgs e)
        {
            _refreshPersonsDataGridView();
        }

        private void OpenAddPersonFormButton_Click(object sender, EventArgs e)
        {
            Add_UpdatePersonForm addPersonForm = new Add_UpdatePersonForm();
            addPersonForm.ShowDialog();
            _refreshPersonsDataGridView();
        }

        private void PersonPhoneCallButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Still Under Developement", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void EmailPersonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Still Under Developement", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            Add_UpdatePersonForm addPersonForm = new Add_UpdatePersonForm();
            addPersonForm.ShowDialog();
            _refreshPersonsDataGridView();
        }

        private void EditPersonButton_Click(object sender, EventArgs e)
        {
            Add_UpdatePersonForm add_UpdatePersonForm = new Add_UpdatePersonForm((int)PersonsDataGridView.CurrentRow.Cells[0].Value);
            add_UpdatePersonForm.ShowDialog();
            _refreshPersonsDataGridView();
        }

        private void RemovePersonButton_Click(object sender, EventArgs e)
        {

            var cellValueForImage = PersonsDataGridView.CurrentRow.Cells[12].Value;
            var cellValueForPersonId = (int)PersonsDataGridView.CurrentRow.Cells[0].Value;

            int result = PersonsBusiness.deletePersonByPersonId(cellValueForPersonId);

            if (result == 1)
            {
                MessageBox.Show($"Person With Id {cellValueForPersonId}, Deleted Succuessfully", "Lesssss GO !!", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (cellValueForImage != null && !string.IsNullOrWhiteSpace(cellValueForImage.ToString()))
                {
                    File.Delete(cellValueForImage.ToString()!);
                }
            }
            else if (result == -1)
            {
                MessageBox.Show($"Person With Id {cellValueForPersonId}, Is Deleted Succuessfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == -2) {
                MessageBox.Show($"Person With Id {cellValueForPersonId}, Cannot delete this record as it is referenced by other records. Please delete the related records first.");
            }

            _refreshPersonsDataGridView();
        }
    }
}
