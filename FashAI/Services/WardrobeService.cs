using FashAI.Models;

namespace FashAI.Services
{
    public class WardrobeService
    {
        private List<Wardrobe> wardrobes = new List<Wardrobe>
        {
            new Wardrobe{Id = 1, ItemName = "Summer Dress", Season = "Summer", Gender = "Female", Occasion = "Casual", ClothingType = "Dress", ImagePath = "/images/summer_dress.jpg"},
            new Wardrobe{Id = 2, ItemName = "Winter Coat", Season = "Winter", Gender = "Male", Occasion = "Formal", ClothingType = "Coat", ImagePath = "/images/winter_coat.jpg"},
            new Wardrobe{Id = 3, ItemName = "T-Shirt", Season = "Summer", Gender = "Male", Occasion = "Casual", ClothingType = "T-Shirt", ImagePath = "/images/T-shirt.jpg"},
            new Wardrobe{Id = 4, ItemName = "Converse AllStar", Season = "Summer", Gender = "Female", Occasion = "Casual", ClothingType = "Shoe", ImagePath = "/images/converse_allstar.jpg"}
            //Add More Items Here
        };

        public List<Wardrobe> GetWardrobeByCategory(string season, string gender, string occasion, string clothingType)
        {
            return wardrobes
                .Where(w => w.Season == season && w.Gender == gender && w.Occasion == occasion && w.ClothingType == clothingType)
                .ToList();
        }
    }
}
