/* Jordan Ross
 * June 7, 2019
 * Sum of all primes under 2 million
 */
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

namespace Euler_SummationOfPrimes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public long n = 2000001;
        public bool[] A;
        public long sum = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            sum = 0;
            A = new bool[n];

            for (int i = 2; i < n; i++)
            {
                A[i] = true;
            }

            for (int i = 2; i < (int)Math.Sqrt(n); i++)
            {
                if (A[i])
                {
                    for (int j = i * i; j < n; j = j + i)
                    {
                        A[j] = false;
                    }
                }
            }
            for (int i = 2; i < n; i++)
            {
                if (A[i])
                {
                    sum += i;
                }
            }
            MessageBox.Show(sum.ToString());
        }
    }
}
