using System.Text.Json;
using static ReUnited_frontend.Components.LostItemsSummaryList;

namespace ReUnited_frontend.DataModels
{
    public class CategoryItem
    {
        public string Name { get; set; } = "";
        public bool IsSelected { get; set; } = false;
    }

    public static class LostItemCategories
    {
        public static List<CategoryItem>? GetCategories()
        {
            var categoryItemFile = File.ReadAllText("Resources/LostItemCategoryData.json");
            List<CategoryItem>? categories = JsonSerializer.Deserialize<List<CategoryItem>>(categoryItemFile);

            return categories;

            /*return new List<CategoryItem>
            {

            new CategoryItem { Name = "Phone" },
                new CategoryItem { Name = "Bag" },
                new CategoryItem { Name = "Wallet" },
                new CategoryItem { Name = "Keys" },
                new CategoryItem { Name = "Jewellery" }
            };*/
        }
    }
}
