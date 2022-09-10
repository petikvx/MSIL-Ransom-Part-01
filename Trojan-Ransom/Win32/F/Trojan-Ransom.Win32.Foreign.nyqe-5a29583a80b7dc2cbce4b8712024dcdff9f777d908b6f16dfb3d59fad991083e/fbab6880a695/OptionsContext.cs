using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace fbab6880a695;

internal class OptionsContext : FileLayout
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
				int num = 1741054113;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7427E130u) % 3u)
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
					num = ((int)num2 * -1733749534) ^ -975945526;
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
			if (this.nextCaption != null)
			{
				goto IL_0036;
			}
			goto IL_00a8;
			IL_00a8:
			this.nextCaption = value;
			int num = 977574952;
			goto IL_007f;
			IL_007f:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2C74B0D4u) % 6u)
				{
				case 5u:
					((Control)this.nextCaption).add_TextChanged(eventHandler);
					num = ((int)num2 * -1887541344) ^ 0x6FA1CC0E;
					continue;
				case 4u:
					break;
				case 1u:
					((Control)this.nextCaption).remove_TextChanged(eventHandler);
					num = ((int)num2 * -231204321) ^ 0x660A4142;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (this.nextCaption != null)
					{
						num3 = 907681625;
						num4 = 907681625;
					}
					else
					{
						num3 = 566736534;
						num4 = 566736534;
					}
					num = num3 ^ ((int)num2 * -248553774);
					continue;
				}
				default:
					return;
				case 3u:
					goto IL_00a8;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0036;
			IL_0036:
			num = 1919859761;
			goto IL_007f;
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
			while (true)
			{
				int num = -1951473367;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEEAC87EDu) % 3u)
					{
					case 2u:
						goto IL_0013;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0013:
					this.nextCaption = value;
					((Control)this).Invalidate();
					num = (int)(num2 * 1143621918) ^ -947200794;
				}
			}
		}
	}

	public new int JoinBookmark
	{
		get
		{
			int result = this.nextCaption;
			while (true)
			{
				int num = 631321014;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2C20CCAEu) % 3u)
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
					num = (int)((num2 * 1274335240) ^ 0x28206998);
				}
			}
		}
		set
		{
			this.nextCaption = value;
			((TextBoxBase)SearchContext).set_MaxLength(this.JoinBookmark);
			while (true)
			{
				int num = -2056611211;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD4B65E60u) % 3u)
					{
					case 2u:
						goto IL_001a;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_001a:
					((Control)this).Invalidate();
					num = (int)((num2 * 875819375) ^ 0x467ABCB);
				}
			}
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
				int num = -1843291405;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFA10CFDEu) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = ((int)num2 * -1222023851) ^ 0x7F9F796A;
				}
			}
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			nextCaption = value;
			while (true)
			{
				int num = 1853837235;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x555C9319u) % 3u)
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
					num = ((int)num2 * -542182993) ^ 0x76EA002D;
				}
			}
		}
	}

	public OptionsContext()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		((Control)this).add_TextChanged((EventHandler)delegate
		{
			ViewComponent();
		});
		SearchContext = new TextBox();
		this.nextCaption = false;
		this.nextCaption = 32767;
		((Control)this).get_Controls().Add((Control)(object)SearchContext);
		TextBox searchContext = SearchContext;
		searchContext.set_ScrollBars((ScrollBars)2);
		searchContext.set_Multiline(true);
		((TextBoxBase)searchContext).set_BackColor(Color.FromArgb(0, 0, 0));
		((TextBoxBase)searchContext).set_ForeColor(((Control)this).get_ForeColor());
		searchContext.set_Text(string.Empty);
		searchContext.set_TextAlign((HorizontalAlignment)2);
		((TextBoxBase)searchContext).set_BorderStyle((BorderStyle)0);
		TextBox obj = searchContext;
		Point location = new Point(5, 8);
		((Control)obj).set_Location(location);
		((Control)searchContext).set_Font(new Font(PathSet.nextCaption[7], 8.25f, (FontStyle)1));
		TextBox obj2 = searchContext;
		Size size = checked(new Size(((Control)this).get_Width() - 8, ((Control)this).get_Height() - 11));
		((Control)obj2).set_Size(size);
		searchContext.set_UseSystemPasswordChar(this.JoinBookmark);
		searchContext = null;
		System_002EWindows_002EForms_002EControl_002EText = PathSet.nextCaption[8];
		((Control)this).set_DoubleBuffered(true);
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
		while (true)
		{
			int num = -1049538779;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5E541A1u) % 3u)
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
				((TextBoxBase)SearchContext).set_BackColor(((Control)this).get_BackColor());
				((Control)this).Invalidate();
				num = (int)((num2 * 2110182324) ^ 0x3D3FB82A);
			}
		}
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
		((Control)SearchContext).set_Font(((Control)this).get_Font());
	}

	protected override void NavigatePlugin(EventArgs nextCaption)
	{
		((Control)this).OnGotFocus(nextCaption);
		while (true)
		{
			int num = -355868276;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF031E1Fu) % 3u)
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
				((Control)SearchContext).Focus();
				num = ((int)num2 * -360810277) ^ -900235952;
			}
		}
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
		if (msg == 15)
		{
			goto IL_005a;
		}
		goto IL_00b9;
		IL_00b9:
		((Control)this).WndProc(ref nextCaption);
		int num = -1248444324;
		goto IL_0083;
		IL_0083:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x9BC8967Bu) % 9u)
			{
			case 7u:
				num = ((int)num2 * -248971499) ^ -28445068;
				continue;
			case 6u:
				num = ((int)num2 * -1685865419) ^ -349294685;
				continue;
			case 5u:
				((Control)this).Invalidate();
				num = ((int)num2 * -1285889189) ^ 0x36CBED14;
				continue;
			case 4u:
				((Control)this).WndProc(ref nextCaption);
				num = (int)((num2 * 777234620) ^ 0x3C4A3F5E);
				continue;
			case 3u:
				break;
			case 2u:
				num = (int)(num2 * 1535434446) ^ -1485711930;
				continue;
			case 0u:
				DisposeDatabase();
				num = ((int)num2 * -1430126992) ^ -1375713722;
				continue;
			default:
				return;
			case 1u:
				goto IL_00b9;
			case 8u:
				return;
			}
			break;
		}
		goto IL_005a;
		IL_005a:
		num = -1687402546;
		goto IL_0083;
	}

	public override void DisposeDatabase()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_BackColor(Color.White);
		base.nextCaption.Clear(((Control)this).get_Parent().get_BackColor());
		Pen val = new Pen(Color.FromArgb(204, 204, 204), 1f);
		Pen val2 = new Pen(Color.FromArgb(252, 252, 252), 7f);
		Font font = default(Font);
		TextBox searchContext = default(TextBox);
		while (true)
		{
			int num = 2046425539;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78665BECu) % 6u)
				{
				case 5u:
				{
					Graphics obj4 = base.nextCaption;
					Rectangle rectangle = checked(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
					obj4.DrawPath(val, ProjectContext.ToggleDatabase(rectangle, 2));
					num = (int)((num2 * 1889529926) ^ 0x6F24AFAC);
					continue;
				}
				case 4u:
					font = new Font(PathSet.nextCaption[9], 9f, (FontStyle)0);
					num = ((int)num2 * -55442098) ^ 0x70CC071;
					continue;
				case 3u:
				{
					Graphics obj2 = base.nextCaption;
					Brush white = Brushes.get_White();
					checked
					{
						Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
						obj2.FillPath(white, ProjectContext.ToggleDatabase(rectangle, 2));
						Graphics obj3 = base.nextCaption;
						rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
						obj3.DrawPath(val2, ProjectContext.ToggleDatabase(rectangle, 2));
					}
					num = (int)((num2 * 860962456) ^ 0x7FD09DCD);
					continue;
				}
				case 1u:
				{
					searchContext = SearchContext;
					TextBox obj = searchContext;
					Size size = checked(new Size(((Control)this).get_Width() - 10, ((Control)this).get_Height() - 14));
					((Control)obj).set_Size(size);
					((TextBoxBase)searchContext).set_ForeColor(Color.FromArgb(72, 72, 72));
					((Control)searchContext).set_Font(font);
					num = (int)(num2 * 2021153728) ^ -847909860;
					continue;
				}
				case 2u:
					break;
				default:
					searchContext.set_TextAlign(this.JoinBookmark);
					searchContext.set_UseSystemPasswordChar(this.JoinBookmark);
					searchContext = null;
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
	[CompilerGenerated]
	[DebuggerStepThrough]
	private new void ViewComponent(object sender, EventArgs e)
	{
		ViewComponent();
	}
}
