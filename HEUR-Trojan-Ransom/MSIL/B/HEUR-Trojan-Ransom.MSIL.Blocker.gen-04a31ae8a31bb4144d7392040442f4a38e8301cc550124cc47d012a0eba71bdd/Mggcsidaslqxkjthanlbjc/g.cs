using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Mggcsidaslqxkjthanlbjc;

public sealed class g : Form
{
	private IContainer m_a;

	public g()
	{
		a();
	}

	public byte[] a(byte[] a)
	{
		if (a == null)
		{
			return null;
		}
		MemoryStream memoryStream = new MemoryStream(a);
		try
		{
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				BufferedStream bufferedStream = new BufferedStream(new GZipStream(memoryStream, CompressionMode.Decompress));
				try
				{
					bufferedStream.CopyTo(memoryStream2);
				}
				finally
				{
					((IDisposable)bufferedStream).Dispose();
				}
				return memoryStream2.ToArray();
			}
			finally
			{
				((IDisposable)memoryStream2).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	protected override void Dispose(bool a)
	{
		if (a && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		((Form)this).Dispose(a);
	}

	private void a()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(613, 260));
		((Control)this).set_Name("Form3");
		((Control)this).set_Text("Form3");
		((Control)this).ResumeLayout(false);
	}
}
