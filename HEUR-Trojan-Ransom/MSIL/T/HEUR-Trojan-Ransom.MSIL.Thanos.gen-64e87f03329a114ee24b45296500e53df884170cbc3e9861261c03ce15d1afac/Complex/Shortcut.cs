using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Complex;

public sealed class Shortcut
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface IWshShortcut
	{
		[DispId(0)]
		string FullName
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string Arguments
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
		string Description
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
		string Hotkey
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
		string IconLocation
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
		string RelativePath
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string TargetPath
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
		int WindowStyle
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string WorkingDirectory
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

	private static Type m_type;

	private static object m_shell;

	[NonSerialized]
	internal static GetString getString_0;

	public static void Create(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			IWshShortcut wshShortcut = (IWshShortcut)m_type.InvokeMember(Program.Base64Decode(getString_0(107402001)), BindingFlags.InvokeMethod, null, m_shell, new object[1] { string_0 });
			wshShortcut.Description = string_4;
			wshShortcut.Hotkey = string_5;
			wshShortcut.TargetPath = string_1;
			wshShortcut.WorkingDirectory = string_3;
			wshShortcut.Arguments = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				wshShortcut.IconLocation = string_6;
			}
			wshShortcut.Save();
		}
		catch (Exception ex)
		{
			if (Program.debugmode)
			{
				try
				{
					File.AppendAllText(Program.DebugReport, getString_0(107402004) + ex.Message + getString_0(107396411));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static Shortcut()
	{
		Strings.CreateGetStringDelegate(typeof(Shortcut));
		m_type = Type.GetTypeFromProgID(Program.Base64Decode(getString_0(107402439)));
		m_shell = Activator.CreateInstance(m_type);
	}
}
