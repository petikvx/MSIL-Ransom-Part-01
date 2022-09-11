using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;

[SecuritySafeCritical]
internal class _003CAgileDotNetRT_003E
{
	private static bool inited;

	private static Assembly runtimeAssembly;

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
		瞱.mAAAAA_003D_003D(type = 瞢.iQAAAA_003D_003D(typeof(_003CAgileDotNetRT_003E).TypeHandle));
		try
		{
			WindowsImpersonationContext val = default(WindowsImpersonationContext);
			try
			{
				val = WindowsIdentity.Impersonate(IntPtr.Zero);
				Assembly assembly = 瞊.CQAAAA_003D_003D();
				Stream stream = null;
				string text = null;
				string text2 = null;
				if (瞵.sgAAAA_003D_003D() == 4)
				{
					text = "bbb15c29-dcc7-4992-b8a4-636eb5b33b63";
					text2 = "AgileDotNetRT";
				}
				else
				{
					text = "996ef38d-a8d9-4758-862d-2c02910c2de4";
					text2 = "AgileDotNetRT64";
				}
				stream = assembly.GetManifestResourceStream(text);
				GZipStream input = new GZipStream(stream, CompressionMode.Decompress);
				BinaryReader binaryReader = new BinaryReader(input);
				byte[] array = 瞽.rAAAAA_003D_003D_0025(binaryReader, 瞔.rQAAAA_003D_003D_0025(binaryReader));
				string text3 = 睻.MwAAAA_003D_003D("{0}{1}\\", 瞶.VAAAAA_003D_003D(), text);
				瞡.WQAAAA_003D_003D(text3);
				string text4 = 矅.SQAAAA_003D_003D(text3, text2, ".dll");
				if (!瞌.agAAAA_003D_003D(text4))
				{
					FileStream fileStream = 瞤.cAAAAA_003D_003D(text4);
					瞚.BQAAAA_003D_003D_0025(fileStream, array, 0, array.Length);
					睷.BwAAAA_003D_003D_0025(fileStream);
					FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(new SecurityIdentifier("S-1-1-0"), FileSystemRights.ReadAndExecute, AccessControlType.Allow);
					FileSecurity fileSecurity = 矆.cwAAAA_003D_003D(text4);
					矇.tQAAAA_003D_003D_0025(fileSecurity, fileSystemAccessRule);
					矈.dAAAAA_003D_003D(text4, fileSecurity);
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
			瞱.lwAAAA_003D_003D(type);
		}
	}

	internal static int InitializeThroughDelegate(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize");
		InitializeDelegate initializeDelegate = (InitializeDelegate)矉.twAAAA_003D_003D(procAddress, 瞢.iQAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static int InitializeThroughDelegate64(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize64");
		InitializeDelegate initializeDelegate = (InitializeDelegate)矉.twAAAA_003D_003D(procAddress, 瞢.iQAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static void DomainUnload(object P_0, EventArgs P_1)
	{
		if (瞵.sgAAAA_003D_003D() == 4)
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
			if (((瞵.sgAAAA_003D_003D() != 4) ? InitializeThroughDelegate64((IntPtr)4) : InitializeThroughDelegate((IntPtr)4)) == 1)
			{
				矊.TQAAAA_003D_003D_0025(瞂.SgAAAA_003D_003D(), DomainUnload);
			}
			inited = true;
		}
	}

	internal static void PostInitialize()
	{
	}
}
