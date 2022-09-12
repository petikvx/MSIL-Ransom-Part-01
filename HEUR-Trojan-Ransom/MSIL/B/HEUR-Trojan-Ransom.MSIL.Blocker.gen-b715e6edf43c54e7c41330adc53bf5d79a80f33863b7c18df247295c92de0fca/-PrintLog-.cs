using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;

[SecuritySafeCritical]
internal class _003CPrintLog_003E
{
	private static bool inited;

	private static Assembly runtimeAssembly;

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.ForwardRef)]
	private static extern IntPtr LoadLibraryA(string P_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.ForwardRef)]
	private static extern IntPtr GetProcAddress(IntPtr P_0, string P_1);

	[DllImport("PrintLog.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.ForwardRef)]
	private static extern int _Initialize(IntPtr P_0);

	[DllImport("PrintLog.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.ForwardRef)]
	private static extern int _Initialize64(IntPtr P_0);

	[DllImport("PrintLog.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.ForwardRef)]
	private static extern void _AtExit();

	[DllImport("PrintLog.dll", CharSet = CharSet.Ansi, EntryPoint = "_AtExit", ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.ForwardRef)]
	private static extern void _AtExit64();

	internal static IntPtr Load()
	{
		Type type;
		瞼.swAAAA_003D_003D(type = 睿.VgAAAA_003D_003D(typeof(_003CPrintLog_003E).TypeHandle));
		try
		{
			WindowsImpersonationContext val = default(WindowsImpersonationContext);
			try
			{
				val = WindowsIdentity.Impersonate(IntPtr.Zero);
				Assembly assembly = 瞁.LAAAAA_003D_003D();
				Stream stream = null;
				string text = null;
				string text2 = null;
				if (矓.RAAAAA_003D_003D() == 4)
				{
					text = "3649c632-0ef0-47b1-8e37-c7b2dd1dad1c";
					text2 = "PrintLog";
				}
				else
				{
					text = "6b6cd90f-de66-49c2-b567-b5d53478d2a9";
					text2 = "PrintLog";
				}
				stream = assembly.GetManifestResourceStream(text);
				GZipStream input = new GZipStream(stream, CompressionMode.Decompress);
				BinaryReader binaryReader = new BinaryReader(input);
				byte[] array = 瞉.pgAAAA_003D_003D_0025(binaryReader, 瞫.qQAAAA_003D_003D_0025(binaryReader));
				string text3 = 矔.DwAAAA_003D_003D("{0}{1}\\", 瞃.gwAAAA_003D_003D(), text);
				矕.xwAAAA_003D_003D(text3);
				string text4 = 矊.DgAAAA_003D_003D(text3, text2, ".dll");
				if (!矆.fgAAAA_003D_003D(text4))
				{
					FileStream fileStream = 矖.fwAAAA_003D_003D(text4);
					矎.IQAAAA_003D_003D_0025(fileStream, array, 0, array.Length);
					瞅.HgAAAA_003D_003D_0025(fileStream);
					FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(new SecurityIdentifier("S-1-1-0"), FileSystemRights.ReadAndExecute, AccessControlType.Allow);
					FileSecurity fileSecurity = 矗.gAAAAA_003D_003D(text4);
					矘.ygAAAA_003D_003D_0025(fileSecurity, fileSystemAccessRule);
					矙.gQAAAA_003D_003D(text4, fileSecurity);
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
			瞼.sgAAAA_003D_003D(type);
		}
	}

	internal static int InitializeThroughDelegate(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize");
		InitializeDelegate initializeDelegate = (InitializeDelegate)矉.SgAAAA_003D_003D(procAddress, 睿.VgAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static int InitializeThroughDelegate64(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize64");
		InitializeDelegate initializeDelegate = (InitializeDelegate)矉.SgAAAA_003D_003D(procAddress, 睿.VgAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static void ExitThroughDelegate()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit");
		ExitDelegate exitDelegate = (ExitDelegate)矉.SgAAAA_003D_003D(procAddress, 睿.VgAAAA_003D_003D(typeof(ExitDelegate).TypeHandle));
		exitDelegate();
	}

	internal static void ExitThroughDelegate64()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit64");
		ExitDelegate exitDelegate = (ExitDelegate)矉.SgAAAA_003D_003D(procAddress, 睿.VgAAAA_003D_003D(typeof(ExitDelegate).TypeHandle));
		exitDelegate();
	}

	internal static void DomainUnload(object P_0, EventArgs P_1)
	{
		if (矓.RAAAAA_003D_003D() == 4)
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
			RuntimeMethodHandle runtimeMethodHandle = 矜.lAAAAA_003D_003D_0025(矛._0AAAAA_003D_003D_0025(矚.zwAAAA_003D_003D_0025(new StackTrace(), 0)));
			if (((矓.RAAAAA_003D_003D() != 4) ? InitializeThroughDelegate64(runtimeMethodHandle.Value) : InitializeThroughDelegate(runtimeMethodHandle.Value)) == 1)
			{
				矝.iAAAAA_003D_003D_0025(瞣.hgAAAA_003D_003D(), DomainUnload);
			}
			inited = true;
		}
	}

	internal static void PostInitialize()
	{
	}
}
