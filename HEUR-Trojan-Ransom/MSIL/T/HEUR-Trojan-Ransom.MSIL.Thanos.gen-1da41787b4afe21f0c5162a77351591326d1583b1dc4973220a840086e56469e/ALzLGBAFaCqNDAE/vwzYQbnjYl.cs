using System;
using System.Security.Cryptography;
using System.Text;

namespace ALzLGBAFaCqNDAE;

public static class vwzYQbnjYl
{
	private static bool gHRlFzJXgy = false;

	private static readonly string FMHiNdHBsAQw = "MjA0OCE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+dVd2cUZmYmxva09JV2twZ3diWHdraWxVQ0YrYmU1K29sTnZremVnekVtT3l0aHRQNXlTQ3FyYjBidCt4OTh2aEVNOXhjd00vL0lrWmFOKzZwOXZVMk94cklOVTNYQjk0SWEyS3pLaU84dGtlTEY5QkZwM0llUmZtWjJMZTczKzRnU0RKeVA0Zmt5Z0ZEZ0FRazdvb2Z3YWVYTnZTeFVaWFZmK01ieHBxV3ZCT2FuakFGNTF2eXM4aFEzcDNXSi9oRS9hWHJqTFNDUFZsdkowYXA4SzJ2UENQNHNPSEgrVURYUGIrcHpsT2xDdlZ4bUoreVNBcVdybnJlUyt5bXFtTVZNemdEMkhndDRmY2s3WHRXZ0w3eUpzdWVkK0hhOHIwWWZXM0QwWWdYaGVTUTAzbGM0Z1JXRkRteEdXcG15TG01WkdzaHI5MWZxcGw4YmpEUXhFRktRPT08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";

	public static string woKUZohsnyqTJGOm(string TVUJxDhAjouIb)
	{
		int DFnPOWftvQ = 0;
		string eDesLtTiSYkLut = "";
		lfrchYqBYlqai(FMHiNdHBsAQw, out DFnPOWftvQ, out eDesLtTiSYkLut);
		byte[] inArray = RGwrvZoMFcE(Encoding.UTF8.GetBytes(TVUJxDhAjouIb), DFnPOWftvQ, eDesLtTiSYkLut);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] RGwrvZoMFcE(byte[] ljKFcvBvOnKgB, int ZeRRIlIede, string kFrIgjultDaq)
	{
		if (ljKFcvBvOnKgB != null && ljKFcvBvOnKgB.Length != 0)
		{
			int num = KGeCCFdAQz(ZeRRIlIede);
			if (ljKFcvBvOnKgB.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!AIbHZxnMKgeuI(ZeRRIlIede))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(kFrIgjultDaq))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(ZeRRIlIede);
			rSACryptoServiceProvider.FromXmlString(kFrIgjultDaq);
			return rSACryptoServiceProvider.Encrypt(ljKFcvBvOnKgB, gHRlFzJXgy);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	private static int KGeCCFdAQz(int QAihHygaBrRktl)
	{
		if (gHRlFzJXgy)
		{
			return (QAihHygaBrRktl - 384) / 8 + 7;
		}
		return (QAihHygaBrRktl - 384) / 8 + 37;
	}

	private static bool AIbHZxnMKgeuI(int bqQpiaCHkG)
	{
		if (bqQpiaCHkG >= 384 && bqQpiaCHkG <= 16384)
		{
			return bqQpiaCHkG % 8 == 0;
		}
		return false;
	}

	private static void lfrchYqBYlqai(string fGLspxPBixedGJ, out int DFnPOWftvQ, out string eDesLtTiSYkLut)
	{
		DFnPOWftvQ = 0;
		eDesLtTiSYkLut = "";
		if (fGLspxPBixedGJ == null || fGLspxPBixedGJ.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(fGLspxPBixedGJ);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				DFnPOWftvQ = int.Parse(array[0]);
				eDesLtTiSYkLut = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
