using System;
using System.Drawing;
using System.Drawing.Printing;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UmXkJLRjSLdPF;

public static class nLpAcVMOXbMht
{
	private sealed class dNFLzHeUqaA
	{
		public PrintDocument QBZStziJedAqAkl;

		public string neyCMhXIQXfLBaw;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CPrintNote_003Eb__0(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(neyCMhXIQXfLBaw, new Font(getString_0(107462816), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, QBZStziJedAqAkl.get_DefaultPageSettings().get_PrintableArea().Width, QBZStziJedAqAkl.get_DefaultPageSettings().get_PrintableArea().Height));
		}

		static dNFLzHeUqaA()
		{
			Strings.CreateGetStringDelegate(typeof(dNFLzHeUqaA));
		}
	}

	public static void kkLJvZLWeOuhR(string string_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		dNFLzHeUqaA CS_0024_003C_003E8__locals0 = new dNFLzHeUqaA();
		CS_0024_003C_003E8__locals0.neyCMhXIQXfLBaw = string_0;
		CS_0024_003C_003E8__locals0.QBZStziJedAqAkl = new PrintDocument();
		CS_0024_003C_003E8__locals0.QBZStziJedAqAkl.add_PrintPage((PrintPageEventHandler)delegate(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(CS_0024_003C_003E8__locals0.neyCMhXIQXfLBaw, new Font(dNFLzHeUqaA.getString_0(107462816), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, CS_0024_003C_003E8__locals0.QBZStziJedAqAkl.get_DefaultPageSettings().get_PrintableArea().Width, CS_0024_003C_003E8__locals0.QBZStziJedAqAkl.get_DefaultPageSettings().get_PrintableArea().Height));
		});
		try
		{
			CS_0024_003C_003E8__locals0.QBZStziJedAqAkl.Print();
		}
		catch (Exception)
		{
		}
	}
}
