using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;


namespace SecretText
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Label_code.Visibility = Visibility.Hidden;
            Label_Uncode.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e) // открыть файл
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                EnterCode.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // сохранить в файл
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, ResultCode.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TextBoxKey.Text == "")
                {
                    MessageBox.Show("Введите ключ шифровки");
                    return;
                }

                if (EnterCode.Text == "")
                {
                    if (RadioButton_Encoding.IsChecked == true)
                    {
                        MessageBox.Show("Нечего шифровать!!!\nЗаполните поле с текстом");
                    }
                    if (RadioButton_Decoding.IsChecked == true)
                    {
                        MessageBox.Show("Нечего расшифровывать!!!\nЗаполните поле с текстом");
                    }
                }

                Int64 per = Convert.ToInt32(TextBoxKey.Text);

                if (RadioButton_Encoding.IsChecked == false && RadioButton_Decoding.IsChecked == false)
                {
                    MessageBox.Show("Выберете зашифровать или расшифровать информацию");
                    return;
                }
                if (RadioButton_Encoding.IsChecked == true)
                {
                    Label_Uncode.Visibility = Visibility.Hidden;
                    Label_code.Visibility = Visibility.Visible;
                    Pressmark pressmark = new Pressmark(TextBoxKey.Text);
                    string result = pressmark.Encoding(EnterCode.Text);
                    ResultCode.Text = result;
                }
                if (RadioButton_Decoding.IsChecked == true)
                {
                    Label_code.Visibility = Visibility.Hidden;
                    Label_Uncode.Visibility = Visibility.Visible;
                    Pressmark pressmark = new Pressmark(TextBoxKey.Text);
                    string result = pressmark.Decoding(EnterCode.Text);
                    ResultCode.Text = result;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ключ должен состоять только из чисел");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Слишком большой ключ");
            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Label_code.Visibility = Visibility.Hidden;
            Label_Uncode.Visibility = Visibility.Hidden;
            ResultCode.Text = EnterCode.Text;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Label_code.Visibility = Visibility.Hidden;
            Label_Uncode.Visibility = Visibility.Hidden;
            EnterCode.Text = ResultCode.Text;
        }
    }
}
