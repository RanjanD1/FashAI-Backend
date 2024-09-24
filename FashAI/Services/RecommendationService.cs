using FashAI.Models;

namespace FashAI.Services
{
    public class RecommendationService
    {
        private readonly List<Wardrobe> _wardrobeItems;

        public RecommendationService()
        {
            //Example data for wardrobe items in the system
            _wardrobeItems = new List<Wardrobe>
            {
                new Wardrobe { Id = 1, ItemName = "Casual Summer Shirt", Season = "Summer", Gender = "Male", Occasion = "Casual", ClothingType = "Shirt", ImagePath = "/images/summer_shirt.jpg" },
                new Wardrobe { Id = 2, ItemName = "Formal Winter Coat", Season = "Winter", Gender = "Male", Occasion = "Formal", ClothingType = "Coat", ImagePath = "/images/winter_coat.jpg" },
                new Wardrobe { Id = 3, ItemName = "Evening Gown", Season = "Fall", Gender = "Female", Occasion = "Formal", ClothingType = "Dress", ImagePath = "/images/evening_gown.jpg" },
                new Wardrobe { Id = 4, ItemName = "Summer Dress", Season = "Summer", Gender = "Female", Occasion = "Casual", ClothingType = "Dress", ImagePath = "/images/summer_dress.jpg" }
            };
        }
        
        public List<Wardrobe> RecommendForUser(UserProfile userProfile)
        {
            //placeholder logic for recommendations based on preferences
            List<Wardrobe> recommendedItems = _wardrobeItems
                .Where(item => item.Season == userProfile.PreferredSeason &&
                               item.Gender == userProfile.Gender &&
                               item.Occasion == userProfile.PreferredOccasion)
                .ToList();

            //If no specific recommendation matches, add a default recommendation
            if(!recommendedItems.Any())
            {
                recommendedItems.Add(new Wardrobe
                {
                    Id = 5,
                    ItemName = "Generic Shirt",
                    Season = "All Seasons",
                    Gender = userProfile.Gender,
                    Occasion = "Casual",
                    ClothingType = "Shirt",
                    ImagePath = "/images/generic_shirt.jpg"
                });
            }
            return recommendedItems;
        }
    }
}
