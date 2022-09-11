using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;

internal class _003CAgileDotNetRT_003E
{
	private static byte[] pRM_003D;

	private static Hashtable sc;

	private static bool inited;

	private static Assembly runtimeAssembly;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _003CAgileDotNetRT_003E()
	{
		sc = new Hashtable();
		pRM_003D = new byte[103]
		{
			47, 245, 165, 74, 167, 164, 36, 65, 12, 210,
			11, 230, 119, 244, 105, 152, 208, 152, 240, 62,
			62, 214, 123, 72, 246, 81, 27, 117, 235, 59,
			185, 45, 96, 104, 207, 85, 118, 137, 53, 240,
			217, 61, 78, 96, 26, 149, 241, 249, 253, 9,
			226, 91, 49, 139, 235, 87, 121, 93, 82, 85,
			136, 173, 84, 208, 25, 221, 133, 15, 36, 20,
			34, 71, 98, 254, 99, 1, 136, 27, 45, 96,
			94, 33, 119, 226, 87, 93, 250, 212, 123, 119,
			218, 24, 54, 222, 103, 44, 231, 124, 71, 60,
			16, 225, 212
		};
	}

	internal static string oRM_003D(string P_0)
	{
		Hashtable hashtable;
		瞇.OgAAAA_003D_003D(hashtable = sc);
		try
		{
			if (瞈.NQAAAA_003D_003D_0025(sc, P_0))
			{
				return (string)瞉.NgAAAA_003D_003D_0025(sc, P_0);
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < P_0.Length; i++)
			{
				瞊.OQAAAA_003D_003D_0025(stringBuilder, 睼.JgAAAA_003D_003D(P_0[i] ^ pRM_003D[i % pRM_003D.Length]));
			}
			瞌.NwAAAA_003D_003D_0025(sc, P_0, 瞋.DwAAAA_003D_003D_0025(stringBuilder));
			return 瞋.DwAAAA_003D_003D_0025(stringBuilder);
		}
		finally
		{
			瞇.OwAAAA_003D_003D(hashtable);
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.ForwardRef)]
	private static extern IntPtr LoadLibraryA(string P_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.ForwardRef)]
	private static extern IntPtr GetProcAddress(IntPtr P_0, string P_1);

	[DllImport("AgileDotNetRT.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.ForwardRef)]
	private static extern int _Initialize(IntPtr P_0);

	[DllImport("AgileDotNetRT64.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.ForwardRef)]
	private static extern int _Initialize64(IntPtr P_0);

	[DllImport("AgileDotNetRT.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.ForwardRef)]
	private static extern void _AtExit();

	[DllImport("AgileDotNetRT64.dll", CharSet = CharSet.Ansi, EntryPoint = "_AtExit", ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.ForwardRef)]
	private static extern void _AtExit64();

	internal static IntPtr Load()
	{
		Type type;
		瞇.OgAAAA_003D_003D(type = 瞃.KwAAAA_003D_003D(typeof(_003CAgileDotNetRT_003E).TypeHandle));
		try
		{
			WindowsImpersonationContext val = default(WindowsImpersonationContext);
			try
			{
				val = WindowsIdentity.Impersonate(IntPtr.Zero);
				Assembly assembly = 瞍.LgAAAA_003D_003D();
				Stream stream = null;
				string text = null;
				string text2 = null;
				if (瞎.ZAAAAA_003D_003D() == 4)
				{
					text = "b8da9a92-07e3-42b1-b849-a6275ad9053e";
					text2 = "AgileDotNetRT";
				}
				else
				{
					text = "d5282b60-25ab-46aa-a430-77f754a6c0b9";
					text2 = "AgileDotNetRT64";
				}
				stream = assembly.GetManifestResourceStream(text);
				GZipStream input = new GZipStream(stream, CompressionMode.Decompress);
				BinaryReader binaryReader = new BinaryReader(input);
				byte[] array = 瞐.VwAAAA_003D_003D_0025(binaryReader, 瞏.WAAAAA_003D_003D_0025(binaryReader));
				string text3 = 瞒.IQAAAA_003D_003D("{0}{1}\\", 瞑.JQAAAA_003D_003D(), text);
				瞓.ZQAAAA_003D_003D(text3);
				string text4 = 瞔.IwAAAA_003D_003D(text3, text2, ".dll");
				if (!瞕.GQAAAA_003D_003D(text4))
				{
					FileStream fileStream = 瞖.GgAAAA_003D_003D(text4);
					瞗.SwAAAA_003D_003D_0025(fileStream, array, 0, array.Length);
					瞘.TAAAAA_003D_003D_0025(fileStream);
					FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(new SecurityIdentifier("S-1-1-0"), FileSystemRights.ReadAndExecute, AccessControlType.Allow);
					FileSecurity fileSecurity = 瞙.GwAAAA_003D_003D(text4);
					瞚.ZwAAAA_003D_003D_0025(fileSecurity, fileSystemAccessRule);
					瞛.HAAAAA_003D_003D(text4, fileSecurity);
				}
				return LoadLibraryA(text4);
			}
			finally
			{
				val.Undo();
			}
		}
		finally
		{
			瞇.OwAAAA_003D_003D(type);
		}
	}

	internal static int InitializeThroughDelegate(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize");
		InitializeDelegate initializeDelegate = (InitializeDelegate)瞜.aQAAAA_003D_003D(procAddress, 瞃.KwAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static int InitializeThroughDelegate64(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize64");
		InitializeDelegate initializeDelegate = (InitializeDelegate)瞜.aQAAAA_003D_003D(procAddress, 瞃.KwAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static void ExitThroughDelegate()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit");
		ExitDelegate exitDelegate = (ExitDelegate)瞜.aQAAAA_003D_003D(procAddress, 瞃.KwAAAA_003D_003D(typeof(ExitDelegate).TypeHandle));
		exitDelegate();
	}

	internal static void ExitThroughDelegate64()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit64");
		ExitDelegate exitDelegate = (ExitDelegate)瞜.aQAAAA_003D_003D(procAddress, 瞃.KwAAAA_003D_003D(typeof(ExitDelegate).TypeHandle));
		exitDelegate();
	}

	internal static void DomainUnload(object P_0, EventArgs P_1)
	{
		if (瞎.ZAAAAA_003D_003D() == 4)
		{
			ExitThroughDelegate();
		}
		else
		{
			ExitThroughDelegate64();
		}
	}

	internal static void Initialize()
	{
		if (!inited)
		{
			RuntimeMethodHandle runtimeMethodHandle = 瞟.bgAAAA_003D_003D_0025(瞞.bQAAAA_003D_003D_0025(瞝.bAAAAA_003D_003D_0025(new StackTrace(), 0)));
			if (((瞎.ZAAAAA_003D_003D() != 4) ? InitializeThroughDelegate64(runtimeMethodHandle.Value) : InitializeThroughDelegate(runtimeMethodHandle.Value)) == 1)
			{
				瞡.QAAAAA_003D_003D_0025(瞠.PgAAAA_003D_003D(), DomainUnload);
			}
			inited = true;
		}
	}

	internal static void PostInitialize()
	{
	}
}
