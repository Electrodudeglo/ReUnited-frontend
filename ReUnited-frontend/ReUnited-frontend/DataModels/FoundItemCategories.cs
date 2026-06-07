using System.Text.Json;
using static ReUnited_frontend.Components.FoundItemsSummaryList;

namespace ReUnited_frontend.DataModels
{
    public class CategoryItem
    {
        public string Name { get; set; } = "";
        public bool IsSelected { get; set; } = false;
    }

    public static class FoundItemCategories
    {
        public static List<CategoryItem>? GetCategories()
        {
            var categoryItemFile = File.ReadAllText("Resources/FoundItemCategoryData.json");
            List<CategoryItem>? categories = JsonSerializer.Deserialize<List<CategoryItem>>(categoryItemFile);

            return categories;
        }
    }
}
