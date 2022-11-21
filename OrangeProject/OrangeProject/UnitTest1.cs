using NUnit.Framework;
using OrangeProject.Driver;
using OrangeProject.Page;

namespace OrangeProject
{
    public class Tests
    {
        LogIn login;
        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            login = new LogIn();
        }

        [Test]
        public void Test1()
        {
            login.LoginUser("Admin","admin123");
        }
    }
}