using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace RuJ22SnU;

internal class Nr2sp4aM
{
	internal static void J7K17xN9(DataGridView dataGridView_0, DataGridViewCellEventHandler dataGridViewCellEventHandler_0, int int_0)
	{
		switch (int_0 ^ 0xEEDA)
		{
		default:
			dataGridView_0.remove_CellDoubleClick(dataGridViewCellEventHandler_0);
			break;
		case 1:
			dataGridView_0.add_CellDoubleClick(dataGridViewCellEventHandler_0);
			break;
		case 2:
			dataGridView_0.remove_CellContentClick(dataGridViewCellEventHandler_0);
			break;
		case 3:
			dataGridView_0.add_CellContentClick(dataGridViewCellEventHandler_0);
			break;
		}
	}

	internal static void lJeSf5kR(Control control_0, PaintEventHandler paintEventHandler_0, int int_0)
	{
		switch (int_0 ^ 0x8D07)
		{
		default:
			control_0.add_Paint(paintEventHandler_0);
			break;
		case 1:
			control_0.remove_Paint(paintEventHandler_0);
			break;
		}
	}

	internal static string Be12s2SH(string string_0, string string_1, int int_0)
	{
		return (int_0 ^ 0x3F1) switch
		{
			_ => Path.Combine(string_0, string_1), 
		};
	}

	internal static Graphics N2abcc8Z(Control control_0, int int_0)
	{
		return (Graphics)((int_0 ^ 0x59F6) switch
		{
			_ => control_0.CreateGraphics(), 
		});
	}

	internal static void GIIbCwRh(Component component_0, int int_0)
	{
		switch (int_0 ^ 0x84E9)
		{
		}
		component_0.Dispose();
	}

	internal static int Nrwpqirh(ArrayList arrayList_0, int int_0)
	{
		return (int_0 ^ 0xC9B4) switch
		{
			_ => arrayList_0.Count, 
		};
	}

	internal static Keyboard UgoFn2mH(Computer computer_0, int int_0)
	{
		return (Keyboard)((int_0 ^ 0x4D4) switch
		{
			_ => computer_0.get_Keyboard(), 
		});
	}

	internal static bool e2d5mBW9(Keyboard keyboard_0, int int_0)
	{
		return (int_0 ^ 0x52BA) switch
		{
			_ => keyboard_0.get_ShiftKeyDown(), 
		};
	}

	internal static void Bfbwn9e5(Pen pen_0, DashStyle dashStyle_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0x55AB)
		{
		}
		pen_0.set_DashStyle(dashStyle_0);
	}

	internal static void mKe1vtgu(Graphics graphics_0, Pen pen_0, Rectangle rectangle_0, int int_0)
	{
		switch (int_0 ^ 0xD7D6)
		{
		}
		graphics_0.DrawRectangle(pen_0, rectangle_0);
	}

	internal static bool BThVOtCE(object object_0, int int_0, int int_1)
	{
		return (int_1 ^ 0x9D0B) switch
		{
			_ => Monitor.TryEnter(object_0, int_0), 
		};
	}

	internal static void m1WAiMUb(Graphics graphics_0, Color color_0, int int_0)
	{
		switch (int_0 ^ 0xC4FB)
		{
		}
		graphics_0.Clear(color_0);
	}

	internal static int unOb6UUK(int int_0, int int_1, int int_2)
	{
		return (int_2 ^ 0x4E7C) switch
		{
			1 => Math.Min(int_0, int_1), 
			_ => Math.Max(int_0, int_1), 
		};
	}

	internal static ToolStripItem smethod_0(ToolStripItemCollection toolStripItemCollection_0, int int_0, int int_1)
	{
		return (ToolStripItem)((int_1 ^ 0x6C46) switch
		{
			_ => toolStripItemCollection_0.get_Item(int_0), 
		});
	}

	internal static ImageList LItsk1k8(ToolStrip toolStrip_0, int int_0)
	{
		return (ImageList)((int_0 ^ 0xA8B6) switch
		{
			_ => toolStrip_0.get_ImageList(), 
		});
	}

	internal static Image DxamdEMA(ImageCollection imageCollection_0, int int_0, int int_1)
	{
		return (Image)((int_1 ^ 0x1F3) switch
		{
			_ => imageCollection_0.get_Item(int_0), 
		});
	}

	internal static void P3w8E5oG(ToolStrip toolStrip_0, ImageList imageList_0, int int_0)
	{
		switch (int_0 ^ 0x2979)
		{
		}
		toolStrip_0.set_ImageList(imageList_0);
	}

	internal static Rectangle ZwUvaZQ1(PaintEventArgs paintEventArgs_0, int int_0)
	{
		return (int_0 ^ 0x1B61) switch
		{
			_ => paintEventArgs_0.get_ClipRectangle(), 
		};
	}

	internal static MouseButtons PaOzirRt(MouseEventArgs mouseEventArgs_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return (MouseButtons)((int_0 ^ 0xFA05) switch
		{
			_ => mouseEventArgs_0.get_Button(), 
		});
	}

	internal static int smethod_1(MouseEventArgs mouseEventArgs_0, int int_0)
	{
		return (int_0 ^ 0x59DF) switch
		{
			1 => mouseEventArgs_0.get_Y(), 
			_ => mouseEventArgs_0.get_X(), 
		};
	}
}
