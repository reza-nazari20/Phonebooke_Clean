using ApplicationPhonebook.Services.AddNewContact;

namespace UI_winform.Forms
{
    public partial class frmAddContact : Form
    {
        private readonly IAddNewContactService addNewContactService;

        public frmAddContact(IAddNewContactService addNewContactService)
        {
            InitializeComponent();
            this.addNewContactService = addNewContactService;
        }

        private void frmAddContact_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = addNewContactService.Execute(new AddNewContactDto
            {
                Company = txtCompany.Text,
                Description = txtDescription.Text,
                LastName = txtLastname.Text,
                Name = txtName.Text,
                PhoneNumber = txtPhonenumber.Text
            });

            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
