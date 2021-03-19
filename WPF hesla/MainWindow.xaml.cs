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

namespace WPF_hesla
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            ButVypni.Visibility = Visibility.Hidden;
            int x = 0;
            int y = 0;
            string ss;
            string s = TextHeslo.Text;
            if (s.Length >= 6)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    try
                    {
                        ss = Char.ToString(s[i]);
                        y = Convert.ToInt32(ss);
                        x++;
                    }
                    catch (Exception)
                    {

                    }
                }
                if (x > 0)
                {
                    TextVypis.Text = $@"Jméno a heslo bylo úspěšně zadáno
Jméno - {TextJmeno.Text}
Heslo - {TextHeslo.Text}";
                    ButVypni.Visibility = Visibility.Visible;
                }
                else 
                {
                    TextVypis.Text = "Heslo neobsahuje číslo";
                }
            }
            else 
            {
                TextVypis.Text = "Heslo má méně než 6 znaků";
            }
        }

        private void ButVypni_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
