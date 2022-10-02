using System;
using System.Drawing;
using System.Drawing.Printing;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UvfJgsTEpPeNG;

public static class VQrWWDTidS
{
	private sealed class HAapNmkZOFZmoD
	{
		public PrintDocument mOCLrAZMjfMSL;

		public string xSavuixSiqkqo;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CPrintNote_003Eb__0(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(xSavuixSiqkqo, new Font(getString_0(107366256), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, mOCLrAZMjfMSL.get_DefaultPageSettings().get_PrintableArea().Width, mOCLrAZMjfMSL.get_DefaultPageSettings().get_PrintableArea().Height));
		}

		static HAapNmkZOFZmoD()
		{
			Strings.CreateGetStringDelegate(typeof(HAapNmkZOFZmoD));
		}
	}

	public static void LPtorjTlwGoCZsIs(string string_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		HAapNmkZOFZmoD CS_0024_003C_003E8__locals0 = new HAapNmkZOFZmoD();
		CS_0024_003C_003E8__locals0.xSavuixSiqkqo = string_0;
		CS_0024_003C_003E8__locals0.mOCLrAZMjfMSL = new PrintDocument();
		CS_0024_003C_003E8__locals0.mOCLrAZMjfMSL.add_PrintPage((PrintPageEventHandler)delegate(object sender, PrintPageEventArgs e)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Expected O, but got Unknown
			e.get_Graphics().DrawString(CS_0024_003C_003E8__locals0.xSavuixSiqkqo, new Font(HAapNmkZOFZmoD.getString_0(107366256), 12f), (Brush)new SolidBrush(Color.Black), new RectangleF(0f, 0f, CS_0024_003C_003E8__locals0.mOCLrAZMjfMSL.get_DefaultPageSettings().get_PrintableArea().Width, CS_0024_003C_003E8__locals0.mOCLrAZMjfMSL.get_DefaultPageSettings().get_PrintableArea().Height));
		});
		try
		{
			CS_0024_003C_003E8__locals0.mOCLrAZMjfMSL.Print();
		}
		catch (Exception)
		{
		}
	}
}
