#define DEBUG
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3554254475;

internal static class C543223747
{
	private struct C3554254475
	{
		public IntPtr C3554254475;

		public IntPtr C3904355907;
	}

	internal const int C3554254475 = 260;

	internal const long C3554254475 = -1L;

	internal const uint C3554254475 = 1u;

	internal const uint C3904355907 = 2u;

	internal const uint C1255198513 = 2097152u;

	internal const int C3904355907 = 64;

	internal static readonly Guid C3554254475 = new Guid(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CZ());

	private static bool? m_C3554254475 = null;

	private static Type m_C3554254475 = null;

	private static Type m_C3904355907 = null;

	private const string m_C3554254475 = "libgcrypt.so.20";

	internal const int C1255198513 = 9;

	internal const int C1908338681 = 1;

	[DllImport("KeePassLibC32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool TransformKey256(IntPtr intptr_0, IntPtr intptr_1, ulong ulong_0);

	[DllImport("KeePassLibC64.dll", EntryPoint = "TransformKey256")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool TransformKey256_1(IntPtr intptr_0, IntPtr intptr_1, ulong ulong_0);

	internal static bool C1255198513(IntPtr intptr_0, IntPtr intptr_1, ulong ulong_0)
	{
		if (IntPtr.Size == 4)
		{
			return TransformKey256(intptr_0, intptr_1, ulong_0);
		}
		return TransformKey256_1(intptr_0, intptr_1, ulong_0);
	}

	[DllImport("KeePassLibC32.dll")]
	private static extern ulong TransformKeyBenchmark256(uint uint_0);

	[DllImport("KeePassLibC64.dll", EntryPoint = "TransformKeyBenchmark256")]
	private static extern ulong TransformKeyBenchmark256_1(uint uint_0);

	internal static ulong C1255198513(uint uint_0)
	{
		if (IntPtr.Size == 4)
		{
			return TransformKeyBenchmark256(uint_0);
		}
		return TransformKeyBenchmark256_1(uint_0);
	}

	[DllImport("KeePassLibC32.dll")]
	private static extern void ProtectProcessWithDacl();

	[DllImport("KeePassLibC64.dll", EntryPoint = "ProtectProcessWithDacl")]
	private static extern void ProtectProcessWithDacl_1();

	internal static void C1255198513()
	{
		try
		{
			if (!C1812594589.C1908338681())
			{
				if (IntPtr.Size == 4)
				{
					ProtectProcessWithDacl();
				}
				else
				{
					ProtectProcessWithDacl_1();
				}
			}
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
	}

	[DllImport("Kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, uint uint_0, ref uint uint_1, ref uint uint_2, ref uint uint_3, StringBuilder stringBuilder_1, uint uint_4);

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool MoveFileEx(string string_0, string string_1, uint uint_0);

	[DllImport("KtmW32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr CreateTransaction(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, uint uint_1, uint uint_2, uint uint_3, string string_0);

	[DllImport("KtmW32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CommitTransaction(IntPtr intptr_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool MoveFileTransacted(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, uint uint_0, IntPtr intptr_2);

	[DllImport("Shell32.dll")]
	private static extern int SHGetKnownFolderPath(ref Guid guid_0, uint uint_0, IntPtr intptr_0, out IntPtr intptr_1);

	[DllImport("ShlWApi.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool PathRelativePathTo([Out] StringBuilder stringBuilder_0, [In] string string_0, uint uint_0, [In] string string_1, uint uint_1);

	[DllImport("ShlWApi.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	private static extern int StrCmpLogicalW(string string_0, string string_1);

	private static void C1908338681()
	{
		try
		{
			StrCmpLogicalW(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cv(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cv());
			C543223747.m_C3554254475 = true;
		}
		catch (Exception)
		{
			C543223747.m_C3554254475 = false;
		}
	}

	[SpecialName]
	internal static bool C1037565863()
	{
		if (!C543223747.m_C3554254475.HasValue)
		{
			C1908338681();
		}
		return C543223747.m_C3554254475.Value;
	}

	internal static int C3904355907(string string_0, string string_1)
	{
		if (!C1037565863())
		{
			Debug.Assert(condition: false);
			return string.Compare(string_0, string_1, ignoreCase: true);
		}
		return StrCmpLogicalW(string_0, string_1);
	}

	internal static string C3554254475(Guid guid_0)
	{
		if (Marshal.SystemDefaultCharSize != 2)
		{
			Debug.Assert(condition: false);
			return string.Empty;
		}
		IntPtr intptr_ = IntPtr.Zero;
		try
		{
			if (SHGetKnownFolderPath(ref guid_0, 0u, IntPtr.Zero, out intptr_) == 0)
			{
				if (intptr_ != IntPtr.Zero)
				{
					return Marshal.PtrToStringUni(intptr_);
				}
				Debug.Assert(condition: false);
			}
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		finally
		{
			try
			{
				if (intptr_ != IntPtr.Zero)
				{
					Marshal.FreeCoTaskMem(intptr_);
				}
			}
			catch (Exception)
			{
				Debug.Assert(condition: false);
			}
		}
		return string.Empty;
	}

	[DllImport("libX11")]
	private static extern int XSetClassHint(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

	private static Type C3554254475(bool bool_0)
	{
		if (C543223747.m_C3554254475 == null)
		{
			string assemblyQualifiedName = typeof(CheckState).AssemblyQualifiedName;
			string typeName = assemblyQualifiedName.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CW(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cw());
			C543223747.m_C3554254475 = Type.GetType(typeName, bool_0, ignoreCase: true);
		}
		return C543223747.m_C3554254475;
	}

	private static Type C3904355907(bool bool_0)
	{
		if (C543223747.m_C3904355907 == null)
		{
			string assemblyQualifiedName = typeof(CheckState).AssemblyQualifiedName;
			string typeName = assemblyQualifiedName.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CW(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CX());
			C543223747.m_C3904355907 = Type.GetType(typeName, bool_0, ignoreCase: true);
		}
		return C543223747.m_C3904355907;
	}

	internal static void C3554254475(Form form_0, string string_0, string string_1)
	{
		if (form_0 == null)
		{
			Debug.Assert(condition: false);
		}
		else if (C1812594589.C1037565863() != PlatformID.MacOSX)
		{
			try
			{
				Type type = C3554254475(bool_0: true);
				FieldInfo field = type.GetField(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cx(), BindingFlags.Static | BindingFlags.NonPublic);
				IntPtr intptr_ = (IntPtr)field.GetValue(null);
				Type type2 = C3904355907(bool_0: true);
				MethodInfo method = type2.GetMethod(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.CY(), BindingFlags.Static | BindingFlags.Public);
				object obj = method.Invoke(null, new object[1] { ((Control)form_0).get_Handle() });
				FieldInfo field2 = type2.GetField(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Cy(), BindingFlags.Instance | BindingFlags.NonPublic);
				IntPtr intptr_2 = (IntPtr)field2.GetValue(obj);
				C3554254475 structure = default(C3554254475);
				structure.C3554254475 = Marshal.StringToCoTaskMemAnsi(string_0 ?? string.Empty);
				structure.C3904355907 = Marshal.StringToCoTaskMemAnsi(string_1 ?? string.Empty);
				IntPtr intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(structure));
				Marshal.StructureToPtr(structure, intPtr, fDeleteOld: false);
				XSetClassHint(intptr_, intptr_2, intPtr);
				Marshal.FreeCoTaskMem(intPtr);
				Marshal.FreeCoTaskMem(structure.C3554254475);
				Marshal.FreeCoTaskMem(structure.C3904355907);
			}
			catch (Exception)
			{
				Debug.Assert(condition: false);
			}
		}
	}

	[DllImport("libgcrypt.so.20")]
	internal static extern IntPtr gcry_check_version(IntPtr intptr_0);

	[DllImport("libgcrypt.so.20")]
	internal static extern uint gcry_cipher_open(ref IntPtr intptr_0, int int_0, int int_1, uint uint_0);

	[DllImport("libgcrypt.so.20")]
	internal static extern void gcry_cipher_close(IntPtr intptr_0);

	[DllImport("libgcrypt.so.20")]
	internal static extern uint gcry_cipher_setkey(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("libgcrypt.so.20")]
	internal static extern uint gcry_cipher_encrypt(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4);
}
