using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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

namespace Vertical_Prototype{
    public partial class MainWindow : MetroWindow{

        public MainWindow(){
            InitializeComponent();
            adultTicketChoice.Value = 1;
            adultDayPassChoice.Value = 1;
            adultWeeklyPassChoice.Value = 1;
            adultMonthlyPassChoice.Value = 1;
            youthTicketChoice.Value = 1;
            youthDayPassChoice.Value = 1;
            youthWeeklyPassChoice.Value = 1;
            youthMonthlyPassChoice.Value = 1;
        }

        private void shoppingCartBtn_Click(object sender, RoutedEventArgs e){
            myFlyout.Visibility = Visibility.Visible;
        }

        private async void mapBtn_Click(object sender, RoutedEventArgs e){
            await this.ShowMessageAsync("This is the title", "Some message");
        }

        private async void busScheduleBtn(object sender, RoutedEventArgs e){
            await this.ShowMessageAsync("This is the title", "Some message");
            
        }

        private void questionBtn_Click(object sender, RoutedEventArgs e){
            helpFlyout.Visibility = Visibility.Visible;
        }

        private void shoppingCartBtn_UnClick(object sender, RoutedEventArgs e){
            myFlyout.Visibility = Visibility.Hidden;
        }

        private void questionBtn_UnClick(object sender, RoutedEventArgs e){
            helpFlyout.Visibility = Visibility.Hidden;
        }

        private async void confirmBtn_Checked(object sender, RoutedEventArgs e){
            await this.ShowMessageAsync("This is the title", "Some message"); 
        }

        private void deleteBtn_Checked(object sender, RoutedEventArgs e)
        {
            myFlyout.Visibility = Visibility.Hidden;
            helpFlyout.Visibility = Visibility.Hidden;
        }
    }
    
}
