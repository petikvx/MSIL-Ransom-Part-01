using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using fJpF6sGRwSPY0tjIER;
using zjWSh2Z73jBs4TcJ0x;

namespace theme_for_jack;

public class header : UserControl
{
	private IContainer VwYizaERdq;

	private static header rABnxn7mAaUmOHHTS5S;

	public header()
	{
		evF7be7RjiBlKxVyou2();
		ecDs1K7nmjCibxbOh1m();
		VwYizaERdq = null;
		((UserControl)this)._002Ector();
		D8qiS6uEI9();
	}

	private void jcAiOEvvcM(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		int num = 7;
		while (true)
		{
			IL_0099:
			if (!disposing)
			{
				goto IL_007c;
			}
			goto IL_008e;
			IL_008e:
			int num2 = ((VwYizaERdq != null) ? 1 : 0);
			goto IL_007d;
			IL_007d:
			bool flag = (byte)num2 != 0;
			int num3 = 1;
			if (K1F7eC7SlrO5LUQ982p() != null)
			{
				goto IL_0026;
			}
			goto IL_0055;
			IL_0055:
			while (true)
			{
				switch (num3)
				{
				case 5:
					break;
				default:
					do
					{
						PVles57cKgqSWCJkWbp(this, disposing);
						num3 = 3;
					}
					while (!kmpMCl7fTMIoFxmunTu());
					continue;
				case 1:
					goto IL_0042;
				case 6:
					goto end_IL_0055;
				case 4:
					goto IL_008e;
				case 7:
					goto IL_0099;
				case 3:
					return;
				}
				goto IL_000e;
				IL_0042:
				if (flag)
				{
					goto IL_000e;
				}
				num3 = 0;
				if (kmpMCl7fTMIoFxmunTu())
				{
					continue;
				}
				goto IL_0026;
				IL_000e:
				Pc9pSi7NPx9rOW8P68q(VwYizaERdq);
				num3 = 2;
				if (kmpMCl7fTMIoFxmunTu())
				{
					continue;
				}
				goto IL_0026;
				continue;
				end_IL_0055:
				break;
			}
			goto IL_007c;
			IL_007c:
			num2 = 0;
			goto IL_007d;
			IL_0026:
			num3 = num;
			goto IL_0055;
		}
	}

	private void D8qiS6uEI9()
	{
		int num = 4;
		while (true)
		{
			((Control)this).SuspendLayout();
			while (true)
			{
				JVCuIq7xjPVK9XHXZTB(this, new SizeF(6f, 13f));
				int num2 = 1;
				if (K1F7eC7SlrO5LUQ982p() != null)
				{
					goto IL_0022;
				}
				goto IL_008f;
				IL_008f:
				while (true)
				{
					switch (num2)
					{
					case 7:
						break;
					case 6:
						aZmtvH73V4IMIa1druw(this, new EventHandler(jcAiOEvvcM));
						num2 = 7;
						if (kmpMCl7fTMIoFxmunTu())
						{
							continue;
						}
						goto IL_0022;
					case 2:
						nTOl787pdjw6InUytu1(this, VxExFb78KBWBZ1ZeqPf(28, 20, 59));
						num2 = 0;
						if (K1F7eC7SlrO5LUQ982p() != null)
						{
							continue;
						}
						goto default;
					default:
						zsyCxv7CgNPMTFt282n(this, XaXlykERDhtdRwMnBY.oXbWkAhpNa(33972));
						goto case 6;
					case 1:
						u0SYNj7QXb6RA313SOn(this, (AutoScaleMode)1);
						num2 = 1;
						if (!kmpMCl7fTMIoFxmunTu())
						{
							continue;
						}
						goto case 2;
					case 3:
						goto end_IL_008f;
					case 4:
						goto end_IL_00b6;
					case 5:
						return;
					}
					OLGCXj7skHVEcGhrLmA(this, bool_0: false);
					num2 = 5;
					if (K1F7eC7SlrO5LUQ982p() == null)
					{
						continue;
					}
					goto IL_0022;
					continue;
					end_IL_008f:
					break;
				}
				continue;
				IL_0022:
				num2 = num;
				goto IL_008f;
				continue;
				end_IL_00b6:
				break;
			}
		}
	}

	internal static void evF7be7RjiBlKxVyou2()
	{
		XaXlykERDhtdRwMnBY.jXRWMU6APG();
	}

	internal static void ecDs1K7nmjCibxbOh1m()
	{
		zB3PVH9hASM2TtLqpf.unC5KZCzPQ9Xt();
	}

	internal static bool kmpMCl7fTMIoFxmunTu()
	{
		return rABnxn7mAaUmOHHTS5S == null;
	}

	internal static header K1F7eC7SlrO5LUQ982p()
	{
		return rABnxn7mAaUmOHHTS5S;
	}

	internal static void Pc9pSi7NPx9rOW8P68q(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static void PVles57cKgqSWCJkWbp(object object_0, bool bool_0)
	{
		((ContainerControl)object_0).Dispose(bool_0);
	}

	internal static void JVCuIq7xjPVK9XHXZTB(object object_0, SizeF sizeF_0)
	{
		((ContainerControl)object_0).set_AutoScaleDimensions(sizeF_0);
	}

	internal static void u0SYNj7QXb6RA313SOn(object object_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)object_0).set_AutoScaleMode(autoScaleMode_0);
	}

	internal static Color VxExFb78KBWBZ1ZeqPf(int int_0, int int_1, int int_2)
	{
		return Color.FromArgb(int_0, int_1, int_2);
	}

	internal static void nTOl787pdjw6InUytu1(object object_0, Color color_0)
	{
		((Control)object_0).set_BackColor(color_0);
	}

	internal static void zsyCxv7CgNPMTFt282n(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static void aZmtvH73V4IMIa1druw(object object_0, object object_1)
	{
		((UserControl)object_0).add_Load((EventHandler)object_1);
	}

	internal static void OLGCXj7skHVEcGhrLmA(object object_0, bool bool_0)
	{
		((Control)object_0).ResumeLayout(bool_0);
	}
}
