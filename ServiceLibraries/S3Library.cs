using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using Amazon;
using Amazon.S3.Transfer;

namespace ServiceLibraries
{
    public static class S3Library
    {
        public static bool CopyToBucket(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint awsRegion, string awsBucketName, string name, string value)
        {
            try
            {
                var filename = "log-" + Guid.NewGuid().ToString() + ".log";
                var stream = new MemoryStream();

                // A single object
                //var serializer = new DataContractJsonSerializer(typeof(Json));
                //serializer.WriteObject(stream, new Json(name, value));

                // A list of objects
                var jsons = new List<Json>();
                jsons.Add(new Json("Kaori", "4"));
                jsons.Add(new Json("Mimi", "1"));
                var serializer = new DataContractJsonSerializer(typeof(List<Json>));
                serializer.WriteObject(stream, jsons);

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