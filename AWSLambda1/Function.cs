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

namespace AWSLambda1
{
    public class Function
    {

        public static async Task<string> FunctionHandler(String photo)
        {
            String bucket = "moodanalysis";
            //ArrayList result = new ArrayList();
            string result = "";

            AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient();

            CompareFacesRequest CFR = new CompareFacesRequest()
            {
                //SimilarityThreshold = 50,

                SourceImage = new Image()
                {
                    S3Object = new S3Object()
                    {
                        Name = "jd_stupid_hair.png",
                        Bucket = bucket
                    },
                },

                TargetImage = new Image()
                {
                    S3Object = new S3Object()
                    {
                        Name = photo,
                        Bucket = bucket
                    },
                },
            };

            CompareFacesResponse compareFacesResponse = await rekognitionClient.CompareFacesAsync(CFR);
            string test = "";

            int index = 0, bestIndex = 0;
            var bestMatch = compareFacesResponse.FaceMatches[0];
            float bestMatchResult = compareFacesResponse.FaceMatches[0].Similarity;
            foreach (var faceMatch in compareFacesResponse.FaceMatches)
            {
                test += faceMatch.Similarity + ",";

                if (bestMatchResult < faceMatch.Similarity)
                {
                    bestMatch = faceMatch;
                    bestIndex = index;
                }
                index++;
            }

            //return test + "and the best face is: " + bestMatch.Similarity;


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

            //foreach (FaceDetail face in detectFacesResponse.FaceDetails)
            //{
            var face = detectFacesResponse.FaceDetails[bestIndex];
                IEnumerable<Emotion> emotQuery =
                    from faceEmotion in face.Emotions
                    where faceEmotion.Confidence > 20
                    select faceEmotion;
                // GRAB THE EMOTION
                foreach (Emotion emot in emotQuery)
                {
                    //if (emot.Confidence > 20)
                    //{
                    //    if (result != "")
                    //    {
                    //        result += ",";
                    //    }

                    //    result += emot.Type;
                    //}
                    result += emot.Type + ",";
 
                }
            //}
            //return false;
            return test + "- - -" + result;
        }
    }
}
