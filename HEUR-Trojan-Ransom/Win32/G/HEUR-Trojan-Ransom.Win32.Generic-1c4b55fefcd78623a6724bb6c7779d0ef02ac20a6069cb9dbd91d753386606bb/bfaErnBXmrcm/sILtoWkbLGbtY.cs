using System;
using System.Drawing;
using System.Drawing.Printing;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bfaErnBXmrcm;

public static class sILtoWkbLGbtY
{
	private sealed class SjhVRrdYUw
	{
		public PrintDocument pKeNKCZkdysz;

		public string otiexZnbvZXR;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CPrintNote_003Eb__0(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(otiexZnbvZXR, new Font(getString_0(107365679), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, pKeNKCZkdysz.get_DefaultPageSettings().get_PrintableArea().Width, pKeNKCZkdysz.get_DefaultPageSettings().get_PrintableArea().Height));
		}

		static SjhVRrdYUw()
		{
			Strings.CreateGetStringDelegate(typeof(SjhVRrdYUw));
		}
	}

	public static void esDeouPWeK(string string_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		SjhVRrdYUw CS_0024_003C_003E8__locals0 = new SjhVRrdYUw();
		CS_0024_003C_003E8__locals0.otiexZnbvZXR = string_0;
		CS_0024_003C_003E8__locals0.pKeNKCZkdysz = new PrintDocument();
		CS_0024_003C_003E8__locals0.pKeNKCZkdysz.add_PrintPage((PrintPageEventHandler)delegate(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(CS_0024_003C_003E8__locals0.otiexZnbvZXR, new Font(SjhVRrdYUw.getString_0(107365679), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, CS_0024_003C_003E8__locals0.pKeNKCZkdysz.get_DefaultPageSettings().get_PrintableArea().Width, CS_0024_003C_003E8__locals0.pKeNKCZkdysz.get_DefaultPageSettings().get_PrintableArea().Height));
		});
		try
		{
			CS_0024_003C_003E8__locals0.pKeNKCZkdysz.Print();
		}
		catch (Exception)
		{
		}
	}
}
