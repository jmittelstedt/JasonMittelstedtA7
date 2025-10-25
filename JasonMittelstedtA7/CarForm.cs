using JasonMittelstedtA7.Model;
using JasonMittelstedtA7.Comparers;
using System.Text.Json;
namespace JasonMittelstedtA7
{
    public partial class CarForm : Form
    {
        private List<Car> cars = new();
        public CarForm()
        {
            InitializeComponent();
            btnSortMake.Enabled = false;
            btnSortMakePrice.Enabled = false;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new()
            {
                Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*",
                Title = "Select Car Data File"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(ofd.FileName);
                cars = JsonSerializer.Deserialize<List<Car>>(json) ?? new();
                DisplayCars();
                btnSortMake.Enabled = true;
                btnSortMakePrice.Enabled = true;
            }
        }

        private void btnSortMake_Click(object sender, EventArgs e)
        {
            cars.Sort();
            DisplayCars();
        }

        private void btnSortMakePrice_Click(object sender, EventArgs e)
        {
            cars.Sort(new CarMakePriceComparer());
            DisplayCars();
        }

        private void DisplayCars()
        {
            listBoxCars.Items.Clear();
            if (cars.Count == 0)
            {
                listBoxCars.Items.Add("No Data Loaded");
            }
            else
            {
                foreach (Car car in cars)
                    listBoxCars.Items.Add(car.ToString());
            }
        }
    }
}
