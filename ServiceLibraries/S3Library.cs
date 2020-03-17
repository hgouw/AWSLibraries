using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Amazon;
using Amazon.S3.Transfer;

namespace ServiceLibraries
{
    public static class S3Library
    {
        private const string awsAccessKeyId = "AKIAJ6BT7U37B3DREJSQ";
        private const string awsSecretAccessKey = "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";
        private const string filePath = "c:\\logs\\ASX_LNGSYDL-600244_2020-03-08.log";
        private const string bucketName = "aio-snoopy-hgouw";

        public static bool CopyToBucket()
        {
            try
            {
                var filename = "log-" + Guid.NewGuid().ToString() + ".log";
                var transferUtility = new TransferUtility(awsAccessKeyId, awsSecretAccessKey, RegionEndpoint.APSoutheast2);
                transferUtility.Upload(filePath, bucketName);
                return true;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                return false;
            }
        }
    }
}