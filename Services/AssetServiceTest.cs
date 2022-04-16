using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Moq;
using OAM_Backend.Models;
using OAM_Backend.Repositories;
using Xunit;

namespace OAM_Backend.Test.Services
{
    public class AssetServiceTest
    {
        private readonly Mock<IAssetRepository> _mockAssetRepository;
        private readonly Mock<IMapper> _mockMapper;
        private readonly Mock<IAssetStateRepository> _mockAssetStateRepository;
        private readonly Mock<ICategoryRepository> _mockCategoryRepository;

        static List<Asset> _asset = new List<Asset>
        {
            new Asset
                {
                    AssetCode = "LA000001",
                    AssetName = "MSI KATANA GF66",
                    CategoryId = 1,
                    Specification = "Goob p/p",
                    Location = "Ha Noi",
                    Quantity = "0",
                    StateId = 5,
                    InstalledDate = new DateTime(2022, 01, 01)
                },
                new Asset
                {
                    AssetCode = "LA000002",
                    AssetName = "Asus TUF",
                    CategoryId = 1,
                    Specification = "Goob p/p",
                    Location = "Ha Noi",
                    Quantity = "0",
                    StateId = 5,
                    InstalledDate = new DateTime(2022, 01, 01)
                },
                new Asset
                {
                    AssetCode = "LA000003",
                    AssetName = "Acer Nitro 5 Eagle",
                    CategoryId = 1,
                    Specification = "Goob p/p",
                    Location = "Ha Noi",
                    Quantity = "0",
                    StateId = 5,
                    InstalledDate = new DateTime(2022, 01, 01)
                },
                new Asset
                {
                    AssetCode = "MT000001",
                    AssetName = "ViewSonic VA2432-H 24",
                    CategoryId = 2,
                    Specification = "Goob p/p",
                    Location = "Ha Noi",
                    Quantity = "0",
                    StateId = 5,
                    InstalledDate = new DateTime(2022, 01, 01)
                },
                new Asset
                {
                    AssetCode = "MT000002",
                    AssetName = "Acer EK241Y 24",
                    CategoryId = 2,
                    Specification = "Goob p/p",
                    Location = "Ha Noi",
                    Quantity = "0",
                    StateId = 5,
                    InstalledDate = new DateTime(2022, 01, 01)
                },
                new Asset
                {
                    AssetCode = "MT000003",
                    AssetName = "HKC M27G3F 27",
                    CategoryId = 2,
                    Specification = "Goob p/p",
                    Location = "Ha Noi",
                    Quantity = "0",
                    StateId = 5,
                    InstalledDate = new DateTime(2022, 01, 01)
                },
                new Asset
                {
                    AssetCode = "KB000001",
                    AssetName = "Razer Blackwidow Green Switch",
                    CategoryId = 3,
                    Specification = "Razer™ Green Mechanical",
                    Location = "Ha Noi",
                    Quantity = "0",
                    StateId = 5,
                    InstalledDate = new DateTime(2022, 01, 01)
                },
                new Asset
                {
                    AssetCode = "KB000002",
                    AssetName = "Leopold FC980M PD Dark Yellow",
                    CategoryId = 3,
                    Specification = "Cherry MX Brown/Red",
                    Location = "Ha Noi",
                    Quantity = "0",
                    StateId = 1,
                    InstalledDate = new DateTime(2022, 01, 01)
                },
                new Asset
                {
                    AssetCode = "KB000003",
                    AssetName = "Leopold FC980C Black Topre Switch",
                    CategoryId = 3,
                    Specification = "Silent Topre - Keycaps PBT",
                    Location = "Ha Noi",
                    Quantity = "0",
                    StateId = 1,
                    InstalledDate = new DateTime(2022, 01, 01)
                }
        };

        public AssetServiceTest()
        {
            _mockAssetRepository = new Mock<IAssetRepository>();
            _mockMapper = new Mock<IMapper>();
            _mockAssetStateRepository = new Mock<IAssetStateRepository>();
            _mockCategoryRepository = new Mock<ICategoryRepository>();
        }


    }
}
