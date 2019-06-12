using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    int Mask = 0;
    public Allergies(int mask)
    {
        Mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        Allergen[] allerList = (Allergen[])Enum.GetValues(typeof(Allergen));
        for(int i = 0; i < 8; i++)
        {
            if(((Mask&(1<<i)) != 0) && allerList[i] == allergen)return true;
        }
        return false;
    }

    public Allergen[] List()
    {
        List<Allergen> res = new List<Allergen>();
        Allergen[] allerList = (Allergen[])Enum.GetValues(typeof(Allergen));
        foreach(Allergen aller in allerList)
        {
            if(IsAllergicTo(aller))
            {
                res.Add(aller);
            }
        }
        return res.ToArray();
    }
}