using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourAgency.DataContext.Models
{
    /// <summary>
    /// Базовая модель для всех классов которые используются в базе данных
    /// </summary>
    public abstract class BasicModel
    {
        public int Id { get; set; }
        public DateTime Creation { set; get; }
        
    }
}
