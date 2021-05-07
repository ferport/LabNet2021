using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEntityFramework.Entities;

namespace TPEntityFramework.Logic
{
    public class TerritoriesLogic : BaseLogic , IABMLogic<Territories>
    {
        public List<Territories> GetAll() 
        {
            return context.Territories.ToList();
        }

        public void Add(string id, string description) 
        {
            Territories newTerritorie = new Territories
            {
                TerritoryID = id,
                TerritoryDescription = description,
                RegionID = 1
            };
            context.Territories.Add(newTerritorie);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var deleteTerritorie = context.Territories.Find(id);
            context.Territories.Remove(deleteTerritorie);
            context.SaveChanges();       
        }

        public void Update(Territories territorie)
        {
            var updateTerritorie = context.Territories.Find(territorie.TerritoryID);
            updateTerritorie.TerritoryDescription = territorie.TerritoryDescription;
            context.SaveChanges();    
        }

        
        public Territories GetOne(string id)
        {
            var territorie = context.Territories.Find(id);
            return territorie;   
        }

        public int FindId(string id)
        {
            if (context.Territories.Find(id) == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
