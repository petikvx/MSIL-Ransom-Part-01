using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Extension;

public class UserData
{
	public string UniqueKey { get; set; }

	public string PublicKey { get; set; }

	public string PrivateKey { get; set; }

	public string BtcAddress { get; set; }

	public UserData()
	{
		Load();
	}

	public void Load()
	{
		string text = null;
		if (!File.Exists(Config.DatFilePath))
		{
			UniqueKey = Cryptor.GetRandomString(12);
			Save();
		}
		if (File.Exists(Config.DatFilePath))
		{
			using BinaryReader binaryReader = new BinaryReader(File.Open(Config.DatFilePath, FileMode.Open));
			binaryReader.ReadSingle();
			text = binaryReader.ReadString();
		}
		try
		{
			JToken val = (JToken)(object)JObject.Parse(text);
			UniqueKey = (string)val.SelectToken("UniqueKey");
			PublicKey = (string)val.SelectToken("PublicKey");
			PrivateKey = (string)val.SelectToken("PrivateKey");
			BtcAddress = (string)val.SelectToken("BtcAddress");
		}
		catch (Exception)
		{
		}
	}

	public void Save()
	{
		string value = JsonConvert.SerializeObject((object)this);
		using BinaryWriter binaryWriter = new BinaryWriter(File.Open(Config.DatFilePath, FileMode.Create));
		binaryWriter.Write(1.25f);
		binaryWriter.Write(value);
	}
}
