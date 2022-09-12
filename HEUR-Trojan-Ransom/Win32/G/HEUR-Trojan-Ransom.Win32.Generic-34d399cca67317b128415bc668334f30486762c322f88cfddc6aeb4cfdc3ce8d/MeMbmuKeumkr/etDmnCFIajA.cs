using System;
using System.Drawing;
using System.Drawing.Printing;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MeMbmuKeumkr;

public static class etDmnCFIajA
{
	private sealed class GsxkfGjvQpvVn
	{
		public PrintDocument oaFhnGEgFINbQi;

		public string NzelVmorQHXe;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CPrintNote_003Eb__0(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(NzelVmorQHXe, new Font(getString_0(107365125), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, oaFhnGEgFINbQi.get_DefaultPageSettings().get_PrintableArea().Width, oaFhnGEgFINbQi.get_DefaultPageSettings().get_PrintableArea().Height));
		}

		static GsxkfGjvQpvVn()
		{
			Strings.CreateGetStringDelegate(typeof(GsxkfGjvQpvVn));
		}
	}

	public static void nxuOfptySr(string string_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		GsxkfGjvQpvVn CS_0024_003C_003E8__locals0 = new GsxkfGjvQpvVn();
		CS_0024_003C_003E8__locals0.NzelVmorQHXe = string_0;
		CS_0024_003C_003E8__locals0.oaFhnGEgFINbQi = new PrintDocument();
		CS_0024_003C_003E8__locals0.oaFhnGEgFINbQi.add_PrintPage((PrintPageEventHandler)delegate(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(CS_0024_003C_003E8__locals0.NzelVmorQHXe, new Font(GsxkfGjvQpvVn.getString_0(107365125), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, CS_0024_003C_003E8__locals0.oaFhnGEgFINbQi.get_DefaultPageSettings().get_PrintableArea().Width, CS_0024_003C_003E8__locals0.oaFhnGEgFINbQi.get_DefaultPageSettings().get_PrintableArea().Height));
		});
		try
		{
			CS_0024_003C_003E8__locals0.oaFhnGEgFINbQi.Print();
		}
		catch (Exception)
		{
		}
	}
}
