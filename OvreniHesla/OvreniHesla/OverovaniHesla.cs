using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Hesloapp;

namespace OvreniHesla
{
    [TestClass]
    public class OverovaniHesla
    {
        public Heslo heslo = new Heslo();
        [TestMethod]
        public void ObsahujeRPR()
        {
            heslo.NastavHeslo("RPR");
            Assert.IsTrue(heslo.heslo.Contains("RPR");
        }
        [TestMethod]
        public void Delka(string heslo)
        {
            
        }
        [TestMethod]
        public void Neprazdne(string heslo)
        {
          
            
        }
        
    }
}
