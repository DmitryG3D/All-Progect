using System;
using System.Windows;
using System.Diagnostics;

namespace All_Progects
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("D:\\Tools\\C#\\Morse(WPF)\\Wpf\\bin\\Debug\\Wpf.exe");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("D:\\Tools\\C#\\FileWorker(WPF)\\Tut\\bin\\Debug\\Tut.exe");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("D:\\Tools\\C#\\Notes(WPF)\\Notes\\bin\\Debug\\Notes.exe");
        }
    }
}
