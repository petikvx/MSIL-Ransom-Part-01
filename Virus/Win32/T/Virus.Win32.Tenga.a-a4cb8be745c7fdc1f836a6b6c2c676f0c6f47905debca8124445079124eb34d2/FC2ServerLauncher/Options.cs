using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace FC2ServerLauncher;

internal class Options
{
	private enum ColorFormat
	{
		NamedColor,
		ARGBColor
	}

	private bool m_logFile;

	private bool m_logTime;

	private Color m_consoleBack;

	private Color m_consoleFore;

	private Font m_consoleFont;

	private bool m_playerStats;

	private string m_lastFile = "";

	private List<string> m_recentFiles = new List<string>();

	[Category("Log")]
	[Description("Log console output into a file")]
	public bool File
	{
		get
		{
			return m_logFile;
		}
		set
		{
			m_logFile = value;
		}
	}

	[Category("Log")]
	[Description("Log the time when a console output occurs")]
	public bool Time
	{
		get
		{
			return m_logTime;
		}
		set
		{
			m_logTime = value;
		}
	}

	[Category("Console")]
	[Description("Console back color")]
	public Color BackColor
	{
		get
		{
			return m_consoleBack;
		}
		set
		{
			m_consoleBack = value;
		}
	}

	[Description("Console fore color")]
	[Category("Console")]
	public Color ForeColor
	{
		get
		{
			return m_consoleFore;
		}
		set
		{
			m_consoleFore = value;
		}
	}

	[Category("Console")]
	[Description("Console font")]
	public Font Font
	{
		get
		{
			return m_consoleFont;
		}
		set
		{
			m_consoleFont = value;
		}
	}

	[Category("Players")]
	[Description("Update and show players stats")]
	public bool PlayersStats
	{
		get
		{
			return m_playerStats;
		}
		set
		{
			m_playerStats = value;
		}
	}

	[Browsable(false)]
	public string LastFile
	{
		get
		{
			return m_lastFile;
		}
		set
		{
			m_lastFile = value;
		}
	}

	[Browsable(false)]
	public List<string> RecentFiles
	{
		get
		{
			return m_recentFiles;
		}
		set
		{
			m_recentFiles = value;
		}
	}

	public void SetDefault(TextBox console)
	{
		PlayersStats = true;
		File = true;
		Time = true;
		BackColor = ((Control)console).get_BackColor();
		ForeColor = ((Control)console).get_ForeColor();
		Font = ((Control)console).get_Font();
		RecentFiles.Clear();
	}

	public void AddRecent(string recent)
	{
		foreach (string recentFile in RecentFiles)
		{
			if (recentFile.ToLower() == recent.ToLower())
			{
				return;
			}
		}
		RecentFiles.Add(recent);
	}

	public void SaveToXml(ref XmlDocument xmldoc)
	{
		XmlNode newChild = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
		xmldoc.AppendChild(newChild);
		XmlElement newChild2 = xmldoc.CreateElement("", "Options", "");
		XmlNode xmlNode = xmldoc.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "PlayersStats", "");
		XmlAttribute xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = PlayersStats.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "File", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = File.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "Time", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = Time.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "BackColor", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = SerializeColor(BackColor);
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "ForeColor", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = SerializeColor(ForeColor);
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "Font", "");
		XmlNode fnode = xmlNode.AppendChild(newChild2);
		SerializeFont(ref xmldoc, ref fnode, Font);
		newChild2 = xmldoc.CreateElement("", "LastFile", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = LastFile;
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "RecentFiles", "");
		XmlNode xmlNode2 = xmlNode.AppendChild(newChild2);
		foreach (string recentFile in RecentFiles)
		{
			newChild2 = xmldoc.CreateElement("", "File", "");
			xmlAttribute = xmldoc.CreateAttribute("", "value", "");
			xmlAttribute.Value = recentFile;
			newChild2.Attributes.Append(xmlAttribute);
			xmlNode2.AppendChild(newChild2);
		}
	}

	public void LoadFromXml(XmlNode xmldoc)
	{
		if (xmldoc == null)
		{
			throw new ArgumentNullException("xmldoc");
		}
		foreach (XmlNode childNode in xmldoc.ChildNodes)
		{
			if (!(childNode.Name == "Options"))
			{
				continue;
			}
			XmlNode xmlNode2 = childNode;
			foreach (XmlNode item in xmlNode2)
			{
				if (item.Name == "PlayersStats")
				{
					string value = item.Attributes!.GetNamedItem("value")!.Value;
					PlayersStats = bool.Parse(value);
				}
				else if (item.Name == "File")
				{
					string value = item.Attributes!.GetNamedItem("value")!.Value;
					File = bool.Parse(value);
				}
				else if (item.Name == "Time")
				{
					string value = item.Attributes!.GetNamedItem("value")!.Value;
					Time = bool.Parse(value);
				}
				else if (item.Name == "BackColor")
				{
					string value = item.Attributes!.GetNamedItem("value")!.Value;
					BackColor = DeserializeColor(value);
				}
				else if (item.Name == "ForeColor")
				{
					string value = item.Attributes!.GetNamedItem("value")!.Value;
					ForeColor = DeserializeColor(value);
				}
				else if (item.Name == "Font")
				{
					Font = DeserializeFont(item);
				}
				else if (item.Name == "LastFile")
				{
					LastFile = item.Attributes!.GetNamedItem("value")!.Value;
				}
				else
				{
					if (!(item.Name == "RecentFiles"))
					{
						continue;
					}
					RecentFiles.Clear();
					foreach (XmlNode item2 in item)
					{
						if (item2.Name == "File")
						{
							RecentFiles.Add(item2.Attributes!.GetNamedItem("value")!.Value);
						}
					}
				}
			}
		}
	}

	private static string SerializeColor(Color color)
	{
		if (color.IsNamedColor)
		{
			return $"{ColorFormat.NamedColor}:{color.Name}";
		}
		return $"{ColorFormat.ARGBColor}:{color.A}:{color.R}:{color.G}:{color.B}";
	}

	private static Color DeserializeColor(string color)
	{
		string[] array = color.Split(new char[1] { ':' });
		switch ((ColorFormat)Enum.Parse(typeof(ColorFormat), array[0], ignoreCase: true))
		{
		default:
			return Color.Empty;
		case ColorFormat.NamedColor:
			return Color.FromName(array[1]);
		case ColorFormat.ARGBColor:
		{
			byte alpha = byte.Parse(array[1]);
			byte red = byte.Parse(array[2]);
			byte green = byte.Parse(array[3]);
			byte blue = byte.Parse(array[4]);
			return Color.FromArgb(alpha, red, green, blue);
		}
		}
	}

	private static void SerializeFont(ref XmlDocument xmldoc, ref XmlNode fnode, Font f)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		XmlElement xmlElement = xmldoc.CreateElement("", "FontFamily", "");
		XmlAttribute xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = f.get_FontFamily().get_Name();
		xmlElement.Attributes.Append(xmlAttribute);
		fnode.AppendChild(xmlElement);
		xmlElement = xmldoc.CreateElement("", "GraphicsUnit", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = ((object)f.get_Unit()).ToString();
		xmlElement.Attributes.Append(xmlAttribute);
		fnode.AppendChild(xmlElement);
		xmlElement = xmldoc.CreateElement("", "Size", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = f.get_Size().ToString();
		xmlElement.Attributes.Append(xmlAttribute);
		fnode.AppendChild(xmlElement);
		xmlElement = xmldoc.CreateElement("", "FontStyle", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = ((object)f.get_Style()).ToString();
		xmlElement.Attributes.Append(xmlAttribute);
		fnode.AppendChild(xmlElement);
	}

	private static Font DeserializeFont(XmlNode node)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		string text = "Microsoft Sans Serif";
		GraphicsUnit val = (GraphicsUnit)3;
		float num = 8f;
		FontStyle val2 = (FontStyle)0;
		foreach (XmlNode item in node)
		{
			if (item.Name == "FontFamily")
			{
				text = item.Attributes!.GetNamedItem("value")!.Value;
			}
			else if (item.Name == "GraphicsUnit")
			{
				string value = item.Attributes!.GetNamedItem("value")!.Value;
				val = (GraphicsUnit)Enum.Parse(typeof(GraphicsUnit), value);
			}
			else if (item.Name == "Size")
			{
				string value = item.Attributes!.GetNamedItem("value")!.Value;
				num = float.Parse(value);
			}
			else if (item.Name == "FontStyle")
			{
				string value = item.Attributes!.GetNamedItem("value")!.Value;
				val2 = (FontStyle)Enum.Parse(typeof(FontStyle), value);
			}
		}
		return new Font(text, num, val2, val);
	}
}
