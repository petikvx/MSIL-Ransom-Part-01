using System;
using System.Drawing;
using System.Drawing.Printing;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gtzdezosLTmcL;

public static class UCubrPozpgE
{
	private sealed class aYhjfZsLLPSY
	{
		public PrintDocument BrEUyDOnEmtKv;

		public string LpceWtFETzhEzFMD;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CPrintNote_003Eb__0(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(LpceWtFETzhEzFMD, new Font(getString_0(107462684), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, BrEUyDOnEmtKv.get_DefaultPageSettings().get_PrintableArea().Width, BrEUyDOnEmtKv.get_DefaultPageSettings().get_PrintableArea().Height));
		}

		static aYhjfZsLLPSY()
		{
			Strings.CreateGetStringDelegate(typeof(aYhjfZsLLPSY));
		}
	}

	public static void eWVidlpdQdAvM(string string_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		aYhjfZsLLPSY CS_0024_003C_003E8__locals0 = new aYhjfZsLLPSY();
		CS_0024_003C_003E8__locals0.LpceWtFETzhEzFMD = string_0;
		CS_0024_003C_003E8__locals0.BrEUyDOnEmtKv = new PrintDocument();
		CS_0024_003C_003E8__locals0.BrEUyDOnEmtKv.add_PrintPage((PrintPageEventHandler)delegate(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(CS_0024_003C_003E8__locals0.LpceWtFETzhEzFMD, new Font(aYhjfZsLLPSY.getString_0(107462684), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, CS_0024_003C_003E8__locals0.BrEUyDOnEmtKv.get_DefaultPageSettings().get_PrintableArea().Width, CS_0024_003C_003E8__locals0.BrEUyDOnEmtKv.get_DefaultPageSettings().get_PrintableArea().Height));
		});
		try
		{
			CS_0024_003C_003E8__locals0.BrEUyDOnEmtKv.Print();
		}
		catch (Exception)
		{
		}
	}
}
