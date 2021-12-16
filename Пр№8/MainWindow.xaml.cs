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

namespace Пр_8
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
        Father nameFather = new Father();
        Child nameChild = new Child();

        private void InfoFather_Click(object sender, RoutedEventArgs e)
        {
            nameFather.Name = NameFather.Text;
            nameFather.Surname = SurnameFather.Text;
            infoFather.Text = nameFather.Print();
        }

        private void InfoChild_Click(object sender, RoutedEventArgs e)
        {
            nameChild.Name = NameChild.Text;
            nameChild.Surname = SurnameChild.Text;
            nameChild.MiddleName = PatronymicChild.Text;
            infoChild.Text = nameChild.Print();
        }

        private void CompareSurname_Click(object sender, RoutedEventArgs e)
        {
            nameFather.Surname = SurnameFather.Text;
            nameChild.Surname = SurnameChild.Text;
            int rezult = String.Compare(nameFather.Surname,nameChild.Surname);
            if (rezult == 0) compareSurname.Text = "Фамилии одинаковы";
            else compareSurname.Text = "Фамилии разные";
        }

        private void Clone_Click(object sender, RoutedEventArgs e)
        {
            nameFather.Name = NameFather.Text;
            nameFather.Surname = SurnameFather.Text;
            Father x1 = nameFather.ShallowClone();
            Father x3 = (Father)nameFather.Clone();
            nameChild.Name = NameChild.Text;
            nameChild.Surname = SurnameChild.Text;
            Child x2 = nameChild.ShallowClone();
            Child x4 = (Child)nameChild.Clone();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Informatoin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №8 Вариант 11\nВыполнил студент группы ИСП-31 Обухов С.\nЗадание:Создать интерфейс - человек, у которого есть имя, функция печати. Создать класс отец, у которого функция печати выводит имя.Создать класс ребенок, у которого есть отец, отчество, функция печати выводит имя и отчество. Классы должны включать конструкторы.Сравнение производить по фамилии.","О программе",MessageBoxButton.OK,MessageBoxImage.Question);
        }
    }
}
