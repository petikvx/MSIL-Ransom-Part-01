using System.Text;

public class ChangeMethods
{
	public static string Lock(string Data, string key)
	{
		return Encoding.Default.GetString(Lock(Encoding.Default.GetBytes(Data), Encoding.Default.GetBytes(key)));
	}

	public static byte[] Lock(byte[] Data, byte[] key)
	{
		int num = checked(Data.Length * 2 + key.Length);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			Data[i % Data.Length] = (byte)(checked((byte)unchecked(checked(unchecked((int)Data[i % Data.Length]) + unchecked((int)Data[checked(i + 1) % Data.Length])) % 256)) ^ key[i % key.Length]);
		}
		return Data;
	}

	public static string DeLock(string Data, string key)
	{
		return Encoding.Default.GetString(DeLock(Encoding.Default.GetBytes(Data), Encoding.Default.GetBytes(key)));
	}

	public static byte[] DeLock(byte[] Data, byte[] key)
	{
		checked
		{
			for (int i = Data.Length * 2 + key.Length; i >= 0; i += -1)
			{
				Data[unchecked(i % Data.Length)] = (byte)unchecked(checked(unchecked(Data[i % Data.Length] ^ key[i % key.Length]) - unchecked((int)Data[checked(i + 1) % Data.Length]) + 256) % 256);
			}
			return Data;
		}
	}
}
