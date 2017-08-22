using SCA.Servicos.Spec.Servicos;
using SCA.WebControls;

namespace ControleDeEstoque.Presentation.Controllers.Base
{
    public abstract class CustomController : SCAController
    {
        public override ISCAService GetSCAService()
        {
            return serviceLocator.GetService<ISCAService>("antt.servicos/SCAService", SCAApplicationContext.ObterParametrosServico(), "antt");
        }
    }
}