using System.ServiceModel;

namespace ControleDeEstoque.Services.Spec.Services
{
    [ServiceContract]
    public interface IServiceBase
    {
        [OperationContract]
        string GetServiceVersion();
    }
}