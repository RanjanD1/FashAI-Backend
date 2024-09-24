namespace FashAI.Models
{
    public class Wardrobe
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Season { get; set; }//e.g., Summer, Winter, Spring
        public string Gender { get; set; }//e.g., Male, Female
        public string Occasion { get; set; }//e.g., Casual, Formal
        public string ClothingType { get; set; }//e.g., Shirt, Dress, Pant
        public string ImagePath { get; set; }//Path to the clothing image
    }
}
