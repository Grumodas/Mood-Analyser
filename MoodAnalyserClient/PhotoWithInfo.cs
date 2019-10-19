using System;

public enum Emotion
{
    UNKNOWN = 0b_0000_0000, // 0
    HAPPY = 0b_0000_0001, // 1
    SAD = 0b_0000_0010, // 2
    ANGRY = 0b_0000_0100, // 4
    CONFUSED = 0b_0000_1000, // 8
    DISGUSTED = 0b_0001_0000, // 16
    SURPRISED = 0b_0010_0000, // 32
    CALM = 0b_0100_0000,  // 64 
    FEAR = 0b_1000_0000  // 128
}

public struct Info
{
    String eventName;
    Emotion emotion;
    //Photo photo???
    DateTime date;
    
    public Info(String eventName, Emotion emotion)
    {
        this.eventName = eventName;
        this.emotion = emotion;
        this.date = DateTime.Now;
    }
}

namespace MoodAnalyserClient
{
    class PhotoWithInfo
    {
        private Info info;
        PhotoWithInfo(String eventName, Emotion emotion)
        {
            Info info = new Info(eventName, emotion);
    }
    }
}
