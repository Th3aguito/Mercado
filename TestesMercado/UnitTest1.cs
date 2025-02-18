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
            string codigo = "1031";
            int Quantidade = 1;
            string Prod = "";
            string Desc = "";
            double Valor = 0;

            Assert.IsTrue(InteracaoBD.InstanciaPublica().inserirProd("1031", 1, out Prod, out Desc, out Valor));

        }

    }
}
