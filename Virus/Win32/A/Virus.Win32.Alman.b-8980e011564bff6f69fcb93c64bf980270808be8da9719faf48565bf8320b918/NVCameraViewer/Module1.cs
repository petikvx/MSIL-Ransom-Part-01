using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace NVCameraViewer;

[StandardModule]
internal sealed class Module1
{
	public static SettingClass SettingObject = new SettingClass();

	public static bool LoadSetting()
	{
		bool result = false;
		if (SettingFileExist())
		{
			string xmlContent = File.ReadAllText(GetRunPath() + "\\NVCameraViewer.ini");
			try
			{
				SettingObject = (SettingClass)XMLDeserial(xmlContent, typeof(SettingClass));
				result = true;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return result;
	}

	public static void SaveSetting()
	{
		string contents = XMLSerial(SettingObject);
		File.WriteAllText(GetRunPath() + "\\NVCameraViewer.ini", contents);
	}

	public static bool SettingFileExist()
	{
		return File.Exists(GetSettingFilename());
	}

	public static string GetSettingFilename()
	{
		return GetRunPath() + "\\NVCameraViewer.ini";
	}

	public static string GetRunPath()
	{
		string text = Application.get_ExecutablePath();
		int num = text.LastIndexOf("\\");
		if (num != -1)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	public static string XMLSerial(object obj)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
		MemoryStream memoryStream = new MemoryStream();
		xmlSerializer.Serialize(memoryStream, RuntimeHelpers.GetObjectValue(obj));
		memoryStream.Position = 0L;
		byte[] array = new byte[checked((int)(memoryStream.Length - 1L) + 1)];
		memoryStream.Read(array, 0, array.Length);
		memoryStream.Dispose();
		memoryStream = null;
		return Encoding.UTF8.GetString(array);
	}

	public static object XMLDeserial(string xmlContent, Type objType)
	{
		object result = null;
		if (Operators.CompareString(xmlContent, string.Empty, false) != 0)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(xmlContent);
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(bytes, 0, bytes.Length);
			memoryStream.Position = 0L;
			XmlSerializer xmlSerializer = new XmlSerializer(objType);
			result = RuntimeHelpers.GetObjectValue(xmlSerializer.Deserialize(memoryStream));
			memoryStream.Dispose();
			memoryStream = null;
		}
		return result;
	}
}
