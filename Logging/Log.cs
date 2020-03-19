using System;
using System.Collections.Generic;
using System.Text;
using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;

namespace Logging
{
    public class Log
    {
        public string BucketName { get; set; }
        public string AccessKeyId { get; set; }
        public string SecretAccessKey { get; set; }
        public RegionEndpoint Region { get; set; }
        public TransferUtility TransferUtility { get; set; }

        public Log()
        {
        }

        public Log(string bucketName)
        {
            BucketName = bucketName;
        }

        public Log(string bucketName, string accessKeyId, string secretAccessKey, RegionEndpoint region)
        {
            BucketName = bucketName;
            AccessKeyId = accessKeyId;
            SecretAccessKey = secretAccessKey;
            Region = region;
            TransferUtility = new TransferUtility(accessKeyId, secretAccessKey, region);
        }

        public void Write(string message, string category, string bucketName = null)
        {

        }

        public void WriteLine()
        {
            //var jsons = new List<Json>();
            //jsons.Add(new Json("Kaori", "4"));
            //jsons.Add(new Json("Mimi", "1"));
            //var serializer = new DataContractJsonSerializer(typeof(List<Json>));
            //serializer.WriteObject(stream, jsons);
        }
    }
}
