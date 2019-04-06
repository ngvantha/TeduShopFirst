using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using TeduShop.Model.Model;
using TeduShop.Service;
using TeduShopData.Infratructure;
using TeduShopData.Repositoris;

namespace TeduShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockPostCategoryRepository;
        private Mock<IUnitofWork> _mockUnitofWork;
        private PostCategoryService _categoryService;
        private List<PostCategory> _postCategoryList;

        [TestInitialize]
        public void Initialize()
        {
            _mockPostCategoryRepository = new Mock<IPostCategoryRepository>();
            _mockUnitofWork = new Mock<IUnitofWork>();
            _categoryService = new PostCategoryService(_mockPostCategoryRepository.Object, _mockUnitofWork.Object);
            _postCategoryList = new List<PostCategory>()
            {
                new PostCategory(){ID=1,Name="DM1Service",Status=true},
                new PostCategory(){ID=2,Name="DM2Service",Status=true},
                new PostCategory(){ID=3,Name="DM3Service",Status=true}
            };
        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            //setup method
            _mockPostCategoryRepository.Setup(m => m.GetAll(null)).Returns(_postCategoryList);
            //call action
            var result = _categoryService.GetAll() as List<PostCategory>;
            //compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            PostCategory category = new PostCategory();
            //int id;
            category.Name = "Test PostCategory Server";
            category.Alias = "Test PostCategory Server";
            category.Status = true;
            _mockPostCategoryRepository.Setup(m => m.Add(category)).Returns((PostCategory p) =>
                  {
                      p.ID = 1;
                      return p;                     
                  });
            var result = _categoryService.Add(category);
            Assert.AreEqual(1, result.ID);
            Assert.IsNotNull(result);
        }
    }
}