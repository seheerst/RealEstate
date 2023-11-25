using Dapper;
using RealEstate_Api.Dtos.CategoryDtos;
using RealEstate_Api.Dtos.ProductDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultProductDto>> GetAllAsync()
        {
            string query = "Select * From Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllWithCategoryAsync()
        {
            string query = "Select ProductID,Title,Price,CoverImage,City,District, Address ,CategoryName,Description,Type,DealOfTheDay From Product inner join Category on Product.ProductCategory=Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async void ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            string query = "Update Product Set DealOfTheDay =0  where ProductID = @productID";
            var parameters = new DynamicParameters();

            parameters.Add("@productID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            string query = "Update Product Set DealOfTheDay =1  where ProductID = @productID";
            var parameters = new DynamicParameters();

            parameters.Add("@productID", id);
         
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

    }
}
