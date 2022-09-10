using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using EkIJjm7vjs8xMISmTn;
using NCDRxx4R49CZy0gNBsi;
using ivPFWBLjP3D0KTGBB8g;

namespace HqA5in40eahA8GWQgvh;

internal sealed class jnDpM84nlcN4shBokyt : Control
{
	private int EvuT6QMsl9;

	private readonly Bitmap KpsTcrpfhr;

	private readonly Bitmap heCTqGpVtJ;

	private readonly Timer PXdTfJ0OfB;

	private float U8kTK6QWna;

	private float iVAThgVEo5;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _0001(EventArgs _0020)
	{
		//Discarded unreachable code: IL_0049
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 2:
					((Control)this).OnVisibleChanged(_0020);
					num2 = 3;
					continue;
				case 4:
					break;
				case 1:
				case 3:
					if (!((Component)this).DesignMode)
					{
						break;
					}
					return;
				default:
					num2 = 4;
					if (qy87UcgyvBgDafMXW3L())
					{
					}
					continue;
				case 5:
					return;
				}
				break;
			}
			Vo9TCrHh5x(((Control)this).get_Visible());
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Vo9TCrHh5x(bool _0020)
	{
		//Discarded unreachable code: IL_0046
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					((Control)this).Refresh();
					num2 = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					PXdTfJ0OfB.set_Enabled(_0020);
					num = 4;
					break;
				case 1:
				case 4:
					EvuT6QMsl9 = 0;
					goto case 3;
				default:
					num = 3;
					break;
				case 5:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _0002(EventArgs _0020)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(250f * U8kTK6QWna), Convert.ToInt32(42f * iVAThgVEo5)));
		((Control)this).OnResize(_0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _0001(float _0020, float _0020)
	{
		//Discarded unreachable code: IL_001b
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					((Control)this).ScaleCore(_0020, _0020);
					goto case 1;
				default:
					num = 1;
					break;
				case 1:
				case 3:
					((Control)this).OnResize(EventArgs.Empty);
					num = 6;
					break;
				case 0:
				case 4:
					U8kTK6QWna = _0020;
					num2 = 2;
					if (!qy87UcgyvBgDafMXW3L())
					{
						continue;
					}
					goto case 2;
				case 2:
					iVAThgVEo5 = _0020;
					num2 = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _0002(bool _0020)
	{
		//Discarded unreachable code: IL_004e
		int num = 2;
		if (1 == 0)
		{
			goto IL_000c;
		}
		goto IL_005b;
		IL_005b:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				break;
			case 3:
			case 5:
				goto IL_0025;
			case 6:
				((Image)KpsTcrpfhr).Dispose();
				goto IL_0025;
			default:
				num = 5;
				continue;
			case 2:
				if (_0020)
				{
					num = 0;
					if (qy87UcgyvBgDafMXW3L())
					{
					}
					continue;
				}
				goto case 4;
			case 4:
				((Control)this).Dispose(_0020);
				num = 7;
				if (qy87UcgyvBgDafMXW3L())
				{
				}
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_000c;
		IL_000c:
		if (KpsTcrpfhr == null)
		{
			goto IL_0025;
		}
		int num2 = 6;
		goto IL_0057;
		IL_0025:
		((Component)(object)PXdTfJ0OfB).Dispose();
		num2 = 4;
		goto IL_0057;
		IL_0057:
		num = num2;
		goto IL_005b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _0001(PaintEventArgs _0020)
	{
		//Discarded unreachable code: IL_00f6
		int num = 4;
		if (false)
		{
			goto IL_000c;
		}
		goto IL_0103;
		IL_0103:
		int num2;
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 5:
			case 8:
				goto IL_0021;
			case 3:
				goto IL_0073;
			case 0:
				if (KpsTcrpfhr != null)
				{
					goto case 1;
				}
				return;
			default:
				goto IL_0130;
			case 6:
				if (heCTqGpVtJ == null)
				{
					goto case 0;
				}
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 7:
				_0020.get_Graphics().DrawImage((Image)(object)heCTqGpVtJ, new Rectangle(0, 0, Convert.ToInt32(250f * U8kTK6QWna), Convert.ToInt32(42f * iVAThgVEo5)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2);
				num2 = 0;
				goto IL_00ff;
			case 1:
				if (EvuT6QMsl9 > 0)
				{
					num = 8;
					continue;
				}
				return;
			case 9:
				return;
			}
			break;
			IL_0130:
			num2 = 1;
			goto IL_00ff;
			IL_0073:
			_0020.get_Graphics().DrawImage((Image)(object)KpsTcrpfhr, new Rectangle(Convert.ToInt32((float)(EvuT6QMsl9 - 6) * U8kTK6QWna), Convert.ToInt32(16f * iVAThgVEo5), Convert.ToInt32(40f * U8kTK6QWna), Convert.ToInt32(12f * iVAThgVEo5)), 0, 0, 40, 12, (GraphicsUnit)2);
			num2 = 9;
			goto IL_00ff;
			IL_0021:
			_0020.get_Graphics().SetClip(new Rectangle(Convert.ToInt32(46f * U8kTK6QWna), 0, Convert.ToInt32(165f * U8kTK6QWna), Convert.ToInt32(34f * iVAThgVEo5)));
			num2 = 3;
			goto IL_00ff;
		}
		goto IL_000c;
		IL_000c:
		((Control)this).OnPaint(_0020);
		num2 = 6;
		goto IL_00ff;
		IL_00ff:
		num = num2;
		goto IL_0103;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qsWT9tMJZQ(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_001a
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					EvuT6QMsl9 = 0;
					goto case 5;
				default:
					goto IL_0048;
				case 0:
				case 4:
					EvuT6QMsl9 += 11;
					num = 2;
					break;
				case 1:
				case 2:
					if (EvuT6QMsl9 > 198)
					{
						num = 3;
						break;
					}
					goto case 5;
				case 5:
					((Control)this).Refresh();
					num = 6;
					break;
				case 6:
					return;
				}
				break;
				IL_0048:
				num2 = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public jnDpM84nlcN4shBokyt()
	{
		//Discarded unreachable code: IL_0147
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		int num = 11;
		if (false)
		{
			goto IL_000c;
		}
		goto IL_0154;
		IL_0154:
		int num2;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 11:
				break;
			case 10:
				goto IL_001f;
			case 8:
				goto IL_0035;
			case 6:
				((Control)this).set_Size(new Size(250, 42));
				num = 7;
				if (!qy87UcgyvBgDafMXW3L())
				{
					continue;
				}
				goto case 5;
			case 5:
			case 13:
				U8kTK6QWna = 1f;
				num2 = 4;
				goto IL_0150;
			case 9:
				PXdTfJ0OfB = new Timer();
				num = 13;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				PXdTfJ0OfB.set_Interval(85);
				num = 14;
				if (pFkq96gSYASdKBe45m1())
				{
					continue;
				}
				goto case 3;
			case 3:
				((Control)this).SetStyle((ControlStyles)75794, true);
				num = 15;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				KpsTcrpfhr = uDc1MtLJPKip5Eik5Ld.uQtktiS5hZ(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48440));
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 12;
			case 12:
				((Control)this)._002Ector();
				num2 = 2;
				goto IL_0150;
			case 14:
				PXdTfJ0OfB.add_Tick((EventHandler)qsWT9tMJZQ);
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				iVAThgVEo5 = 1f;
				goto case 12;
			default:
				num = 12;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				((Control)this).set_TabStop(false);
				num2 = 3;
				goto IL_0150;
			case 15:
				return;
			}
			break;
			IL_0035:
			heCTqGpVtJ = uDc1MtLJPKip5Eik5Ld.uQtktiS5hZ(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48449));
			num2 = 9;
			goto IL_0150;
			IL_001f:
			EvuT6QMsl9 = 99;
			num2 = 1;
			goto IL_0150;
		}
		goto IL_000c;
		IL_0150:
		num = num2;
		goto IL_0154;
		IL_000c:
		QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
		num2 = 10;
		goto IL_0150;
	}

	internal static bool pFkq96gSYASdKBe45m1()
	{
		return true;
	}

	internal static bool qy87UcgyvBgDafMXW3L()
	{
		return false;
	}
}
