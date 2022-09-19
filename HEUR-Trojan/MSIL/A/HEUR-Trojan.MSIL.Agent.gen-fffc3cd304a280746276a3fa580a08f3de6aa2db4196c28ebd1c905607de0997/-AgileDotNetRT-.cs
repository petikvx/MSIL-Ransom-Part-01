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
	private static byte[] e;

	private static Hashtable sc;

	private static bool inited;

	private static Assembly runtimeAssembly;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _003CAgileDotNetRT_003E()
	{
		sc = new Hashtable();
		e = new byte[102]
		{
			162, 216, 114, 203, 156, 242, 46, 164, 209, 222,
			120, 177, 182, 177, 82, 129, 110, 207, 81, 57,
			49, 2, 252, 34, 189, 20, 190, 253, 218, 231,
			246, 66, 163, 2, 207, 202, 170, 65, 195, 25,
			88, 188, 33, 5, 46, 11, 241, 151, 251, 98,
			31, 194, 22, 79, 237, 159, 218, 80, 14, 136,
			52, 48, 200, 233, 231, 54, 14, 179, 225, 134,
			213, 44, 12, 55, 224, 115, 224, 246, 242, 177,
			33, 38, 1, 119, 200, 51, 43, 84, 20, 47,
			238, 90, 51, 59, 228, 40, 243, 55, 29, 247,
			252, 61
		};
	}

	internal static string a(string P_0)
	{
		lock (sc)
		{
			if (sc.ContainsKey(P_0))
			{
				return (string)sc[P_0];
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < P_0.Length; i++)
			{
				stringBuilder.Append(Convert.ToChar(P_0[i] ^ e[i % e.Length]));
			}
			sc[P_0] = stringBuilder.ToString();
			return stringBuilder.ToString();
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
		lock (typeof(_003CAgileDotNetRT_003E))
		{
			WindowsImpersonationContext val = default(WindowsImpersonationContext);
			try
			{
				val = WindowsIdentity.Impersonate(IntPtr.Zero);
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream stream = null;
				string text = null;
				string text2 = null;
				if (IntPtr.Size == 4)
				{
					text = "d8d9113a-8137-4ea3-b46b-ba3fd2872645";
					text2 = "AgileDotNetRT";
				}
				else
				{
					text = "42bdbff4-2e20-4168-9b00-6137d5d5603f";
					text2 = "AgileDotNetRT64";
				}
				stream = executingAssembly.GetManifestResourceStream(text);
				GZipStream input = new GZipStream(stream, CompressionMode.Decompress);
				BinaryReader binaryReader = new BinaryReader(input);
				byte[] array = binaryReader.ReadBytes(binaryReader.ReadInt32());
				string text3 = $"{Path.GetTempPath()}{text}\\";
				Directory.CreateDirectory(text3);
				string text4 = text3 + text2 + ".dll";
				if (!File.Exists(text4))
				{
					FileStream fileStream = File.OpenWrite(text4);
					fileStream.Write(array, 0, array.Length);
					fileStream.Close();
					FileSystemAccessRule rule = new FileSystemAccessRule(new SecurityIdentifier("S-1-1-0"), FileSystemRights.ReadAndExecute, AccessControlType.Allow);
					FileSecurity accessControl = File.GetAccessControl(text4);
					accessControl.AddAccessRule(rule);
					File.SetAccessControl(text4, accessControl);
				}
				return LoadLibraryA(text4);
			}
			finally
			{
				val.Undo();
			}
		}
	}

	internal static int InitializeThroughDelegate(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize");
		InitializeDelegate initializeDelegate = (InitializeDelegate)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(InitializeDelegate));
		return initializeDelegate(P_0);
	}

	internal static int InitializeThroughDelegate64(IntPtr P_0)
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_Initialize64");
		InitializeDelegate initializeDelegate = (InitializeDelegate)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(InitializeDelegate));
		return initializeDelegate(P_0);
	}

	internal static void ExitThroughDelegate()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit");
		ExitDelegate exitDelegate = (ExitDelegate)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(ExitDelegate));
		exitDelegate();
	}

	internal static void ExitThroughDelegate64()
	{
		IntPtr intPtr = Load();
		IntPtr procAddress = GetProcAddress(intPtr, "_AtExit64");
		ExitDelegate exitDelegate = (ExitDelegate)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(ExitDelegate));
		exitDelegate();
	}

	internal static void DomainUnload(object P_0, EventArgs P_1)
	{
		if (IntPtr.Size == 4)
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
			RuntimeMethodHandle methodHandle = new StackTrace().GetFrame(0)!.GetMethod()!.MethodHandle;
			if (((IntPtr.Size != 4) ? InitializeThroughDelegate64(methodHandle.Value) : InitializeThroughDelegate(methodHandle.Value)) == 1)
			{
				AppDomain.CurrentDomain.DomainUnload += DomainUnload;
			}
			inited = true;
		}
	}

	internal static void PostInitialize()
	{
	}
}
