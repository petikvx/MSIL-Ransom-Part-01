using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BAFtn8MT09F52hXL1NN;
using LYGYSgYwZZQHi0dvtur;
using NDLrcOYUKj1ecQRCUOV;
using ProwxkN4F4ab5Fc8FL;

namespace kTObUYYKIiLNw4W73I3;

internal sealed class BAFQuqYJLPqN8cnnwRs : Control
{
	private Label ETjKn7J7Df;

	private Image HrYKGUkVjG;

	private Icon LIfKIWMkrb;

	private Bitmap ad2K8lf102;

	private T8Vm9tYA3OSl2HXi5ML YoQKFKIHDb;

	private float UXlKgpSLH6;

	private float wyTKsi9aIx;

	string Text
	{
		get
		{
			return ((Control)ETjKn7J7Df).get_Text();
		}
		set
		{
			((Control)ETjKn7J7Df).set_Text(value);
		}
	}

	[SpecialName]
	public void method_0(T8Vm9tYA3OSl2HXi5ML t8Vm9tYA3OSl2HXi5ML_0)
	{
		int num = 2;
		if (!znJJhf4AfLqhAJ1iGeC())
		{
			goto IL_003b;
		}
		goto IL_0046;
		IL_0046:
		switch (num)
		{
		case 1:
		case 5:
			break;
		case 4:
			goto IL_0016;
		case 3:
			goto IL_001d;
		case 2:
			goto IL_003b;
		case 9:
			ad2K8lf102 = null;
			goto IL_00b1;
		default:
			goto IL_00b1;
		case 10:
			return;
		}
		goto IL_000f;
		IL_00b1:
		((Control)this).Refresh();
		return;
		IL_003b:
		if (YoQKFKIHDb != t8Vm9tYA3OSl2HXi5ML_0)
		{
			goto IL_000f;
		}
		return;
		IL_000f:
		YoQKFKIHDb = t8Vm9tYA3OSl2HXi5ML_0;
		goto IL_0016;
		IL_0016:
		T8Vm9tYA3OSl2HXi5ML yoQKFKIHDb = YoQKFKIHDb;
		goto IL_001d;
		IL_001d:
		switch (yoQKFKIHDb)
		{
		case (T8Vm9tYA3OSl2HXi5ML)1:
			goto IL_007c;
		case (T8Vm9tYA3OSl2HXi5ML)2:
			goto IL_0093;
		}
		num = 9;
		if (!znJJhf4AfLqhAJ1iGeC())
		{
			return;
		}
		goto IL_0046;
		IL_007c:
		ad2K8lf102 = rITYfQM9BT4MKIrlIxO.NekK7jcmTv(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681208));
		goto IL_00b1;
		IL_0093:
		ad2K8lf102 = rITYfQM9BT4MKIrlIxO.NekK7jcmTv(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681221));
		goto IL_00b1;
	}

	void Control.Dispose(bool disposing)
	{
		while (disposing)
		{
			int num = 11;
			if (!znJJhf4AfLqhAJ1iGeC())
			{
				goto IL_00cb;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
				case 11:
					if (LIfKIWMkrb != null)
					{
						goto case 9;
					}
					goto case 7;
				case 9:
					LIfKIWMkrb.Dispose();
					LIfKIWMkrb = null;
					num = 7;
					if (znJJhf4AfLqhAJ1iGeC())
					{
						continue;
					}
					goto case 7;
				case 7:
					if (HrYKGUkVjG != null)
					{
						num = 8;
						if (HA6ga84p2tmsDUCmb2l())
						{
						}
						continue;
					}
					goto default;
				case 8:
					HrYKGUkVjG.Dispose();
					num = 2;
					if (!HA6ga84p2tmsDUCmb2l())
					{
					}
					continue;
				case 0:
				case 6:
					break;
				case 2:
					HrYKGUkVjG = null;
					goto default;
				default:
					if (ad2K8lf102 == null)
					{
						goto end_IL_00a6;
					}
					goto case 10;
				case 10:
					((Image)ad2K8lf102).Dispose();
					goto IL_00cb;
				case 3:
					goto IL_00cb;
				case 5:
					goto end_IL_00a6;
				case 12:
					return;
				}
				break;
			}
			continue;
			IL_00cb:
			ad2K8lf102 = null;
			break;
			continue;
			end_IL_00a6:
			break;
		}
		((Control)this).Dispose(disposing);
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)ETjKn7J7Df).SetBounds(Convert.ToInt32(13f * UXlKgpSLH6), Convert.ToInt32(15f * wyTKsi9aIx), ((Control)this).get_Width() - Convert.ToInt32(69f * UXlKgpSLH6), ((Control)this).get_Height() - Convert.ToInt32(18f * wyTKsi9aIx));
		((Control)this).OnResize(e);
	}

	void Control.ScaleCore(float dx, float dy)
	{
		while (true)
		{
			UXlKgpSLH6 = dx;
			while (true)
			{
				wyTKsi9aIx = dy;
				if (!HA6ga84p2tmsDUCmb2l())
				{
					switch (2)
					{
					case 1:
						continue;
					case 0:
					case 5:
						break;
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

	void Control.OnPaint(PaintEventArgs e)
	{
		Rectangle rectangle = default(Rectangle);
		while (true)
		{
			((Control)this).OnPaint(e);
			int num = 2;
			if (znJJhf4AfLqhAJ1iGeC())
			{
				while (true)
				{
					switch (num)
					{
					default:
						num = 1;
						if (!HA6ga84p2tmsDUCmb2l())
						{
							continue;
						}
						break;
					case 6:
						break;
					case 2:
						e.get_Graphics().DrawLine(SystemPens.get_ControlDark(), 0, ((Control)this).get_ClientSize().Height - 2, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 2);
						goto case 9;
					case 9:
						e.get_Graphics().DrawLine(SystemPens.get_ControlLightLight(), 0, ((Control)this).get_ClientSize().Height - 1, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 1);
						goto case 3;
					case 3:
					case 10:
						rectangle = new Rectangle(((Control)this).get_ClientSize().Width - Convert.ToInt32(48f * UXlKgpSLH6), Convert.ToInt32(11f * wyTKsi9aIx), Convert.ToInt32(32f * UXlKgpSLH6), Convert.ToInt32(32f * wyTKsi9aIx));
						goto case 8;
					case 8:
						if (HrYKGUkVjG != null)
						{
							e.get_Graphics().DrawImage(HrYKGUkVjG, rectangle, new Rectangle(0, 0, 32, 32), (GraphicsUnit)2);
							return;
						}
						if (LIfKIWMkrb == null)
						{
							return;
						}
						goto case 0;
					case 1:
						return;
					case 0:
						e.get_Graphics().DrawIcon(LIfKIWMkrb, rectangle);
						goto case 5;
					case 5:
					case 7:
						if (ad2K8lf102 == null)
						{
							return;
						}
						goto IL_0188;
					case 4:
						goto IL_0188;
					case 11:
						return;
					}
					break;
				}
				continue;
			}
			goto IL_0188;
			IL_0188:
			e.get_Graphics().DrawImage((Image)(object)ad2K8lf102, new Rectangle(rectangle.Right - Convert.ToInt32(12f * UXlKgpSLH6), rectangle.Bottom - Convert.ToInt32(12f * wyTKsi9aIx), Convert.ToInt32(16f * UXlKgpSLH6), Convert.ToInt32(16f * wyTKsi9aIx)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
			break;
		}
	}

	void Control.OnFontChanged(EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		try
		{
			((Control)ETjKn7J7Df).set_Font(new Font(((Control)this).get_Font(), (FontStyle)1));
			((Control)this).OnFontChanged(e);
		}
		catch
		{
		}
	}

	public BAFQuqYJLPqN8cnnwRs()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		while (true)
		{
			ETjKn7J7Df = new Label();
			while (true)
			{
				IL_000c:
				UXlKgpSLH6 = 1f;
				while (true)
				{
					IL_0017:
					wyTKsi9aIx = 1f;
					while (true)
					{
						IL_0022:
						((Control)this)._002Ector();
						while (true)
						{
							IL_0028:
							try
							{
								ETjKn7J7Df.set_FlatStyle((FlatStyle)3);
								((Control)ETjKn7J7Df).set_Font(new Font(((Control)this).get_Font(), (FontStyle)1));
							}
							catch
							{
							}
							((Control)this).get_Controls().Add((Control)(object)ETjKn7J7Df);
							while (true)
							{
								IL_00b1:
								((Control)this).set_BackColor(SystemColors.Window);
								while (true)
								{
									IL_00a8:
									((Control)this).set_TabStop(false);
									while (true)
									{
										((Control)this).set_Dock((DockStyle)1);
										((Control)this).set_Height(58);
										if (HA6ga84p2tmsDUCmb2l())
										{
										}
										switch (6)
										{
										case 4:
											break;
										case 1:
										case 12:
											goto IL_000c;
										case 9:
											goto IL_0017;
										case 0:
											goto IL_0022;
										case 2:
											goto IL_0028;
										case 11:
											continue;
										default:
											goto IL_00a8;
										case 3:
											goto IL_00b1;
										case 6:
										case 8:
											((Control)this).SetStyle((ControlStyles)75794, true);
											goto case 7;
										case 7:
											LIfKIWMkrb = xAjiqWY1RtDWwMdfIUA.QNsAORfppT();
											goto case 5;
										case 5:
											((Control)this).OnResize(EventArgs.Empty);
											return;
										case 13:
											return;
										}
										break;
									}
									break;
								}
								break;
							}
							break;
						}
						break;
					}
					break;
				}
				break;
			}
		}
	}

	public BAFQuqYJLPqN8cnnwRs(string string_0)
		: this()
	{
		((Control)ETjKn7J7Df).set_Text(string_0);
	}

	internal static bool znJJhf4AfLqhAJ1iGeC()
	{
		return true;
	}

	internal static bool HA6ga84p2tmsDUCmb2l()
	{
		return false;
	}
}
