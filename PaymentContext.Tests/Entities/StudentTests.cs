using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
 {
     [TestClass]
     public class StudentTests
     {
         [TestMethod]
         public void AdicionarAssinatura()
         {
             var subscription = new Subscription(null);
             var student = new Student("Mário", "Menezes", "123456789", "mario082@gmail.com");
             student.AddSubscription(subscription);
         }
     }
 }