using System;//Радзивиловский дз3
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

namespace макс_дз3
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

        private void TEXT_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*
            // Cчитываем из файла сообщения
            string m = TEXT.Text;


            int nomer; // Номер в алфавите
            int d; // Смещение
            string s; //Результат
            int j; // Переменная для циклов

            char[] massage = m.ToCharArray(); // Превращаем строку в массив символов.

            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            // Перебираем каждый символ сообщения
            for (int i = 0; i < massage.Length; i++)
            {
            // Ищем индекс буквы
            for (j = 0; j < alfavit.Length; j++)
            {
            if (massage[i] == alfavit[j])
            {
            break;
            }
            }

            if (j != 33) // Если j равно 33, значит символ не из алфавита
            {
            nomer = j; // Индекс буквы
            d = nomer + 1; // Делаем смещение

            // Проверяем, чтобы не вышли за пределы алфавита
            if (d > 32)
            {
            d = d - 33;
            }

            massage[i] = alfavit[d]; // Меняем букву
            }
            }

            s = new string(massage); // Собираем символы обратно в строку.
            RES.Text = s.ToString(); // Записываем результат
            */


        }

        private void RES_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void N_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Cчитываем из файла сообщения
            string m = TEXT.Text;

            int n = int.Parse(MyText.Text);
            int nomer; // Номер в алфавите
            int d; // Смещение
            string s; //Результат
            int j; // Переменная для циклов

            char[] massage = m.ToCharArray(); // Превращаем строку в массив символов.

            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            // Перебираем каждый символ сообщения
            for (int i = 0; i < massage.Length; i++)
            {
                // Ищем индекс буквы
                for (j = 0; j < alfavit.Length; j++)
                {
                    if (massage[i] == alfavit[j])
                    {
                        break;
                    }
                }

                if (j != 33) // Если j равно 33, значит символ не из алфавита
                {
                    nomer = j; // Индекс буквы
                    d = nomer + n; // Делаем смещение

                    // Проверяем, чтобы не вышли за пределы алфавита
                    if (d > 32)
                    {
                        d = d - 33;
                    }

                    massage[i] = alfavit[d]; // Меняем букву
                }
            }

            s = new string(massage); // Собираем символы обратно в строку.
            RES.Text = s.ToString(); // Записываем результат
        }
    }
}
