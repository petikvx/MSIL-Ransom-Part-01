using System;
using System.Collections;
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
	private static byte[] _123;

	private static Hashtable sc;

	private static bool inited;

	private static Assembly runtimeAssembly;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _003CAgileDotNetRT_003E()
	{
		sc = new Hashtable();
		_123 = new byte[102]
		{
			154, 177, 79, 117, 142, 168, 81, 74, 118, 99,
			203, 78, 203, 18, 7, 25, 144, 152, 75, 220,
			104, 150, 191, 234, 49, 110, 63, 250, 169, 13,
			113, 20, 104, 219, 120, 4, 86, 130, 113, 121,
			145, 148, 120, 169, 98, 5, 73, 206, 27, 138,
			104, 205, 144, 169, 187, 4, 240, 99, 68, 32,
			104, 86, 159, 105, 240, 182, 228, 238, 152, 2,
			194, 13, 39, 208, 75, 210, 29, 21, 136, 43,
			36, 112, 222, 31, 164, 163, 131, 190, 31, 116,
			18, 242, 62, 80, 17, 58, 243, 15, 184, 170,
			31, 89
		};
	}

	internal static string cs(string P_0)
	{
		Hashtable hashtable;
		瞅.OQAAAA_003D_003D(hashtable = sc);
		try
		{
			if (瞆.NAAAAA_003D_003D_0025(sc, P_0))
			{
				return (string)瞇.NQAAAA_003D_003D_0025(sc, P_0);
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < P_0.Length; i++)
			{
				瞉.OAAAAA_003D_003D_0025(stringBuilder, 瞈.DwAAAA_003D_003D(P_0[i] ^ _123[i % _123.Length]));
			}
			瞋.NgAAAA_003D_003D_0025(sc, P_0, 瞊.AQAAAA_003D_003D_0025(stringBuilder));
			return 瞊.AQAAAA_003D_003D_0025(stringBuilder);
		}
		finally
		{
			瞅.OgAAAA_003D_003D(hashtable);
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
		瞅.OQAAAA_003D_003D(type = 睷.AgAAAA_003D_003D(typeof(_003CAgileDotNetRT_003E).TypeHandle));
		try
		{
			WindowsImpersonationContext val = default(WindowsImpersonationContext);
			try
			{
				val = WindowsIdentity.Impersonate(IntPtr.Zero);
				Assembly assembly = 瞌.BQAAAA_003D_003D();
				Stream stream = null;
				string text = null;
				string text2 = null;
				if (瞍.RAAAAA_003D_003D() == 4)
				{
					text = "d33a279e-a246-426a-9ba6-aa7086bec025";
					text2 = "AgileDotNetRT";
				}
				else
				{
					text = "5b2f7af3-34b4-4e0b-8525-4dc2d7a7f93b";
					text2 = "AgileDotNetRT64";
				}
				stream = assembly.GetManifestResourceStream(text);
				GZipStream input = new GZipStream(stream, CompressionMode.Decompress);
				BinaryReader binaryReader = new BinaryReader(input);
				byte[] array = 瞏.OwAAAA_003D_003D_0025(binaryReader, 瞎.PAAAAA_003D_003D_0025(binaryReader));
				string text3 = 瞐.FQAAAA_003D_003D("{0}{1}\\", 瞃.IgAAAA_003D_003D(), text);
				瞑.RQAAAA_003D_003D(text3);
				string text4 = 瞒.FwAAAA_003D_003D(text3, text2, ".dll");
				if (!瞓.GwAAAA_003D_003D(text4))
				{
					FileStream fileStream = 瞔.HAAAAA_003D_003D(text4);
					瞕.PwAAAA_003D_003D_0025(fileStream, array, 0, array.Length);
					睾.QAAAAA_003D_003D_0025(fileStream);
					FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(new SecurityIdentifier("S-1-1-0"), FileSystemRights.ReadAndExecute, AccessControlType.Allow);
					FileSecurity fileSecurity = 瞖.HQAAAA_003D_003D(text4);
					瞗.SAAAAA_003D_003D_0025(fileSecurity, fileSystemAccessRule);
					瞘.HgAAAA_003D_003D(text4, fileSecurity);
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
			瞅.OgAAAA_003D_003D(type);
		}
	}

	internal static int InitializeThroughDelegate(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize");
		InitializeDelegate initializeDelegate = (InitializeDelegate)瞙.SgAAAA_003D_003D(procAddress, 睷.AgAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static int InitializeThroughDelegate64(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize64");
		InitializeDelegate initializeDelegate = (InitializeDelegate)瞙.SgAAAA_003D_003D(procAddress, 睷.AgAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static void DomainUnload(object P_0, EventArgs P_1)
	{
		if (瞍.RAAAAA_003D_003D() == 4)
		{
			_AtExit();
		}
		else
		{
			_AtExit64();
		}
	}

	internal static void Initialize()
	{
		if (!inited)
		{
			if (((瞍.RAAAAA_003D_003D() != 4) ? InitializeThroughDelegate64((IntPtr)4) : InitializeThroughDelegate((IntPtr)4)) == 1)
			{
				瞛.TAAAAA_003D_003D_0025(瞚.SwAAAA_003D_003D(), DomainUnload);
			}
			inited = true;
		}
	}

	internal static void PostInitialize()
	{
	}
}
