using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AudienceWPF
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
        static bool _ctrl = false;
        static bool _alt = false;
        private void audWind_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void toggleVisibility()
        {
            if (this.Visibility == Visibility.Visible)
                this.Visibility = Visibility.Hidden;
            else
                this.Visibility = Visibility.Visible;
        }
        public void setNumAnswers(int n)
        {
            /*ImageBrush f = new ImageBrush(new BitmapImage(new Uri("/AudienceWPF;component/Resources/item bg.png")));
            rectangle0.Fill = f;
            rectangle1.Fill = f;
            rectangle2.Fill = f;
            rectangle3.Fill = f;
            rectangle4.Fill = f;
            rectangle5.Fill = f;
            rectangle6.Fill = f;
            rectangle7.Fill = f;*/
            

            switch (n)
            {
                case 1:
                    b_1.Visibility = Visibility.Visible;
                    b_2.Visibility = Visibility.Hidden;
                    b_3.Visibility = Visibility.Hidden;
                    b_4.Visibility = Visibility.Hidden;
                    b_5.Visibility = Visibility.Hidden;
                    b_6.Visibility = Visibility.Hidden;
                    b_7.Visibility = Visibility.Hidden;
                    b_8.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    b_1.Visibility = Visibility.Visible;
                    b_2.Visibility = Visibility.Visible;
                    b_3.Visibility = Visibility.Hidden;
                    b_4.Visibility = Visibility.Hidden;
                    b_5.Visibility = Visibility.Hidden;
                    b_6.Visibility = Visibility.Hidden;
                    b_7.Visibility = Visibility.Hidden;
                    b_8.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    b_1.Visibility = Visibility.Visible;
                    b_2.Visibility = Visibility.Visible;
                    b_3.Visibility = Visibility.Visible;
                    b_4.Visibility = Visibility.Hidden;
                    b_5.Visibility = Visibility.Hidden;
                    b_6.Visibility = Visibility.Hidden;
                    b_7.Visibility = Visibility.Hidden;
                    b_8.Visibility = Visibility.Hidden;
                    break;
                case 4:
                    b_1.Visibility = Visibility.Visible;
                    b_2.Visibility = Visibility.Visible;
                    b_3.Visibility = Visibility.Visible;
                    b_4.Visibility = Visibility.Visible;
                    b_5.Visibility = Visibility.Hidden;
                    b_6.Visibility = Visibility.Hidden;
                    b_7.Visibility = Visibility.Hidden;
                    b_8.Visibility = Visibility.Hidden;
                    break;
                case 5:
                    b_1.Visibility = Visibility.Visible;
                    b_2.Visibility = Visibility.Visible;
                    b_3.Visibility = Visibility.Visible;
                    b_4.Visibility = Visibility.Visible;
                    b_5.Visibility = Visibility.Visible;
                    b_6.Visibility = Visibility.Hidden;
                    b_7.Visibility = Visibility.Hidden;
                    b_8.Visibility = Visibility.Hidden;
                    break;
                case 6:
                    b_1.Visibility = Visibility.Visible;
                    b_2.Visibility = Visibility.Visible;
                    b_3.Visibility = Visibility.Visible;
                    b_4.Visibility = Visibility.Visible;
                    b_5.Visibility = Visibility.Visible;
                    b_6.Visibility = Visibility.Visible;
                    b_7.Visibility = Visibility.Hidden;
                    b_8.Visibility = Visibility.Hidden;
                    break;
                case 7:
                    b_1.Visibility = Visibility.Visible;
                    b_2.Visibility = Visibility.Visible;
                    b_3.Visibility = Visibility.Visible;
                    b_4.Visibility = Visibility.Visible;
                    b_5.Visibility = Visibility.Visible;
                    b_6.Visibility = Visibility.Visible;
                    b_7.Visibility = Visibility.Visible;
                    b_8.Visibility = Visibility.Hidden;
                    break;
                case 8:
                    b_1.Visibility = Visibility.Visible;
                    b_2.Visibility = Visibility.Visible;
                    b_3.Visibility = Visibility.Visible;
                    b_4.Visibility = Visibility.Visible;
                    b_5.Visibility = Visibility.Visible;
                    b_6.Visibility = Visibility.Visible;
                    b_7.Visibility = Visibility.Visible;
                    b_8.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void audWind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.L)
            {
                if (this.WindowStyle == System.Windows.WindowStyle.None)
                {
                    this.WindowStyle = System.Windows.WindowStyle.SingleBorderWindow;
                    if (_ctrl && _alt)
                        this.WindowState = System.Windows.WindowState.Normal;
                }
                else
                {
                    this.WindowStyle = System.Windows.WindowStyle.None;
                    if (_ctrl && _alt)
                        this.WindowState = WindowState.Maximized;
                }
            }
            else if (e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl)
            {
                _ctrl = true;
            }
            else if (e.Key == Key.LeftAlt || e.Key == Key.RightAlt)
            {
                _alt = true;
            }
           
        }

        private void audWind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl)
            {
                _ctrl = false;
            }
            else if (e.Key == Key.LeftAlt || e.Key == Key.RightAlt)
            {
                _alt = false;
            }
        }

        private void FlipBack(ref ImageBrush itemBg, ref Rectangle blankBoardFlip, ref Label answerBox, ref Label blankBox, ref Label pointBox)
        {
            blankBoardFlip.Fill = itemBg;
            answerBox.Visibility = Visibility.Hidden;
            blankBox.Visibility = Visibility.Visible;
            pointBox.Visibility = Visibility.Hidden;
        }

        public void FlipBack(int answer, ref ImageBrush itemBg)
        {
            switch (answer) {
                case 0: FlipBack(ref itemBg, ref rectangle0, ref a_1, ref b_1, ref p1); break;
                case 1: FlipBack(ref itemBg, ref rectangle1, ref a_2, ref b_2, ref p2); break;
                case 2: FlipBack(ref itemBg, ref rectangle2, ref a_3, ref b_3, ref p3); break;
                case 3: FlipBack(ref itemBg, ref rectangle3, ref a_4, ref b_4, ref p4); break;
                case 4: FlipBack(ref itemBg, ref rectangle4, ref a_5, ref b_5, ref p5); break;
                case 5: FlipBack(ref itemBg, ref rectangle5, ref a_6, ref b_6, ref p6); break;
                case 6: FlipBack(ref itemBg, ref rectangle6, ref a_7, ref b_7, ref p7); break;
                case 7: FlipBack(ref itemBg, ref rectangle7, ref a_8, ref b_8, ref p8); break;
                default:
                    break;

            }

        }
    }
}
