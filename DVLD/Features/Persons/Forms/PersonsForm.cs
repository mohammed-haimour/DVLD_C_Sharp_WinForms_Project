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

namespace DVLD.Features.Persons.Forms
{
    public partial class PersonsForm : Form
    {
        public PersonsForm()
        {
            InitializeComponent();
        }

        private void _loadPersons() { 
            PersonsDataGridView.DataSource = PersonsBusiness.getAllPersons();
        }

        private void PersonsForm_Load(object sender, EventArgs e)
        {
            _loadPersons();
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm();
            addPersonForm.Show();
        }
    }
}
