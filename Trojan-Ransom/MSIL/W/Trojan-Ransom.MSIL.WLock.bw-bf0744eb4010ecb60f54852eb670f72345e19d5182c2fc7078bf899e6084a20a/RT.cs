using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class RT : RichTextBox
{
	private struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	private struct CHARRANGE
	{
		public int cpMin;

		public int cpMax;
	}

	private struct FORMATRANGE
	{
		public IntPtr hdc;

		public IntPtr hdcTarget;

		public RECT rc;

		public RECT rcPage;

		public CHARRANGE chrg;
	}

	public string TypeObj;

	public string defaultName;

	public Propertys Props;

	public string LastProp;

	public string LastSobyt;

	public object MyObj;

	private const double AnInch = 14.4;

	private const int WM_USER = 1024;

	private const int EM_FORMATRANGE = 1081;

	public RT()
	{
		TypeObj = "Obi4niy";
		defaultName = peremens.trans("Текстовый документ");
		Props = new Propertys(this);
		LastProp = peremens.trans("Текст");
		LastSobyt = peremens.trans("Изменение текста");
		bool[] array3;
		if (peremens2.proj == null)
		{
			Props.Name = defaultName + "1";
		}
		else
		{
			Propertys props = Props;
			object proj = peremens2.proj;
			object[] array = new object[1] { defaultName };
			object[] array2 = array;
			array3 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(proj, (Type)null, "GiveName", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			props.Name = Conversions.ToString(obj);
		}
		Propertys props2 = Props;
		object proj2 = peremens2.proj;
		object[] array4 = new object[1] { defaultName };
		object[] array5 = array4;
		array3 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet(proj2, (Type)null, "GiveName", array5, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
		}
		props2.Name = Conversions.ToString(obj2);
		Props.Text = Props.Name;
		Props.Width = 100;
		Props.Height = 100;
		Props.BackColor = peremens.ToMyColor(Color.White);
		Props.BorderStyle = Strings.LCase(peremens.trans("объем"));
		Props.EnableAutoDragDrop = peremens.trans("Да");
		Props.HideSelection = peremens.trans("Нет");
		Props.MultiLine = peremens.trans("Да");
		Props.ScrollBars = peremens.trans("Вертикальная");
	}

	[DllImport("USER32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr SendMessageA(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

	public int Print(int charFrom, int charTo, PrintPageEventArgs e, float yPos = 0f)
	{
		CHARRANGE chrg = default(CHARRANGE);
		chrg.cpMin = charFrom;
		chrg.cpMax = charTo;
		if (yPos == 0f)
		{
			yPos = e.get_MarginBounds().Top;
		}
		checked
		{
			RECT rc = default(RECT);
			rc.Top = (int)Math.Round((double)yPos * 14.4);
			rc.Bottom = (int)Math.Round((double)e.get_MarginBounds().Bottom * 14.4);
			rc.Left = (int)Math.Round((double)e.get_MarginBounds().Left * 14.4);
			rc.Right = (int)Math.Round((double)e.get_MarginBounds().Right * 14.4);
			RECT rcPage = default(RECT);
			rcPage.Top = (int)Math.Round((double)e.get_PageBounds().Top * 14.4);
			rcPage.Bottom = (int)Math.Round((double)e.get_PageBounds().Bottom * 14.4);
			rcPage.Left = (int)Math.Round((double)e.get_PageBounds().Left * 14.4);
			rcPage.Right = (int)Math.Round((double)e.get_PageBounds().Right * 14.4);
			IntPtr hdc = e.get_Graphics().GetHdc();
			FORMATRANGE fORMATRANGE = default(FORMATRANGE);
			fORMATRANGE.chrg = chrg;
			fORMATRANGE.hdc = hdc;
			fORMATRANGE.hdcTarget = hdc;
			fORMATRANGE.rc = rc;
			fORMATRANGE.rcPage = rcPage;
			IntPtr zero = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			zero2 = new IntPtr(1);
			IntPtr zero3 = IntPtr.Zero;
			zero3 = Marshal.AllocCoTaskMem(Marshal.SizeOf((object)fORMATRANGE));
			Marshal.StructureToPtr((object)fORMATRANGE, zero3, fDeleteOld: false);
			zero = SendMessageA(((Control)this).get_Handle(), 1081, zero2, zero3);
			Marshal.FreeCoTaskMem(zero3);
			e.get_Graphics().ReleaseHdc(hdc);
			return zero.ToInt32();
		}
	}
}
