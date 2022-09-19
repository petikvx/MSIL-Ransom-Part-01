using System;
using System.Drawing;
using System.Windows.Forms;

namespace DnD5eSpellSorter;

public class Grid
{
	public static int TOP_OFFSET = 80;

	public static int GAP = -1;

	private Tile[,] gridOfTiles;

	private Timer timer;

	private bool isMoving = false;

	public bool IsMoving
	{
		get
		{
			return isMoving;
		}
		set
		{
			isMoving = value;
			if (isMoving)
			{
				timer.Start();
			}
			else
			{
				timer.Stop();
			}
		}
	}

	public Timer Timer
	{
		get
		{
			return timer;
		}
		set
		{
			timer = value;
		}
	}

	public Tile this[int index1, int index2]
	{
		get
		{
			return gridOfTiles[index1, index2];
		}
		set
		{
			gridOfTiles[index1, index2] = value;
		}
	}

	public Grid(Form myForm, int nbrColumns, int nbrRows, string[] tileTypesSaved, int leftOffset)
	{
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		gridOfTiles = new Tile[nbrColumns, nbrRows];
		for (int i = 0; i < nbrColumns; i++)
		{
			for (int j = 0; j < nbrRows; j++)
			{
				gridOfTiles[i, j] = new Tile();
				((Control)gridOfTiles[i, j]).set_Location(new Point(i * (Tile.WIDTH + GAP) + leftOffset, j * (Tile.HEIGHT + GAP) + TOP_OFFSET));
				if (tileTypesSaved != null)
				{
					int num = int.Parse(tileTypesSaved[i * nbrRows + j]);
					if (num != -1)
					{
						gridOfTiles[i, j].AssignTyleType(num);
					}
				}
				if (myForm is PlayForm)
				{
					((PictureBox)gridOfTiles[i, j]).set_BorderStyle((BorderStyle)0);
				}
				gridOfTiles[i, j].Column = i;
				gridOfTiles[i, j].Row = j;
				((Control)gridOfTiles[i, j]).BringToFront();
				((Control)myForm).get_Controls().Add((Control)(object)gridOfTiles[i, j]);
			}
		}
		timer = new Timer();
		timer.set_Interval(150);
		timer.set_Enabled(true);
		timer.Stop();
	}

	public int GetLength(int dim)
	{
		return dim switch
		{
			0 => gridOfTiles.GetLength(0), 
			1 => gridOfTiles.GetLength(1), 
			_ => throw new Exception("The parameter is outside the bounds"), 
		};
	}

	public void DeleteGrid(Form myForm)
	{
		for (int i = 0; i < gridOfTiles.GetLength(0); i++)
		{
			for (int j = 0; j < gridOfTiles.GetLength(1); j++)
			{
				((Control)myForm).get_Controls().Remove((Control)(object)gridOfTiles[i, j]);
			}
		}
	}
}
