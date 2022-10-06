using System;
using System.Drawing;
using System.Drawing.Printing;

namespace OeQGwjtftIBDg;

public static class TgCsKvBJUFtXrjRf
{
	private sealed class MumaprHitENf
	{
		public PrintDocument cVZdFrAjqyOi;

		public string ajLSqQApRhDa;

		public void _003CPrintNote_003Eb__0(object sender, PrintPageEventArgs e)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0069: Expected O, but got Unknown
			e.get_Graphics().DrawString(ajLSqQApRhDa, new Font("Times New Roman", 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, cVZdFrAjqyOi.get_DefaultPageSettings().get_PrintableArea().Width, cVZdFrAjqyOi.get_DefaultPageSettings().get_PrintableArea().Height));
		}
	}

	public static void qONalJPEgIK(string string_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		MumaprHitENf CS_0024_003C_003E8__locals0 = new MumaprHitENf();
		CS_0024_003C_003E8__locals0.ajLSqQApRhDa = string_0;
		CS_0024_003C_003E8__locals0.cVZdFrAjqyOi = new PrintDocument();
		CS_0024_003C_003E8__locals0.cVZdFrAjqyOi.add_PrintPage((PrintPageEventHandler)delegate(object sender, PrintPageEventArgs e)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0069: Expected O, but got Unknown
			e.get_Graphics().DrawString(CS_0024_003C_003E8__locals0.ajLSqQApRhDa, new Font("Times New Roman", 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, CS_0024_003C_003E8__locals0.cVZdFrAjqyOi.get_DefaultPageSettings().get_PrintableArea().Width, CS_0024_003C_003E8__locals0.cVZdFrAjqyOi.get_DefaultPageSettings().get_PrintableArea().Height));
		});
		try
		{
			CS_0024_003C_003E8__locals0.cVZdFrAjqyOi.Print();
		}
		catch (Exception)
		{
		}
	}
}
