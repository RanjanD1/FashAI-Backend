namespace FashAI.Models
{
    public class UserProfile
    {
        public string UserId { get; set; }
        public string Gender { get; set; }
        public string PreferredSeason { get; set; }
        public string PreferredOccasion { get; set; }
        public string Preferences { get; set; }//Store user preferences like style, colors, fabrics
        public string History { get; set; }
        public string Complexion { get; set; }
        public string BodyType { get; set; }
    }
}
