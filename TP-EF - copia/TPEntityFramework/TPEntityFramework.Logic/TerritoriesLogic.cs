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

        public void ShowAll()
        {
            Console.WriteLine("  ID  -  DESCRIPCION");
            Console.WriteLine("-----------------------");
            foreach (Territories territories in this.GetAll())
            {
                this.ShowOne(territories.TerritoryID);
                Console.WriteLine("----------------------");
            }
        }

        public void ShowOne(string id)
        {
            var territorie = context.Territories.Find(id);
            Console.WriteLine($"{territorie.TerritoryID} - {territorie.TerritoryDescription}");    
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
