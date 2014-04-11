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

        private BindingManager DataBindingManager { get; set; }
        private NewReceiptViewModel ViewModel { get; set; }

        #endregion

        #region [ Methods ]

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DataBindingManager = new BindingManager();

            imgViewer.BindData(DataBindingManager,
                ViewModel, s => s.ActiveImage,
                mode: BindingMode.OneWayToTarget);

            chkOptimize.BindData(DataBindingManager,
                ViewModel, s => s.Optimize);

            radTrackBar1.BindData(DataBindingManager,
                ViewModel, s => s.ContrastAmount,
                converter: FloatToIntConverter.Instance);
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