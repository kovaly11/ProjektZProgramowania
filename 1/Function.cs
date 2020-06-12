using System;
using System.Threading;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;


namespace _1
{
    public class Function
    {
        IWebDriver Browser;
        List<IWebElement> Posts;
        int ilosc;
        public Function()
        {
            var driverService = OpenQA.Selenium.Chrome.ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver(driverService);

        }
        public bool Logowanie(String login, String password)
        {
            Browser.Navigate().GoToUrl("https://www.instagram.com/");
            Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement LoginBox = Browser.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[2]/div/label/input"));
            IWebElement PasswordBox = Browser.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[3]/div/label/input"));
            IWebElement Wejscie = Browser.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]"));
            LoginBox.SendKeys(login);
            Odroczenie();
            PasswordBox.SendKeys(password);
            Odroczenie();
            Wejscie.Click();
            Odroczenie();
            try
            {
                Browser.FindElement(By.XPath("/html/body/div[1]/section/main/div/div/div/div/button")).Click();
                Odroczenie();
                Browser.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[3]/button[2]")).Click();
                Odroczenie();
            }
            catch
            {
                while (LoginBox.GetAttribute("value") != "")
                    LoginBox.SendKeys("\b");
                Odroczenie();
                while (PasswordBox.GetAttribute("value") != "")
                    PasswordBox.SendKeys("\b");
                return false;
            }
            return true;

        }

        public void PrejscDoLinku(String link)
        {
            Browser.Navigate().GoToUrl(link);
            Odroczenie();
        }
        public void ZbiorPostow()
        {
            Random rnd = new Random();
            int pixel;
            int losowo = rnd.Next(2, 5);
            int ilosc1 = ilosc * losowo;
            IJavaScriptExecutor js = Browser as IJavaScriptExecutor;
            Posts = Browser.FindElements(By.ClassName("_bz0w")).ToList();
            while (Posts.Count < ilosc1)
            {
                pixel = rnd.Next(80, 1500);
                js.ExecuteScript("window.scrollBy(0," + pixel + ");");
                Posts = Browser.FindElements(By.ClassName("_bz0w")).ToList();
                Odroczenie();
            }
        }
        public String[] UstawieniaLikow()
        {
            List<IWebElement> Posts1 = Posts;
            IWebElement post;
            String[] konta = new String[ilosc];
            String href;
            for (int i = 0; i < ilosc; i++)
            {
                post = Posts1[new Random().Next(0, Posts1.Count)];
                Posts1.Remove(post);
                post.Click();
                Odroczenie();
                IWebElement likeButton = Browser.FindElement(By.XPath("/html/body/div[4]/div[2]/div/article/div[2]/section[1]/span[1]/button"));
                String like = likeButton.FindElement(By.TagName("svg")).GetAttribute("aria-label");
                if (like == "Нравится")
                {
                    likeButton.Click();
                    href = Browser.FindElement(By.XPath("/html/body/div[4]/div[2]/div/article/header/div[2]/div[1]/div[1]/a")).GetAttribute("href");
                    konta[i] = href;
                }
                Odroczenie();
                Browser.FindElement(By.XPath("/html/body/div[4]/div[3]/button")).Click();
                Odroczenie();
            }
            return konta;
        }
        public String[] Subskrybuj()
        {
            List<IWebElement> Posts1 = Posts;
            IWebElement post;
            String[] konta = new String[ilosc];
            String href;
            for (int i = 0; i < ilosc; i++)
            {
                post = Posts1[new Random().Next(0, Posts1.Count)];
                Posts1.Remove(post);
                post.Click();
                Odroczenie();
                IWebElement subskrybButton = Browser.FindElement(By.XPath("/html/body/div[4]/div[2]/div/article/header/div[2]/div[1]/div[2]/button"));
                String subskryb = subskrybButton.Text;
                if (subskryb == "Подписаться")
                {
                    subskrybButton.Click();
                    href = Browser.FindElement(By.XPath("/html/body/div[4]/div[2]/div/article/header/div[2]/div[1]/div[1]/a")).GetAttribute("href");
                    konta[i] = href;
                }
                Odroczenie();
                Browser.FindElement(By.XPath("/html/body/div[4]/div[3]/button")).Click();
                Odroczenie();
            }
            return konta;
        }

        public String[] PiszKomentarzy()
        {
            List<IWebElement> Posts1 = Posts;
            IWebElement post;
            String[] konta = new String[ilosc];
            String href, koment;
            String[] komentarze = { "Super!", "Extra!!!", "XD", "Bardzo dobrze )", "Piękne zdjęcia )" };
            for (int i = 0; i < ilosc; i++)
            {
                post = Posts1[new Random().Next(0, Posts1.Count)];
                Posts1.Remove(post);
                post.Click();
                Odroczenie();
                IWebElement komentarButton = Browser.FindElement(By.XPath("/html/body/div[4]/div[2]/div/article/div[2]/section[1]/span[2]/button"));
                komentarButton.Click();
                try
                {
                    IWebElement komentar = Browser.FindElement(By.XPath("/html/body/div[4]/div[2]/div/article/div[2]/section[3]/div/form/textarea"));
                    koment = komentarze[new Random().Next(0, komentarze.Length)];
                    komentar.SendKeys(koment);
                    Odroczenie();
                    Browser.FindElement(By.XPath("/html/body/div[4]/div[2]/div/article/div[2]/section[3]/div/form/button")).Click();
                    Odroczenie();
                    href = Browser.FindElement(By.XPath("/html/body/div[4]/div[2]/div/article/header/div[2]/div[1]/div[1]/a")).GetAttribute("href");
                    konta[i] = href + " got a comment \"" + koment + "\"";
                }
                finally
                {
                    Browser.FindElement(By.XPath("/html/body/div[4]/div[3]/button")).Click();
                    Odroczenie();
                }
            }
            return konta;
        }
        public void Odroczenie()
        {
            Random rnd = new Random();
            int czas = rnd.Next(500, 3000);
            Thread.Sleep(czas);
        }

        public int UstawIlosc(int ilo)
        {
            ilosc = ilo;
            return ilosc;
        }

        public void Zamkni()
        {
            Browser.Quit();
        }

    }
}
