using System;
using System.Drawing;
using AForge.Imaging.Filters;

namespace ReceiptBasket.ViewModel
{
    public class NewReceiptViewModel : ViewModelBase
    {
        #region [ Logging ]

        private static readonly log4net.ILog Log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        #region [ Constructors ]

        public NewReceiptViewModel()
        {
            Optimize = true;
            EnableContrast = true;
            ContrastAmount = 95;

            PropertyChanged += NewReceiptViewModel_PropertyChanged;
        }

        #endregion

        #region [ Properties ]

        public Image ActiveImage
        {
            get { return Optimize ? OptimizedImage : OriginalImage; }
        }

        public decimal? Amount { get; set; }
        public int ContrastAmount { get; set; }
        public DateTime? Date { get; set; }
        public bool EnableContrast { get; set; }
        public string Name { get; set; }
        public bool Optimize { get; set; }
        public Image OptimizedImage { get; set; }
        public Image OriginalImage { get; set; }

        #endregion

        #region [ Public Methods ]

        public void OpenImage(string fileName)
        {
            OriginalImage = Image.FromFile(fileName);
        }

        public void UpdateOptimizedImage()
        {
            var image = OriginalImage;

            if (EnableContrast)
                image = DoContrast(image);

            OptimizedImage = image;
        }

        #endregion

        #region [ Methods ]

        private Image DoContrast(Image image)
        {
            var bitmapImage = (Bitmap)image.Clone();
            var filter = new ContrastCorrection(ContrastAmount);
            return filter.Apply(bitmapImage);
        }

        #endregion

        #region [ Event Handlers ]

        private void NewReceiptViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Log.DebugFormat("PropertyChanged: {0}", e.PropertyName);

            switch (e.PropertyName)
            {
                case "Optimize":
                case "OriginalImage":
                case "EnableContrast":
                case "ContrastAmount":
                    UpdateOptimizedImage();
                    break;
            }
        }

        #endregion
    }
}