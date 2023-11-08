namespace RealEstate_Api.Repositories.StatisticsRepositories
{
    public interface IStatisticsRepository
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
        int ProductCount();
        int ApartmentCount();
        string EmployeeNameByMaxProductCount();
        string CategoryNameByMaxProductCount();
        decimal AvgProductByRent();
        decimal AvgProductBySale();
        string CityNameByMaxProduct();
        int DifferentCityCount();
        decimal LastProductPRice();
        string NewestBuildingYear();
        string OldestBuildingYear();
        int AvgRoomCount();
        int ActiveEmployeeCount();

    }
}
