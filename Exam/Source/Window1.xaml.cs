using Exam.Source;
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
using System.Windows.Shapes;

namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private readonly Run DataDB;

        public Window1()
        {
            

            InitializeComponent();
            DataDB = Run.Instance;
        }

        private void Closing_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Saving_Click(object sender, RoutedEventArgs e)
        {
            if (adName.Text == "") { }
            if (adProc.Text == "") { adProc.Text = "Unknown"; }
            if (adRam.Text == "") { adRam.Text = "0"; }
            if (adMem.Text == "") { adMem.Text = "0"; }
            Computer computer = new Computer($"{adName.Text}", $"{adProc.Text}", (adRam.Text), (adMem.Text));
            DataDB.spisok.AddComputer(computer);
            var Window2 = new Window2(computer.ID);
            Window2.Show();
            this.Close();
        }
    }
}
