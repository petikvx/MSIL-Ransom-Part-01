using System.Drawing;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.CompilerServices;

namespace fbab6880a695;

[StandardModule]
internal sealed class ProjectContext
{
	public static GraphicsPath ToggleDatabase(Rectangle nextCaption, int parentLog)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		int num;
		checked
		{
			num = parentLog * 2;
			Rectangle rectangle = new Rectangle(nextCaption.X, nextCaption.Y, num, num);
			val.AddArc(rectangle, -180f, 90f);
			rectangle = new Rectangle(nextCaption.Width - num + nextCaption.X, nextCaption.Y, num, num);
			val.AddArc(rectangle, -90f, 90f);
		}
		GraphicsPath result = default(GraphicsPath);
		while (true)
		{
			int num2 = 581523993;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x3BE558B0u) % 6u)
				{
				case 5u:
				{
					Rectangle rectangle = checked(new Rectangle(nextCaption.Width - num + nextCaption.X, nextCaption.Height - num + nextCaption.Y, num, num));
					val.AddArc(rectangle, 0f, 90f);
					num2 = ((int)num3 * -1682386566) ^ 0x7A52C695;
					continue;
				}
				case 4u:
					num2 = (int)(num3 * 1017616795) ^ -1032397388;
					continue;
				case 3u:
					result = val;
					num2 = (int)((num3 * 1222183644) ^ 0x253C8C56);
					continue;
				case 1u:
					checked
					{
						Rectangle rectangle = new Rectangle(nextCaption.X, nextCaption.Height - num + nextCaption.Y, num, num);
						val.AddArc(rectangle, 90f, 90f);
						Point point = new Point(nextCaption.X, nextCaption.Height - num + nextCaption.Y);
						Point point2 = new Point(nextCaption.X, parentLog + nextCaption.Y);
						val.AddLine(point, point2);
					}
					num2 = ((int)num3 * -10202140) ^ 0x2E4D8E65;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}
}
