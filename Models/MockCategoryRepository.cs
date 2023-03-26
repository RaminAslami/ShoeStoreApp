namespace ShoeStoreApp.Models;

public class MockCategoryRepository: ICategoryRepository
{

    public IEnumerable<Category> AllCategories => new List<Category>
    {
        new Category
        {
            CategoryId = 1, CategoryName = "Lifestyle",
            Description =
                "The short answer is that lifestyle shoes are meant for casual wear—in the sense that they're not built for strenuous activity. "
        },
        new Category
        {
            CategoryId = 2, CategoryName = "Jordan",
            Description =
                "Air Jordan is a line of basketball shoes and athletic apparel produced by American corporation Nike, Inc. The first Air Jordan shoe was produced for Hall of Fame former basketball player Michael Jordan during his time with the Chicago Bulls in late 1984 and released to the public on April 1, 1985."
        },
        new Category
        {
            CategoryId = 3,
            CategoryName = "Running",
            Description = "Perfect shoes for the people sprinting on their day to day lives"
        }
    };
}