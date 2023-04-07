namespace ShoeStoreApp.Models
{
    public class MockShoeRepository : IShoeRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Shoe> AllShoes =>
            new List<Shoe>
            {
                new Shoe {ShoeId = 1, 
                    Name="Nike Air Force 1", 
                    Price=15.95M, 
                    ShortDescription="Lorem Ipsum lorem lorem lorem*3", 
                    LongDescription="Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/strawberrypie.jpg", 
                    InStock=true, 
                    IsShoeOfTheWeek= false, 
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/strawberrypiesmall.jpg"},
                new Shoe {ShoeId = 2, 
                    Name="Air Jordan 1", 
                    Price=18.99M, 
                    ShortDescription="Lorem Ipsum", 
                    LongDescription="Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear",
                    Category = _categoryRepository.AllCategories.ToList()[1],
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecake.jpg", 
                    InStock=true, 
                    IsShoeOfTheWeek= false, 
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecakesmall.jpg"},
                new Shoe {ShoeId = 3, 
                    Name="Nike Invicible 3", 
                    Price=15.95M, 
                    ShortDescription="Lorem Ipsum", 
                    LongDescription="Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/rhubarbpie.jpg", 
                    InStock=true, 
                    IsShoeOfTheWeek=true, 
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/rhubarbpiesmall.jpg"},
                new Shoe {ShoeId = 4, 
                    Name="Nike React Infinity", 
                    Price=12.95M, 
                    ShortDescription="Lorem Ipsum", 
                    LongDescription="Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear",
                    Category = _categoryRepository.AllCategories.ToList()[2],
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/pumpkinpie.jpg", 
                    InStock=true, 
                    IsShoeOfTheWeek=true, 
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/pumpkinpiesmall.jpg"}
            };

        public IEnumerable<Shoe> ShoeOfTheWeek
        {
            get
            {
                return AllShoes.Where(p => p.IsShoeOfTheWeek);
            }
        }

        public Shoe? GetShoeById(int shoeId) => AllShoes.FirstOrDefault(p => p.ShoeId == shoeId);

        public IEnumerable<Shoe> SearchShoes(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
