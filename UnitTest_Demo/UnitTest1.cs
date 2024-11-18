//using Rza_Website.Services;
//using Rza_Website.Components;
//using Rza_Website.Utilities;
//using Rza_Website.Models;
//using Microsoft.EntityFrameworkCore;

//namespace UnitTest_Demo
//{
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {

//            var options = new DbContextOptionsBuilder<TlS2300852RzaContext>()
//                .UseInMemoryDatabase(databaseName: "TestDatabase")
//                .Options;
//                _context = new TlS2300852RzaContext(options);
//            _customerService = new CustomerService(_context);

//        }

//        [Test]
//        public void Test1()
//        {
//            Assert.Pass();
//        }
//    }
//}