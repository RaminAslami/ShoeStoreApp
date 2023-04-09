namespace ShoeStoreApp.Models;

public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            ShoeStoreDbContext context = applicationBuilder.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<ShoeStoreDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Shoe.Any())
            {
                context.AddRange
                (
                    new Shoe { Name = "Nike Air Force 1 ", Price = 22.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Lifestyle"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/caramelpopcorncheesecake.jpg", InStock = true, IsShoeOfTheWeek = true, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/caramelpopcorncheesecakesmall.jpg"},
                    new Shoe { Name = "Nike Air VaporMax 2021 FK", Price = 19.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Jordan"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/chocolatecheesecake.jpg", InStock = true, IsShoeOfTheWeek = true, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/chocolatecheesecakesmall.jpg"},
                    new Shoe { Name = "Nike Air Max LTD 3", Price = 21.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Running"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/pistachecheesecake.jpg", InStock = true, IsShoeOfTheWeek = true, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/pistachecheesecakesmall.jpg"},
                    new Shoe { Name = "Nike Air Huarache", Price = 21.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Training"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/pecanpie.jpg", InStock = true, IsShoeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/pecanpiesmall.jpg"},
                    new Shoe { Name = "Nike Air Presto", Price = 29.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Running"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/birthdaypie.jpg", InStock = true, IsShoeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/birthdaypiesmall.jpg"},
                    new Shoe { Name = "Nike Waffle One", Price = 12.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Jordan"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", InStock = true, IsShoeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg"},
                    new Shoe { Name = "Nike Wmns Air Max 90", Price = 18.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Running"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/blueberrycheesecake.jpg", InStock = true, IsShoeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/blueberrycheesecakesmall.jpg"},
                    new Shoe { Name = "Nike Air Huarache", Price = 18.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Running"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecake.jpg", InStock = true, IsShoeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecakesmall.jpg"},
                    new Shoe { Name = "Nike Air Max 97", Price = 15.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Jordan"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", InStock = true, IsShoeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg"},
                    new Shoe { Name = "Nike Air Max 270 GS", Price = 13.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Lifestyle"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", InStock = true, IsShoeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg" },
                    new Shoe { Name = "Nike Air Max SC", Price = 17.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Training"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", InStock = true, IsShoeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg"},
                    new Shoe { Name = "Nike React Vision", Price = 15.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Jordan"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", InStock = false, IsShoeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg" },
                    new Shoe { Name = "Air Jordan 1 Mid", Price = 12.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Lifestyle"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", InStock = true, IsShoeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg" },
                    new Shoe { Name = "Nike Air Jordan 1 Mid", Price = 15.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Jordan"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", InStock = true, IsShoeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg"},
                    new Shoe { Name = "Nike Air Jordan 11 CMFT", Price = 15.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Jordan"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InStock = true, IsShoeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"},
                    new Shoe { Name = "Nike Air Jordan 1 Low", Price = 18.95M, ShortDescription = "Classics never fade away, just like the Nike Air Force 1 Low Retro is forever fresh. Packed with OG details, these sneakers put the legacy of sports and fashion under your feet.", LongDescription = "Stylish and trendy shoes with a unique design featuring intricate details and a bold color palette. The shoe's strappy silhouette exudes confidence and sophistication, reminiscent of a sleek and modern aesthetic. The attention to detail is evident in the carefully crafted elements, akin to the precision of dragées or delicate icing. The pumps boast a chic combination of materials, with a mix of leather and fabric that adds depth and texture, similar to a Danish pastry. The high-quality craftsmanship and exquisite finish evoke a sense of luxury, much like a fine piece of jewelry. The shoes exude a sense of playfulness with pops of candy-colored accents, adding a touch of whimsy. These shoes are a true fashion statement, perfect for those who appreciate unique and fashion-forward footwear", Category = Categories["Running"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", InStock = false, IsShoeOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg"}
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category>? categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Lifestyle" },
                        new Category { CategoryName = "Jordan" },
                        new Category { CategoryName = "Running" },
                        new Category { CategoryName = "Training" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
