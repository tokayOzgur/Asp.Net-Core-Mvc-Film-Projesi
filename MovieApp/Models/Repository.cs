using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Models
{
    public static class Repository
    {
        private static List<Movie> _movies = null;

        static Repository()
        {
            _movies = new List<Movie>()
            {
                new Movie(){Id=1,Name="Yüzüklerin Efendisi",Description="Yüzüklerin efendisi bir seridir",ImageUrl="https://tr.web.img4.acsta.net/pictures/bzp/01/27070.jpg"},
                new Movie(){Id=2,Name="Forest Gump",Description="Tom hanks başrolde",ImageUrl="https://tr.web.img4.acsta.net/pictures/bzp/01/10568.jpg"},
                new Movie(){Id=3,Name="Harry Potter",Description="Gelmiş geçmiş zamanın en iyi büyücü filmi",ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRq35bX8oxRLYk9x5YcTSFXbf7umbtoG_h-pOKNIeV_gNVh73NWkArGWqWDpGS0iQh7c7M&usqp=CAU"},
                new Movie(){Id=4,Name="Edge of Tomorrow",Description="Muhteşem iki oyuncunun başrolü paylaştığı heyecan dolu bir aksiyon filmi.",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTc5OTk4MTM3M15BMl5BanBnXkFtZTgwODcxNjg3MDE@._V1_.jpg"}
            };
        }

        public static List<Movie> Movies { get { return _movies; } }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity); //Dışarıdan gelen entity'i movies'in üzerine alıyoruz.
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id); //Gelen id ile datamızdaki id değerleri aynı ise geri döndür
        }
    }
}