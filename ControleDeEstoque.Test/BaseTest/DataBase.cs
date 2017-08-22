using ControleDeEstoque.Services.Spec.DataTransferObjects;

namespace ControleDeEstoque.Test.BaseTest
{
    public class DataBase
    {
        public DTOCategoria PreencheCategoria()
        {
            DTOCategoria categoria = new DTOCategoria();
            categoria.Codigo = "CAT13092";
            categoria.Nome = "Cozinha";
            return categoria;
        }
    }
}
