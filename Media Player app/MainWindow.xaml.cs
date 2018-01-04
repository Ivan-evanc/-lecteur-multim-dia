using System;
using System.Collections.Generic;
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
using System.Windows.Forms;

namespace Media_Player_app
{

    public partial class MainWindow : Window
    {
        string selectFile;
        private SoundPlayerAction soundPlayer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.AddExtension = true;
            fileDialog.DefaultExt = "";
            fileDialog.Title = "Find the file to choose";
            fileDialog.Filter="media(*.*)|*.*";
            selectFile = fileDialog.FileName;
            fileDialog.ShowDialog();

            mediaElement.Source = new Uri(fileDialog.FileName, UriKind.RelativeOrAbsolute);
           
           // textBox.Text = fileDialog.SafeFileName;
            textBox1.Text = fileDialog.SafeFileName;




        }

        private void mediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
        }
    }
}
