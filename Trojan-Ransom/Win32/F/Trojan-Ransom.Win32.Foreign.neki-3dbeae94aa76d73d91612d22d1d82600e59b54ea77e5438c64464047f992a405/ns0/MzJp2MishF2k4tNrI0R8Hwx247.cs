using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace ns0;

public class MzJp2MishF2k4tNrI0R8Hwx247 : PrintDocument
{
	private Font TU5as2tg2GBAAgUGpIMBC7kn179;

	private string ggc9UPt9Ra7Cv5SvZADqK90F180;

	[SpecialName]
	private int _0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar;

	public string Text
	{
		get
		{
			return ggc9UPt9Ra7Cv5SvZADqK90F180;
		}
		set
		{
			ggc9UPt9Ra7Cv5SvZADqK90F180 = value;
		}
	}

	public Font Font
	{
		get
		{
			return TU5as2tg2GBAAgUGpIMBC7kn179;
		}
		set
		{
			TU5as2tg2GBAAgUGpIMBC7kn179 = value;
		}
	}

	public MzJp2MishF2k4tNrI0R8Hwx247(string Text)
	{
		ggc9UPt9Ra7Cv5SvZADqK90F180 = Text;
	}

	protected override void OnBeginPrint(PrintEventArgs ev)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		((PrintDocument)this).OnBeginPrint(ev);
		if (TU5as2tg2GBAAgUGpIMBC7kn179 == null)
		{
			TU5as2tg2GBAAgUGpIMBC7kn179 = new Font("Times New Roman", 12f);
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
			string text = Strings.Mid(ggc9UPt9Ra7Cv5SvZADqK90F180, Nsb1xBgkysQF7lJBWxBIzEB1216(_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar));
			Font font = Font;
			SizeF sizeF = new SizeF(num2, num);
			int num4 = default(int);
			int num5 = default(int);
			graphics.MeasureString(text, font, sizeF, val, ref num4, ref num5);
			e.get_Graphics().DrawString(Strings.Mid(ggc9UPt9Ra7Cv5SvZADqK90F180, Nsb1xBgkysQF7lJBWxBIzEB1216(_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar)), Font, Brushes.get_Black(), rectangleF, val);
			_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar += num4;
			if (_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar < ggc9UPt9Ra7Cv5SvZADqK90F180.Length)
			{
				e.set_HasMorePages(true);
				return;
			}
			e.set_HasMorePages(false);
			_0024STATIC_0024OnPrintPage_0024201112809D_0024intCurrentChar = 0;
		}
	}

	public int Nsb1xBgkysQF7lJBWxBIzEB1216(int Input)
	{
		if (Input == 0)
		{
			return 1;
		}
		return Input;
	}
}
