using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fbab6880a695;

internal abstract class QueueDesigner : ContainerControl
{
	private struct SymbolContext
	{
		public readonly Cursor nextCaption;

		public readonly byte nextCaption;

		public SymbolContext(Cursor nextCaption, byte parentLog)
		{
			this = default(SymbolContext);
			this.nextCaption = nextCaption;
			this.nextCaption = parentLog;
		}
	}

	protected Graphics nextCaption;

	private bool nextCaption;

	private bool parentLog;

	private int nextCaption;

	private IntPtr nextCaption;

	private bool propStorePosition;

	private bool variableID;

	private bool query;

	private bool timerHeader;

	private Point nextCaption;

	private SymbolContext nextCaption;

	private SymbolContext parentLog;

	protected Rectangle nextCaption;

	private Color nextCaption;

	private Image nextCaption;

	private Size nextCaption;

	private Rectangle parentLog;

	private LinearGradientBrush nextCaption;

	private SolidBrush nextCaption;

	string Text
	{
		get
		{
			string text = ((Control)this).get_Text();
			while (true)
			{
				int num = -2146829353;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB46C9F28u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return text;
					}
					break;
					IL_0009:
					num = (int)(num2 * 845327505) ^ -1514100688;
				}
			}
		}
		set
		{
			((Control)this).set_Text(value);
			((Control)this).Invalidate();
		}
	}

	public bool AddSymbol
	{
		get
		{
			return this.parentLog;
		}
		set
		{
			this.parentLog = value;
		}
	}

	public int AddSymbol
	{
		get
		{
			int result = this.nextCaption;
			while (true)
			{
				int num = -1334804708;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB7B99870u) % 3u)
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
					num = ((int)num2 * -2041642430) ^ 0x7482FBF;
				}
			}
		}
		set
		{
			this.nextCaption = value;
			ref Rectangle reference = ref this.nextCaption;
			reference = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, this.nextCaption - 7));
		}
	}

	public Color AddSymbol
	{
		get
		{
			Color result = this.nextCaption;
			while (true)
			{
				int num = -804849631;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA1BFAADAu) % 3u)
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
					num = ((int)num2 * -2068188796) ^ -1475894069;
				}
			}
		}
		set
		{
			this.nextCaption = value;
			while (true)
			{
				int num = -506942706;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD117B66Au) % 3u)
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
					num = ((int)num2 * -160760245) ^ 0x308204CF;
				}
			}
		}
	}

	public Image AddSymbol
	{
		get
		{
			Image result = this.nextCaption;
			while (true)
			{
				int num = 88131101;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA4951Bu) % 3u)
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
					num = ((int)num2 * -1575247154) ^ -186079265;
				}
			}
		}
		set
		{
			this.nextCaption = value;
			while (true)
			{
				int num = 632623521;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x526B928u) % 3u)
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
					num = ((int)num2 * -657856719) ^ 0x27399F5C;
				}
			}
		}
	}

	public int DeletePlugin
	{
		get
		{
			if (this.nextCaption == null)
			{
				goto IL_0008;
			}
			goto IL_0052;
			IL_0052:
			int result = this.nextCaption.get_Width();
			int num = -1826559013;
			goto IL_002d;
			IL_002d:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA252BC0Au) % 5u)
				{
				case 3u:
					break;
				case 2u:
					num = (int)((num2 * 1515864594) ^ 0x606300F9);
					continue;
				case 1u:
					result = 0;
					num = ((int)num2 * -1926596566) ^ 0x30015A2F;
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
			num = -893880108;
			goto IL_002d;
		}
	}

	public QueueDesigner()
	{
		this.parentLog = true;
		this.nextCaption = 24;
		((Control)this).SetStyle((ControlStyles)139270, true);
	}

	protected override void ToggleDatabase(EventArgs nextCaption)
	{
		((Control)this).set_Dock((DockStyle)5);
		while (true)
		{
			int num = -1454267517;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB438BB81u) % 8u)
				{
				case 7u:
				{
					int num5;
					int num6;
					if (this.nextCaption == Color.Empty)
					{
						num5 = -1545514029;
						num6 = -1545514029;
					}
					else
					{
						num5 = -1930710314;
						num6 = -1930710314;
					}
					num = num5 ^ ((int)num2 * -1307892071);
					continue;
				}
				case 5u:
					((ContainerControl)this).get_ParentForm().set_FormBorderStyle((FormBorderStyle)0);
					num = -642355827;
					continue;
				case 4u:
					((Control)this).OnHandleCreated(nextCaption);
					num = -417640398;
					continue;
				case 2u:
					this.nextCaption = ((Control)this).get_Parent() is Form;
					num = (int)((num2 * 11623844) ^ 0x32515040);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!this.nextCaption)
					{
						num3 = 1824079384;
						num4 = 1824079384;
					}
					else
					{
						num3 = 927393147;
						num4 = 927393147;
					}
					num = num3 ^ (int)(num2 * 1339805613);
					continue;
				}
				case 0u:
					((ContainerControl)this).get_ParentForm().set_TransparencyKey(this.nextCaption);
					num = ((int)num2 * -76134364) ^ 0x5DFAF284;
					continue;
				default:
					return;
				case 6u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	protected override void RebuildSolution(MouseEventArgs nextCaption)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Invalid comparison between Unknown and I4
		if ((int)nextCaption.get_Button() != 1048576)
		{
			goto IL_00d0;
		}
		goto IL_01fc;
		IL_01fc:
		int num;
		int num2;
		if (this.nextCaption)
		{
			num = -881074443;
			num2 = -881074443;
		}
		else
		{
			num = -1955378022;
			num2 = -1955378022;
		}
		goto IL_019f;
		IL_019f:
		IntPtr intPtr = default(IntPtr);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xB363150Bu) % 15u)
			{
			case 13u:
			{
				ref IntPtr reference = ref this.nextCaption;
				reference = new IntPtr(this.nextCaption.nextCaption);
				num = -2008815243;
				continue;
			}
			case 12u:
				num = ((int)num3 * -1310313669) ^ 0x400F0767;
				continue;
			case 11u:
				num = ((int)num3 * -734937061) ^ 0x36D8F5A8;
				continue;
			case 10u:
			{
				Message val = Message.Create(((Control)this).get_Parent().get_Handle(), 161, this.nextCaption, intPtr);
				((Control)this).DefWndProc(ref val);
				num = (int)(num3 * 1207784650) ^ -1536963176;
				continue;
			}
			case 9u:
				num = ((int)num3 * -1521431116) ^ -982371747;
				continue;
			case 8u:
			{
				ref IntPtr reference2 = ref this.nextCaption;
				reference2 = new IntPtr(2);
				num = ((int)num3 * -1445275111) ^ 0x3F242920;
				continue;
			}
			case 7u:
				break;
			case 6u:
				goto IL_00da;
			case 5u:
				num = ((int)num3 * -77620001) ^ 0x6B28EDC1;
				continue;
			case 4u:
				((Control)this).set_Capture(false);
				num = -1413329548;
				continue;
			case 3u:
				((Control)this).OnMouseDown(nextCaption);
				num = (int)(num3 * 1319135235) ^ -459406081;
				continue;
			case 1u:
			{
				int num4;
				int num5;
				if ((int)((ContainerControl)this).get_ParentForm().get_WindowState() != 2)
				{
					num4 = 362293122;
					num5 = 362293122;
				}
				else
				{
					num4 = 191827942;
					num5 = 191827942;
				}
				num = num4 ^ (int)(num3 * 1777631860);
				continue;
			}
			case 0u:
				goto IL_016e;
			default:
				return;
			case 14u:
				goto IL_01fc;
			case 2u:
				return;
			}
			break;
			IL_016e:
			int num6;
			if ((this.nextCaption.nextCaption == 0) | !this.parentLog)
			{
				num = -1728165725;
				num6 = -1728165725;
			}
			else
			{
				num = -1693705559;
				num6 = -1693705559;
			}
			continue;
			IL_00da:
			int num7;
			if (!this.nextCaption.Contains(nextCaption.get_Location()))
			{
				num = -50944208;
				num7 = -50944208;
			}
			else
			{
				num = -1297169770;
				num7 = -1297169770;
			}
		}
		goto IL_00d0;
		IL_00d0:
		num = -185113276;
		goto IL_019f;
	}

	private SymbolContext AddSymbol()
	{
		this.nextCaption = ((Control)this).PointToClient(Control.get_MousePosition());
		SymbolContext symbolContext = default(SymbolContext);
		SymbolContext result = default(SymbolContext);
		while (true)
		{
			int num = 303397860;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDBE748Eu) % 30u)
				{
				case 29u:
				{
					int num11;
					if (!variableID)
					{
						num = 1696954750;
						num11 = 1696954750;
					}
					else
					{
						num = 501771563;
						num11 = 501771563;
					}
					continue;
				}
				case 28u:
					symbolContext = new SymbolContext(Cursors.get_SizeNESW(), 16);
					num = (int)((num2 * 1455841159) ^ 0x748D8A6A);
					continue;
				case 27u:
				{
					int num9;
					if (timerHeader)
					{
						num = 736985200;
						num9 = 736985200;
					}
					else
					{
						num = 34069511;
						num9 = 34069511;
					}
					continue;
				}
				case 26u:
					symbolContext = new SymbolContext(Cursors.get_SizeNWSE(), 13);
					result = symbolContext;
					num = ((int)num2 * -1282769983) ^ 0x4D773859;
					continue;
				case 25u:
					symbolContext = new SymbolContext(Cursors.get_Default(), 0);
					result = symbolContext;
					num = 843700859;
					continue;
				case 24u:
					symbolContext = new SymbolContext(Cursors.get_SizeNESW(), 14);
					result = symbolContext;
					num = (int)((num2 * 1291376801) ^ 0x7EE789E3);
					continue;
				case 23u:
					num = (int)(num2 * 10151679) ^ -1467699246;
					continue;
				case 22u:
					symbolContext = new SymbolContext(Cursors.get_SizeWE(), 10);
					num = ((int)num2 * -839814648) ^ 0x761F229B;
					continue;
				case 21u:
					result = symbolContext;
					num = ((int)num2 * -1427009888) ^ -2106306360;
					continue;
				case 20u:
					symbolContext = new SymbolContext(Cursors.get_SizeNS(), 12);
					result = symbolContext;
					num = (int)((num2 * 377157952) ^ 0x10C0919B);
					continue;
				case 19u:
					result = symbolContext;
					num = ((int)num2 * -329312805) ^ 0x3747E02C;
					continue;
				case 18u:
					variableID = this.nextCaption.X > checked(((Control)this).get_Width() - 7);
					num = (int)((num2 * 1409581598) ^ 0x28B2BC0A);
					continue;
				case 16u:
					num = (int)(num2 * 1781535266) ^ -76564745;
					continue;
				case 15u:
					symbolContext = new SymbolContext(Cursors.get_SizeNWSE(), 17);
					result = symbolContext;
					num = (int)((num2 * 1311627126) ^ 0x57E9728D);
					continue;
				case 14u:
				{
					int num10;
					if (!propStorePosition)
					{
						num = 507203459;
						num10 = 507203459;
					}
					else
					{
						num = 740109514;
						num10 = 740109514;
					}
					continue;
				}
				case 13u:
					num = ((int)num2 * -1469327144) ^ 0x2B124BC3;
					continue;
				case 12u:
					query = this.nextCaption.Y < 7;
					timerHeader = this.nextCaption.Y > checked(((Control)this).get_Height() - 7);
					num = ((int)num2 * -422132353) ^ 0x31F45151;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (propStorePosition & query)
					{
						num7 = 677218473;
						num8 = 677218473;
					}
					else
					{
						num7 = 963888768;
						num8 = 963888768;
					}
					num = num7 ^ ((int)num2 * -1033419113);
					continue;
				}
				case 10u:
				{
					int num6;
					if (!(variableID & query))
					{
						num = 758305776;
						num6 = 758305776;
					}
					else
					{
						num = 426983446;
						num6 = 426983446;
					}
					continue;
				}
				case 8u:
					propStorePosition = this.nextCaption.X < 7;
					num = ((int)num2 * -1021501792) ^ 0x634617BE;
					continue;
				case 7u:
					symbolContext = new SymbolContext(Cursors.get_SizeWE(), 11);
					num = (int)((num2 * 1017734126) ^ 0x34B6CF23);
					continue;
				case 6u:
					result = symbolContext;
					num = ((int)num2 * -1090905329) ^ -1562988023;
					continue;
				case 5u:
				{
					int num5;
					if (!(propStorePosition & timerHeader))
					{
						num = 1971455132;
						num5 = 1971455132;
					}
					else
					{
						num = 93599528;
						num5 = 93599528;
					}
					continue;
				}
				case 4u:
					symbolContext = new SymbolContext(Cursors.get_SizeNS(), 15);
					num = (int)((num2 * 12197952) ^ 0x4F5721D7);
					continue;
				case 3u:
					num = ((int)num2 * -1361801304) ^ 0xFFF4FB3;
					continue;
				case 2u:
				{
					int num4;
					if (!query)
					{
						num = 1858880403;
						num4 = 1858880403;
					}
					else
					{
						num = 1487335958;
						num4 = 1487335958;
					}
					continue;
				}
				case 1u:
					result = symbolContext;
					num = (int)((num2 * 1219720265) ^ 0x5506053A);
					continue;
				case 0u:
				{
					int num3;
					if (variableID & timerHeader)
					{
						num = 1622457039;
						num3 = 1622457039;
					}
					else
					{
						num = 2085818994;
						num3 = 2085818994;
					}
					continue;
				}
				case 17u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void AddSymbol()
	{
		this.parentLog = this.AddSymbol();
		while (true)
		{
			int num = 1518618799;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x315AD02Du) % 6u)
				{
				case 4u:
					num = (int)((num2 * 613894202) ^ 0x4C261AE2);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (this.nextCaption.nextCaption != this.parentLog.nextCaption)
					{
						num3 = -694574527;
						num4 = -694574527;
					}
					else
					{
						num3 = -277830423;
						num4 = -277830423;
					}
					num = num3 ^ ((int)num2 * -830784712);
					continue;
				}
				case 1u:
					((Control)this).set_Cursor(this.nextCaption.nextCaption);
					num = ((int)num2 * -1851366214) ^ 0x4F039814;
					continue;
				case 0u:
					this.nextCaption = this.AddSymbol();
					num = 2003880838;
					continue;
				default:
					return;
				case 3u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	protected override void DisconnectPlugin(MouseEventArgs nextCaption)
	{
		if (this.parentLog)
		{
			goto IL_0008;
		}
		goto IL_0043;
		IL_0043:
		((Control)this).OnMouseMove(nextCaption);
		int num = 1388873437;
		goto IL_0022;
		IL_0022:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x49E886E9u) % 4u)
			{
			case 2u:
				break;
			case 1u:
				this.AddSymbol();
				num = ((int)num2 * -631028195) ^ -1059550137;
				continue;
			default:
				return;
			case 3u:
				goto IL_0043;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0008;
		IL_0008:
		num = 450064548;
		goto IL_0022;
	}

	protected override void OpenProject(EventArgs nextCaption)
	{
		if (((Control)this).get_Width() == 0)
		{
			return;
		}
		while (true)
		{
			int num = -2111873537;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB91E2000u) % 7u)
				{
				case 6u:
					((Control)this).Invalidate();
					num = ((int)num2 * -345501205) ^ 0x70FC34BE;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (((Control)this).get_Height() != 0)
					{
						num3 = -2008026870;
						num4 = -2008026870;
					}
					else
					{
						num3 = -609054296;
						num4 = -609054296;
					}
					num = num3 ^ (int)(num2 * 947251068);
					continue;
				}
				case 3u:
				{
					ref Rectangle reference = ref this.nextCaption;
					reference = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, this.nextCaption - 7));
					num = -1761586663;
					continue;
				}
				case 1u:
					((Control)this).OnSizeChanged(nextCaption);
					num = (int)(num2 * 1689001127) ^ -1742328975;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
				case 5u:
					return;
				}
				break;
			}
		}
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
			int num = -1811018167;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2A20211u) % 6u)
				{
				case 4u:
					DisposeDatabase();
					num = (int)((num2 * 1611418764) ^ 0x4FCA72F1);
					continue;
				case 3u:
					this.nextCaption = nextCaption.get_Graphics();
					num = -1877922837;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (((Control)this).get_Height() == 0)
					{
						num3 = -632706294;
						num4 = -632706294;
					}
					else
					{
						num3 = -1568543338;
						num4 = -1568543338;
					}
					num = num3 ^ (int)(num2 * 1313524646);
					continue;
				}
				default:
					return;
				case 5u:
					break;
				case 0u:
				case 1u:
					return;
				}
				break;
			}
		}
	}

	protected void AddSymbol(Color nextCaption, Rectangle parentLog)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		this.nextCaption = new SolidBrush(nextCaption);
		while (true)
		{
			int num = -250419113;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xABABB284u) % 5u)
				{
				case 3u:
					this.nextCaption.FillRectangle((Brush)(object)this.nextCaption, checked(parentLog.X + (parentLog.Width - 1)), parentLog.Y, 1, 1);
					num = (int)((num2 * 1615133060) ^ 0x5759C9F4);
					continue;
				case 2u:
					checked
					{
						this.nextCaption.FillRectangle((Brush)(object)this.nextCaption, parentLog.X, parentLog.Y + (parentLog.Height - 1), 1, 1);
						this.nextCaption.FillRectangle((Brush)(object)this.nextCaption, parentLog.X + (parentLog.Width - 1), parentLog.Y + (parentLog.Height - 1), 1, 1);
					}
					num = (int)(num2 * 638452862) ^ -1667876723;
					continue;
				case 1u:
					this.nextCaption.FillRectangle((Brush)(object)this.nextCaption, parentLog.X, parentLog.Y, 1, 1);
					num = ((int)num2 * -84537471) ^ 0x7CD7B6C8;
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	protected void AddSymbol(Pen nextCaption, Pen parentLog, Rectangle propStorePosition)
	{
		checked
		{
			this.nextCaption.DrawRectangle(nextCaption, propStorePosition.X, propStorePosition.Y, propStorePosition.Width - 1, propStorePosition.Height - 1);
			this.nextCaption.DrawRectangle(parentLog, propStorePosition.X + 1, propStorePosition.Y + 1, propStorePosition.Width - 3, propStorePosition.Height - 3);
		}
	}

	protected void AddSymbol(HorizontalAlignment nextCaption, Color parentLog, int propStorePosition)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		AddSymbol(nextCaption, parentLog, propStorePosition, 0);
	}

	protected void AddSymbol(HorizontalAlignment nextCaption, Color parentLog, int propStorePosition, int variableID)
	{
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected I4, but got Unknown
		if (string.IsNullOrEmpty(System_002EWindows_002EForms_002EControl_002EText))
		{
			goto IL_0064;
		}
		goto IL_0163;
		IL_0163:
		this.nextCaption = this.nextCaption.MeasureString(System_002EWindows_002EForms_002EControl_002EText, ((Control)this).get_Font()).ToSize();
		this.nextCaption = new SolidBrush(parentLog);
		switch ((int)nextCaption)
		{
		case 0:
			break;
		case 1:
			goto IL_006b;
		case 2:
			goto IL_00ff;
		default:
			goto IL_0159;
		}
		goto IL_0024;
		IL_0159:
		int num = -1930741485;
		goto IL_00cb;
		IL_0024:
		checked
		{
			this.nextCaption.DrawString(System_002EWindows_002EForms_002EControl_002EText, ((Control)this).get_Font(), (Brush)(object)this.nextCaption, (float)propStorePosition, (float)(unchecked(this.nextCaption / 2) - unchecked(this.nextCaption.Height / 2) + variableID));
			num = -699820007;
			goto IL_00cb;
		}
		IL_00cb:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xDBA5112Bu) % 8u)
			{
			case 6u:
				num = ((int)num2 * -1556430994) ^ -1688836339;
				continue;
			case 5u:
				break;
			case 4u:
				goto IL_0064;
			case 3u:
				goto IL_006b;
			case 0u:
				num = (int)(num2 * 929251375) ^ -247006639;
				continue;
			default:
				return;
			case 1u:
				goto IL_00ff;
			case 7u:
				goto IL_0163;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0024;
		IL_00ff:
		checked
		{
			this.nextCaption.DrawString(System_002EWindows_002EForms_002EControl_002EText, ((Control)this).get_Font(), (Brush)(object)this.nextCaption, (float)(unchecked(((Control)this).get_Width() / 2) - unchecked(this.nextCaption.Width / 2) + propStorePosition), (float)(unchecked(this.nextCaption / 2) - unchecked(this.nextCaption.Height / 2) + variableID));
			num = -699820007;
			goto IL_00cb;
		}
		IL_0064:
		num = -1043146259;
		goto IL_00cb;
		IL_006b:
		checked
		{
			this.nextCaption.DrawString(System_002EWindows_002EForms_002EControl_002EText, ((Control)this).get_Font(), (Brush)(object)this.nextCaption, (float)(((Control)this).get_Width() - this.nextCaption.Width - propStorePosition), (float)(unchecked(this.nextCaption / 2) - unchecked(this.nextCaption.Height / 2) + variableID));
			num = -699820007;
			goto IL_00cb;
		}
	}

	protected void AddSymbol(HorizontalAlignment nextCaption, int parentLog)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		AddSymbol(nextCaption, parentLog, 0);
	}

	protected void AddSymbol(HorizontalAlignment nextCaption, int parentLog, int propStorePosition)
	{
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected I4, but got Unknown
		if (this.nextCaption == null)
		{
			goto IL_00b5;
		}
		goto IL_013e;
		IL_013e:
		switch ((int)nextCaption)
		{
		case 0:
			break;
		case 1:
			goto IL_0071;
		case 2:
			goto IL_00f0;
		default:
			goto IL_0134;
		}
		goto IL_0022;
		IL_0134:
		int num = 2079208967;
		goto IL_00ba;
		IL_0022:
		checked
		{
			this.nextCaption.DrawImage(this.nextCaption, parentLog, unchecked(this.nextCaption / 2) - unchecked(this.nextCaption.get_Height() / 2) + propStorePosition);
			num = 1360712319;
			goto IL_00ba;
		}
		IL_00ba:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x4346D697u) % 9u)
			{
			case 8u:
				num = ((int)num2 * -1521437353) ^ -460422390;
				continue;
			case 7u:
				break;
			case 5u:
				num = (int)(num2 * 111635690) ^ -237786271;
				continue;
			case 4u:
				num = (int)((num2 * 439824432) ^ 0x79AFC97F);
				continue;
			case 3u:
				goto IL_0071;
			case 2u:
				goto IL_00b5;
			default:
				return;
			case 6u:
				goto IL_00f0;
			case 0u:
				goto IL_013e;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0022;
		IL_00b5:
		num = 849105540;
		goto IL_00ba;
		IL_00f0:
		checked
		{
			this.nextCaption.DrawImage(this.nextCaption, unchecked(((Control)this).get_Width() / 2) - unchecked(this.nextCaption.get_Width() / 2), unchecked(this.nextCaption / 2) - unchecked(this.nextCaption.get_Height() / 2));
			num = 1360712319;
			goto IL_00ba;
		}
		IL_0071:
		checked
		{
			this.nextCaption.DrawImage(this.nextCaption, ((Control)this).get_Width() - this.nextCaption.get_Width() - parentLog, unchecked(this.nextCaption / 2) - unchecked(this.nextCaption.get_Height() / 2) + propStorePosition);
			num = 2032351460;
			goto IL_00ba;
		}
	}

	protected void AddSymbol(Color nextCaption, Color parentLog, int propStorePosition, int variableID, int query, int timerHeader, float activeManager)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		ref Rectangle reference = ref this.parentLog;
		reference = new Rectangle(propStorePosition, variableID, query, timerHeader);
		this.nextCaption = new LinearGradientBrush(this.parentLog, nextCaption, parentLog, activeManager);
		this.nextCaption.FillRectangle((Brush)(object)this.nextCaption, this.parentLog);
	}
}
