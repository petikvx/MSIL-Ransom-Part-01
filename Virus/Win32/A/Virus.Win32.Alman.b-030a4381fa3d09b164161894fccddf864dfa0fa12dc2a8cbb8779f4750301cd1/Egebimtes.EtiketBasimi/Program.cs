using System;
using System.Windows.Forms;
using System.Xml;
using Egebimtes.LisansKontrol;

namespace Egebimtes.EtiketBasimi;

internal static class Program
{
	public static Guid ProgramID = new Guid("2C1E23EC-675A-413a-815B-5310BA50F1C9");

	public static int intSubeKodu;

	public static string strVTAdi;

	public static string strConnString;

	public static string strPort;

	public static string strSablonDosya;

	public static string strPrinter;

	public static int intMiktarOndalik;

	public static int intAciklamaOndalik;

	[STAThread]
	private static void Main()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		try
		{
			LisansKontrol val = new LisansKontrol(ProgramID);
			if (!val.KontrolEt())
			{
				MessageBox.Show("Gecersiz lisans dosyası", "Hata", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
			}
			XmlDocument xmlDocument = new XmlDocument();
			string startupPath = Application.get_StartupPath();
			string filename = startupPath + "//Config.xml";
			xmlDocument.Load(filename);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("//configuration/connectionstringOLE");
			strConnString = xmlNode.FirstChild!.Value;
			strConnString = strConnString.Replace("master", strVTAdi);
			XmlNode xmlNode2 = xmlDocument.SelectSingleNode("//configuration/port");
			strPort = xmlNode2.FirstChild!.Value;
			XmlNode xmlNode3 = xmlDocument.SelectSingleNode("//configuration/printer");
			strPrinter = xmlNode3.FirstChild!.Value;
			XmlNode xmlNode4 = xmlDocument.SelectSingleNode("//configuration/miktarondalik");
			intMiktarOndalik = Convert.ToInt32(xmlNode4.FirstChild!.Value);
			XmlNode xmlNode5 = xmlDocument.SelectSingleNode("//configuration/aciklamaondalik");
			intAciklamaOndalik = Convert.ToInt32(xmlNode5.FirstChild!.Value);
			XmlNode xmlNode6 = xmlDocument.SelectSingleNode("//configuration/VTAdi");
			strVTAdi = xmlNode6.FirstChild!.Value;
			XmlNode xmlNode7 = xmlDocument.SelectSingleNode("//configuration/VTSube");
			intSubeKodu = Convert.ToInt32(xmlNode7.FirstChild!.Value);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Hata: " + ex.Message, "Egebimtes - Barkod Etiket Basım", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		Application.Run((Form)(object)new MainForm());
	}
}
