using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace ECbh4LRo71e4DDkBlyBhe3;

public class ribM9yQJNOc4Vj47 : PrintDocument
{
	private Font ocb7EjJFU1HRh9179;

	private string babv4dS6FnqSnh180;

	[SpecialName]
	private int _0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar;

	public string Text
	{
		get
		{
			return babv4dS6FnqSnh180;
		}
		set
		{
			babv4dS6FnqSnh180 = value;
		}
	}

	public Font Font
	{
		get
		{
			return ocb7EjJFU1HRh9179;
		}
		set
		{
			ocb7EjJFU1HRh9179 = value;
		}
	}

	public ribM9yQJNOc4Vj47(string Text)
	{
		babv4dS6FnqSnh180 = Text;
	}

	protected override void OnBeginPrint(PrintEventArgs ev)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		((PrintDocument)this).OnBeginPrint(ev);
		if (ocb7EjJFU1HRh9179 == null)
		{
			ocb7EjJFU1HRh9179 = new Font("Times New Roman", 12f);
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
			string text = Strings.Mid(babv4dS6FnqSnh180, SLSJecV9f7y1I6216(_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar));
			Font font = Font;
			SizeF sizeF = new SizeF(num2, num);
			int num4 = default(int);
			int num5 = default(int);
			graphics.MeasureString(text, font, sizeF, val, ref num4, ref num5);
			e.get_Graphics().DrawString(Strings.Mid(babv4dS6FnqSnh180, SLSJecV9f7y1I6216(_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar)), Font, Brushes.get_Black(), rectangleF, val);
			_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar += num4;
			if (_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar < babv4dS6FnqSnh180.Length)
			{
				e.set_HasMorePages(true);
				return;
			}
			e.set_HasMorePages(false);
			_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar = 0;
		}
	}

	public int SLSJecV9f7y1I6216(int Input)
	{
		if (Input == 0)
		{
			return 1;
		}
		return Input;
	}
}
