using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;

namespace ClickMe
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _i = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            _i++;
            switch (_i)
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
                default:
                {
                    Button.Content = "别点了！！！😫";
                    break;
                }
            }
        }
    }
}