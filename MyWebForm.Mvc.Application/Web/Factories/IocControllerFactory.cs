using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyWebForms.Core.Web.Factories
{

    public class IocControllerFactory : DefaultControllerFactory, IIocControllerFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public IocControllerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return (IController)_serviceProvider.GetService(controllerType);
        }

        public void SetCurrentControllerFactory()
        {
            ControllerBuilder.Current.SetControllerFactory(this);
        }
    }

}
