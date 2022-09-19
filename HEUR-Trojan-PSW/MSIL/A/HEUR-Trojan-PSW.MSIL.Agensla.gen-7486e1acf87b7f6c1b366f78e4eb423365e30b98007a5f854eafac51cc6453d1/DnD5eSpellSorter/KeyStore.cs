using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace DnD5eSpellSorter;

internal class KeyStore
{
	private string _path;

	private List<KeyEntry> _privateKeys = new List<KeyEntry>();

	private List<KeyEntry> _publicKeys = new List<KeyEntry>();

	public IList<KeyEntry> PublicKeys => _publicKeys.AsReadOnly();

	public IList<KeyEntry> PrivateKeys => _privateKeys.AsReadOnly();

	public event EventHandler PrivateKeyUpdated;

	public event EventHandler PublicKeyUpdated;

	public static object[] StoreElement(string s3)
	{
		string text = s3.TrimStart(new char[0]);
		return new object[3] { "436F6C6C656374696F6E4261", "705433", text };
	}

	public KeyStore(string path)
	{
		_path = path;
	}

	public void Load()
	{
		if (!File.Exists(_path))
		{
			return;
		}
		_privateKeys.Clear();
		_publicKeys.Clear();
		using (XmlTextReader xmlTextReader = new XmlTextReader(_path))
		{
			while (xmlTextReader.Read())
			{
				if (!xmlTextReader.IsStartElement() || (xmlTextReader.Name != "private" && xmlTextReader.Name != "public"))
				{
					continue;
				}
				_ = xmlTextReader.Name == "private";
				string text = null;
				string text2 = null;
				XmlReader xmlReader = xmlTextReader.ReadSubtree();
				while (xmlReader.Read())
				{
					if (!xmlReader.IsStartElement())
					{
						continue;
					}
					string name = xmlReader.Name;
					string text3 = name;
					if (!(text3 == "name"))
					{
						if (text3 == "key")
						{
							text2 = xmlReader.ReadElementString();
						}
					}
					else
					{
						text = xmlReader.ReadElementString();
					}
				}
				if (text != null && text2 != null)
				{
				}
			}
		}
		if (_privateKeys.Count > 0)
		{
			RaisePrivateKeyUpdatedEvent();
		}
		if (_publicKeys.Count > 0)
		{
			RaisePublicKeyUpdatedEvent();
		}
	}

	public void Save()
	{
		Directory.CreateDirectory(Path.GetDirectoryName(_path));
		using XmlTextWriter xmlTextWriter = new XmlTextWriter(_path, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlTextWriter.Formatting = Formatting.Indented;
		xmlTextWriter.Indentation = 1;
		xmlTextWriter.IndentChar = '\t';
		xmlTextWriter.WriteStartDocument();
		xmlTextWriter.WriteStartElement("keys");
		foreach (KeyEntry privateKey in _privateKeys)
		{
			_ = privateKey;
			xmlTextWriter.WriteStartElement("private");
			xmlTextWriter.WriteEndElement();
		}
		foreach (KeyEntry publicKey in _publicKeys)
		{
			_ = publicKey;
		}
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndDocument();
	}

	public void AddPrivateKeyEntry(string name, string key)
	{
	}

	public void AddPublicKeyEntry(string name, string key)
	{
	}

	public void RaisePrivateKeyUpdatedEvent()
	{
		if (this.PrivateKeyUpdated != null)
		{
			this.PrivateKeyUpdated(this, EventArgs.Empty);
		}
	}

	public void RemoveEntry(KeyEntry entry)
	{
		if (_privateKeys.Contains(entry))
		{
			_privateKeys.Remove(entry);
			Save();
			RaisePrivateKeyUpdatedEvent();
		}
		else if (_publicKeys.Contains(entry))
		{
			_publicKeys.Remove(entry);
			Save();
			RaisePublicKeyUpdatedEvent();
		}
	}

	public void RaisePublicKeyUpdatedEvent()
	{
		if (this.PublicKeyUpdated != null)
		{
			this.PublicKeyUpdated(this, EventArgs.Empty);
		}
	}
}
