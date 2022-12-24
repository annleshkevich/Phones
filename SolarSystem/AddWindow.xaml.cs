using SolarSystem.BusinessLogic.Implementation;
using SolarSystem.Model.DatabaseModels;
using System;
using System.Windows;

namespace SolarSystem
{
    public partial class AddWindow : Window
    {
        private PlanetService _planetService;

        public AddWindow()
        {
            InitializeComponent();
            _planetService = new PlanetService();
        }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(NameTb.Text) || !String.IsNullOrEmpty(MassTb.Text) || !String.IsNullOrEmpty(DiametrTb.Text))
                {
                    _planetService.Create(new Planet { Name = NameTb.Text, Mass = double.Parse(MassTb.Text), Diameter = double.Parse(DiametrTb.Text) });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
