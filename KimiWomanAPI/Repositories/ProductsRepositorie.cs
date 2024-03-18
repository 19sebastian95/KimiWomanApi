using DataBase;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace KimiWomanAPI.Repositories
{
    public class ProductsRepositorie : IProducts
    {
        private KimiWomanContext _context;
        private List<Variaciones>? _listVariations = new List<Variaciones>();
        private Variaciones _variations;
        private List<Products> _listProducts = new List<Products>();
        private Products _products;
        public ProductsRepositorie(KimiWomanContext context)
        {
            _context = context;
        }

        public IEnumerable<Products> GetAllProducts()
        {
            try
            {
                var allProducts = _context.Productos.FromSqlRaw("TodosLosProductos").ToList();
                var variationsallProducts = _context.Variaciones.FromSqlRaw($"VariacionesTodosLosProductos").ToList();

                foreach (var product in allProducts)
                {
                    foreach (var variation in variationsallProducts)
                    {
                        if (variation.IdProducto == product.IdProducto)
                        {
                            var imagesByVariation = _context.Imagenes.FromSqlRaw($"ImagenesPorVariacion {variation.IdVariacion}").ToList();

                            _variations = new Variaciones
                            {
                                IdProducto = variation.IdProducto,
                                Cantidad = variation.Cantidad,
                                ValorAnterior = variation.ValorAnterior,
                                ValorActual = variation.ValorActual,
                                Caracteristica = variation.Caracteristica,
                                Imagenes = imagesByVariation,
                                Oferta = variation.Oferta
                            };

                            _listVariations.Add(_variations);
                        }
                    }

                    var listVariations = _listVariations.ToList();
                    _listVariations.Clear();

                    _products = new Products
                    {
                        IdProducto = product.IdProducto,
                        NombreProducto = product.NombreProducto,
                        Descripcion = product.Descripcion,
                        Marca = product.Marca,
                        Variaciones = listVariations
                    };

                    _listProducts.Add(_products);
                }

                return _listProducts.OrderBy(x => x.NombreProducto);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<Products> GetProductsByCategory(int idCategory)
        {
            try
            {
                var productsByCategories = _context.Productos.FromSqlRaw($"ProductosPorCategoria {idCategory}").ToList();
                var variationsBySubCategories = _context.Variaciones.FromSqlRaw($"VariacionesPorCategoria {idCategory}").ToList();                

                foreach (var product in productsByCategories)
                {
                    foreach (var variation in variationsBySubCategories)
                    {
                        if (variation.IdProducto == product.IdProducto)
                        {
                            var imagesByVariation = _context.Imagenes.FromSqlRaw($"ImagenesPorVariacion {variation.IdVariacion}").ToList();

                            _variations = new Variaciones
                            {
                                IdProducto = variation.IdProducto,
                                Cantidad = variation.Cantidad,
                                ValorAnterior = variation.ValorAnterior,
                                ValorActual = variation.ValorActual,
                                Caracteristica = variation.Caracteristica,
                                Imagenes = imagesByVariation,
                                Oferta = variation.Oferta
                            };

                            _listVariations.Add(_variations);
                        }
                    }

                    var listVariations = _listVariations.ToList();
                    _listVariations.Clear();

                    _products = new Products
                    {
                        IdProducto = product.IdProducto,
                        NombreProducto = product.NombreProducto,
                        Descripcion = product.Descripcion,
                        Marca = product.Marca,
                        Variaciones = listVariations
                    };

                    _listProducts.Add(_products);
                }

                return _listProducts.OrderBy(x => x.NombreProducto);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<Products> GetProductsBySubCategory(int idSubCategory)
        {
            try
            {
                var productsBySubCategories = _context.Productos.FromSqlRaw($"ProductosPorSubCategoria {idSubCategory}").ToList();
                var variationsBySubCategories = _context.Variaciones.FromSqlRaw($"VariacionesPorSubCategoria {idSubCategory}").ToList();

                foreach (var product in productsBySubCategories) 
                {                    
                    foreach (var variation in variationsBySubCategories)
                    {
                        if (variation.IdProducto == product.IdProducto)
                        {
                            var imagesByVariation = _context.Imagenes.FromSqlRaw($"ImagenesPorVariacion {variation.IdVariacion}").ToList();

                            _variations = new Variaciones
                            {
                                IdProducto = variation.IdProducto,
                                Cantidad = variation.Cantidad,
                                ValorAnterior = variation.ValorAnterior,
                                ValorActual = variation.ValorActual,
                                Caracteristica = variation.Caracteristica,
                                Imagenes = imagesByVariation,
                                Oferta = variation.Oferta
                            };

                            _listVariations.Add(_variations);
                        }
                    }

                    var listVariations = _listVariations.ToList();
                    _listVariations.Clear();

                    _products = new Products
                    {
                        IdProducto = product.IdProducto,
                        NombreProducto = product.NombreProducto,  
                        Descripcion = product.Descripcion,
                        Marca = product.Marca,
                        Variaciones = listVariations
                    };

                    _listProducts.Add(_products);
                }               
                    
                return _listProducts.OrderBy(x => x.NombreProducto);
            }
            catch (Exception)
            {

                throw;
            }            
        }
    }
}
