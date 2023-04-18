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

namespace Practicheskaya_5
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
            listBox1.Items.Clear(); //очистка listBox

            string text = textBox1.Text;//запись текста в переменную с textBox

            string[] splitText = text.Split(' ');//разделение текста на слова

            for(int i = 0; i < splitText.Length; i++)
                listBox1.Items.Add(splitText[i]);//добавление слов в listBox
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            label1.Content = "";//очистка label

            string text = textBox1.Text;//запись текста в переменную с textBox

            string[] splitText = text.Split(' ');//разделение текста на слова

            for (int i = splitText.Length - 1; i >= 0; i--)
                label1.Content += splitText[i] + " ";//добавление слов в label в обратном порядке
        }
    }
}
