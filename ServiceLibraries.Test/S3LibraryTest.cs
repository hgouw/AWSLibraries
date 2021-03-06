using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon;

namespace ServiceLibraries.Test
{
    [TestClass]
    public class S3LibraryTest
    {
        [TestMethod]
        public void CopyToBucketTest()
        {
            // Personal
            Assert.IsTrue(S3Library.CopyToBucket("", "", RegionEndpoint.APSoutheast2, "", "name", "value"));
            // Sandbox
            Assert.IsTrue(S3Library.CopyToBucket("", "", RegionEndpoint.APSoutheast2, "", "name", "value"));
        }
    }
}