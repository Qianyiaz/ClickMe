using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ClickMe
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            i++;
            switch (i)
            {
                case 1:
                {
                    Button.Content = "你点我干啥？😫";
                    break;
                }
                case 2:
                {
                    Button.Content = "你再点试试？😠";
                    break;
                }
                case 3:
                {
                    Button.Content = "你再点！😡";
                    break;
                }
                case 4:
                {
                    Button.Content = "你再点！!😡😡";
                    break;
                }
                case 5:
                {
                    Button.Content = "你再点！！！🤬";
                    break;
                }
                case 6:
                {
                    Button.Content = "你干嘛！哎呦喂。😫";
                    await Task.Delay(1000);
                    Process.Start(
                        new ProcessStartInfo("https://www.bilibili.com/video/BV1GJ411x7h7")
                    );
                    Close();
                    break;
                }
            }
        }

        private void Border_Mouse(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Border.Background = System.Windows.Media.Brushes.Gray;
            DragMove();
        }

        private void Border_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Border.Background = System.Windows.Media.Brushes.LightGray;
        }
    }
}
