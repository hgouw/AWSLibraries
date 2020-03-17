using System;
using System.IO;
using System.Runtime.Serialization.Json;
using Amazon;
using Amazon.S3.Transfer;

namespace ServiceLibraries
{
    public static class S3Library
    {
        public static bool CopyToBucket(string awsAccessKeyId, string awsSecretAccessKey, string bucketName)
        {
            try
            {
                var json = new JSon("Herman", "60");
                var stream = new MemoryStream();
                var serializer = new DataContractJsonSerializer(typeof(JSon));
                serializer.WriteObject(stream, json);

                var filename = "log-" + Guid.NewGuid().ToString() + ".log";
                var transferUtility = new TransferUtility(awsAccessKeyId, awsSecretAccessKey, RegionEndpoint.APSoutheast2);
                transferUtility.Upload(stream, bucketName, filename);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}