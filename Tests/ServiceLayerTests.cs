using NUnit.Framework;
using FluentAssertions;
using DataAccessLayer;
using ServiceLayer;
using Moq;
using ServiceLayer;

namespace Tests
{
    public class Tests
    {
        IDataLayer _dataLayer;
        IService _service;
        Mock<IDataLayer> _mockDataLayer;
        [SetUp]
        public void Setup()
        {
            _dataLayer = new DataLayer();
            
            _mockDataLayer = new Mock<IDataLayer>();
            _service = new Service();
        }

        [Test]
        public void GetListOfGenre_Service_should_()
        {
            string genre = "Fantasy";
            //_service.GetListOfGenre(genre);
            //_mockDataLayer.Verify(x => x.ExtractListOfGenre(genre), Times.Once);
            int id = 1;
            var result = _service.GetBookDetails(id);
            result.Should().NotBeNull();
            //Assert.Pass();
        }
    }
}