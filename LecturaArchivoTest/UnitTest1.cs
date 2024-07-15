using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LecturaArchivoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLecturaArchivo()
        {
            bool resultado = LeerArchivo.Program.LecturaArchivo("C:\\LogInventario", "LogInventario06032024.txt");
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void TestModificarContenido()
        {
            string resultado = LeerArchivo.Program.ModificaContenido("123");
            Assert.AreEqual("123", resultado);
        }
    }
}
