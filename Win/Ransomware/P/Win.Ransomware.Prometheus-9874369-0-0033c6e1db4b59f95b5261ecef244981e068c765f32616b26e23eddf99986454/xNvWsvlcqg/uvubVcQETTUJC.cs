using System;
using System.Drawing;
using System.Drawing.Printing;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace xNvWsvlcqg;

public static class uvubVcQETTUJC
{
	private sealed class PQQXswbpfzEkSl
	{
		public PrintDocument NAVWSJrFtVrKyu;

		public string bscniwEecMX;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CPrintNote_003Eb__0(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(bscniwEecMX, new Font(getString_0(107462205), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, NAVWSJrFtVrKyu.get_DefaultPageSettings().get_PrintableArea().Width, NAVWSJrFtVrKyu.get_DefaultPageSettings().get_PrintableArea().Height));
		}

		static PQQXswbpfzEkSl()
		{
			Strings.CreateGetStringDelegate(typeof(PQQXswbpfzEkSl));
		}
	}

	public static void GZysqcCzoSWVFVkK(string string_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		PQQXswbpfzEkSl CS_0024_003C_003E8__locals0 = new PQQXswbpfzEkSl();
		CS_0024_003C_003E8__locals0.bscniwEecMX = string_0;
		CS_0024_003C_003E8__locals0.NAVWSJrFtVrKyu = new PrintDocument();
		CS_0024_003C_003E8__locals0.NAVWSJrFtVrKyu.add_PrintPage((PrintPageEventHandler)delegate(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(CS_0024_003C_003E8__locals0.bscniwEecMX, new Font(PQQXswbpfzEkSl.getString_0(107462205), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, CS_0024_003C_003E8__locals0.NAVWSJrFtVrKyu.get_DefaultPageSettings().get_PrintableArea().Width, CS_0024_003C_003E8__locals0.NAVWSJrFtVrKyu.get_DefaultPageSettings().get_PrintableArea().Height));
		});
		try
		{
			CS_0024_003C_003E8__locals0.NAVWSJrFtVrKyu.Print();
		}
		catch (Exception)
		{
		}
	}
}
