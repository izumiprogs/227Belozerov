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
usin

namespace _2273
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
                double v = Convert.ToDouble(TbNumberV.Text);
                double u = Convert.ToDouble(TbNumberU.Text);
                double t1 = Convert.ToDouble(TbNumberT1.Text);
                double t2 = Convert.ToDouble(TbNumberT2.Text);
                double Inf = Convert.ToDouble(TbNumberInf.Text);
                double s;
                if (t2 == 0) { s = (v + u) * t1; }
                else { s = t1 * v + t2 * (v - u); }
                TextBlockAnswer.Text = ($" s={s}");

            }
        }
    }
}
