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

namespace Zad1ZTP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string? inputString;
        CouponManager couponManager = new CouponManager();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Put_Click(object sender, RoutedEventArgs e)
        {
            inputString = TextBox_UserInput.Text;
            couponManager.AddCoupon(inputString);
            if (inputString != "")
            {
                Label_OutputMessage.Content = $"Dodano {inputString} do maszyny losujacej";
                Label_ListOfCoupons.Content = couponManager.ReadAllCoupons();
            }
            else
            {
                Label_OutputMessage.Content = $"Proszę wypełnić pole tekstowe";

            }

        }

        private void Button_Withdraw_Click(object sender, RoutedEventArgs e)
        {
            Label_OutputMessage.Content = couponManager.ReadRandomValue();
            Label_ListOfCoupons.Content = couponManager.ReadAllCoupons();

        }
    }
}
