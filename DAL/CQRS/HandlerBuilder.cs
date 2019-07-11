using System;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.CQRS
{
    public class HandlerBuilder
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;
        private IServiceProvider _serviceProvider;
        private IUnitOfWork UnitOfWork { get; set; }

        public HandlerBuilder(IUnitOfWorkFactory factory, IServiceProvider serviceProvider)
        {
            _unitOfWorkFactory = factory;
            _serviceProvider = serviceProvider;
            InitializeUnitOfWork();
        }

        public THandler Build<THandler>() where THandler: IHandler
        {
            var handler = _serviceProvider.GetService<THandler>();
            handler.InitializeContext(new HandlerContext(UnitOfWork, this));
            return handler;
        }

        private IUnitOfWork InitializeUnitOfWork()
        {
            if (UnitOfWork == null)
            {
                this.UnitOfWork = _unitOfWorkFactory.CreateUnitOfWork();
            }

            return this.UnitOfWork;
        }
    }
}
