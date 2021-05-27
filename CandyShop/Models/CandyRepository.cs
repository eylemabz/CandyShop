using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Candy> GetAllCandy => new List<Candy>
        {
            new Candy{CandyId=1,Name="Assorted Hard Candy",Price=4.95M,Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",Category=_categoryRepository.GetAllCategories.ToList()[0],ImageUrl="https://en.wikipedia.org/wiki/Hard_candy#/media/File:HardCandy.jpg",IsInStock=true,IsOnSale=false,ImageThumbnailUrl="https://en.wikipedia.org/wiki/Hard_candy#/media/File:HardCandy.jpg"}
            new Candy{CandyId=2,Name="Chocolate Candy",Price=5.95M,Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",Category=_categoryRepository.GetAllCategories.ToList()[1],ImageUrl="https://en.wikipedia.org/wiki/Candy#/media/File:Bar_of_Guittard_chocolate.jpg",IsInStock=true,IsOnSale=false,ImageThumbnailUrl="https://en.wikipedia.org/wiki/Candy#/media/File:Bar_of_Guittard_chocolate.jpgg"}
            new Candy{CandyId=3,Name="Fruit Candy",Price=3.95M,Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",Category=_categoryRepository.GetAllCategories.ToList()[2],ImageUrl="https://en.wikipedia.org/wiki/Candied_fruit#/media/File:Candied_Fruit_-_La_Boquer%C3%ADa.jpgg",IsInStock=true,IsOnSale=false,ImageThumbnailUrl="https://en.wikipedia.org/wiki/Candied_fruit#/media/File:Candied_Fruit_-_La_Boquer%C3%ADa.jpg"}

        };

        public IEnumerable<Candy> GetCandyOnSale => throw new NotImplementedException();

        public Candy GetCandyById(int candyId)
        {
            return GetAllCandy.FirstOrDefault(c => c.CandyId == candyId);
        }
    }
}
