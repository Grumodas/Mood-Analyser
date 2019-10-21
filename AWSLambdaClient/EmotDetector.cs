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
        public async Task<Object> WhatEmot(string filePath, string fileName)
        {
            // (not sure to the detail what deos what here) 
            Object emotResult = new ArrayList();

            await UploadToS3(filePath, fileName);

            AmazonLambdaClient amazonLambdaClient = new AmazonLambdaClient(accessKey, privateKey, Amazon.RegionEndpoint.EUWest1);
            // Calling our Lambda function
            InvokeRequest ir = new InvokeRequest();
            ir.InvocationType = InvocationType.RequestResponse;
            ir.FunctionName = "AWSLambda1";
            // Selecting which file from S3 should our function use
            ir.Payload = "\"" + fileName + "\"";

            // Getting the result. result is of type InvokeResponse
            InvokeResponse result = await amazonLambdaClient.InvokeAsync(ir);
            // Picking up the result value
            emotResult = result.Payload;

            return emotResult;


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
