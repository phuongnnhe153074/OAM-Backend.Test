using Moq;
using OAM_Backend.Models;
using OAM_Backend.Models.Responses;
using OAM_Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAM_Backend.Test.Mocks.Repositories
{
    public class MockUserRepository : Mock<IUserRepository>
    {
        public MockUserRepository MockGetAll(PagedResponse<List<User>> response)
        {
            Setup(x => x.GetAll(It.IsAny<PageAction>(), It.IsAny<string>(), It.IsAny<int>()));
            return this;
        }

        public MockUserRepository MockDisableUser(User user)
        {
            Setup(x => x.DisableUser(It.IsAny<string>()));
            return this;
        }

        public MockUserRepository MockCreate()
        {
            Setup(x => x.Create(It.IsAny<User>()));
            return this;
        }

        public MockUserRepository MockUpdate()
        {
            Setup(x => x.Update(It.IsAny<User>()));
            return this;
        }

        public MockUserRepository MockGetUserByStaffcode(User user)
        {
            Setup(x => x.GetUserByStaffcode(It.IsAny<string>()));
            return this;
        }

        public MockUserRepository MockGetUserByUsername(User user)
        {
            Setup(x => x.GetUserByUsername(It.IsAny<string>()));
            return this;
        }

        public MockUserRepository MockGetLastestUser(User user)
        {
            Setup(x => x.GetLastestUser());
            return this;
        }

        public MockUserRepository MockIsExistUserHaveSameUsername(bool isExist)
        {
            Setup(x => x.IsExistUserHaveSameUsername(It.IsAny<string>()));
            return this;
        }
    }
}
