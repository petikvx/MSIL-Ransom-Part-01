using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fbab6880a695;

internal abstract class DialogType : ContainerControl
{
	protected Graphics nextCaption;

	protected Bitmap nextCaption;

	private bool nextCaption;

	private Rectangle nextCaption;

	private LinearGradientBrush nextCaption;

	public bool DisconnectPlugin
	{
		get
		{
			bool result = this.nextCaption;
			while (true)
			{
				int num = 378237509;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2BDB8A4Cu) % 3u)
					{
					case 2u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = (int)(num2 * 128621792) ^ -131797766;
				}
			}
		}
		set
		{
			this.nextCaption = value;
			((Control)this).Invalidate();
		}
	}

	public DialogType()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)139270, true);
		this.nextCaption = new Bitmap(1, 1);
		this.nextCaption = Graphics.FromImage((Image)(object)this.nextCaption);
	}

	public void DisconnectPlugin()
	{
		((Control)this).SetStyle((ControlStyles)4, false);
		((Control)this).SetStyle((ControlStyles)2048, true);
	}

	public abstract void ToggleDatabase();

	protected sealed override void BatchBuildXmlFile(PaintEventArgs nextCaption)
	{
		if (((Control)this).get_Width() == 0)
		{
			return;
		}
		while (true)
		{
			int num = -524518245;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA7DBA61u) % 5u)
				{
				case 3u:
					ToggleDatabase();
					nextCaption.get_Graphics().DrawImage((Image)(object)this.nextCaption, 0, 0);
					num = -61823043;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (((Control)this).get_Height() == 0)
					{
						num3 = -802110333;
						num4 = -802110333;
					}
					else
					{
						num3 = -492140437;
						num4 = -492140437;
					}
					num = num3 ^ (int)(num2 * 637915689);
					continue;
				}
				default:
					return;
				case 2u:
					break;
				case 0u:
				case 4u:
					return;
				}
				break;
			}
		}
	}

	protected override void GenerateDevice(EventArgs nextCaption)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		if (((Control)this).get_Width() != 0)
		{
			while (true)
			{
				int num = 804997812;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x49D3A8F6u) % 6u)
					{
					case 3u:
						((Control)this).Invalidate();
						num = ((int)num2 * -143308041) ^ -307690626;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (((Control)this).get_Height() == 0)
						{
							num3 = 1637774603;
							num4 = 1637774603;
						}
						else
						{
							num3 = 1656305951;
							num4 = 1656305951;
						}
						num = num3 ^ (int)(num2 * 951276191);
						continue;
					}
					case 1u:
						this.nextCaption = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
						num = (int)(num2 * 1001581190) ^ -2045738340;
						continue;
					case 0u:
						this.nextCaption = Graphics.FromImage((Image)(object)this.nextCaption);
						num = ((int)num2 * -1066778804) ^ -479269253;
						continue;
					case 4u:
						break;
					default:
						goto end_IL_00bd;
					}
					break;
				}
				continue;
				end_IL_00bd:
				break;
			}
		}
		((Control)this).OnSizeChanged(nextCaption);
	}

	protected void DisconnectPlugin(Color nextCaption, Rectangle parentLog)
	{
		if (this.nextCaption)
		{
			goto IL_000b;
		}
		goto IL_00cc;
		IL_00cc:
		this.nextCaption.SetPixel(parentLog.X, parentLog.Y, nextCaption);
		int num = -792551685;
		goto IL_00a7;
		IL_00a7:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xB6967A30u) % 5u)
			{
			case 4u:
				break;
			case 2u:
				checked
				{
					this.nextCaption.SetPixel(parentLog.X + (parentLog.Width - 1), parentLog.Y, nextCaption);
					this.nextCaption.SetPixel(parentLog.X, parentLog.Y + (parentLog.Height - 1), nextCaption);
					this.nextCaption.SetPixel(parentLog.X + (parentLog.Width - 1), parentLog.Y + (parentLog.Height - 1), nextCaption);
				}
				num = ((int)num2 * -2080611331) ^ -1190684889;
				continue;
			case 1u:
				num = ((int)num2 * -234778218) ^ 0x262F2D1E;
				continue;
			default:
				return;
			case 0u:
				goto IL_00cc;
			case 3u:
				return;
			}
			break;
		}
		goto IL_000b;
		IL_000b:
		num = -1112665559;
		goto IL_00a7;
	}

	protected void DisconnectPlugin(Pen nextCaption, Pen parentLog, Rectangle propStorePosition)
	{
		checked
		{
			this.nextCaption.DrawRectangle(nextCaption, propStorePosition.X, propStorePosition.Y, propStorePosition.Width - 1, propStorePosition.Height - 1);
		}
		while (true)
		{
			int num = 1476459512;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x42A697Du) % 3u)
				{
				case 2u:
					goto IL_002e;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_002e:
				checked
				{
					this.nextCaption.DrawRectangle(parentLog, propStorePosition.X + 1, propStorePosition.Y + 1, propStorePosition.Width - 3, propStorePosition.Height - 3);
				}
				num = (int)((num2 * 1433029176) ^ 0x1D5ED4C2);
			}
		}
	}

	protected void DisconnectPlugin(Color nextCaption, Color parentLog, int propStorePosition, int variableID, int query, int timerHeader, float activeManager)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		ref Rectangle reference = ref this.nextCaption;
		reference = new Rectangle(propStorePosition, variableID, query, timerHeader);
		this.nextCaption = new LinearGradientBrush(this.nextCaption, nextCaption, parentLog, activeManager);
		this.nextCaption.FillRectangle((Brush)(object)this.nextCaption, this.nextCaption);
	}
}
