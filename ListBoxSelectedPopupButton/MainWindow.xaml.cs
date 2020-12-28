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

namespace ListBoxSelectedPopupButton
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //lb.Items.Add(new ListBoxItem() {Content = "가나다라마바사 1" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 2" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 3" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 4" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 5" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 6" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 7" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 8" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 9" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 10" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 11" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 12" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 13" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 14" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 15" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 16" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 17" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 18" });
            //lb.Items.Add(new ListBoxItem() { Content = "가나다라마바사 19" });

            lb.Items.Add(new CustomItem() { Content = "아싸라비아 1" });
            lb.Items.Add(new CustomItem() { Content = "아싸라비아 2" });
            lb.Items.Add(new CustomItem() { Content = "아싸라비아 3" });
            lb.Items.Add(new CustomItem() { Content = "아싸라비아 4" });
            lb.Items.Add(new CustomItem() { Content = "아싸라비아 5" });
            lb.Items.Add(new CustomItem() { Content = "아싸라비아 6" });
            lb.Items.Add(new CustomItem() { Content = "아싸라비아 7" });
            lb.Items.Add(new CustomItem() { Content = "아싸라비아 8" });
        }


        private void btnLBItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var listItem = (sender as Button).TemplatedParent as ListBoxItem;
                if (listItem != null)
                {
                    listItem.IsSelected = true;
                    popup.PlacementTarget = listItem as UIElement;
                    popup.IsOpen = !popup.IsOpen;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }            
        }
    }

    public class CustomItem
    {
        public string Content { get; set; }
    }
}
