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

namespace TheNextCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Car nextCar;
        public MainWindow()
        {
            InitializeComponent();

            AccubatteryController accubatterryController = new AccubatteryController();
            DoorController doorController = new DoorController();

            nextCar = new Car();
            nextCar.setAccubaterryController(accubatterryController);
            nextCar.setDoorController(doorController);
        }

        private void AccuButton_Click(object sender, RoutedEventArgs e)
        {
            Boolean powerIsOn = nextCar.powerIsReady();
            if (powerIsOn)
            {
                this.nextCar.turnOfPower();
                this.AccuState.Content = "No Power";
                this.AccuButton.Content = "OFF";
            }
            else
            {
                this.nextCar.turnOnPower();
                this.AccuState.Content = "Power is Ready";
                this.AccuButton.Content = "ON";
            }
            //Console.WriteLine("Button Aki");
        }

        private void DoorButton_Click(object sender, RoutedEventArgs e)
        {
            Boolean doorIsLocked = nextCar.doorIsLocked();
            Boolean doorIsClosed = nextCar.doorIsClosed();

            if (!doorIsClosed)
            {
                nextCar.closeTheDoor();
            }

            doorIsClosed = nextCar.doorIsClosed();

            if (doorIsClosed && !doorIsLocked)
            {
                this.nextCar.lockTheDoor();
                this.DoorState.Content = "Door id Locked";
                this.DoorButton.Content = "ON";
            }
            else if (doorIsClosed && doorIsLocked)
            {
                this.nextCar.unlockTheDoor();
                this.DoorState.Content = "Door id Unlocked";
                this.DoorButton.Content = "OFF";
            }
            //Console.WriteLine("Button Pintu");
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (nextCar.doorIsLocked() &&
                nextCar.doorIsClosed() &&
                nextCar.powerIsReady())
            {
                Console.WriteLine("Mesin Menyala");
            }
            else
            {
                Console.WriteLine("Periksa Aki / Pintu Mobil");
            }
            //Console.WriteLine("Button Start");
        }
    }
}
