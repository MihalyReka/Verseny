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
using System.Windows.Threading;


namespace Verseny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow
    {
        DispatcherTimer idozito;
        List<int> kEred = new List<int>();
        List<int> sEred = new List<int>();
        List<int> nEred = new List<int>();
        
        int _1 = 0;
        int _2 = 0;
        int _3 = 0;
        public MainWindow()
        {
            InitializeComponent();
            idozito = new DispatcherTimer();
            idozito.Interval = TimeSpan.FromSeconds(0.1);
            idozito.Tick += new EventHandler(FutamKezdete);

            
        }
        Random rnd = new Random();
        int balOldal = 10;

        private void FutamKezdete(object sender, EventArgs e)
        {


            kekMot.Margin = new Thickness(rnd.Next(1, 11) * 10 + balOldal, 58, 0, 0);
            balOldal = (int)kekMot.Margin.Left;
            sargaMot.Margin = new Thickness(rnd.Next(1, 11) * 10 + balOldal, 142, 0, 158);
            balOldal = (int)sargaMot.Margin.Left;
            narancsMot.Margin = new Thickness(rnd.Next(1, 11) * 10 + balOldal, 58, 0, 69);
            balOldal = (int)narancsMot.Margin.Left;

            

        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            idozito.Start();
            start.IsEnabled = false;
            ujBjanokság.IsEnabled = false;
            ujFutam.IsEnabled = false;
            double kMotV = kekMot.Margin.Left;
            double sMotV = sargaMot.Margin.Left;
            double nMotV = narancsMot.Margin.Left;
            if (kMotV <766 )
            {
               
            }
            else
            {
                if (_1 == 0)
                {
                    _1 = 1;
                    kEred.Add(1);
                }
                else if (_2==0)
                {
                    _2 = 1;
                    kEred.Add(2);

                }
                else if (_3 == 0)
                {
                    _3 = 1;
                    kEred.Add(3);
                }

            }
            if (sMotV < 766)
            {

            }
            else
            {
                if (_1 == 0)
                {
                    _1 = 2;
                    sEred.Add(1);
                }
                else if (_2 == 0)
                {
                    _2 = 2;
                    sEred.Add(2);

                }
                else if (_3 == 0)
                {
                    _3 = 2;
                    sEred.Add(3);
                }

            }
            if (nMotV < 766)
            {
            }
            else
            {
                if (_1 == 0)
                {
                    _1 = 3;
                    nEred.Add(1);
                }
                else if (_2 == 0)
                {
                    _2 = 3;
                    nEred.Add(2);

                }
                else if (_3 == 0)
                {
                    _3 = 3;
                    nEred.Add(3);
                }

            }

            if (kMotV <=766 && sMotV<=766  && nMotV <=766)
            {
                FutamVége();
            }
            

        }
        private void FutamVége()
        {
            idozito.Stop();
            start.IsEnabled = true;
            ujBjanokság.IsEnabled = true;
            ujFutam.IsEnabled = true;

            hely.Content = "Hely";
            nev.Content = "Név";
            _1hely.Content = "1.";
            _2hely.Content = "2.";
            _3hely.Content = "3.";
            pont.Content = "Pont";
         
            _1kpont.Content = kEred[0];
            _1spont.Content = sEred[0];
            _1npont.Content = nEred[0];
            _2kpont.Content = kEred[1];
            _2spont.Content = sEred[1];
            _2npont.Content = nEred[1];              
            _3kpont.Content = kEred[2];
            _3spont.Content = sEred[2];
            _3npont.Content = nEred[2];                
            kOsszPont.Content = kEred.Sum();
            sOsszPont.Content = sEred.Sum();
            nOsszPont.Content = nEred.Sum();
        
        }

        private void ujFutam_Click(object sender, RoutedEventArgs e)
        {

            FutamVége();
        }

        private void ujBjanokság_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show($"Bajnokság végeredménye");
            hely.Content = "";
            nev.Content = "";
            _1hely.Content = "";
            _2hely.Content = "";
            _3hely.Content = "";
            pont.Content = "";

            _1kpont.Content = "";
            _1spont.Content = "";
            _1npont.Content = "";
            _2kpont.Content = "";
            _2spont.Content = "";
            _2npont.Content = "";
            _3kpont.Content = "";
            _3spont.Content = "";
            _3npont.Content = "";
            kOsszPont.Content = "";
            sOsszPont.Content = "";
            nOsszPont.Content = "";
        }
    }
}