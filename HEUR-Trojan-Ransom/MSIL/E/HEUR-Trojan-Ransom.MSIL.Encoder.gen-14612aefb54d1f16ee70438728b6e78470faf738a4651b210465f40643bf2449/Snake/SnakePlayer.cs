using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Snake;

internal class SnakePlayer
{
	private const int m_CircleRadius = 20;

	private List<BodyPart> m_SnakeParts = new List<BodyPart>();

	private Direction m_MoveDirection = Direction.none;

	private int m_PendingSegments;

	private Snake GameForm = null;

	public SnakePlayer(Snake Form)
	{
		m_SnakeParts.Add(new BodyPart(100, 200, Direction.right));
		m_SnakeParts.Add(new BodyPart(80, 200, Direction.right));
		m_SnakeParts.Add(new BodyPart(60, 200, Direction.right));
		m_MoveDirection = Direction.right;
		m_PendingSegments = 0;
		GameForm = Form;
	}

	public void AddBodySegments(int Number)
	{
		m_PendingSegments += Number;
	}

	public void MovePlayer()
	{
		if (m_PendingSegments > 0)
		{
			Point position = m_SnakeParts.Last().GetPosition();
			m_SnakeParts.Add(new BodyPart(position.X, position.Y));
			m_PendingSegments--;
		}
		m_SnakeParts[0].m_Dir = m_MoveDirection;
		for (int num = m_SnakeParts.Count - 1; num >= 0; num--)
		{
			switch (m_SnakeParts[num].m_Dir)
			{
			case Direction.left:
				m_SnakeParts[num].AddPosition(new Point(-20, 0));
				break;
			case Direction.right:
				m_SnakeParts[num].AddPosition(new Point(20, 0));
				break;
			case Direction.up:
				m_SnakeParts[num].AddPosition(new Point(0, -20));
				break;
			case Direction.down:
				m_SnakeParts[num].AddPosition(new Point(0, 20));
				break;
			}
			if (num > 0)
			{
				m_SnakeParts[num].m_Dir = m_SnakeParts[num - 1].m_Dir;
			}
		}
		if (IsSelfIntersecting())
		{
			OnHitSelf();
		}
	}

	public bool IsSelfIntersecting()
	{
		for (int i = 0; i < m_SnakeParts.Count; i++)
		{
			for (int j = 0; j < m_SnakeParts.Count; j++)
			{
				if (i != j)
				{
					BodyPart bodyPart = m_SnakeParts[i];
					BodyPart bodyPart2 = m_SnakeParts[j];
					if (new Rectangle(bodyPart.GetPosition().X, bodyPart.GetPosition().Y, 20, 20).IntersectsWith(new Rectangle(bodyPart2.GetPosition().X, bodyPart2.GetPosition().Y, 20, 20)))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	public void SetDirection(Direction Dir)
	{
		if ((m_MoveDirection != 0 || Dir != Direction.right) && (m_MoveDirection != Direction.right || Dir != 0) && (m_MoveDirection != Direction.up || Dir != Direction.down) && (m_MoveDirection != Direction.down || Dir != Direction.up))
		{
			m_MoveDirection = Dir;
		}
	}

	public bool IsIntersectingRect(Rectangle rect)
	{
		foreach (BodyPart snakePart in m_SnakeParts)
		{
			Point position = snakePart.GetPosition();
			if (rect.IntersectsWith(new Rectangle(position.X, position.Y, 20, 20)))
			{
				return true;
			}
		}
		return false;
	}

	public void OnHitWall(Direction WhichWall)
	{
		GameForm.ToggleTimer();
		GameForm.ResetGame();
	}

	public void Draw(Graphics canvas)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		Random random = new Random();
		SolidBrush val = new SolidBrush(Color.FromArgb(random.Next(100, 256), 0, 0));
		List<Rectangle> rects = GetRects();
		foreach (Rectangle item in rects)
		{
			canvas.FillEllipse((Brush)(object)val, item);
		}
	}

	public void OnHitSelf()
	{
		GameForm.ToggleTimer();
		GameForm.ResetGame();
	}

	public List<Rectangle> GetRects()
	{
		List<Rectangle> list = new List<Rectangle>();
		foreach (BodyPart snakePart in m_SnakeParts)
		{
			Point position = snakePart.GetPosition();
			list.Add(new Rectangle(position.X, position.Y, 20, 20));
		}
		return list;
	}
}
