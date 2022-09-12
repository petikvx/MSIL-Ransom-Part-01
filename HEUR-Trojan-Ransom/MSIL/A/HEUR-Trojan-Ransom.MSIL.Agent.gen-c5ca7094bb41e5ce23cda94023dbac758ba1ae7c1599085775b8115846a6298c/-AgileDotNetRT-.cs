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
		矚.PgAAAA_003D_003D(type = 矙.FAAAAA_003D_003D(typeof(_003CAgileDotNetRT_003E).TypeHandle));
		try
		{
			WindowsImpersonationContext val = default(WindowsImpersonationContext);
			try
			{
				val = WindowsIdentity.Impersonate(IntPtr.Zero);
				Assembly assembly = 矛.KwAAAA_003D_003D();
				Stream stream = null;
				string text = null;
				string text2 = null;
				if (矜.PQAAAA_003D_003D() == 4)
				{
					text = "2473fbde-0c24-41a0-bb03-4ffbd69e78c6";
					text2 = "AgileDotNetRT";
				}
				else
				{
					text = "0610153b-8644-447d-96e4-a1daf0339f2c";
					text2 = "AgileDotNetRT64";
				}
				stream = assembly.GetManifestResourceStream(text);
				GZipStream input = new GZipStream(stream, CompressionMode.Decompress);
				BinaryReader binaryReader = new BinaryReader(input);
				byte[] array = 矞.NwAAAA_003D_003D_0025(binaryReader, 矝.OAAAAA_003D_003D_0025(binaryReader));
				string text3 = 矠.IQAAAA_003D_003D("{0}{1}\\", 矟.HAAAAA_003D_003D(), text);
				矡.QAAAAA_003D_003D(text3);
				string text4 = 矢.IwAAAA_003D_003D(text3, text2, ".dll");
				if (!矣.QQAAAA_003D_003D(text4))
				{
					FileStream fileStream = 矤.QgAAAA_003D_003D(text4);
					知.JgAAAA_003D_003D_0025(fileStream, array, 0, array.Length);
					矐.JwAAAA_003D_003D_0025(fileStream);
					FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(new SecurityIdentifier("S-1-1-0"), FileSystemRights.ReadAndExecute, AccessControlType.Allow);
					FileSecurity fileSecurity = 矦.QwAAAA_003D_003D(text4);
					矧.RwAAAA_003D_003D_0025(fileSecurity, fileSystemAccessRule);
					矨.RAAAAA_003D_003D(text4, fileSecurity);
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
			矚.PwAAAA_003D_003D(type);
		}
	}

	internal static int InitializeThroughDelegate(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize");
		InitializeDelegate initializeDelegate = (InitializeDelegate)矩.SQAAAA_003D_003D(procAddress, 矙.FAAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static int InitializeThroughDelegate64(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize64");
		InitializeDelegate initializeDelegate = (InitializeDelegate)矩.SQAAAA_003D_003D(procAddress, 矙.FAAAAA_003D_003D(typeof(InitializeDelegate).TypeHandle));
		return initializeDelegate(P_0);
	}

	internal static void DomainUnload(object P_0, EventArgs P_1)
	{
		if (矜.PQAAAA_003D_003D() == 4)
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
			if (((矜.PQAAAA_003D_003D() != 4) ? InitializeThroughDelegate64((IntPtr)4) : InitializeThroughDelegate((IntPtr)4)) == 1)
			{
				矪.GQAAAA_003D_003D_0025(矊.FgAAAA_003D_003D(), DomainUnload);
			}
			inited = true;
		}
	}

	internal static void PostInitialize()
	{
	}
}
