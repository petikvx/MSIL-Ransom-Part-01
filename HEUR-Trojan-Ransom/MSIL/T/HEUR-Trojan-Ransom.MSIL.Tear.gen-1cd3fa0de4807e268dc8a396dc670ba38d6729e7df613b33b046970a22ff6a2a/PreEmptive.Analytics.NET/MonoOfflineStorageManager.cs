using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PreEmptive.Analytics.Common;

namespace PreEmptive.Analytics.NET;

public class MonoOfflineStorageManager : IOfflineStorageManager, IDisposable
{
	[CompilerGenerated]
	private sealed class Class24
	{
		public string string_0;

		public string string_1;

		public bool method_0(string string_2)
		{
			int num = -14265;
			int num2 = num;
			num = -14265;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				if (!string_2.EndsWith(string_0))
				{
					return false;
				}
				break;
			case false:
			case true:
				break;
			}
			return string_2.Contains(string_1);
		}
	}

	private IsolatedStorageFile isolatedStorageFile_0;

	private readonly string string_0;

	[CompilerGenerated]
	private static Func<string, string> func_0;

	public MonoOfflineStorageManager(string appid)
	{
		string_0 = "닦뛀닛뻷닛뛂닚긻删嘷剰市列噼" + appid;
		try
		{
			isolatedStorageFile_0 = IsolatedStorageFile.GetUserStoreForAssembly();
		}
		catch
		{
			isolatedStorageFile_0 = IsolatedStorageFile.GetMachineStoreForAssembly();
		}
		isolatedStorageFile_0.CreateDirectory(string_0);
	}

	public void MoveFile(string origin, string destination)
	{
		int num = 27376;
		int num2 = num;
		num = 27376;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		isolatedStorageFile_0.MoveFile(Path.Combine(string_0, origin), Path.Combine(string_0, destination));
	}

	public IEnumerable<string> GetFilesEndingWith(string suffix, [Optional] string contains)
	{
		int num = 11;
		if (1 == 0)
		{
		}
		int num2 = 15360;
		int num3 = num2;
		num2 = 15360;
		switch (num3 == num2)
		{
		default:
		{
			if (0 == 0)
			{
			}
			string[] fileNames = isolatedStorageFile_0.GetFileNames(Path.Combine(string_0, "틸"));
			return fileNames.Where(delegate(string string_2)
			{
				int num6 = -14265;
				int num7 = num6;
				num6 = -14265;
				switch (num7 == num6)
				{
				default:
					if (0 == 0)
					{
					}
					if (1 == 0)
					{
					}
					if (!string_2.EndsWith(suffix))
					{
						return false;
					}
					break;
				case false:
				case true:
					break;
				}
				return string_2.Contains(contains);
			}).OrderBy(delegate(string string_1)
			{
				int num4 = 26298;
				int num5 = num4;
				num4 = 26298;
				switch (num5 == num4)
				{
				default:
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					return string_1;
				}
			});
		}
		}
	}

	public void DeleteFile(string filename)
	{
		int num = 16615;
		int num2 = num;
		num = 16615;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		if (1 == 0)
		{
		}
		isolatedStorageFile_0.DeleteFile(Path.Combine(string_0, filename));
	}

	public void WriteToFile(string filename, string text)
	{
		int num = 26004;
		int num2 = num;
		num = 26004;
		switch (num2 == num)
		{
		case false:
		case true:
			return;
		}
		if (0 == 0)
		{
		}
		IsolatedStorageFileStream isolatedStorageFileStream = isolatedStorageFile_0.OpenFile(Path.Combine(string_0, filename), FileMode.Create, FileAccess.ReadWrite, FileShare.Delete);
		try
		{
			StreamWriter streamWriter = new StreamWriter(isolatedStorageFileStream);
			try
			{
				streamWriter.Write(text);
				streamWriter.Flush();
				streamWriter.Close();
			}
			finally
			{
				num = 0;
				int num3 = num;
				while (true)
				{
					switch (num3)
					{
					case 1:
						((IDisposable)streamWriter).Dispose();
						num = 2;
						num3 = num;
						continue;
					default:
						if (streamWriter != null)
						{
							num = 1;
							num3 = num;
							continue;
						}
						break;
					case 2:
						break;
					}
					break;
				}
			}
			isolatedStorageFileStream.Close();
		}
		finally
		{
			num = 0;
			int num3 = num;
			while (true)
			{
				switch (num3)
				{
				case 1:
					((IDisposable)isolatedStorageFileStream).Dispose();
					if (1 == 0)
					{
					}
					num = 2;
					num3 = num;
					continue;
				default:
					if (isolatedStorageFileStream != null)
					{
						num = 1;
						num3 = num;
						continue;
					}
					break;
				case 2:
					break;
				}
				break;
			}
		}
	}

	public string ReadFile(string filename)
	{
		int num = -3493;
		int num2 = num;
		num = -3493;
		switch (num2 == num)
		{
		default:
		{
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			IsolatedStorageFileStream isolatedStorageFileStream = isolatedStorageFile_0.OpenFile(Path.Combine(string_0, filename), FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			try
			{
				isolatedStorageFileStream.Seek(0L, SeekOrigin.Begin);
				StreamReader streamReader = new StreamReader(isolatedStorageFileStream);
				try
				{
					return streamReader.ReadToEnd();
				}
				finally
				{
					num = 0;
					int num3 = num;
					while (true)
					{
						switch (num3)
						{
						case 1:
							((IDisposable)streamReader).Dispose();
							num = 2;
							num3 = num;
							continue;
						default:
							if (streamReader != null)
							{
								num = 1;
								num3 = num;
								continue;
							}
							break;
						case 2:
							break;
						}
						break;
					}
				}
			}
			finally
			{
				num = 0;
				int num3 = num;
				while (true)
				{
					switch (num3)
					{
					case 1:
						((IDisposable)isolatedStorageFileStream).Dispose();
						num = 2;
						num3 = num;
						continue;
					default:
						if (isolatedStorageFileStream != null)
						{
							num = 1;
							num3 = num;
							continue;
						}
						break;
					case 2:
						break;
					}
					break;
				}
			}
		}
		case false:
		case true:
		{
			string result = default(string);
			return result;
		}
		}
	}

	public void Dispose()
	{
		int num = 21808;
		int num2 = num;
		num = 21808;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		isolatedStorageFile_0.Dispose();
	}

	[CompilerGenerated]
	private static string smethod_0(string string_1)
	{
		int num = 26298;
		int num2 = num;
		num = 26298;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return string_1;
		}
	}
}
