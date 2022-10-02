using System;
using System.Drawing;
using System.Drawing.Printing;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nZBhTHSmQawuU;

public static class BnmUcXyBxyt
{
	private sealed class nLaQRvHgmtRCJELs
	{
		public PrintDocument cccIvlsmtqX;

		public string BhLRqmSjSDjDSEk;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CPrintNote_003Eb__0(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(BhLRqmSjSDjDSEk, new Font(getString_0(107461649), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, cccIvlsmtqX.get_DefaultPageSettings().get_PrintableArea().Width, cccIvlsmtqX.get_DefaultPageSettings().get_PrintableArea().Height));
		}

		static nLaQRvHgmtRCJELs()
		{
			Strings.CreateGetStringDelegate(typeof(nLaQRvHgmtRCJELs));
		}
	}

	public static void QIJehjhxptQDZ(string string_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		nLaQRvHgmtRCJELs CS_0024_003C_003E8__locals0 = new nLaQRvHgmtRCJELs();
		CS_0024_003C_003E8__locals0.BhLRqmSjSDjDSEk = string_0;
		CS_0024_003C_003E8__locals0.cccIvlsmtqX = new PrintDocument();
		CS_0024_003C_003E8__locals0.cccIvlsmtqX.add_PrintPage((PrintPageEventHandler)delegate(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(CS_0024_003C_003E8__locals0.BhLRqmSjSDjDSEk, new Font(nLaQRvHgmtRCJELs.getString_0(107461649), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, CS_0024_003C_003E8__locals0.cccIvlsmtqX.get_DefaultPageSettings().get_PrintableArea().Width, CS_0024_003C_003E8__locals0.cccIvlsmtqX.get_DefaultPageSettings().get_PrintableArea().Height));
		});
		try
		{
			CS_0024_003C_003E8__locals0.cccIvlsmtqX.Print();
		}
		catch (Exception)
		{
		}
	}
}
