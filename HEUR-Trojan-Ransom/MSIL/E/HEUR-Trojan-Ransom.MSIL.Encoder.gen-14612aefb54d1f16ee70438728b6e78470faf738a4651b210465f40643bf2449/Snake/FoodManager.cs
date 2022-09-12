using System;
using System.Collections.Generic;
using System.Drawing;

namespace Snake;

internal class FoodManager
{
	private const int m_CircleRadius = 20;

	private Random r = new Random();

	private List<FoodPellet> m_FoodPellets = new List<FoodPellet>();

	private int m_GameWidth;

	private int m_GameHeight;

	public FoodManager(int GameWidth, int GameHeight)
	{
		m_GameWidth = GameWidth;
		m_GameHeight = GameHeight;
	}

	public void Draw(Graphics Canvas)
	{
		Brush blueViolet = Brushes.get_BlueViolet();
		foreach (FoodPellet foodPellet in m_FoodPellets)
		{
			Point position = foodPellet.GetPosition();
			Canvas.FillEllipse(blueViolet, new Rectangle(position.X + 5, position.Y + 5, 10, 10));
		}
	}

	public void AddRandomFood()
	{
		int num = r.Next(m_GameWidth - 20);
		int num2 = r.Next(m_GameHeight - 20);
		int num3 = num / 20;
		int num4 = num2 / 20;
		num = num3 * 20;
		num2 = num4 * 20;
		m_FoodPellets.Add(new FoodPellet(num, num2));
	}

	public void AddRandomFood(int Amount)
	{
		for (int i = 0; i < Amount; i++)
		{
			AddRandomFood();
		}
	}

	public bool IsIntersectingRect(Rectangle rect, bool RemoveFood)
	{
		foreach (FoodPellet foodPellet in m_FoodPellets)
		{
			Point position = foodPellet.GetPosition();
			if (rect.IntersectsWith(new Rectangle(position.X, position.Y, 20, 20)))
			{
				if (RemoveFood)
				{
					m_FoodPellets.Remove(foodPellet);
				}
				return true;
			}
		}
		return false;
	}
}
