using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using I00usori0y;

namespace B4mbsights;

public static class Typesettin3
{
	public static readonly int Pa1ama = 3;

	public static readonly FileShare Val5ating = FileShare.ReadWrite | FileShare.Delete;

	public static string Blockhead2(string string_0)
	{
		string path = $"{Guid.NewGuid()}.tmp".ToLowerInvariant();
		return Path.GetFullPath(Path.Combine(string_0, path));
	}

	public static async Task Pod3atr3es(string R55ngrav5d)
	{
		if (R55ngrav5d == null)
		{
			throw new ArgumentNullException("filePath");
		}
		await Forcemeat8.smethod_0(R55ngrav5d, delegate
		{
			Misc7ose(R55ngrav5d);
			return Task.FromResult(0);
		}, CancellationToken.None);
	}

	public static async Task No6allergic(Action<string> Droo4ily, string Pro3oking)
	{
		if (Droo4ily == null)
		{
			throw new ArgumentNullException("writeSourceFile");
		}
		if (Pro3oking == null)
		{
			throw new ArgumentNullException("destFilePath");
		}
		await Forcemeat8.smethod_0(Pro3oking, delegate
		{
			Condonab6e(Droo4ily, Pro3oking);
			return Task.FromResult(0);
		}, CancellationToken.None);
	}

	public static void Condonab6e(Action<string> Glam6r6usness, string Bioener1etics)
	{
		if (Glam6r6usness == null)
		{
			throw new ArgumentNullException("writeSourceFile");
		}
		if (Bioener1etics == null)
		{
			throw new ArgumentNullException("destFilePath");
		}
		string text = Blockhead2(Path.GetDirectoryName(Bioener1etics));
		try
		{
			Glam6r6usness(text);
			Recog6ises(text, Bioener1etics);
		}
		catch
		{
			Misc7ose(text);
			throw;
		}
	}

	public static async Task Mi2count2(Func<string, Task> func_0, string U3traradica3s)
	{
		if (func_0 == null)
		{
			throw new ArgumentNullException("writeSourceFile");
		}
		if (U3traradica3s == null)
		{
			throw new ArgumentNullException("destFilePath");
		}
		string tempPath = Blockhead2(Path.GetDirectoryName(U3traradica3s));
		try
		{
			await func_0(tempPath);
			Recog6ises(tempPath, U3traradica3s);
		}
		catch
		{
			Misc7ose(tempPath);
			throw;
		}
	}

	public static void Recog6ises(string Mist7anslate, string Perf1sion)
	{
		Misc7ose(Perf1sion);
		smethod_0(Mist7anslate, Perf1sion);
	}

	public static void smethod_0(string Sa5ifrage, string Axialitie0)
	{
		if (Sa5ifrage == null)
		{
			throw new ArgumentNullException("sourceFileName");
		}
		if (Axialitie0 == null)
		{
			throw new ArgumentNullException("destFileName");
		}
		for (int i = 0; i < Pa1ama; i++)
		{
			try
			{
				File.Move(Sa5ifrage, Axialitie0);
				break;
			}
			catch (Exception ex) when (i < Pa1ama - 1 && (ex is UnauthorizedAccessException || ex is IOException))
			{
				Op5h(100);
			}
		}
	}

	public static void Misc7ose(string Misbu66ons)
	{
		if (Misbu66ons == null)
		{
			throw new ArgumentNullException("path");
		}
		for (int i = 0; i < Pa1ama; i++)
		{
			try
			{
				if (File.Exists(Misbu66ons))
				{
					File.Delete(Misbu66ons);
				}
				break;
			}
			catch (Exception ex) when (i < Pa1ama - 1 && (ex is UnauthorizedAccessException || ex is IOException))
			{
				Op5h(100);
			}
		}
	}

	public static T D1s1rting<T>(string string_0, Func<FileStream, string, T> Pon4oniers)
	{
		int pa1ama = Pa1ama;
		for (int i = 1; i <= pa1ama; i++)
		{
			try
			{
				using FileStream arg = new FileStream(string_0, FileMode.Open, FileAccess.Read, Val5ating);
				return Pon4oniers(arg, string_0);
			}
			catch (Exception ex) when (i < pa1ama && (ex is UnauthorizedAccessException || ex is IOException))
			{
				Op5h(100);
			}
		}
		return default(T);
	}

	public static async Task<T> Bewee6<T>(string Pane44oni, Func<FileStream, string, Task<T>> Trickish7ess)
	{
		int retries = Pa1ama;
		for (int i = 1; i <= retries; i++)
		{
			try
			{
				using FileStream stream = new FileStream(Pane44oni, FileMode.Open, FileAccess.Read, Val5ating);
				return await Trickish7ess(stream, Pane44oni);
			}
			catch (Exception ex) when (i < retries && (ex is UnauthorizedAccessException || ex is IOException))
			{
				Op5h(100);
			}
		}
		return default(T);
	}

	private static void Op5h(int Nonfun6e6)
	{
		Thread.Sleep(Nonfun6e6);
	}
}
