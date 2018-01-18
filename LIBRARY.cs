using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookMail
{
    public partial class LIBRARY : Form
    {
        public LIBRARY()
        {
            InitializeComponent();
        }

        private void SIGN_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bookInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBooks obj = new UpdateBooks();
            obj.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentInfo obj = new AddStudentInfo();
            obj.Show();
        }

        private void searchStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudentInfo obj = new SearchStudentInfo();
            obj.Show();
        }

        private void updateStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudentInfo obj = new UpdateStudentInfo();
            obj.Show();

        }

        private void deleteStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudentInfo obj = new DeleteStudentInfo();
            obj.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBooks obj = new SearchBooks();
            obj.Show();
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks obj = new AddBooks();
            obj.Show();
        }

        private void removeBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveBooks obj = new RemoveBooks();
            obj.Show();
        }

        private void updateBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBooks obj = new UpdateBooks();
            obj.Show();
        }

        private void cONFIRMSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OutlookMail obj = new OutlookMail();

            obj.Show();
        }

        private void wITHDRAWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Withdraw obj = new Withdraw();
            obj.Show();

        }

        private void dEPOSITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit obj = new Deposit();
            obj.Show();
        }

        private void aLLBOOKINFORMATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sssbooksss obj = new sssbooksss();
            obj.Show();
        }
    }
}
