

using ApplicationPhonebook.Services.AddNewContact;
using ApplicationPhonebook.Services.DeleteContact;
using ApplicationPhonebook.Services.GetListContact;
using Phonebook.Endpoint;

namespace UI_winform.Forms
{
    public partial class frmMain : Form
    {
        private readonly IGetListContactService getListContactService;
        private readonly IDeleteContactService deleteContactService;

        public frmMain(IGetListContactService getListContactService, IDeleteContactService deleteContactService)
        {
            InitializeComponent();
            this.getListContactService = getListContactService;
            this.deleteContactService = deleteContactService;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var Listcontact = getListContactService.Execute();

            SettingGridveiw(Listcontact);

            this.Cursor = Cursors.Default;
        }

        private void SettingGridveiw(List<ContactListDto> Listcontact)
        {
            dataGridView1.DataSource = Listcontact;

            dataGridView1.Columns[0].HeaderText = "شناسه";
            dataGridView1.Columns[1].HeaderText = "نام مخاطب";
            dataGridView1.Columns[2].HeaderText = "شماره تلفن";
                 
            dataGridView1.Columns[1].Width = 183;
            dataGridView1.Columns[2].Width = 183;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var listContact = getListContactService.Execute(txtsearchkey.Text);

            SettingGridveiw(listContact);

            this.Cursor = Cursors.Default;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var result = deleteContactService.Execute(Id);

            if (result.IsSuccess == true)
            {
                MessageBox.Show(result.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmMain_Load(null,null);
            }
            else
            {
                MessageBox.Show(result.Message,"هشدار",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            ShowDetali();
        }

        private void ShowDetali()
        {
            //var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //frmDetailContact frmDetailContact = new frmDetailContact(Id);
            //frmDetailContact.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ShowDetali();
        }

        private void btnAddnewContact_Click(object sender, EventArgs e)
        {
            //باز کردن صفحه با استفاده از اینترفیسی که تزرق وابستگی شده

            var serviceAdd = (IAddNewContactService)Program.ServiceProvider.GetService(typeof(IAddNewContactService));

            frmAddContact frmAddContact = new frmAddContact(serviceAdd);
            frmAddContact.ShowDialog();
            frmMain_Load(null, null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //frmEditContact frmEditContact = new frmEditContact(Id);
            //frmEditContact.ShowDialog();
            //frmMain_Load(null,null);
        }
    }
}
