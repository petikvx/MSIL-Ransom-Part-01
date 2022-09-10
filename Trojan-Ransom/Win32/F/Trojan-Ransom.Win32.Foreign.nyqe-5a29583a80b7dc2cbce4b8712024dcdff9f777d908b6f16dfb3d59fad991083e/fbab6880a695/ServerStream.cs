using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fbab6880a695;

internal class ServerStream : FileLayout
{
	public ServerStream()
	{
		while (true)
		{
			int num = 1791167779;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E7547E2u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
				{
					Size size = new Size(((Control)this).get_Width(), 20);
					((Control)this).set_Size(size);
					return;
				}
				}
				break;
				IL_0008:
				((Control)this).set_Dock((DockStyle)2);
				num = ((int)num2 * -316134405) ^ 0x2855CECD;
			}
		}
	}

	public override void DisposeDatabase()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		((Control)this).set_Font(new Font(PathSet.nextCaption[7], 10f));
		base.nextCaption.Clear(((Control)this).get_BackColor());
		while (true)
		{
			int num = -278317111;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5FCFBACu) % 12u)
				{
				case 9u:
					base.nextCaption.set_SmoothingMode((SmoothingMode)2);
					switch (nextCaption)
					{
					case FormList.nextCaption:
						goto IL_0062;
					case FormList.parentLog:
						goto IL_00a1;
					case FormList.propStorePosition:
						goto IL_00e3;
					}
					num = ((int)num2 * -610117369) ^ 0x315B6E1;
					continue;
				case 0u:
					goto IL_0062;
				case 7u:
					goto IL_00a1;
				case 4u:
					goto IL_00e3;
				case 8u:
					JoinBookmark((HorizontalAlignment)0, Color.FromArgb(240, 240, 240), 1);
					num = ((int)num2 * -1749618760) ^ 0x51797032;
					continue;
				case 6u:
					checked
					{
						base.nextCaption.DrawRectangle(new Pen(Color.FromArgb(12, 69, 180)), 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					}
					num = ((int)num2 * -852286966) ^ 0x42507DB;
					continue;
				case 5u:
					checked
					{
						base.nextCaption.DrawRectangle(new Pen(Color.FromArgb(12, 69, 180)), 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					}
					num = (int)((num2 * 2060555519) ^ 0x4339D8D7);
					continue;
				case 3u:
					JoinBookmark((HorizontalAlignment)0, Color.FromArgb(250, 250, 250), 1);
					num = (int)(num2 * 1646395599) ^ -1945258969;
					continue;
				case 2u:
					num = ((int)num2 * -1761488848) ^ -1735074702;
					continue;
				case 1u:
					checked
					{
						base.nextCaption.DrawRectangle(new Pen(Color.FromArgb(12, 69, 180)), 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
						JoinBookmark((HorizontalAlignment)0, Color.FromArgb(232, 232, 232), 1);
					}
					num = ((int)num2 * -1588349751) ^ -1401921813;
					continue;
				case 11u:
					break;
				default:
					{
						base.nextCaption.DrawLine(new Pen(Color.FromArgb(50, 255, 255, 255)), 1, 1, checked(((Control)this).get_Width() - 3), 1);
						return;
					}
					IL_00e3:
					JoinBookmark(Color.FromArgb(19, 75, 172), Color.FromArgb(70, 110, 198), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), 270f);
					num = -1551412131;
					continue;
					IL_00a1:
					JoinBookmark(Color.FromArgb(21, 79, 177), Color.FromArgb(76, 128, 218), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), 270f);
					num = -478138462;
					continue;
					IL_0062:
					JoinBookmark(Color.FromArgb(20, 82, 179), Color.FromArgb(58, 110, 195), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), 270f);
					num = -154853075;
					continue;
				}
				break;
			}
		}
	}
}
