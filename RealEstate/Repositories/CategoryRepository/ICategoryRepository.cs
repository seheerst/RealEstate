using RealEstate_Api.Dtos.CategoryDtos;

namespace RealEstate_Api.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllAsync();

        void CreateCategory (CreateCategoryDto categoryDto);

        void DeleteCategory(int categoryID);

        void UpdateCategory(UpdateCategoryDto categoryDto);

        Task<GetByIdCategoryDto> GetByIdCategory(int id);

    }
}
