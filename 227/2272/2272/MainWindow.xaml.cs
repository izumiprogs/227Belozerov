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

namespace _2272
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
                double a = Convert.ToDouble(TbNumberA.Text);
                double b = Convert.ToDouble(TbNumberB.Text);
                double c = Convert.ToDouble(TbNumberC.Text);
                double s;
                s = Abs(a - c) * Abs(b - c);
                TextBlockAnswer.Text = ($" s={s}");

            }
        }
    }
}
