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

                foreach(Room r in _Rooms) {
                    tbOut.Text += r.Number + " | \r\n";
                }


            }


        }
    }
}
