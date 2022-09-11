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
	private static byte[] _0020;

	private static Hashtable sc;

	private static bool inited;

	private static Assembly runtimeAssembly;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _003CAgileDotNetRT_003E()
	{
		sc = new Hashtable();
		_0020 = new byte[105]
		{
			159, 118, 178, 108, 208, 107, 152, 4, 33, 159,
			237, 114, 24, 228, 252, 103, 22, 77, 237, 240,
			53, 49, 116, 65, 25, 177, 68, 187, 48, 2,
			79, 241, 116, 210, 27, 164, 142, 218, 12, 253,
			213, 147, 38, 104, 222, 167, 55, 178, 17, 126,
			44, 240, 92, 66, 10, 109, 1, 113, 82, 30,
			38, 220, 210, 30, 80, 251, 253, 68, 200, 87,
			215, 58, 64, 239, 27, 161, 11, 11, 98, 113,
			122, 145, 169, 177, 213, 93, 148, 49, 200, 172,
			163, 29, 135, 237, 214, 248, 191, 8, 24, 225,
			168, 241, 232, 184, 165
		};
	}

	internal static string _200B(string P_0)
	{
		Hashtable hashtable;
		瞊.PQAAAA_003D_003D(hashtable = sc);
		try
		{
			if (瞋.BQAAAA_003D_003D_0025(sc, P_0))
			{
				return (string)瞌.CQAAAA_003D_003D_0025(sc, P_0);
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < P_0.Length; i++)
			{
				瞎.PAAAAA_003D_003D_0025(stringBuilder, 瞍.IgAAAA_003D_003D(P_0[i] ^ _0020[i % _0020.Length]));
			}
			瞐.CgAAAA_003D_003D_0025(sc, P_0, 瞏.AwAAAA_003D_003D_0025(stringBuilder));
			return 瞏.AwAAAA_003D_003D_0025(stringBuilder);
		}
		finally
		{
			瞊.PgAAAA_003D_003D(hashtable);
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
		瞊.PQAAAA_003D_003D(type = 睺.CwAAAA_003D_003D(typeof(_003CAgileDotNetRT_003E).TypeHandle));
		try
		{
			WindowsImpersonationContext val = default(WindowsImpersonationContext);
			try
			{
				val = WindowsIdentity.Impersonate(IntPtr.Zero);
				Assembly assembly = 睷.FgAAAA_003D_003D();
				Stream stream = null;
				string text = null;
				string text2 = null;
				if (瞑.ZgAAAA_003D_003D() == 4)
				{
					text = "5f1cc25a-f91d-4ff8-a3be-c7df50209e06";
					text2 = "AgileDotNetRT";
				}
				else
				{
					text = "6df8434e-2f81-49d0-9f91-fa476d8451ff";
					text2 = "AgileDotNetRT64";
				}
				stream = assembly.GetManifestResourceStream(text);
				GZipStream input = new GZipStream(stream, CompressionMode.Decompress);
				BinaryReader binaryReader = new BinaryReader(input);
				byte[] array = 瞓.WQAAAA_003D_003D_0025(binaryReader, 瞒.WgAAAA_003D_003D_0025(binaryReader));
				string text3 = 瞕.OAAAAA_003D_003D("{0}{1}\\", 瞔.ZwAAAA_003D_003D(), text);
				瞖.aAAAAA_003D_003D(text3);
				string text4 = 瞗.OgAAAA_003D_003D(text3, text2, ".dll");
				if (!瞘.HQAAAA_003D_003D(text4))
				{
					FileStream fileStream = 瞙.HgAAAA_003D_003D(text4);
					瞚.TQAAAA_003D_003D_0025(fileStream, array, 0, array.Length);
					瞛.TgAAAA_003D_003D_0025(fileStream);
					FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(new SecurityIdentifier("S-1-1-0"), FileSystemRights.ReadAndExecute, AccessControlType.Allow);
					FileSecurity fileSecurity = 瞜.HwAAAA_003D_003D(text4);
					瞝.agAAAA_003D_003D_0025(fileSecurity, fileSystemAccessRule);
					瞞.IAAAAA_003D_003D(text4, fileSecurity);
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
			瞊.PgAAAA_003D_003D(type);
		}
	}

	internal static int InitializeThroughDelegate(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize");
		InitializeDelegate initializeDelegate = (InitializeDelegate)瞟.bAAAAA_003D_003D(procAddress, 睺.CwAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static int InitializeThroughDelegate64(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize64");
		InitializeDelegate initializeDelegate = (InitializeDelegate)瞟.bAAAAA_003D_003D(procAddress, 睺.CwAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static void ExitThroughDelegate()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit");
		ExitDelegate exitDelegate = (ExitDelegate)瞟.bAAAAA_003D_003D(procAddress, 睺.CwAAAA_003D_003D(typeof(ExitDelegate).TypeHandle));
		exitDelegate();
	}

	internal static void ExitThroughDelegate64()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit64");
		ExitDelegate exitDelegate = (ExitDelegate)瞟.bAAAAA_003D_003D(procAddress, 睺.CwAAAA_003D_003D(typeof(ExitDelegate).TypeHandle));
		exitDelegate();
	}

	internal static void DomainUnload(object P_0, EventArgs P_1)
	{
		if (瞑.ZgAAAA_003D_003D() == 4)
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
			RuntimeMethodHandle runtimeMethodHandle = 瞢.cgAAAA_003D_003D_0025(瞡.cQAAAA_003D_003D_0025(瞠.cAAAAA_003D_003D_0025(new StackTrace(), 0)));
			if (((瞑.ZgAAAA_003D_003D() != 4) ? InitializeThroughDelegate64(runtimeMethodHandle.Value) : InitializeThroughDelegate(runtimeMethodHandle.Value)) == 1)
			{
				瞣.KAAAAA_003D_003D_0025(瞅.JgAAAA_003D_003D(), DomainUnload);
			}
			inited = true;
		}
	}

	internal static void PostInitialize()
	{
	}
}
