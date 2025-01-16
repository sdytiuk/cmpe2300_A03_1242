/* Creating a new class
 * Steven Dytiuk
 *  */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ClassDemo
{
    
    public partial class Form1 : Form
    {
        List<Car> cars = null;
        public Form1()
        {
            InitializeComponent();
            btnNewCar.Click += BtnNewCar_Click;
            btnShowCars.Click += BtnShowCars_Click;
            lbCars.Click += LbCars_Click;
        }

        private void LbCars_Click(object sender, EventArgs e)
        {
            ((Car)((ListBox)sender).SelectedItem).RenovateCar();
        }

        private void BtnShowCars_Click(object sender, EventArgs e)
        {
            FirstCar();
            lbCars.DataSource = null;
            lbCars.DataSource = cars;
        }

        private void FirstCar()
        {
            cars?[0].ShowYourself();

            int? x = null;
            if (x == null) x = 3;
            Console.WriteLine(x);

        }

        private void BtnNewCar_Click(object sender, EventArgs e)
        {
            if (cars == null)
                cars = new List<Car>();
            cars.Add( new Car());
            
        }
    }

    
}
