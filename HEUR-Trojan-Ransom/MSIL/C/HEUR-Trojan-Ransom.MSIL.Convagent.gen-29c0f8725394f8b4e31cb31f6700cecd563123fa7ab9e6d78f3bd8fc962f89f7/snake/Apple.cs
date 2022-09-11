using System;
using System.Windows.Forms;

namespace snake;

public class Apple : Element
{
	public Apple(int x, int y, object object1, int sizeElem, Panel panel1)
		: base(x, y, object1, sizeElem, panel1)
	{
	}

	public void changePosition(Snake s, AllWall walls, int width, int height)
	{
		Random random = new Random();
		int left = 0;
		int top = 0;
		int num = 0;
		while (num == 0)
		{
			left = 20 * random.Next(0, width / 20);
			top = 20 * random.Next(0, height / 20);
			int num2;
			for (num2 = 0; num2 < s.myList.Count; num2++)
			{
				num2 = s.myList.Count;
				if (num2 == s.myList.Count - 1)
				{
					num = 1;
				}
			}
			if (num == 1)
			{
				int num3;
				for (num3 = 0; num3 < walls.myWalls.Count; num3++)
				{
					num3 = walls.myWalls.Count;
					num = 0;
				}
			}
		}
		((Control)pictureBox1).set_Left(left);
		((Control)pictureBox1).set_Top(top);
	}
}
