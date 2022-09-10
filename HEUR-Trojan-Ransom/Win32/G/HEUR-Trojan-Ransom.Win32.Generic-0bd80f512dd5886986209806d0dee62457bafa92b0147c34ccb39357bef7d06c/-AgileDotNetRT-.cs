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
		pRM_003D = new byte[104]
		{
			88, 15, 95, 249, 59, 121, 59, 230, 139, 217,
			73, 25, 118, 222, 85, 253, 25, 34, 2, 105,
			219, 178, 62, 244, 87, 166, 204, 16, 229, 35,
			231, 112, 148, 91, 23, 104, 56, 236, 143, 129,
			77, 127, 2, 153, 246, 100, 41, 238, 147, 247,
			145, 62, 12, 72, 96, 165, 208, 105, 161, 148,
			171, 43, 1, 103, 240, 216, 132, 27, 198, 235,
			196, 44, 146, 128, 27, 91, 176, 164, 253, 241,
			124, 221, 123, 236, 145, 169, 99, 76, 250, 113,
			151, 206, 74, 249, 212, 34, 126, 153, 168, 30,
			223, 14, 40, 166
		};
	}

	internal static string oRM_003D(string P_0)
	{
		Hashtable hashtable;
		瞋.OwAAAA_003D_003D(hashtable = sc);
		try
		{
			if (瞌.NQAAAA_003D_003D_0025(sc, P_0))
			{
				return (string)瞍.NgAAAA_003D_003D_0025(sc, P_0);
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < P_0.Length; i++)
			{
				瞏.OQAAAA_003D_003D_0025(stringBuilder, 瞎.OgAAAA_003D_003D(P_0[i] ^ pRM_003D[i % pRM_003D.Length]));
			}
			瞑.NwAAAA_003D_003D_0025(sc, P_0, 瞐.DgAAAA_003D_003D_0025(stringBuilder));
			return 瞐.DgAAAA_003D_003D_0025(stringBuilder);
		}
		finally
		{
			瞋.PAAAAA_003D_003D(hashtable);
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
		瞋.OwAAAA_003D_003D(type = 瞇.KwAAAA_003D_003D(typeof(_003CAgileDotNetRT_003E).TypeHandle));
		try
		{
			WindowsImpersonationContext val = default(WindowsImpersonationContext);
			try
			{
				val = WindowsIdentity.Impersonate(IntPtr.Zero);
				Assembly assembly = 瞒.LQAAAA_003D_003D();
				Stream stream = null;
				string text = null;
				string text2 = null;
				if (瞓.ZQAAAA_003D_003D() == 4)
				{
					text = "36af10af-a99a-4907-9e55-5f5bb1e8a402";
					text2 = "AgileDotNetRT";
				}
				else
				{
					text = "08e0e2b6-be77-4b01-a603-cbbd1db66708";
					text2 = "AgileDotNetRT64";
				}
				stream = assembly.GetManifestResourceStream(text);
				GZipStream input = new GZipStream(stream, CompressionMode.Decompress);
				BinaryReader binaryReader = new BinaryReader(input);
				byte[] array = 瞕.WAAAAA_003D_003D_0025(binaryReader, 瞔.WQAAAA_003D_003D_0025(binaryReader));
				string text3 = 瞗.HwAAAA_003D_003D("{0}{1}\\", 瞖.ZgAAAA_003D_003D(), text);
				瞘.ZwAAAA_003D_003D(text3);
				string text4 = 瞀.GgAAAA_003D_003D(text3, text2, ".dll");
				if (!瞙.JAAAAA_003D_003D(text4))
				{
					FileStream fileStream = 瞚.JQAAAA_003D_003D(text4);
					瞛.TAAAAA_003D_003D_0025(fileStream, array, 0, array.Length);
					瞜.TQAAAA_003D_003D_0025(fileStream);
					FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(new SecurityIdentifier("S-1-1-0"), FileSystemRights.ReadAndExecute, AccessControlType.Allow);
					FileSecurity fileSecurity = 瞝.JgAAAA_003D_003D(text4);
					瞞.aQAAAA_003D_003D_0025(fileSecurity, fileSystemAccessRule);
					瞟.JwAAAA_003D_003D(text4, fileSecurity);
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
			瞋.PAAAAA_003D_003D(type);
		}
	}

	internal static int InitializeThroughDelegate(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize");
		InitializeDelegate initializeDelegate = (InitializeDelegate)瞠.awAAAA_003D_003D(procAddress, 瞇.KwAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static int InitializeThroughDelegate64(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize64");
		InitializeDelegate initializeDelegate = (InitializeDelegate)瞠.awAAAA_003D_003D(procAddress, 瞇.KwAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static void ExitThroughDelegate()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit");
		ExitDelegate exitDelegate = (ExitDelegate)瞠.awAAAA_003D_003D(procAddress, 瞇.KwAAAA_003D_003D(typeof(ExitDelegate).TypeHandle));
		exitDelegate();
	}

	internal static void ExitThroughDelegate64()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit64");
		ExitDelegate exitDelegate = (ExitDelegate)瞠.awAAAA_003D_003D(procAddress, 瞇.KwAAAA_003D_003D(typeof(ExitDelegate).TypeHandle));
		exitDelegate();
	}

	internal static void DomainUnload(object P_0, EventArgs P_1)
	{
		if (瞓.ZQAAAA_003D_003D() == 4)
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
			RuntimeMethodHandle runtimeMethodHandle = 瞣.cAAAAA_003D_003D_0025(瞢.bwAAAA_003D_003D_0025(瞡.bgAAAA_003D_003D_0025(new StackTrace(), 0)));
			if (((瞓.ZQAAAA_003D_003D() != 4) ? InitializeThroughDelegate64(runtimeMethodHandle.GetFunctionPointer()) : InitializeThroughDelegate(runtimeMethodHandle.GetFunctionPointer())) == 1)
			{
				瞥.QQAAAA_003D_003D_0025(瞤.PwAAAA_003D_003D(), DomainUnload);
			}
			inited = true;
		}
	}

	internal static void PostInitialize()
	{
	}
}
