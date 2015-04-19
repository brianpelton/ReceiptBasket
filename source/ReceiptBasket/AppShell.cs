using System;
using System.Windows.Forms;

namespace ReceiptBasket
{
    public partial class AppShell : Form
    {
        #region [ Constructors ]

        public AppShell()
        {
            InitializeComponent();
        }

        #endregion

        #region [ Event Handlers ]

        private void cmdNewTestForm_Click(object sender, EventArgs e)
        {
            var f = new View.TestView {MdiParent = this};
            f.Show();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            var f = new Form1 {MdiParent = this};
            f.Show();
        }

        #endregion

        private void radButton2_Click(object sender, EventArgs e)
        {
            var f = new View.RenameFilesView { MdiParent = this };
            f.Show();
        }
    }
}