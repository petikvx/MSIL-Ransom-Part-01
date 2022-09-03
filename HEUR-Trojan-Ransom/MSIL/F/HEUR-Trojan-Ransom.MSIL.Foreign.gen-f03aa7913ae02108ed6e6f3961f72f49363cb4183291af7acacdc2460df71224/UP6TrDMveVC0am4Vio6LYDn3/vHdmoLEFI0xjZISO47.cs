using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace UP6TrDMveVC0am4Vio6LYDn3;

public class vHdmoLEFI0xjZISO47 : PrintDocument
{
	private Font font_0;

	private string dT00F9qqLWoaVukT180;

	[SpecialName]
	private int _0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar;

	public string Text
	{
		get
		{
			return dT00F9qqLWoaVukT180;
		}
		set
		{
			dT00F9qqLWoaVukT180 = value;
		}
	}

	public Font Font
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
		}
	}

	public vHdmoLEFI0xjZISO47(string Text)
	{
		dT00F9qqLWoaVukT180 = Text;
	}

	protected override void OnBeginPrint(PrintEventArgs ev)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		((PrintDocument)this).OnBeginPrint(ev);
		if (font_0 == null)
		{
			font_0 = new Font("Times New Roman", 12f);
		}
	}

	protected override void OnPrintPage(PrintPageEventArgs e)
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		((PrintDocument)this).OnPrintPage(e);
		PageSettings defaultPageSettings = ((PrintDocument)this).get_DefaultPageSettings();
		checked
		{
			int num = defaultPageSettings.get_PaperSize().get_Height() - defaultPageSettings.get_Margins().get_Top() - defaultPageSettings.get_Margins().get_Bottom();
			int num2 = defaultPageSettings.get_PaperSize().get_Width() - defaultPageSettings.get_Margins().get_Left() - defaultPageSettings.get_Margins().get_Right();
			int left = defaultPageSettings.get_Margins().get_Left();
			int top = defaultPageSettings.get_Margins().get_Top();
			defaultPageSettings = null;
			if (((PrintDocument)this).get_DefaultPageSettings().get_Landscape())
			{
				int num3 = num;
				num = num2;
				num2 = num3;
			}
			RectangleF rectangleF = new RectangleF(left, top, num2, num);
			StringFormat val = new StringFormat((StringFormatFlags)8192);
			Graphics graphics = e.get_Graphics();
			string text = Strings.Mid(dT00F9qqLWoaVukT180, Jny1d4VgXdQalOch216(_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar));
			Font font = Font;
			SizeF sizeF = new SizeF(num2, num);
			int num4 = default(int);
			int num5 = default(int);
			graphics.MeasureString(text, font, sizeF, val, ref num4, ref num5);
			e.get_Graphics().DrawString(Strings.Mid(dT00F9qqLWoaVukT180, Jny1d4VgXdQalOch216(_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar)), Font, Brushes.get_Black(), rectangleF, val);
			_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar += num4;
			if (_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar < dT00F9qqLWoaVukT180.Length)
			{
				e.set_HasMorePages(true);
				return;
			}
			e.set_HasMorePages(false);
			_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar = 0;
		}
	}

	public int Jny1d4VgXdQalOch216(int Input)
	{
		if (Input == 0)
		{
			return 1;
		}
		return Input;
	}
}
