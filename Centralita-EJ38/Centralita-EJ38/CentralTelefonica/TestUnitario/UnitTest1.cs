using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using System.Collections.Generic;
using Exceptions;

namespace TestUnitario
{
	[TestClass]
	public class UnitTest1
	{
		
		[TestMethod]
		public void ValidaInstanciaCentralitaListLlamada()
		{
			//Arrange
			Centralita c = new Centralita("ValidaListCentralita");

			//Act

			//Assert
			Assert.IsNotNull(c.Llamadas);
		}


		[TestMethod]
		[ExpectedException(typeof(CentralitaException))]
		public void ValidarCentraltiaLocalException()
		{
			//Arrange
			Centralita c = new Centralita("ValidaListCentralita");
			Local l5 = new Local("Lanús", 45, "San Rafael", 1.99f);
			Local l6 = new Local("Lanús", 45, "San Rafael", 1.99f);

			//Act
			c += l5;
			c += l6;

			//Assert
			Assert.IsNotNull(c.Llamadas);

		}


		[TestMethod]
		[ExpectedException(typeof(CentralitaException))]
		public void ValidarCentraltiaProvincialException()
		{
			//Arrange
			Centralita c = new Centralita("ValidaListCentralita");
			Provincial l7 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
			Provincial l8 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");

			//Act
			c += l7;
			c += l8;

			//Assert
			Assert.IsNotNull(c.Llamadas);
		}

		[TestMethod]
		[ExpectedException(typeof(CentralitaException))]
		public void ValidarCentraltiaLPException()
		{
			//Arrange
			Centralita c = new Centralita("ValidaListCentralita");
			Local l5 = new Local("Lanús", 45, "San Rafael", 1.99f);
			Local l6 = new Local("Lanús", 45, "San Rafael", 1.99f);
			Provincial l7 = new Provincial("Lanús", Provincial.Franja.Franja_1, 21, "San Rafael");
			Provincial l8 = new Provincial("Lanús", Provincial.Franja.Franja_1, 21, "San Rafael");

			//Act
			c += l5;
			c += l6;
			c += l7;
			c += l8;

			//Assert
			Assert.IsTrue(l5 == l6);
			Assert.IsTrue(l5 != l7);
			Assert.IsTrue(l5 != l8);
			Assert.IsTrue(l7 == l8);
			Assert.IsTrue(l7 != l6);
			

		}

	}
}
