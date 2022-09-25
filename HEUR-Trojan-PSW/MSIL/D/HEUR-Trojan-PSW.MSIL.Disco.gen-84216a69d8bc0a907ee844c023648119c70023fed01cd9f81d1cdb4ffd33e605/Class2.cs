using System;
using System.IO;

internal class Class2
{
	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public Class2(string string_3, int int_1)
	{
		string_0 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		string_1 = Class11.smethod_0("\ueda3\ued93\ued90\ued98\ued8c\uedd1\ued8b\ued87\ued8b", 60926);
		string_2 = string_3;
		int_0 = int_1;
	}

	private void method_0(string string_3, string string_4)
	{
		if (int_0 == 1)
		{
			using (StreamWriter streamWriter = File.AppendText(string_0 + string_1))
			{
				string text = string.Format(Class11.smethod_0("\uee86\ueecd\uee80\ueedd\uee86\ueecc\uee80\ueedd\ueed0\ueedd", 60988), DateTime.Now.ToString(Class11.smethod_0("\uf8a5\uf896\uf896\uf8c4\uf893\uf893\uf8c4\uf88d\uf88d\uf8a3", 63606)), string_3);
				streamWriter.Write(text + string_4);
				streamWriter.Write(Class11.smethod_0("\ue36f", 58117));
				return;
			}
		}
		if (int_0 == 0)
		{
			string text2 = string.Format(Class11.smethod_0("\uee86\ueecd\uee80\ueedd\uee86\ueecc\uee80\ueedd\ueed0\ueedd", 60988), DateTime.Now.ToString(Class11.smethod_0("\uf8a5\uf896\uf896\uf8c4\uf893\uf893\uf8c4\uf88d\uf88d\uf8a3", 63606)), string_3);
			Console.Write(text2 + string_4);
			Console.Write(Class11.smethod_0("\ue36f", 58117));
			return;
		}
		using (StreamWriter streamWriter2 = File.AppendText(string_0 + string_1))
		{
			string text3 = string.Format(Class11.smethod_0("\uee86\ueecd\uee80\ueedd\uee86\ueecc\uee80\ueedd\ueed0\ueedd", 60988), DateTime.Now.ToString(Class11.smethod_0("\uf8a5\uf896\uf896\uf8c4\uf893\uf893\uf8c4\uf88d\uf88d\uf8a3", 63606)), string_3);
			streamWriter2.Write(text3 + string_4);
			streamWriter2.Write(Class11.smethod_0("\ue36f", 58117));
		}
		string text4 = string.Format(Class11.smethod_0("\uee86\ueecd\uee80\ueedd\uee86\ueecc\uee80\ueedd\ueed0\ueedd", 60988), DateTime.Now.ToString(Class11.smethod_0("\uf8a5\uf896\uf896\uf8c4\uf893\uf893\uf8c4\uf88d\uf88d\uf8a3", 63606)), string_3);
		Console.Write(text4 + string_4);
		Console.Write(Class11.smethod_0("\ue36f", 58117));
	}

	public void method_1(string string_3)
	{
		if (string_2 == Class11.smethod_0("\uef99\uef98\uef9f\uef88\uef9a", 61340))
		{
			method_0(Class11.smethod_0("\uef99\uef98\uef9f\uef88\uef9a", 61340), string_3);
		}
	}

	public void method_2(string string_3)
	{
		if (string_2 == Class11.smethod_0("\uef99\uef98\uef9f\uef88\uef9a", 61340))
		{
			method_0(Class11.smethod_0("\ue556\ue551\ue559\ue550", 58639), string_3);
		}
		else if (string_2 == Class11.smethod_0("\ue556\ue551\ue559\ue550", 58639))
		{
			method_0(Class11.smethod_0("\ue556\ue551\ue559\ue550", 58639), string_3);
		}
	}

	public void method_3(string string_3)
	{
		if (string_2 != Class11.smethod_0("\uecb6\ueca1\ueca1\uecbc\ueca1", 60609))
		{
			method_0(Class11.smethod_0("\ued1c\ued0a\ued19\ued05\ued02\ued05\ued0c", 60682), string_3);
		}
	}

	public void method_4(string string_3)
	{
		method_0(Class11.smethod_0("\uecb6\ueca1\ueca1\uecbc\ueca1", 60609), string_3);
	}
}
