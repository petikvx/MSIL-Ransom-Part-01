using System;
using System.Timers;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace F0;

internal class dp
{
	private Dd yD;

	internal static dp qX;

	public void Im(Dd dd_0)
	{
		int num = 1;
		while (true)
		{
			yD = dd_0;
			int num2 = 0;
			if (!gP())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			Timer timer = new Timer();
			timer.Elapsed += XH;
			timer.Interval = 2000.0;
			timer.Enabled = true;
			return;
		}
	}

	private void XH(object sender, ElapsedEventArgs e)
	{
		((DispatcherObject)yD).get_Dispatcher().BeginInvoke((Delegate)new Action(ha), (DispatcherPriority)4, new object[0]);
	}

	private void ha()
	{
		if (b2.fgA == ((Shape)yD.light1).get_Fill())
		{
			((Shape)yD.light1).set_Fill(b2.rgs);
			((Shape)yD.light2).set_Fill(b2.fgA);
			((Shape)yD.light3).set_Fill(b2.fgA);
			((Shape)yD.light4).set_Fill(b2.rgs);
			((Shape)yD.light5).set_Fill(b2.fgA);
			goto IL_00b3;
		}
		Im(yD.light1, b2.fgA);
		((Shape)yD.light2).set_Fill(b2.rgs);
		goto IL_0353;
		IL_0117:
		int num = default(int);
		int num2 = num;
		goto IL_02b5;
		IL_019e:
		((Shape)yD.light9).set_Fill(b2.fgA);
		((Shape)yD.light10).set_Fill(b2.rgs);
		Im(yD.light11, b2.fgA);
		((Shape)yD.light12).set_Fill(b2.rgs);
		num2 = 0;
		if (!gP())
		{
			goto IL_02b5;
		}
		goto IL_03e3;
		IL_0353:
		((Shape)yD.light3).set_Fill(b2.rgs);
		((Shape)yD.light4).set_Fill(b2.fgA);
		goto IL_0312;
		IL_0312:
		Im(yD.light5, b2.rgs);
		((Shape)yD.light6).set_Fill(b2.fgA);
		Im(yD.light7, b2.fgA);
		goto IL_02eb;
		IL_02eb:
		((Shape)yD.light8).set_Fill(b2.fgA);
		num2 = 3;
		if (Bp() == null)
		{
			goto IL_019e;
		}
		goto IL_02b5;
		IL_02b5:
		while (true)
		{
			switch (num2)
			{
			case 10:
				break;
			case 9:
				goto IL_0120;
			case 8:
				goto IL_019e;
			case 2:
				((Shape)yD.light15).set_Fill(b2.rgs);
				((Shape)yD.light16).set_Fill(b2.fgA);
				Im(yD.light17, b2.fgA);
				((Shape)yD.light18).set_Fill(b2.fgA);
				((Shape)yD.light19).set_Fill(b2.rgs);
				num2 = 1;
				if (gP())
				{
					continue;
				}
				goto case 1;
			case 1:
				Im(yD.light20, b2.rgs);
				((Shape)yD.light21).set_Fill(b2.rgs);
				num2 = 7;
				if (!gP())
				{
					continue;
				}
				goto case 7;
			case 4:
				goto IL_02eb;
			case 5:
				goto IL_0312;
			case 3:
				goto IL_0353;
			case 7:
				((Shape)yD.light22).set_Fill(b2.fgA);
				((Shape)yD.light23).set_Fill(b2.fgA);
				Im(yD.light24, b2.rgs);
				num = 6;
				goto case 6;
			case 6:
				((Shape)yD.light25).set_Fill(b2.fgA);
				return;
			default:
				goto IL_03e3;
			}
			break;
			IL_0120:
			((Shape)yD.light10).set_Fill(b2.fgA);
			((Shape)yD.light11).set_Fill(b2.rgs);
			((Shape)yD.light12).set_Fill(b2.fgA);
			((Shape)yD.light13).set_Fill(b2.fgA);
			((Shape)yD.light14).set_Fill(b2.fgA);
			num2 = 2;
			if (Bp() == null)
			{
				continue;
			}
			goto IL_0117;
		}
		goto IL_00b3;
		IL_00b3:
		((Shape)yD.light6).set_Fill(b2.rgs);
		((Shape)yD.light7).set_Fill(b2.rgs);
		((Shape)yD.light8).set_Fill(b2.rgs);
		Im(yD.light9, b2.rgs);
		num2 = 9;
		if (Bp() != null)
		{
			goto IL_0117;
		}
		goto IL_02b5;
		IL_03e3:
		Im(yD.light13, b2.rgs);
		((Shape)yD.light14).set_Fill(b2.rgs);
		((Shape)yD.light15).set_Fill(b2.fgA);
		((Shape)yD.light16).set_Fill(b2.rgs);
		((Shape)yD.light17).set_Fill(b2.rgs);
		((Shape)yD.light18).set_Fill(b2.rgs);
		((Shape)yD.light19).set_Fill(b2.fgA);
		((Shape)yD.light20).set_Fill(b2.fgA);
		((Shape)yD.light21).set_Fill(b2.fgA);
		((Shape)yD.light22).set_Fill(b2.rgs);
		((Shape)yD.light23).set_Fill(b2.rgs);
		((Shape)yD.light24).set_Fill(b2.fgA);
		Im(yD.light25, b2.rgs);
	}

	public dp()
	{
		Rg.XRF6rz();
		yD = null;
		base._002Ector();
	}

	internal static bool gP()
	{
		return qX == null;
	}

	internal static dp Bp()
	{
		return qX;
	}

	internal static void Im(object object_0, object object_1)
	{
		((Shape)object_0).set_Fill((Brush)object_1);
	}
}
