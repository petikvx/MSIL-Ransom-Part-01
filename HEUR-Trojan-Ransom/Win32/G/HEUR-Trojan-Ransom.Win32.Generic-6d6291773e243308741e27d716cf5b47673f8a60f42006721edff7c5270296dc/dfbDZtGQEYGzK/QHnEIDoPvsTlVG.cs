using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;

namespace dfbDZtGQEYGzK;

public static class QHnEIDoPvsTlVG
{
	[CompilerGenerated]
	private sealed class tuJdOiUbDQ
	{
		public PrintDocument nfQtlDtiHTx;

		public string zkxcvCKXxc;

		public void _003CPrintNote_003Eb__0(object sender, PrintPageEventArgs e)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0069: Expected O, but got Unknown
			e.get_Graphics().DrawString(zkxcvCKXxc, new Font("Times New Roman", 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, nfQtlDtiHTx.get_DefaultPageSettings().get_PrintableArea().Width, nfQtlDtiHTx.get_DefaultPageSettings().get_PrintableArea().Height));
		}
	}

	public static void PKAhnGOGYsYmZ(string kuNeoUyXGqcHcjey)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		PrintDocument nfQtlDtiHTx = new PrintDocument();
		nfQtlDtiHTx.add_PrintPage((PrintPageEventHandler)delegate(object sender, PrintPageEventArgs e)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0069: Expected O, but got Unknown
			e.get_Graphics().DrawString(kuNeoUyXGqcHcjey, new Font("Times New Roman", 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, nfQtlDtiHTx.get_DefaultPageSettings().get_PrintableArea().Width, nfQtlDtiHTx.get_DefaultPageSettings().get_PrintableArea().Height));
		});
		try
		{
			nfQtlDtiHTx.Print();
		}
		catch (Exception)
		{
		}
	}
}
