using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category(){CategoryId=1,CategoryName="Macera - Aksiyon"},
                new Category(){CategoryId=2,CategoryName="Bilim Kurgu"},
                new Category(){CategoryId=3,CategoryName="Komedi"},
                new Category(){CategoryId=4,CategoryName="Gençlik"},
                new Category(){CategoryId=5,CategoryName="Dram"}
            };
        }

        public static List<Category> Categories { get { return _categories; } }

        public static void AddCategory(Category entity)
        {
            _categories.Add(entity); //Dışarıdan gelen entity'i movies'in üzerine alıyoruz.
        }

        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.CategoryId == id); //Gelen id ile datamızdaki id değerleri aynı ise geri döndür
        }
    }
}