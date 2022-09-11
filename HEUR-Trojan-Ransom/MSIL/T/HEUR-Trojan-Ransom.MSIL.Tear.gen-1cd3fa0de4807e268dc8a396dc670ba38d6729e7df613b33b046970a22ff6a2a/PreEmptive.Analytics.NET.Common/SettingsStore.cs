using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Threading;
using PreEmptive.Analytics.Common;

namespace PreEmptive.Analytics.NET.Common;

public class SettingsStore : ISettingsStore
{
	private IsolatedStorageFile isolatedStorageFile_0;

	private string string_0;

	private object object_0;

	public string this[string string_1]
	{
		get
		{
			int num = 29341;
			int num2 = num;
			num = 29341;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
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
				num = 5311;
				int num3 = num;
				num = 5311;
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
						case 0:
							if (true)
							{
							}
							goto default;
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
							goto end_IL_00e0;
						case 2:
							if (Keys.Count == 0)
							{
								num = 4;
								num2 = num;
								goto end_IL_00e0;
							}
							return;
						case 3:
							return;
						case 4:
							isolatedStorageFile_0.DeleteDirectory(string_0);
							return;
						}
						goto case false;
					}
					end_IL_00e0:
					break;
				}
			}
		}
	}

	public int Count
	{
		get
		{
			int num = 12268;
			int num2 = num;
			num = 12268;
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
			int num = 14;
			int num2 = 10568;
			int num3 = num2;
			num2 = 10568;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return isolatedStorageFile_0.GetFileNames(string_0 + "꺘늘뚘").ToList();
			}
		}
	}

	public int MaxValueLength
	{
		get
		{
			int num = 20857;
			int num2 = num;
			num = 20857;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
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
			int num = -19855;
			int num2 = num;
			num = -19855;
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

	public SettingsStore(string appid)
	{
		int num = 14;
		object_0 = new object();
		base._002Ector();
		if (NetUtilities.RunningInMono())
		{
			throw new NotSupportedException("껦닞뛛닍뺒닕뛞닏긡別噲刷帡剶嘰刜渝爝瘗爐繒爙瘜牎渟刹嘼刱平剶嘇勝껗늖뛿닑뻜닙뛡닋꺦튢횻튰\udeb5튥횁튚\uee9d\uf284\uf697\uf2deﺛ\uf298\uf681\uf29a\ueeb7튷횶");
		}
		string_0 = "껢닄뛗닻뻟닆뛆닇긤刳噼刌帛剸嘁刋渆爂瘛爐縕爅" + Path.DirectorySeparatorChar + "껢닄뛗닻뻟닆뛆닇긤刳噼刌帛剸" + appid + Path.DirectorySeparatorChar;
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
			isolatedStorageFile_0.GetDirectoryNames(string_0);
		}
		catch (DirectoryNotFoundException)
		{
			isolatedStorageFile_0.CreateDirectory(string_0);
		}
	}

	public void Flush()
	{
		if (1 == 0)
		{
		}
		int num = 10180;
		int num2 = num;
		num = 10180;
		switch (num2 == num)
		{
		}
		if (false)
		{
		}
	}

	private string method_0(string string_1)
	{
		while (true)
		{
			if (1 == 0)
			{
			}
			string result = null;
			string value = null;
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					try
					{
						isolatedStorageFile_0.GetFileNames(string_1);
						value = isolatedStorageFile_0.GetFileNames(string_1).FirstOrDefault();
					}
					catch (Exception)
					{
					}
					num = 0;
					num2 = num;
					continue;
				case 0:
					if (!string.IsNullOrEmpty(value))
					{
						num = 1;
						num2 = num;
						continue;
					}
					return result;
				case 1:
					try
					{
						while (true)
						{
							StreamReader streamReader = new StreamReader(new IsolatedStorageFileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read, isolatedStorageFile_0));
							try
							{
								result = streamReader.ReadToEnd();
							}
							finally
							{
								num = 2;
								num2 = num;
								while (true)
								{
									switch (num2)
									{
									default:
										if (streamReader != null)
										{
											num = 0;
											num2 = num;
											continue;
										}
										break;
									case 0:
										((IDisposable)streamReader).Dispose();
										num = 1;
										num2 = num;
										continue;
									case 1:
										break;
									}
									break;
								}
							}
							num = -28659;
							int num3 = num;
							num = -28659;
							switch (num3 == num)
							{
							case false:
							case true:
								continue;
							}
							if (false)
							{
								return result;
							}
							return result;
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
		while (true)
		{
			if (1 == 0)
			{
			}
			string value = null;
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
				{
					num = -8656;
					int num3 = num;
					num = -8656;
					switch (num3 == num)
					{
					default:
						if (0 == 0)
						{
						}
						try
						{
							value = isolatedStorageFile_0.GetFileNames(string_1).FirstOrDefault();
						}
						catch
						{
						}
						num = 0;
						num2 = num;
						continue;
					case false:
					case true:
						break;
					}
					goto case 1;
				}
				case 0:
					if (!string.IsNullOrEmpty(value))
					{
						num = 1;
						num2 = num;
						continue;
					}
					return;
				case 1:
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
		int num = 15;
		switch (0)
		{
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
					while (true)
					{
						StreamWriter streamWriter = new StreamWriter(isolatedStorageFileStream);
						int num2;
						try
						{
							streamWriter.Write(string_2);
							streamWriter.Close();
						}
						finally
						{
							num2 = 2;
							int num3 = num2;
							while (true)
							{
								switch (num3)
								{
								default:
									if (streamWriter != null)
									{
										num2 = 0;
										num3 = num2;
										continue;
									}
									break;
								case 0:
									((IDisposable)streamWriter).Dispose();
									num2 = 1;
									num3 = num2;
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						num2 = -13828;
						int num4 = num2;
						num2 = -13828;
						switch (num4 == num2)
						{
						case false:
						case true:
							continue;
						}
						if (0 == 0)
						{
						}
						isolatedStorageFileStream.Close();
						break;
					}
				}
				finally
				{
					int num2 = 2;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (isolatedStorageFileStream != null)
							{
								num2 = 0;
								num3 = num2;
								continue;
							}
							break;
						case 0:
							((IDisposable)isolatedStorageFileStream).Dispose();
							num2 = 1;
							num3 = num2;
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				isolatedStorageFile_0.GetFileNames(string_1.Replace("닻뛘닁뻊닓뛘닑껋创嘒", ""));
				isolatedStorageFile_0.GetFileNames(string_1);
			}
			catch
			{
			}
		}
		finally
		{
			int num2 = 2;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 2:
					if (true)
					{
					}
					goto default;
				default:
					if (lockTaken)
					{
						num2 = 0;
						num3 = num2;
						continue;
					}
					break;
				case 0:
					Monitor.Exit(obj);
					num2 = 1;
					num3 = num2;
					continue;
				case 1:
					break;
				}
				break;
			}
		}
	}
}
