using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using BAFtn8MT09F52hXL1NN;
using ProwxkN4F4ab5Fc8FL;

namespace EP9YrOYpdhxIB6Oly1i;

internal sealed class LC5ha2YQUDNd1IaR1IS : Control
{
	private Label BmVK9Msbg2;

	private PictureBox pIUKTZpXSC;

	private ToolTip yDQKleZ3jS;

	private float ld9KmcGWP3;

	private float wBwKNKKkmw;

	void Control.OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(112f * ld9KmcGWP3), Convert.ToInt32(32f * wBwKNKKkmw)));
		((Control)this).OnResize(e);
	}

	void Control.ScaleCore(float dx, float dy)
	{
		while (true)
		{
			ld9KmcGWP3 = dx;
			while (true)
			{
				wBwKNKKkmw = dy;
				if (eWFmWJ4aqGRjLLGR2WG())
				{
					switch (0)
					{
					case 1:
					case 5:
						continue;
					case 4:
						break;
					case 0:
					case 2:
						((Control)this).ScaleCore(dx, dy);
						goto default;
					default:
						((Control)this).OnResize(EventArgs.Empty);
						return;
					case 6:
						return;
					}
					break;
				}
				return;
			}
		}
	}

	void Control.Dispose(bool disposing)
	{
		if (disposing)
		{
			if (yDQKleZ3jS != null)
			{
				((Component)(object)yDQKleZ3jS).Dispose();
			}
			if (pIUKTZpXSC != null)
			{
				((Component)(object)pIUKTZpXSC).Dispose();
			}
		}
		((Control)this).Dispose(disposing);
	}

	private void swZK2eAtbb(object sender, EventArgs e)
	{
		try
		{
			Process.Start(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681234));
		}
		catch
		{
		}
	}

	public LC5ha2YQUDNd1IaR1IS()
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		while (true)
		{
			IL_0234:
			BmVK9Msbg2 = new Label();
			int num = 19;
			if (zpdWh44Sru9hdDQYabD())
			{
				goto IL_01a0;
			}
			goto IL_01ce;
			IL_01ce:
			while (true)
			{
				switch (num)
				{
				case 21:
					((Control)this)._002Ector();
					break;
				case 16:
					break;
				case 6:
				case 14:
					goto IL_001e;
				case 3:
					goto IL_0031;
				case 15:
					goto IL_0045;
				case 20:
					pIUKTZpXSC.set_Image((Image)(object)rITYfQM9BT4MKIrlIxO.NekK7jcmTv(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681477)));
					goto case 10;
				case 10:
				case 17:
					((Control)pIUKTZpXSC).set_Location(new Point(72, 0));
					((Control)pIUKTZpXSC).set_Size(new Size(32, 32));
					goto default;
				default:
					pIUKTZpXSC.set_SizeMode((PictureBoxSizeMode)1);
					goto case 4;
				case 4:
					((Control)BmVK9Msbg2).add_Click((EventHandler)swZK2eAtbb);
					num = 12;
					if (zpdWh44Sru9hdDQYabD())
					{
					}
					continue;
				case 19:
					pIUKTZpXSC = new PictureBox();
					goto case 1;
				case 1:
					yDQKleZ3jS = new ToolTip();
					ld9KmcGWP3 = 1f;
					goto case 18;
				case 18:
					wBwKNKKkmw = 1f;
					goto case 21;
				case 13:
					goto IL_0117;
				case 0:
					goto IL_0122;
				case 7:
					goto IL_0129;
				case 5:
					goto IL_015d;
				case 12:
					goto IL_01a0;
				case 11:
					goto IL_01b7;
				case 8:
					goto IL_0234;
				case 9:
					yDQKleZ3jS.SetToolTip((Control)(object)pIUKTZpXSC, DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681486));
					((Control)this).ResumeLayout(true);
					return;
				case 22:
					return;
				}
				break;
			}
			goto IL_000c;
			IL_01a0:
			((Control)pIUKTZpXSC).add_Click((EventHandler)swZK2eAtbb);
			goto IL_01b7;
			IL_01b7:
			((Control)this).add_Click((EventHandler)swZK2eAtbb);
			goto IL_0117;
			IL_0117:
			((Control)this).set_Cursor(Cursors.get_Hand());
			goto IL_0122;
			IL_0122:
			((Control)this).set_TabStop(false);
			goto IL_0129;
			IL_0129:
			((Control)this).set_Size(new Size(112, 32));
			((Control)this).get_Controls().AddRange((Control[])(object)new Control[2]
			{
				(Control)pIUKTZpXSC,
				(Control)BmVK9Msbg2
			});
			goto IL_015d;
			IL_015d:
			yDQKleZ3jS.SetToolTip((Control)(object)this, DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681486));
			yDQKleZ3jS.SetToolTip((Control)(object)BmVK9Msbg2, DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681486));
			num = 9;
			if (!eWFmWJ4aqGRjLLGR2WG())
			{
				goto IL_000c;
			}
			goto IL_01ce;
			IL_000c:
			((Control)this).SuspendLayout();
			BmVK9Msbg2.set_FlatStyle((FlatStyle)3);
			goto IL_001e;
			IL_001e:
			((Control)BmVK9Msbg2).set_Location(new Point(0, 10));
			goto IL_0031;
			IL_0031:
			((Control)BmVK9Msbg2).set_Size(new Size(62, 24));
			goto IL_0045;
			IL_0045:
			((Control)BmVK9Msbg2).set_Text(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681460));
			num = 20;
			if (zpdWh44Sru9hdDQYabD())
			{
			}
			goto IL_01ce;
		}
	}

	internal static bool eWFmWJ4aqGRjLLGR2WG()
	{
		return true;
	}

	internal static bool zpdWh44Sru9hdDQYabD()
	{
		return false;
	}
}
