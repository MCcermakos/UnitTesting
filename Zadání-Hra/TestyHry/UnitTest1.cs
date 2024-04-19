using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.Eventing.Reader;
using Zadání_Hra;

namespace TestyHry
{
    [TestClass]
    public class UnitTest1
    {
        public Herní_Postava steve = new Herní_Postava("Radek");
        [TestMethod]
        public void TestDelkyJmena_POSITIVE()
        {
            Assert.IsTrue(steve.Jmeno.Length < 10);
        }

        [TestMethod]
        public void TestDelkyJmena_NEGATIVE()
        {
            Assert.IsFalse(steve.Jmeno.Length < 10);
        }

        [TestMethod]
        public void TestPoziceX_POSITIVE()
        {
            Assert.IsTrue(steve.poziceX == 0);
        }

        [TestMethod]
        public void TestPoziceX_NEGATIVE()
        {
            steve.poziceX = 10;
            Assert.IsFalse(steve.poziceX == 0);
        }


        [TestMethod]
        public void TestPoziceY_POSITIVE()
        {
            Assert.IsTrue(steve.poziceY == 0);
        }

        [TestMethod]
        public void TestPoziceY_NEGATIVE()
        {
            steve.poziceY = 10;
            Assert.IsFalse(steve.poziceY == 0);
        }

        [TestMethod]
        public void TestOblicej_POSITIVE()
        {
            Hráč alex = new Hráč("Petr", "Kouzelník", 0, 0, 0); 
            Assert.IsTrue( alex.oblicej == 0);
        }

        [TestMethod]
        public void TestOblicej_Negative()
        {
            Hráč alex = new Hráč("Petr", "Kouzelník", 3, 0, 0);
            Assert.IsFalse(alex.oblicej == 0);
        }
        [TestMethod]
        public void TestVlasy_POSITIVE()
        {
            Hráč alex = new Hráč("Petr", "Kouzelník", 0, 0, 0);
            Assert.IsTrue(alex.vlasy == 0);
        }
        [TestMethod]
        public void TestVlasy_NEGATIVE()
        {
            Hráč alex = new Hráč("Petr", "Kouzelník", 0, 3, 0);
            Assert.IsFalse(alex.vlasy == 0);
        }

        [TestMethod]
        public void TestBarvaVlasu_POSITIVE()
        {
            Hráč alex = new Hráč("Petr", "Kouzelník", 0, 0, 0);
            Assert.IsTrue(alex.barvaVlasu == 0);
        }

        [TestMethod]
        public void TestBarvaVlasu_NEGAIVE()
        {
            Hráč alex = new Hráč("Petr", "Kouzelník", 0, 0, 5);
            Assert.IsFalse(alex.barvaVlasu == 0);
        }

        [TestMethod]
        public void Specializace_Positive()
        {
            Hráč alex = new Hráč("Petr", "Kouzelník", 0, 0, 5);
            Assert.IsTrue(alex.Specializace.Contains("Kouzelník"));
            Assert.IsTrue(alex.Specializace.Contains("Berseker"));
            Assert.IsTrue(alex.Specializace.Contains("Inženýr"));
            Assert.IsTrue(alex.Specializace.Contains("Cizák"));

        }
        [TestMethod]
        public void TestLevel_POSIIVE()
        {
            Assert.IsTrue(steve.level == 1);
        }
        [TestMethod]
        public void TestLevel_NEGAIVE()
        {
            steve.level = 3;
            Assert.IsFalse(steve.level == 1);
        }

        [TestMethod]
        public void TestXP_POSIIVE()
        {
            steve.level = 3;
            Hráč alex = new Hráč("Petr", "Kouzelník", 0, 0, 5);
            alex.PridejXP();
            Assert.IsTrue(alex.XP == 100*steve.level);
        }

        [TestMethod]
        public void TestXP_POSIIVE()
        {
            steve.level = 3;
            Hráč alex = new Hráč("Petr", "Kouzelník", 0, 0, 5);
            alex.PridejXP();
            Assert.IsTrue(alex.XP == 100 * steve.level);
        }



    }
}
