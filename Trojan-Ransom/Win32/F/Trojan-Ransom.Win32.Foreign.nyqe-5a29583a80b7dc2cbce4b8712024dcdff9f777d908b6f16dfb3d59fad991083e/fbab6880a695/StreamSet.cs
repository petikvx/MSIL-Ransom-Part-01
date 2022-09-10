using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace fbab6880a695;

internal class StreamSet : ComboBox
{
	private int nextCaption;

	private bool nextCaption;

	public StreamSet()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		while (true)
		{
			int num = -444055491;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCA873B9Fu) % 7u)
				{
				case 6u:
					((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
					num = (int)((num2 * 1995534316) ^ 0x7A4C8FFA);
					continue;
				case 4u:
					((Control)this).SetStyle((ControlStyles)73746, true);
					((ComboBox)this).set_ItemHeight(25);
					num = ((int)num2 * -161985734) ^ 0xAE7693;
					continue;
				case 3u:
					((ComboBox)this).add_DropDown((EventHandler)OpenProject);
					num = (int)(num2 * 1800018030) ^ -284363982;
					continue;
				case 2u:
					((Control)this).set_Font(new Font(PathSet.nextCaption[9], 9f, (FontStyle)0));
					num = ((int)num2 * -1977024652) ^ 0x525F21A7;
					continue;
				case 1u:
					((ComboBox)this).add_DropDownClosed((EventHandler)DisposeDatabase);
					((Control)this).add_TextChanged((EventHandler)ChangeActivity);
					num = ((int)num2 * -1935636610) ^ -929198576;
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	protected override void ToggleDatabase(MouseEventArgs nextCaption)
	{
		((Control)this).OnMouseMove(nextCaption);
		this.nextCaption = nextCaption.get_Location().X;
		((Control)this).Invalidate();
	}

	protected override void BatchBuildXmlFile(EventArgs nextCaption)
	{
		((ComboBox)this).OnMouseEnter(nextCaption);
		while (true)
		{
			int num = -1114908230;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD4478321u) % 4u)
				{
				case 3u:
					this.nextCaption = true;
					num = (int)((num2 * 1731116593) ^ 0x2FA01F5B);
					continue;
				case 1u:
					((Control)this).Invalidate();
					num = ((int)num2 * -1916583269) ^ 0x3E92AEAC;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	protected override void GenerateDevice(EventArgs nextCaption)
	{
		((ComboBox)this).OnMouseEnter(nextCaption);
		while (true)
		{
			int num = -1648367884;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0D1E44Au) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					((Control)this).Invalidate();
					return;
				}
				break;
				IL_0009:
				this.nextCaption = false;
				num = (int)(num2 * 79375669) ^ -1510547177;
			}
		}
	}

	protected override void RebuildSolution(PaintEventArgs nextCaption)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Invalid comparison between Unknown and I4
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected O, but got Unknown
		((Control)this).set_Font(new Font(PathSet.nextCaption[9], 9f, (FontStyle)0));
		LinearGradientBrush val6 = default(LinearGradientBrush);
		Graphics val2 = default(Graphics);
		SolidBrush val3 = default(SolidBrush);
		Pen val7 = default(Pen);
		Rectangle rectangle = default(Rectangle);
		int num3 = default(int);
		Font val4 = default(Font);
		Bitmap val = default(Bitmap);
		SizeF sizeF = default(SizeF);
		Pen val5 = default(Pen);
		while (true)
		{
			int num = -536612091;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x908FD309u) % 30u)
				{
				case 29u:
					val6 = new LinearGradientBrush(rectangle, Color.FromArgb(234, 234, 234), Color.FromArgb(242, 242, 242), 270f);
					num = (int)((num2 * 1202778703) ^ 0x4AEDF036);
					continue;
				case 27u:
					val2.Clear(Color.FromArgb(50, 50, 50));
					num = (int)((num2 * 327313589) ^ 0x5A0567C2);
					continue;
				case 26u:
					val3 = new SolidBrush(((ComboBox)this).get_ForeColor());
					num = ((int)num2 * -1956658712) ^ -82229230;
					continue;
				case 25u:
				{
					Graphics obj7 = val2;
					LinearGradientBrush obj8 = val6;
					rectangle = checked(new Rectangle(((Control)this).get_Width() - 22, 2, 20, ((Control)this).get_Height() - 4));
					obj7.FillRectangle((Brush)(object)obj8, rectangle);
					num = ((int)num2 * -463046611) ^ -1887752529;
					continue;
				}
				case 23u:
					val2.Dispose();
					num = ((int)num2 * -591375448) ^ 0x5CE4BADB;
					continue;
				case 22u:
				{
					Graphics obj9 = val2;
					LinearGradientBrush obj10 = val6;
					rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
					obj9.FillRectangle((Brush)(object)obj10, rectangle);
					num = (int)(num2 * 2112572048) ^ -1218417143;
					continue;
				}
				case 21u:
				{
					Graphics obj5 = val2;
					Pen obj6 = val7;
					int num7;
					checked
					{
						rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
						obj5.DrawPath(obj6, ProjectContext.ToggleDatabase(rectangle, 2));
						int num8;
						if (!((this.nextCaption >= ((Control)this).get_Width() - 20) & this.nextCaption))
						{
							num7 = 1844661149;
							num8 = 1844661149;
						}
						else
						{
							num7 = 1065674121;
							num8 = 1065674121;
						}
					}
					num = num7 ^ (int)(num2 * 586770058);
					continue;
				}
				case 20u:
				{
					rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
					val6 = new LinearGradientBrush(rectangle, Color.FromArgb(239, 239, 239), Color.FromArgb(236, 236, 236), 90f);
					Graphics obj3 = val2;
					LinearGradientBrush obj4 = val6;
					rectangle = checked(new Rectangle(2, 2, ((Control)this).get_Width() - 27, ((Control)this).get_Height() - 4));
					obj3.FillRectangle((Brush)(object)obj4, rectangle);
					num = ((int)num2 * -1037331702) ^ 0x6CEB1E8C;
					continue;
				}
				case 19u:
					checked
					{
						val2.DrawString(Conversions.ToString(((ComboBox)this).get_Items().get_Item(((ComboBox)this).get_SelectedIndex())), ((Control)this).get_Font(), (Brush)(object)val3, 4f, (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(num3 / 2)));
						val2.DrawString(PathSet.nextCaption[14], val4, (Brush)(object)val3, (float)(((Control)this).get_Width() - 22), (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(num3 / 2)));
					}
					num = (int)(num2 * 112120625) ^ -703907483;
					continue;
				case 18u:
					val7 = new Pen(Color.FromArgb(204, 204, 204), 1f);
					num = ((int)num2 * -66775863) ^ -985674262;
					continue;
				case 17u:
					num = ((int)num2 * -248392713) ^ 0x5469D0F7;
					continue;
				case 16u:
					rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
					num = (int)(num2 * 149988766) ^ -388675302;
					continue;
				case 15u:
					val2.DrawLine(new Pen(Color.FromArgb(120, 255, 255, 255)), 1, 1, checked(((Control)this).get_Width() - 3), 1);
					NewLateBinding.LateCall((object)nextCaption.get_Graphics(), (Type)null, "DrawImage", new object[3]
					{
						RuntimeHelpers.GetObjectValue(((Image)val).Clone()),
						0,
						0
					}, (string[])null, (Type[])null, (bool[])null, true);
					num = -2045616178;
					continue;
				case 14u:
					checked
					{
						val2.DrawString(PathSet.nextCaption[13], ((Control)this).get_Font(), (Brush)(object)val3, 4f, (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(num3 / 2)));
						num = -1287632386;
						continue;
					}
				case 13u:
					checked
					{
						val2.DrawString(PathSet.nextCaption[14], val4, (Brush)(object)val3, (float)(((Control)this).get_Width() - 22), (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(num3 / 2)));
					}
					num = ((int)num2 * -994156088) ^ 0x6F4C7870;
					continue;
				case 12u:
				{
					num3 = checked((int)Math.Round(sizeF.Height));
					int num10;
					int num11;
					if (((ComboBox)this).get_SelectedIndex() != -1)
					{
						num10 = 1233325300;
						num11 = 1233325300;
					}
					else
					{
						num10 = 339524208;
						num11 = 339524208;
					}
					num = num10 ^ ((int)num2 * -1567244608);
					continue;
				}
				case 11u:
					val2 = Graphics.FromImage((Image)(object)val);
					val4 = new Font(PathSet.nextCaption[11], 11f);
					num = ((int)num2 * -1140845602) ^ 0x5EB8D0F2;
					continue;
				case 10u:
					val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
					num = -1555427736;
					continue;
				case 9u:
				{
					int num9;
					if (!((((ComboBox)this).get_Items() != null) & (((ComboBox)this).get_Items().get_Count() > 0)))
					{
						num = -18274513;
						num9 = -18274513;
					}
					else
					{
						num = -652383917;
						num9 = -652383917;
					}
					continue;
				}
				case 8u:
				{
					int num6;
					if (!((this.nextCaption < checked(((Control)this).get_Width() - 20)) & this.nextCaption))
					{
						num = -402337528;
						num6 = -402337528;
					}
					else
					{
						num = -1501605805;
						num6 = -1501605805;
					}
					continue;
				}
				case 7u:
					sizeF = val2.MeasureString(PathSet.nextCaption[13], ((Control)this).get_Font());
					num = -1963370573;
					continue;
				case 6u:
					val6 = new LinearGradientBrush(rectangle, Color.FromArgb(239, 239, 239), Color.FromArgb(236, 236, 236), 90f);
					num = ((int)num2 * -579274963) ^ 0xF4558EE;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if ((int)((ComboBox)this).get_DropDownStyle() == 2)
					{
						num4 = -379993323;
						num5 = -379993323;
					}
					else
					{
						num4 = -682619731;
						num5 = -682619731;
					}
					num = num4 ^ ((int)num2 * -1576663678);
					continue;
				}
				case 4u:
					rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
					num = (int)((num2 * 380458876) ^ 0x47ADD01D);
					continue;
				case 3u:
				{
					Graphics obj = val2;
					Pen obj2 = val5;
					rectangle = checked(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
					obj.DrawPath(obj2, ProjectContext.ToggleDatabase(rectangle, 2));
					num = ((int)num2 * -1063140852) ^ -665442484;
					continue;
				}
				case 2u:
					((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
					num = (int)(num2 * 1491569955) ^ -1541832491;
					continue;
				case 1u:
					val5 = new Pen(Color.FromArgb(237, 237, 237), 6f);
					num = (int)(num2 * 228593031) ^ -944618347;
					continue;
				case 0u:
					checked
					{
						val2.DrawString(Conversions.ToString(((ComboBox)this).get_Items().get_Item(0)), ((Control)this).get_Font(), (Brush)(object)val3, 4f, (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(num3 / 2)));
						val2.DrawString(PathSet.nextCaption[14], val4, (Brush)(object)val3, (float)(((Control)this).get_Width() - 22), (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(num3 / 2)));
					}
					num = (int)((num2 * 1510984680) ^ 0x3A72E018);
					continue;
				case 28u:
					break;
				default:
					((Image)val).Dispose();
					return;
				}
				break;
			}
		}
	}

	protected override void DisconnectPlugin(DrawItemEventArgs nextCaption)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		if (nextCaption.get_Index() < 0)
		{
			goto IL_01f0;
		}
		goto IL_0270;
		IL_0270:
		Rectangle rectangle = default(Rectangle);
		rectangle.X = nextCaption.get_Bounds().X;
		int num = 1252585576;
		goto IL_022a;
		IL_022a:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x330E26DCu) % 13u)
			{
			case 12u:
			{
				nextCaption.DrawBackground();
				int num3;
				int num4;
				if (!(((int)nextCaption.get_State() == 785) | ((int)nextCaption.get_State() == 17)))
				{
					num3 = 179316307;
					num4 = 179316307;
				}
				else
				{
					num3 = 1135652442;
					num4 = 1135652442;
				}
				num = num3 ^ ((int)num2 * -1739089232);
				continue;
			}
			case 11u:
				rectangle.Width = checked(nextCaption.get_Bounds().Width - 1);
				num = (int)((num2 * 1109706386) ^ 0x54296DCC);
				continue;
			case 10u:
				((ComboBox)this).OnDrawItem(nextCaption);
				num = 768969008;
				continue;
			case 9u:
				nextCaption.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.FromArgb(50, ((ComboBox)this).get_ForeColor())), nextCaption.get_Bounds());
				nextCaption.get_Graphics().DrawString(((ComboBox)this).get_Items().get_Item(nextCaption.get_Index()).ToString(), nextCaption.get_Font(), Brushes.get_Black(), (float)nextCaption.get_Bounds().X, (float)checked(nextCaption.get_Bounds().Y + 5));
				num = (int)(num2 * 1169037598) ^ -527712913;
				continue;
			case 8u:
				rectangle.Y = nextCaption.get_Bounds().Y;
				num = (int)(num2 * 842131029) ^ -630859980;
				continue;
			case 6u:
				nextCaption.get_Graphics().DrawString(((ComboBox)this).get_Items().get_Item(nextCaption.get_Index()).ToString(), nextCaption.get_Font(), Brushes.get_Black(), (float)nextCaption.get_Bounds().X, (float)checked(nextCaption.get_Bounds().Y + 4));
				num = ((int)num2 * -1523544217) ^ -1353569620;
				continue;
			case 5u:
				nextCaption.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.White), nextCaption.get_Bounds());
				num = 241299117;
				continue;
			case 4u:
				nextCaption.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.FromArgb(235, 235, 235)), nextCaption.get_Bounds());
				num = (int)(num2 * 711514957) ^ -2100542956;
				continue;
			case 3u:
				break;
			case 1u:
				num = ((int)num2 * -1889369297) ^ 0x53FB2275;
				continue;
			case 0u:
				rectangle.Height = checked(nextCaption.get_Bounds().Height - 1);
				num = (int)(num2 * 930922565) ^ -852072796;
				continue;
			default:
				return;
			case 7u:
				goto IL_0270;
			case 2u:
				return;
			}
			break;
		}
		goto IL_01f0;
		IL_01f0:
		num = 361385239;
		goto IL_022a;
	}

	private void OpenProject(object sender, EventArgs e)
	{
	}

	private void DisposeDatabase(object sender, EventArgs e)
	{
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)0);
		while (true)
		{
			int num = -1294176407;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA7A7D67Eu) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 2u:
					break;
				default:
					((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
					return;
				}
				break;
				IL_0009:
				Application.DoEvents();
				num = ((int)num2 * -632919624) ^ -1200321161;
			}
		}
	}

	private void ChangeActivity(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}
}
