namespace MovieTrailer.Models
{
    public class AppLoginModel
    {
        //public string Email { get; set; }
        public string userNameOrEmailAddress { get; set; }
        public  bool rememberClient { get; set; }
        public string Password { get; set; }
    }

    public class PasswordResetModel
    {
        public string Email { get; set; }
    }

    public class Group
    {
        public string name { get; set; }
        public string image { get; set; }
    }

    public class Painting
    {
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string imageBackground { get; set; }
        public double rating { get; set; }
        public double price { get; set; }
        public string color { get; set; }
        public string style { get; set; }
        public string madeIn { get; set; }
    }

    public class TopArtists
    {
        public string name { get; set; }
        public string image { get; set; }
    }

    public class ForYou
    {
        public string image { get; set; }
    }

    public class Star
    {
        public string image { get; set; }
    }
}
