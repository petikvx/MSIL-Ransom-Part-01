using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace P5EWkEJj;

internal class ITnaJzyl
{
	internal static void wHNKO26G(Control control_0, Cursor cursor_0, int int_0)
	{
		switch (int_0 ^ 0xDEA4)
		{
		}
		control_0.set_Cursor(cursor_0);
	}

	internal static Cursor kNtN6PXE(int int_0)
	{
		return (Cursor)((int_0 ^ 0xDC47) switch
		{
			1 => Cursors.get_WaitCursor(), 
			_ => Cursors.get_Default(), 
		});
	}

	internal static void G9w2Qdin(object object_0, Type type_0, string string_0, object[] object_1, string[] string_1, Type[] type_1, int int_0)
	{
		switch (int_0 ^ 0x1097)
		{
		}
		NewLateBinding.LateSet(object_0, type_0, string_0, object_1, string_1, type_1);
	}

	internal static object b26YxPWq(object object_0, Type type_0, string string_0, object[] object_1, string[] string_1, Type[] type_1, bool[] bool_0, bool bool_1, int int_0)
	{
		return (int_0 ^ 0x9F6E) switch
		{
			_ => NewLateBinding.LateCall(object_0, type_0, string_0, object_1, string_1, type_1, bool_0, bool_1), 
		};
	}

	internal static object YxYsb6cN(object object_0, Type type_0, int int_0)
	{
		return (int_0 ^ 0x1088) switch
		{
			_ => Conversions.ChangeType(object_0, type_0), 
		};
	}

	internal static void smethod_0(Form form_0, int int_0)
	{
		switch (int_0 ^ 0x8F35)
		{
		}
		form_0.Activate();
	}

	internal static Keys IUSA1vvj(KeyEventArgs keyEventArgs_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return (Keys)((int_0 ^ 0x7780) switch
		{
			_ => keyEventArgs_0.get_KeyCode(), 
		});
	}

	internal static Graphics pqzMW89v(Image image_0, int int_0)
	{
		return (Graphics)((int_0 ^ 0x11FC) switch
		{
			_ => Graphics.FromImage(image_0), 
		});
	}

	internal static Brush Q3OyQusA(int int_0)
	{
		return (Brush)((int_0 ^ 0x1427) switch
		{
			_ => Brushes.get_White(), 
		});
	}

	internal static void XIYIXNp7(Graphics graphics_0, Brush brush_0, Rectangle rectangle_0, int int_0)
	{
		switch (int_0 ^ 0xDAB4)
		{
		}
		graphics_0.FillRectangle(brush_0, rectangle_0);
	}

	internal static ImageFormat FTgDWlpt(int int_0)
	{
		return (ImageFormat)((int_0 ^ 0xF6DD) switch
		{
			_ => ImageFormat.get_Jpeg(), 
		});
	}

	internal static void smethod_1(Image image_0, string string_0, ImageFormat imageFormat_0, int int_0)
	{
		switch (int_0 ^ 0x6954)
		{
		}
		image_0.Save(string_0, imageFormat_0);
	}

	internal static Size ZJEUfOmd(Control control_0, int int_0)
	{
		return (int_0 ^ 0xE909) switch
		{
			_ => control_0.get_Size(), 
		};
	}

	internal static string riDiwNlC(FileDialog fileDialog_0, int int_0)
	{
		return (int_0 ^ 0xDF73) switch
		{
			_ => fileDialog_0.get_FileName(), 
		};
	}

	internal static DialogResult smethod_2(CommonDialog commonDialog_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)((int_0 ^ 0xF633) switch
		{
			_ => commonDialog_0.ShowDialog(), 
		});
	}

	internal static DataGridViewCell DlwarI3x(DataGridView dataGridView_0, int int_0)
	{
		return (DataGridViewCell)((int_0 ^ 0x759C) switch
		{
			_ => dataGridView_0.get_CurrentCell(), 
		});
	}

	internal static string R2Jd8uRQ(FolderBrowserDialog folderBrowserDialog_0, int int_0)
	{
		return (int_0 ^ 0xA6A5) switch
		{
			_ => folderBrowserDialog_0.get_SelectedPath(), 
		};
	}

	internal static void w2bEH6We(FolderBrowserDialog folderBrowserDialog_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0xA088)
		{
		}
		folderBrowserDialog_0.set_ShowNewFolderButton(bool_0);
	}

	internal static Environment.SpecialFolder kqJ4jO3t(FolderBrowserDialog folderBrowserDialog_0, int int_0)
	{
		return (int_0 ^ 0xB57A) switch
		{
			_ => folderBrowserDialog_0.get_RootFolder(), 
		};
	}

	internal static bool a8hTibMI(char char_0, int int_0)
	{
		return (int_0 ^ 0xD470) switch
		{
			_ => char.IsDigit(char_0), 
		};
	}
}
