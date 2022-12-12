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

namespace MyToDo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _topmostIs = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimize_Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void DragMove_ToolBar(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }

        private void OpacitySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BackgrondWindowBorder.Opacity = (double)e.NewValue;
        }

        private void Topmost_Button_Click(object sender, RoutedEventArgs e)
        {
            if (_topmostIs == false)
            {
                _topmostIs = true;
                this.Topmost = true;
            }
            else
            {
                _topmostIs = false;
                this.Topmost = false;
            }
        }

        private void Search_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
