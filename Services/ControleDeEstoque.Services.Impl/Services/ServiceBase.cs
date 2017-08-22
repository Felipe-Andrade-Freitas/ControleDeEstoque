using ControleDeEstoque.Services.Spec.Services;
using SQFramework.Core.Reflection;

namespace ControleDeEstoque.Services.Impl.Services
{
    public class ServiceBase : IServiceBase
    {
        public string GetServiceVersion()
        {
            return AssemblyHelper.GetAssemblyVersion(GetType());
        }
    }
}