using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;

namespace YzTymtbtgFABHvJvj;

public static class FGfsSEOTSS
{
	[CompilerGenerated]
	private sealed class WQGgpyYYYriuvcWH
	{
		public PrintDocument alpjrkorZD;

		public string MTJiTTJWNAOfUe;

		public void _003CPrintNote_003Eb__0(object sender, PrintPageEventArgs e)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0069: Expected O, but got Unknown
			e.get_Graphics().DrawString(MTJiTTJWNAOfUe, new Font("Times New Roman", 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, alpjrkorZD.get_DefaultPageSettings().get_PrintableArea().Width, alpjrkorZD.get_DefaultPageSettings().get_PrintableArea().Height));
		}
	}

	public static void xAbaBNJZskQr(string XbZcJccvfzVGAf)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		PrintDocument alpjrkorZD = new PrintDocument();
		alpjrkorZD.add_PrintPage((PrintPageEventHandler)delegate(object sender, PrintPageEventArgs e)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0069: Expected O, but got Unknown
			e.get_Graphics().DrawString(XbZcJccvfzVGAf, new Font("Times New Roman", 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, alpjrkorZD.get_DefaultPageSettings().get_PrintableArea().Width, alpjrkorZD.get_DefaultPageSettings().get_PrintableArea().Height));
		});
		try
		{
			alpjrkorZD.Print();
		}
		catch (Exception)
		{
		}
	}
}
