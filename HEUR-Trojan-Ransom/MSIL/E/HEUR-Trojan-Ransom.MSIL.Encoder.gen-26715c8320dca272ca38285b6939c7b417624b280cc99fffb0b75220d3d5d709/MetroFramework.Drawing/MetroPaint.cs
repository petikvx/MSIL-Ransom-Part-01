using System.Drawing;
using System.Windows.Forms;

namespace MetroFramework.Drawing;

public sealed class MetroPaint
{
	public sealed class BorderColor
	{
		public static class Button
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(68, 68, 68);
				}
				return Color.FromArgb(204, 204, 204);
			}

			public static Color Hover(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(170, 170, 170);
				}
				return Color.FromArgb(102, 102, 102);
			}

			public static Color Press(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(238, 238, 238);
				}
				return Color.FromArgb(51, 51, 51);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(109, 109, 109);
				}
				return Color.FromArgb(155, 155, 155);
			}
		}

		public static class CheckBox
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(153, 153, 153);
				}
				return Color.FromArgb(153, 153, 153);
			}

			public static Color Hover(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(204, 204, 204);
				}
				return Color.FromArgb(51, 51, 51);
			}

			public static Color Press(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(153, 153, 153);
				}
				return Color.FromArgb(153, 153, 153);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(85, 85, 85);
				}
				return Color.FromArgb(204, 204, 204);
			}
		}

		public static class ComboBox
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(153, 153, 153);
				}
				return Color.FromArgb(153, 153, 153);
			}

			public static Color Hover(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(204, 204, 204);
				}
				return Color.FromArgb(51, 51, 51);
			}

			public static Color Press(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(153, 153, 153);
				}
				return Color.FromArgb(153, 153, 153);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(85, 85, 85);
				}
				return Color.FromArgb(204, 204, 204);
			}
		}

		public static class ProgressBar
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(68, 68, 68);
				}
				return Color.FromArgb(204, 204, 204);
			}

			public static Color Hover(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(68, 68, 68);
				}
				return Color.FromArgb(204, 204, 204);
			}

			public static Color Press(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(68, 68, 68);
				}
				return Color.FromArgb(204, 204, 204);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(109, 109, 109);
				}
				return Color.FromArgb(155, 155, 155);
			}
		}

		public static class TabControl
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(68, 68, 68);
				}
				return Color.FromArgb(204, 204, 204);
			}

			public static Color Hover(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(68, 68, 68);
				}
				return Color.FromArgb(204, 204, 204);
			}

			public static Color Press(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(68, 68, 68);
				}
				return Color.FromArgb(204, 204, 204);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(109, 109, 109);
				}
				return Color.FromArgb(155, 155, 155);
			}
		}

		public static Color Form(MetroThemeStyle theme)
		{
			if (theme == MetroThemeStyle.Dark)
			{
				return Color.FromArgb(153, 153, 153);
			}
			return Color.FromArgb(153, 153, 153);
		}
	}

	public sealed class BackColor
	{
		public sealed class Button
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(34, 34, 34);
				}
				return Color.FromArgb(238, 238, 238);
			}

			public static Color Hover(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(170, 170, 170);
				}
				return Color.FromArgb(102, 102, 102);
			}

			public static Color Press(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(238, 238, 238);
				}
				return Color.FromArgb(51, 51, 51);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(80, 80, 80);
				}
				return Color.FromArgb(204, 204, 204);
			}
		}

		public sealed class TrackBar
		{
			public sealed class Thumb
			{
				public static Color Normal(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(153, 153, 153);
					}
					return Color.FromArgb(102, 102, 102);
				}

				public static Color Hover(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(204, 204, 204);
					}
					return Color.FromArgb(17, 17, 17);
				}

				public static Color Press(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(204, 204, 204);
					}
					return Color.FromArgb(17, 17, 17);
				}

				public static Color Disabled(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(85, 85, 85);
					}
					return Color.FromArgb(179, 179, 179);
				}
			}

			public sealed class Bar
			{
				public static Color Normal(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(51, 51, 51);
					}
					return Color.FromArgb(204, 204, 204);
				}

				public static Color Hover(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(51, 51, 51);
					}
					return Color.FromArgb(204, 204, 204);
				}

				public static Color Press(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(51, 51, 51);
					}
					return Color.FromArgb(204, 204, 204);
				}

				public static Color Disabled(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(34, 34, 34);
					}
					return Color.FromArgb(230, 230, 230);
				}
			}
		}

		public sealed class ScrollBar
		{
			public sealed class Thumb
			{
				public static Color Normal(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(51, 51, 51);
					}
					return Color.FromArgb(221, 221, 221);
				}

				public static Color Hover(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(204, 204, 204);
					}
					return Color.FromArgb(17, 17, 17);
				}

				public static Color Press(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(204, 204, 204);
					}
					return Color.FromArgb(17, 17, 17);
				}

				public static Color Disabled(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(51, 51, 51);
					}
					return Color.FromArgb(221, 221, 221);
				}
			}

			public sealed class Bar
			{
				public static Color Normal(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(38, 38, 38);
					}
					return Color.FromArgb(234, 234, 234);
				}

				public static Color Hover(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(38, 38, 38);
					}
					return Color.FromArgb(234, 234, 234);
				}

				public static Color Press(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(38, 38, 38);
					}
					return Color.FromArgb(234, 234, 234);
				}

				public static Color Disabled(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(38, 38, 38);
					}
					return Color.FromArgb(234, 234, 234);
				}
			}
		}

		public sealed class ProgressBar
		{
			public sealed class Bar
			{
				public static Color Normal(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(38, 38, 38);
					}
					return Color.FromArgb(234, 234, 234);
				}

				public static Color Hover(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(38, 38, 38);
					}
					return Color.FromArgb(234, 234, 234);
				}

				public static Color Press(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(38, 38, 38);
					}
					return Color.FromArgb(234, 234, 234);
				}

				public static Color Disabled(MetroThemeStyle theme)
				{
					if (theme == MetroThemeStyle.Dark)
					{
						return Color.FromArgb(51, 51, 51);
					}
					return Color.FromArgb(221, 221, 221);
				}
			}
		}

		public static Color Form(MetroThemeStyle theme)
		{
			if (theme == MetroThemeStyle.Dark)
			{
				return Color.FromArgb(17, 17, 17);
			}
			return Color.FromArgb(255, 255, 255);
		}
	}

	public sealed class ForeColor
	{
		public sealed class Button
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(204, 204, 204);
				}
				return Color.FromArgb(0, 0, 0);
			}

			public static Color Hover(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(17, 17, 17);
				}
				return Color.FromArgb(255, 255, 255);
			}

			public static Color Press(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(17, 17, 17);
				}
				return Color.FromArgb(255, 255, 255);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(109, 109, 109);
				}
				return Color.FromArgb(136, 136, 136);
			}
		}

		public sealed class Tile
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(255, 255, 255);
				}
				return Color.FromArgb(255, 255, 255);
			}

			public static Color Hover(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(255, 255, 255);
				}
				return Color.FromArgb(255, 255, 255);
			}

			public static Color Press(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(255, 255, 255);
				}
				return Color.FromArgb(255, 255, 255);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(209, 209, 209);
				}
				return Color.FromArgb(209, 209, 209);
			}
		}

		public sealed class Link
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(170, 170, 170);
				}
				return Color.FromArgb(0, 0, 0);
			}

			public static Color Hover(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(93, 93, 93);
				}
				return Color.FromArgb(128, 128, 128);
			}

			public static Color Press(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(93, 93, 93);
				}
				return Color.FromArgb(128, 128, 128);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(51, 51, 51);
				}
				return Color.FromArgb(209, 209, 209);
			}
		}

		public sealed class Label
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(170, 170, 170);
				}
				return Color.FromArgb(0, 0, 0);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(51, 51, 51);
				}
				return Color.FromArgb(209, 209, 209);
			}
		}

		public sealed class CheckBox
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(170, 170, 170);
				}
				return Color.FromArgb(17, 17, 17);
			}

			public static Color Hover(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(153, 153, 153);
				}
				return Color.FromArgb(153, 153, 153);
			}

			public static Color Press(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(153, 153, 153);
				}
				return Color.FromArgb(153, 153, 153);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(93, 93, 93);
				}
				return Color.FromArgb(136, 136, 136);
			}
		}

		public sealed class ComboBox
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(153, 153, 153);
				}
				return Color.FromArgb(153, 153, 153);
			}

			public static Color Hover(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(170, 170, 170);
				}
				return Color.FromArgb(17, 17, 17);
			}

			public static Color Press(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(153, 153, 153);
				}
				return Color.FromArgb(153, 153, 153);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(93, 93, 93);
				}
				return Color.FromArgb(136, 136, 136);
			}
		}

		public sealed class ProgressBar
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(170, 170, 170);
				}
				return Color.FromArgb(0, 0, 0);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(51, 51, 51);
				}
				return Color.FromArgb(209, 209, 209);
			}
		}

		public sealed class TabControl
		{
			public static Color Normal(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(170, 170, 170);
				}
				return Color.FromArgb(0, 0, 0);
			}

			public static Color Disabled(MetroThemeStyle theme)
			{
				if (theme == MetroThemeStyle.Dark)
				{
					return Color.FromArgb(51, 51, 51);
				}
				return Color.FromArgb(209, 209, 209);
			}
		}

		public static Color Form(MetroThemeStyle theme)
		{
			if (theme == MetroThemeStyle.Dark)
			{
				return Color.FromArgb(255, 255, 255);
			}
			return Color.FromArgb(0, 0, 0);
		}
	}

	public static Color GetStyleColor(MetroColorStyle style)
	{
		return style switch
		{
			MetroColorStyle.Black => MetroColors.Black, 
			MetroColorStyle.White => MetroColors.White, 
			MetroColorStyle.Silver => MetroColors.Silver, 
			MetroColorStyle.Blue => MetroColors.Blue, 
			MetroColorStyle.Green => MetroColors.Green, 
			MetroColorStyle.Lime => MetroColors.Lime, 
			MetroColorStyle.Teal => MetroColors.Teal, 
			MetroColorStyle.Orange => MetroColors.Orange, 
			MetroColorStyle.Brown => MetroColors.Brown, 
			MetroColorStyle.Pink => MetroColors.Pink, 
			MetroColorStyle.Magenta => MetroColors.Magenta, 
			MetroColorStyle.Purple => MetroColors.Purple, 
			MetroColorStyle.Red => MetroColors.Red, 
			MetroColorStyle.Yellow => MetroColors.Yellow, 
			_ => MetroColors.Blue, 
		};
	}

	public static SolidBrush GetStyleBrush(MetroColorStyle style)
	{
		return (SolidBrush)(style switch
		{
			MetroColorStyle.Black => MetroBrushes.Black, 
			MetroColorStyle.White => MetroBrushes.White, 
			MetroColorStyle.Silver => MetroBrushes.Silver, 
			MetroColorStyle.Blue => MetroBrushes.Blue, 
			MetroColorStyle.Green => MetroBrushes.Green, 
			MetroColorStyle.Lime => MetroBrushes.Lime, 
			MetroColorStyle.Teal => MetroBrushes.Teal, 
			MetroColorStyle.Orange => MetroBrushes.Orange, 
			MetroColorStyle.Brown => MetroBrushes.Brown, 
			MetroColorStyle.Pink => MetroBrushes.Pink, 
			MetroColorStyle.Magenta => MetroBrushes.Magenta, 
			MetroColorStyle.Purple => MetroBrushes.Purple, 
			MetroColorStyle.Red => MetroBrushes.Red, 
			MetroColorStyle.Yellow => MetroBrushes.Yellow, 
			_ => MetroBrushes.Blue, 
		});
	}

	public static Pen GetStylePen(MetroColorStyle style)
	{
		return (Pen)(style switch
		{
			MetroColorStyle.Black => MetroPens.Black, 
			MetroColorStyle.White => MetroPens.White, 
			MetroColorStyle.Silver => MetroPens.Silver, 
			MetroColorStyle.Blue => MetroPens.Blue, 
			MetroColorStyle.Green => MetroPens.Green, 
			MetroColorStyle.Lime => MetroPens.Lime, 
			MetroColorStyle.Teal => MetroPens.Teal, 
			MetroColorStyle.Orange => MetroPens.Orange, 
			MetroColorStyle.Brown => MetroPens.Brown, 
			MetroColorStyle.Pink => MetroPens.Pink, 
			MetroColorStyle.Magenta => MetroPens.Magenta, 
			MetroColorStyle.Purple => MetroPens.Purple, 
			MetroColorStyle.Red => MetroPens.Red, 
			MetroColorStyle.Yellow => MetroPens.Yellow, 
			_ => MetroPens.Blue, 
		});
	}

	public static TextFormatFlags GetTextFormatFlags(ContentAlignment textAlign)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected I4, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		TextFormatFlags val = (TextFormatFlags)32768;
		if ((int)textAlign <= 32)
		{
			switch (textAlign - 1)
			{
			default:
				if ((int)textAlign != 16)
				{
					if ((int)textAlign == 32)
					{
						val = (TextFormatFlags)(val | 5);
					}
				}
				else
				{
					val = (TextFormatFlags)(val | 4);
				}
				break;
			case 0:
				val = val;
				break;
			case 1:
				val = (TextFormatFlags)(val | 1);
				break;
			case 3:
				val = (TextFormatFlags)(val | 2);
				break;
			case 2:
				break;
			}
		}
		else if ((int)textAlign <= 256)
		{
			if ((int)textAlign != 64)
			{
				if ((int)textAlign == 256)
				{
					val = (TextFormatFlags)(val | 8);
				}
			}
			else
			{
				val = (TextFormatFlags)(val | 6);
			}
		}
		else if ((int)textAlign != 512)
		{
			if ((int)textAlign == 1024)
			{
				val = (TextFormatFlags)(val | 0xA);
			}
		}
		else
		{
			val = (TextFormatFlags)(val | 9);
		}
		return val;
	}
}
