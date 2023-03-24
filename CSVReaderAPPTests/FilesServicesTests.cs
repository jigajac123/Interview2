using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSVReaderAPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
using Moq;
using CSVReaderAPPTests;

namespace CSVReaderAPP.Tests
{
    [TestClass()]
    public class FilesServicesTests
    {
        [TestMethod()]
        public void firstDscOrderTest()
        {
            //Arrange
            
            var mock = new Mock<IServices>().Setup(x => x.firstDscOrder()).Returns(new List<string>());
            

            //Act

            var actual = FilesServices.firstDscOrder();
            var expected = Fixture.StringFirstDscOrder();

            //Assert
            mock.Verifiable();
           Assert.IsNotNull(actual);
           Assert.AreEqual(expected.Count, actual.Count);
            for(var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
           
           
           

        }

        [TestMethod()]
        public void secondAlphabeticalOrderTest()
        {
            //Arrange

            var mock1 = new Mock<IServices>().Setup(x => x.secondAlphabeticalOrder()).Returns(new List<string>());


            //Act

            var actual1 = FilesServices.secondAlphabeticalOrder();
            var expected1 = Fixture.StringSecondAlphab();


            //Assert
            mock1.Verifiable();
            Assert.IsNotNull(actual1);
            Assert.AreEqual(expected1.Count, actual1.Count);
            for (var i = 0; i < expected1.Count; i++)
            {
                Assert.AreEqual(actual1[i], expected1[i]);
            }

        }
    }
}