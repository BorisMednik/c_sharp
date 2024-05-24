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

namespace Exam.Source
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private readonly Run DataDB;
        private int ItemIndex;
        public Window2(int Index)
        {
             ItemIndex = Index;

            InitializeComponent();
            DataDB = Run.Instance;
            aID.Content += Convert.ToString(Index);
            aName.Text = DataDB.spisok.GetName(ItemIndex);
            aProc.Text = DataDB.spisok.GetProcessor(ItemIndex);
            aRam.Text = DataDB.spisok.GetRam(ItemIndex);
            aMem.Text = DataDB.spisok.GetMemory(ItemIndex);
        }

        private void Closing_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Saving_Click(object sender, RoutedEventArgs e)
        {
            DataDB.spisok.AddName(ItemIndex,aName.Text);
            DataDB.spisok.AddProcessor(ItemIndex, aProc.Text);
            DataDB.spisok.AddRam(ItemIndex, aRam.Text);
            DataDB.spisok.AddMemory(ItemIndex, aMem.Text);
        }
            private void Del_Click(object sender, RoutedEventArgs e)
        {
            DataDB.spisok.DeleteItem(ItemIndex);
            this.Close();
        }
    }
}
