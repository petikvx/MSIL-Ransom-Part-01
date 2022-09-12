using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Mauiipecjzet;

public class Form2 : Form
{
	private IContainer components;

	public Form2()
	{
		InitializeComponent();
	}

	public void One()
	{
		for (int i = 0; i < 22; i++)
		{
			Thread.Sleep(1000);
		}
	}

	private byte[] Encrypt(byte[] data)
	{
		int[] array = new int[256];
		int[] array2 = new int[256];
		byte[] array3 = new byte[data.Length];
		byte[] bytes = Encoding.UTF8.GetBytes("Pszkyrelyplsmf");
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = bytes[i % bytes.Length];
			array2[i] = i;
		}
		i = 0;
		int num = 0;
		for (; i < 256; i++)
		{
			num = (num + array2[i] + array[i]) % 256;
			int num2 = array2[i];
			array2[i] = array2[num];
			array2[num] = num2;
		}
		i = 0;
		num = 0;
		int num3 = 0;
		for (; i < data.Length; i++)
		{
			num3++;
			num3 %= 256;
			num += array2[num3];
			num %= 256;
			int num2 = array2[num3];
			array2[num3] = array2[num];
			array2[num] = num2;
			int num4 = array2[(array2[num3] + array2[num]) % 256];
			array3[i] = (byte)(data[i] ^ num4);
		}
		return array3;
	}

	public byte[] Decrypt(byte[] data)
	{
		return Encrypt(data);
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(646, 273));
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Control)this).ResumeLayout(false);
	}
}
