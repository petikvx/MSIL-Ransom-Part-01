using System;
using System.Drawing;
using System.Drawing.Printing;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace WEoqBCtavg;

public static class XaliFjexNdirMh
{
	private sealed class aZafvvCkyNIohp
	{
		public PrintDocument JYqEpeICrndIStN;

		public string xPqtSoQQkYv;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CPrintNote_003Eb__0(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(xPqtSoQQkYv, new Font(getString_0(107461461), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, JYqEpeICrndIStN.get_DefaultPageSettings().get_PrintableArea().Width, JYqEpeICrndIStN.get_DefaultPageSettings().get_PrintableArea().Height));
		}

		static aZafvvCkyNIohp()
		{
			Strings.CreateGetStringDelegate(typeof(aZafvvCkyNIohp));
		}
	}

	public static void xHgKDEvaxhHDdRE(string string_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		aZafvvCkyNIohp CS_0024_003C_003E8__locals0 = new aZafvvCkyNIohp();
		CS_0024_003C_003E8__locals0.xPqtSoQQkYv = string_0;
		CS_0024_003C_003E8__locals0.JYqEpeICrndIStN = new PrintDocument();
		CS_0024_003C_003E8__locals0.JYqEpeICrndIStN.add_PrintPage((PrintPageEventHandler)delegate(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(CS_0024_003C_003E8__locals0.xPqtSoQQkYv, new Font(aZafvvCkyNIohp.getString_0(107461461), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, CS_0024_003C_003E8__locals0.JYqEpeICrndIStN.get_DefaultPageSettings().get_PrintableArea().Width, CS_0024_003C_003E8__locals0.JYqEpeICrndIStN.get_DefaultPageSettings().get_PrintableArea().Height));
		});
		try
		{
			CS_0024_003C_003E8__locals0.JYqEpeICrndIStN.Print();
		}
		catch (Exception)
		{
		}
	}
}
