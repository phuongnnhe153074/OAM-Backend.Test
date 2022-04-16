using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using OAM_Backend.Controllers;
using OAM_Backend.Helpers;
using OAM_Backend.Models;
using OAM_Backend.Models.Responses;
using OAM_Backend.Services;
using Xunit;

namespace OAM_Backend.Test.Controllers
{
    public class AssetControllerTest
    {
        private readonly Mock<IAssetService> _mockAssetService;
        private readonly Mock<IAssignmentService> _mockAssignmentService;
        private readonly Mock<AssetsController> _mockAssetController;

        static List<AssetAdminView> _asset = new List<AssetAdminView>
        {
            //new Asset
            //    {
            //        AssetCode = "LA000001",
            //        AssetName = "MSI KATANA GF66",
            //        CategoryId = 1,
            //        Specification = "Goob p/p",
            //        Location = "Ha Noi",
            //        Quantity = "0",
            //        StateId = 5,
            //        InstalledDate = new DateTime(2022, 01, 01)
            //    },
            //    new Asset
            //    {
            //        AssetCode = "LA000002",
            //        AssetName = "Asus TUF",
            //        CategoryId = 1,
            //        Specification = "Goob p/p",
            //        Location = "Ha Noi",
            //        Quantity = "0",
            //        StateId = 5,
            //        InstalledDate = new DateTime(2022, 01, 01)
            //    },
            //    new Asset
            //    {
            //        AssetCode = "LA000003",
            //        AssetName = "Acer Nitro 5 Eagle",
            //        CategoryId = 1,
            //        Specification = "Goob p/p",
            //        Location = "Ha Noi",
            //        Quantity = "0",
            //        StateId = 5,
            //        InstalledDate = new DateTime(2022, 01, 01)
            //    },
            //    new Asset
            //    {
            //        AssetCode = "MT000001",
            //        AssetName = "ViewSonic VA2432-H 24",
            //        CategoryId = 2,
            //        Specification = "Goob p/p",
            //        Location = "Ha Noi",
            //        Quantity = "0",
            //        StateId = 5,
            //        InstalledDate = new DateTime(2022, 01, 01)
            //    },
            //    new Asset
            //    {
            //        AssetCode = "MT000002",
            //        AssetName = "Acer EK241Y 24",
            //        CategoryId = 2,
            //        Specification = "Goob p/p",
            //        Location = "Ha Noi",
            //        Quantity = "0",
            //        StateId = 5,
            //        InstalledDate = new DateTime(2022, 01, 01)
            //    },
            //    new Asset
            //    {
            //        AssetCode = "MT000003",
            //        AssetName = "HKC M27G3F 27",
            //        CategoryId = 2,
            //        Specification = "Goob p/p",
            //        Location = "Ha Noi",
            //        Quantity = "0",
            //        StateId = 5,
            //        InstalledDate = new DateTime(2022, 01, 01)
            //    },
            //    new Asset
            //    {
            //        AssetCode = "KB000001",
            //        AssetName = "Razer Blackwidow Green Switch",
            //        CategoryId = 3,
            //        Specification = "Razer™ Green Mechanical",
            //        Location = "Ha Noi",
            //        Quantity = "0",
            //        StateId = 5,
            //        InstalledDate = new DateTime(2022, 01, 01)
            //    },
            //    new Asset
            //    {
            //        AssetCode = "KB000002",
            //        AssetName = "Leopold FC980M PD Dark Yellow",
            //        CategoryId = 3,
            //        Specification = "Cherry MX Brown/Red",
            //        Location = "Ha Noi",
            //        Quantity = "0",
            //        StateId = 1,
            //        InstalledDate = new DateTime(2022, 01, 01)
            //    },
            //    new Asset
            //    {
            //        AssetCode = "KB000003",
            //        AssetName = "Leopold FC980C Black Topre Switch",
            //        CategoryId = 3,
            //        Specification = "Silent Topre - Keycaps PBT",
            //        Location = "Ha Noi",
            //        Quantity = "0",
            //        StateId = 1,
            //        InstalledDate = new DateTime(2022, 01, 01)
            //    }
            new AssetAdminView
                {
                    AssetCode = "CH000011",
                    AssetName = "G603",
                    CategoryId = 1,
                    CategoryName = "Chair",
                    Specification = "good",
                    Location = "Ho Chi Minh",
                    Quantity = "6",
                    StateId = 1,
                    assignedTime = 0,
                    InstalledDate = new DateTime(2022, 01, 01)
                }
        };

        public AssetControllerTest()
        {
            _mockAssetService = new Mock<IAssetService>();
            _mockAssignmentService = new Mock<IAssignmentService>();
            _mockAssetController = new Mock<AssetsController>();
        }
        [Fact]
        public void GetAll_LocationParameter_ReturnAllAsset()
        {
            //_mockUserService.Setup(x => x.GetUsersForTesting()).Returns(_user);
            //var result = _mockUserService.Object.GetUsersForTesting();
            //Assert.Equal(result, _user);
            //Assert.Equal(result.Count, 6);
            //Assert.Equal(result[0].Staffcode, "SD0001");
            // Arrange 
            var expectedList = _asset.ToList();
            var validAction = new PageAction(
                1,
                1,
                null,
                null,
                null,
                null
                );
            var pagedReponse = PageActionHelper.CreatePagedReponse<AssetAdminView>(
                _asset,
                validAction,
                1
            );
            _mockAssetService.Setup(x => x.GetAll(new PageAction(), "Ho Chi Minh", 6, 0)).Returns(pagedReponse);
            //act
            var result = _mockAssetService.Object.GetAll(new PageAction(), "Ho Chi Minh", 6, 0);

        }
    }
}