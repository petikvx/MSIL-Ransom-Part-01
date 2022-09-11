using System;
using System.Drawing;
using System.Drawing.Printing;

namespace Complex;

public static class Printing
{
	public static void PrintNote(string message)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		PrintDocument p = new PrintDocument();
		p.add_PrintPage((PrintPageEventHandler)delegate(object sender, PrintPageEventArgs e)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0069: Expected O, but got Unknown
			e.get_Graphics().DrawString(message, new Font("Times New Roman", 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, p.get_DefaultPageSettings().get_PrintableArea().Width, p.get_DefaultPageSettings().get_PrintableArea().Height));
		});
		try
		{
			p.Print();
		}
		catch (Exception)
		{
		}
	}
}
