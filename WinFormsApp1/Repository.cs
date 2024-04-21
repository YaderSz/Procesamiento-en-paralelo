using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsApp1
{
    public class Repository : IRepository
    {
        private PictureBox picOriginal;
        private PictureBox picGray;
        public Repository(PictureBox picOriginal, PictureBox picGray)
        {
            this.picOriginal = picOriginal;
            this.picGray = picGray;
        }

        //metodo para convertir las imagenes a gris con Bitmap 
        public Bitmap ConvertToGrayscale(Bitmap originalImage)
        {


            Bitmap grayScaleImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < grayScaleImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color pixelColor;
                    lock (originalImage)
                    {
                        pixelColor = originalImage.GetPixel(x, y);
                    }

                    int grayScaleValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                    Color grayColor = Color.FromArgb(grayScaleValue, grayScaleValue, grayScaleValue);

                    lock (grayScaleImage)
                    {
                        grayScaleImage.SetPixel(x, y, grayColor);
                    }
                }
            }

            return grayScaleImage;
        }

        public void ProcessImages(string[] imageFiles)
        {
            Parallel.ForEach(imageFiles, file =>
            {
                Bitmap originalImage = new Bitmap(file);
                Bitmap grayScaleImage = ConvertToGrayscale(originalImage);
                string outputPath = Path.Combine(Path.GetDirectoryName(file), "Gris" + Path.GetFileName(file));
                grayScaleImage.Save(outputPath);
                UpdatePictureBoxes(originalImage,grayScaleImage);
            });

            MessageBox.Show("Imagenes Procesadas");
        }
        public void UpdatePictureBoxes(Bitmap originalImages, Bitmap grayScaleImages)
        {
            picOriginal.Image = originalImages;
            picGray.Image = grayScaleImages;
        }
    }
}