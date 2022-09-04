using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

public sealed class dret
{
	private object object_0;

	public dret()
	{
		object_0 = "hehehe";
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetDC(IntPtr hwnd);

	public static object EnterText(object data)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		object result = default(object);
		try
		{
			Graphics val = Graphics.FromHdc(GetDC(IntPtr.Zero));
			val.DrawString(Conversions.ToString(data), new Font("arial", 25f), Brushes.get_Red(), Conversions.ToSingle(Conversions.ToString(Conversion.Int(VBMath.Rnd() * (float)((Computer)Class1.Class0_0).get_Screen().get_Bounds().Width))), Conversions.ToSingle(Conversions.ToString(Conversion.Int(VBMath.Rnd() * (float)((Computer)Class1.Class0_0).get_Screen().get_Bounds().Height))));
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
