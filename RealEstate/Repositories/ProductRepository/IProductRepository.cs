using RealEstate_Api.Dtos.ProductDtos;

namespace RealEstate_Api.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllAsync();

        Task<List<ResultProductWithCategoryDto>> GetAllWithCategoryAsync();
    }
}
