using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace detbordes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, carga una imagen primero.");
                return;
            }

            // Aplicar el filtro Sobel
            Bitmap originalImage = new Bitmap(pictureBox1.Image);
            Bitmap edgeDetectedImage = ApplySobelFilter(originalImage);

            // Mostrar la imagen con detección de bordes
            pictureBox2.Image = edgeDetectedImage;
        }

        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar imagen en el PictureBox
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private Bitmap ApplySobelFilter(Bitmap original)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);

            // Definir los kernels del operador Sobel
            int[,] gx = {
                { -1, 0, 1 },
                { -2, 0, 2 },
                { -1, 0, 1 }
            };

            int[,] gy = {
                { -1, -2, -1 },
                { 0, 0, 0 },
                { 1, 2, 1 }
            };

            // Recorrer cada píxel de la imagen (excepto el borde)
            for (int y = 1; y < original.Height - 1; y++)
            {
                for (int x = 1; x < original.Width - 1; x++)
                {
                    int pixelX = 0;
                    int pixelY = 0;

                    // Aplicar Sobel kernel en la ventana 3x3
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color pixelColor = original.GetPixel(x + i, y + j);
                            int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                            pixelX += gray * gx[j + 1, i + 1];
                            pixelY += gray * gy[j + 1, i + 1];
                        }
                    }

                    // Calcular la magnitud del gradiente
                    int gradientMagnitude = (int)Math.Sqrt((pixelX * pixelX) + (pixelY * pixelY));
                    gradientMagnitude = Math.Min(255, Math.Max(0, gradientMagnitude));

                    // Asignar el color al resultado
                    Color edgeColor = Color.FromArgb(gradientMagnitude, gradientMagnitude, gradientMagnitude);
                    result.SetPixel(x, y, edgeColor);
                }
            }

            return result;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
