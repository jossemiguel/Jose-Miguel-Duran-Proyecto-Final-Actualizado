using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
namespace BLL.Tests
{
    [TestClass()]
    public class ComprasBLLTests
    {
        [TestMethod()]
        public void insertarTest()
        {
            Compras c = new Compras();
            Assert.IsTrue(ComprasBLL.insertar (c));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.Fail();
        }
    }
}