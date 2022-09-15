using System;
using System.IO;
using System.Text;

internal class Streams_Operand
{
	public static byte[] getBuffer(string path)
	{
		try
		{
			string text = path + ".bak";
			if (is_acess(path))
			{
				try
				{
					byte[] bytes = File.ReadAllBytes(path);
					return Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(bytes));
				}
				catch
				{
					if (File.Exists(text))
					{
						File.Delete(text);
					}
					File.Copy(path, text, overwrite: true);
					byte[] array;
					using (FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read))
					{
						array = new byte[fileStream.Length];
						fileStream.Read(array, 0, (int)fileStream.Length);
					}
					File.Delete(text);
					return array;
				}
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Copy(path, text, overwrite: true);
			byte[] array2;
			using (FileStream fileStream2 = new FileStream(text, FileMode.Open, FileAccess.Read))
			{
				array2 = new byte[fileStream2.Length];
				fileStream2.Read(array2, 0, (int)fileStream2.Length);
			}
			File.Delete(text);
			return array2;
		}
		catch
		{
			return new byte[0];
		}
	}

	private static bool is_acess(string path)
	{
		try
		{
			File.GetAccessControl(path);
			return true;
		}
		catch (UnauthorizedAccessException)
		{
			return false;
		}
	}
}
