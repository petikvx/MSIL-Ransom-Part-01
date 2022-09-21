using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;

namespace vQzMGKHeycFziMq;

public static class jjkdSsQnHftqKN
{
	[CompilerGenerated]
	private sealed class eMvbBmhwhJoTAxBE
	{
		public PrintDocument fccmVqDzrLQAXRdD;

		public string bDRGhUnUwjaBA;

		public void _003CPrintNote_003Eb__0(object sender, PrintPageEventArgs e)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0069: Expected O, but got Unknown
			e.get_Graphics().DrawString(bDRGhUnUwjaBA, new Font("Times New Roman", 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, fccmVqDzrLQAXRdD.get_DefaultPageSettings().get_PrintableArea().Width, fccmVqDzrLQAXRdD.get_DefaultPageSettings().get_PrintableArea().Height));
		}
	}

	public static void kWDVksNVtomw(string xisCugdSyu)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		PrintDocument fccmVqDzrLQAXRdD = new PrintDocument();
		fccmVqDzrLQAXRdD.add_PrintPage((PrintPageEventHandler)delegate(object sender, PrintPageEventArgs e)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0069: Expected O, but got Unknown
			e.get_Graphics().DrawString(xisCugdSyu, new Font("Times New Roman", 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, fccmVqDzrLQAXRdD.get_DefaultPageSettings().get_PrintableArea().Width, fccmVqDzrLQAXRdD.get_DefaultPageSettings().get_PrintableArea().Height));
		});
		try
		{
			fccmVqDzrLQAXRdD.Print();
		}
		catch (Exception)
		{
		}
	}
}
