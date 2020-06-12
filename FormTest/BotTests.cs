using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1;

namespace FormTest
{
    [TestClass]
    public class BotTests
    {
        [TestMethod]
        public void LoginTest()
        {
            Function Bot = new Function();            
            Assert.IsTrue(Bot.Logowanie("marvel_kovaly", "zxcvbnm123"));
            Bot.Zamkni();
        }

        [TestMethod]
        public void IloscTest()
        {
            Function Bot = new Function();
            int ilosc = Bot.UstawIlosc(10);
            Bot.Zamkni();
            Assert.AreEqual(ilosc, 10);
        }
       
    }
}
