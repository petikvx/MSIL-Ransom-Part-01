using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BAFtn8MT09F52hXL1NN;
using ProwxkN4F4ab5Fc8FL;

namespace qeV0U0YtmeJWNxqihp2;

internal sealed class XUCR4AYcHUUvGB8LbKv : Control
{
	private int EhbKDlZylv;

	private readonly Bitmap TuNK34yLvU;

	private readonly Bitmap kASKv7NWAY;

	private readonly Timer QQuKyb79A8;

	private float MlqKzEXY3X;

	private float QDqALmOBiD;

	void Control.OnVisibleChanged(EventArgs e)
	{
		((Control)this).OnVisibleChanged(e);
		if (!((Component)this).DesignMode)
		{
			LYoKfsEOKh(((Control)this).get_Visible());
		}
	}

	private void LYoKfsEOKh(bool bool_0)
	{
		while (true)
		{
			QQuKyb79A8.set_Enabled(bool_0);
			if (zsiTw841r2jO6QqDFXr())
			{
				switch (4)
				{
				case 0:
				case 3:
					break;
				case 1:
				case 4:
					goto IL_0039;
				default:
					goto end_IL_0001;
				case 5:
					return;
				}
				continue;
			}
			goto IL_0039;
			IL_0039:
			EhbKDlZylv = 0;
			break;
			continue;
			end_IL_0001:
			break;
		}
		((Control)this).Refresh();
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(250f * MlqKzEXY3X), Convert.ToInt32(42f * QDqALmOBiD)));
		((Control)this).OnResize(e);
	}

	void Control.ScaleCore(float dx, float dy)
	{
		MlqKzEXY3X = dx;
		QDqALmOBiD = dy;
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	void Control.Dispose(bool disposing)
	{
		if (disposing)
		{
			if (TuNK34yLvU != null)
			{
				((Image)TuNK34yLvU).Dispose();
			}
			((Component)(object)QQuKyb79A8).Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	void Control.OnPaint(PaintEventArgs e)
	{
		while (true)
		{
			((Control)this).OnPaint(e);
			while (true)
			{
				IL_00a3:
				if (kASKv7NWAY != null)
				{
					goto IL_004d;
				}
				goto IL_0096;
				IL_0096:
				while (true)
				{
					IL_0096_2:
					if (TuNK34yLvU == null)
					{
						return;
					}
					while (true)
					{
						if (EhbKDlZylv > 0)
						{
							if (qopSYj46o2vKMBw9Yhm())
							{
							}
							switch (0)
							{
							case 2:
							case 8:
								goto end_IL_003f;
							case 5:
								goto IL_0096_2;
							case 1:
							case 4:
								goto IL_00a3;
							case 3:
								goto end_IL_00a3;
							case 0:
								e.get_Graphics().SetClip(new Rectangle(Convert.ToInt32(46f * MlqKzEXY3X), 0, Convert.ToInt32(165f * MlqKzEXY3X), Convert.ToInt32(34f * QDqALmOBiD)));
								goto case 6;
							case 6:
								e.get_Graphics().DrawImage((Image)(object)TuNK34yLvU, new Rectangle(Convert.ToInt32((float)(EhbKDlZylv - 6) * MlqKzEXY3X), Convert.ToInt32(16f * QDqALmOBiD), Convert.ToInt32(40f * MlqKzEXY3X), Convert.ToInt32(12f * QDqALmOBiD)), 0, 0, 40, 12, (GraphicsUnit)2);
								return;
							case 9:
								return;
							}
							continue;
						}
						return;
						continue;
						end_IL_003f:
						break;
					}
					break;
				}
				goto IL_004d;
				IL_004d:
				e.get_Graphics().DrawImage((Image)(object)kASKv7NWAY, new Rectangle(0, 0, Convert.ToInt32(250f * MlqKzEXY3X), Convert.ToInt32(42f * QDqALmOBiD)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2);
				goto IL_0096;
				continue;
				end_IL_00a3:
				break;
			}
		}
	}

	private void w0nK5dCkTf(object sender, EventArgs e)
	{
		EhbKDlZylv += 11;
		if (EhbKDlZylv > 198)
		{
			EhbKDlZylv = 0;
		}
		((Control)this).Refresh();
	}

	public XUCR4AYcHUUvGB8LbKv()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		if (zsiTw841r2jO6QqDFXr())
		{
			switch (6)
			{
			case 6:
				EhbKDlZylv = 99;
				goto case 12;
			case 12:
				TuNK34yLvU = rITYfQM9BT4MKIrlIxO.NekK7jcmTv(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681519));
				goto case 11;
			case 11:
				kASKv7NWAY = rITYfQM9BT4MKIrlIxO.NekK7jcmTv(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681528));
				break;
			case 3:
			case 9:
				break;
			case 8:
				goto IL_008b;
			case 2:
				goto IL_0096;
			default:
				goto IL_00a1;
			case 4:
			case 7:
				goto IL_00b4;
			case 5:
				goto IL_00cb;
			case 1:
				goto IL_00dd;
			case 10:
				goto IL_00e4;
			case 13:
				return;
			}
		}
		QQuKyb79A8 = new Timer();
		goto IL_008b;
		IL_00b4:
		QQuKyb79A8.add_Tick((EventHandler)w0nK5dCkTf);
		goto IL_00cb;
		IL_00e4:
		((Control)this).SetStyle((ControlStyles)75794, true);
		return;
		IL_00dd:
		((Control)this).set_TabStop(false);
		goto IL_00e4;
		IL_00cb:
		((Control)this).set_Size(new Size(250, 42));
		goto IL_00dd;
		IL_00a1:
		((Control)this)._002Ector();
		QQuKyb79A8.set_Interval(85);
		goto IL_00b4;
		IL_008b:
		MlqKzEXY3X = 1f;
		goto IL_0096;
		IL_0096:
		QDqALmOBiD = 1f;
		goto IL_00a1;
	}

	internal static bool zsiTw841r2jO6QqDFXr()
	{
		return true;
	}

	internal static bool qopSYj46o2vKMBw9Yhm()
	{
		return false;
	}
}
