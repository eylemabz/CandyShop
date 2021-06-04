using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.", "\\Images\\thumbnails\\chocolateCandy-small.jpg", "\\Images\\chocolateCandy.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale" },
                values: new object[] { "Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Quisque egestas diam in arcu cursus. Sed viverra tellus in hac. Quis commodo odio aenean sed adipiscing diam donec adipiscing.", "\\Images\\thumbnails\\chocolateCandy2-small.jpg", "\\Images\\chocolateCandy2.jpg", true });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Sed faucibus turpis in eu mi bibendum neque egestas. At in tellus integer feugiat scelerisque. Elementum integer enim neque volutpat ac tincidunt.", "\\Images\\thumbnails\\chocolateCandy3-small.jpg", "\\Images\\chocolateCandy3.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Vitae congue eu consequat ac felis donec et. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit. Vel eros donec ac odio. A lacus vestibulum sed arcu non odio euismod lacinia at. Nisl suscipit adipiscing bibendum est ultricies integer. Nec tincidunt praesent semper feugiat nibh.", "\\Images\\thumbnails\\fruitCandy-small.jpg", "\\Images\\fruitCandy.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale" },
                values: new object[] { "Purus sit amet luctus venenatis lectus magna fringilla. Consectetur lorem donec massa sapien faucibus et molestie ac. Sagittis nisl rhoncus mattis rhoncus urna neque viverra.", "\\Images\\thumbnails\\fruitCandy2-small.jpg", "\\Images\\fruitCandy2.jpg", true });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale", "Name" },
                values: new object[] { "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ", "\\Images\\thumbnails\\fruitCandy3-small.jpg", "\\Images\\fruitCandy3.jpg", true, "Another Assorted Fruit Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[] { "Diam sit amet nisl suscipit adipiscing bibendum est ultricies integer. Molestie at elementum eu facilisis sed odio morbi quis commodo. Odio facilisis mauris sit amet massa vitae tortor condimentum lacinia. Urna porttitor rhoncus dolor purus non enim praesent elementum facilisis.", "\\Images\\thumbnails\\gummyCandy-small.jpg", "\\Images\\gummyCandy.jpg", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale", "Name" },
                values: new object[] { "Posuere ac ut consequat semper viverra nam libero justo laoreet. Ultrices dui sapien eget mi proin sed libero enim. Etiam non quam lacus suspendisse faucibus interdum. Amet nisl suscipit adipiscing bibendum est ultricies integer quis.", "\\Images\\thumbnails\\gummyCandy2-small.jpg", "\\Images\\gummyCandy2.jpg", false, "Another Assorted Gummy Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\gummyCandy3-small.jpg", "\\images\\gummyCandy3.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\halloweenCandy-small.jpg", "\\images\\halloweenCandy.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\halloweenCandy2-small.jpg", "\\images\\halloweenCandy2.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\halloweenCandy3-small.jpg", "\\images\\halloweenCandy3.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\hardCandy-small.jpg", "\\images\\hardCandy.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\hardCandy2-small.jpg", "\\images\\hardCandy2.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15,
                column: "ImageUrl",
                value: "\\images\\hardCandy3.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "~\\images\\thumbnails\\chocolateCandy-small.jpg", "~\\images\\chocolateCandy.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "~\\images\\thumbnails\\chocolateCandy2-small.jpg", "~\\images\\chocolateCandy2.jpg", false });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "~\\images\\thumbnails\\chocolateCandy3-small.jpg", "~\\images\\chocolateCandy3.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "~\\images\\thumbnails\\FruitCandy-small.jpg", "~\\images\\FruitCandy.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "~\\images\\thumbnails\\fruitCandy2-small.jpg", "~\\images\\fruitCandy2.jpg", false });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale", "Name" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "~\\images\\thumbnails\\fruitCandy3-small.jpg", "~\\images\\fruitCandy3.jpg", false, "Fruit Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "Price" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "~\\images\\thumbnails\\gummyCandy-small.jpg", "~\\images\\gummyCandy.jpg", 6.00m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale", "Name" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "~\\images\\thumbnails\\gummyCandy2-small.jpg", "~\\images\\gummyCandy2.jpg", true, "Another Gummy Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\gummyCandy3-small.jpg", "\\Images\\gummyCandy3.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\halloweenCandy-small.jpg", "\\Images\\halloweenCandy.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\halloweenCandy2-small.jpg", "\\Images\\halloweenCandy2.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\halloweenCandy3-small.jpg", "\\Images\\halloweenCandy3.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\hardCandy-small.jpg", "\\Images\\hardCandy.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\hardCandy2-small.jpg", "\\Images\\hardCandy2.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15,
                column: "ImageUrl",
                value: "\\Images\\hardCandy3.jpg");
        }
    }
}
