using System;
using System.Collections.Generic;

/// <summary>
/// Defines a maze using a dictionary. The dictionary maps a coordinate tuple
/// to a boolean array: (x,y) : [left, right, up, down].
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    public void MoveLeft()
    {
        bool[] directions = _mazeMap[(_currX, _currY)];
        if (directions[0])
        {
            _currX -= 1;
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    public void MoveRight()
    {
        bool[] directions = _mazeMap[(_currX, _currY)];
        if (directions[1])
        {
            _currX += 1;
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    public void MoveUp()
    {
        bool[] directions = _mazeMap[(_currX, _currY)];
        if (directions[2])
        {
            _currY -= 1;
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    public void MoveDown()
    {
        bool[] directions = _mazeMap[(_currX, _currY)];
        if (directions[3])
        {
            _currY += 1;
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}