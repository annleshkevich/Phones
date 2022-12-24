using SolarSystem.Model;
using SolarSystem.Model.DatabaseModels;


namespace SolarSystem.BusinessLogic.Implementation
{
    public class PlanetService
    {
        SolarSystemContext _db;

        public PlanetService()
        {
            _db = new SolarSystemContext();
        }
  
        public void Create(Planet model)
        {
            _db.Planets.Add(model);
            _db.SaveChanges();
        }
        public IEnumerable<Planet> Get()
        {
            return _db.Planets.ToList();        
        }
        public void Delete(Planet model)
        {
            _db.Planets.Remove(model);
            _db.SaveChanges();
        }
        public void Update(Planet model)
        {
            _db.Planets.Update(model);
            _db.SaveChanges();
        }
    }
}
