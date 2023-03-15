using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MertekEgysegValto;

namespace ValtoUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Kemia()
        {
            // próba számok, értékek
            String errol = "K";
            String erre = "Cel";
            double szam = 100;

            // Teszt..
            double varhato = szam - 273.15;
            double akt = MertekEgysegValto.KemiaControl.atvaltas(errol, erre, szam);
            Assert.AreEqual(varhato, akt);
            
        }
        [TestMethod]
        public void Test_FizikaRossz()
        {
            // Próba számok értékek (rossz értékek)
            String errol = "KPH";
            String erre = "KG";
            double szam = 150;

            double varhato = 0;
            double akt = MertekEgysegValto.FizikaControl.atvaltas(errol, erre, szam);
            Assert.AreEqual(varhato, akt);
        }
        [TestMethod]
        public void Test_Fizika()
        {
            // Próba számok, értékek
            String errol = "KPH";
            String erre = "MPH";
            double szam = 134;
            double varhato = 134 / 1.61;

            double akt = MertekEgysegValto.FizikaControl.atvaltas(errol, erre, szam);
            Assert.AreEqual(varhato, akt);

            errol = "LB";
            erre = "KG";
            varhato = szam * (1/2.20);
            akt = MertekEgysegValto.FizikaControl.atvaltas(errol, erre, szam);
            Assert.AreEqual(varhato, akt);
        }
    }
}
