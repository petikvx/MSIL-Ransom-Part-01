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
	private static byte[] _0020;

	private static Hashtable sc;

	private static bool inited;

	private static Assembly runtimeAssembly;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _003CAgileDotNetRT_003E()
	{
		sc = new Hashtable();
		_0020 = new byte[110]
		{
			47, 229, 150, 57, 194, 228, 16, 65, 213, 226,
			105, 238, 127, 176, 130, 211, 19, 188, 178, 130,
			242, 253, 13, 97, 33, 186, 250, 60, 72, 250,
			34, 56, 245, 115, 33, 39, 147, 80, 81, 39,
			21, 65, 205, 42, 156, 247, 246, 205, 140, 86,
			170, 14, 68, 140, 145, 48, 216, 52, 23, 8,
			233, 211, 247, 217, 191, 49, 248, 11, 142, 90,
			63, 194, 107, 138, 109, 176, 48, 225, 195, 41,
			194, 44, 174, 241, 80, 19, 242, 105, 225, 239,
			78, 94, 56, 72, 61, 64, 73, 242, 105, 107,
			254, 235, 63, 49, 22, 231, 162, 185, 31, 223
		};
	}

	internal static string _200B(string P_0)
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
				stringBuilder.Append(Convert.ToChar(P_0[i] ^ _0020[i % _0020.Length]));
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
					text = "2b14b4cf-8dfe-4203-ba52-0b61fac7b018";
					text2 = "AgileDotNetRT";
				}
				else
				{
					text = "b48025b5-2c69-4bf7-85dc-865bffc6d74f";
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
