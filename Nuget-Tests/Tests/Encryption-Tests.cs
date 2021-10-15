using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Nuget_Tests.Tests
{
    public class Encryption_Tests
    {
        [Fact]
        public void SALTING_AND_HASHING_TEST()
        {
            var SALT = "SALT";
            var HASH = Nuget_Library.Encryption.SaltingAndHashing.GetHash("PASSWORD", SALT);
            Assert.True(Nuget_Library.Encryption.SaltingAndHashing.CompareHash("PASSWORD",HASH,SALT));
        }
    }
}
