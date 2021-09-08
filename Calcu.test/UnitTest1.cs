using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calcu.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            // de la aplicacion "calcu" escojo la clase creada del objeto "Test" e inicio el calcular donde instacio uno nuevo.
            Calcu.Calc Calcular = new Calcu.Calc();

            //creacion del resultado que se espera
            int expectedResult = 7;
            // creacion de los parametros para que se lleve la ejecucion del metodo Suma
            int result = Calc.Suma(3, 4);

            //utilizacion del AssertEqual para comparar ambos resultados.
            Assert.AreEqual(expectedResult, result);
        }
        
        public void TestSumaFail()
        {
            // de la aplicacion "calcu" escojo la clase creada del objeto "Test" e inicio el calcular donde instacio uno nuevo.
            Calcu.Calc Calcular = new Calcu.Calc();

            //creacion del resultado que se espera
            int expectedResult = 6;
            // creacion de los parametros para que se lleve la ejecucion del metodo Suma
            int result = Calc.Suma(2, 4);

            //utilizacion del AssertEqual para comparar ambos resultados.
            Assert.AreNotEqual(expectedResult, result);

        }


        //NO IMPLEMENTO LOS DEMAS POR QUE NO SE SI ESTA BIEN AL 100%
        //asi que lo dejo comentado para saber cual de las opciones es la correcta o si tengo que cambiar ambas.

        /*
        [TestMethod]
        public void TestSumaFail()
        {
            var s = Suma.Sum(-1, 2);
            Assert.AreEqual( 5, s);
        }
        [TestMethod]
        public void TestResta()
        {
            var r = Resto.Rest(-8, 2);
            Assert.AreEqual(-10, r);
        }
        [TestMethod]
        public void TestRestaFail()
        {
            var r = Suma.Sum(-7, -5);
            Assert.AreEqual(-1, r);
        }
        [TestMethod]
        public void TestMulti()
        {
            var m = Multiplicacion.Mult(3, 3);
            Assert.AreEqual(9, m);
        }
        public void TestMultiFail()
        {
            var m = Multiplicacion.Mult(3, 3);
            Assert.AreEqual(5, m);
        }
<<<<<<< Updated upstream
=======
        [TestMethod]
        public void TestDiv()
        {
            var d = Division.Div(9, 3);
            Assert.AreEqual(3, d);
        }
        public void TestDivFail()
        {
            var d = Division.Div(9, 3);
            Assert.AreEqual(3, d);
        }
>>>>>>> Stashed changes

    }
        */
    }
}
