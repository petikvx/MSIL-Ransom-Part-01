using System;
using System.Collections.Generic;

namespace snake;

[Serializable]
public class ObjectToSerialize
{
	public int score;

	public List<Position> myList;

	public List<Position> myWalls;

	public Position myApple;

	public ObjectToSerialize()
	{
		score = 0;
		myList = new List<Position>();
		myWalls = new List<Position>();
	}
}
