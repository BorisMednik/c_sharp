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

namespace Exam.Source
{
    /// <summary>
    /// Логика взаимодействия для Control2.xaml
    /// </summary>
    public partial class Control2 : UserControl
    {
        private int Index;
        public Control2(Computer cpu)
        {
            InitializeComponent();

            Index = cpu.ID;
            UID.Content = Convert.ToString(cpu.ID);
            Uname.Content += cpu.Name;
            UProc.Content += cpu.Processor;
            URam.Content += Convert.ToString(cpu.Ram);
            UMem.Content += Convert.ToString(cpu.Memory);
        }


        private void MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var Window2 = new Window2(Index);
            Window2.Show();
        }

        //public void mouseenter(object sender, MouseEventArgs e)
        //{
        //    var bc = new BrushConverter();
        //    Control2 control = e.Source as Control2;
        //    control.Background = (Brush)bc.ConvertFrom("#CCDDE5EB");
        //    control.Background = new SolidColorBrush(Color.FromValues("#CCDDE5EB"))
        //}
        private void openButton_Click(object sender, RoutedEventArgs e)
        {
            var Window2 = new Window2(Index);
            Window2.Show();
        }
    }
}
