using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Boggle;

public class Cube
{
	[AccessedThroughProperty("clsPicCubeDown")]
	private PictureBox _clsPicCubeDown;

	private CircleLabel clsCubeLabel;

	private bool clsIsBack;

	public long CubeTopHeight
	{
		get
		{
			return ((Control)clsCubeLabel).get_Height();
		}
		set
		{
			((Control)clsCubeLabel).set_Height(checked((int)value));
		}
	}

	public Color CubeHighLight
	{
		get
		{
			return clsCubeLabel.CubeHighLight;
		}
		set
		{
			clsCubeLabel.CubeHighLight = value;
		}
	}

	public object CubeTopRadius
	{
		get
		{
			return clsCubeLabel.CubeTopRadius;
		}
		set
		{
			clsCubeLabel.CubeTopRadius = LongType.FromObject(value);
		}
	}

	public long CubeTopWidth
	{
		get
		{
			return ((Control)clsCubeLabel).get_Width();
		}
		set
		{
			((Control)clsCubeLabel).set_Width(checked((int)value));
		}
	}

	public string CubeLetter
	{
		get
		{
			return clsCubeLabel.CubeText;
		}
		set
		{
			clsCubeLabel.CubeText = value;
		}
	}

	public CircleLabel CubeLabel
	{
		get
		{
			return clsCubeLabel;
		}
		set
		{
			clsCubeLabel = value;
		}
	}

	private virtual PictureBox clsPicCubeDown
	{
		get
		{
			return _clsPicCubeDown;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			if (_clsPicCubeDown != null)
			{
				((Control)_clsPicCubeDown).remove_Paint(new PaintEventHandler(clspicCubeDown_Paint));
			}
			_clsPicCubeDown = value;
			if (_clsPicCubeDown != null)
			{
				((Control)_clsPicCubeDown).add_Paint(new PaintEventHandler(clspicCubeDown_Paint));
			}
		}
	}

	public bool IsBack
	{
		get
		{
			return clsIsBack;
		}
		set
		{
			clsIsBack = value;
		}
	}

	public PictureBox CubeDownPic
	{
		get
		{
			return clsPicCubeDown;
		}
		set
		{
			clsPicCubeDown = value;
		}
	}

	public Color CubeTextColor
	{
		get
		{
			return clsCubeLabel.CubeTextColor;
		}
		set
		{
			clsCubeLabel.CubeTextColor = value;
		}
	}

	public long CubeTopTop
	{
		get
		{
			return ((Control)clsCubeLabel).get_Top();
		}
		set
		{
			((Control)clsCubeLabel).set_Top(checked((int)value));
		}
	}

	public long CubeTopLeft
	{
		get
		{
			return ((Control)clsCubeLabel).get_Left();
		}
		set
		{
			((Control)clsCubeLabel).set_Left(checked((int)value));
		}
	}

	public Cube()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		clsCubeLabel = new CircleLabel();
		clsPicCubeDown = new PictureBox();
	}

	public void SetRndCubeLetter()
	{
		string text = "AABCDEEFGHIIJKLMNOOPQRSTUUVWXYZ";
		VBMath.Randomize();
		checked
		{
			int num = (int)Math.Round(Conversion.Int((float)Strings.Len(text) * VBMath.Rnd() + 1f));
			string text2 = Strings.Mid(text, num, 1);
			long num2 = num * 100;
			for (long num3 = 1L; num3 <= num2; num3++)
			{
				VBMath.Randomize();
				int num4 = (int)Math.Round(Conversion.Int((float)Strings.Len(text) * VBMath.Rnd() + 1f));
				text2 = Strings.Mid(text, num4, 1);
			}
			if (StringType.StrCmp(text2, "Q", false) == 0)
			{
				text2 = "Qu";
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = modGlobal.Cubes.GetEnumerator();
					while (enumerator.MoveNext())
					{
						modGlobal.myCube = (Cube)enumerator.Current;
						if (StringType.StrCmp(modGlobal.myCube.CubeLetter, "Qu", false) == 0)
						{
							text2 = "R";
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			CubeLetter = text2;
		}
	}

	private void clspicCubeDown_Paint(object sender, PaintEventArgs e)
	{
		checked
		{
			long num = (long)Math.Round(DoubleType.FromString(Strings.Mid(StringType.FromObject(((Control)CubeLabel).get_Tag()), 1, 1)) * 70.0 * -1.0);
			long num2 = (long)Math.Round(DoubleType.FromString(Strings.Mid(StringType.FromObject(((Control)CubeLabel).get_Tag()), 2, 1)) * 70.0 * -1.0);
			Image val = Image.FromFile(modGlobal.AppPath + "\\CubesDown.jpg");
			Point point = new Point((int)num, (int)num2);
			Point point2 = new Point((int)(283L + num), (int)num2);
			Point point3 = new Point((int)num, (int)(283L + num2));
			Point[] array = new Point[3] { point, point2, point3 };
			e.get_Graphics().DrawImage(val, array);
		}
	}

	public void ShowClick()
	{
		checked
		{
			((Control)clsPicCubeDown).set_Width((int)Math.Round(74.0 - DoubleType.FromString(Strings.Mid(StringType.FromObject(((Control)clsCubeLabel).get_Tag()), 1, 1))));
			((Control)clsPicCubeDown).set_Height((int)Math.Round(75.0 - DoubleType.FromString(Strings.Mid(StringType.FromObject(((Control)clsCubeLabel).get_Tag()), 2, 1))));
			((Control)clsPicCubeDown).set_Left(((Control)clsCubeLabel).get_Left() - 10);
			((Control)clsPicCubeDown).set_Top((int)Math.Round((double)((Control)clsCubeLabel).get_Top() - 9.6));
			CubeTopRadius = 50;
			((Control)clsPicCubeDown).Show();
			SetCubeTopPos();
		}
	}

	private void SetCubeTopPos()
	{
		object tag = ((Control)clsCubeLabel).get_Tag();
		checked
		{
			if (ObjectType.ObjTst(tag, (object)"00", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() + 7);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() + 6);
			}
			else if (ObjectType.ObjTst(tag, (object)"10", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() + 7);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() + 3);
			}
			else if (ObjectType.ObjTst(tag, (object)"20", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() + 7);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() - 1);
			}
			else if (ObjectType.ObjTst(tag, (object)"30", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() + 7);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() - 6);
			}
			else if (ObjectType.ObjTst(tag, (object)"01", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() + 4);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() + 7);
			}
			else if (ObjectType.ObjTst(tag, (object)"11", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() + 4);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() + 3);
			}
			else if (ObjectType.ObjTst(tag, (object)"21", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() + 4);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() - 1);
			}
			else if (ObjectType.ObjTst(tag, (object)"31", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() + 3);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() - 5);
			}
			else if (ObjectType.ObjTst(tag, (object)"02", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() + 8);
			}
			else if (ObjectType.ObjTst(tag, (object)"12", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() - 1);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() + 3);
			}
			else if (ObjectType.ObjTst(tag, (object)"22", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() - 1);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() - 1);
			}
			else if (ObjectType.ObjTst(tag, (object)"32", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() - 1);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() - 5);
			}
			else if (ObjectType.ObjTst(tag, (object)"03", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() - 5);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() + 8);
			}
			else if (ObjectType.ObjTst(tag, (object)"13", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() - 5);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() + 3);
			}
			else if (ObjectType.ObjTst(tag, (object)"23", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() - 5);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() - 1);
			}
			else if (ObjectType.ObjTst(tag, (object)"33", false) == 0)
			{
				CircleLabel circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Top(((Control)circleLabel).get_Top() - 5);
				circleLabel = clsCubeLabel;
				((Control)circleLabel).set_Left(((Control)circleLabel).get_Left() - 5);
			}
		}
	}
}
