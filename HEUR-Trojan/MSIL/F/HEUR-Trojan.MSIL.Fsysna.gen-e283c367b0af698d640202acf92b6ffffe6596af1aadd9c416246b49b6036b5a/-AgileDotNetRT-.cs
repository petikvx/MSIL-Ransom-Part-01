using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;

[SecuritySafeCritical]
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
		pRM_003D = new byte[114]
		{
			191, 66, 125, 58, 204, 138, 143, 0, 96, 49,
			210, 114, 126, 69, 151, 78, 169, 113, 21, 68,
			34, 206, 86, 104, 115, 78, 85, 140, 199, 197,
			157, 166, 23, 247, 108, 223, 52, 97, 163, 193,
			5, 225, 156, 44, 236, 202, 228, 53, 19, 199,
			181, 124, 230, 73, 155, 239, 235, 21, 198, 126,
			53, 2, 55, 154, 147, 44, 91, 133, 215, 183,
			26, 72, 205, 82, 63, 64, 49, 41, 122, 167,
			104, 31, 120, 254, 15, 32, 190, 204, 92, 123,
			243, 30, 154, 36, 139, 2, 169, 2, 152, 191,
			111, 95, 93, 91, 172, 109, 174, 147, 9, 91,
			190, 193, 153, 30
		};
	}

	internal static string oRM_003D(string P_0)
	{
		Hashtable hashtable;
		瞱.cQAAAA_003D_003D(hashtable = sc);
		try
		{
			if (瞲.bgAAAA_003D_003D_0025(sc, P_0))
			{
				return (string)瞳.bwAAAA_003D_003D_0025(sc, P_0);
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < P_0.Length; i++)
			{
				瞅.LgAAAA_003D_003D_0025(stringBuilder, 瞴.NgAAAA_003D_003D(P_0[i] ^ pRM_003D[i % pRM_003D.Length]));
			}
			瞵.cAAAAA_003D_003D_0025(sc, P_0, 睺.AAAAAA_003D_003D_0025(stringBuilder));
			return 睺.AAAAAA_003D_003D_0025(stringBuilder);
		}
		finally
		{
			瞱.cgAAAA_003D_003D(hashtable);
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
		瞱.cQAAAA_003D_003D(type = 瞶.gQAAAA_003D_003D(typeof(_003CAgileDotNetRT_003E).TypeHandle));
		try
		{
			WindowsImpersonationContext val = default(WindowsImpersonationContext);
			try
			{
				val = WindowsIdentity.Impersonate(IntPtr.Zero);
				Assembly assembly = 睹.FgAAAA_003D_003D();
				Stream stream = null;
				string text = null;
				string text2 = null;
				if (瞷.awAAAA_003D_003D() == 4)
				{
					text = "fb9fc514-4e3e-4c12-9c1e-b2e7e9736d0b";
					text2 = "AgileDotNetRT";
				}
				else
				{
					text = "c3146dc3-d053-479f-aba1-beaba5073433";
					text2 = "AgileDotNetRT64";
				}
				stream = assembly.GetManifestResourceStream(text);
				GZipStream input = new GZipStream(stream, CompressionMode.Decompress);
				BinaryReader binaryReader = new BinaryReader(input);
				byte[] array = 瞕.iwAAAA_003D_003D_0025(binaryReader, 瞂.jAAAAA_003D_003D_0025(binaryReader));
				string text3 = 瞸.KwAAAA_003D_003D("{0}{1}\\", 瞪.HQAAAA_003D_003D(), text);
				瞹.OQAAAA_003D_003D(text3);
				string text4 = 瞏.JAAAAA_003D_003D(text3, text2, ".dll");
				if (!瞩.QgAAAA_003D_003D(text4))
				{
					FileStream fileStream = 瞺.RgAAAA_003D_003D(text4);
					瞘.WAAAAA_003D_003D_0025(fileStream, array, 0, array.Length);
					瞙.WQAAAA_003D_003D_0025(fileStream);
					FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(new SecurityIdentifier("S-1-1-0"), FileSystemRights.ReadAndExecute, AccessControlType.Allow);
					FileSecurity fileSecurity = 瞻.RwAAAA_003D_003D(text4);
					瞼.lwAAAA_003D_003D_0025(fileSecurity, fileSystemAccessRule);
					瞽.SAAAAA_003D_003D(text4, fileSecurity);
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
			瞱.cgAAAA_003D_003D(type);
		}
	}

	internal static int InitializeThroughDelegate(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize");
		InitializeDelegate initializeDelegate = (InitializeDelegate)瞾.mQAAAA_003D_003D(procAddress, 瞶.gQAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static int InitializeThroughDelegate64(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize64");
		InitializeDelegate initializeDelegate = (InitializeDelegate)瞾.mQAAAA_003D_003D(procAddress, 瞶.gQAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static void ExitThroughDelegate()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit");
		ExitDelegate exitDelegate = (ExitDelegate)瞾.mQAAAA_003D_003D(procAddress, 瞶.gQAAAA_003D_003D(typeof(ExitDelegate).TypeHandle));
		exitDelegate();
	}

	internal static void ExitThroughDelegate64()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit64");
		ExitDelegate exitDelegate = (ExitDelegate)瞾.mQAAAA_003D_003D(procAddress, 瞶.gQAAAA_003D_003D(typeof(ExitDelegate).TypeHandle));
		exitDelegate();
	}

	internal static void DomainUnload(object P_0, EventArgs P_1)
	{
		if (瞷.awAAAA_003D_003D() == 4)
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
			RuntimeMethodHandle runtimeMethodHandle = 矁.nwAAAA_003D_003D_0025(矀.ngAAAA_003D_003D_0025(瞿.nQAAAA_003D_003D_0025(new StackTrace(), 0)));
			if (((瞷.awAAAA_003D_003D() != 4) ? InitializeThroughDelegate64(runtimeMethodHandle.Value) : InitializeThroughDelegate(runtimeMethodHandle.Value)) == 1)
			{
				矂.YwAAAA_003D_003D_0025(瞠.YQAAAA_003D_003D(), DomainUnload);
			}
			inited = true;
		}
	}

	internal static void PostInitialize()
	{
	}
}
