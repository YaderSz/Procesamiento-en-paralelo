using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public interface IRepository
    {
        void ProcessImages(string[] imageFiles);
        Bitmap ConvertToGrayscale(Bitmap originalImage);
        void UpdatePictureBoxes(Bitmap originalImages, Bitmap grayScaleImages);
    }
}
