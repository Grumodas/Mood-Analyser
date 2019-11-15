using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

using Amazon.Lambda.Core;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AWSIsReferencePhotoValid
{
    public class Function
    {

        public static async Task<string> FunctionHandler(String photo)
        {
            String bucket = "moodanalysis";
            //ArrayList result = new ArrayList();

            AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient();

            DetectFacesRequest detectFacesRequest = new DetectFacesRequest()
            {
                Image = new Image()
                {
                    S3Object = new S3Object()
                    {
                        Name = photo,
                        Bucket = bucket
                    },
                },

                Attributes = new List<String>() { "ALL" }
            };

            DetectFacesResponse detectFacesResponse = await rekognitionClient.DetectFacesAsync(detectFacesRequest);

            int count = detectFacesResponse.FaceDetails.Count;
            //return false;
            return (count == 1) + "";
        }
    }
}
