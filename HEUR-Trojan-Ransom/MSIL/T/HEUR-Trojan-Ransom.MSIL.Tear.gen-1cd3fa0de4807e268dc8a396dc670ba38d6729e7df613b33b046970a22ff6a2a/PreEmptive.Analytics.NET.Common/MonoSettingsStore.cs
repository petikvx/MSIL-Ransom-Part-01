using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Threading;
using PreEmptive.Analytics.Common;

namespace PreEmptive.Analytics.NET.Common;

public class MonoSettingsStore : ISettingsStore
{
	private IsolatedStorageFile isolatedStorageFile_0;

	private string string_0;

	private object object_0 = new object();

	public string this[string string_1]
	{
		get
		{
			int num = 11601;
			int num2 = num;
			num = 11601;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return method_0(string_0 + string_1);
			}
		}
		set
		{
			int num = 0;
			int num2 = num;
			while (true)
			{
				num = 6319;
				int num3 = num;
				num = 6319;
				switch (num3 == num)
				{
				case false:
				case true:
					method_1(string_0 + string_1);
					num = 2;
					num2 = num;
					break;
				default:
					{
						if (0 == 0)
						{
						}
						switch (num2)
						{
						case 1:
							break;
						default:
							if (value == null)
							{
								num = 1;
								num2 = num;
							}
							else
							{
								method_2(string_0 + string_1, value);
								num = 3;
								num2 = num;
							}
							goto end_IL_00cb;
						case 2:
							if (Keys.Count == 0)
							{
								num = 4;
								num2 = num;
								goto end_IL_00cb;
							}
							return;
						case 3:
							if (true)
							{
							}
							return;
						case 4:
							isolatedStorageFile_0.DeleteDirectory(string_0);
							return;
						}
						goto case false;
					}
					end_IL_00cb:
					break;
				}
			}
		}
	}

	public int Count
	{
		get
		{
			int num = -20188;
			int num2 = num;
			num = -20188;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return Keys.Count;
			}
		}
	}

	public IList<string> Keys
	{
		get
		{
			int num = 0;
			int num2 = 6737;
			int num3 = num2;
			num2 = 6737;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return isolatedStorageFile_0.GetFileNames(string_0 + "틼훼틴").ToList();
			}
		}
	}

	public int MaxValueLength
	{
		get
		{
			int num = -29688;
			int num2 = num;
			num = -29688;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return int.MaxValue;
			}
		}
	}

	public int MaxKeyLength
	{
		get
		{
			if (1 == 0)
			{
			}
			int num = 23337;
			int num2 = num;
			num = 23337;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return int.MaxValue;
			}
		}
	}

	public MonoSettingsStore(string appid)
	{
		string_0 = "횂틜껗닳뛟닎뻆닟뛄닋깼刄嘛刍帷刢嘦切渜爑瘁牐" + appid + Path.DirectorySeparatorChar;
		try
		{
			isolatedStorageFile_0 = IsolatedStorageFile.GetUserStoreForAssembly();
		}
		catch
		{
			isolatedStorageFile_0 = IsolatedStorageFile.GetMachineStoreForAssembly();
		}
		try
		{
			string[] directoryNames = isolatedStorageFile_0.GetDirectoryNames();
			string text = string_0.Replace(new string(Path.DirectorySeparatorChar, 1), "");
			if (!directoryNames.Contains(text))
			{
				isolatedStorageFile_0.CreateDirectory(text);
			}
		}
		catch
		{
		}
	}

	public void Flush()
	{
		int num = 25283;
		int num2 = num;
		num = 25283;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (false)
		{
		}
	}

	private string method_0(string string_1)
	{
		int num3 = default(int);
		while (true)
		{
			string result = null;
			string value = null;
			int num = -15489;
			int num2 = num;
			num = -15489;
			switch (num2 == num)
			{
			case false:
			case true:
				break;
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				num = 0;
				num3 = num;
				break;
			}
			while (true)
			{
				switch (num3)
				{
				case 1:
					if (!string.IsNullOrEmpty(value))
					{
						num = 2;
						num3 = num;
						continue;
					}
					return result;
				case 0:
					try
					{
						value = isolatedStorageFile_0.GetFileNames(string_1).FirstOrDefault();
					}
					catch (Exception)
					{
					}
					num = 1;
					num3 = num;
					continue;
				case 2:
					try
					{
						StreamReader streamReader = new StreamReader(new IsolatedStorageFileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read, isolatedStorageFile_0));
						try
						{
							result = streamReader.ReadToEnd();
							return result;
						}
						finally
						{
							num = 0;
							num3 = num;
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
					catch
					{
						return result;
					}
				}
				break;
			}
		}
	}

	private void method_1(string string_1)
	{
		int num3 = default(int);
		while (true)
		{
			string value = null;
			int num = -23541;
			int num2 = num;
			num = -23541;
			switch (num2 == num)
			{
			case false:
			case true:
				break;
			default:
				if (0 == 0)
				{
				}
				num = 0;
				num3 = num;
				break;
			}
			while (true)
			{
				switch (num3)
				{
				case 1:
					if (!string.IsNullOrEmpty(value))
					{
						num = 2;
						num3 = num;
						continue;
					}
					return;
				case 0:
					if (1 == 0)
					{
					}
					try
					{
						value = isolatedStorageFile_0.GetFileNames(string_1).FirstOrDefault();
					}
					catch
					{
					}
					num = 1;
					num3 = num;
					continue;
				case 2:
					try
					{
						isolatedStorageFile_0.DeleteFile(string_1);
						return;
					}
					catch
					{
						return;
					}
				}
				break;
			}
		}
	}

	private void method_2(string string_1, string string_2)
	{
		int num = 2375;
		int num2 = num;
		num = 2375;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			switch (0)
			{
			}
			break;
		case false:
		case true:
			break;
		}
		bool lockTaken = false;
		object obj = default(object);
		try
		{
			Monitor.Enter(obj = object_0, ref lockTaken);
			try
			{
				IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream(string_1, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, isolatedStorageFile_0);
				try
				{
					StreamWriter streamWriter = new StreamWriter(isolatedStorageFileStream);
					try
					{
						streamWriter.Write(string_2);
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
			catch
			{
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
					Monitor.Exit(obj);
					num = 2;
					num3 = num;
					continue;
				default:
					if (lockTaken)
					{
						if (1 == 0)
						{
						}
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
}
