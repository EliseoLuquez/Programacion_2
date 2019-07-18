using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using Entidades;
using _20181122_SP;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GuardarXml()
        {
            //Arrange
            Patente p = new Patente("ac186ds", Patente.Tipo.Mercosur);
            Xml<Patente> xml = new Xml<Patente>();
            //Act
            xml.Guardar("gpatentes.xml", p);
            xml.Leer("gpatentes.xml", out p);
            //Assert
            Assert.IsTrue(p ==  p);
        }

        [TestMethod]
        public void GuardarTexto()
        {
            Queue<Patente> cola = new Queue<Patente>();
            Texto texto = new Texto();
            texto.Guardar("gpatentes.txt", cola);
            texto.Leer("patentes.txt", out cola);
            Assert.IsTrue(cola == cola);
        }


        [TestMethod]
        public void GuardarSql()
        {
            Queue<Patente> cola = new Queue<Patente>();
            Sql sql = new Sql();
            sql.Guardar("patentes", cola);
            sql.Leer("patentes", out cola);
            Assert.IsTrue(cola == cola);
        }
    }
}
