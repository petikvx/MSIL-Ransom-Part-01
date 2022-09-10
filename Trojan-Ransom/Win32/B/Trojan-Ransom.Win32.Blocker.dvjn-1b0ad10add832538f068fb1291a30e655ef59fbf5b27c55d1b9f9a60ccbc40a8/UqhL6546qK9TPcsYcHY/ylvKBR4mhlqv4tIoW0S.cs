using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using EkIJjm7vjs8xMISmTn;
using NCDRxx4R49CZy0gNBsi;
using ivPFWBLjP3D0KTGBB8g;

namespace UqhL6546qK9TPcsYcHY;

internal sealed class ylvKBR4mhlqv4tIoW0S : Control
{
	private Label pNOT7dFusr;

	private PictureBox fMCT1HRDIM;

	private ToolTip CcITe9avtj;

	private float y4UTL59ZMM;

	private float jiPTMt7EEs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _0001(EventArgs _0020)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(112f * y4UTL59ZMM), Convert.ToInt32(32f * jiPTMt7EEs)));
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
				case 2:
					((Control)this).ScaleCore(_0020, _0020);
					goto case 3;
				default:
					num = 3;
					break;
				case 1:
				case 5:
					jiPTMt7EEs = _0020;
					num2 = 2;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 4:
					y4UTL59ZMM = _0020;
					num = 5;
					break;
				case 3:
					((Control)this).OnResize(EventArgs.Empty);
					num2 = 6;
					if (JnKYqkgaoTf2PXabpqx())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _0001(bool _0020)
	{
		//Discarded unreachable code: IL_0071
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					((Control)this).Dispose(_0020);
					num2 = 8;
					continue;
				case 1:
				case 2:
					((Component)(object)CcITe9avtj).Dispose();
					num = 4;
					break;
				case 3:
					if (CcITe9avtj != null)
					{
						num = 1;
						break;
					}
					goto case 4;
				case 0:
				case 7:
					if (_0020)
					{
						num2 = 3;
						continue;
					}
					goto case 5;
				case 4:
					if (fMCT1HRDIM == null)
					{
						goto case 5;
					}
					goto case 6;
				default:
					num2 = 6;
					if (JnKYqkgaoTf2PXabpqx())
					{
						continue;
					}
					goto case 6;
				case 6:
					((Component)(object)fMCT1HRDIM).Dispose();
					num2 = 5;
					if (TW0a7IgecmIcIDaIvAT())
					{
					}
					continue;
				case 8:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YZUTV4pO5e(object _0020, EventArgs _0020)
	{
		try
		{
			Process.Start(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48155));
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ylvKBR4mhlqv4tIoW0S()
	{
		//Discarded unreachable code: IL_00c6
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		int num = 25;
		while (true)
		{
			int num2;
			switch (num)
			{
			case 4:
			case 12:
				y4UTL59ZMM = 1f;
				num2 = 14;
				goto IL_00cf;
			case 14:
				jiPTMt7EEs = 1f;
				num2 = 28;
				goto IL_00cf;
			case 15:
				fMCT1HRDIM.set_SizeMode((PictureBoxSizeMode)1);
				num = 24;
				if (JnKYqkgaoTf2PXabpqx())
				{
					continue;
				}
				goto case 19;
			case 19:
				((Control)fMCT1HRDIM).add_Click((EventHandler)YZUTV4pO5e);
				num2 = 10;
				goto IL_00cf;
			case 3:
				((Control)this).SuspendLayout();
				num2 = 13;
				goto IL_00cf;
			case 18:
				((Control)pNOT7dFusr).set_Location(new Point(0, 10));
				num = 1;
				continue;
			case 0:
				((Control)fMCT1HRDIM).set_Location(new Point(72, 0));
				goto case 27;
			default:
				num = 27;
				if (!TW0a7IgecmIcIDaIvAT())
				{
					continue;
				}
				goto case 6;
			case 6:
				CcITe9avtj.SetToolTip((Control)(object)this, teuVAA2ghHDQmtOkUp.dYB2ebULO8(48407));
				num2 = 8;
				goto IL_00cf;
			case 1:
				((Control)pNOT7dFusr).set_Size(new Size(62, 24));
				num2 = 17;
				goto IL_00cf;
			case 21:
				fMCT1HRDIM.set_Image((Image)(object)uDc1MtLJPKip5Eik5Ld.uQtktiS5hZ(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48398)));
				num = 0;
				if (JnKYqkgaoTf2PXabpqx())
				{
					continue;
				}
				goto case 16;
			case 16:
				CcITe9avtj = new ToolTip();
				num = 12;
				continue;
			case 25:
				QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
				num2 = 26;
				goto IL_00cf;
			case 23:
				CcITe9avtj.SetToolTip((Control)(object)fMCT1HRDIM, teuVAA2ghHDQmtOkUp.dYB2ebULO8(48407));
				num2 = 11;
				goto IL_00cf;
			case 26:
				pNOT7dFusr = new Label();
				num2 = 5;
				goto IL_00cf;
			case 27:
				((Control)fMCT1HRDIM).set_Size(new Size(32, 32));
				num = 15;
				if (JnKYqkgaoTf2PXabpqx())
				{
					continue;
				}
				goto case 24;
			case 24:
				((Control)pNOT7dFusr).add_Click((EventHandler)YZUTV4pO5e);
				num2 = 19;
				goto IL_00cf;
			case 11:
				((Control)this).ResumeLayout(true);
				num2 = 29;
				goto IL_00cf;
			case 9:
				((Control)this).set_Cursor(Cursors.get_Hand());
				num = 7;
				if (true)
				{
					continue;
				}
				break;
			case 17:
				break;
			case 10:
				((Control)this).add_Click((EventHandler)YZUTV4pO5e);
				num2 = 9;
				goto IL_00cf;
			case 20:
			case 22:
				((Control)this).get_Controls().AddRange((Control[])(object)new Control[2]
				{
					(Control)fMCT1HRDIM,
					(Control)pNOT7dFusr
				});
				num = 6;
				if (JnKYqkgaoTf2PXabpqx())
				{
					continue;
				}
				goto case 8;
			case 8:
				CcITe9avtj.SetToolTip((Control)(object)pNOT7dFusr, teuVAA2ghHDQmtOkUp.dYB2ebULO8(48407));
				num2 = 23;
				goto IL_00cf;
			case 28:
				((Control)this)._002Ector();
				num2 = 3;
				goto IL_00cf;
			case 13:
				pNOT7dFusr.set_FlatStyle((FlatStyle)3);
				num = 18;
				if (JnKYqkgaoTf2PXabpqx())
				{
					continue;
				}
				goto case 5;
			case 5:
				fMCT1HRDIM = new PictureBox();
				num = 16;
				if (!TW0a7IgecmIcIDaIvAT())
				{
					continue;
				}
				goto case 7;
			case 7:
				((Control)this).set_TabStop(false);
				num2 = 2;
				goto IL_00cf;
			case 2:
				((Control)this).set_Size(new Size(112, 32));
				num2 = 20;
				goto IL_00cf;
			case 29:
				return;
				IL_00cf:
				num = num2;
				continue;
			}
			((Control)pNOT7dFusr).set_Text(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48381));
			num = 21;
		}
	}

	internal static bool JnKYqkgaoTf2PXabpqx()
	{
		return true;
	}

	internal static bool TW0a7IgecmIcIDaIvAT()
	{
		return false;
	}
}
