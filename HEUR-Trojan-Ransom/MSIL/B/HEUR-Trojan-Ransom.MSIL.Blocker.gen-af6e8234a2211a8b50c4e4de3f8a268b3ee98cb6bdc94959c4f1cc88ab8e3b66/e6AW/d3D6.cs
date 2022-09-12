using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Ak9;
using Ar7;
using Ek3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Qf0;
using Re3;
using Yb6;
using Zc7;
using j7JG;
using o5T;
using p0J;

namespace e6AW;

[StandardModule]
internal sealed class d3D6
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

	public static void Tx5k()
	{
		a6SR("c:\\temp\\test.txt", "c:\\temp\\Encrypted.txt", "%c0jm0ds");
		Tm6q("c:\\temp\\Encrypted.txt", "c:\\temp\\Decrypted.txt", "%c0jm0ds");
	}

	public static void a6SR(string x9W0, string i0XS, string Sj71)
	{
		FileStream fileStream = new FileStream(x9W0, FileMode.Open, FileAccess.Read);
		FileStream stream = new FileStream(i0XS, FileMode.Create, FileAccess.Write);
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		dESCryptoServiceProvider.Key = Encoding.ASCII.GetBytes(Sj71);
		dESCryptoServiceProvider.IV = Encoding.ASCII.GetBytes(Sj71);
		ICryptoTransform transform = dESCryptoServiceProvider.CreateEncryptor();
		CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		byte[] array = new byte[checked((int)(fileStream.Length - 1L) + 1)];
		fileStream.Read(array, 0, array.Length);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.Close();
	}

	public static void Tm6q(string Jk0e, string Rd18, string n1ET)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		dESCryptoServiceProvider.Key = Encoding.ASCII.GetBytes(n1ET);
		dESCryptoServiceProvider.IV = Encoding.ASCII.GetBytes(n1ET);
		FileStream stream = new FileStream(Jk0e, FileMode.Open, FileAccess.Read);
		ICryptoTransform transform = dESCryptoServiceProvider.CreateDecryptor();
		CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		StreamWriter streamWriter = new StreamWriter(Rd18);
		streamWriter.Write(new StreamReader(stream2).ReadToEnd());
		streamWriter.Flush();
		streamWriter.Close();
	}

	public static void Mx7c()
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

	public static void Ry90()
	{
		if (Directory.Exists(rutaAppData + "\\Mods\\" + modName + "\\ini"))
		{
			((ServerComputer)Dd8.Computer).get_FileSystem().DeleteDirectory(rutaAppData + "\\Mods\\" + modName + "\\ini", (DeleteDirectoryOption)5);
		}
		((ServerComputer)Dd8.Computer).get_FileSystem().CreateDirectory(rutaAppData + "\\Mods\\" + modName + "\\ini");
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

	public static void Zn93(string Ps7t)
	{
		switch (Ps7t)
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

	public static void Me54(string b4T2)
	{
		switch (b4T2)
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

	public static void Ea64(string x2K1)
	{
		if (((ServerComputer)Dd8.Computer).get_FileSystem().DirectoryExists(ruta + rutaTemp))
		{
			DirectoryInfo directoryInfo = ((ServerComputer)Dd8.Computer).get_FileSystem().GetDirectoryInfo(x2K1);
			directoryInfo.Attributes = FileAttributes.Hidden;
		}
	}

	static void Bj53()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ab4 ab);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr uIntPtr);
		try
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				ab = null;
				ab = ab;
			}
		}
		catch
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				Dd8 dd = dd;
				dd = dd;
			}
		}
		finally
		{
			UIntPtr num = (UIntPtr)j6Q.Default;
			uIntPtr = uIntPtr;
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num) + uIntPtr == 0)
				{
					_ = (d3D6)(object)j6Q.Default;
				}
				goto IL_006d;
			}
		}
		IL_006d:
		Xy3 xy = null;
		xy = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t3T t3T);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q4H9 q4H);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / (nuint)(UIntPtr)j6Q.Default / uIntPtr == 0)
			{
				if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
				{
					t3T = t3T;
					t3T = t3T;
				}
				else
				{
					ab = ab;
				}
			}
			else if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				_ = j6Q.Default;
			}
			else
			{
				q4H = (q4H9)(object)j6Q.Default;
				q4H = q4H;
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (Ab4)(object)j6Q.Default;
				}
				catch
				{
					q4H = null;
					_ = (_003CModule_003E)(object)j6Q.Default;
				}
			}
			catch
			{
				while (true)
				{
					obj3 = obj3;
					if (obj3 != null)
					{
						_ = j6Q.Default;
						continue;
					}
					goto end_IL_0114;
				}
				end_IL_0114:;
			}
		}
		c0W c0W = (c0W)(object)j6Q.Default;
		c0W = c0W;
		t3T = t3T;
		checked
		{
			if (uIntPtr - uIntPtr - unchecked((nuint)(UIntPtr)j6Q.Default) != 0)
			{
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a3Y a3Y);
		if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u && uIntPtr == 0)
		{
			try
			{
				_ = (c0W)(object)j6Q.Default;
				_ = (Xy3)(object)j6Q.Default;
				Dd8 dd = (Dd8)(object)j6Q.Default;
				_ = (Ab4)(object)j6Q.Default;
			}
			finally
			{
				_ = (Dd8)(object)j6Q.Default;
				a3Y = a3Y;
				a3Y = a3Y;
				goto IL_01df;
			}
		}
		goto IL_01df;
		IL_01df:
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				do
				{
					_ = (a3Y)(object)j6Q.Default;
				}
				while (obj3 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ry0 ry);
		while (obj3 != null)
		{
			ry = (Ry0)(object)j6Q.Default;
		}
		try
		{
			do
			{
				_ = (Xy3)(object)j6Q.Default;
				t3T = t3T;
				_ = (q4H9)(object)j6Q.Default;
			}
			while (obj3 != null);
		}
		catch
		{
			try
			{
				_ = (n8A)(object)j6Q.Default;
			}
			finally
			{
				try
				{
					_ = (Ab4)(object)j6Q.Default;
				}
				catch
				{
					_ = (a3Y)(object)j6Q.Default;
				}
				goto end_IL_0222;
			}
			end_IL_0222:;
		}
		_ = (Ab4)(object)j6Q.Default;
		try
		{
			a3Y = (a3Y)(object)j6Q.Default;
		}
		catch
		{
			try
			{
				q4H = q4H;
			}
			finally
			{
				_ = (c0W)(object)j6Q.Default;
				goto end_IL_026b;
			}
			end_IL_026b:;
		}
		while (obj3 != null)
		{
			while (true)
			{
				if (obj3 != null)
				{
					ry = null;
				}
				else if (obj3 == null)
				{
					break;
				}
			}
		}
		if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
		{
			_ = (d3D6)(object)j6Q.Default;
		}
		try
		{
			try
			{
				xy = xy;
			}
			catch
			{
				c0W = null;
			}
		}
		catch
		{
			do
			{
				_ = (c0W)(object)j6Q.Default;
				_ = (n8A)(object)j6Q.Default;
				ry = ry;
				xy = null;
			}
			while ((object)j6Q.Default != null || obj3 != null);
		}
		_ = (Xy3)(object)j6Q.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (q4H9)(object)j6Q.Default;
			c0W = c0W;
			_ = (Ry0)(object)j6Q.Default;
			a3Y = a3Y;
		}
		do
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u && (UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ry0)(object)j6Q.Default;
				q4H = (q4H9)(object)j6Q.Default;
				_ = (t3T)(object)j6Q.Default;
				_ = (n8A)(object)j6Q.Default;
			}
		}
		while ((object)j6Q.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n8A n8A);
		try
		{
			do
			{
				UIntPtr num2 = (UIntPtr)j6Q.Default;
				nuint num3 = uIntPtr;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num2) - (num3 - uIntPtr) != 0)
					{
						n8A = (n8A)(object)j6Q.Default;
						n8A = n8A;
					}
					else
					{
						q4H = null;
					}
				}
			}
			while ((object)j6Q.Default != null);
		}
		catch
		{
			while (true)
			{
				if (obj3 != null)
				{
					q4H = (q4H9)(object)j6Q.Default;
				}
				else if (obj3 == null)
				{
					break;
				}
			}
		}
		try
		{
			q4H = q4H;
		}
		catch
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (a3Y)(object)j6Q.Default;
				}
				else
				{
					Dd8 dd = (Dd8)(object)j6Q.Default;
				}
			}
			catch
			{
				_ = (c0W)(object)j6Q.Default;
			}
		}
		if (default(UIntPtr) != (UIntPtr)(nuint)0u || default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
		}
		j6Q j6Q = j6Q.Default;
		j6Q = j6Q;
		_ = (c0W)(object)j6Q.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					_ = (Ab4)(object)j6Q.Default;
				}
			}
			goto IL_052c;
		}
		try
		{
			n8A = n8A;
			a3Y = a3Y;
		}
		catch
		{
			xy = null;
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			while (obj3 != null)
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
				_ = (Xy3)(object)j6Q.Default;
				_003CModule_003E = (_003CModule_003E)(object)j6Q.Default;
			}
			goto IL_052c;
		}
		IL_052c:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
		}
	}

	static void Kt86()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n8A n8A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			num = default(UIntPtr);
			nuint num2 = num / (nuint)(UIntPtr)j6Q.Default;
			num = default(UIntPtr);
			num = num2 / num;
			if (num == 0)
			{
				_ = (Ry0)(object)j6Q.Default;
				n8A = n8A;
				n8A = null;
			}
		}
		catch
		{
			try
			{
				_ = (c0W)(object)j6Q.Default;
				_ = j6Q.Default;
			}
			catch
			{
				_ = (d3D6)(object)j6Q.Default;
			}
		}
		finally
		{
			_ = (Xy3)(object)j6Q.Default;
			goto IL_0085;
		}
		IL_0085:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j6Q j6Q);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				if ((object)j6Q.Default != null)
				{
					_ = (c0W)(object)j6Q.Default;
				}
				else if ((object)j6Q.Default == null)
				{
					break;
				}
			}
		}
		else
		{
			try
			{
				_003CModule_003E = (_003CModule_003E)(object)j6Q.Default;
				_003CModule_003E = _003CModule_003E;
				_ = (d3D6)(object)j6Q.Default;
				_ = (_003CModule_003E)(object)j6Q.Default;
				_ = (q4H9)(object)j6Q.Default;
			}
			catch
			{
				while (true)
				{
					obj3 = obj3;
					if (obj3 != null)
					{
						j6Q = j6Q;
						j6Q = j6Q;
						continue;
					}
					break;
				}
			}
		}
		try
		{
			if (num == 0)
			{
				_ = (Ab4)(object)j6Q.Default;
				_ = (n8A)(object)j6Q.Default;
				_ = (t3T)(object)j6Q.Default;
				j6Q = j6Q;
			}
			else
			{
				_ = (d3D6)(object)j6Q.Default;
			}
		}
		catch
		{
			do
			{
				if ((nuint)(UIntPtr)j6Q.Default / unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (t3T)(object)j6Q.Default;
				}
			}
			while ((object)j6Q.Default != null);
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				_ = (n8A)(object)j6Q.Default;
			}
			finally
			{
				_ = (Ab4)(object)j6Q.Default;
				goto IL_01c7;
			}
		}
		_ = (Xy3)(object)j6Q.Default;
		goto IL_01c7;
		IL_0500:
		Ry0 ry;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ab4 ab);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				try
				{
					ab = null;
				}
				finally
				{
					ry = ry;
					goto IL_055e;
				}
			}
			try
			{
				_ = (c0W)(object)j6Q.Default;
			}
			catch
			{
				_ = (d3D6)(object)j6Q.Default;
			}
		}
		else
		{
			_ = (Ry0)(object)j6Q.Default;
		}
		goto IL_055e;
		IL_040c:
		while (obj3 != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (c0W)(object)j6Q.Default;
				_ = (n8A)(object)j6Q.Default;
				_ = (d3D6)(object)j6Q.Default;
				continue;
			}
			try
			{
				n8A = null;
			}
			finally
			{
				_ = (Dd8)(object)j6Q.Default;
				continue;
			}
		}
		try
		{
			do
			{
				_ = (d3D6)(object)j6Q.Default;
			}
			while (obj3 != null);
		}
		finally
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ry0)(object)j6Q.Default;
			}
			goto IL_043f;
		}
		IL_043f:
		_ = (t3T)(object)j6Q.Default;
		try
		{
			while (obj3 != null)
			{
			}
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dd8 dd);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				dd = dd;
			}
			catch
			{
				_ = (d3D6)(object)j6Q.Default;
			}
		}
		num = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / checked(num * unchecked((nuint)(UIntPtr)j6Q.Default)) == 0)
		{
			try
			{
				while (obj3 != null)
				{
					dd = null;
				}
			}
			finally
			{
				do
				{
					_ = (Dd8)(object)j6Q.Default;
					ab = ab;
					_ = (t3T)(object)j6Q.Default;
					_ = (t3T)(object)j6Q.Default;
				}
				while ((object)j6Q.Default != null);
				goto IL_0500;
			}
		}
		goto IL_0500;
		IL_055e:
		while (obj3 != null)
		{
			a3Y a3Y = (a3Y)(object)j6Q.Default;
		}
		if (num == 0)
		{
			_ = (Ry0)(object)j6Q.Default;
		}
		else if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
		{
			while (obj3 != null)
			{
				_ = (d3D6)(object)j6Q.Default;
			}
		}
		_ = (c0W)(object)j6Q.Default;
		dd = null;
		while ((object)j6Q.Default != null)
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				if (num == 0)
				{
					_ = (c0W)(object)j6Q.Default;
				}
				continue;
			}
			nuint num3 = num;
			num = default(UIntPtr);
			if (checked(num3 * num) == 0)
			{
				_ = (t3T)(object)j6Q.Default;
			}
		}
		if (num == 0)
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Dd8)(object)j6Q.Default;
				}
				while ((object)j6Q.Default != null);
			}
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q4H9 q4H);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c0W c0W);
		do
		{
			try
			{
				_ = (c0W)(object)j6Q.Default;
				q4H = q4H;
				_ = j6Q.Default;
				c0W = c0W;
			}
			catch
			{
				n8A = n8A;
			}
		}
		while ((object)j6Q.Default != null);
		return;
		IL_01c7:
		do
		{
			try
			{
				_ = (t3T)(object)j6Q.Default;
			}
			finally
			{
				ry = null;
				ry = null;
				continue;
			}
		}
		while (obj3 != null);
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				try
				{
					q4H = q4H;
					q4H = q4H;
				}
				finally
				{
					_ = (t3T)(object)j6Q.Default;
					continue;
				}
			}
		}
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Xy3 xy);
			do
			{
				try
				{
					if (num * unchecked((nuint)default(UIntPtr)) == 0)
					{
						xy = xy;
						xy = null;
					}
					else
					{
						_ = (Dd8)(object)j6Q.Default;
						ry = (Ry0)(object)j6Q.Default;
						_ = j6Q.Default;
						_ = (Dd8)(object)j6Q.Default;
					}
				}
				finally
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						dd = (Dd8)(object)j6Q.Default;
						dd = null;
					}
					continue;
				}
			}
			while (obj3 != null);
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (c0W)(object)j6Q.Default;
			}
			else
			{
				try
				{
					try
					{
						_ = (Ab4)(object)j6Q.Default;
					}
					finally
					{
						xy = xy;
						_003CModule_003E = (_003CModule_003E)(object)j6Q.Default;
						_003CModule_003E = null;
						a3Y a3Y = (a3Y)(object)j6Q.Default;
						a3Y = a3Y;
						goto end_IL_02bb;
					}
					end_IL_02bb:;
				}
				catch
				{
					_ = (d3D6)(object)j6Q.Default;
					ab = ab;
					ab = ab;
				}
			}
			while (true)
			{
				if (obj3 != null)
				{
					n8A = n8A;
				}
				else if ((object)j6Q.Default == null)
				{
					break;
				}
			}
			try
			{
			}
			catch
			{
				try
				{
					c0W obj11 = (c0W)(object)j6Q.Default;
					c0W = null;
					c0W = obj11;
				}
				catch
				{
					try
					{
						_003CModule_003E = _003CModule_003E;
						goto end_IL_0352;
					}
					catch
					{
						_ = (Ab4)(object)j6Q.Default;
						goto end_IL_0352;
					}
					end_IL_0352:;
				}
			}
			_ = j6Q.Default;
			if ((num + unchecked((nuint)(UIntPtr)j6Q.Default)) * unchecked((nuint)default(UIntPtr)) == 0)
			{
				try
				{
					c0W = c0W;
				}
				finally
				{
					try
					{
						n8A = (n8A)(object)j6Q.Default;
					}
					finally
					{
						_ = (q4H9)(object)j6Q.Default;
						goto IL_040c;
					}
				}
			}
			goto IL_040c;
		}
	}
}
