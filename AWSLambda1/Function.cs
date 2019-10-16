using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

using Amazon.Lambda.Core;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AWSLambda1
{
    public class Function
    {

        public static async Task<String> FunctionHandler(String photo)
        {
            //REIK ISIRASYT SAVO BUCKET'A I THINK
            String bucket = "rimantasbucket2";
            String result = "";

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

            foreach (FaceDetail face in detectFacesResponse.FaceDetails)
            {
                // GRAB THE EMOTION
                foreach (Emotion emot in face.Emotions)
                {
                    result += emot.Type + " " + emot.Confidence + "\n";
                }

                // GRAB THE BOUDING BOXES
                // CHECK PAPER NOTES FOR MORE INFO
            }


            return result;
        }
    }
}
