using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace c;

public class y : Form
{
	private IContainer m;

	public y()
	{
		while (true)
		{
			int num = 606922999;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2C0F0C76u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				c();
				num = (int)((num2 * 1490029687) ^ 0x7381ECDF);
			}
		}
	}

	private void n(object sender, EventArgs e)
	{
		j.l();
		y.smethod_0(0);
	}

	protected override void Dispose(bool disposing)
	{
		byte[] d = h.d;
		int num3 = default(int);
		while (true)
		{
			int num = -1886772314;
			while (true)
			{
				uint num2;
				int num5;
				int num4;
				switch ((num2 = (uint)num ^ 0xD9BBB1CEu) % 6u)
				{
				case 5u:
					num5 = 0;
					goto IL_000c;
				case 4u:
					num3 = 2;
					num = (int)((num2 * 923803856) ^ 0x2EFA8E5D);
					continue;
				default:
					num5 = d[80] - 101;
					goto IL_000c;
				case 1u:
					while (true)
					{
						switch (num3)
						{
						case 0:
						case 4:
							if (m == null)
							{
								num3 = d[94];
								continue;
							}
							num3 = 1;
							goto case 1;
						case 2:
							goto IL_0064;
						case 1:
							y.smethod_1((IDisposable)m);
							goto case 5;
						case 5:
							((Form)this).Dispose(disposing);
							return;
						case 3:
						case 6:
							return;
						}
						break;
					}
					num = -608884266;
					continue;
				case 0u:
					goto IL_0064;
				case 3u:
					break;
					IL_0064:
					if (!disposing)
					{
						num = -1593486438;
						num4 = -1593486438;
					}
					else
					{
						num = -589035633;
						num4 = -589035633;
					}
					continue;
					IL_000c:
					num3 = num5;
					num = -1746306339;
					continue;
				}
				break;
			}
		}
	}

	private void c()
	{
		byte[] d = h.d;
		int num = 3;
		while (true)
		{
			int num2 = 1762708717;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x65BCBD89u) % 11u)
				{
				case 10u:
					((Control)this).set_Text(global::c.c.k(1229547683, null, 5));
					((Form)this).add_Load((EventHandler)n);
					num = d[233];
					num2 = 1762708717;
					continue;
				case 8u:
					goto IL_0043;
				case 7u:
					num = d[272];
					num2 = ((int)num3 * -356597005) ^ 0xEDCE0E4;
					continue;
				case 6u:
					goto IL_006d;
				case 5u:
					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					num2 = ((int)num3 * -1168261303) ^ 0x183147;
					continue;
				case 4u:
					num2 = (int)((num3 * 509804751) ^ 0x6715233D);
					continue;
				case 3u:
					goto IL_00d4;
				case 1u:
					switch (num)
					{
					case 1:
						break;
					case 3:
						goto IL_0043;
					case 4:
					case 5:
						goto IL_006d;
					case 6:
						goto IL_00d4;
					default:
						goto IL_012f;
					case 2:
						goto IL_0136;
					case 0:
						return;
					}
					goto case 10u;
				case 0u:
					goto IL_0136;
				default:
					return;
				case 2u:
					break;
				case 9u:
					return;
					IL_0136:
					num = 6;
					num2 = 183065273;
					continue;
					IL_012f:
					num2 = 996854373;
					continue;
					IL_00d4:
					((Form)this).set_ClientSize(new Size(284, 261));
					((Control)this).set_Name(v.a.u(0, 9, typeof(v), 1468094611));
					num2 = 47104410;
					continue;
					IL_006d:
					((Control)this).ResumeLayout(false);
					h.d[63] = (byte)((h.d[63] + h.d[48]) & 0x21);
					num2 = 505391416;
					continue;
					IL_0043:
					y.smethod_2((Control)(object)this);
					num2 = 907098691;
					continue;
				}
				break;
			}
		}
	}

	static void smethod_0(int int_0)
	{
		Environment.Exit(int_0);
	}

	static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static void smethod_2(Control control_0)
	{
		control_0.SuspendLayout();
	}
}
