using System.Collections.Generic;
using System.Drawing;

namespace VanillaStub.Helpers.Services.StreamLibrary.src;

public static class Extensions
{
	public static SortedList<int, SortedList<int, Rectangle>> RectanglesTo2D(this Rectangle[] rects)
	{
		SortedList<int, SortedList<int, Rectangle>> sortedList = new SortedList<int, SortedList<int, Rectangle>>();
		for (int i = 0; i < rects.Length; i++)
		{
			if (!sortedList.ContainsKey(rects[i].Y))
			{
				sortedList.Add(rects[i].Y, new SortedList<int, Rectangle>());
			}
			if (!sortedList[rects[i].Y].ContainsKey(rects[i].X))
			{
				sortedList[rects[i].Y].Add(rects[i].X, rects[i]);
			}
		}
		return sortedList;
	}

	public static SortedList<int, SortedList<int, Rectangle>> Rectangle2DToRows(this SortedList<int, SortedList<int, Rectangle>> Rects)
	{
		SortedList<int, SortedList<int, Rectangle>> sortedList = new SortedList<int, SortedList<int, Rectangle>>();
		for (int i = 0; i < Rects.Values.Count; i++)
		{
			if (!sortedList.ContainsKey(Rects.Values[i].Values[0].Y))
			{
				sortedList.Add(Rects.Values[i].Values[0].Y, new SortedList<int, Rectangle>());
			}
			if (!sortedList[Rects.Values[i].Values[0].Y].ContainsKey(Rects.Values[i].Values[0].X))
			{
				sortedList[Rects.Values[i].Values[0].Y].Add(Rects.Values[i].Values[0].X, Rects.Values[i].Values[0]);
			}
			Rectangle value = Rects.Values[i].Values[0];
			for (int j = 1; j < Rects.Values[i].Values.Count; j++)
			{
				Rectangle rectangle = Rects.Values[i].Values[j];
				Rectangle rectangle2 = sortedList[value.Y].Values[sortedList[value.Y].Count - 1];
				if (rectangle2.IntersectsWith(new Rectangle(rectangle.X - 1, rectangle.Y, rectangle.Width, rectangle.Height)))
				{
					sortedList[value.Y][rectangle2.X] = new Rectangle(rectangle2.X, rectangle2.Y, rectangle2.Width + value.Width, rectangle2.Height);
					value = Rects.Values[i].Values[j];
				}
				else
				{
					value = Rects.Values[i].Values[j];
					sortedList[Rects.Values[i].Values[0].Y].Add(value.X, value);
				}
			}
		}
		return sortedList;
	}
}
