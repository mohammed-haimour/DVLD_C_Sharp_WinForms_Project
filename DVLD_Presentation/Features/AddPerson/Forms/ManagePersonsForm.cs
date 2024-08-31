using DVLD_Business;
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

        private DataTable ? _loadPersons()
        {
            return PersonsBusiness.getAllPersons();
        }

        private void ManagePersonsForm_Load(object sender, EventArgs e)
        {
            PersonsDataGridView.DataSource = _loadPersons();
        }

        private void OpenAddPersonFormButton_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm();
            addPersonForm.ShowDialog();
        }
    }
}
