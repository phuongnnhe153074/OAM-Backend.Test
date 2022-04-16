using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using OAM_Backend.Models;
using OAM_Backend.Models.Responses;
using OAM_Backend.Repositories;

namespace OAM_Backend.Test.Mocks.Repositories
{
    public class MockAssetRepository : Mock<IAssetRepository>
    {
        public MockAssetRepository MockCreate()
        {
            Setup(x => x.Create(It.IsAny<Asset>()));
            return this;
        }

        public MockAssetRepository GetMaxIdByCategoryId(string AssetCode)
        {
            Setup(x => x.GetMaxIdByCategoryId(It.IsAny<int>()));
            return this;
        }

        public MockAssetRepository MockUpdate()
        {
            Setup(x => x.Update(It.IsAny<Asset>()));
            return this;
        }

        public MockAssetRepository MockIsAssetExists(bool isExist)
        {
            Setup(x => x.IsAssetExists(It.IsAny<string>()));
            return this;
        }

        public MockAssetRepository MockGetAll(PagedResponse<List<AssetAdminView>> results)
        {
            Setup(x => x.GetAll(It.IsAny<PageAction>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>()));
            return this;
        }

        public MockAssetRepository MockGetAsset(Asset asset)
        {
            Setup(x => x.GetAsset(It.IsAny<string>()));
            return this;
        }

        public MockAssetRepository MockGetAssets(List<Asset> assets)
        {
            Setup(x => x.GetAssets());
            return this;
        }

        public MockAssetRepository MockIsAvailableAsset(Asset asset)
        {
            Setup(x => x.IsAvailableAsset(It.IsAny<string>()));
            return this;
        }

        public MockAssetRepository MockDelete()
        {
            Setup(x => x.Delete(It.IsAny<string>()));
            return this;
        }

        public MockAssetRepository MockGetAvailableAssets(List<AssetResponse> response)
        {
            Setup(x => x.GetAvailableAssets(It.IsAny<string>()));
            return this;
        }
    }
}
