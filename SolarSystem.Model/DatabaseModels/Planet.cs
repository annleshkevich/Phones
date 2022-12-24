namespace SolarSystem.Model.DatabaseModels
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Mass { get; set; }
        public double Diameter { get; set; }
    }
}
