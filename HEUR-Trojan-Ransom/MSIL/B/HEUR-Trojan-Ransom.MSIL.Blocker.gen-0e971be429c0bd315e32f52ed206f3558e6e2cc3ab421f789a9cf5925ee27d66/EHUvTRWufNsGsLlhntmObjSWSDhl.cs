using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using chicken.src.Util;

internal class EHUvTRWufNsGsLlhntmObjSWSDhl
{
	private static uint eAwwnMRNBOUmSZnFwWpBjBpuJcdO = (uint)IPAddress.NetworkToHostOrder(BitConverter.ToInt32(IPAddress.Parse("127.0.0.1").GetAddressBytes(), 0));

	private static byte[] LLIeAEJbqrTXwXhEaKzDLmfBIbIe = new byte[2] { 117, 59 };

	public static bool VfSyUAiLYZSHeCCwnXZySxEYQjKs(string clientDirectory, string bin, ushort port, IPAddress serverIp)
	{
		string text = Path.Combine(clientDirectory, bin);
		uint num = ((serverIp != null) ? ((uint)IPAddress.NetworkToHostOrder(BitConverter.ToInt32(serverIp.GetAddressBytes(), 0))) : eAwwnMRNBOUmSZnFwWpBjBpuJcdO);
		Win32Api.Startupinfo lpStartupInfo = default(Win32Api.Startupinfo);
		Win32Api.ProcessInformation lpProcessInformation = default(Win32Api.ProcessInformation);
		Win32Api.CreateProcess(text, $"\"{text.Trim()}\" {num} {port}", IntPtr.Zero, IntPtr.Zero, bInheritHandles: false, Win32Api.ProcessCreationFlags.CreateDefaultErrorMode | Win32Api.ProcessCreationFlags.CreateSuspended, IntPtr.Zero, null, ref lpStartupInfo, out lpProcessInformation);
		IntPtr hThread = lpProcessInformation.HThread;
		byte[] array = new byte[2];
		Thread.Sleep(500);
		Win32Api.ResumeThread(hThread);
		for (int i = 0; i < 20; i++)
		{
			Win32Api.ReadProcessMemory(lpProcessInformation.HProcess, (IntPtr)4608136, array, (uint)array.Length, 0);
			if (!leyureCpxlakHzFtwgHJugDVJkbE(LLIeAEJbqrTXwXhEaKzDLmfBIbIe, array))
			{
				Thread.Sleep(100);
				continue;
			}
			Win32Api.WriteProcessMemory(lpProcessInformation.HProcess, (IntPtr)4608136, new byte[1] { 235 }, 1u, 0);
			Win32Api.WriteProcessMemory(lpProcessInformation.HProcess, (IntPtr)4613593, new byte[2] { 144, 233 }, 2u, 0);
			Win32Api.WriteProcessMemory(lpProcessInformation.HProcess, (IntPtr)5364122, new byte[2] { 144, 144 }, 2u, 0);
			Win32Api.WriteProcessMemory(lpProcessInformation.HProcess, (IntPtr)4602183, new byte[6] { 144, 144, 144, 144, 144, 144 }, 6u, 0);
			Win32Api.WriteProcessMemory(lpProcessInformation.HProcess, (IntPtr)4615674, new byte[1] { 235 }, 1u, 0);
			Win32Api.WriteProcessMemory(lpProcessInformation.HProcess, (IntPtr)5231430, new byte[10] { 144, 144, 144, 144, 144, 132, 192, 94, 91, 235 }, 10u, 0);
			break;
		}
		Win32Api.ResumeThread(hThread);
		Win32Api.CloseHandle(hThread);
		IntPtr intPtr = Win32Api.OpenProcess(1208u, 0, lpProcessInformation.DwProcessId);
		Win32Api.SuspendThread(intPtr);
		Process processById = Process.GetProcessById((int)lpProcessInformation.DwProcessId);
		_ = DateTime.Now - processById.StartTime;
		try
		{
			int j = 0;
			int num2;
			for (num2 = 600; j <= num2; j++)
			{
				if (!(processById.MainWindowTitle != "Lineage Windows Client"))
				{
					break;
				}
				Thread.Sleep(5);
				processById.Refresh();
			}
			if (j == num2)
			{
				return false;
			}
		}
		catch (Exception)
		{
			return false;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Templates);
		byte[] array2 = File.ReadAllBytes(Path.Combine(folderPath + "\\List.pak"));
		uint num3 = (uint)array2.Length;
		IntPtr intPtr2 = Win32Api.VirtualAllocEx(intPtr, IntPtr.Zero, num3, 4096u, 4u);
		long lpBuffer = (long)intPtr2;
		string text2 = Convert.ToString(lpBuffer, 16);
		Win32Api.WriteProcessMemory(intPtr, intPtr2, array2, num3, 0);
		text2 = Convert.ToString(lpBuffer, 16);
		Console.WriteLine(string.Format("가상메모리할당주소 = [0] = [" + text2 + "]"));
		Win32Api.WriteProcessMemory(intPtr, 4961987, ref lpBuffer, 4, 0);
		Win32Api.WriteProcessMemory(intPtr, 4962003, ref lpBuffer, 4, 0);
		Win32Api.WriteProcessMemory(intPtr, 4962083, ref lpBuffer, 4, 0);
		Win32Api.WriteProcessMemory(intPtr, 4962123, ref lpBuffer, 4, 0);
		long lpBuffer2 = lpBuffer + 4L;
		text2 = Convert.ToString(lpBuffer2, 16);
		Console.WriteLine(string.Format("가상메모리할당주소 = [1] = [" + text2 + "]"));
		Win32Api.WriteProcessMemory(intPtr, 4962137, ref lpBuffer2, 4, 0);
		Win32Api.WriteProcessMemory(intPtr, 4962144, new byte[1] { 235 }, 1, 0);
		lpBuffer2 = lpBuffer + (num3 - 128 - 4);
		text2 = Convert.ToString(lpBuffer2, 16);
		Console.WriteLine(string.Format("가상메모리할당주소 = [2] = [" + text2 + "]"));
		Win32Api.WriteProcessMemory(intPtr, 4962023, ref lpBuffer2, 4, 0);
		lpBuffer2 = lpBuffer + (num3 - 4 - 4);
		text2 = Convert.ToString(lpBuffer2, 16);
		Console.WriteLine(string.Format("가상메모리할당주소 = [3] = [" + text2 + "]"));
		Win32Api.WriteProcessMemory(intPtr, 4962072, ref lpBuffer2, 4, 0);
		Win32Api.WriteProcessMemory(intPtr, 4962094, ref lpBuffer2, 4, 0);
		lpBuffer2 = lpBuffer + (num3 - 4);
		text2 = Convert.ToString(lpBuffer2, 16);
		Console.WriteLine(string.Format("가상메모리할당주소 = [4] = [" + text2 + "]"));
		Win32Api.WriteProcessMemory(intPtr, 4962227, ref lpBuffer2, 4, 0);
		long num4 = 0L;
		byte[] array3 = new byte[num3 - 128 - 4];
		long num5 = num3 - 128 - 4;
		long num6 = num5 / 32L;
		for (int k = 0; k < 128; k += 4)
		{
			long num7 = array3[0] & 0xFF;
			num7 |= 0L;
			num7 |= 0L;
			num7 |= 0L;
			if (k == 0)
			{
				num4 = num7;
			}
			lpBuffer2 = num7 - num4;
			lpBuffer2 = lpBuffer + 8L + lpBuffer2;
			lpBuffer2 += k / 4 * num6;
			Win32Api.WriteProcessMemory(intPtr, (int)(lpBuffer + (num3 - 128 - 4) + k), ref lpBuffer2, 4, 0);
			text2 = Convert.ToString(lpBuffer2, 16);
			string text3 = Convert.ToString((int)(lpBuffer + (num3 - 128 - 4) + k), 16);
			Console.Write(string.Format("가상메모리할당주소 = [" + text3 + "] = [" + text2 + "]\n"));
		}
		Console.Write(string.Format("리스트 용량 = [" + num5 + "]\n"));
		Console.Write(string.Format("리스트 용량사이즈 = [" + num6 + "]\n"));
		text2 = Convert.ToString(num3, 16);
		Console.WriteLine(string.Format("리스트 전체용량 = [1] = [" + num3 + "]\n"));
		Console.WriteLine(string.Format("List.pak주소 : [" + Path.Combine(folderPath + "\\List.pak") + "]"));
		Win32Api.ResumeThread(intPtr);
		Win32Api.CloseHandle(intPtr);
		intPtr = IntPtr.Zero;
		return true;
	}

	public static bool leyureCpxlakHzFtwgHJugDVJkbE(byte[] a1, byte[] a2)
	{
		if (a1.Length != a2.Length)
		{
			return false;
		}
		for (int i = 0; i < a1.Length; i++)
		{
			if (a1[i] != a2[i])
			{
				return false;
			}
		}
		return true;
	}
}
