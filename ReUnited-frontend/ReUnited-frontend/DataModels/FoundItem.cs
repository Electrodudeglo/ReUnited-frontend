using System.ComponentModel.DataAnnotations;

namespace ReUnited_frontend.DataModels
{
    public class FoundItem
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

        public FoundItem(
            int id,
            string city,
            string postcode,
            string email,
            string phoneNumber,
            string category,
            string itemDescription,
            string additionalInformation,
            string picture)
        {
            Id = id;
            City = city;
            Postcode = postcode;
            Email = email;
            PhoneNumber = phoneNumber;
            Category = category;
            ItemDescription = itemDescription;
            AdditionalInformation = additionalInformation;
            Picture = picture;
        }

        public FoundItem() { }
    }
}
