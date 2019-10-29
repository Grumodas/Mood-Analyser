using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AWSLambdaClient
{
    public class EmotDetector
    {
        private readonly string accessKey;
        private readonly string privateKey;

        public EmotDetector(string accessKey, string privateKey)
        {
            this.accessKey = accessKey;
            this.privateKey = privateKey;
        }
        public async Task<string> WhatEmot(string filePath, string fileName)
        {
            Object emotResult = new ArrayList();
            // Uploading file to S3
            await UploadToS3(filePath, fileName);
            
            // Calling our Lambda function
            AmazonLambdaClient amazonLambdaClient = new AmazonLambdaClient(accessKey, privateKey, Amazon.RegionEndpoint.EUWest2);
            InvokeRequest ir = new InvokeRequest();
            ir.InvocationType = InvocationType.RequestResponse;
            ir.FunctionName = "MyAWS";

            // Selecting which file from S3 should our function use
            ir.Payload = "\"" + fileName + "\"";

            // Getting the result
            var result = await amazonLambdaClient.InvokeAsync(ir);
            // Picking up the result value
            string response = Encoding.ASCII.GetString(result.Payload.ToArray());

            return response;
        }

        // Putting the file to S3
        public async Task UploadToS3(string filePath, string fileName)
        {
            var client = new AmazonS3Client(accessKey, privateKey, Amazon.RegionEndpoint.EUWest2);

            var putRequest = new PutObjectRequest
            {
                BucketName = "moodanalysis",
                Key = fileName,
                FilePath = filePath,
                ContentType = "text/plain"
            };

            PutObjectResponse response = await client.PutObjectAsync(putRequest);
        }
    }
}
