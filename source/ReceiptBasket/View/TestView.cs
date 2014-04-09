using System;
using System.Windows.Forms;
using MvvmFx.Windows.Data;
using ReceiptBasket.ViewHelper;
using ReceiptBasket.ViewModel;

namespace ReceiptBasket.View
{
    public partial class TestView : Form
    {
        #region [ Constructors ]

        public TestView()
        {
            InitializeComponent();
            ViewModel = new NewReceiptViewModel();
        }

        #endregion

        #region [ Properties ]

        private BindingManager BindingManager { get; set; }
        private NewReceiptViewModel ViewModel { get; set; }

        #endregion

        #region [ Methods ]

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BindingManager = new BindingManager();

            imgViewer.BindData(BindingManager,
                ViewModel, s => s.ActiveImage);
        }

        #endregion

        #region [ Event Handlers ]

        private void cmdOpenImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "Image Files|*.jp*g"
            };
            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.OK)
                return;

            ViewModel.OpenImage(dialog.FileName);
        }

        #endregion
    }
}