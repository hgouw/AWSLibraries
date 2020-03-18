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
        public IAmazonS3 S3Client { get; set; }
        public TransferUtility TransferUtility { get; set; }
        public string BucketName { get; set; }
        public string AccessKeyId { get; set; }
        public string SecretAccessKey { get; set; }
        public RegionEndpoint Region { get; set; }

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
        }
    }
}
