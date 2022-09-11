using System.IO;
using System.Net.Sockets;

namespace VanillaStub.Helpers.Telepathy;

public static class NetworkStreamExtensions
{
	public static int ReadSafely(this NetworkStream stream, byte[] buffer, int offset, int size)
	{
		try
		{
			return stream.Read(buffer, offset, size);
		}
		catch (IOException)
		{
			return 0;
		}
	}

	public static bool ReadExactly(this NetworkStream stream, byte[] buffer, int amount)
	{
		int num = 0;
		while (true)
		{
			if (num < amount)
			{
				int size = amount - num;
				int num2 = stream.ReadSafely(buffer, num, size);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				continue;
			}
			return true;
		}
		return false;
	}
}
