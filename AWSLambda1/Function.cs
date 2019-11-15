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
        public delegate bool ConfidenceFilterDelegate(Emotion e);
        public delegate List<Emotion> FilterEmotions(FaceDetail facething, ConfidenceFilterDelegate filterthing);

        public static async Task<string> FunctionHandler(String photo)
        {
            String bucket = "moodanalysis";
            //ArrayList result = new ArrayList();
            string result = "";

            AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient();

            // Recognizes User's face
            CompareFacesRequest CFR = new CompareFacesRequest()
            {
                //SimilarityThreshold = 50,

                SourceImage = new Image()
                {
                    S3Object = new S3Object()
                    {
                        Name = "referencePhoto.jpg",
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

            // Detects emotions of faces in photo
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
                    //var emotQuery = FilterEmotions(face, IsLowConfidence);

                    FilterEmotions filter = delegate(FaceDetail facething, ConfidenceFilterDelegate filterthing)
                    {
                        return face.Emotions.FindAll(n => filterthing(n)).ToList();
                    };
                    var emotQuery = filter(face, IsHighConfidence);

                    //IEnumerable<Emotion> emotQuery =
                    //    from faceEmotion in face.Emotions
                    //    where faceEmotion.Confidence > 10
                    //    select faceEmotion;

                    // GRAB THE EMOTION
                    foreach (Emotion emot in emotQuery)
                    {
                        result += emot.Type + ",";
                    }

                    break;
                }
            }

            //delete the last ,
            if (result.Length != 0)
            {
                result = result.Substring(0, result.Length - 1);
            }

            return result;
        }

        //static public List<Emotion> FilterEmotions(FaceDetail face, ConfidenceFilterDelegate filter)
        //{
        //    return face.Emotions.FindAll(n => filter(n)).ToList();
        //}

        static public bool IsHighConfidence(Emotion e)
        {
            return e.Confidence > 50;
        }
        static public bool IsMediumConfidence(Emotion e)
        {
            return e.Confidence > 20;
        }
        static public bool IsLowConfidence(Emotion e)
        {
            return e.Confidence > 5;
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Collections;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Diagnostics;

//using Amazon.Lambda.Core;
//using Amazon.Rekognition;
//using Amazon.Rekognition.Model;

//// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
//[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

//namespace AWSLambda1
//{
//    public class Function
//    {

//        public static async Task<string> FunctionHandler(String photo)
//        {
//            //REIK ISIRASYT SAVO BUCKET'A I THINK
//            String bucket = "moodanalysis";
//            //ArrayList result = new ArrayList();
//            string result = "";

//            AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient();

//            DetectFacesRequest detectFacesRequest = new DetectFacesRequest()
//            {
//                Image = new Image()
//                {
//                    S3Object = new S3Object()
//                    {
//                        Name = photo,
//                        Bucket = bucket
//                    },
//                },

//                Attributes = new List<String>() { "ALL" }
//            };

//            DetectFacesResponse detectFacesResponse = await rekognitionClient.DetectFacesAsync(detectFacesRequest);

//            foreach (FaceDetail face in detectFacesResponse.FaceDetails)
//            {

//                IEnumerable<Emotion> emotQuery =
//                    from faceEmotion in face.Emotions
//                    where faceEmotion.Confidence > 5
//                    select faceEmotion;
//                // GRAB THE EMOTION
//                foreach (Emotion emot in emotQuery)
//                {
//                    //if (emot.Confidence > 20)
//                    //{
//                    //    if (result != "")
//                    //    {
//                    //        result += ",";
//                    //    }

//                    //    result += emot.Type;
//                    //}
//                    result += emot.Type + "," + emot.Confidence + "---";

//                }
//            }
//            //return false;
//            return result;
//        }
//    }
//}
