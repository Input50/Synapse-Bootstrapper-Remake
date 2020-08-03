using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Synapse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
           
               InitializeComponent();

            
        }

       

        private void home_enter(object sender, MouseEventArgs e)
        {
            popup.PlacementTarget = Home;
            popup.Placement = PlacementMode.Right;
            popup.IsOpen = true;
            header.textbox.Text = "Script Executor";
        }

        private void home_leave(object sender, MouseEventArgs e)
        {
            popup.Visibility = Visibility.Collapsed;
            popup.IsOpen = false;
        }

        private void folder_enter(object sender, MouseEventArgs e)
        {
            popup.PlacementTarget = Folder;
            popup.Placement = PlacementMode.Right;
            popup.IsOpen = true;
            header.textbox.Text = "Script Hub";
        }

        private void folder_leave(object sender, MouseEventArgs e)
        {
            popup.Visibility = Visibility.Collapsed;
            popup.IsOpen = false;
        }

        private void options_enter(object sender, MouseEventArgs e)
        {
            popup.PlacementTarget = Options;
            popup.Placement = PlacementMode.Right;
            popup.IsOpen = true;
            header.textbox.Text = "Options";
        }

        private void options_leave(object sender, MouseEventArgs e)
        {
            popup.Visibility = Visibility.Collapsed;
            popup.IsOpen = false;
        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Minibtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void executeion_home_click(object sender, RoutedEventArgs e)
        {
            Button6.Visibility = System.Windows.Visibility.Hidden;
            Button7.Visibility = System.Windows.Visibility.Hidden;
            Button8.Visibility = System.Windows.Visibility.Hidden;
            Button9.Visibility = System.Windows.Visibility.Hidden;
            Button10.Visibility = System.Windows.Visibility.Hidden;
            Button11.Visibility = System.Windows.Visibility.Hidden;
            list_box.Visibility = System.Windows.Visibility.Hidden;
            frame.NavigationService.Navigate(new EXECUTION());
            
        }

       

        private void script_hub_home(object sender, RoutedEventArgs e)
        {
            Button6.Visibility = System.Windows.Visibility.Hidden;
            Button7.Visibility = System.Windows.Visibility.Hidden;
            Button8.Visibility = System.Windows.Visibility.Hidden;
            Button9.Visibility = System.Windows.Visibility.Hidden;
            Button10.Visibility = System.Windows.Visibility.Hidden;
            Button11.Visibility = System.Windows.Visibility.Hidden;
            list_box.Visibility = System.Windows.Visibility.Hidden;
            frame.NavigationService.Navigate(new ScriptHub());
        }

        private void options_home(object sender, RoutedEventArgs e)
        {
            Button6.Visibility = System.Windows.Visibility.Hidden;
            Button7.Visibility = System.Windows.Visibility.Hidden;
            Button8.Visibility = System.Windows.Visibility.Hidden;
            Button9.Visibility = System.Windows.Visibility.Hidden;
            Button10.Visibility = System.Windows.Visibility.Hidden;
            Button11.Visibility = System.Windows.Visibility.Hidden;
            list_box.Visibility = System.Windows.Visibility.Hidden;
            frame.NavigationService.Navigate(new Options());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
