using System.Numerics;

namespace TestesMercado
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLogin()
        {
            string cpf= "000.000.000-00 ", senha="2007 ";
            Assert.AreEqual("Supervisor", InteracaoBD.InstanciaPublica().LoginUsuario(cpf, senha));
        }
        [TestMethod]
        public void TesteQuantidade()
        {

        }

    }
}
