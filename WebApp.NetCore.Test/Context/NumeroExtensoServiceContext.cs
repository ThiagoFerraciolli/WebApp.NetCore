using Moq;
using Moq.AutoMock;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.NetCore.Domain;

namespace WebApp.NetCore.Test.Context
{
    public class NumeroExtensoServiceContext
    {
        private readonly AutoMocker mocker;

        public Mock<INumeroExtensoService> _numeroExtensoService;

        public NumeroExtensoServiceContext()
        {
            mocker = new AutoMocker();

            _numeroExtensoService = mocker.GetMock<INumeroExtensoService>();
        }

        public NumeroExtensoService Create() => mocker.CreateInstance<NumeroExtensoService>();
    }
}
