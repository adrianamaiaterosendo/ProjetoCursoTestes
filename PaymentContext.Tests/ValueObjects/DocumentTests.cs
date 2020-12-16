using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Domain.Enums;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);      
           
        }
        [TestMethod]
        public void ShouldReturnSucessWhenCNPJIsValid()
        {
            var doc = new Document("34110468000150", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);       
           
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);      
           
        }
        [TestMethod]
        [DataTestMethod]
        [DataRow("29734148818")]
        [DataRow("34148815264")]
        [DataRow("28546822214")]
            public void ShouldReturnSucessWhenCPFIsValid(string CPF)
        {
            var doc = new Document(CPF, EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);       
           
        }

    }
}