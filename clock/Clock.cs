using System;

public class Clock
{
    public Clock(int hours, int minutes)
    {
        var time = hours*60 + minutes;
		if(time < 0){
		    hours = (int)Math.Floor(time/60.0);
		}
		else {hours = time/60;}
		
		hours = (hours%24 + 24)%24;
		minutes = (minutes%60 + 60)%60;

        this.Hours = hours;
        this.Minutes = minutes;
    }

    public int Hours
    {
        get; set;
    }

    public int Minutes
    {
        get; set;
    }

    public Clock Add(int minutesToAdd)
    {
        Clock res = new Clock(this.Hours, this.Minutes + minutesToAdd);
        return res;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        Clock res = new Clock(this.Hours, this.Minutes - minutesToSubtract);
        return res;
    }

    public override string ToString()
    {
        var res = $"{Hours.ToString("D2")}:{Minutes.ToString("D2")}";
        return res;
    }

    public override bool Equals(object obj)
    {
        var item = obj as Clock;

        if (item == null)
        {
            return false;
        }

        return this.Hours.Equals(item.Hours) && this.Minutes.Equals(item.Minutes);
    }
}