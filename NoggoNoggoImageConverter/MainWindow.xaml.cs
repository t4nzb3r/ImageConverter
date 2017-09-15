using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace NoggoNoggoImageConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[][] red;
        int[][] green;
        int[][] blue;

        public MainWindow()
        {
            InitializeComponent();

            LblHeight.Content = "";
            LblWidth.Content = "";

            LblNumbers.Content = "";
            LblNumbersEach.Content = "";

            LblMedRed.Content = "";
            LblMedGreen.Content = "";
            LblMedBlue.Content = "";
        }

        private void BtnOpenImg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Pictures|*.img; *.png; *.jpg; *.jpeg";

            ofd.ShowDialog();

            String path = ofd.FileName;

            if (File.Exists(path))
            {
                TxtBoxPath.Text = path;

                Bitmap bmp = new Bitmap(path);
                LblHeight.Content = bmp.Height;
                LblWidth.Content = bmp.Width;

                LblNumbers.Content = (bmp.Height * bmp.Width) * 3;
                LblNumbersEach.Content = (bmp.Height * bmp.Width);

                red = new int[bmp.Height][];
                green = new int[bmp.Height][];
                blue = new int[bmp.Height][];

                int sumRed = 0;
                int sumGreen = 0;
                int sumBlue = 0;
                
                for(int i = 0; i < bmp.Height; i++)
                {
                    red[i] = new int[bmp.Width];
                    green[i] = new int[bmp.Width];
                    blue[i] = new int[bmp.Width];

                    for (int j = 0; j < bmp.Width; j++)
                    {
                        System.Drawing.Color c = bmp.GetPixel(j, i);
                        red[i][j] = c.R;
                        green[i][j] = c.G;
                        blue[i][j] = c.B;

                        sumRed += c.R;
                        sumGreen += c.G;
                        sumBlue += c.B;
                    }
                }

                LblMedRed.Content = (sumRed / (bmp.Height * bmp.Width));
                LblMedGreen.Content = (sumGreen / (bmp.Height * bmp.Width));
                LblMedBlue.Content = (sumBlue / (bmp.Height * bmp.Width));
            }

            else TxtBoxPath.Text = "File doesn not exist.";
        }

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            String folder = System.IO.Path.GetDirectoryName(TxtBoxPath.Text);
            String name = System.IO.Path.GetFileNameWithoutExtension(TxtBoxPath.Text);

            FileStream fRed = File.Create(folder + "\\" + name + "_RED.txt");
            String redText = "";
            for (int i = 0; i < red.Length; i++)
            {
                for (int j = 0; j < red[i].Length; j++)
                {
                    redText += red[i][j] + " ";
                }
                redText = redText.Substring(0, redText.Length - 1);
                redText += "\n";

                Byte[] redByte = Encoding.ASCII.GetBytes(redText);
                fRed.Write(redByte, 0, redByte.Length);

                redText = "";
            }
            fRed.Close();

            FileStream fGreen = File.Create(folder + "\\" + name + "_GREEN.txt");
            String greenText = "";
            for (int i = 0; i < green.Length; i++)
            {
                for (int j = 0; j < green[i].Length; j++)
                {
                    greenText += green[i][j] + " ";
                }
                greenText = greenText.Substring(0, greenText.Length - 1);
                greenText += "\n";

                Byte[] greenByte = Encoding.ASCII.GetBytes(greenText);
                fGreen.Write(greenByte, 0, greenByte.Length);

                greenText = "";
            }
            fGreen.Close();

            FileStream fBlue = File.Create(folder + "\\" + name + "_BLUE.txt");
            String blueText = "";
            for (int i = 0; i < blue.Length; i++)
            {
                for (int j = 0; j < blue[i].Length; j++)
                {
                    blueText += blue[i][j] + " ";
                }
                blueText = blueText.Substring(0, blueText.Length - 1);
                blueText += "\n";

                Byte[] blueByte = Encoding.ASCII.GetBytes(blueText);
                fBlue.Write(blueByte, 0, blueByte.Length);

                blueText = "";
            }
            fBlue.Close();
        }
    }
}
