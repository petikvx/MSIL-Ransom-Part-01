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
		pRM_003D = new byte[104]
		{
			70, 26, 122, 148, 189, 67, 155, 111, 55, 13,
			131, 165, 186, 152, 194, 211, 253, 217, 164, 155,
			104, 221, 42, 213, 7, 14, 249, 88, 127, 20,
			19, 75, 110, 254, 179, 191, 232, 66, 78, 213,
			50, 244, 10, 201, 38, 195, 152, 44, 11, 9,
			78, 14, 80, 221, 210, 103, 239, 164, 140, 174,
			72, 67, 239, 35, 248, 56, 55, 186, 228, 2,
			233, 186, 138, 206, 104, 115, 211, 96, 174, 66,
			117, 205, 76, 117, 197, 5, 250, 143, 44, 75,
			207, 68, 181, 158, 140, 238, 4, 229, 207, 236,
			140, 220, 71, 8
		};
	}

	internal static string oRM_003D(string P_0)
	{
		Hashtable hashtable;
		瞜.UgAAAA_003D_003D(hashtable = sc);
		try
		{
			if (瞝.TAAAAA_003D_003D_0025(sc, P_0))
			{
				return (string)瞞.TQAAAA_003D_003D_0025(sc, P_0);
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < P_0.Length; i++)
			{
				瞠.UAAAAA_003D_003D_0025(stringBuilder, 瞟.UQAAAA_003D_003D(P_0[i] ^ pRM_003D[i % pRM_003D.Length]));
			}
			瞡.TgAAAA_003D_003D_0025(sc, P_0, 瞀.DwAAAA_003D_003D_0025(stringBuilder));
			return 瞀.DwAAAA_003D_003D_0025(stringBuilder);
		}
		finally
		{
			瞜.UwAAAA_003D_003D(hashtable);
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
		瞜.UgAAAA_003D_003D(type = 睸.IwAAAA_003D_003D(typeof(_003CAgileDotNetRT_003E).TypeHandle));
		try
		{
			WindowsImpersonationContext val = default(WindowsImpersonationContext);
			try
			{
				val = WindowsIdentity.Impersonate(IntPtr.Zero);
				Assembly assembly = 睿.JQAAAA_003D_003D();
				Stream stream = null;
				string text = null;
				string text2 = null;
				if (瞢.IgAAAA_003D_003D() == 4)
				{
					text = "88044b52-bb1c-4d13-820b-fd46b551698e";
					text2 = "AgileDotNetRT";
				}
				else
				{
					text = "611373a0-d220-45b6-967b-7a25bc5c6ea9";
					text2 = "AgileDotNetRT64";
				}
				stream = assembly.GetManifestResourceStream(text);
				GZipStream input = new GZipStream(stream, CompressionMode.Decompress);
				BinaryReader binaryReader = new BinaryReader(input);
				byte[] array = 瞤.VAAAAA_003D_003D_0025(binaryReader, 瞣.VQAAAA_003D_003D_0025(binaryReader));
				string text3 = 瞥.NAAAAA_003D_003D("{0}{1}\\", 睽.OQAAAA_003D_003D(), text);
				瞦.LQAAAA_003D_003D(text3);
				string text4 = 瞂.LwAAAA_003D_003D(text3, text2, ".dll");
				if (!瞃.PwAAAA_003D_003D(text4))
				{
					FileStream fileStream = 瞧.QgAAAA_003D_003D(text4);
					瞨.WAAAAA_003D_003D_0025(fileStream, array, 0, array.Length);
					瞩.WQAAAA_003D_003D_0025(fileStream);
					FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(new SecurityIdentifier("S-1-1-0"), FileSystemRights.ReadAndExecute, AccessControlType.Allow);
					FileSecurity fileSecurity = 瞪.QwAAAA_003D_003D(text4);
					瞫.XgAAAA_003D_003D_0025(fileSecurity, fileSystemAccessRule);
					瞬.RAAAAA_003D_003D(text4, fileSecurity);
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
			瞜.UwAAAA_003D_003D(type);
		}
	}

	internal static int InitializeThroughDelegate(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize");
		InitializeDelegate initializeDelegate = (InitializeDelegate)瞭.YAAAAA_003D_003D(procAddress, 睸.IwAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static int InitializeThroughDelegate64(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize64");
		InitializeDelegate initializeDelegate = (InitializeDelegate)瞭.YAAAAA_003D_003D(procAddress, 睸.IwAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static void ExitThroughDelegate()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit");
		ExitDelegate exitDelegate = (ExitDelegate)瞭.YAAAAA_003D_003D(procAddress, 睸.IwAAAA_003D_003D(typeof(ExitDelegate).TypeHandle));
		exitDelegate();
	}

	internal static void ExitThroughDelegate64()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit64");
		ExitDelegate exitDelegate = (ExitDelegate)瞭.YAAAAA_003D_003D(procAddress, 睸.IwAAAA_003D_003D(typeof(ExitDelegate).TypeHandle));
		exitDelegate();
	}

	internal static void DomainUnload(object P_0, EventArgs P_1)
	{
		if (瞢.IgAAAA_003D_003D() == 4)
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
			RuntimeMethodHandle runtimeMethodHandle = 瞰.ZwAAAA_003D_003D_0025(瞯.ZgAAAA_003D_003D_0025(瞮.ZQAAAA_003D_003D_0025(new StackTrace(), 0)));
			if (((瞢.IgAAAA_003D_003D() != 4) ? InitializeThroughDelegate64(runtimeMethodHandle.Value) : InitializeThroughDelegate(runtimeMethodHandle.Value)) == 1)
			{
				瞲.YgAAAA_003D_003D_0025(瞱.YQAAAA_003D_003D(), DomainUnload);
			}
			inited = true;
		}
	}

	internal static void PostInitialize()
	{
	}
}
