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

namespace Associations {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Room _Room;
        int[] ints = new int[5];
        Room[] _Rooms = new Room[4];


        public MainWindow() {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, RoutedEventArgs e) {
            Random rnd;
            int seed;
            if (txtSeed.Text != "") {
                int.TryParse(txtSeed.Text, out seed);
                rnd = new Random(seed);
            } else {
                seed = DateTime.Now.Millisecond;
                rnd = new Random();
            }

            string output = seed.ToString() + " :: ";
            for (int i = 0; i < 10; i++) {
                int randNum = rnd.Next();
                output += randNum + " | ";
            }
            tbOut.Text += output + "\r\n";

        }

        private void btnMakeRoom_Click(object sender, RoutedEventArgs e) {
            _Room = new Room();
            _Room.Number = 7;

            Teacher tch = new Teacher();
            tch.FirstName = "Bob";

            int rmNum = _Room.Number;
            _Room.Number = rmNum;
            rmNum.ToString();

            _Room.Teacher = tch;

            _Rooms[0] = new Room();
            _Rooms[1] = new Room();
            _Rooms[2] = new Room();
            _Rooms[3] = new Room();

            _Rooms[0].Number = 10;
            _Rooms[1].Number = 15;
            _Rooms[2].Number = 20;
            _Rooms[3].Number = 25;


        }

        private void btnShow_Click(object sender, RoutedEventArgs e) {
            if (_Room == null) {
                MessageBox.Show("Please create the room first");
            } else {
                _Room.Teacher.Room = _Room;
                //tbOut.Text = _Room.Teacher.FirstName;

                foreach (Room r in _Rooms) {
                    tbOut.Text += r.Number + " | \r\n";
                }


            }


        }

        private void btnMakeStudents_Click(object sender, RoutedEventArgs e) {
            Room rm = new Room();
            rm.Number = 13;
            rm.Teacher = new Teacher();
            rm.Teacher.FirstName = "Marty";
            Teacher tch = rm.Teacher;
            tch.MiddleName = "George";

            tch.Room = rm;
            rm.Teacher.Room = rm;

            //tch.Room.Teacher.Room.Number = 15;
            //rm.Teacher.Room.Teacher.Room.Number = 30;

            Student stud1 = new Student() { FirstName = "Sushan" };
            Student stud2 = new Student() { FirstName = "Meshari" };
            Student stud3 = new Student() { FirstName = "Taki" };
            Student stud4 = new Student() { FirstName = "Yumi" };

            //tch.Room.Students = new Student[37];

            //tch.Room.Students[0] = stud1;
            //tch.Room.Students[1] = stud4;
            //tch.Room.Students[2] = stud2;
            //tch.Room.Students[3] = stud3;

            //tch.Room.Students = new Student[3];

            MessageBox.Show(rm.Number.ToString());



            int[] arr;
            arr = new int[4];
            arr[1] = 2;

        }

        private void btnFillGrid_Click(object sender, RoutedEventArgs e) {
            int[,] values = new int[4, 5];
            //                      0, 1, 2, 3 
            //    0  1  2  3  4
            //  0
            //  1
            //  2
            //  3
            int seed = 1;
                    Random rnd = new Random();
            for (int row = 0; row < values.GetLength(0); row++) {
                // 0 - 3
                for (int col = 0; col < values.GetLength(1); col++) {
                    // 0 - 4
                  int rNum = rnd.Next(10);
                    if(rNum < 3) {
                    values[row, col] = 10 ; // 0, 10 ,20
                    }else if(rNum < 8) {
                        values[row, col] = 20; // 0, 10 ,20
                    } else {
                        //values[row, col] = 20; // 0, 10 ,20
                    }
                }
            }

            FillGrid(values);

        }

        private void FillGrid(int[,] values) {
            grdFiller.Children.Clear();
            for (int row = 0; row < values.GetLength(0); row++) {
                for (int col = 0; col < values.GetLength(1); col++) {
                    TextBlock tb = new TextBlock();
                    Grid.SetColumn(tb, col);
                    Grid.SetRow(tb, row);
                    tb.FontSize = 20;
                    grdFiller.Children.Add(tb);

                    if(values[row,col] == 0) {
                    tb.Text = "";
                    }else if(values[row,col] == 10) {
                        tb.Text = "S";
                        tb.Foreground = new SolidColorBrush(Colors.Blue);
                    } else {
                        tb.Text = "M";
                        tb.Foreground = new SolidColorBrush(Colors.Purple);
                    }

                }
            }
        }
    }
}
