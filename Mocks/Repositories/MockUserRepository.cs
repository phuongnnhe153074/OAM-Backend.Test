using Moq;
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
        public MockUserRepository MockGetAll()
        {
            return new MockUserRepository();
        }
    }
}
