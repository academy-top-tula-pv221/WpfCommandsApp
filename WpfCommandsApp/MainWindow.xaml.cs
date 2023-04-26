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

namespace WpfCommandsApp
{
    
    public static class MyAppCommands
    {
        public static RoutedCommand Exit { set; get; }
        static MyAppCommands()
        {
            Exit = new RoutedCommand("Exit", typeof(MainWindow));
        }
    }
    
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //CommandBinding binding = new();
            //binding.Command = ApplicationCommands.Help;
            //binding.Executed += helpExecute;
            //btnHelp.CommandBindings.Add(binding);

        }

        void helpExecute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Help for appalication");
        }

        void exitExecute(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
