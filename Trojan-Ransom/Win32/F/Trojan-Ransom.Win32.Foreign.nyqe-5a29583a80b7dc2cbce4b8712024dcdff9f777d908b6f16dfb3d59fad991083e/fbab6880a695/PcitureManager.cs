using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace fbab6880a695;

internal class PcitureManager : FileLayout
{
	[AccessedThroughProperty("txtbox")]
	private new TextBox nextCaption;

	private new bool nextCaption;

	private new int nextCaption;

	private new HorizontalAlignment nextCaption;

	private virtual TextBox SearchContext
	{
		get
		{
			TextBox result = this.nextCaption;
			while (true)
			{
				int num = -2043602813;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB27F05B4u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = (int)((num2 * 838586466) ^ 0x231C4B03);
				}
			}
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = delegate
			{
				JoinBookmark();
			};
			while (true)
			{
				int num = 1838446523;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x71273F5Eu) % 6u)
					{
					case 5u:
						((Control)this.nextCaption).add_TextChanged(eventHandler);
						num = (int)((num2 * 1266991801) ^ 0x534C858F);
						continue;
					case 4u:
					{
						this.nextCaption = value;
						int num5;
						if (this.nextCaption == null)
						{
							num = 1838345562;
							num5 = 1838345562;
						}
						else
						{
							num = 1056606115;
							num5 = 1056606115;
						}
						continue;
					}
					case 3u:
						((Control)this.nextCaption).remove_TextChanged(eventHandler);
						num = (int)(num2 * 1186630975) ^ -341174491;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (this.nextCaption == null)
						{
							num3 = -878749484;
							num4 = -878749484;
						}
						else
						{
							num3 = -1563694319;
							num4 = -1563694319;
						}
						num = num3 ^ (int)(num2 * 1131344250);
						continue;
					}
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	public new bool JoinBookmark
	{
		get
		{
			return this.nextCaption;
		}
		set
		{
			SearchContext.set_UseSystemPasswordChar(this.JoinBookmark);
			this.nextCaption = value;
			((Control)this).Invalidate();
		}
	}

	public new int JoinBookmark
	{
		get
		{
			int result = this.nextCaption;
			while (true)
			{
				int num = 1477516724;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6A263A76u) % 3u)
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
					num = (int)(num2 * 765667703) ^ -1418925483;
				}
			}
		}
		set
		{
			this.nextCaption = value;
			((TextBoxBase)SearchContext).set_MaxLength(this.JoinBookmark);
			((Control)this).Invalidate();
		}
	}

	public new HorizontalAlignment JoinBookmark
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			HorizontalAlignment result = nextCaption;
			while (true)
			{
				int num = -1854183727;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBC3893A0u) % 3u)
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
					num = ((int)num2 * -801814004) ^ -1177636676;
				}
			}
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			nextCaption = value;
			((Control)this).Invalidate();
		}
	}

	public PcitureManager()
	{
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		TextBox val = default(TextBox);
		while (true)
		{
			int num = 2043910578;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FE20A15u) % 12u)
				{
				case 11u:
					val = SearchContext;
					val.set_Multiline(false);
					num = (int)((num2 * 341563245) ^ 0x4BC871A3);
					continue;
				case 10u:
					((Control)this).get_Controls().Add((Control)(object)SearchContext);
					num = (int)((num2 * 1610369192) ^ 0x6F70116A);
					continue;
				case 9u:
					((TextBoxBase)val).set_BorderStyle((BorderStyle)0);
					num = (int)((num2 * 1752524227) ^ 0x5F8A3095);
					continue;
				case 7u:
				{
					TextBox obj2 = val;
					Point location = new Point(5, 8);
					((Control)obj2).set_Location(location);
					num = ((int)num2 * -25246567) ^ 0x2EA16032;
					continue;
				}
				case 6u:
					System_002EWindows_002EForms_002EControl_002EText = PathSet.nextCaption[8];
					num = (int)((num2 * 1290683578) ^ 0x10FF6FC5);
					continue;
				case 5u:
					((TextBoxBase)val).set_BackColor(Color.FromArgb(0, 0, 0));
					((TextBoxBase)val).set_ForeColor(((Control)this).get_ForeColor());
					val.set_Text(string.Empty);
					num = (int)(num2 * 309735393) ^ -642980803;
					continue;
				case 4u:
				{
					((Control)val).set_Font(new Font(PathSet.nextCaption[7], 8.25f, (FontStyle)1));
					TextBox obj = val;
					Size size = checked(new Size(((Control)this).get_Width() - 8, ((Control)this).get_Height() - 11));
					((Control)obj).set_Size(size);
					val.set_UseSystemPasswordChar(this.JoinBookmark);
					val = null;
					num = ((int)num2 * -1348755309) ^ -304423905;
					continue;
				}
				case 3u:
					((Control)this).add_TextChanged((EventHandler)delegate
					{
						ViewComponent();
					});
					SearchContext = new TextBox();
					num = (int)(num2 * 392359881) ^ -8945626;
					continue;
				case 1u:
					val.set_TextAlign((HorizontalAlignment)2);
					num = (int)((num2 * 823582896) ^ 0x794E2318);
					continue;
				case 0u:
					this.nextCaption = false;
					this.nextCaption = 32767;
					num = ((int)num2 * -106111925) ^ 0x250EE093;
					continue;
				case 2u:
					break;
				default:
					((Control)this).set_DoubleBuffered(true);
					return;
				}
				break;
			}
		}
	}

	protected override void RebuildConnection(PaintEventArgs nextCaption)
	{
	}

	protected override void ExtractXmlFile(EventArgs nextCaption)
	{
		((Control)this).OnTextChanged(nextCaption);
		((Control)this).Invalidate();
	}

	protected override void CleanServer(EventArgs nextCaption)
	{
		((Control)this).OnBackColorChanged(nextCaption);
		((TextBoxBase)SearchContext).set_BackColor(((Control)this).get_BackColor());
		((Control)this).Invalidate();
	}

	protected override void UncheckPane(EventArgs nextCaption)
	{
		((Control)this).OnForeColorChanged(nextCaption);
		((TextBoxBase)SearchContext).set_ForeColor(((Control)this).get_ForeColor());
		((Control)this).Invalidate();
	}

	protected override void DisposeRegistry(EventArgs nextCaption)
	{
		((Control)this).OnFontChanged(nextCaption);
		while (true)
		{
			int num = -1107472894;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB31192F1u) % 3u)
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
				((Control)SearchContext).set_Font(((Control)this).get_Font());
				num = (int)((num2 * 1179067076) ^ 0x337407E2);
			}
		}
	}

	protected override void NavigatePlugin(EventArgs nextCaption)
	{
		((Control)this).OnGotFocus(nextCaption);
		((Control)SearchContext).Focus();
	}

	public new void JoinBookmark()
	{
		System_002EWindows_002EForms_002EControl_002EText = SearchContext.get_Text();
	}

	public new void ViewComponent()
	{
		SearchContext.set_Text(System_002EWindows_002EForms_002EControl_002EText);
	}

	protected override void CleanContext(ref Message nextCaption)
	{
		int msg = ((Message)(ref nextCaption)).get_Msg();
		while (true)
		{
			int num = -1789512004;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE2B87877u) % 8u)
				{
				case 7u:
					((Control)this).Invalidate();
					num = ((int)num2 * -2114688203) ^ -2017498486;
					continue;
				case 6u:
					((Control)this).WndProc(ref nextCaption);
					DisposeDatabase();
					num = (int)((num2 * 7082536) ^ 0x25F3CFF7);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (msg == 15)
					{
						num3 = -1220510234;
						num4 = -1220510234;
					}
					else
					{
						num3 = -1965700520;
						num4 = -1965700520;
					}
					num = num3 ^ ((int)num2 * -2117856518);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1770788109) ^ 0x6E720DE4;
					continue;
				case 1u:
					((Control)this).WndProc(ref nextCaption);
					num = -76076262;
					continue;
				case 0u:
					num = ((int)num2 * -848259737) ^ 0x31F2830A;
					continue;
				default:
					return;
				case 4u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public override void DisposeDatabase()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		((Control)this).set_BackColor(Color.White);
		base.nextCaption.Clear(((Control)this).get_Parent().get_BackColor());
		Pen val = new Pen(Color.FromArgb(204, 204, 204), 1f);
		Font font = default(Font);
		Pen val3 = default(Pen);
		TextBox val2 = default(TextBox);
		while (true)
		{
			int num = 1113110798;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E26AE67u) % 8u)
				{
				case 7u:
					val2 = SearchContext;
					num = (int)(num2 * 128662684) ^ -1027022333;
					continue;
				case 6u:
					((TextBoxBase)val2).set_ForeColor(Color.FromArgb(72, 72, 72));
					((Control)val2).set_Font(font);
					val2.set_TextAlign(this.JoinBookmark);
					val2.set_UseSystemPasswordChar(this.JoinBookmark);
					num = ((int)num2 * -1927813446) ^ 0x6BDF9979;
					continue;
				case 5u:
					((Control)this).set_Height(checked(((Control)SearchContext).get_Height() + 16));
					font = new Font(PathSet.nextCaption[9], 9f, (FontStyle)0);
					num = (int)(num2 * 1687515501) ^ -1229659991;
					continue;
				case 3u:
				{
					Graphics obj = base.nextCaption;
					Brush white = Brushes.get_White();
					checked
					{
						Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
						obj.FillPath(white, ProjectContext.ToggleDatabase(rectangle, 2));
						Graphics obj2 = base.nextCaption;
						Pen obj3 = val3;
						rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
						obj2.DrawPath(obj3, ProjectContext.ToggleDatabase(rectangle, 2));
						Graphics obj4 = base.nextCaption;
						rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
						obj4.DrawPath(val, ProjectContext.ToggleDatabase(rectangle, 2));
					}
					num = ((int)num2 * -504686841) ^ -1926449521;
					continue;
				}
				case 1u:
					val3 = new Pen(Color.FromArgb(252, 252, 252), 7f);
					num = ((int)num2 * -792395605) ^ 0x6A02AC77;
					continue;
				case 0u:
					((Control)val2).set_Width(checked(((Control)this).get_Width() - 12));
					num = (int)(num2 * 847867384) ^ -130057463;
					continue;
				case 4u:
					break;
				default:
					val2 = null;
					JoinBookmark(((Control)this).get_Parent().get_BackColor(), ((Control)this).get_ClientRectangle());
					return;
				}
				break;
			}
		}
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private new void JoinBookmark(object sender, EventArgs e)
	{
		JoinBookmark();
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private new void ViewComponent(object sender, EventArgs e)
	{
		ViewComponent();
	}
}
