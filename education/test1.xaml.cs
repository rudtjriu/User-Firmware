using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace education
{
    /// <summary>
    /// test1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class test1 : Window
    {
        public test1()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string value = 과목.Text;

            if( value == "ATMEGA32D4" )
            {
                education.수학 section1 = new education.수학();

                section1.ShowDialog();
            }
            else if(value == "ATMEGA64D4")
            {
                education.과학 section2 = new education.과학();

                section2.ShowDialog();

            }
        }
    }
    
}
