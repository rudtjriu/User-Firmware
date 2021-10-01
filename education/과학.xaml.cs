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
using System.Diagnostics;
using System.Threading;

//using System.Windows.Forms;

namespace education
{
    /// <summary>
    /// 과학.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 

    public partial class 과학 : Window
    {

        string file = "";

        public 과학()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            /*
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            //dlg.FileName = "바탕 화면";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text Files(*.txt) | *.txt";

            Nullable<bool> result = dlg.ShowDialog();

            if(result == true)
            {
                file = dlg.FileName;
            }
            */

            //System.Diagnostics.Process.Start("11.bat", "C:\Users\HOME-PC\Desktop");

            //System.Diagnostics.Process.Start("chrome.exe", "http://www.naver.com");

            string filename = @"C:\Users\HOME-PC\Desktop\Back_up\onetouch_program\onetouch.bat";

            //string url = "http://www.naver.com";



            Process.Start(filename);


            

                /*
                Nullable<bool> result = dlg.ShowDialog();


                // Get the selected file name and display in a TextBox 


                if (result == true)
                {
                    // Open document 
                    string filename = dlg.FileName;

                }
                */

          }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            file = textbox.Text;
        }
    }
}

