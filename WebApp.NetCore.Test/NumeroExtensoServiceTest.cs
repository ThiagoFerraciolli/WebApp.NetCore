using System;
using System.Collections.Generic;
using System.Text;
using WebApp.NetCore.Domain;
using WebApp.NetCore.Test.Context;
using Xunit;

namespace WebApp.NetCore.Test
{
    public class NumeroExtensoServiceTest
    {
        private readonly NumeroExtensoServiceContext _numeroExtensoServiceContext;

        public NumeroExtensoServiceTest()
        {
            _numeroExtensoServiceContext = new NumeroExtensoServiceContext();
        }

        [Fact]
        public void DeveRetornarNumeroPorExtenso()
        {
            _numeroExtensoServiceContext._numeroExtensoService
                .Setup(x => x.Validar(1))
                .Returns(new NumeroExtenso() { Extenso = "um" });

            var target = _numeroExtensoServiceContext.Create();

            target.Validar(1);

            target.Equals(new NumeroExtenso() { Extenso = "um" });
        }
    }
}
