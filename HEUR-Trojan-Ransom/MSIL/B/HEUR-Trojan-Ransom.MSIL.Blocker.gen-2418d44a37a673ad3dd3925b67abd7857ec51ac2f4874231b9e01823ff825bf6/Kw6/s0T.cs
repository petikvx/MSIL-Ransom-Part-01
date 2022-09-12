using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Ha03;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Pp74;
using Wo0y;
using Wo29;
using Xi7s;
using b1T3;
using d2G3;
using i1H7;
using y6N2;
using z2FR;

namespace Kw6;

[StandardModule]
internal sealed class s0T
{
	public static bool CerrarServidor = false;

	public static string modName;

	public static string ModNameComprobacionGuardar = "";

	public static string nombreArchivoObtenido;

	public static string nombreClaseObtenido;

	public static bool cancelModName;

	public static string ruta;

	public static string rutaTemp = "\\temp\\";

	public static string rutaPlayer = "\\CoJ2\\Data\\Player\\";

	public static string rutaAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ModsCoJ2\\";

	public static StreamWriter write;

	public static StreamReader read;

	public static bool vRestart = false;

	public static string ModIniCabecera = "";

	public static string ModIniAristocrat = "";

	public static string ModIniBandit = "";

	public static string ModIniBarnsby = "";

	public static string ModIniDoc = "";

	public static string ModIniGunslinger = "";

	public static string ModIniGunsmith = "";

	public static string ModIniJuarez = "";

	public static string ModIniMiner = "";

	public static string ModIniRifleman = "";

	public static string ModIniSniper = "";

	public static string ModIniThief = "";

	public static string ModIniTrapper = "";

	public static string ModIniTribeWarrior = "";

	public static string ConfiguracionModInicial = "";

	private static object frmArmas;

	public const string sSecretKey = "%c0jm0ds";

	public static void b7B()
	{
		Qj0("c:\\temp\\test.txt", "c:\\temp\\Encrypted.txt", "%c0jm0ds");
		Eq5("c:\\temp\\Encrypted.txt", "c:\\temp\\Decrypted.txt", "%c0jm0ds");
	}

	public static void Qj0(string y9G, string t9K, string s1F)
	{
		FileStream fileStream = new FileStream(y9G, FileMode.Open, FileAccess.Read);
		FileStream stream = new FileStream(t9K, FileMode.Create, FileAccess.Write);
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		dESCryptoServiceProvider.Key = Encoding.ASCII.GetBytes(s1F);
		dESCryptoServiceProvider.IV = Encoding.ASCII.GetBytes(s1F);
		ICryptoTransform transform = dESCryptoServiceProvider.CreateEncryptor();
		CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[checked((int)(fileStream.Length - 1L) + 1)];
		fileStream.Read(array, 0, array.Length);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.Close();
	}

	public static void Eq5(string Jf7, string c2X, string Yz4)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		dESCryptoServiceProvider.Key = Encoding.ASCII.GetBytes(Yz4);
		dESCryptoServiceProvider.IV = Encoding.ASCII.GetBytes(Yz4);
		FileStream stream = new FileStream(Jf7, FileMode.Open, FileAccess.Read);
		ICryptoTransform transform = dESCryptoServiceProvider.CreateDecryptor();
		CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		StreamWriter streamWriter = new StreamWriter(c2X);
		streamWriter.Write(new StreamReader(stream2).ReadToEnd());
		streamWriter.Flush();
		streamWriter.Close();
	}

	public static void Sr0()
	{
		string text = "";
		string text2 = "";
		if (!File.Exists(rutaAppData + "\\Mods\\" + modName + "\\ini\\mod.ini"))
		{
			return;
		}
		read = File.OpenText(rutaAppData + "\\Mods\\" + modName + "\\ini\\mod.ini");
		text2 = read.ReadToEnd();
		checked
		{
			text2 = text2.Substring(0, text2.Length - 2);
			read.Close();
			int num = 0;
			ModIniCabecera = text2.Substring(0, 1).ToString();
			int num2 = 1;
			do
			{
				switch (num2)
				{
				case 2:
					text = "Bandit";
					num = text2.IndexOf(text);
					if (num > -1)
					{
						ModIniBandit = text2.Substring(num + Strings.Len(text), 10).ToString();
					}
					break;
				case 3:
					text = "Barnsby";
					num = text2.IndexOf(text);
					if (num > -1)
					{
						ModIniBarnsby = text2.Substring(num + Strings.Len(text), 10).ToString();
					}
					break;
				case 4:
					text = "Doc";
					num = text2.IndexOf(text);
					if (num > -1)
					{
						ModIniDoc = text2.Substring(num + Strings.Len(text), 10).ToString();
					}
					break;
				case 5:
					text = "Gunslinger";
					num = text2.IndexOf(text);
					if (num > -1)
					{
						ModIniGunslinger = text2.Substring(num + Strings.Len(text), 10).ToString();
					}
					break;
				case 6:
					text = "Gunsmith";
					num = text2.IndexOf(text);
					if (num > -1)
					{
						ModIniGunsmith = text2.Substring(num + Strings.Len(text), 10).ToString();
					}
					break;
				case 7:
					text = "Juarez";
					num = text2.IndexOf(text);
					if (num > -1)
					{
						ModIniJuarez = text2.Substring(num + Strings.Len(text), 10).ToString();
					}
					break;
				case 8:
					text = "Miner";
					num = text2.IndexOf(text);
					if (num > -1)
					{
						ModIniMiner = text2.Substring(num + Strings.Len(text), 10).ToString();
					}
					break;
				case 9:
					text = "Rifleman";
					num = text2.IndexOf(text);
					if (num > -1)
					{
						ModIniRifleman = text2.Substring(num + Strings.Len(text), 10).ToString();
					}
					break;
				case 10:
					text = "Sniper";
					num = text2.IndexOf(text);
					if (num > -1)
					{
						ModIniSniper = text2.Substring(num + Strings.Len(text), 10).ToString();
					}
					break;
				case 11:
					text = "Thief";
					num = text2.IndexOf(text);
					if (num > -1)
					{
						ModIniThief = text2.Substring(num + Strings.Len(text), 10).ToString();
					}
					break;
				case 12:
					text = "Trapper";
					num = text2.IndexOf(text);
					if (num > -1)
					{
						ModIniTrapper = text2.Substring(num + Strings.Len(text), 10).ToString();
					}
					break;
				case 13:
					text = "TribeWarrior";
					num = text2.IndexOf(text);
					if (num > -1)
					{
						ModIniTribeWarrior = text2.Substring(num + Strings.Len(text), 10).ToString();
					}
					break;
				case 1:
					text = "Aristocrat";
					num = text2.IndexOf(text);
					if (num > -1)
					{
						ModIniAristocrat = text2.Substring(num + Strings.Len(text), 10).ToString();
					}
					break;
				}
				num2++;
			}
			while (num2 <= 13);
			ConfiguracionModInicial = text2;
		}
	}

	public static void Zx1()
	{
		if (Directory.Exists(rutaAppData + "\\Mods\\" + modName + "\\ini"))
		{
			((ServerComputer)Cc9k.Computer).get_FileSystem().DeleteDirectory(rutaAppData + "\\Mods\\" + modName + "\\ini", (DeleteDirectoryOption)5);
		}
		((ServerComputer)Cc9k.Computer).get_FileSystem().CreateDirectory(rutaAppData + "\\Mods\\" + modName + "\\ini");
		string text = "";
		if (Operators.CompareString(ModIniCabecera, "", false) == 0)
		{
			ModIniCabecera = "0";
		}
		if (Operators.CompareString(ModIniCabecera, "", false) != 0)
		{
			text += ModIniCabecera;
		}
		if (Operators.CompareString(Strings.Trim(ModIniAristocrat), "", false) != 0)
		{
			text = text + "Aristocrat" + ModIniAristocrat;
		}
		if (Operators.CompareString(Strings.Trim(ModIniBandit), "", false) != 0)
		{
			text = text + "Bandit" + ModIniBandit;
		}
		if (Operators.CompareString(Strings.Trim(ModIniBarnsby), "", false) != 0)
		{
			text = text + "Barnsby" + ModIniBarnsby;
		}
		if (Operators.CompareString(Strings.Trim(ModIniDoc), "", false) != 0)
		{
			text = text + "Doc" + ModIniDoc;
		}
		if (Operators.CompareString(Strings.Trim(ModIniGunslinger), "", false) != 0)
		{
			text = text + "Gunslinger" + ModIniGunslinger;
		}
		if (Operators.CompareString(Strings.Trim(ModIniGunsmith), "", false) != 0)
		{
			text = text + "Gunsmith" + ModIniGunsmith;
		}
		if (Operators.CompareString(Strings.Trim(ModIniJuarez), "", false) != 0)
		{
			text = text + "Juarez" + ModIniJuarez;
		}
		if (Operators.CompareString(Strings.Trim(ModIniMiner), "", false) != 0)
		{
			text = text + "Miner" + ModIniMiner;
		}
		if (Operators.CompareString(Strings.Trim(ModIniRifleman), "", false) != 0)
		{
			text = text + "Rifleman" + ModIniRifleman;
		}
		if (Operators.CompareString(Strings.Trim(ModIniSniper), "", false) != 0)
		{
			text = text + "Sniper" + ModIniSniper;
		}
		if (Operators.CompareString(Strings.Trim(ModIniThief), "", false) != 0)
		{
			text = text + "Thief" + ModIniThief;
		}
		if (Operators.CompareString(Strings.Trim(ModIniTrapper), "", false) != 0)
		{
			text = text + "Trapper" + ModIniTrapper;
		}
		if (Operators.CompareString(Strings.Trim(ModIniTribeWarrior), "", false) != 0)
		{
			text = text + "TribeWarrior" + ModIniTribeWarrior;
		}
		write = File.AppendText(rutaAppData + "\\Mods\\" + modName + "\\ini\\mod.ini");
		write.WriteLine(text);
		write.Close();
	}

	public static void p6E(string Yz4)
	{
		switch (Yz4)
		{
		case "Aristocrat":
			nombreArchivoObtenido = "_NetWeapon_Aristocrat_Properties.scr";
			break;
		case "Bandit":
			nombreArchivoObtenido = "_NetWeapon_Bandit_Properties.scr";
			break;
		case "Barnsby":
			nombreArchivoObtenido = "_NetWeapon_Barnsby_Properties.scr";
			break;
		case "Doc":
			nombreArchivoObtenido = "_NetWeapon_Doc_Properties.scr";
			break;
		case "Gunslinger":
			nombreArchivoObtenido = "_NetWeapon_Gunslinger_Properties.scr";
			break;
		case "Gunsmith":
			nombreArchivoObtenido = "_NetWeapon_Gunsmith_Properties.scr";
			break;
		case "Juarez":
			nombreArchivoObtenido = "_NetWeapon_Juarez_Properties.scr";
			break;
		case "Miner":
			nombreArchivoObtenido = "_NetWeapon_Miner_Properties.scr";
			break;
		case "Rifleman":
			nombreArchivoObtenido = "_NetWeapon_Rifleman_Properties.scr";
			break;
		case "Sniper":
			nombreArchivoObtenido = "_NetWeapon_Sniper_Properties.scr";
			break;
		case "Thief":
			nombreArchivoObtenido = "_NetWeapon_Thief_Properties.scr";
			break;
		case "Trapper":
			nombreArchivoObtenido = "_NetWeapon_Trapper_Properties.scr";
			break;
		case "Tribe Warrior":
			nombreArchivoObtenido = "_NetWeapon_TribeWarrior_Properties.scr";
			break;
		}
	}

	public static void z7Z(string Sd9)
	{
		switch (Sd9)
		{
		case "_NetWeapon_Aristocrat_Properties.scr":
			nombreClaseObtenido = "Aristocrat";
			break;
		case "_NetWeapon_Bandit_Properties.scr":
			nombreClaseObtenido = "Bandit";
			break;
		case "_NetWeapon_Barnsby_Properties.scr":
			nombreClaseObtenido = "Barnsby";
			break;
		case "_NetWeapon_Doc_Properties.scr":
			nombreClaseObtenido = "Doc";
			break;
		case "_NetWeapon_Gunslinger_Properties.scr":
			nombreClaseObtenido = "Gunslinger";
			break;
		case "_NetWeapon_Gunsmith_Properties.scr":
			nombreClaseObtenido = "Gunsmith";
			break;
		case "_NetWeapon_Juarez_Properties.scr":
			nombreClaseObtenido = "Juarez";
			break;
		case "_NetWeapon_Miner_Properties.scr":
			nombreClaseObtenido = "Miner";
			break;
		case "_NetWeapon_Rifleman_Properties.scr":
			nombreClaseObtenido = "Rifleman";
			break;
		case "_NetWeapon_Sniper_Properties.scr":
			nombreClaseObtenido = "Sniper";
			break;
		case "_NetWeapon_Thief_Properties.scr":
			nombreClaseObtenido = "Thief";
			break;
		case "_NetWeapon_Trapper_Properties.scr":
			nombreClaseObtenido = "Trapper";
			break;
		case "_NetWeapon_TribeWarrior_Properties.scr":
			nombreClaseObtenido = "Tribe Warrior";
			break;
		}
	}

	public static void x3M(string f5H)
	{
		if (((ServerComputer)Cc9k.Computer).get_FileSystem().DirectoryExists(ruta + rutaTemp))
		{
			DirectoryInfo directoryInfo = ((ServerComputer)Cc9k.Computer).get_FileSystem().GetDirectoryInfo(f5H);
			directoryInfo.Attributes = FileAttributes.Hidden;
		}
	}

	static void Bz1()
	{
		_ = (p9CA)(object)t8TR.Default;
		_ = (s2ZW)(object)t8TR.Default;
		_ = (o3HG)(object)t8TR.Default;
		_ = (y9CZ)(object)t8TR.Default;
		_ = (s0T)(object)t8TR.Default;
		object obj = null;
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		s0T s0T2;
		if (uIntPtr == 0)
		{
			s0T2 = null;
			s0T2 = s0T2;
			goto IL_00a3;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o3HG o3HG);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nb4n nb4n);
		try
		{
			_ = (Nb4n)(object)t8TR.Default;
			nb4n = null;
			nb4n = nb4n;
		}
		catch
		{
			o3HG = o3HG;
		}
		finally
		{
			_ = (s0T)(object)t8TR.Default;
			goto IL_00a3;
		}
		IL_04b1:
		do
		{
			if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ao56)(object)t8TR.Default;
			}
		}
		while ((object)t8TR.Default != null);
		Cc9k cc9k = (Cc9k)(object)t8TR.Default;
		Hj2y hj2y = hj2y;
		_ = (_003CModule_003E)(object)t8TR.Default;
		o3HG = o3HG;
		while (obj != null)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ao56 ao);
		try
		{
			try
			{
				if (uIntPtr / unchecked((nuint)default(UIntPtr)) == 0)
				{
					ao = ao;
				}
			}
			catch
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					cc9k = cc9k;
				}
			}
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				o3HG = o3HG;
				nb4n = (Nb4n)(object)t8TR.Default;
				s2ZW s2ZW = null;
				_ = (m0PK)(object)t8TR.Default;
			}
			else
			{
				_ = (_003CModule_003E)(object)t8TR.Default;
			}
		}
		while (obj != null)
		{
			if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Nb4n)(object)t8TR.Default;
				}
				catch
				{
					_ = (Ao56)(object)t8TR.Default;
				}
			}
			else
			{
				_ = (Cc9k)(object)t8TR.Default;
			}
		}
		s0T2 = s0T2;
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			s0T2 = s0T2;
			_ = (Ao56)(object)t8TR.Default;
			_ = (m0PK)(object)t8TR.Default;
		}
		return;
		IL_02f6:
		if (uIntPtr != 0)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9CA p9CA);
		try
		{
			uIntPtr = default(UIntPtr);
			nuint num = uIntPtr;
			UIntPtr num2 = (UIntPtr)t8TR.Default;
			uIntPtr = default(UIntPtr);
			nuint num3 = checked(unchecked((nuint)num2) * uIntPtr) / uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num / (num3 / uIntPtr) == 0)
			{
				try
				{
					p9CA = null;
				}
				finally
				{
					_ = (p9CA)(object)t8TR.Default;
					goto end_IL_02fd;
				}
			}
			p9CA = null;
			end_IL_02fd:;
		}
		finally
		{
			while (obj != null)
			{
				p9CA = null;
			}
			goto IL_0366;
		}
		IL_00a3:
		try
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr + uIntPtr) == 0)
			{
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (Hj2y)(object)t8TR.Default;
			goto IL_0110;
		}
		try
		{
			do
			{
				_ = (Hj2y)(object)t8TR.Default;
			}
			while ((object)t8TR.Default != null);
		}
		finally
		{
			do
			{
				_ = (Nb4n)(object)t8TR.Default;
			}
			while (obj != null);
			goto IL_0110;
		}
		IL_02ab:
		nb4n = nb4n;
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = (y9CZ)(object)t8TR.Default;
				}
				while ((object)t8TR.Default != null);
			}
			finally
			{
				if (uIntPtr == 0)
				{
					ao = ao;
				}
				else
				{
					_ = (s2ZW)(object)t8TR.Default;
				}
				goto IL_02f6;
			}
		}
		goto IL_02f6;
		IL_0223:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			do
			{
				try
				{
					_ = (y9CZ)(object)t8TR.Default;
				}
				catch
				{
					_ = (y9CZ)(object)t8TR.Default;
				}
			}
			while (obj != null);
			goto IL_02ab;
		}
		try
		{
			try
			{
				_ = (o3HG)(object)t8TR.Default;
			}
			finally
			{
				p9CA = p9CA;
				_ = (Nb4n)(object)t8TR.Default;
				_ = (Nb4n)(object)t8TR.Default;
				_003CModule_003E _003CModule_003E = null;
				_003CModule_003E = _003CModule_003E;
				goto end_IL_0258;
			}
			end_IL_0258:;
		}
		finally
		{
			while (obj != null)
			{
				_ = (p9CA)(object)t8TR.Default;
			}
			goto IL_02ab;
		}
		IL_0366:
		s0T2 = null;
		_ = (Cc9k)(object)t8TR.Default;
		while (obj != null)
		{
			_ = (o3HG)(object)t8TR.Default;
			hj2y = null;
			o3HG = null;
			_ = (Nb4n)(object)t8TR.Default;
		}
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				_ = (s0T)(object)t8TR.Default;
			}
		}
		try
		{
			try
			{
				_ = (o3HG)(object)t8TR.Default;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (Ao56)(object)t8TR.Default;
				}
				goto end_IL_03b7;
			}
			end_IL_03b7:;
		}
		catch
		{
			try
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Ao56)(object)t8TR.Default;
				}
			}
			catch
			{
				while (true)
				{
					if ((object)t8TR.Default != null)
					{
						_ = (y9CZ)(object)t8TR.Default;
						_ = (Nb4n)(object)t8TR.Default;
						continue;
					}
					goto end_IL_03f4;
				}
				end_IL_03f4:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t8TR t8TR);
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)t8TR.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					t8TR = t8TR;
				}
				finally
				{
					_ = t8TR.Default;
					goto IL_04b1;
				}
			}
			s2ZW s2ZW = (s2ZW)(object)t8TR.Default;
			_ = t8TR.Default;
			_ = (Nb4n)(object)t8TR.Default;
		}
		else
		{
			do
			{
				try
				{
					_ = (s2ZW)(object)t8TR.Default;
				}
				finally
				{
					_ = (Ao56)(object)t8TR.Default;
					continue;
				}
			}
			while (obj != null);
		}
		goto IL_04b1;
		IL_0110:
		try
		{
			t8TR obj10 = t8TR.Default;
			t8TR = t8TR;
			t8TR = obj10;
		}
		finally
		{
			do
			{
				if ((UIntPtr)t8TR.Default != (UIntPtr)(nuint)0u)
				{
					hj2y = hj2y;
					hj2y = hj2y;
				}
				else
				{
					p9CA obj11 = (p9CA)(object)t8TR.Default;
					p9CA = p9CA;
					p9CA = obj11;
				}
			}
			while (obj != null);
			goto IL_016c;
		}
		IL_016c:
		_ = (y9CZ)(object)t8TR.Default;
		hj2y = hj2y;
		_ = t8TR.Default;
		_ = (Hj2y)(object)t8TR.Default;
		_ = (Hj2y)(object)t8TR.Default;
		while (obj != null)
		{
			_ = (Ao56)(object)t8TR.Default;
		}
		checked
		{
			if (uIntPtr - unchecked((nuint)(UIntPtr)t8TR.Default) == 0)
			{
				try
				{
					do
					{
						_ = t8TR.Default;
						s2ZW s2ZW = (s2ZW)(object)t8TR.Default;
						s2ZW = s2ZW;
						ao = ao;
						ao = null;
					}
					while (obj != null);
				}
				finally
				{
					t8TR = t8TR;
					o3HG = o3HG;
					_ = (s2ZW)(object)t8TR.Default;
					_ = (Nb4n)(object)t8TR.Default;
					goto IL_0223;
				}
			}
			goto IL_0223;
		}
	}
}
