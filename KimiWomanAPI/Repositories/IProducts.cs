using DataBase;

namespace KimiWomanAPI.Repositories
{
    public interface IProducts
    {
        IEnumerable<Products> GetAllProducts();
        IEnumerable<Products> GetProductsByCategory(int idCategory);
        IEnumerable<Products> GetProductsBySubCategory(int idSubCategory);
    }
}
