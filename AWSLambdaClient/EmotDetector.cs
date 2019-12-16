using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using HistoryClient;

namespace AWSLambdaClient
{
    class Credentials
    {
        public string accessKey = "AKIAJD7LAUG64Y5KY3SA";
        public string privateKey = "CKX8DTED/dvNbYtORQf5sdeK747bEz1kJgT1aIUG";
    }
    public class EmotDetector
    {
        private readonly string accessKey;
        private readonly string privateKey;

        // for testing
        public static string Hi()
        {
            return "hi";
;        }

        public EmotDetector(string accessKey, string privateKey)
        {
            this.accessKey = accessKey;
            this.privateKey = privateKey;
        }

        public EmotDetector()
        {
            Lazy<Credentials> credentials = new Lazy<Credentials>();   
            this.accessKey = credentials.Value.accessKey;
            this.privateKey = credentials.Value.privateKey;
        }
        // ADD TO MIDDLE
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

        public async Task uploadReferencePhoto(string filePath)
        {
            var client = new AmazonS3Client(accessKey, privateKey, Amazon.RegionEndpoint.EUWest2);

            var putRequest = new PutObjectRequest
            {
                BucketName = "moodanalysis",
                Key = "referencePhoto.jpg",
                FilePath = filePath,
                ContentType = "text/plain"
            };

            PutObjectResponse response = await client.PutObjectAsync(putRequest);
        }

        // ADD TO MIDDLE
        public async Task<bool> IsReferencePhotoValid(string filePath)
        {
            Object emotResult = new ArrayList();
            // Uploading file to S3
            await uploadReferencePhoto(filePath);

            // Calling our Lambda function
            AmazonLambdaClient amazonLambdaClient = new AmazonLambdaClient(accessKey, privateKey, Amazon.RegionEndpoint.EUWest2);
            InvokeRequest ir = new InvokeRequest();
            ir.InvocationType = InvocationType.RequestResponse;
            ir.FunctionName = "IsReferencePhotoValid";

            // Selecting which file from S3 should our function use
            ir.Payload = "\"" + "referencePhoto.jpg" + "\"";

            // Getting the result
            var resultAWS = await amazonLambdaClient.InvokeAsync(ir);
            // Picking up the result value
            string response = Encoding.ASCII.GetString(resultAWS.Payload.ToArray());
            response = response.Replace("\"", "");
            bool result = bool.Parse(response);
            if (result == false)
            {
                throw new InvalidReferencePictureException("test");
            }
            
            return bool.Parse(response);
        }

        public  void uploadPhotoAndroid(string filePath)
        {
            string bucket = "moodanalysis";
            var client = new AmazonS3Client(accessKey, privateKey, Amazon.RegionEndpoint.EUWest2);
            //PutObjectRequest request = new PutObjectRequest
            //{
            //    BucketName = bucket,
            //    Key = "file",
            //    ContentBody = filePath
            //};

            //await client.PutObjectAsync(request);

            PutObjectRequest request = new PutObjectRequest
            {
                BucketName = bucket,
                Key = "TESTING",
            };

            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                request.InputStream = stream;

                // Put object
                var response = client.PutObjectAsync(request);
            }

            //---------------DIFFERENT METHOD, DOESN'T WORK EITHER

            //var client = new AmazonS3Client(accessKey, privateKey, Amazon.RegionEndpoint.EUWest2);

            //TransferUtility transferUtility = new TransferUtility(client);

            //TransferUtilityUploadRequest request = new TransferUtilityUploadRequest();
            //request.BucketName = "moodanalysis";
            //request.FilePath = filePath;


            //System.Threading.CancellationToken canellationToken = new System.Threading.CancellationToken();

            //await transferUtility.UploadAsync(request, canellationToken);

            ////---------------DIFFERENT METHOD
            //AmazonS3Config config = new AmazonS3Config();
            //config.ServiceURL = "https://moodanalysis.s3.eu-west-2.amazonaws.com";//amazon s3 URL                            
            //config.UseHttp = true;
            //config.RegionEndpoint = Amazon.RegionEndpoint.EUWest2;

            //AmazonS3Client client = new AmazonS3Client(accessKey,
            //    privateKey, config);

            //TransferUtility transferUtility = new TransferUtility(client);

            //TransferUtilityUploadRequest request = new TransferUtilityUploadRequest();
            //request.BucketName = "moodanalysis";
            //request.FilePath = filePath;//local file path 

            ////Test that the path is correct
            ////UIImage image = UIImage.FromFile(filePath);

            //System.Threading.CancellationToken canellationToken = new System.Threading.CancellationToken();
            //await transferUtility.UploadAsync(request, canellationToken);
            //AWSCredentials creds = new BasicAWSCredentials(accessKey,
            //                                                  privateKey);

            //var client = new AmazonS3Client(creds, Amazon.RegionEndpoint.EUWest2);    // "USWest2" replace your code(Amazon)
            //var po = new PutObjectRequest();
            //po.CannedACL = S3CannedACL.PublicReadWrite;
            //po.FilePath = filePath;
            //po.BucketName = "moodanalysis";
            //po.Key = filePath;

            //await client.PutObjectAsync(po);
        }
    }
}
