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
                        Name = "jd_smile.jpg",
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

            if (compareFacesResponse.FaceMatches.Count == 0)
            {
                return "";
            }

            //int index = 0, bestIndex = 0;
            var bestMatch = compareFacesResponse.FaceMatches[0];
            float bestMatchResult = compareFacesResponse.FaceMatches[0].Similarity;
            BoundingBox bestBoundingBox = compareFacesResponse.FaceMatches[0].Face.BoundingBox;
            foreach (var faceMatch in compareFacesResponse.FaceMatches)
            {
                test += faceMatch.Similarity + ",";

                if (bestMatchResult < faceMatch.Similarity)
                {
                    bestMatch = faceMatch;
                    bestBoundingBox = faceMatch.Face.BoundingBox;
                    bestMatchResult = faceMatch.Similarity;
                }
            }


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

            //int i = 0;
            foreach (FaceDetail face in detectFacesResponse.FaceDetails)
            {
                if (face.BoundingBox.Height == bestBoundingBox.Height &&
                    face.BoundingBox.Left == bestBoundingBox.Left &&
                    face.BoundingBox.Top == bestBoundingBox.Top &&
                    face.BoundingBox.Width == bestBoundingBox.Width)
                {
                    IEnumerable<Emotion> emotQuery =
                        from faceEmotion in face.Emotions
                        where faceEmotion.Confidence > 5
                        select faceEmotion;

                    // GRAB THE EMOTION
                    foreach (Emotion emot in emotQuery)
                    {
                        result += emot.Type + ",";
                    }
                }
            }
            //}
            //return test + "- - -" + result;
            return result;
        }
    }
}
