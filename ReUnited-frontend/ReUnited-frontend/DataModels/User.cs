namespace ReUnited_frontend.DataModels
{
    public class LoginPayload
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
    }

    public static class User
    {
        public static string Token { get; set; } = "";
        public static bool Authenticated { get; set; } = false;
    }


}
