using System.IO;
using System.Xml.Serialization;

namespace SandboxDotNet.Perms.Profiles;

public class PermissionsXML
{
	private readonly string _profilePath;

	public PermissionsXML(string profilePath)
	{
		_profilePath = profilePath;
	}

	public void ExportPermissions(Permissions permissions)
	{
		FileStream fileStream = File.Create(_profilePath);
		new XmlSerializer(typeof(Permissions)).Serialize(fileStream, permissions);
		fileStream.Close();
	}

	public Permissions ImportPermissions()
	{
		StreamReader streamReader = new StreamReader(_profilePath);
		Permissions result = (Permissions)new XmlSerializer(typeof(Permissions)).Deserialize(streamReader);
		streamReader.Close();
		return result;
	}
}
