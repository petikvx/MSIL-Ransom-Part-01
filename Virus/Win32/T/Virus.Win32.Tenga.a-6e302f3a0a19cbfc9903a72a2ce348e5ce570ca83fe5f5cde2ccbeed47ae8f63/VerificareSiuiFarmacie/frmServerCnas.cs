using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Xml;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using VerificareSiuiFarmacie.EPrescriptionWS;
using VerificareSiuiFarmacie.SiuiInsuredWS;
using VerificareSiuiFarmacie.SiuiWS;
using ns0;

namespace VerificareSiuiFarmacie;

public class frmServerCnas : Form
{
	private string string_0 = "";

	private X509Certificate2 x509Certificate2_0;

	private string string_1 = "";

	private string string_2 = null;

	private string string_3 = "";

	private string string_4 = "";

	private string string_5 = "";

	private string string_6 = "";

	private string string_7 = "";

	private string string_8 = "";

	private string string_9 = "";

	private bool bool_0 = false;

	private bool bool_1 = false;

	private SiuiInsuredWSService siuiInsuredWSService_0 = new SiuiInsuredWSService();

	private SiuiWSService siuiWSService_0 = new SiuiWSService();

	private EPrescriptionWSService eprescriptionWSService_0 = new EPrescriptionWSService();

	private CultureInfo cultureInfo_0 = new CultureInfo("en-US", useUserOverride: false);

	private string string_10 = "";

	private bool bool_2 = false;

	private string string_11 = "";

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Label label1;

	private Label label2;

	private TextBox txtCale;

	private TextBox txtUltimulFisierProcesat;

	private Label lblUltimulFisierProcesat;

	private Button btnReinitializareCerficare;

	private TextBox txtUltimaEroare;

	private Label lblUltimaEroare;

	private Label lblStareServer;

	private Button btnConfigurare;

	private Button btnteste;

	private NotifyIcon notifyIcon_0;

	private Button btnClose;

	private ImageList imageList_0;

	private Button btnTestRegister;

	public frmServerCnas()
	{
		InitializeComponent();
	}

	public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return true;
	}

	private void frmServerCnas_Load(object sender, EventArgs e)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		method_0();
		Class2.smethod_0();
		if (string_0 == "" || string_1 == "" || string_3 == "" || string_5 == "")
		{
			frmConfigurare frmConfigurare2 = new frmConfigurare();
			((Form)frmConfigurare2).ShowDialog();
			if ((int)((Form)frmConfigurare2).get_DialogResult() == 1)
			{
				method_0();
			}
		}
		if (!(string_0 == "") && !Directory.Exists(string_0 + "\\UltimaEReteta"))
		{
			try
			{
				Directory.CreateDirectory(string_0 + "\\UltimaEReteta");
			}
			catch (Exception ex)
			{
				method_3("Eroare creare director: " + string_0 + "\\UltimaEReteta Exception: " + ex.Message);
				((Control)txtUltimaEroare).set_Text("Eroare creare director: " + string_0 + "\\UltimaEReteta Exception: " + ex.Message);
			}
		}
		siuiInsuredWSService_0.Url = "https://www.siui.ro" + string_10 + "/svapntws/services/SiuiInsuredWS";
		siuiWSService_0.Url = "https://www.siui.ro" + string_10 + "/svapntws/services/SiuiWS";
		if (bool_2)
		{
			eprescriptionWSService_0.Url = "https://testpe.siui.ro" + string_10 + "/svapntws/services/EPrescriptionWS";
			((Control)btnteste).set_Visible(true);
		}
		else
		{
			eprescriptionWSService_0.Url = "https://sipe.siui.ro" + string_10 + "/svapntws/services/EPrescriptionWS";
			((Control)btnteste).set_Visible(false);
		}
		((WebClientProtocol)siuiInsuredWSService_0).set_Timeout(-1);
		((WebClientProtocol)siuiWSService_0).set_Timeout(-1);
		((WebClientProtocol)eprescriptionWSService_0).set_Timeout(-1);
		method_3("Deschidere Aplicatie");
		method_2();
		((Control)this).set_Text("Server CNAS - vs " + Application.get_ProductVersion());
		method_12();
	}

	private static X509Certificate2 smethod_0(StoreLocation storeLocation_0, StoreName storeName_0, X509FindType x509FindType_0, string string_12)
	{
		X509Store x509Store = new X509Store(storeName_0, storeLocation_0);
		try
		{
			x509Store.Open(OpenFlags.ReadOnly);
			X509Certificate2Collection x509Certificate2Collection = x509Store.Certificates.Find(x509FindType_0, string_12, validOnly: true);
			try
			{
				return x509Certificate2Collection[0];
			}
			catch
			{
				return null;
			}
		}
		finally
		{
			x509Store.Close();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (Directory.Exists(string_0))
		{
			timer_0.Stop();
			method_4();
			method_5(bool_3: true);
			method_5(bool_3: false);
			method_6();
			method_8();
			method_17();
			method_18();
			method_19();
			method_20();
			method_21();
			method_22();
			method_7();
			method_23();
			timer_0.Start();
		}
	}

	private void method_0()
	{
		string_0 = ConfigurationSettings.get_AppSettings()["Cale comunicatie"];
		string_1 = ConfigurationSettings.get_AppSettings()["User Token"];
		string_3 = ConfigurationSettings.get_AppSettings()["User Inregistrare Casa"];
		string_5 = ConfigurationSettings.get_AppSettings()["Licenta SIUI"];
		if (ConfigurationSettings.get_AppSettings()["Semnare fisier raportare"] != null && Enum.GetNames(typeof(TrueFalse)).Contains(ConfigurationSettings.get_AppSettings()["Semnare fisier raportare"]!.ToString().ToUpper()))
		{
			bool_1 = Convert.ToBoolean(ConfigurationSettings.get_AppSettings()["Semnare fisier raportare"]);
		}
		if (ConfigurationSettings.get_AppSettings()["Numar Serial Token"] != null)
		{
			string_2 = Class1.smethod_1(ConfigurationSettings.get_AppSettings()["Numar Serial Token"]!.ToString());
		}
		((Control)txtCale).set_Text(string_0);
		string_10 = ConfigurationSettings.get_AppSettings()["Port"];
		if (string_10 != null && string_10.Length != 0)
		{
			string_10 = ":" + string_10;
		}
		if (ConfigurationSettings.get_AppSettings()["Versiune Test"] != null && Enum.GetNames(typeof(TrueFalse)).Contains(ConfigurationSettings.get_AppSettings()["Versiune Test"]!.ToString().ToUpper()))
		{
			bool_2 = Convert.ToBoolean(ConfigurationSettings.get_AppSettings()["Versiune Test"]);
		}
	}

	private void method_1()
	{
		((Form)this).set_WindowState((FormWindowState)0);
		((Form)this).set_TopMost(true);
		((Control)this).Focus();
		((Control)this).BringToFront();
		((Form)this).set_TopMost(false);
	}

	private void method_2()
	{
		method_3("Initializare certificare");
		((Control)lblStareServer).set_Text("OFFLINE");
		bool_0 = false;
		method_12();
		timer_0.Stop();
		try
		{
			method_0();
			if (string_2 != null && string_2.Length != 0)
			{
				x509Certificate2_0 = smethod_0(StoreLocation.CurrentUser, StoreName.My, X509FindType.FindBySerialNumber, string_2);
			}
			else
			{
				x509Certificate2_0 = smethod_0(StoreLocation.CurrentUser, StoreName.My, X509FindType.FindBySubjectName, string_1);
			}
			if (x509Certificate2_0 != null)
			{
				List<string> list = Class1.smethod_0(x509Certificate2_0.Subject, "CN=");
				if (list != null && list.Count > 0)
				{
					string_6 = list[0];
				}
				string_7 = x509Certificate2_0.SerialNumber;
				_ = x509Certificate2_0.NotBefore;
				string_8 = x509Certificate2_0.NotBefore.Day.ToString().PadLeft(2, '0') + "/" + x509Certificate2_0.NotBefore.Month.ToString().PadLeft(2, '0') + "/" + x509Certificate2_0.NotBefore.Year;
				list = Class1.smethod_0(x509Certificate2_0.IssuerName.Name, " O=");
				if (list != null && list.Count > 0)
				{
					string_9 = list[0];
				}
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
				string text = "";
				text = ((!bool_2) ? string.Format("https://www.siui.ro" + string_10 + "/OCSP/validator?username={0}", string_3) : $"https://test2.siui.ro/OCSP/validator?username={string_3}");
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(text));
				new Uri(text);
				httpWebRequest.ProtocolVersion = HttpVersion.Version10;
				httpWebRequest.KeepAlive = false;
				httpWebRequest.AllowAutoRedirect = false;
				httpWebRequest.Proxy = WebRequest.GetSystemWebProxy();
				httpWebRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
				ServicePointManager.ServerCertificateValidationCallback = ValidateServerCertificate;
				ServicePointManager.Expect100Continue = false;
				httpWebRequest.ClientCertificates.Add(x509Certificate2_0);
				httpWebRequest.PreAuthenticate = true;
				string text2 = "";
				if (text2 != null)
				{
					httpWebRequest.Headers.Add("OSCP_RESPONSE", text2);
				}
				httpWebRequest.Headers.Add("OCSP_INTERNAL_BYPASS", true.ToString(CultureInfo.InvariantCulture).ToLower());
				WebResponse response = httpWebRequest.GetResponse();
				response.Headers.ToString();
				string text3 = (string_4 = response.Headers["OSCP_RESPONSE"]);
				((Control)lblStareServer).set_Text("ONLINE");
				bool_0 = true;
				method_12();
				((Control)txtUltimaEroare).set_Text("");
				method_3("Initializare cerficare - OK");
				try
				{
					if (bool_0)
					{
						((HttpWebClientProtocol)siuiInsuredWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
						((HttpWebClientProtocol)siuiWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
						((HttpWebClientProtocol)eprescriptionWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
						((WebClientProtocol)siuiInsuredWSService_0).set_PreAuthenticate(true);
						((WebClientProtocol)siuiWSService_0).set_PreAuthenticate(true);
						((WebClientProtocol)eprescriptionWSService_0).set_PreAuthenticate(true);
						((WebClientProtocol)siuiInsuredWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
						((WebClientProtocol)siuiWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
						((WebClientProtocol)eprescriptionWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
						siuiInsuredWSService_0.SessionId = string_4;
						siuiWSService_0.SessionId = string_4;
						eprescriptionWSService_0.SessionId = string_4;
						siuiInsuredWSService_0.WsUserName = string_3;
						siuiWSService_0.WsUserName = string_3;
						eprescriptionWSService_0.WsUserName = string_3;
						siuiInsuredWSService_0.WsPassword = string_5;
						siuiWSService_0.WsPassword = string_5;
						eprescriptionWSService_0.WsPassword = string_5;
						((Control)txtUltimaEroare).set_Text("");
					}
				}
				catch (Exception ex)
				{
					method_3("Eroare configurare WebServiciu: " + ex.Message);
					((Control)txtUltimaEroare).set_Text("Eroare configurare WebServiciu " + ex.Message);
					bool_0 = false;
					method_12();
					((Control)lblStareServer).set_Text("OFFLINE");
					method_1();
				}
			}
			else
			{
				method_3("Eroare certificare(jeton null) - verificati corectitudinea instalarii");
				((Control)txtUltimaEroare).set_Text("Eroare certificare(jeton null) - verificati corectitudinea instalarii");
				method_1();
			}
		}
		catch (WebException ex2)
		{
			if (ex2.Status.ToString().ToUpper() != "TIMEOUT")
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex2.Response;
				string text4 = "";
				text4 = string.Concat("Eroare certificare: ", Environment.NewLine, "   Mesaj Eroare:                       ", ex2.Message, Environment.NewLine, "   Status Eroare:                      ", ex2.Status, Environment.NewLine);
				if (httpWebResponse != null)
				{
					object obj = text4;
					text4 = string.Concat(obj, "   HttpWebResponse.CharacterSet:       ", httpWebResponse.CharacterSet, Environment.NewLine, "   HttpWebResponse.ContentEncoding:    ", httpWebResponse.ContentEncoding, Environment.NewLine, "   HttpWebResponse.ContentLength:      ", httpWebResponse.ContentLength.ToString(), Environment.NewLine, "   HttpWebResponse.ContentType:        ", httpWebResponse.ContentType, Environment.NewLine, "   HttpWebResponse.Method:             ", httpWebResponse.Method, Environment.NewLine, "   HttpWebResponse.ProtocolVersion:    ", httpWebResponse.ProtocolVersion.ToString(), Environment.NewLine, "   HttpWebResponse.ResponseUri:        ", httpWebResponse.ResponseUri.ToString(), Environment.NewLine, "   HttpWebResponse.Server:             ", httpWebResponse.Server, Environment.NewLine, "   HttpWebResponse.StatusCode:         ", httpWebResponse.StatusCode, Environment.NewLine, "   HttpWebResponse.StatusDescription:  ", httpWebResponse.StatusDescription, Environment.NewLine);
				}
				method_3(text4);
			}
			((Control)txtUltimaEroare).set_Text("Eroare certificare(" + ex2.Message + ")");
			method_1();
		}
		catch (Exception ex)
		{
			method_3("Eroare certificare(" + ex.Message + ")");
			((Control)txtUltimaEroare).set_Text("Eroare certificare(" + ex.Message + ")");
			method_1();
		}
		timer_0.Start();
	}

	private void method_3(string string_12)
	{
		string text = "";
		string text2 = "";
		text2 = Directory.GetCurrentDirectory() + "\\Log";
		if (!Directory.Exists(text2))
		{
			try
			{
				Directory.CreateDirectory(text2);
			}
			catch (Exception ex)
			{
				((Control)txtUltimaEroare).set_Text("Eroare creare director log(" + ex.Message + ")");
				return;
			}
		}
		text = text2 + "\\Log" + DateTime.Now.Year + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') + ".log";
		StreamWriter streamWriter = File.AppendText(text);
		streamWriter.WriteLine(DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Second.ToString().PadLeft(2, '0') + "    " + string_12);
		streamWriter.Flush();
		streamWriter.Close();
	}

	private void btnReinitializareCerficare_Click(object sender, EventArgs e)
	{
		int num = 0;
		do
		{
			num++;
			method_2();
		}
		while (num < 3 && !bool_0);
	}

	private void lblStareServer_TextChanged(object sender, EventArgs e)
	{
		if (((Control)lblStareServer).get_Text().ToUpper() == "ONLINE")
		{
			((Control)lblStareServer).set_ForeColor(Color.Green);
		}
		else
		{
			((Control)lblStareServer).set_ForeColor(Color.Red);
		}
	}

	private void btnConfigurare_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		frmConfigurare frmConfigurare2 = new frmConfigurare(bool_0);
		((Form)frmConfigurare2).ShowDialog();
		if ((int)((Form)frmConfigurare2).get_DialogResult() == 1)
		{
			method_0();
		}
	}

	private void method_4()
	{
		string[] files = Directory.GetFiles(string_0, "CNP*.send");
		string text = "";
		if (files.Length == 0)
		{
			return;
		}
		string[] array = files;
		foreach (string text2 in array)
		{
			if (!File.Exists(text2) || Class3.smethod_0(text2))
			{
				continue;
			}
			bool flag = false;
			string text3 = text2;
			((Control)txtUltimulFisierProcesat).set_Text(text2);
			method_3("Prelucrare fisier: " + text2);
			if (File.Exists(text3.Replace(".send", ".scnas")))
			{
				File.Delete(text3.Replace(".send", ".scnas"));
			}
			File.Move(text3, text3.Replace(".send", ".scnas"));
			text3 = text3.Replace(".send", ".scnas");
			try
			{
				if (bool_0)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(text3);
					foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
					{
						if (flag)
						{
							continue;
						}
						string xml = "";
						int num = 0;
						bool flag2 = false;
						try
						{
							DateTime dateTime = default(DateTime);
							dateTime = ((childNode.Attributes!["DataEtalon"] == null || string.IsNullOrEmpty(childNode.Attributes!["DataEtalon"]!.Value)) ? DateTime.Now : Convert.ToDateTime(childNode.Attributes!["DataEtalon"]!.Value.ToString(), cultureInfo_0));
							method_3("Verificare CNP: apel getInsured(" + childNode.Attributes!["CNPValue"]!.Value.ToString() + ", " + dateTime.ToShortDateString() + ")");
							do
							{
								num++;
								try
								{
									xml = siuiInsuredWSService_0.getInsured(childNode.Attributes!["CNPValue"]!.Value.ToString(), dateTime);
									method_3("Verificare CNP: Apel getInsured incheiat cu succes");
									flag2 = true;
								}
								catch (Exception ex)
								{
									if (num < 3 && ex.Message.ToUpper().Contains("UNAUTHORIZED"))
									{
										int num2 = 0;
										do
										{
											num2++;
											method_2();
										}
										while (num2 < 3 && !bool_0);
										if (bool_0)
										{
											((HttpWebClientProtocol)siuiInsuredWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
											((WebClientProtocol)siuiInsuredWSService_0).set_PreAuthenticate(true);
											((WebClientProtocol)siuiInsuredWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
											siuiInsuredWSService_0.SessionId = string_4;
											siuiInsuredWSService_0.WsUserName = string_3;
											siuiInsuredWSService_0.WsPassword = string_5;
											((Control)txtUltimaEroare).set_Text("");
										}
									}
									if (num == 3)
									{
										method_3("Fisier " + text2 + " Eroare apel WebServiciu(Verificare CNP Asigurat): " + ex.Message);
										((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Verificare CNP Asigurat): " + ex.Message);
										text = "CNP: " + childNode.Attributes!["CNPValue"]!.Value.ToString() + Environment.NewLine + ex.Message;
										method_1();
									}
								}
							}
							while (num < 3 && !flag2);
							if (flag2)
							{
								XmlDocument xmlDocument2 = new XmlDocument();
								xmlDocument2.LoadXml(xml);
								XmlElement xmlElement = (XmlElement)childNode;
								foreach (XmlNode childNode2 in xmlDocument2.DocumentElement!.ChildNodes)
								{
									string text4 = "";
									string text5 = "";
									string text6 = "";
									string text7 = "";
									string text8 = "";
									foreach (XmlAttribute item in childNode2.Attributes!)
									{
										if (item.Name.ToUpper() != "PID")
										{
											xmlElement.SetAttribute(item.Name, item.Value);
										}
										else
										{
											text7 = item.Value;
										}
										if (item.Name.ToUpper() == "STATE")
										{
											text4 = item.Value;
										}
									}
									foreach (XmlNode childNode3 in childNode2.ChildNodes)
									{
										XmlNode newChild = xmlDocument.ImportNode(childNode3, deep: true);
										xmlElement.AppendChild(newChild);
										if (childNode3.Name.ToUpper() == "STATES" && childNode3.ChildNodes.Count >= 0)
										{
											if (childNode3.ChildNodes.Item(0)!.Attributes!["code"] != null)
											{
												text5 = childNode3.ChildNodes.Item(0)!.Attributes!["code"]!.Value.ToString();
											}
											if (childNode3.ChildNodes.Item(0)!.Attributes!["validFrom"] != null)
											{
												text6 = childNode3.ChildNodes.Item(0)!.Attributes!["validFrom"]!.Value.ToString();
											}
										}
									}
									text8 = "Raspuns server CNP=" + text7 + " Stare=" + text4 + " Categorie=" + text5 + " Valid din=" + text6;
									method_3(text8);
								}
							}
							else
							{
								flag = true;
							}
						}
						catch (Exception ex2)
						{
							method_3("Fisier " + text2 + " Eroare apel WebServiciu(Verificare CNP Asigurat): " + ex2.Message);
							((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Verificare CNP Asigurat): " + ex2.Message);
							method_1();
							flag = true;
							text = "Eroare: " + ex2.Message;
						}
					}
					if (!flag && File.Exists(text3))
					{
						xmlDocument.Save(text3);
					}
				}
				else
				{
					text = "Eroare: Server Offline.";
				}
			}
			catch (Exception ex2)
			{
				method_3("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				text = "Eroare: " + ex2.Message;
				method_1();
				flag = true;
			}
			if (!flag && bool_0)
			{
				if (!File.Exists(text2) && File.Exists(text3))
				{
					if (File.Exists(text3.Replace(".scnas", ".recv")))
					{
						File.Delete(text3.Replace(".scnas", ".recv"));
					}
					File.Move(text3, text3.Replace(".scnas", ".recv"));
				}
			}
			else if (!File.Exists(text2) && File.Exists(text3))
			{
				if (File.Exists(text3.Replace(".scnas", ".err")))
				{
					File.Delete(text3.Replace(".scnas", ".err"));
				}
				File.Delete(text3);
				Class1.smethod_2(text, text3.Replace(".scnas", ".err"));
			}
		}
	}

	private void method_5(bool bool_3)
	{
		string text = "";
		text = (bool_3 ? "FARME*.xml" : "FARMD*.xml");
		string[] files = Directory.GetFiles(string_0, text);
		if (files.Length == 0)
		{
			return;
		}
		string text2 = "";
		string[] array = files;
		foreach (string text3 in array)
		{
			if (!File.Exists(text3) || Class3.smethod_0(text3))
			{
				continue;
			}
			bool flag = false;
			((Control)txtUltimulFisierProcesat).set_Text(text3);
			method_3("Prelucrare fisier: " + text3);
			if (!bool_3)
			{
				method_15(text3);
			}
			if (bool_0)
			{
				if (bool_1)
				{
					method_3("Semnare fisier " + Path.GetFileName(text3));
					if (!method_11(text3, text3, x509Certificate2_0))
					{
						flag = true;
					}
				}
				if (!flag && method_13(text3) && File.Exists(text3.Replace(".xml", ".zip")))
				{
					int num = 0;
					bool flag2 = false;
					string text4 = "";
					FileStream fileStream = new FileStream(text3.Replace(".xml", ".zip"), FileMode.Open, FileAccess.Read);
					byte[] array2 = new byte[fileStream.Length];
					fileStream.Read(array2, 0, Convert.ToInt32(fileStream.Length));
					string reportXML = Convert.ToBase64String(array2);
					text4 = "FARMD";
					method_3("Trimitere fisier raportare: apel sendReport(" + text4 + ",ecodingData)");
					do
					{
						num++;
						try
						{
							text4 = (bool_3 ? "FARME" : "FARMD");
							siuiWSService_0.sendReport(text4, reportXML);
							method_3("Trimitere fisier raportare: apel sendReport incheiat cu succes");
							flag2 = true;
						}
						catch (Exception ex)
						{
							if (num < 3 && ex.Message.ToUpper().Contains("UNAUTHORIZED"))
							{
								int num2 = 0;
								do
								{
									num2++;
									method_2();
								}
								while (num2 < 3 && !bool_0);
								if (bool_0)
								{
									((HttpWebClientProtocol)siuiWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
									((WebClientProtocol)siuiWSService_0).set_PreAuthenticate(true);
									((WebClientProtocol)siuiWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
									siuiWSService_0.SessionId = string_4;
									siuiWSService_0.WsUserName = string_3;
									siuiWSService_0.WsPassword = string_5;
									((Control)txtUltimaEroare).set_Text("");
								}
							}
							if (num == 3)
							{
								method_3("Fisier " + text3 + " Eroare apel WebServiciu(Trimitere raportare): " + ex.Message);
								((Control)txtUltimaEroare).set_Text("Fisier " + text3 + " Eroare apel WebServiciu(Trimitere raportare): " + ex.Message);
								method_1();
								text2 = Path.GetFileName(text3) + Environment.NewLine + "Eroare: " + ex.Message;
							}
						}
					}
					while (num < 3 && !flag2);
					fileStream.Close();
					if (!flag2)
					{
						flag = true;
					}
				}
			}
			else
			{
				flag = true;
				text2 = "Eroare: Server Offline.";
			}
			if (flag)
			{
				if (File.Exists(text3))
				{
					if (File.Exists(text3.Replace(".xml", ".xml.err")))
					{
						File.Delete(text3.Replace(".xml", ".xml.err"));
					}
					File.Delete(text3);
					Class1.smethod_2(text2, text3.Replace(".xml", ".xml.err"));
				}
			}
			else if (File.Exists(text3))
			{
				if (File.Exists(text3.Replace(".xml", ".xml.ok")))
				{
					File.Delete(text3.Replace(".xml", ".xml.ok"));
				}
				File.Move(text3, text3.Replace(".xml", ".xml.ok"));
			}
			if (File.Exists(text3.Replace(".xml", ".zip")))
			{
				File.Delete(text3.Replace(".xml", ".zip"));
			}
		}
	}

	private void btnteste_Click(object sender, EventArgs e)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DateTime prescriptionDate = new DateTime(2012, 6, 29);
			eprescriptionWSService_0.getPrescribedPrescription("20423730", "104295", "21527", "", "CAS-BT", "NBNA", "1001619", prescriptionDate);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void notifyIcon_0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() == 1)
		{
			((Control)this).Show();
			((Form)this).set_WindowState((FormWindowState)0);
			((Control)this).set_Width(468);
			((Control)this).set_Height(348);
		}
		((Form)this).Activate();
	}

	private void frmServerCnas_Resize(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if ((int)((Form)this).get_WindowState() == 1)
		{
			if (!bool_0)
			{
				MessageBox.Show("Atentie! Server-ul este offline. Verificati mai tarziu daca a redevenit online!", "Atentie", (MessageBoxButtons)0);
			}
			((Control)this).Hide();
		}
	}

	private void method_6()
	{
		string[] files = Directory.GetFiles(string_0, "*.rez");
		if (files.Length == 0)
		{
			return;
		}
		string text = "";
		string[] array = files;
		foreach (string text2 in array)
		{
			if (!File.Exists(text2) || Class3.smethod_0(text2))
			{
				continue;
			}
			bool flag = false;
			string text3 = text2;
			((Control)txtUltimulFisierProcesat).set_Text(text2);
			method_3("Prelucrare fisier: " + text2);
			if (File.Exists(text3.Replace(".rez", ".scnas")))
			{
				File.Delete(text3.Replace(".rez", ".scnas"));
			}
			File.Move(text3, text3.Replace(".rez", ".scnas"));
			text3 = text3.Replace(".rez", ".scnas");
			try
			{
				if (bool_0)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(text3);
					foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
					{
						if (childNode.Attributes!.GetNamedItem("Value") == null)
						{
							continue;
						}
						bool flag2 = false;
						int num = 0;
						method_3("Preluare rezultat raportare: apel getReportFeedback(" + childNode.Attributes!.GetNamedItem("Value")!.Value + ".xml)");
						do
						{
							num++;
							try
							{
								string[] reportFeedback = siuiWSService_0.getReportFeedback(childNode.Attributes!.GetNamedItem("Value")!.Value + ".xml");
								method_3("Preluare rezultat raportare: apel getReportFeedback incheiat cu succes");
								flag2 = true;
								if (reportFeedback.Length == 2)
								{
									string string_ = "";
									if (method_9("https://www.siui.ro" + string_10 + reportFeedback[0], ref string_, bool_3: true))
									{
										childNode.InnerText = string_;
										continue;
									}
									flag = true;
									text = Path.GetFileName(text2) + Environment.NewLine + "Eroare apel getReportFeedback. Nu s-putut prelua fisierul de raspuns.";
								}
								else
								{
									text = Path.GetFileName(text2) + Environment.NewLine + "Eroare apel getReportFeedback. Nu s-au primit parametrii pentru download fisier prelucrare.";
								}
							}
							catch (Exception ex)
							{
								if (num < 3 && ex.Message.ToUpper().Contains("UNAUTHORIZED"))
								{
									int num2 = 0;
									do
									{
										num2++;
										method_2();
									}
									while (num2 < 3 && !bool_0);
									if (bool_0)
									{
										((HttpWebClientProtocol)siuiWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
										((WebClientProtocol)siuiWSService_0).set_PreAuthenticate(true);
										((WebClientProtocol)siuiWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
										siuiWSService_0.SessionId = string_4;
										siuiWSService_0.WsUserName = string_3;
										siuiWSService_0.WsPassword = string_5;
										((Control)txtUltimaEroare).set_Text("");
									}
								}
								if (num == 3)
								{
									method_3("Fisier " + text2 + " Eroare apel WebServiciu(getReportFeedback): " + ex.Message);
									((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(getReportFeedback): " + ex.Message);
									method_1();
									flag = true;
									text = Path.GetFileName(text2) + Environment.NewLine + "Eroare: " + ex.Message;
								}
							}
						}
						while (!flag2 && num < 3);
					}
					if (!flag)
					{
						xmlDocument.Save(text3);
					}
				}
				else
				{
					text = "Eroare: Server Offline.";
				}
			}
			catch (Exception ex2)
			{
				method_3("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				method_1();
				flag = true;
				text = Path.GetFileName(text2) + Environment.NewLine + "Eroare: " + ex2.Message;
			}
			if (!flag && bool_0)
			{
				if (!File.Exists(text2) && File.Exists(text3))
				{
					if (File.Exists(text3.Replace(".scnas", ".rez.ok")))
					{
						File.Delete(text3.Replace(".scnas", ".rez.ok"));
					}
					File.Move(text3, text3.Replace(".scnas", ".rez.ok"));
				}
			}
			else if (!File.Exists(text2) && File.Exists(text3))
			{
				if (File.Exists(text3.Replace(".scnas", ".rez.err")))
				{
					File.Delete(text3.Replace(".scnas", ".rez.err"));
				}
				File.Delete(text3);
				Class1.smethod_2(text, text3.Replace(".scnas", ".rez.err"));
			}
		}
	}

	private void method_7()
	{
		string[] files = Directory.GetFiles(string_0, "*.reg");
		if (files.Length == 0)
		{
			return;
		}
		bool flag = false;
		string text = "";
		string text2 = "";
		string[] array = null;
		bool flag2 = false;
		int num = 0;
		int num2 = 0;
		string text3 = "";
		string[] array2 = files;
		foreach (string text4 in array2)
		{
			if (!File.Exists(text4) || Class3.smethod_0(text4))
			{
				continue;
			}
			flag = false;
			text = text4;
			((Control)txtUltimulFisierProcesat).set_Text(text4);
			method_3("Prelucrare fisier: " + text4);
			text2 = Path.ChangeExtension(text, "scnas");
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Move(text, text2);
			text = text2;
			try
			{
				if (bool_0)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(text);
					foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
					{
						array = null;
						if (childNode.Attributes!.GetNamedItem("Value") == null)
						{
							continue;
						}
						flag2 = false;
						num = 0;
						method_3("Preluare sume facturare raportare: apel getRegisterFeedback(" + childNode.Attributes!.GetNamedItem("Value")!.Value + ".xml)");
						while (!flag2 && num < 3)
						{
							try
							{
								array = siuiWSService_0.getRegisterFeedback(childNode.Attributes!.GetNamedItem("Value")!.Value + ".xml");
								flag2 = true;
								method_3("Preluare sume facturare raportare: apel getRegisterFeedback incheiat cu succes");
								if (array.Length == 2)
								{
									string string_ = "";
									if (method_9("https://www.siui.ro" + string_10 + array[0], ref string_, bool_3: true))
									{
										childNode.InnerText = string_;
									}
									else
									{
										flag = true;
										text3 = Path.GetFileName(text4) + Environment.NewLine + "Nu s-a putut downloda fisierul cu sumele facturate raportate";
									}
								}
							}
							catch (Exception ex)
							{
								if (num < 2 && ex.Message.ToUpper().Contains("UNAUTHORIZED"))
								{
									for (num2 = 0; num2 < 3; num2++)
									{
										if (bool_0)
										{
											break;
										}
										method_2();
									}
									if (bool_0)
									{
										((HttpWebClientProtocol)siuiWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
										((WebClientProtocol)siuiWSService_0).set_PreAuthenticate(true);
										((WebClientProtocol)siuiWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
										siuiWSService_0.SessionId = string_4;
										siuiWSService_0.WsUserName = string_3;
										siuiWSService_0.WsPassword = string_5;
										((Control)txtUltimaEroare).set_Text("");
									}
								}
								if (num == 2)
								{
									method_3("Fisier " + text4 + " Eroare apel WebServiciu(getRegisterFeedback): " + ex.Message);
									((Control)txtUltimaEroare).set_Text("Fisier " + text4 + " Eroare apel WebServiciu(getRegisterFeedback): " + ex.Message);
									method_1();
									flag = true;
									text3 = Path.GetFileName(text4) + Environment.NewLine + "Eroare" + ex.Message;
								}
							}
							num++;
						}
					}
					if (!flag)
					{
						xmlDocument.Save(text);
					}
				}
				else
				{
					text3 = "Eroare: Server offline";
				}
			}
			catch (Exception ex2)
			{
				method_3("Fisier " + text4 + " Eroare prelucrare fisier: " + ex2.Message);
				((Control)txtUltimaEroare).set_Text("Fisier " + text4 + " Eroare prelucrare fisier: " + ex2.Message);
				method_1();
				flag = true;
				text3 = Path.GetFileName(text4) + Environment.NewLine + "Eroare prelucrare fisier: " + ex2.Message;
			}
			if (!File.Exists(text4) && File.Exists(text))
			{
				text2 = Path.ChangeExtension(text, "reg." + ((flag || !bool_0) ? "err" : "ok"));
				if (File.Exists(text2))
				{
					File.Delete(text2);
				}
				if (!flag && bool_0)
				{
					File.Move(text, text2);
					continue;
				}
				File.Delete(text);
				Class1.smethod_2(text3, text2);
			}
		}
	}

	private void method_8()
	{
		string[] files = Directory.GetFiles(string_0, "*.dec");
		if (files.Length == 0)
		{
			return;
		}
		string text = "";
		if (!method_14())
		{
			return;
		}
		string[] array = files;
		foreach (string text2 in array)
		{
			if (!File.Exists(text2) || Class3.smethod_0(text2))
			{
				continue;
			}
			bool flag = false;
			((Control)txtUltimulFisierProcesat).set_Text(text2);
			string text3 = text2.Replace(".dec", ".dec.tmp");
			method_3("Prelucrare fisier " + text2);
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			File.Move(text2, text3);
			try
			{
				if (bool_0)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(text3);
					foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
					{
						bool flag2 = false;
						int num = 0;
						method_3("Preluare decont: apel getRefund(FARM," + childNode.Attributes!["startDate"]!.Value.ToString() + ", " + childNode.Attributes!["endDate"]!.Value.ToString() + ", " + childNode.Attributes!["uic"]!.Value.ToString() + ")");
						do
						{
							num++;
							try
							{
								string[] refund = siuiWSService_0.getRefund("FARM", Convert.ToDateTime(childNode.Attributes!["startDate"]!.Value.ToString(), cultureInfo_0), Convert.ToDateTime(childNode.Attributes!["endDate"]!.Value.ToString(), cultureInfo_0), childNode.Attributes!["uic"]!.Value.ToString());
								method_3("Preluare decont: apel getRefund incheiat cu succes");
								if (refund.Length == 2 && refund[0].Length != 0)
								{
									string string_ = "";
									if (method_9("https://www.siui.ro" + string_10 + refund[0], ref string_, bool_3: true))
									{
										childNode.InnerText = string_;
										flag2 = true;
										try
										{
											File.Delete(text2.Replace(".dec", ".zip"));
										}
										catch (Exception ex)
										{
											method_3("Eroare stergere fisier" + text2.Replace(".dec", ".zip") + "(" + ex.Message + ")");
										}
										try
										{
											File.Delete(text2.Replace(".dec", ".pdf"));
										}
										catch (Exception ex)
										{
											method_3("Eroare stergere fisier" + text2.Replace(".dec", ".pdf") + "(" + ex.Message + ")");
										}
									}
									else
									{
										flag = true;
										method_3("Eroare download fisiere decont dupa obtinerea adresei de download");
										((Control)txtUltimaEroare).set_Text("Eroare download fisiere decont dupa obtinerea adresei de download");
										text = Path.GetFileName(text2) + Environment.NewLine + "Eroare download fisiere decont dupa obtinerea adresei de download";
									}
								}
								else if (num == 3)
								{
									flag = true;
									if (refund.Length != 2)
									{
										method_3("WebServiciul getRefound a intors un vector cu dimensiune diferita de 2.");
										((Control)txtUltimaEroare).set_Text("WebServiciul getRefound a intors un vector cu dimensiune diferita de 2.");
										text = Path.GetFileName(text2) + Environment.NewLine + "WebServiciul getRefound a intors un vector cu dimensiune diferita de 2.";
									}
									else
									{
										method_3("WebServiciul getRefound a intors un vector fara adresa de download.");
										((Control)txtUltimaEroare).set_Text("WebServiciul getRefound a intors un vector fara adresa de download.");
										text = Path.GetFileName(text2) + Environment.NewLine + "WebServiciul getRefound a intors un vector fara adresa de download.";
									}
								}
							}
							catch (Exception ex2)
							{
								if (num < 3 && ex2.Message.ToUpper().Contains("UNAUTHORIZED"))
								{
									int num2 = 0;
									do
									{
										num2++;
										method_2();
									}
									while (num2 < 3 && !bool_0);
									if (bool_0)
									{
										((HttpWebClientProtocol)siuiWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
										((WebClientProtocol)siuiWSService_0).set_PreAuthenticate(true);
										((WebClientProtocol)siuiWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
										siuiWSService_0.SessionId = string_4;
										siuiWSService_0.WsUserName = string_3;
										siuiWSService_0.WsPassword = string_5;
										((Control)txtUltimaEroare).set_Text("");
									}
								}
								if (num == 3)
								{
									method_3("Fisier " + text2 + " Eroare apel WebServiciu(getRefund): " + ex2.Message);
									((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(getRefund): " + ex2.Message);
									text = Path.GetFileName(text2) + Environment.NewLine + "Eroare: " + ex2.Message;
									method_1();
									flag = true;
								}
							}
						}
						while (!flag2 && num < 3);
						if (!flag)
						{
							xmlDocument.Save(text3);
						}
					}
				}
				else
				{
					text = "Eroare: Server offline";
				}
			}
			catch (Exception ex3)
			{
				method_3("Fisier " + text2 + ". Eroare prelucrare fisier: " + ex3.Message);
				((Control)txtUltimaEroare).set_Text("Fisier " + text2 + ". Eroare prelucrare fisier: " + ex3.Message);
				method_1();
				flag = true;
				text = Path.GetFileName(text2) + Environment.NewLine + "Eroare: " + ex3.Message;
			}
			if (!flag && bool_0)
			{
				method_3("Fisier " + text2 + ". Preluare decont finalizata cu succes.");
				if (!File.Exists(text2))
				{
					if (File.Exists(text3.Replace(".tmp", ".ok")))
					{
						File.Delete(text3.Replace(".tmp", ".ok"));
					}
					File.Move(text3, text3.Replace(".tmp", ".ok"));
				}
				continue;
			}
			method_3("Fisier " + text2 + ". Decontul nu a putut fi preluat.");
			if (!File.Exists(text2))
			{
				if (File.Exists(text3.Replace(".tmp", ".err")))
				{
					File.Delete(text3.Replace(".tmp", ".err"));
				}
				File.Delete(text3);
				Class1.smethod_2(text, text3.Replace(".tmp", ".err"));
			}
		}
	}

	private bool method_9(string string_12, ref string string_13, bool bool_3)
	{
		bool result = false;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(string_12));
		httpWebRequest.Accept = "*/*";
		httpWebRequest.KeepAlive = false;
		httpWebRequest.AllowAutoRedirect = false;
		httpWebRequest.PreAuthenticate = true;
		httpWebRequest.Proxy = WebRequest.GetSystemWebProxy();
		httpWebRequest.ClientCertificates.Add(x509Certificate2_0);
		CredentialCache credentialCache = new CredentialCache();
		ServicePointManager.Expect100Continue = false;
		credentialCache.Add(new Uri(string_12), "Basic", new NetworkCredential(string_3, string_5));
		httpWebRequest.Credentials = credentialCache;
		httpWebRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
		httpWebRequest.Headers.Add("OSCP_RESPONSE", string_4);
		try
		{
			using (WebResponse webResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				byte[] array = ReadFully(webResponse.GetResponseStream());
				if (bool_3)
				{
					string_13 = Convert.ToBase64String(array);
				}
				else
				{
					string_13 = Encoding.GetEncoding(1251).GetString(array);
				}
			}
			result = true;
			return result;
		}
		catch (Exception ex)
		{
			method_3("Eroare Download fisier rezultat raportare URL: " + string_12 + " Mesaj Eroare" + ex.Message);
			return result;
		}
	}

	private byte[] method_10(string string_12)
	{
		byte[] result = null;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(string_12));
		httpWebRequest.Accept = "*/*";
		httpWebRequest.KeepAlive = false;
		httpWebRequest.AllowAutoRedirect = false;
		httpWebRequest.PreAuthenticate = true;
		httpWebRequest.Proxy = WebRequest.GetSystemWebProxy();
		httpWebRequest.ClientCertificates.Add(x509Certificate2_0);
		CredentialCache credentialCache = new CredentialCache();
		ServicePointManager.Expect100Continue = false;
		credentialCache.Add(new Uri(string_12), "Basic", new NetworkCredential(string_3, string_5));
		httpWebRequest.Credentials = credentialCache;
		httpWebRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
		httpWebRequest.Headers.Add("OSCP_RESPONSE", string_4);
		try
		{
			using WebResponse webResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			result = ReadFully(webResponse.GetResponseStream());
		}
		catch (Exception ex)
		{
			method_3("Eroare Download fisier rezultat raportare URL: " + string_12 + " Mesaj Eroare" + ex.Message);
		}
		return result;
	}

	private bool method_11(string string_12, string string_13, X509Certificate2 x509Certificate2_1)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		try
		{
			byte[] array = File.ReadAllBytes(string_12);
			ContentInfo val = new ContentInfo(array);
			SignedCms val2 = new SignedCms(val, false);
			CmsSigner val3 = new CmsSigner(x509Certificate2_1);
			val2.ComputeSignature(val3);
			byte[] array2 = val2.Encode();
			FileStream fileStream;
			try
			{
				fileStream = ((!new FileInfo(string_13).Exists) ? new FileStream(string_13, FileMode.OpenOrCreate) : new FileStream(string_13, FileMode.Truncate));
			}
			catch
			{
				fileStream = new FileStream(string_13, FileMode.OpenOrCreate);
				return false;
			}
			byte[] array3 = array2;
			foreach (byte value in array3)
			{
				fileStream.WriteByte(value);
			}
			fileStream.Flush();
			fileStream.Close();
			fileStream = null;
		}
		catch (Exception ex)
		{
			method_3("Eroare semnare fisier XML(" + ex.Message + ")");
			((Control)txtUltimaEroare).set_Text("Eroare semnare fisier XML(" + ex.Message + ")");
			return false;
		}
		return true;
	}

	public static byte[] ReadFully(Stream input)
	{
		byte[] array = new byte[16384];
		using MemoryStream memoryStream = new MemoryStream();
		int count;
		while ((count = input.Read(array, 0, array.Length)) > 0)
		{
			memoryStream.Write(array, 0, count);
		}
		return memoryStream.ToArray();
	}

	private void frmServerCnas_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() != 1)
		{
			((Form)this).set_WindowState((FormWindowState)1);
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		frmMsgClose frmMsgClose2 = new frmMsgClose();
		DialogResult val = ((Form)frmMsgClose2).ShowDialog();
		if ((int)val != 2)
		{
			if ((int)val == 6)
			{
				Process.GetCurrentProcess().Kill();
			}
		}
		else
		{
			((Form)this).set_WindowState((FormWindowState)1);
		}
	}

	private void notifyIcon_0_BalloonTipShown(object sender, EventArgs e)
	{
	}

	private void method_12()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		if (bool_0)
		{
			notifyIcon_0.set_Text("Server CNAS - ONLINE");
			((Form)this).set_Icon(Icon.FromHandle(((Bitmap)imageList_0.get_Images().get_Item(0)).GetHicon()));
			notifyIcon_0.set_Icon(Icon.FromHandle(((Bitmap)imageList_0.get_Images().get_Item(0)).GetHicon()));
		}
		else
		{
			notifyIcon_0.set_Text("Server CNAS - OFFLINE");
			((Form)this).set_Icon(Icon.FromHandle(((Bitmap)imageList_0.get_Images().get_Item(1)).GetHicon()));
			notifyIcon_0.set_Icon(Icon.FromHandle(((Bitmap)imageList_0.get_Images().get_Item(1)).GetHicon()));
		}
	}

	private void frmServerCnas_MinimumSizeChanged(object sender, EventArgs e)
	{
	}

	private void frmServerCnas_SizeChanged(object sender, EventArgs e)
	{
	}

	private void frmServerCnas_ResizeBegin(object sender, EventArgs e)
	{
	}

	private bool method_13(string string_12)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		try
		{
			ZipOutputStream val = new ZipOutputStream((Stream)File.Create(string_12.Replace(".xml", ".zip")));
			FileInfo fileInfo = new FileInfo(string_12);
			ZipEntry val2 = new ZipEntry(fileInfo.Name);
			FileStream fileStream = File.OpenRead(string_12);
			byte[] array = new byte[Convert.ToInt32(fileStream.Length)];
			fileStream.Read(array, 0, (int)fileStream.Length);
			val2.set_DateTime(fileInfo.LastWriteTime);
			val2.set_Size(fileStream.Length);
			fileStream.Close();
			val.PutNextEntry(val2);
			((Stream)(object)val).Write(array, 0, array.Length);
			((DeflaterOutputStream)val).Finish();
			((Stream)(object)val).Close();
		}
		catch (Exception ex)
		{
			method_3("Eroare creare arhiva zip " + Path.GetFileName(string_12) + ". Mesaj eroare: " + ex.Message);
			((Control)txtUltimaEroare).set_Text("Eroare arhivare zip " + Path.GetFileName(string_12) + ". Mesaj eroare: " + ex.Message);
			return false;
		}
		return true;
	}

	public void ExtractZipFile(string archiveFilenameIn, string password, string outFolder)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		ZipFile val = null;
		try
		{
			FileStream fileStream = File.OpenRead(archiveFilenameIn);
			val = new ZipFile(fileStream);
			if (!string.IsNullOrEmpty(password))
			{
				val.set_Password(password);
			}
			foreach (ZipEntry item in val)
			{
				ZipEntry val2 = item;
				if (val2.get_IsFile())
				{
					string name = val2.get_Name();
					byte[] array = new byte[4096];
					Stream inputStream = val.GetInputStream(val2);
					string path = Path.Combine(outFolder, name);
					string directoryName = Path.GetDirectoryName(path);
					if (directoryName.Length > 0)
					{
						Directory.CreateDirectory(directoryName);
					}
					using FileStream fileStream2 = File.Create(path);
					StreamUtils.Copy(inputStream, (Stream)fileStream2, array);
				}
			}
		}
		finally
		{
			if (val != null)
			{
				val.set_IsStreamOwner(true);
				val.Close();
			}
		}
	}

	private bool method_14()
	{
		if (!Directory.Exists(string_0 + "\\Temp"))
		{
			try
			{
				Directory.CreateDirectory(string_0 + "\\Temp");
			}
			catch (Exception ex)
			{
				method_3("Eroare creare director " + string_0 + "Temp(Mesaj Eroare: " + ex.Message + ")");
				((Control)txtUltimaEroare).set_Text("Eroare creare director " + string_0 + "Temp");
				return false;
			}
		}
		return true;
	}

	private void method_15(string string_12)
	{
		method_3("Criptare PersonID");
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(string_12);
			bool flag = true;
			foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
			{
				if (childNode.Attributes!["personCID"] != null)
				{
					if (childNode.Attributes!["personPID"]!.Value != "")
					{
						childNode.Attributes!["personCID"]!.Value = method_16(childNode.Attributes!["personPID"]!.Value, "CID", 18, "40");
					}
					continue;
				}
				flag = false;
				break;
			}
			if (flag)
			{
				xmlDocument.Save(string_12);
			}
		}
		catch (Exception ex)
		{
			method_3("Eroare completare PersonCID: " + ex.Message);
			((Control)txtUltimaEroare).set_Text("Eroare completare PersonCID: " + ex.Message);
		}
	}

	private string method_16(string string_12, string string_13, int int_0, string string_14)
	{
		string result = "";
		byte[] key;
		using (SHA256 sHA = SHA256.Create())
		{
			key = sHA.ComputeHash(Encoding.ASCII.GetBytes(string_13));
		}
		using (HMACSHA256 hMACSHA = new HMACSHA256(key))
		{
			byte[] array = hMACSHA.ComputeHash(Encoding.ASCII.GetBytes(string_12));
			string format = $"{{0}}{{1:D{int_0}}}";
			int length = int_0 + (string_14?.Length ?? 0);
			ulong num = (BitConverter.IsLittleEndian ? BitConverter.ToUInt64(smethod_1(array, 8), 0) : BitConverter.ToUInt64(array, 0));
			result = string.Format(format, string_14, num).Substring(0, length);
		}
		return result;
	}

	private static byte[] smethod_1(byte[] byte_0, int int_0 = 0)
	{
		if (int_0 == 0)
		{
			int_0 = byte_0.Length;
		}
		int num = int_0 - 1;
		for (int i = 0; i < int_0 / 2; i++)
		{
			byte b = byte_0[i];
			byte_0[i] = byte_0[num];
			byte_0[num] = b;
			num--;
		}
		return byte_0;
	}

	private void method_17()
	{
		string[] files = Directory.GetFiles(string_0, "RETEL*.send");
		if (files.Length == 0)
		{
			return;
		}
		string text = "";
		string[] array = files;
		foreach (string text2 in array)
		{
			if (!File.Exists(text2) || Class3.smethod_0(text2))
			{
				continue;
			}
			string text3 = "";
			text3 = Path.GetFileName(text2);
			text3 = text3.Replace("RETEL", "");
			text3 = text3.Replace("retel", "");
			text3 = text3.Replace(".send", "");
			method_25(string_0 + "\\UltimaEReteta", text3);
			if (File.Exists(string_0 + "\\UltimaEReteta\\1__" + Path.GetFileName(text2)))
			{
				File.Delete(string_0 + "\\UltimaEReteta\\1__" + Path.GetFileName(text2));
			}
			method_24(text2, string_0 + "\\UltimaEReteta", "1__" + Path.GetFileName(text2));
			bool flag = false;
			string text4 = text2;
			((Control)txtUltimulFisierProcesat).set_Text(text2);
			method_3("Prelucrare fisier: " + text2);
			if (File.Exists(text4.Replace(".send", ".scnas")))
			{
				File.Delete(text4.Replace(".send", ".scnas"));
			}
			File.Move(text4, text4.Replace(".send", ".scnas"));
			text4 = text4.Replace(".send", ".scnas");
			try
			{
				if (bool_0)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(text4);
					foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
					{
						if (flag)
						{
							continue;
						}
						string text5 = "";
						int num = 0;
						bool flag2 = false;
						try
						{
							string text6 = "";
							string text7 = "";
							string contractNo = "";
							string contractType = "";
							string insuranceHouseCode = "";
							string text8 = "";
							string text9 = "";
							DateTime dateTime = default(DateTime);
							if (childNode.Attributes!["CUI"] != null)
							{
								text6 = childNode.Attributes!["CUI"]!.Value;
							}
							if (childNode.Attributes!["PARAFA"] != null)
							{
								text7 = childNode.Attributes!["PARAFA"]!.Value;
							}
							if (childNode.Attributes!["NRCONTR"] != null)
							{
								contractNo = childNode.Attributes!["NRCONTR"]!.Value;
							}
							if (childNode.Attributes!["TIPCONTR"] != null)
							{
								contractType = childNode.Attributes!["TIPCONTR"]!.Value;
							}
							if (childNode.Attributes!["CAS"] != null)
							{
								insuranceHouseCode = childNode.Attributes!["CAS"]!.Value;
							}
							if (childNode.Attributes!["SERIE_DOC"] != null)
							{
								text8 = childNode.Attributes!["SERIE_DOC"]!.Value;
							}
							if (childNode.Attributes!["NR_DOC"] != null)
							{
								text9 = childNode.Attributes!["NR_DOC"]!.Value;
							}
							dateTime = ((childNode.Attributes!["DATA_PRESC"] == null || string.IsNullOrEmpty(childNode.Attributes!["DATA_PRESC"]!.Value)) ? DateTime.Now : Convert.ToDateTime(childNode.Attributes!["DATA_PRESC"]!.Value.ToString(), cultureInfo_0));
							method_3("Preluare reteta electronica(metoda getPrescribedPrescription): CUI" + text6 + " Parafa: " + text7 + " Serie: " + text8 + " Nr: " + text9 + " Data prescr:" + dateTime.ToShortDateString());
							do
							{
								num++;
								try
								{
									text5 = eprescriptionWSService_0.getPrescribedPrescription(text6, text7, contractNo, contractType, insuranceHouseCode, text8, text9, dateTime).ToString();
									method_3("Preluare reteta electronica: apel getPrescribedPrescription incheiat cu succes");
									if (File.Exists(string_0 + "\\2__" + Path.GetFileName(text2)))
									{
										File.Delete(string_0 + "\\2__" + Path.GetFileName(text2));
									}
									StreamWriter streamWriter = File.AppendText(string_0 + "\\2__" + Path.GetFileName(text2));
									streamWriter.Write(text5);
									streamWriter.Flush();
									streamWriter.Close();
									flag2 = true;
								}
								catch (Exception ex)
								{
									if (num < 3 && ex.Message.ToUpper().Contains("UNAUTHORIZED"))
									{
										int num2 = 0;
										do
										{
											num2++;
											method_2();
										}
										while (num2 < 3 && !bool_0);
										if (bool_0)
										{
											((HttpWebClientProtocol)eprescriptionWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
											((WebClientProtocol)eprescriptionWSService_0).set_PreAuthenticate(true);
											((WebClientProtocol)eprescriptionWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
											eprescriptionWSService_0.SessionId = string_4;
											eprescriptionWSService_0.WsUserName = string_3;
											eprescriptionWSService_0.WsPassword = string_5;
											((Control)txtUltimaEroare).set_Text("");
										}
									}
									if (num == 3)
									{
										method_3("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex.Message);
										((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex.Message);
										childNode.InnerText = "EROARE:" + ex.Message;
										method_1();
										text = text8 + text9 + Environment.NewLine + "Eroare: " + ex.Message;
									}
								}
							}
							while (num < 3 && !flag2);
							if (flag2)
							{
								childNode.InnerText = text5;
							}
							else
							{
								flag = true;
							}
						}
						catch (Exception ex2)
						{
							method_3("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex2.Message);
							((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex2.Message);
							method_1();
							childNode.InnerText = "EROARE:" + ex2.Message;
							flag = true;
							text = "EROARE:" + ex2.Message;
						}
					}
					if (File.Exists(text4))
					{
						xmlDocument.Save(text4);
					}
				}
				else
				{
					text = "Eroare: Server offline";
				}
			}
			catch (Exception ex2)
			{
				method_3("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				method_1();
				flag = true;
				text = "EROARE:" + ex2.Message;
			}
			if (!flag && bool_0)
			{
				if (!File.Exists(text2) && File.Exists(text4))
				{
					if (File.Exists(text4.Replace(".scnas", ".recv")))
					{
						File.Delete(text4.Replace(".scnas", ".recv"));
					}
					if (File.Exists(string_0 + "\\UltimaEReteta\\3__" + Path.GetFileName(text4.Replace(".scnas", ".recv"))))
					{
						File.Delete(string_0 + "\\UltimaEReteta\\3__" + Path.GetFileName(text4.Replace(".scnas", ".recv")));
					}
					method_24(text4, string_0 + "\\UltimaEReteta", "3__" + Path.GetFileName(text4.Replace(".scnas", ".recv")));
					File.Move(text4, text4.Replace(".scnas", ".recv"));
				}
			}
			else if (!File.Exists(text2) && File.Exists(text4))
			{
				if (File.Exists(text4.Replace(".scnas", ".err")))
				{
					File.Delete(text4.Replace(".scnas", ".err"));
				}
				if (File.Exists(string_0 + "\\UltimaEReteta\\3__" + Path.GetFileName(text4.Replace(".scnas", ".err"))))
				{
					File.Delete(string_0 + "\\UltimaEReteta\\3__" + Path.GetFileName(text4.Replace(".scnas", ".err")));
				}
				method_24(text4, string_0 + "\\UltimaEReteta", "3__" + Path.GetFileName(text4.Replace(".scnas", ".err")));
				Class1.smethod_2(text, text4.Replace(".scnas", ".err"));
			}
		}
	}

	private void method_18()
	{
		string[] files = Directory.GetFiles(string_0, "VALIDRETEL*.send");
		if (files.Length == 0)
		{
			return;
		}
		string text = "";
		string[] array = files;
		foreach (string text2 in array)
		{
			if (!File.Exists(text2) || Class3.smethod_0(text2))
			{
				continue;
			}
			if (File.Exists(string_0 + "\\UltimaEReteta\\1__" + Path.GetFileName(text2)))
			{
				File.Delete(string_0 + "\\UltimaEReteta\\1__" + Path.GetFileName(text2));
			}
			method_24(text2, string_0 + "\\UltimaEReteta", "1__" + Path.GetFileName(text2));
			bool flag = false;
			string text3 = text2;
			((Control)txtUltimulFisierProcesat).set_Text(text2);
			method_3("Prelucrare fisier: " + text2);
			if (File.Exists(text3.Replace(".send", ".scnas")))
			{
				File.Delete(text3.Replace(".send", ".scnas"));
			}
			File.Move(text3, text3.Replace(".send", ".scnas"));
			text3 = text3.Replace(".send", ".scnas");
			try
			{
				if (bool_0)
				{
					if (!flag)
					{
						string text4 = "";
						string text5 = "";
						text5 = File.ReadAllText(text3);
						int num = 0;
						bool flag2 = false;
						try
						{
							method_3("Validare reteta electronica: apel processIssuedPrescription(SendXml)");
							do
							{
								num++;
								try
								{
									text4 = eprescriptionWSService_0.processIssuedPrescription(text5);
									XmlDocument xmlDocument = new XmlDocument();
									xmlDocument.LoadXml(text4);
									foreach (XmlNode item in xmlDocument.DocumentElement!.GetElementsByTagName("prescription"))
									{
										XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("CertificatSubject_CN");
										xmlAttribute.Value = string_6;
										item.Attributes!.Append(xmlAttribute);
										XmlAttribute xmlAttribute2 = xmlDocument.CreateAttribute("Certificat_SerialNumber");
										xmlAttribute2.Value = string_7;
										item.Attributes!.Append(xmlAttribute2);
										XmlAttribute xmlAttribute3 = xmlDocument.CreateAttribute("Certificat_NotBefore");
										xmlAttribute3.Value = string_8;
										item.Attributes!.Append(xmlAttribute3);
										XmlAttribute xmlAttribute4 = xmlDocument.CreateAttribute("CertificatIssuerName_CN");
										xmlAttribute4.Value = string_9;
										item.Attributes!.Append(xmlAttribute4);
									}
									if (File.Exists(text3))
									{
										xmlDocument.Save(text3);
										if (File.Exists(string_0 + "\\UltimaEReteta\\3__" + Path.GetFileName(text3)))
										{
											File.Delete(string_0 + "\\UltimaEReteta\\3__" + Path.GetFileName(text3));
										}
										method_24(text3, string_0 + "\\UltimaEReteta", "3__" + Path.GetFileName(text3));
										method_3("Validare reteta electronica: apel processIssuedPrescription incheiat cu succes");
										flag2 = true;
									}
								}
								catch (Exception ex)
								{
									if (num < 3 && ex.Message.ToUpper().Contains("UNAUTHORIZED"))
									{
										int num2 = 0;
										do
										{
											num2++;
											method_2();
										}
										while (num2 < 3 && !bool_0);
										if (bool_0)
										{
											((HttpWebClientProtocol)eprescriptionWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
											((WebClientProtocol)eprescriptionWSService_0).set_PreAuthenticate(true);
											((WebClientProtocol)eprescriptionWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
											eprescriptionWSService_0.SessionId = string_4;
											eprescriptionWSService_0.WsUserName = string_3;
											eprescriptionWSService_0.WsPassword = string_5;
											((Control)txtUltimaEroare).set_Text("");
										}
									}
									if (num == 3)
									{
										method_3("Fisier " + text2 + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex.Message);
										((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex.Message);
										method_1();
										text = Path.GetFileName(text2) + Environment.NewLine + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex.Message;
									}
								}
							}
							while (num < 3 && !flag2);
							if (!flag2)
							{
								flag = true;
							}
						}
						catch (Exception ex2)
						{
							method_3("Fisier " + text2 + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex2.Message);
							((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex2.Message);
							method_1();
							flag = true;
							text = Path.GetFileName(text2) + Environment.NewLine + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex2.Message;
						}
					}
				}
				else
				{
					text = "Eroare: Server offline";
				}
			}
			catch (Exception ex2)
			{
				method_3("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				method_1();
				flag = true;
				text = Path.GetFileName(text2) + Environment.NewLine + " Eroare prelucrare fisier: " + ex2.Message;
			}
			if (!flag && bool_0)
			{
				if (!File.Exists(text2) && File.Exists(text3))
				{
					if (File.Exists(text3.Replace(".scnas", ".recv")))
					{
						File.Delete(text3.Replace(".scnas", ".recv"));
					}
					if (File.Exists(string_0 + "\\UltimaEReteta\\3__" + Path.GetFileName(text3.Replace(".scnas", ".recv"))))
					{
						File.Delete(string_0 + "\\UltimaEReteta\\3__" + Path.GetFileName(text3.Replace(".scnas", ".recv")));
					}
					method_24(text3, string_0 + "\\UltimaEReteta", "3__" + Path.GetFileName(text3.Replace(".scnas", ".recv")));
					File.Move(text3, text3.Replace(".scnas", ".recv"));
				}
			}
			else if (!File.Exists(text2) && File.Exists(text3))
			{
				if (File.Exists(text3.Replace(".scnas", ".err")))
				{
					File.Delete(text3.Replace(".scnas", ".err"));
				}
				if (File.Exists(string_0 + "\\UltimaEReteta\\3__" + Path.GetFileName(text3.Replace(".scnas", ".err"))))
				{
					File.Delete(string_0 + "\\UltimaEReteta\\3__" + Path.GetFileName(text3.Replace(".scnas", ".err")));
				}
				method_24(text3, string_0 + "\\UltimaEReteta", "3__" + Path.GetFileName(text3.Replace(".scnas", ".err")));
				File.Delete(text3);
				Class1.smethod_2(text, text3.Replace(".scnas", ".err"));
			}
		}
	}

	private void method_19()
	{
		string[] files = Directory.GetFiles(string_0, "COMPLCID*.send");
		if (files.Length == 0)
		{
			return;
		}
		string text = "";
		string[] array = files;
		foreach (string text2 in array)
		{
			if (!File.Exists(text2) || Class3.smethod_0(text2))
			{
				continue;
			}
			bool flag = false;
			string text3 = text2;
			((Control)txtUltimulFisierProcesat).set_Text(text2);
			method_3("Prelucrare fisier: " + text2);
			if (File.Exists(text3.Replace(".send", ".scnas")))
			{
				File.Delete(text3.Replace(".send", ".scnas"));
			}
			File.Move(text3, text3.Replace(".send", ".scnas"));
			text3 = text3.Replace(".send", ".scnas");
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(text3);
				foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
				{
					if (flag)
					{
						continue;
					}
					try
					{
						string text4 = "";
						string text5 = "";
						if (childNode.Attributes!["CNPValue"] != null)
						{
							text4 = childNode.Attributes!["CNPValue"]!.Value;
						}
						method_3("Completare CID pentru CNP=" + text4);
						if (text4.Length == 13)
						{
							text5 = method_16(text4, "CID", 18, "40");
							XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("CID");
							xmlAttribute.Value = text5;
							childNode.Attributes!.Append(xmlAttribute);
						}
						method_3("Completare CID pentru CNP=" + text4 + " CID=" + text5);
					}
					catch (Exception ex)
					{
						method_3("Fisier " + text2 + " Eroare completare CID pr CNP=" + childNode.Attributes!["CNP"]!.Value + " " + ex.Message);
						((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare completare CID pr CNP=" + childNode.Attributes!["CNP"]!.Value + " " + ex.Message);
						method_1();
						flag = true;
						text = Path.GetFileName(text2) + Environment.NewLine + "Eroare completare CID pr CNP=" + childNode.Attributes!["CNP"]!.Value + " " + ex.Message;
					}
				}
				if (File.Exists(text3))
				{
					xmlDocument.Save(text3);
				}
			}
			catch (Exception ex)
			{
				method_3("Fisier " + text2 + " Eroare prelucrare fisier: " + ex.Message);
				((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare prelucrare fisier: " + ex.Message);
				method_1();
				flag = true;
				text = Path.GetFileName(text2) + Environment.NewLine + "Eroare completare CID " + ex.Message;
			}
			if (!flag)
			{
				if (!File.Exists(text2) && File.Exists(text3))
				{
					if (File.Exists(text3.Replace(".scnas", ".recv")))
					{
						File.Delete(text3.Replace(".scnas", ".recv"));
					}
					File.Move(text3, text3.Replace(".scnas", ".recv"));
				}
			}
			else if (!File.Exists(text2) && File.Exists(text3))
			{
				if (File.Exists(text3.Replace(".scnas", ".err")))
				{
					File.Delete(text3.Replace(".scnas", ".err"));
				}
				File.Delete(text3);
				Class1.smethod_2(text, text3.Replace(".scnas", ".err"));
			}
		}
	}

	private void method_20()
	{
		string[] files = Directory.GetFiles(string_0, "FARMF*.xml");
		if (files.Length == 0)
		{
			return;
		}
		string text = "";
		string[] array = files;
		foreach (string text2 in array)
		{
			if (!File.Exists(text2) || Class3.smethod_0(text2))
			{
				continue;
			}
			bool flag = false;
			((Control)txtUltimulFisierProcesat).set_Text(text2);
			method_3("Prelucrare fisier: " + text2);
			if (bool_0)
			{
				if (!flag)
				{
					int num = 0;
					string text3 = "";
					text3 = File.ReadAllText(text2);
					int num2 = 0;
					bool flag2 = false;
					try
					{
						method_3("Raportare retete electronice: apel updateInvoices(xml)");
						do
						{
							num2++;
							try
							{
								num = eprescriptionWSService_0.updateInvoices(text3);
								method_3("Raportare retete electronice: apel updateInvoices terminat cu succes");
								flag2 = true;
							}
							catch (Exception ex)
							{
								if (num2 < 3 && ex.Message.ToUpper().Contains("UNAUTHORIZED"))
								{
									int num3 = 0;
									do
									{
										num3++;
										method_2();
									}
									while (num3 < 3 && !bool_0);
									if (bool_0)
									{
										((HttpWebClientProtocol)eprescriptionWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
										((WebClientProtocol)eprescriptionWSService_0).set_PreAuthenticate(true);
										((WebClientProtocol)eprescriptionWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
										eprescriptionWSService_0.SessionId = string_4;
										eprescriptionWSService_0.WsUserName = string_3;
										eprescriptionWSService_0.WsPassword = string_5;
										((Control)txtUltimaEroare).set_Text("");
									}
								}
								if (num2 == 3)
								{
									method_3("Fisier " + text2 + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex.Message);
									((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex.Message);
									method_1();
									text = Path.GetFileName(text2) + Environment.NewLine + "Eroare trimitere fisier raportare retete electronice " + ex.Message;
								}
							}
						}
						while (num2 < 3 && !flag2);
						if (!flag2 || num != 1)
						{
							flag = true;
						}
					}
					catch (Exception ex2)
					{
						method_3("Fisier " + text2 + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex2.Message);
						((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex2.Message);
						method_1();
						flag = true;
						text = Path.GetFileName(text2) + Environment.NewLine + "Eroare trimitere fisier raportare retete electronice " + ex2.Message;
					}
				}
			}
			else
			{
				flag = true;
				text = "Eroare: Server offline.";
			}
			if (flag)
			{
				if (File.Exists(text2))
				{
					if (File.Exists(text2.Replace(".xml", ".xml.err")))
					{
						File.Delete(text2.Replace(".xml", ".xml.err"));
					}
					Class1.smethod_2(text, text2.Replace(".xml", ".xml.err"));
				}
			}
			else if (File.Exists(text2))
			{
				if (File.Exists(text2.Replace(".xml", ".xml.ok")))
				{
					File.Delete(text2.Replace(".xml", ".xml.ok"));
				}
				File.Move(text2, text2.Replace(".xml", ".xml.ok"));
			}
		}
	}

	private void method_21()
	{
		string[] files = Directory.GetFiles(string_0, "GETRELEASED*.send");
		if (files.Length == 0)
		{
			return;
		}
		string text = "";
		string[] array = files;
		foreach (string text2 in array)
		{
			if (!File.Exists(text2) || Class3.smethod_0(text2))
			{
				continue;
			}
			bool flag = false;
			string text3 = text2;
			((Control)txtUltimulFisierProcesat).set_Text(text2);
			method_3("Prelucrare fisier: " + text2);
			if (File.Exists(text3.Replace(".send", ".scnas")))
			{
				File.Delete(text3.Replace(".send", ".scnas"));
			}
			File.Move(text3, text3.Replace(".send", ".scnas"));
			text3 = text3.Replace(".send", ".scnas");
			try
			{
				if (bool_0)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(text3);
					foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
					{
						if (flag)
						{
							continue;
						}
						string innerText = "";
						int num = 0;
						bool flag2 = false;
						try
						{
							string text4 = "";
							string text5 = "";
							string text6 = "";
							string text7 = "";
							string text8 = "";
							int num2 = 0;
							if (childNode.Attributes!["ProviderCode"] != null)
							{
								text4 = childNode.Attributes!["ProviderCode"]!.Value;
							}
							if (childNode.Attributes!["workPlaceCode"] != null)
							{
								text5 = childNode.Attributes!["workPlaceCode"]!.Value;
							}
							if (childNode.Attributes!["insuranceHouseCode"] != null)
							{
								text6 = childNode.Attributes!["insuranceHouseCode"]!.Value;
							}
							if (childNode.Attributes!["series"] != null)
							{
								text7 = childNode.Attributes!["series"]!.Value;
							}
							if (childNode.Attributes!["no"] != null)
							{
								text8 = childNode.Attributes!["no"]!.Value;
							}
							if (childNode.Attributes!["fractionNo"] != null)
							{
								num2 = Convert.ToInt32(childNode.Attributes!["fractionNo"]!.Value.ToString());
							}
							method_3("Preluare reteta electronica : apel getReleasedPrescription(" + text4 + ", " + text5 + ", " + text6 + ", " + text7 + ", " + text8 + ", " + num2 + ")");
							do
							{
								num++;
								try
								{
									innerText = eprescriptionWSService_0.getReleasedPrescription(text4, text5, text6, text7, text8, num2);
									method_3("Preluare reteta electronica : apel getReleasedPrescription incheiat cu succes");
									flag2 = true;
								}
								catch (Exception ex)
								{
									if (num < 3 && ex.Message.ToUpper().Contains("UNAUTHORIZED"))
									{
										int num3 = 0;
										do
										{
											num3++;
											method_2();
										}
										while (num3 < 3 && !bool_0);
										if (bool_0)
										{
											((HttpWebClientProtocol)eprescriptionWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
											((WebClientProtocol)eprescriptionWSService_0).set_PreAuthenticate(true);
											((WebClientProtocol)eprescriptionWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
											eprescriptionWSService_0.SessionId = string_4;
											eprescriptionWSService_0.WsUserName = string_3;
											eprescriptionWSService_0.WsPassword = string_5;
											((Control)txtUltimaEroare).set_Text("");
										}
									}
									if (num == 3)
									{
										method_3("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex.Message);
										((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex.Message);
										childNode.InnerText = "EROARE:" + ex.Message;
										method_1();
										text = text7 + text8 + Environment.NewLine + "EROARE:" + ex.Message;
									}
								}
							}
							while (num < 3 && !flag2);
							if (flag2)
							{
								childNode.InnerText = innerText;
							}
							else
							{
								flag = true;
							}
						}
						catch (Exception ex2)
						{
							method_3("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex2.Message);
							((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex2.Message);
							method_1();
							childNode.InnerText = "EROARE:" + ex2.Message;
							flag = true;
							text = Path.GetFileName(text2) + Environment.NewLine + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex2.Message;
						}
					}
					if (File.Exists(text3))
					{
						xmlDocument.Save(text3);
					}
				}
				else
				{
					text = "Eroare: Server ofline.";
				}
			}
			catch (Exception ex2)
			{
				method_3("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				method_1();
				flag = true;
				text = Path.GetFileName(text2) + Environment.NewLine + " Eroare prelucrare fisier: " + ex2.Message;
			}
			if (!flag && bool_0)
			{
				if (!File.Exists(text2) && File.Exists(text3))
				{
					if (File.Exists(text3.Replace(".scnas", ".recv")))
					{
						File.Delete(text3.Replace(".scnas", ".recv"));
					}
					File.Move(text3, text3.Replace(".scnas", ".recv"));
				}
			}
			else if (!File.Exists(text2) && File.Exists(text3))
			{
				if (File.Exists(text3.Replace(".scnas", ".err")))
				{
					File.Delete(text3.Replace(".scnas", ".err"));
				}
				File.Delete(text3);
				Class1.smethod_2(text, text3.Replace(".scnas", ".err"));
			}
		}
	}

	private void method_22()
	{
		string[] files = Directory.GetFiles(string_0, "ANULRETEL*.send");
		if (files.Length == 0)
		{
			return;
		}
		string text = "";
		string[] array = files;
		foreach (string text2 in array)
		{
			if (!File.Exists(text2) || Class3.smethod_0(text2))
			{
				continue;
			}
			bool flag = false;
			string text3 = text2;
			((Control)txtUltimulFisierProcesat).set_Text(text2);
			method_3("Prelucrare fisier: " + text2);
			if (File.Exists(text3.Replace(".send", ".scnas")))
			{
				File.Delete(text3.Replace(".send", ".scnas"));
			}
			File.Move(text3, text3.Replace(".send", ".scnas"));
			text3 = text3.Replace(".send", ".scnas");
			try
			{
				if (bool_0)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(text3);
					foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
					{
						if (flag)
						{
							continue;
						}
						int num = 0;
						int num2 = 0;
						bool flag2 = false;
						try
						{
							string text4 = "";
							string text5 = "";
							string text6 = "";
							string text7 = "";
							string text8 = "";
							int num3 = 0;
							string text9 = "";
							if (childNode.Attributes!["ProviderCode"] != null)
							{
								text4 = childNode.Attributes!["ProviderCode"]!.Value;
							}
							if (childNode.Attributes!["workPlaceCode"] != null)
							{
								text5 = childNode.Attributes!["workPlaceCode"]!.Value;
							}
							if (childNode.Attributes!["insuranceHouseCode"] != null)
							{
								text6 = childNode.Attributes!["insuranceHouseCode"]!.Value;
							}
							if (childNode.Attributes!["series"] != null)
							{
								text7 = childNode.Attributes!["series"]!.Value;
							}
							if (childNode.Attributes!["no"] != null)
							{
								text8 = childNode.Attributes!["no"]!.Value;
							}
							if (childNode.Attributes!["fractionNo"] != null)
							{
								num3 = Convert.ToInt32(childNode.Attributes!["fractionNo"]!.Value.ToString());
							}
							if (childNode.Attributes!["cancellationReason"] != null)
							{
								text9 = childNode.Attributes!["cancellationReason"]!.Value;
							}
							method_3("Anulare reteta electronica: apel cancelReleasedPrescription(" + text4 + ", " + text5 + ", " + text6 + ", " + text7 + ", " + text8 + ", " + num3 + ", " + text9 + ")");
							do
							{
								num2++;
								try
								{
									num = eprescriptionWSService_0.cancelReleasedPrescription(text4, text5, text6, text7, text8, num3, text9);
									method_3("Anulare reteta electronica: apel cancelReleasedPrescription incheiat cu succes");
									flag2 = true;
								}
								catch (Exception ex)
								{
									if (num2 < 3 && ex.Message.ToUpper().Contains("UNAUTHORIZED"))
									{
										int num4 = 0;
										do
										{
											num4++;
											method_2();
										}
										while (num4 < 3 && !bool_0);
										if (bool_0)
										{
											((HttpWebClientProtocol)eprescriptionWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
											((WebClientProtocol)eprescriptionWSService_0).set_PreAuthenticate(true);
											((WebClientProtocol)eprescriptionWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
											eprescriptionWSService_0.SessionId = string_4;
											eprescriptionWSService_0.WsUserName = string_3;
											eprescriptionWSService_0.WsPassword = string_5;
											((Control)txtUltimaEroare).set_Text("");
										}
									}
									if (num2 == 3)
									{
										method_3("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex.Message);
										((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex.Message);
										childNode.InnerText = "EROARE:" + ex.Message;
										method_1();
										text = text7 + text8 + Environment.NewLine + "EROARE:" + ex.Message;
									}
								}
							}
							while (num2 < 3 && !flag2);
							if (flag2)
							{
								childNode.InnerText = num.ToString();
							}
							else
							{
								flag = true;
							}
						}
						catch (Exception ex2)
						{
							method_3("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex2.Message);
							((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex2.Message);
							method_1();
							childNode.InnerText = "EROARE:" + ex2.Message;
							text = Path.GetFileName(text2) + Environment.NewLine + "Eroare apel WebServiciu(Preluare reteta electronica): " + ex2.Message;
							flag = true;
						}
					}
					if (File.Exists(text3))
					{
						xmlDocument.Save(text3);
					}
				}
				else
				{
					text = "Eroare: Server offline";
				}
			}
			catch (Exception ex2)
			{
				method_3("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				method_1();
				flag = true;
				text = Path.GetFileName(text2) + Environment.NewLine + " Eroare prelucrare fisier: " + ex2.Message;
			}
			if (!flag && bool_0)
			{
				if (!File.Exists(text2) && File.Exists(text3))
				{
					if (File.Exists(text3.Replace(".scnas", ".recv")))
					{
						File.Delete(text3.Replace(".scnas", ".recv"));
					}
					File.Move(text3, text3.Replace(".scnas", ".recv"));
				}
			}
			else if (!File.Exists(text2) && File.Exists(text3))
			{
				if (File.Exists(text3.Replace(".scnas", ".err")))
				{
					File.Delete(text3.Replace(".scnas", ".err"));
				}
				File.Delete(text3);
				Class1.smethod_2(text, text3.Replace(".scnas", ".err"));
			}
		}
	}

	private void method_23()
	{
		string[] files = Directory.GetFiles(string_0, "GETSTATUSFORPRESCRIPTIONS*.send");
		if (files.Length == 0)
		{
			return;
		}
		string text = "";
		string[] array = files;
		foreach (string text2 in array)
		{
			if (!File.Exists(text2) || Class3.smethod_0(text2))
			{
				continue;
			}
			bool flag = false;
			string text3 = text2;
			((Control)txtUltimulFisierProcesat).set_Text(text2);
			method_3("Prelucrare fisier: " + text2);
			if (File.Exists(text3.Replace(".send", ".scnas")))
			{
				File.Delete(text3.Replace(".send", ".scnas"));
			}
			File.Move(text3, text3.Replace(".send", ".scnas"));
			text3 = text3.Replace(".send", ".scnas");
			try
			{
				if (bool_0)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(text3);
					foreach (XmlNode item in xmlDocument.GetElementsByTagName("RequiredInfo"))
					{
						if (flag)
						{
							continue;
						}
						string innerText = "";
						int num = 0;
						bool flag2 = false;
						try
						{
							string text4 = "";
							string text5 = "";
							string text6 = "";
							string text7 = "";
							string text8 = "";
							if (item.Attributes!["insuranceHouseCode"] != null)
							{
								text4 = item.Attributes!["insuranceHouseCode"]!.Value;
							}
							if (item.Attributes!["providerCode"] != null)
							{
								text5 = item.Attributes!["providerCode"]!.Value;
							}
							if (item.Attributes!["contractNo"] != null)
							{
								text6 = item.Attributes!["contractNo"]!.Value;
							}
							if (item.Attributes!["contractType"] != null)
							{
								text7 = item.Attributes!["contractType"]!.Value;
							}
							DateTime startFrom = ((item.Attributes!["startFrom"] == null || string.IsNullOrEmpty(item.Attributes!["startFrom"]!.Value)) ? DateTime.Now : Convert.ToDateTime(item.Attributes!["startFrom"]!.Value.ToString(), cultureInfo_0));
							DateTime endTo = ((item.Attributes!["endTo"] == null || string.IsNullOrEmpty(item.Attributes!["endTo"]!.Value)) ? DateTime.Now : Convert.ToDateTime(item.Attributes!["endTo"]!.Value.ToString(), cultureInfo_0));
							if (item.Attributes!["workPlaceCode"] != null)
							{
								text8 = item.Attributes!["workPlaceCode"]!.Value;
							}
							method_3("Preluare status retete electronice: InsuranceHouse: " + text4 + " providerCode: " + text5 + " contractNo: " + text6 + " contractType: " + text7 + " startFrom: " + startFrom.ToShortDateString() + " endTo: " + endTo.ToShortDateString() + " workPlaceCode: " + text8);
							do
							{
								num++;
								try
								{
									innerText = eprescriptionWSService_0.getStatusForPrescriptions(text4, text5, text6, text7, startFrom, endTo, text8);
									method_3("Preluare status retete electronice: apel getStatusForPrescriptions incheiat cu succes");
									flag2 = true;
								}
								catch (Exception ex)
								{
									if (num < 3 && ex.Message.ToUpper().Contains("UNAUTHORIZED"))
									{
										int num2 = 0;
										do
										{
											num2++;
											method_2();
										}
										while (num2 < 3 && !bool_0);
										if (bool_0)
										{
											((HttpWebClientProtocol)eprescriptionWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
											((WebClientProtocol)eprescriptionWSService_0).set_PreAuthenticate(true);
											((WebClientProtocol)eprescriptionWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
											eprescriptionWSService_0.SessionId = string_4;
											eprescriptionWSService_0.WsUserName = string_3;
											eprescriptionWSService_0.WsPassword = string_5;
											((Control)txtUltimaEroare).set_Text("");
										}
									}
									if (num == 3)
									{
										method_3("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex.Message);
										((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex.Message);
										item.InnerText = "EROARE:" + ex.Message;
										method_1();
										text = Path.GetFileName(text2) + Environment.NewLine + "EROARE:" + ex.Message;
									}
								}
							}
							while (num < 3 && !flag2);
							if (flag2)
							{
								item.InnerText = innerText;
							}
							else
							{
								flag = true;
							}
						}
						catch (Exception ex2)
						{
							method_3("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex2.Message);
							((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare apel WebServiciu(Preluare reteta electronica): " + ex2.Message);
							method_1();
							item.InnerText = "EROARE:" + ex2.Message;
							flag = true;
							text = Path.GetFileName(text2) + Environment.NewLine + "EROARE:" + ex2.Message;
						}
					}
					if (File.Exists(text3))
					{
						xmlDocument.Save(text3);
					}
				}
				else
				{
					text = "Eroare: Server offline.";
				}
			}
			catch (Exception ex2)
			{
				method_3("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				((Control)txtUltimaEroare).set_Text("Fisier " + text2 + " Eroare prelucrare fisier: " + ex2.Message);
				method_1();
				flag = true;
				text = Path.GetFileName(text2) + Environment.NewLine + "EROARE:" + ex2.Message;
			}
			if (!flag && bool_0)
			{
				if (!File.Exists(text2) && File.Exists(text3))
				{
					if (File.Exists(text3.Replace(".scnas", ".recv")))
					{
						File.Delete(text3.Replace(".scnas", ".recv"));
					}
					File.Move(text3, text3.Replace(".scnas", ".recv"));
				}
			}
			else if (!File.Exists(text2) && File.Exists(text3))
			{
				if (File.Exists(text3.Replace(".scnas", ".err")))
				{
					File.Delete(text3.Replace(".scnas", ".err"));
				}
				File.Delete(text3);
				Class1.smethod_2(text, text3.Replace(".scnas", ".err"));
			}
		}
	}

	private void method_24(string string_12, string string_13, string string_14)
	{
		try
		{
			if (!Directory.Exists(string_13))
			{
				Directory.CreateDirectory(string_13);
			}
			File.Copy(string_12, string_13 + "\\" + string_14);
		}
		catch (Exception ex)
		{
			((Control)txtUltimaEroare).set_Text("Eroare copiere fisier: " + ex.Message);
			method_3("Eroare copiere fisier: " + ex.Message);
		}
	}

	private void method_25(string string_12, string string_13)
	{
		if (!Directory.Exists(string_12))
		{
			return;
		}
		try
		{
			string[] files = Directory.GetFiles(string_12, "*" + string_13 + "*");
			string[] array = files;
			foreach (string path in array)
			{
				File.Delete(path);
			}
		}
		catch (Exception ex)
		{
			((Control)txtUltimaEroare).set_Text("Eroare curatare director: " + string_12 + "(" + ex.Message + ")");
			method_3("Eroare curatare director: " + string_12 + "(" + ex.Message + ")");
		}
	}

	private void frmServerCnas_Activated(object sender, EventArgs e)
	{
		((Control)this).set_Width(468);
		((Control)this).set_Height(348);
	}

	private void method_26()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_0)
		{
			return;
		}
		GetFileNameRegister getFileNameRegister = new GetFileNameRegister(string_11);
		((Form)getFileNameRegister).ShowDialog();
		if (getFileNameRegister.Cancelled)
		{
			return;
		}
		string_11 = getFileNameRegister.FileName;
		bool flag = false;
		int num = 0;
		string text = "";
		byte[] array = null;
		while (!flag && num < 3)
		{
			array = null;
			try
			{
				string[] registerFeedback = siuiWSService_0.getRegisterFeedback(string_11);
				if (registerFeedback.Length == 2)
				{
					array = method_10("https://www.siui.ro" + string_10 + registerFeedback[0]);
				}
				flag = array != null;
			}
			catch (Exception ex)
			{
				text = ex.Message;
			}
			if (!flag && num < 2 && text.ToUpper().Contains("UNAUTHORIZED"))
			{
				text = "";
				int num2 = 0;
				while (!bool_0 && num2 < 3)
				{
					method_2();
					num2++;
				}
				if (bool_0)
				{
					((HttpWebClientProtocol)siuiWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
					((WebClientProtocol)siuiWSService_0).set_PreAuthenticate(true);
					((WebClientProtocol)siuiWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
					siuiWSService_0.SessionId = string_4;
					siuiWSService_0.WsUserName = string_3;
					siuiWSService_0.WsPassword = string_5;
					((Control)txtUltimaEroare).set_Text("");
				}
			}
			num++;
		}
		if (flag)
		{
			string text2 = Path.GetFileNameWithoutExtension(string_11) + "_test.zip";
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.WriteAllBytes(text2, array);
			MessageBox.Show("Fisierul salvat este: " + text2);
		}
		else if (!string.IsNullOrEmpty(text))
		{
			method_3("Fisier " + string_11 + " Eroare apel WebServiciu(getRegisterFeedback): " + text);
			((Control)txtUltimaEroare).set_Text("Fisier " + string_11 + " Eroare apel WebServiciu(getRegisterFeedback): " + text);
			method_1();
		}
	}

	private void btnTestRegister_Click(object sender, EventArgs e)
	{
		method_26();
	}

	private bool method_27(string string_12, ref string string_13)
	{
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(string_12));
		httpWebRequest.Accept = "*/*";
		httpWebRequest.KeepAlive = true;
		httpWebRequest.AllowAutoRedirect = false;
		httpWebRequest.PreAuthenticate = true;
		httpWebRequest.Proxy = WebRequest.GetSystemWebProxy();
		httpWebRequest.ClientCertificates.Add(x509Certificate2_0);
		CredentialCache credentialCache = new CredentialCache();
		credentialCache.Add(new Uri(string_12), "Basic", new NetworkCredential(string_3, string_5));
		httpWebRequest.Credentials = credentialCache;
		httpWebRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
		httpWebRequest.Headers.Add("OSCP_RESPONSE", string_4);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		try
		{
			long num = 0L;
			using Stream stream = httpWebResponse.GetResponseStream();
			string text = "c:\\temp\\xxx.part";
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			using (FileStream fileStream = new FileStream(text, FileMode.OpenOrCreate))
			{
				byte[] array = new byte[1028];
				for (int num2 = stream.Read(array, 0, array.Length); num2 > 0; num2 = stream.Read(array, 0, array.Length))
				{
					fileStream.Write(array, 0, num2);
					num += num2;
				}
				fileStream.Close();
			}
			if (File.Exists("c:\\temp\\xxx111.zip"))
			{
				File.Delete("c:\\temp\\xxx111.zip");
			}
			File.Move(text, "c:\\temp\\xxx111.zip");
			stream.Close();
			return result;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
			return result;
		}
		finally
		{
			httpWebRequest.Abort();
			httpWebResponse.Close();
		}
	}

	private void method_28()
	{
		string[] files = Directory.GetFiles(string_0, "FARMF*.xml");
		if (files.Length == 0)
		{
			return;
		}
		string[] array = files;
		foreach (string text in array)
		{
			if (!File.Exists(text) || Class3.smethod_0(text))
			{
				continue;
			}
			if (File.Exists(text.Replace("FARMF", "FARME")))
			{
				File.Delete(text.Replace("FARMF", "FARME"));
			}
			File.Move(text, text.Replace("FARMF", "FARME"));
			bool flag = false;
			((Control)txtUltimulFisierProcesat).set_Text(text);
			method_3("Prelucrare fisier: " + text);
			if (bool_0)
			{
				if (bool_1)
				{
					method_3("Semnare fisier " + Path.GetFileName(text.Replace("FARMF", "FARME")));
					if (!method_11(text.Replace("FARMF", "FARME"), text.Replace("FARMF", "FARME"), x509Certificate2_0))
					{
						flag = true;
					}
				}
				if (!flag && method_13(text.Replace("FARMF", "FARME")) && File.Exists(text.Replace("FARMF.xml", "FARME.zip")) && !flag)
				{
					FileStream fileStream = new FileStream(text.Replace("FARMF.xml", "FARME.zip"), FileMode.Open, FileAccess.Read);
					byte[] array2 = new byte[fileStream.Length];
					fileStream.Read(array2, 0, Convert.ToInt32(fileStream.Length));
					string requestXml = Convert.ToBase64String(array2);
					int num = 0;
					int num2 = 0;
					bool flag2 = false;
					try
					{
						do
						{
							num2++;
							try
							{
								num = eprescriptionWSService_0.updateInvoices(requestXml);
								flag2 = true;
							}
							catch (Exception ex)
							{
								if (num2 < 3 && ex.Message.ToUpper().Contains("UNAUTHORIZED"))
								{
									int num3 = 0;
									do
									{
										num3++;
										method_2();
									}
									while (num3 < 3 && !bool_0);
									if (bool_0)
									{
										((HttpWebClientProtocol)eprescriptionWSService_0).get_ClientCertificates().Add(x509Certificate2_0);
										((WebClientProtocol)eprescriptionWSService_0).set_PreAuthenticate(true);
										((WebClientProtocol)eprescriptionWSService_0).set_Credentials((ICredentials)new NetworkCredential(string_3, string_5));
										eprescriptionWSService_0.SessionId = string_4;
										eprescriptionWSService_0.WsUserName = string_3;
										eprescriptionWSService_0.WsPassword = string_5;
										((Control)txtUltimaEroare).set_Text("");
									}
								}
								if (num2 == 3)
								{
									method_3("Fisier " + text + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex.Message);
									((Control)txtUltimaEroare).set_Text("Fisier " + text + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex.Message);
									method_1();
								}
							}
						}
						while (num2 < 3 && !flag2);
						if (!flag2 || num != 1)
						{
							flag = true;
						}
					}
					catch (Exception ex2)
					{
						method_3("Fisier " + text + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex2.Message);
						((Control)txtUltimaEroare).set_Text("Fisier " + text + " Eroare apel WebServiciu(Validare Server reteta electronica): " + ex2.Message);
						method_1();
						flag = true;
					}
				}
			}
			else
			{
				flag = true;
			}
			if (File.Exists(text.Replace("FARME", "FARMF")))
			{
				File.Move(text, text.Replace("FARME", "FARMF"));
			}
			if (File.Exists(text.Replace("FARMF.xml", "FARME.zip")))
			{
				File.Delete(text.Replace("FARMF.xml", "FARME.zip"));
			}
			if (flag)
			{
				if (File.Exists(text))
				{
					if (File.Exists(text.Replace(".xml", ".xml.err")))
					{
						File.Delete(text.Replace(".xml", ".xml.err"));
					}
					File.Move(text, text.Replace(".xml", ".xml.err"));
				}
			}
			else if (File.Exists(text))
			{
				if (File.Exists(text.Replace(".xml", ".xml.ok")))
				{
					File.Delete(text.Replace(".xml", ".xml.ok"));
				}
				File.Move(text, text.Replace(".xml", ".xml.ok"));
			}
		}
	}

	private void method_29(string string_12, int int_0)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(string_12));
		httpWebRequest.Accept = "*/*";
		httpWebRequest.KeepAlive = true;
		httpWebRequest.AllowAutoRedirect = false;
		httpWebRequest.PreAuthenticate = true;
		httpWebRequest.Proxy = WebRequest.GetSystemWebProxy();
		httpWebRequest.ClientCertificates.Add(x509Certificate2_0);
		CredentialCache credentialCache = new CredentialCache();
		credentialCache.Add(new Uri(string_12), "Basic", new NetworkCredential(string_3, string_5));
		httpWebRequest.Credentials = credentialCache;
		httpWebRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
		httpWebRequest.Headers.Add("OSCP_RESPONSE", string_4);
		using WebResponse webResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		using FileStream fileStream = new FileStream("c:\\FARMD_6253673_20110331_1905_ERRORS.zip", FileMode.Create, FileAccess.Write);
		byte[] array = ReadFully(webResponse.GetResponseStream());
		fileStream.Write(array, 0, array.Length);
		fileStream.Flush();
		fileStream.Close();
	}

	private void method_30()
	{
		if (!Directory.Exists(string_0 + "\\Temp"))
		{
			try
			{
				Directory.CreateDirectory(string_0 + "\\Temp");
			}
			catch (Exception ex)
			{
				method_3("Eroare creare director " + string_0 + "Temp(Mesaj Eroare: " + ex.Message + ")");
				((Control)txtUltimaEroare).set_Text("Eroare creare director " + string_0 + "Temp");
				return;
			}
		}
		string[] files = Directory.GetFiles(string_0, "*.xml");
		if (files.Length <= 0)
		{
			return;
		}
		string[] array = files;
		foreach (string text in array)
		{
			method_3("Semnare XML: " + text);
			((Control)txtUltimulFisierProcesat).set_Text(text);
			if (!File.Exists(text) || Class3.smethod_0(text))
			{
				continue;
			}
			string text2 = string_0 + "\\Temp\\" + Path.GetFileName(text);
			string text3 = string_0 + "\\Temp\\" + Path.GetFileName(text)!.Replace(".xml", ".sig");
			if (File.Exists(text2))
			{
				try
				{
					File.Delete(text2);
				}
				catch (Exception ex2)
				{
					method_3("Eroare stergere fisier " + text2 + "(" + ex2.Message + ")");
					((Control)txtUltimaEroare).set_Text("Eroare stergere fisier " + text2 + "(" + ex2.Message + ")");
					continue;
				}
			}
			if (File.Exists(text3))
			{
				try
				{
					File.Delete(text3);
				}
				catch (Exception ex2)
				{
					method_3("Eroare stergere fisier " + text3 + "(" + ex2.Message + ")");
					((Control)txtUltimaEroare).set_Text("Eroare stergere fisier " + text3 + "(" + ex2.Message + ")");
					continue;
				}
			}
			File.Move(text, text2);
			method_11(text2, text3, x509Certificate2_0);
			if (File.Exists(text3) && !Class3.smethod_0(text3))
			{
				File.Move(text3, text.Replace(".xml", ".sig"));
			}
			if (File.Exists(text2) && !Class3.smethod_0(text2))
			{
				File.Delete(text2);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected O, but got Unknown
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected O, but got Unknown
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected O, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected O, but got Unknown
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_098d: Expected O, but got Unknown
		//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmServerCnas));
		timer_0 = new Timer(icontainer_0);
		label1 = new Label();
		label2 = new Label();
		txtCale = new TextBox();
		txtUltimulFisierProcesat = new TextBox();
		lblUltimulFisierProcesat = new Label();
		btnReinitializareCerficare = new Button();
		txtUltimaEroare = new TextBox();
		lblUltimaEroare = new Label();
		lblStareServer = new Label();
		btnConfigurare = new Button();
		btnteste = new Button();
		notifyIcon_0 = new NotifyIcon(icontainer_0);
		btnClose = new Button();
		imageList_0 = new ImageList(icontainer_0);
		btnTestRegister = new Button();
		((Control)this).SuspendLayout();
		timer_0.set_Interval(500);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(40, 15));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Cale:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(12, 83));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(88, 15));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("Stare server:");
		((Control)txtCale).set_Enabled(false);
		((Control)txtCale).set_Location(new Point(70, 8));
		((TextBoxBase)txtCale).set_Multiline(true);
		((Control)txtCale).set_Name("txtCale");
		((Control)txtCale).set_Size(new Size(385, 41));
		((Control)txtCale).set_TabIndex(6);
		((Control)txtUltimulFisierProcesat).set_Enabled(false);
		((Control)txtUltimulFisierProcesat).set_Location(new Point(6, 122));
		((TextBoxBase)txtUltimulFisierProcesat).set_Multiline(true);
		((Control)txtUltimulFisierProcesat).set_Name("txtUltimulFisierProcesat");
		((Control)txtUltimulFisierProcesat).set_Size(new Size(449, 39));
		((Control)txtUltimulFisierProcesat).set_TabIndex(8);
		((Control)lblUltimulFisierProcesat).set_AutoSize(true);
		((Control)lblUltimulFisierProcesat).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblUltimulFisierProcesat).set_Location(new Point(13, 104));
		((Control)lblUltimulFisierProcesat).set_Name("lblUltimulFisierProcesat");
		((Control)lblUltimulFisierProcesat).set_Size(new Size(152, 15));
		((Control)lblUltimulFisierProcesat).set_TabIndex(7);
		((Control)lblUltimulFisierProcesat).set_Text("Ultimul fisier procesat:");
		((Control)btnReinitializareCerficare).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnReinitializareCerficare).set_Location(new Point(305, 53));
		((Control)btnReinitializareCerficare).set_Name("btnReinitializareCerficare");
		((Control)btnReinitializareCerficare).set_Size(new Size(150, 21));
		((Control)btnReinitializareCerficare).set_TabIndex(9);
		((Control)btnReinitializareCerficare).set_Text("Reinitializare certificare");
		((ButtonBase)btnReinitializareCerficare).set_UseVisualStyleBackColor(true);
		((Control)btnReinitializareCerficare).add_Click((EventHandler)btnReinitializareCerficare_Click);
		((Control)txtUltimaEroare).set_Enabled(false);
		((Control)txtUltimaEroare).set_Location(new Point(6, 182));
		((TextBoxBase)txtUltimaEroare).set_Multiline(true);
		((Control)txtUltimaEroare).set_Name("txtUltimaEroare");
		((Control)txtUltimaEroare).set_Size(new Size(449, 110));
		((Control)txtUltimaEroare).set_TabIndex(11);
		((Control)lblUltimaEroare).set_AutoSize(true);
		((Control)lblUltimaEroare).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblUltimaEroare).set_Location(new Point(13, 164));
		((Control)lblUltimaEroare).set_Name("lblUltimaEroare");
		((Control)lblUltimaEroare).set_Size(new Size(99, 15));
		((Control)lblUltimaEroare).set_TabIndex(10);
		((Control)lblUltimaEroare).set_Text("Ultima eroare:");
		((Control)lblStareServer).set_AutoSize(true);
		((Control)lblStareServer).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblStareServer).set_ForeColor(Color.Red);
		((Control)lblStareServer).set_Location(new Point(107, 83));
		((Control)lblStareServer).set_Name("lblStareServer");
		((Control)lblStareServer).set_Size(new Size(0, 15));
		((Control)lblStareServer).set_TabIndex(12);
		((Control)lblStareServer).add_TextChanged((EventHandler)lblStareServer_TextChanged);
		((Control)btnConfigurare).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnConfigurare).set_Location(new Point(16, 53));
		((Control)btnConfigurare).set_Name("btnConfigurare");
		((Control)btnConfigurare).set_Size(new Size(150, 21));
		((Control)btnConfigurare).set_TabIndex(13);
		((Control)btnConfigurare).set_Text("Configurare");
		((ButtonBase)btnConfigurare).set_UseVisualStyleBackColor(true);
		((Control)btnConfigurare).add_Click((EventHandler)btnConfigurare_Click);
		((Control)btnteste).set_Location(new Point(165, 99));
		((Control)btnteste).set_Name("btnteste");
		((Control)btnteste).set_Size(new Size(62, 20));
		((Control)btnteste).set_TabIndex(14);
		((Control)btnteste).set_Text("Teste");
		((ButtonBase)btnteste).set_UseVisualStyleBackColor(true);
		((Control)btnteste).add_Click((EventHandler)btnteste_Click);
		notifyIcon_0.set_BalloonTipText("Server CNAS");
		notifyIcon_0.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon.Icon"));
		notifyIcon_0.set_Text("Server CNAS");
		notifyIcon_0.set_Visible(true);
		notifyIcon_0.add_BalloonTipShown((EventHandler)notifyIcon_0_BalloonTipShown);
		notifyIcon_0.add_MouseDoubleClick(new MouseEventHandler(notifyIcon_0_MouseDoubleClick));
		((Control)btnClose).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnClose).set_Location(new Point(305, 82));
		((Control)btnClose).set_Name("btnClose");
		((Control)btnClose).set_Size(new Size(150, 21));
		((Control)btnClose).set_TabIndex(15);
		((Control)btnClose).set_Text("Inchidere aplicatie");
		((ButtonBase)btnClose).set_UseVisualStyleBackColor(true);
		((Control)btnClose).add_Click((EventHandler)btnClose_Click);
		imageList_0.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("imageListIco.ImageStream"));
		imageList_0.set_TransparentColor(Color.Transparent);
		imageList_0.get_Images().SetKeyName(0, "pharmec.ico");
		imageList_0.get_Images().SetKeyName(1, "pharmec-red.ico");
		((Control)btnTestRegister).set_Location(new Point(380, 295));
		((Control)btnTestRegister).set_Name("btnTestRegister");
		((Control)btnTestRegister).set_Size(new Size(75, 23));
		((Control)btnTestRegister).set_TabIndex(16);
		((Control)btnTestRegister).set_TabStop(false);
		((Control)btnTestRegister).set_Text("Test register");
		((ButtonBase)btnTestRegister).set_UseVisualStyleBackColor(true);
		((Control)btnTestRegister).set_Visible(false);
		((Control)btnTestRegister).add_Click((EventHandler)btnTestRegister_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(462, 320));
		((Control)this).get_Controls().Add((Control)(object)btnTestRegister);
		((Control)this).get_Controls().Add((Control)(object)btnClose);
		((Control)this).get_Controls().Add((Control)(object)btnteste);
		((Control)this).get_Controls().Add((Control)(object)btnConfigurare);
		((Control)this).get_Controls().Add((Control)(object)lblStareServer);
		((Control)this).get_Controls().Add((Control)(object)txtUltimaEroare);
		((Control)this).get_Controls().Add((Control)(object)lblUltimaEroare);
		((Control)this).get_Controls().Add((Control)(object)btnReinitializareCerficare);
		((Control)this).get_Controls().Add((Control)(object)txtUltimulFisierProcesat);
		((Control)this).get_Controls().Add((Control)(object)lblUltimulFisierProcesat);
		((Control)this).get_Controls().Add((Control)(object)txtCale);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmServerCnas");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Server CNAS");
		((Form)this).add_MinimumSizeChanged((EventHandler)frmServerCnas_MinimumSizeChanged);
		((Form)this).add_Load((EventHandler)frmServerCnas_Load);
		((Form)this).add_ResizeBegin((EventHandler)frmServerCnas_ResizeBegin);
		((Control)this).add_SizeChanged((EventHandler)frmServerCnas_SizeChanged);
		((Form)this).add_Activated((EventHandler)frmServerCnas_Activated);
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmServerCnas_FormClosing));
		((Control)this).add_Resize((EventHandler)frmServerCnas_Resize);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
