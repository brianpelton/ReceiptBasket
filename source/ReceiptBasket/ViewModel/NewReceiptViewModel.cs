using System;
using System.Drawing;
using AForge.Imaging.Filters;

namespace ReceiptBasket.ViewModel
{
    public class NewReceiptViewModel : ViewModelBase
    {
        #region [ Constructors ]

        public NewReceiptViewModel()
        {
            PropertyChanged += NewReceiptViewModel_PropertyChanged;
        }

        #endregion

        public void OpenImage(string fileName)
        {
            OriginalImage = Image.FromFile(fileName);
        }

        #region [ Properties ]

        public Image ActiveImage
        {
            get
            {
                if (Optimize)
                    return OptimizedImage;

                return OriginalImage;
            }
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
            switch (e.PropertyName)
            {
                case "OriginalImage":
                case "OptimizeSetting":
                case "EnableContrast":
                case "EnableStraighten":
                case "EnableAutoCrop":
                case "EnableThreshold":
                case "ThresholdSetting":
                case "RotateSetting":
                    UpdateOptimizedImage();
                    break;
            }
        }

        #endregion
    }
}