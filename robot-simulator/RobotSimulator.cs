using System;
using System.Linq;

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    public RobotSimulator(Direction direction, int x, int y)
    {
        this.Direction = direction;
        this.X = x;
        this.Y = y;
    }

    public Direction Direction
    {
        get; set;
    }

    public int X
    {
        get; set;
    }

    public int Y
    {
        get; set;
    }

    public void Move(string instructions)
    {
        foreach(char c in instructions)
        {
            fn(c);
        }
    }
    public void fn(char c)
    {
        if(c == 'A')
        {
            if(this.Direction == Direction.North)
            {
                this.Y += 1;
            }
            else if(this.Direction == Direction.South){
                this.Y -= 1;
            }
            else if(this.Direction == Direction.East){
                this.X += 1;
            }
            else{
                this.X -= 1;
            }
        }
        else if(c == 'R')
        {
            if(this.Direction == Direction.North)
            {
                this.Direction = Direction.East;   
            }
            else if(this.Direction == Direction.South){
                this.Direction = Direction.West;
            }
            else if(this.Direction == Direction.East){
                this.Direction = Direction.South;
            }
            else{
                this.Direction = Direction.North;
            }
        }
        else
        {
            if(this.Direction == Direction.North)
            {
                this.Direction = Direction.West;   
            }
            else if(this.Direction == Direction.South){
                this.Direction = Direction.East;
            }
            else if(this.Direction == Direction.East){
                this.Direction = Direction.North;
            }
            else{
                this.Direction = Direction.South;
            }
        }
    }
}