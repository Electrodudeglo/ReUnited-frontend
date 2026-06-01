using System.ComponentModel.DataAnnotations;

namespace ReUnited_frontend.DataModels
{
    public class LostItem
    {
        public int Id { get; set; }

        public string City { get; set; } = string.Empty;

        public string Postcode { get; set; } = string.Empty;

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public string Category { get; set; } = string.Empty;

        public string ItemDescription { get; set; } = string.Empty;

        public string AdditionalInformation { get; set; } = string.Empty;

        public string Picture { get; set; } = string.Empty;

    }
}
