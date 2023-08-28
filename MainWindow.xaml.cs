using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Reflection;


namespace Fight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            //string projectRoot = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(basePath)));
            //string rutaCarpeta = AppDomain.CurrentDomain.BaseDirectory + "videos";
            string rutaCarpeta = GetRelativeFolderPath("../../../videos");
            //C:\Users\lucia\Desktop\Fight\Fight\videos\
            cmbChar.ItemsSource = personajes(rutaCarpeta);
                
            cmbChar.SelectedIndex = 1;
            
            cmbMov.ItemsSource = movimientos(rutaCarpeta);
            cmbMov.SelectedIndex = 0;
            //reproducir();
            btnTest.IsEnabled = false;





            slider.ValueChanged += slider_ValueChanged;

            // Establece la ruta del archivo de video local
            //mediaPlayer.Source = new Uri(@"C:\Users\lucia\source\repos\Fight\videos\Eagle\EagleComboReset.mp4");
            //mediaPlayer.LoadedBehavior = MediaState.Manual;
            //mediaPlayer.MediaEnded += (sender, e) => mediaPlayer.Position = TimeSpan.Zero;
            //// Reproduce el video
            //mediaPlayer.Play();
            //string nomVid = cmbChar.SelectedValue.ToString();
            //PlayVideo(@"C:\Users\lucia\source\repos\Fight\videos\Eagle\EagleComboReset.mp4");
            //mediaPlayer.SetValue("C:\\Users\\lucia\\source\\repos\\Fight\\videos\\Rash\\Combo 2.mp4");
        }

        static string GetRelativeFolderPath(string relativePath)
        {
            string executingAssemblyPath = Assembly.GetExecutingAssembly().Location;
            string projectRoot = Path.GetDirectoryName(executingAssemblyPath);
            string folderPath = Path.Combine(projectRoot, relativePath);

            if (Directory.Exists(folderPath))
            {
                return folderPath;
            }
            return null;
        }

        private void reproducir()
        {
            string pj = cmbChar.SelectedValue.ToString();
            string mov = cmbMov.SelectedValue.ToString();
            string ruta = GetRelativeFolderPath("../../../videos/");
            string urlvid = ruta + pj + "\\" + mov;
            mediaPlayer.Source = new Uri(urlvid);
            mediaPlayer.LoadedBehavior = MediaState.Manual;
            mediaPlayer.MediaEnded += (sender, e) => mediaPlayer.Position = TimeSpan.Zero;
            // Reproduce el video
            lblPlay.Content = pj + " " + mov + ".";
            mediaPlayer.Play();

        }


        private List<string> personajes(string rutaCarpeta)
        {
            
            //string path = @"C:\Users\lucia\source\repos\Fight\videos"; // Ruta del directorio a listar

            List<string> pjs = new List<string>();

            try
            {
                // Obtener una matriz de cadenas que representan los nombres de las carpetas en el directorio
                string[] folders = Directory.GetDirectories(rutaCarpeta);

                // Recorrer la matriz de carpetas e imprimir los nombres
                foreach (string folder in folders)
                {
                    //Console.WriteLine(Path.GetFileName(folder));
                    pjs.Add(Path.GetFileName(folder));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrió un error: " + e.Message);
            }

            return pjs;
        }

        private List<string> movimientos(string rutaCarpeta )
        {

            //string path = @"C:\Users\lucia\source\repos\Fight\videos"; // Ruta del directorio a listar

            List<string> pjs = new List<string>();

            try
            {
                // Obtener una matriz de cadenas que representan los nombres de las carpetas en el directorio
                string[] folders = Directory.GetFiles(rutaCarpeta);

                // Recorrer la matriz de carpetas e imprimir los nombres
                int nro = 0;
                foreach (string folder in folders)
                {
                    nro++;
                    //Console.WriteLine(Path.GetFileName(folder));
                    pjs.Add(Path.GetFileName(folder));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrió un error: " + e.Message);
            }

            return pjs;
        }


        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            reproducir();
        }

        private void cmbChar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ruta  = GetRelativeFolderPath("../../../videos/");
            string rutaCarpeta = ruta + cmbChar.SelectedItem;
            ////reproducir();
            ////cmbMov.SelectedIndex= 0;
            List <string> pjs = new List<string>();
            pjs = movimientos(rutaCarpeta);
            cmbMov.ItemsSource = pjs;
            cmbMov.SelectedIndex = 0;
            btnTest.IsEnabled = true;
            //reproducir(cmbChar.SelectedValue.ToString(), cmbMov.SelectedValue.ToString());

            //string pj = cmbChar.SelectedValue.ToString();
            //string mov = cmbMov.SelectedValue.ToString();
            //string urlvid = @"C:\Users\lucia\source\repos\Fight\videos\" + pj + "\\" + mov;
            //mediaPlayer.Source = new Uri(urlvid);
            //mediaPlayer.LoadedBehavior = MediaState.Manual;
            //mediaPlayer.MediaEnded += (sender, e) => mediaPlayer.Position = TimeSpan.Zero;
            //// Reproduce el video
            ////mediaPlayer.Play();


        }

        

        private void cmbMov_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ruta = GetRelativeFolderPath("../../../videos/");
            string rutaCarpeta = ruta + cmbChar.SelectedItem;
            //cmbMov.ItemsSource = movimientos(rutaCarpeta);
            //cmbMov.SelectedIndex= 0;
            btnTest.IsEnabled= true;



        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan newPosition = TimeSpan.FromSeconds(slider.Value);
            mediaPlayer.Position = newPosition;
            //mediaPlayer
        }

        private void mediaPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            // Configurar el rango del Video Scrubber
            //slider.Minimum = 0;
            slider.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
            slider.IsMoveToPointEnabled = true;


            // Mostrar la duración total del archivo de video
            //durationLabel.Text = mediaPlayer.NaturalDuration.TimeSpan.ToString(@"hh\:mm\:ss");
        }

        private void mediaPlayer_PositionChanged(object sender, RoutedEventArgs e)
        {
            // Actualizar la posición del Video Scrubber
            slider.Value = mediaPlayer.Position.TotalSeconds;
        }
    }
}
