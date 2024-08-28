using DVLD_Presentation.Features.AddPerson.Forms;

namespace DVLD_Presentation
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagePersonsForm managePersonsForm = new ManagePersonsForm();  
            managePersonsForm.ShowDialog();
        }
    }
}
