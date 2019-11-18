using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

public struct Info : IEquatable<Info>, IComparable<Info>
{
    public String eventName { get; set; }
    public Emotion emotion;
    public DateTime date { get; set; }
    public static List<Info> InfoList = new List<Info>();
    public static int index = 0;

    public Info(String eventName = "", Emotion emotion = Emotion.UNKNOWN)
    {
        this.eventName = eventName;
        this.emotion = emotion;
        this.date = DateTime.Now;
        //InfoList = new List<Info>();
        //this[index++] = this;
        InfoList.Add(this);
        index++;
    }

    public Info(String eventName)
    {
        this.eventName = eventName;
        this.date = DateTime.Now;
        this.emotion = Emotion.UNKNOWN;
        InfoList.Add(this);
        index++;
    }


    //ignore this one it's only for one purpose but without it nothing works :)
    public Info(int i)
    {
        this.eventName = "";
        this.date = DateTime.Now;
        this.emotion = Emotion.UNKNOWN;
    }

    public Info this[int index]
    {
        get
        {
            return InfoList[index];
        }
        set
        {
            if (index < InfoList.Count)
            {
                InfoList[index] = value;
            }
        }
    }

    public bool Equals(Info other)
    {
        return (this.eventName == other.eventName);

    }

    public int CompareTo(Info other)
    {
        if (other.date < this.date)
        {
            return -1;
        } else if (other.date == this.date)
        {
            return 0;
        } else
        {
            return 1;
        }
    }
}
