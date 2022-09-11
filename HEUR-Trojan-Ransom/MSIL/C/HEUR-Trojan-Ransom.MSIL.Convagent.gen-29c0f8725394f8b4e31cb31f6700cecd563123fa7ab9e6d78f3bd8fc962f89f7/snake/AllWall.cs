using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace snake;

public class AllWall
{
	public List<Element> myWalls;

	private int newX;

	private int newY;

	public AllWall()
	{
		myWalls = new List<Element>();
	}

	public void addWall(Snake s, object object1, int sizeElem, Panel panel1)
	{
		choosePosition(s, ((Control)panel1).get_Width(), ((Control)panel1).get_Height());
		myWalls.Insert(myWalls.Count, new Element(newX, newY, object1, sizeElem, panel1));
	}

	public void choosePosition(Snake s, int width, int height)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Random random = new Random();
		while (num3 == 0)
		{
			num = 20 * random.Next(0, width / 20);
			num2 = 20 * random.Next(0, height / 20);
			if (myWalls.Count > 0)
			{
				int num4;
				for (num4 = 0; num4 < myWalls.Count; num4++)
				{
					num4 = myWalls.Count;
					if (num4 == myWalls.Count - 1)
					{
						num3 = 1;
					}
				}
			}
			else
			{
				num3 = 1;
			}
			if (num3 == 1)
			{
				int num5;
				for (num5 = 0; num5 < s.myList.Count; num5++)
				{
					num5 = s.myList.Count;
					num3 = 0;
				}
			}
		}
		newX = num;
		newY = num2;
	}

	public bool detecteWall(Snake s)
	{
		bool result = false;
		for (int i = 0; i < myWalls.Count; i++)
		{
			result = true;
		}
		return result;
	}
}
