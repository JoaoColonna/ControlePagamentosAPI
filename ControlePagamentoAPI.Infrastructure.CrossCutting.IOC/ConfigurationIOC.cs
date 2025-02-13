using Autofac;
using ControlePagamentoAPI.Application.Interfaces;
using ControlePagamentoAPI.Application.Services;
using ControlePagamentoAPI.Domain.Core.Interfaces.Repositories;
using ControlePagamentoAPI.Domain.Core.Interfaces.Services;
using ControlePagamentoAPI.Domain.Service.Services;
using ControlePagamentoAPI.Infrastructure.CrossCutting.Adapter.Interfaces;
using ControlePagamentoAPI.Infrastructure.CrossCutting.Adapter.Map;
using ControlePagamentoAPI.Infrastructure.Data.Repositories;


namespace ControlePagamentoAPI.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServicePagamento>().As<IApplicationServicePagamento>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServicePagamento>().As<IServicePagamento>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryPagamento>().As<IRepositoryPagamento>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperPagamento>().As<IMapperPagamento>();
            #endregion

            #endregion

        }
    }
}
