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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Run DataDB;

        private List<Computer> collection;

        public MainWindow()
        {
            DataDB = Run.Instance;

            InitializeComponent();
            
            collection = DataDB.spisok.collection;
            DataDB.spisok.Subscribe(
                () => {
                    MainWin.Children.Clear();
                    foreach (var item in DataDB.spisok.collection)
                    {
                        Control2 card = new Control2(item);
                        MainWin.Children.Add(card);
                    }
                    
                });
            //DataDB.spisok.Subscribe(
            //  () =>
            //  {
            //      ItemsNum.Content = Convert.ToString(DataDB.spisok.Length);

            //  });

        }

        private void Adder_Click(object sender, RoutedEventArgs e)
        {
            var Window1 = new Window1();
           Window1.Show();
        }
        //private void Fill ()
        //{
        //    MainWin.Children.Clear();
        //    foreach (var item in DataDB.spisok.collection)
        //    {
        //        var card = new Card(item);
        //        MainWin.Children.Add(card);
        //    }
        //}

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void mouseenter(object sender, RoutedEventArgs e)
        //{
        //    var bc = new BrushConverter();
        //    Control1 control1 = e.Source as Control1;
        //    control1.Background = (Brush)bc.ConvertFrom("#CCDDE5EB");
        //}


    }
}
