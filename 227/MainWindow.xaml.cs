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
using static System.Math;

namespace _227
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            void BtnOK_Click(object sender, EventArgs e)
            {

                int a = Convert.ToInt32(TbNumberA.Text);
                double v, s;
                v = Pow(a, 3);
                s = 6 * Pow(a, 2);
                TextBlockAnswer.Text = ($"v={v},s={s}");
            }
        }
    }
}
