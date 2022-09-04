using System.Reflection;
using System.Resources;

internal class Reader
{
	public static byte[] ReadManaged()
	{
		ResourceManager resourceManager = new ResourceManager("Encrypted", Assembly.GetExecutingAssembly());
		return (byte[])resourceManager.GetObject("encfile");
	}

	public static byte[] ReadManaged2()
	{
		ResourceManager resourceManager = new ResourceManager("Encrypted", Assembly.GetExecutingAssembly());
		return (byte[])resourceManager.GetObject("encrp");
	}
}
