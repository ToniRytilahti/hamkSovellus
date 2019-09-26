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
using System.Windows.Shapes;

namespace hamkSovellus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Timed ajastin;
        public MainWindow()
        {



            InitializeComponent();




            ajastin = new Timed();
            /*while(true)
            {
                keyboardTime.Content = ajastin.stopwatch.Elapsed;
            }*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            keyboardTime.Content = ajastin.stopwatch.Elapsed;
        }
    }
}


/*
namespace ajastin
{
    class Program
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(10);
            }
            stopwatch.Stop();

            Console.WriteLine("Aikaa kulunut: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);

            Console.ReadLine();


        }
    }
}
*/