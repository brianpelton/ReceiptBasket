using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using ImageMagick;

namespace ReceiptBasket.ViewModel
{
    public class RenameFilesViewModel : ViewModelBase
    {
        #region [ Constructors ]

        public RenameFilesViewModel()
        {
            FileList = new List<FileInfo>();
        }

        #endregion

        #region [ Properties, Indexers ]

        public IReadOnlyCollection<FileInfo> Files
        {
            get { return FileList.AsReadOnly(); }
        }

        public FileInfo SelectedFile { get; set; }
        public Image SelectedFileImage { get; private set; }
        public string SelectedPath { get; set; }
        private List<FileInfo> FileList { get; set; }

        #endregion

        #region [ Others ]

        private async void OnSelectedFileChanged()
        {
            var file = SelectedFile;
            if (!file.Exists)
                return;

            var t = Task.Factory.StartNew(() => GenerateSelectedFileImageAsync(file));
            await t;
        }

        private void GenerateSelectedFileImageAsync(FileInfo file)
        {
            if (file.Extension.ToLower() == ".pdf")
            {
                var settings = new MagickReadSettings
                {
                    Density = new PointD(150, 150),
                    FrameIndex = 0,
                    FrameCount = 1
                };

                using (var images = new MagickImageCollection())
                {
                    images.Read(file.FullName, settings);
                    var firstImage = images[0];
                    SelectedFileImage = firstImage.ToBitmap();
                }
            }
        }

        private void OnSelectedPathChanged()
        {
            var directory = new DirectoryInfo(SelectedPath);

            FileList.Clear();

            if (!directory.Exists)
                return;

            foreach (var file in directory.GetFiles())
            {
                FileList.Add(file);
            }

            SelectedFile = null;
        }

        #endregion
    }
}