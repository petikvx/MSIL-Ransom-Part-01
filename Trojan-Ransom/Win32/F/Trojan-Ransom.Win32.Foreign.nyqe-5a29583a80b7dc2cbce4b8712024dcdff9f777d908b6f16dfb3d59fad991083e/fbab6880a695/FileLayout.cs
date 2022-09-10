using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fbab6880a695;

internal abstract class FileLayout : Control
{
	protected enum FormList : byte
	{
		nextCaption,
		parentLog,
		propStorePosition
	}

	protected Graphics nextCaption;

	protected Bitmap nextCaption;

	protected FormList nextCaption;

	private bool nextCaption;

	private Image nextCaption;

	private Size nextCaption;

	private Rectangle nextCaption;

	private LinearGradientBrush nextCaption;

	private SolidBrush nextCaption;

	string Text
	{
		get
		{
			string text = ((Control)this).get_Text();
			while (true)
			{
				int num = 2030475361;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3742ECDCu) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 2u:
						break;
					default:
						return text;
					}
					break;
					IL_0009:
					num = (int)(num2 * 356250415) ^ -1175687850;
				}
			}
		}
		set
		{
			((Control)this).set_Text(value);
			while (true)
			{
				int num = 330660589;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x652C2C4Du) % 3u)
					{
					case 1u:
						goto IL_0009;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0009:
					((Control)this).Invalidate();
					num = (int)(num2 * 1628432060) ^ -1233698381;
				}
			}
		}
	}

	public bool JoinBookmark
	{
		get
		{
			return this.nextCaption;
		}
		set
		{
			this.nextCaption = value;
			((Control)this).Invalidate();
		}
	}

	public Image JoinBookmark
	{
		get
		{
			return this.nextCaption;
		}
		set
		{
			this.nextCaption = value;
			while (true)
			{
				int num = -1580386604;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x902EE152u) % 3u)
					{
					case 1u:
						goto IL_0009;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0009:
					((Control)this).Invalidate();
					num = (int)((num2 * 1273677416) ^ 0x786A39CB);
				}
			}
		}
	}

	public int JoinBookmark
	{
		get
		{
			if (this.nextCaption == null)
			{
				goto IL_001b;
			}
			goto IL_0067;
			IL_0067:
			int result = this.nextCaption.get_Width();
			int num = 1130184254;
			goto IL_003e;
			IL_003e:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x50434339u) % 6u)
				{
				case 4u:
					result = 0;
					num = (int)(num2 * 1928478451) ^ -735329605;
					continue;
				case 3u:
					break;
				case 1u:
					num = (int)(num2 * 43400531) ^ -870633005;
					continue;
				case 0u:
					num = ((int)num2 * -441737045) ^ -341831080;
					continue;
				case 2u:
					goto IL_0067;
				default:
					return result;
				}
				break;
			}
			goto IL_001b;
			IL_001b:
			num = 2146928705;
			goto IL_003e;
		}
	}

	public int ViewComponent
	{
		get
		{
			if (this.nextCaption == null)
			{
				goto IL_0008;
			}
			goto IL_0052;
			IL_0052:
			int result = default(int);
			int num;
			checked
			{
				result = unchecked(((Control)this).get_Height() / 2) - unchecked(this.nextCaption.get_Height() / 2);
				num = -39352583;
				goto IL_002d;
			}
			IL_002d:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD079F483u) % 5u)
				{
				case 4u:
					break;
				case 2u:
					result = 0;
					num = ((int)num2 * -1283458372) ^ 0x7EC0FBCE;
					continue;
				case 1u:
					num = ((int)num2 * -654762957) ^ -1538628762;
					continue;
				case 0u:
					goto IL_0052;
				default:
					return result;
				}
				break;
			}
			goto IL_0008;
			IL_0008:
			num = -1007428939;
			goto IL_002d;
		}
	}

	public FileLayout()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)139270, true);
		this.nextCaption = new Bitmap(1, 1);
		this.nextCaption = Graphics.FromImage((Image)(object)this.nextCaption);
	}

	public void JoinBookmark()
	{
		((Control)this).SetStyle((ControlStyles)4, false);
		while (true)
		{
			int num = 478643524;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBBC1EC2u) % 3u)
				{
				case 2u:
					goto IL_000a;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000a:
				((Control)this).SetStyle((ControlStyles)2048, true);
				num = ((int)num2 * -2064176373) ^ 0x2E8B8E0C;
			}
		}
	}

	protected override void GenerateDevice(EventArgs nextCaption)
	{
		JoinBookmark(FormList.nextCaption);
		while (true)
		{
			int num = -964294598;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8E401EAEu) % 3u)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				((Control)this).OnMouseLeave(nextCaption);
				num = (int)(num2 * 1743213130) ^ -657505718;
			}
		}
	}

	protected override void RebuildSolution(EventArgs nextCaption)
	{
		JoinBookmark(FormList.parentLog);
		((Control)this).OnMouseEnter(nextCaption);
	}

	protected override void DisconnectPlugin(MouseEventArgs nextCaption)
	{
		JoinBookmark(FormList.parentLog);
		((Control)this).OnMouseUp(nextCaption);
	}

	protected override void OpenProject(MouseEventArgs nextCaption)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)nextCaption.get_Button() == 1048576)
		{
			goto IL_000d;
		}
		goto IL_0049;
		IL_0049:
		((Control)this).OnMouseDown(nextCaption);
		int num = 2109853726;
		goto IL_0028;
		IL_0028:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x775F25BAu) % 4u)
			{
			case 3u:
				break;
			case 2u:
				JoinBookmark(FormList.propStorePosition);
				num = ((int)num2 * -1617989491) ^ 0x12DEAD59;
				continue;
			default:
				return;
			case 1u:
				goto IL_0049;
			case 0u:
				return;
			}
			break;
		}
		goto IL_000d;
		IL_000d:
		num = 143180948;
		goto IL_0028;
	}

	private void JoinBookmark(FormList nextCaption)
	{
		this.nextCaption = nextCaption;
		((Control)this).Invalidate();
	}

	public abstract void DisposeDatabase();

	protected sealed override void ChangeActivity(PaintEventArgs nextCaption)
	{
		if (((Control)this).get_Width() == 0)
		{
			return;
		}
		while (true)
		{
			int num = -162524080;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAD747E88u) % 6u)
				{
				case 2u:
				{
					int num3;
					int num4;
					if (((Control)this).get_Height() == 0)
					{
						num3 = -894646032;
						num4 = -894646032;
					}
					else
					{
						num3 = -729401806;
						num4 = -729401806;
					}
					num = num3 ^ (int)(num2 * 1181419266);
					continue;
				}
				case 1u:
					nextCaption.get_Graphics().DrawImage((Image)(object)this.nextCaption, 0, 0);
					num = (int)((num2 * 1398020207) ^ 0x38E69B38);
					continue;
				case 0u:
					DisposeDatabase();
					num = -1964810313;
					continue;
				default:
					return;
				case 3u:
					break;
				case 4u:
				case 5u:
					return;
				}
				break;
			}
		}
	}

	protected override void AddSymbol(EventArgs nextCaption)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		if (((Control)this).get_Width() != 0)
		{
			while (true)
			{
				int num = -1441924437;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x947E1748u) % 4u)
					{
					case 3u:
					{
						int num3;
						int num4;
						if (((Control)this).get_Height() == 0)
						{
							num3 = -589592369;
							num4 = -589592369;
						}
						else
						{
							num3 = -1764908372;
							num4 = -1764908372;
						}
						num = num3 ^ (int)(num2 * 1640028894);
						continue;
					}
					case 2u:
						this.nextCaption = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
						this.nextCaption = Graphics.FromImage((Image)(object)this.nextCaption);
						((Control)this).Invalidate();
						num = (int)((num2 * 1359547764) ^ 0x4A2EB60D);
						continue;
					case 0u:
						break;
					default:
						goto end_IL_0097;
					}
					break;
				}
				continue;
				end_IL_0097:
				break;
			}
		}
		((Control)this).OnSizeChanged(nextCaption);
	}

	protected void JoinBookmark(Color nextCaption, Rectangle parentLog)
	{
		if (this.nextCaption)
		{
			goto IL_00c2;
		}
		goto IL_00f4;
		IL_00f4:
		this.nextCaption.SetPixel(parentLog.X, parentLog.Y, nextCaption);
		int num = -721524977;
		goto IL_00c7;
		IL_00c7:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xA133CEBBu) % 7u)
			{
			case 5u:
				checked
				{
					this.nextCaption.SetPixel(parentLog.X + (parentLog.Width - 1), parentLog.Y + (parentLog.Height - 1), nextCaption);
				}
				num = ((int)num2 * -591948362) ^ 0x733C916;
				continue;
			case 4u:
				this.nextCaption.SetPixel(checked(parentLog.X + (parentLog.Width - 1)), parentLog.Y, nextCaption);
				num = ((int)num2 * -1685586391) ^ -1604725148;
				continue;
			case 2u:
				num = ((int)num2 * -1699066268) ^ -100163548;
				continue;
			case 1u:
				this.nextCaption.SetPixel(parentLog.X, checked(parentLog.Y + (parentLog.Height - 1)), nextCaption);
				num = ((int)num2 * -1285672488) ^ 0x1C4555A4;
				continue;
			case 0u:
				break;
			default:
				return;
			case 6u:
				goto IL_00f4;
			case 3u:
				return;
			}
			break;
		}
		goto IL_00c2;
		IL_00c2:
		num = -1398841423;
		goto IL_00c7;
	}

	protected void JoinBookmark(Pen nextCaption, Pen parentLog, Rectangle propStorePosition)
	{
		checked
		{
			this.nextCaption.DrawRectangle(nextCaption, propStorePosition.X, propStorePosition.Y, propStorePosition.Width - 1, propStorePosition.Height - 1);
			this.nextCaption.DrawRectangle(parentLog, propStorePosition.X + 1, propStorePosition.Y + 1, propStorePosition.Width - 3, propStorePosition.Height - 3);
		}
	}

	protected void JoinBookmark(HorizontalAlignment nextCaption, Color parentLog, int propStorePosition)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		JoinBookmark(nextCaption, parentLog, propStorePosition, 0);
	}

	protected void JoinBookmark(HorizontalAlignment nextCaption, Color parentLog, int propStorePosition, int variableID)
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected I4, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		if (string.IsNullOrEmpty(System_002EWindows_002EForms_002EControl_002EText))
		{
			goto IL_007a;
		}
		goto IL_0192;
		IL_0192:
		this.nextCaption = this.nextCaption.MeasureString(System_002EWindows_002EForms_002EControl_002EText, ((Control)this).get_Font()).ToSize();
		this.nextCaption = new SolidBrush(parentLog);
		int num = 2053180055;
		goto IL_0158;
		IL_0158:
		checked
		{
			while (true)
			{
				uint num2;
				switch (unchecked((num2 = (uint)num ^ 0x7C204F5Eu) % 10u))
				{
				case 9u:
					num = unchecked((int)num2 * -505689127) ^ -159391270;
					continue;
				case 7u:
					this.nextCaption.DrawString(System_002EWindows_002EForms_002EControl_002EText, ((Control)this).get_Font(), (Brush)(object)this.nextCaption, (float)(((Control)this).get_Width() - this.nextCaption.Width - propStorePosition), (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(this.nextCaption.Height / 2) + variableID));
					num = 213409938;
					continue;
				case 6u:
					break;
				case 4u:
					goto IL_0084;
				case 3u:
					goto IL_00db;
				case 2u:
					num = unchecked((int)(num2 * 1670840375)) ^ -974774951;
					continue;
				case 1u:
					switch (unchecked((int)nextCaption))
					{
					case 1:
						break;
					case 2:
						goto IL_0084;
					case 0:
						goto IL_00db;
					default:
						goto IL_013c;
					}
					goto case 7u;
				case 0u:
					num = unchecked((int)num2 * -824984197) ^ 0x75EBD8FD;
					continue;
				default:
					return;
				case 8u:
					goto IL_0192;
				case 5u:
					return;
					IL_013c:
					num = unchecked((int)((num2 * 1733748399) ^ 0x7584CB59));
					continue;
					IL_00db:
					this.nextCaption.DrawString(System_002EWindows_002EForms_002EControl_002EText, ((Control)this).get_Font(), (Brush)(object)this.nextCaption, (float)propStorePosition, (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(this.nextCaption.Height / 2) + variableID));
					num = 1952926713;
					continue;
					IL_0084:
					this.nextCaption.DrawString(System_002EWindows_002EForms_002EControl_002EText, ((Control)this).get_Font(), (Brush)(object)this.nextCaption, (float)(unchecked(((Control)this).get_Width() / 2) - unchecked(this.nextCaption.Width / 2) + propStorePosition), (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(this.nextCaption.Height / 2) + variableID));
					num = 1952926713;
					continue;
				}
				break;
			}
			goto IL_007a;
		}
		IL_007a:
		num = 2115246853;
		goto IL_0158;
	}

	protected void JoinBookmark(HorizontalAlignment nextCaption, int parentLog)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		JoinBookmark(nextCaption, parentLog, 0);
	}

	protected void JoinBookmark(HorizontalAlignment nextCaption, int parentLog, int propStorePosition)
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected I4, but got Unknown
		if (this.nextCaption == null)
		{
			goto IL_0074;
		}
		goto IL_0154;
		IL_0154:
		switch ((int)nextCaption)
		{
		case 0:
			break;
		case 1:
			goto IL_007b;
		case 2:
			goto IL_0106;
		default:
			goto IL_014a;
		}
		goto IL_0043;
		IL_014a:
		int num = -49914768;
		goto IL_00cc;
		IL_0043:
		checked
		{
			this.nextCaption.DrawImage(this.nextCaption, parentLog, unchecked(((Control)this).get_Height() / 2) - unchecked(this.nextCaption.get_Height() / 2) + propStorePosition);
			num = -1304791499;
			goto IL_00cc;
		}
		IL_00cc:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xD809BD1Bu) % 10u)
			{
			case 9u:
				num = (int)((num2 * 1409441979) ^ 0x73B32AF9);
				continue;
			case 8u:
				num = (int)((num2 * 1260863938) ^ 0x74450748);
				continue;
			case 6u:
				num = (int)((num2 * 2000139694) ^ 0x40F97C94);
				continue;
			case 5u:
				break;
			case 3u:
				goto IL_0074;
			case 2u:
				goto IL_007b;
			case 0u:
				num = ((int)num2 * -576612490) ^ 0x41ED2270;
				continue;
			default:
				return;
			case 4u:
				goto IL_0106;
			case 1u:
				goto IL_0154;
			case 7u:
				return;
			}
			break;
		}
		goto IL_0043;
		IL_0106:
		checked
		{
			this.nextCaption.DrawImage(this.nextCaption, unchecked(((Control)this).get_Width() / 2) - unchecked(this.nextCaption.get_Width() / 2), unchecked(((Control)this).get_Height() / 2) - unchecked(this.nextCaption.get_Height() / 2));
			num = -1773870128;
			goto IL_00cc;
		}
		IL_0074:
		num = -677895465;
		goto IL_00cc;
		IL_007b:
		checked
		{
			this.nextCaption.DrawImage(this.nextCaption, ((Control)this).get_Width() - this.nextCaption.get_Width() - parentLog, unchecked(((Control)this).get_Height() / 2) - unchecked(this.nextCaption.get_Height() / 2) + propStorePosition);
			num = -48467861;
			goto IL_00cc;
		}
	}

	protected void JoinBookmark(Color nextCaption, Color parentLog, int propStorePosition, int variableID, int query, int timerHeader, float activeManager)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		ref Rectangle reference = ref this.nextCaption;
		reference = new Rectangle(propStorePosition, variableID, query, timerHeader);
		this.nextCaption = new LinearGradientBrush(this.nextCaption, nextCaption, parentLog, activeManager);
		this.nextCaption.FillRectangle((Brush)(object)this.nextCaption, this.nextCaption);
	}
}
