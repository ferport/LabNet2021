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
            try
            {
                return context.Territories.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void Add(string id, string description, int region) 
        {
            try
            {
                Territories newTerritorie = new Territories
                {
                    TerritoryID = id,
                    TerritoryDescription = description,
                    RegionID = region
                };
                context.Territories.Add(newTerritorie);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void Delete(string id)
        {
            try
            {
                var deleteTerritorie = context.Territories.Find(id);
                context.Territories.Remove(deleteTerritorie);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Territories territorie)
        {
            try
            {
                var updateTerritorie = context.Territories.Find(territorie.TerritoryID);
                updateTerritorie.TerritoryDescription = territorie.TerritoryDescription;
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        
        public Territories GetOne(string id)
        {
            try
            {
                var territorie = context.Territories.Find(id);
                return territorie;
            }
            catch(Exception ex)
            {
                throw ex;
            }
               
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
