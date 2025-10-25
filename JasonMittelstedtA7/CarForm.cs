using JasonMittelstedtA7.Model;
using JasonMittelstedtA7.Comparers;
using System.Text.Json;
namespace JasonMittelstedtA7
{
    /// <summary>
    /// Represents the main form for displaying and sorting car data.
    /// </summary>
    public partial class CarForm : Form
    {
        /// <summary>
        /// A list containing the collection of <see cref="Car"/> objects loaded from a file.
        /// </summary>
        private List<Car> cars = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="CarForm"/> class and disables sort buttons until data is loaded.
        /// </summary>
        public CarForm()
        {
            InitializeComponent();
            btnSortMake.Enabled = false;
            btnSortMakePrice.Enabled = false;
        }

        /// <summary>
        /// Handles the event when the "Choose File" button is clicked.
        /// Prompts the user to select a JSON file, loads car data, and enables sorting buttons.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
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

        /// <summary>
        /// Handles the event when the "Sort by Make" button is clicked.
        /// Sorts the list of cars by their make (alphabetically).
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void btnSortMake_Click(object sender, EventArgs e)
        {
            cars.Sort();
            DisplayCars();
        }

        /// <summary>
        /// Handles the event when the "Sort by Make and Price" button is clicked.
        /// Sorts the list of cars first by make and then by price.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void btnSortMakePrice_Click(object sender, EventArgs e)
        {
            cars.Sort(new CarMakePriceComparer());
            DisplayCars();
        }

        /// <summary>
        /// Displays the current list of cars in the ListBox.
        /// If no cars are loaded, shows a message instead.
        /// </summary>
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
