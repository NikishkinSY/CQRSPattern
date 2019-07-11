using System;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.CQRS
{
    public class HandlerBuilder
    {
        private UnitOfWorkFactory _unitOfWorkFactory;
        private IServiceProvider _serviceProvider;
        private IUnitOfWork UnitOfWork { get; set; }

        public HandlerBuilder(UnitOfWorkFactory factory, IServiceProvider serviceProvider)
        {
            _unitOfWorkFactory = factory;
            _serviceProvider = serviceProvider;
            Initialize();
        }

        public THandler Build<THandler>() where THandler: IHandler
        {
            var handler = _serviceProvider.GetService<THandler>();
            handler.InitializeContext(UnitOfWork.Context, this);
            return handler;
        }

        private void Initialize()
        {
            if (UnitOfWork == null)
            {
                RunInNewContext();
            }
            else
            {
                RunInParentContext();
            }
        }

        public void RunInNewContext()
        {
            this.UnitOfWork = _unitOfWorkFactory.CreateUnitOfWork();
        }

        public void RunInParentContext()
        {

        }
    }
}
