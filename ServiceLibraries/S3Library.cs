using System;
using System.IO;
using System.Runtime.Serialization.Json;
using Amazon;
using Amazon.S3.Transfer;

namespace ServiceLibraries
{
    public static class S3Library
    {
        public static bool CopyToBucket(string awsAccessKeyId, string awsSecretAccessKey, string awsBucketName, RegionEndpoint awsRegion, string name, string value)
        {
            try
            {
                var filename = "log-" + Guid.NewGuid().ToString() + ".log";
                var stream = new MemoryStream();
                var serializer = new DataContractJsonSerializer(typeof(JSon));
                serializer.WriteObject(stream, new JSon(name, value));

                var transferUtility = new TransferUtility(awsAccessKeyId, awsSecretAccessKey, awsRegion);
                transferUtility.Upload(stream, awsBucketName, filename);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}