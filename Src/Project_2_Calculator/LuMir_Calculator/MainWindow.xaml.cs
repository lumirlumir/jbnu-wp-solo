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

namespace LuMir_Calculator
{


    public partial class MainWindow : Window
    {

        private bool NewButton;
        private double SavedValue;
        private double Sum = 0;
        private int Count = 0;
        private char MyOperator=' ';

        public MainWindow()
        {
            InitializeComponent();
            txtResult.Text = "0";
        }

        private void Button_DEL(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if(txtResult.Text.Length==0)
            {
                txtResult.Text = "0";
            }
        }

        private void Button_SQRT(object sender, RoutedEventArgs e)//완료
        {
            if (double.Parse(txtResult.Text) >= 0)
                txtResult.Text = Math.Sqrt(double.Parse(txtResult.Text)).ToString();
            else
                return;
        }

        private void Button_X2(object sender, RoutedEventArgs e)//완료
        {
            txtResult.Text = ((double.Parse(txtResult.Text)) * (double.Parse(txtResult.Text))).ToString();
        }

        private void Button_1SLASHX(object sender, RoutedEventArgs e)//완료
        {
            txtResult.Text = (1 / double.Parse(txtResult.Text)).ToString();
        }

        private void Button_AC(object sender, RoutedEventArgs e)//완료
        {
            txtResult.Text = "0";
        }

        private void Button_PlusSLASHMinus(object sender, RoutedEventArgs e)//완료
        {
            double temp = double.Parse(txtResult.Text);
            txtResult.Text = (-temp).ToString();
        }

        private void Button_Percent(object sender, RoutedEventArgs e)//완료
        {
            txtResult.Text = (double.Parse(txtResult.Text)/100).ToString();
        }

        private void Button_Devide(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;

            if (MyOperator == '+')
                Sum += double.Parse(txtResult.Text);
            else if (MyOperator == '-')
                Sum -= double.Parse(txtResult.Text);
            else if (MyOperator == '*')
                Sum *= double.Parse(txtResult.Text);
            else if (MyOperator == '/')
            {
                if (double.Parse(txtResult.Text) != 0)
                    Sum /= double.Parse(txtResult.Text);
                else
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.", "Wrong Operation ʕ•ᴥ•ʔ", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            SavedValue = double.Parse(txtResult.Text);
            MyOperator = btn.Content.ToString()[0];
            NewButton = true;

            if (Count == 0)
            {
                Sum = SavedValue;
                Count++;
            }         

            Label_History.Content += txtResult.Text;
            Label_History.Content += " ";
            Label_History.Content += MyOperator.ToString();
            Label_History.Content += " ";

            txtResult.Text = "0";
        }

        private void Button_Multiply(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;

            if (MyOperator == '+')
                Sum += double.Parse(txtResult.Text);
            else if (MyOperator == '-')
                Sum -= double.Parse(txtResult.Text);
            else if (MyOperator == '*')
                Sum *= double.Parse(txtResult.Text);
            else if (MyOperator == '/')
            {
                if (double.Parse(txtResult.Text) != 0)
                    Sum /= double.Parse(txtResult.Text);
                else
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.", "Wrong Operation ʕ•ᴥ•ʔ", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            SavedValue = double.Parse(txtResult.Text);
            MyOperator = btn.Content.ToString()[0];
            NewButton = true;

            if (Count == 0)
            {
                Sum = SavedValue;
                Count++;
            }

            Label_History.Content += txtResult.Text;
            Label_History.Content += " ";
            Label_History.Content += MyOperator.ToString();
            Label_History.Content += " ";

            txtResult.Text = "0";
        }

        private void Button_Minus(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;

            if (MyOperator == '+')
                Sum += double.Parse(txtResult.Text);
            else if (MyOperator == '-')
                Sum -= double.Parse(txtResult.Text);
            else if (MyOperator == '*')
                Sum *= double.Parse(txtResult.Text);
            else if (MyOperator == '/')
            {
                if (double.Parse(txtResult.Text) != 0)
                    Sum /= double.Parse(txtResult.Text);
                else
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.", "Wrong Operation ʕ•ᴥ•ʔ", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            SavedValue = double.Parse(txtResult.Text);
            MyOperator = btn.Content.ToString()[0];
            NewButton = true;

            if (Count == 0)
            {
                Sum = SavedValue;
                Count++;
            }

            Label_History.Content += txtResult.Text;
            Label_History.Content += " ";
            Label_History.Content += MyOperator.ToString();
            Label_History.Content += " ";

            txtResult.Text = "0";
        }

        private void Button_Plus(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;

            if (MyOperator == '+')
                Sum += double.Parse(txtResult.Text);
            else if (MyOperator == '-')
                Sum -= double.Parse(txtResult.Text);
            else if (MyOperator == '*')
                Sum *= double.Parse(txtResult.Text);
            else if (MyOperator == '/')
            {
                if (double.Parse(txtResult.Text) != 0)
                    Sum /= double.Parse(txtResult.Text);
                else
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.", "Wrong Operation ʕ•ᴥ•ʔ", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            SavedValue = double.Parse(txtResult.Text);
            MyOperator = btn.Content.ToString()[0];
            NewButton = true;

            if (Count == 0)
            {
                Sum = SavedValue;
                Count++;
            }

            Label_History.Content += txtResult.Text;
            Label_History.Content += " ";
            Label_History.Content += MyOperator.ToString();
            Label_History.Content += " ";

            txtResult.Text = "0";
        }

        private void Button_Equal(object sender, RoutedEventArgs e)//완료
        {

            Label_History.Content += txtResult.Text;
            Label_History.Content += " ";
            Label_History.Content += "=";
            Label_History.Content += " ";

            if (MyOperator == '+')
                txtResult.Text = (Sum + double.Parse(txtResult.Text)).ToString();
            else if (MyOperator == '-')
                txtResult.Text = (Sum - double.Parse(txtResult.Text)).ToString();
            else if (MyOperator == '*')
                txtResult.Text = (Sum * double.Parse(txtResult.Text)).ToString();
            else if (MyOperator == '/')
            {
                if (double.Parse(txtResult.Text) != 0)
                    txtResult.Text = (Sum / double.Parse(txtResult.Text)).ToString();
                else
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.", "Wrong Operation ʕ•ᴥ•ʔ", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            Label_History.Content += txtResult.Text;

            ListView.Content += (Label_History.Content).ToString();
            ListView.Content += "\n";

            Count = 0;
            MyOperator = ' ';
            Sum = 0;
            Label_History.Content = " ";
        }
        
        private void Button_0(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;
            string number = btn.Content.ToString();

            if (txtResult.Text == "0" || NewButton == true)
            {
                txtResult.Text = number;
                NewButton = false;
            }

            else
                txtResult.Text += number;
        }

        private void Button_1(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;
            string number = btn.Content.ToString();

            if (txtResult.Text == "0" || NewButton == true)
            {
                txtResult.Text = number;
                NewButton = false;
            }

            else
                txtResult.Text += number;
        }

        private void Button_2(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;
            string number = btn.Content.ToString();

            if (txtResult.Text == "0" || NewButton == true)
            {
                txtResult.Text = number;
                NewButton = false;
            }

            else
                txtResult.Text += number;
        }

        private void Button_3(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;
            string number = btn.Content.ToString();

            if (txtResult.Text == "0" || NewButton == true)
            {
                txtResult.Text = number;
                NewButton = false;
            }

            else
                txtResult.Text += number;
        }

        private void Button_4(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;
            string number = btn.Content.ToString();

            if (txtResult.Text == "0" || NewButton == true)
            {
                txtResult.Text = number;
                NewButton = false;
            }

            else
                txtResult.Text += number;
        }

        private void Button_5(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;
            string number = btn.Content.ToString();

            if (txtResult.Text == "0" || NewButton == true)
            {
                txtResult.Text = number;
                NewButton = false;
            }

            else
                txtResult.Text += number;
        }

        private void Button_6(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;
            string number = btn.Content.ToString();

            if (txtResult.Text == "0" || NewButton == true)
            {
                txtResult.Text = number;
                NewButton = false;
            }

            else
                txtResult.Text += number;
        }

        private void Button_7(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;
            string number = btn.Content.ToString();

            if (txtResult.Text == "0" || NewButton == true)
            {
                txtResult.Text = number;
                NewButton = false;
            }

            else
                txtResult.Text += number;
        }

        private void Button_8(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;
            string number = btn.Content.ToString();

            if (txtResult.Text == "0" || NewButton == true)
            {
                txtResult.Text = number;
                NewButton = false;
            }

            else
                txtResult.Text += number;
        }

        private void Button_9(object sender, RoutedEventArgs e)//완료
        {
            Button btn = sender as Button;
            string number = btn.Content.ToString();

            if (txtResult.Text == "0" || NewButton == true)
            {
                txtResult.Text = number;
                NewButton = false;
            }

            else
                txtResult.Text += number;
        }

        private void Button_Dot(object sender, RoutedEventArgs e)//완료
        {
            if (txtResult.Text.Contains("."))
                return;

            else
                txtResult.Text += ".";
        }
    }
}
