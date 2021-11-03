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
using System.Drawing;
using System.Drawing.Font;



namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

        }

        

        private void FontType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontname = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            { textBox.FontFamily = new FontFamily(fontname); };
        }

        private void FontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double fontsize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textBox != null)
            { textBox.FontSize = fontsize; };
        }

        private void Bold_button_Click(object sender, RoutedEventArgs e)
        {
            bool fonttype = (sender as Button).IsPressed;
            if (textBox != null)
            {
                if (fonttype == true)
                { textBox.FontStyle = FontStyle.Bold; }
                    ;
            };
        }

        private void Italic_button_Click(object sender, RoutedEventArgs e)
        {
            bool fonttype = (sender as Button).IsPressed;
            if (textBox != null)
            {

                if (fonttype == true)
                { textBox.FontStyle = FontStyle.Italic; }
                    ;
            }
        }

        private void Underline_button_Click(object sender, RoutedEventArgs e)
        {
            bool fonttype = (sender as Button).IsPressed;
            if (textBox != null)
            {

                if (fonttype == true)
                { textBox.FontStyle = FontStyle.Underline; }
                    ;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            bool fonttype = Convert.ToBoolean((sender as RadioButton).IsChecked);
            if (textBox != null)
            {

                if (fonttype == true)
                { textBox.ForeColor = Color.Red; }
                    ;
            }
        }
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            bool fonttype = Convert.ToBoolean((sender as RadioButton).IsChecked);
            if (textBox != null)
            {

                if (fonttype == true)
                { textBox.ForeColor = Color.Black; }
                    ;
            }
        }
    }
}
