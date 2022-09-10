using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Xml;

namespace FC2ServerLauncher;

public class CMap
{
	private string m_localize;

	private string m_name;

	private EMapType m_mapType;

	private string m_creator;

	private string m_author;

	private DateTime m_dateAdded;

	private string m_gamemode;

	private string m_size;

	private Image m_screenshot;

	public string Localize
	{
		get
		{
			return m_localize;
		}
		set
		{
			m_localize = value;
		}
	}

	public string Name
	{
		get
		{
			return m_name;
		}
		set
		{
			m_name = value;
		}
	}

	public EMapType MapType
	{
		get
		{
			return m_mapType;
		}
		set
		{
			m_mapType = value;
		}
	}

	public string Creator
	{
		get
		{
			return m_creator;
		}
		set
		{
			m_creator = value;
		}
	}

	public string Author
	{
		get
		{
			return m_author;
		}
		set
		{
			m_author = value;
		}
	}

	public DateTime DateAdded
	{
		get
		{
			return m_dateAdded;
		}
		set
		{
			m_dateAdded = value;
		}
	}

	public string GameMode
	{
		get
		{
			return m_gamemode;
		}
		set
		{
			m_gamemode = value;
		}
	}

	public string Size
	{
		get
		{
			return m_size;
		}
		set
		{
			m_size = value;
		}
	}

	public Image Screenshot
	{
		get
		{
			return m_screenshot;
		}
		set
		{
			m_screenshot = value;
		}
	}

	public void LoadHeader(string filename)
	{
		FileInfo fileInfo = new FileInfo(filename);
		if (!fileInfo.Exists || !(fileInfo.Extension == ".fc2map"))
		{
			return;
		}
		CMapHeader cMapHeader = new CMapHeader();
		cMapHeader.LoadMapHeader(filename);
		MapType = EMapType.Custom;
		Name = fileInfo.Name.Remove(fileInfo.Name.IndexOf(CUtils.GetMapExtension()) - 1);
		Localize = cMapHeader.m_mapName;
		Author = cMapHeader.m_authorName;
		Creator = cMapHeader.m_creatorName;
		DateAdded = fileInfo.LastWriteTime;
		string text = "";
		foreach (EMapGameMode value in Enum.GetValues(typeof(EMapGameMode)))
		{
			if (((uint)cMapHeader.m_gameModes & (uint)value) == (uint)value)
			{
				if (!string.IsNullOrEmpty(text))
				{
					text += ", ";
				}
				text += value;
			}
		}
		GameMode = text;
		switch (cMapHeader.m_mapSize)
		{
		case 0:
			Size = "Small (4-8)";
			break;
		case 1:
			Size = "Medium (8-12)";
			break;
		case 2:
			Size = "Large (12-16)";
			break;
		}
		Screenshot = cMapHeader.m_screenshot;
	}

	public void LoadHeader(XmlNode mapNode)
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		MapType = EMapType.Original;
		Name = mapNode.Attributes!.GetNamedItem("name")!.Value;
		Localize = mapNode.Attributes!.GetNamedItem("localize")!.Value;
		Author = mapNode.Attributes!.GetNamedItem("author")!.Value;
		Creator = mapNode.Attributes!.GetNamedItem("creator")!.Value;
		string value = mapNode.Attributes!.GetNamedItem("date")!.Value;
		DateAdded = DateTime.Parse(value);
		GameMode = mapNode.Attributes!.GetNamedItem("mode")!.Value;
		Size = mapNode.Attributes!.GetNamedItem("size")!.Value;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string value2 = mapNode.Attributes!.GetNamedItem("image")!.Value;
		Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(value2);
		if (manifestResourceStream != null)
		{
			Screenshot = (Image)new Bitmap(manifestResourceStream);
		}
	}
}
