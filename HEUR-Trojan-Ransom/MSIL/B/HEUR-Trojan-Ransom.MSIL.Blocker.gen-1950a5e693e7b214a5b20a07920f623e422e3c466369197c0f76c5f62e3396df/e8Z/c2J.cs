using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Co02;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;

namespace e8Z;

[StandardModule]
internal sealed class c2J
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

	public static void n1E()
	{
		r8Q("c:\\temp\\test.txt", "c:\\temp\\Encrypted.txt", "%c0jm0ds");
		Yq7("c:\\temp\\Encrypted.txt", "c:\\temp\\Decrypted.txt", "%c0jm0ds");
	}

	public static void r8Q(string m5K, string f6H, string Qz2)
	{
		FileStream fileStream = new FileStream(m5K, FileMode.Open, FileAccess.Read);
		FileStream stream = new FileStream(f6H, FileMode.Create, FileAccess.Write);
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		dESCryptoServiceProvider.Key = Encoding.ASCII.GetBytes(Qz2);
		dESCryptoServiceProvider.IV = Encoding.ASCII.GetBytes(Qz2);
		ICryptoTransform transform = dESCryptoServiceProvider.CreateEncryptor();
		CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[checked((int)(fileStream.Length - 1L) + 1)];
		fileStream.Read(array, 0, array.Length);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.Close();
	}

	public static void Yq7(string k0E, string Qw9, string Sf9)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		dESCryptoServiceProvider.Key = Encoding.ASCII.GetBytes(Sf9);
		dESCryptoServiceProvider.IV = Encoding.ASCII.GetBytes(Sf9);
		FileStream stream = new FileStream(k0E, FileMode.Open, FileAccess.Read);
		ICryptoTransform transform = dESCryptoServiceProvider.CreateDecryptor();
		CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		StreamWriter streamWriter = new StreamWriter(Qw9);
		streamWriter.Write(new StreamReader(stream2).ReadToEnd());
		streamWriter.Flush();
		streamWriter.Close();
	}

	public static void Mn4()
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

	public static void Ng1()
	{
		if (Directory.Exists(rutaAppData + "\\Mods\\" + modName + "\\ini"))
		{
			((ServerComputer)k8D5.Computer).get_FileSystem().DeleteDirectory(rutaAppData + "\\Mods\\" + modName + "\\ini", (DeleteDirectoryOption)5);
		}
		((ServerComputer)k8D5.Computer).get_FileSystem().CreateDirectory(rutaAppData + "\\Mods\\" + modName + "\\ini");
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

	public static void f5J(string m4Q)
	{
		switch (m4Q)
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

	public static void k7A(string Tc2)
	{
		switch (Tc2)
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

	public static void Cb7(string De9)
	{
		if (((ServerComputer)k8D5.Computer).get_FileSystem().DirectoryExists(ruta + rutaTemp))
		{
			DirectoryInfo directoryInfo = ((ServerComputer)k8D5.Computer).get_FileSystem().GetDirectoryInfo(De9);
			directoryInfo.Attributes = FileAttributes.Hidden;
		}
	}
}
