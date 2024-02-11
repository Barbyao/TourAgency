using System.Diagnostics;

namespace TourAgency.API.Core
{
    public class Tour
    {
        public static void GetInfo(DateTime start, DateTime end)
        {

        }
        
    
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }

            public Tour()
            {
                // Конструктор без параметров
            }

            public Tour(string name, string description, decimal price)
            {
                // Конструктор с параметрами
                Name = name;
                Description = description;
                Price = price;
            }

            

            public decimal CalculateTotalCost(int numberOfPeople)
            {
                // Реализация логики для расчета общей стоимости тура в зависимости от количества человек
                return Price * numberOfPeople;
            }

            // Другие методы обработки данных
        
    

}
}