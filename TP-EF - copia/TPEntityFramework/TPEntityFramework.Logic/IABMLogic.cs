using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEntityFramework.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Update(T entity);
        void ShowAll();
    }
}
