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

        private void _loadPersons()
        {
            PersonsDataGridView.DataSource = PersonsBusiness.getAllPersons();
        }

        private void ManagePersonsForm_Load(object sender, EventArgs e)
        {
            _loadPersons();
        }

        private void OpenAddPersonFormButton_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm();
            addPersonForm.ShowDialog();
        }
    }
}
