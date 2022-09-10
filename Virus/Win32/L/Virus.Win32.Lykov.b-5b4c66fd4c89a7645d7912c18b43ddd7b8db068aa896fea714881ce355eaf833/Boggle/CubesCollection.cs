using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Boggle;

public class CubesCollection : CollectionBase
{
	public enum StateOfCubes
	{
		Clear,
		Normal,
		Spinning,
		ZoomSpinning,
		Text
	}

	private string clsWordToShow;

	private StateOfCubes clsCubesState;

	private string clsDisplayText;

	private PictureBox clsCubesPicBox;

	private bool clsDisplayTextFadeOut;

	private bool clsDisplayTextStartUp;

	private int clsDisplayTextMaxSize;

	private int clsDisplayPosition;

	private Thread SpinCubesThread;

	private Thread ScrambleCubesThread;

	private bool clsCubesAreSpinning;

	private bool clsCubesAreScrambling;

	private bool clsKillThread;

	[SpecialName]
	private double _0024STATIC_0024DrawCubes_0024202112D112C_0024Angle;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024DrawCubes_0024202112D112C_0024Angle_0024Init;

	[SpecialName]
	private double _0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact_0024Init;

	[SpecialName]
	private double _0024STATIC_0024DrawCubes_0024202112D112C_0024FontSize;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue_0024Init;

	[SpecialName]
	private int _0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue;

	public bool CubesAreScrambling
	{
		get
		{
			return clsCubesAreScrambling;
		}
		set
		{
			clsCubesAreScrambling = value;
		}
	}

	public bool CubesAreSpinning
	{
		get
		{
			return clsCubesAreSpinning;
		}
		set
		{
			clsCubesAreSpinning = value;
		}
	}

	public int DisplayPosition
	{
		get
		{
			return clsDisplayPosition;
		}
		set
		{
			clsDisplayPosition = value;
		}
	}

	public int DisplayTextMaxSize
	{
		get
		{
			return clsDisplayTextMaxSize;
		}
		set
		{
			clsDisplayTextMaxSize = value;
		}
	}

	public bool DisplayTextStartUp
	{
		get
		{
			return clsDisplayTextStartUp;
		}
		set
		{
			clsDisplayTextStartUp = value;
		}
	}

	public bool DisplayTextFadeOut
	{
		get
		{
			return clsDisplayTextFadeOut;
		}
		set
		{
			clsDisplayTextFadeOut = value;
		}
	}

	public PictureBox CubesPicBox
	{
		get
		{
			return clsCubesPicBox;
		}
		set
		{
			clsCubesPicBox = value;
		}
	}

	public string DisplayText
	{
		get
		{
			return clsDisplayText;
		}
		set
		{
			clsDisplayText = value;
		}
	}

	public StateOfCubes CubesState
	{
		get
		{
			return clsCubesState;
		}
		set
		{
			clsCubesState = value;
		}
	}

	public Cube this[int Index] => (Cube)List[Index];

	public string WordToShow
	{
		get
		{
			return clsWordToShow;
		}
		set
		{
			clsWordToShow = value;
		}
	}

	public CubesCollection()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle_0024Init = new StaticLocalInitFlag();
		_0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact_0024Init = new StaticLocalInitFlag();
		_0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue_0024Init = new StaticLocalInitFlag();
	}

	public void Add(Cube Cube)
	{
		List.Add(Cube);
	}

	public void Remove(Cube Cube)
	{
		if (List.Contains(Cube))
		{
			List.Remove(Cube);
		}
	}

	public void DrawCubes(PaintEventArgs e, StateOfCubes State)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected O, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected I4, but got Unknown
		Bitmap val = new Bitmap(modGlobal.AppPath + "\\CubesUp.jpg");
		int num = 10;
		if (_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle_0024Init.State != 1)
		{
			Monitor.Enter(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle_0024Init);
			try
			{
				if (_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle_0024Init.State == 0)
				{
					_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle_0024Init.State = 2;
					_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle = -0.777;
				}
				else if (_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle_0024Init.State = 1;
				Monitor.Exit(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle_0024Init);
			}
		}
		checked
		{
			if (_0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact_0024Init.State != 1)
			{
				Monitor.Enter(_0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact_0024Init);
				try
				{
					if (_0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact_0024Init.State == 0)
					{
						_0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact_0024Init.State = 2;
						_0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact = ((Image)val).get_Height() * -1;
					}
					else if (_0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact_0024Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					_0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact_0024Init.State = 1;
					Monitor.Exit(_0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact_0024Init);
				}
			}
			if (_0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue_0024Init.State != 1)
			{
				Monitor.Enter(_0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue_0024Init);
				try
				{
					if (_0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue_0024Init.State == 0)
					{
						_0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue_0024Init.State = 2;
						_0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue = 1;
					}
					else if (_0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue_0024Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					_0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue_0024Init.State = 1;
					Monitor.Exit(_0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue_0024Init);
				}
			}
			double num5 = default(double);
			double num6 = default(double);
			double a = default(double);
			double a2 = default(double);
			double a3 = default(double);
			double a4 = default(double);
			switch (State)
			{
			case StateOfCubes.Clear:
				_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle = -0.777;
				_0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact = ((Image)val).get_Height() * -1;
				_0024STATIC_0024DrawCubes_0024202112D112C_0024FontSize = 0.0;
				_0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue = 1;
				clsCubesPicBox.set_Image((Image)null);
				break;
			case StateOfCubes.Normal:
			{
				_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle = -0.777;
				_0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact = ((Image)val).get_Height() * -1;
				_0024STATIC_0024DrawCubes_0024202112D112C_0024FontSize = 0.0;
				_0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue = 1;
				double num4 = Math.Sqrt(((Image)val).get_Width() * ((Image)val).get_Width() + ((Image)val).get_Height() * ((Image)val).get_Height()) / 2.0;
				num5 = (double)num + (num4 * 2.0 - (double)((Image)val).get_Width()) / 2.0;
				num6 = (num4 * 2.0 - (double)((Image)val).get_Height()) / 2.0;
				a = num5 + (double)((Image)val).get_Width();
				a2 = (num4 * 2.0 - (double)((Image)val).get_Height()) / 2.0;
				a3 = (double)num + (num4 * 2.0 - (double)((Image)val).get_Width()) / 2.0;
				a4 = num6 + (double)((Image)val).get_Height();
				break;
			}
			case StateOfCubes.Spinning:
			{
				double num4 = Math.Sqrt(((Image)val).get_Width() * ((Image)val).get_Width() + ((Image)val).get_Height() * ((Image)val).get_Height()) / 2.0;
				num5 = (double)num + Math.Cos(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle) * num4 + num4;
				num6 = num4 - Math.Sin(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle) * num4;
				a = Math.Cos(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle + 1.6) * num4 + num4;
				a2 = num4 - Math.Sin(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle + 1.6) * num4;
				a3 = (double)num + Math.Cos(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle - 1.6) * num4 + num4;
				a4 = num4 - Math.Sin(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle - 1.6) * num4;
				_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle += 0.3;
				break;
			}
			case StateOfCubes.ZoomSpinning:
			{
				double num4 = Math.Sqrt(((double)((Image)val).get_Width() + _0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact) * ((double)((Image)val).get_Width() + _0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact) + ((double)((Image)val).get_Height() + _0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact) * ((double)((Image)val).get_Height() + _0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact)) / 2.0;
				num5 = (double)num + Math.Cos(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle) * num4 + num4;
				num6 = num4 - Math.Sin(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle) * num4;
				a = (double)num + Math.Cos(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle + 1.6) * num4 + num4;
				a2 = num4 - Math.Sin(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle + 1.6) * num4;
				a3 = (double)num + Math.Cos(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle - 1.6) * num4 + num4;
				a4 = num4 - Math.Sin(_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle - 1.6) * num4;
				_0024STATIC_0024DrawCubes_0024202112D112C_0024Angle += 0.3;
				_0024STATIC_0024DrawCubes_0024202112D112C_0024ZoomFact += 2.0;
				break;
			}
			case StateOfCubes.Text:
				try
				{
					GraphicsPath val2 = new GraphicsPath();
					Rectangle rectangle = new Rectangle(0, 0, ((Control)clsCubesPicBox).get_Width(), ((Control)clsCubesPicBox).get_Height());
					LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.LightBlue, Color.DarkBlue, (LinearGradientMode)1);
					if ((_0024STATIC_0024DrawCubes_0024202112D112C_0024FontSize > (double)(int)Math.Round((double)clsDisplayTextMaxSize / 2.0)) & clsDisplayTextFadeOut)
					{
						_0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue *= -1;
					}
					_0024STATIC_0024DrawCubes_0024202112D112C_0024FontSize += _0024STATIC_0024DrawCubes_0024202112D112C_0024FontAddValue;
					Font val4 = new Font("Arial", (float)_0024STATIC_0024DrawCubes_0024202112D112C_0024FontSize, (FontStyle)0, (GraphicsUnit)2, (byte)1);
					SizeF sizeF = default(SizeF);
					Graphics graphics = e.get_Graphics();
					string text = clsDisplayText;
					StringFormat val5 = new StringFormat((StringFormatFlags)1);
					int num2 = Strings.Len(clsDisplayText);
					int num3 = 1;
					sizeF = graphics.MeasureString(text, val4, default(SizeF), val5, ref num2, ref num3);
					string text2 = clsDisplayText;
					FontFamily fontFamily = val4.get_FontFamily();
					FontStyle style = val4.get_Style();
					float size = val4.get_Size();
					PointF pointF = new PointF((float)((double)rectangle.Width / 2.0 - (double)(sizeF.Width / 2f)), (float)((double)rectangle.Height / 2.0 - (double)(sizeF.Height / 2f) + (double)clsDisplayPosition));
					val2.AddString(text2, fontFamily, unchecked((int)style), size, pointF, StringFormat.get_GenericDefault());
					e.get_Graphics().FillPath((Brush)(object)val3, val2);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					clsCubesState = StateOfCubes.Clear;
					((Control)clsCubesPicBox).Refresh();
					ProjectData.ClearProjectError();
				}
				break;
			}
			Point[] array = new Point[3];
			ref Point reference = ref array[0];
			Point point = (reference = new Point((int)Math.Round(num5), (int)Math.Round(num6)));
			ref Point reference2 = ref array[1];
			Point point2 = (reference2 = new Point((int)Math.Round(a), (int)Math.Round(a2)));
			ref Point reference3 = ref array[2];
			Point point3 = (reference3 = new Point((int)Math.Round(a3), (int)Math.Round(a4)));
			Point[] array2 = array;
			e.get_Graphics().DrawImage((Image)(object)val, array2);
		}
	}

	private void ShowSpinCubes()
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = modGlobal.Cubes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				modGlobal.myCube = (Cube)enumerator.Current;
				((Control)modGlobal.myCube.CubeLabel).set_Visible(false);
				modGlobal.myCube.SetRndCubeLetter();
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		int num = 1;
		do
		{
			if (!clsKillThread)
			{
				Thread.Sleep(1);
				clsCubesState = StateOfCubes.ZoomSpinning;
				((Control)clsCubesPicBox).Refresh();
				num = checked(num + 1);
				continue;
			}
			clsCubesAreSpinning = false;
			clsKillThread = false;
			return;
		}
		while (num <= 130);
		modGlobal.Cubes.CubesState = StateOfCubes.Normal;
		((Control)clsCubesPicBox).Refresh();
		IEnumerator enumerator2 = default(IEnumerator);
		try
		{
			enumerator2 = modGlobal.Cubes.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				modGlobal.myCube = (Cube)enumerator2.Current;
				((Control)modGlobal.myCube.CubeLabel).set_Visible(true);
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				((IDisposable)enumerator2).Dispose();
			}
		}
		clsCubesAreSpinning = false;
	}

	public void ShowSpinStartUp()
	{
		SpinCubesThread = new Thread(ShowSpinCubes);
		clsCubesAreSpinning = true;
		clsKillThread = false;
		SpinCubesThread.Start();
	}

	private void HandleScrambleCubes()
	{
		long num = 1L;
		do
		{
			if (!clsKillThread)
			{
				Thread.Sleep(1);
				((Control)clsCubesPicBox).Refresh();
				num = checked(num + 1L);
				continue;
			}
			clsCubesAreScrambling = false;
			clsKillThread = false;
			return;
		}
		while (num <= 100L);
		clsCubesAreScrambling = false;
	}

	public void ScrambleCubes()
	{
		ScrambleCubesThread = new Thread(HandleScrambleCubes);
		clsCubesAreScrambling = true;
		clsKillThread = false;
		ScrambleCubesThread.Start();
	}

	public void KillCubeThreads()
	{
		clsKillThread = true;
	}
}
