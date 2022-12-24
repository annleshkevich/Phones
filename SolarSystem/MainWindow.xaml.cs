using SolarSystem.BusinessLogic.Implementation;
using SolarSystem.Model.DatabaseModels;
using System.Windows;
using System.Windows.Controls;

namespace SolarSystem
{
    public partial class MainWindow : Window
    {
        PlanetService _planetService;
        public MainWindow()
        {
            InitializeComponent();
            _planetService = new PlanetService();
            planetsGrid.ItemsSource = _planetService.Get();
        }
        private void UpdateGrid()
        {
            planetsGrid.ItemsSource = null;
            planetsGrid.ItemsSource = _planetService.Get();
        }
   
  
        private void NewWindowButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindow win = new AddWindow();
            win.Show();
        }
       
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
           
            if (planetsGrid.SelectedItems.Count > 0 && MessageBox.Show("Confirm removal", "Removal", MessageBoxButton.YesNo)==MessageBoxResult.Yes )
            {
                for (int i = 0; i < planetsGrid.SelectedItems.Count; i++)
                {
                    Planet planet = planetsGrid.SelectedItems[i] as Planet;
                    if (planet != null)
                    {
                        _planetService.Delete(planet);
                    }
                }
            }
            UpdateGrid();  
        }
        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            _planetService.Update(e.Row.Item as Planet);
            UpdateGrid();
        }

        private void planetsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) { }
    }
}
