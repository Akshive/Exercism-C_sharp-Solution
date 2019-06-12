using System;

public class SpaceAge
{
    private double earthAge
    {get; set;}
    public SpaceAge(int seconds)
    {
        double fac = 31557600;
        earthAge = seconds/fac;
    }

    public double OnEarth()
    {
        return earthAge;
    }

    public double OnMercury()
    {
        return earthAge/0.2408467;
    }

    public double OnVenus()
    {
        return earthAge/0.61519726;
    }

    public double OnMars()
    {
        return earthAge/1.8808158;
    }

    public double OnJupiter()
    {
        return earthAge/11.862615;
    }

    public double OnSaturn()
    {
        return earthAge/29.447498;
    }

    public double OnUranus()
    {
        return earthAge/84.016846;
    }

    public double OnNeptune()
    {
        return earthAge/164.79132;
    }
}