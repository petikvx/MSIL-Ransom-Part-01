#define TRACE
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Com.HP.App.HPTools;

namespace Com.HP.IPG.HPLJUTBES;

public class DataUploader
{
	public bool UploadData(string productName, string portName, bool isNetworked, bool addSegmentationData, bool useTestServer)
	{
		bool result = false;
		string text = "http://www.hp.com/post-embed/myprinter";
		if (useTestServer)
		{
			text = "http://g2u0483g.austin.hp.com/pn_entry.jsp";
		}
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "HP\\HPLJUT");
		string text2 = Path.Combine(path, productName);
		if (!Directory.Exists(text2))
		{
			Directory.CreateDirectory(text2);
			OSUtils.AddDirectorySecurity(text2.ToString(), FileSystemRights.FullControl, AccessControlType.Allow);
		}
		addSegmentationData = true;
		bool flag = false;
		bool flag2 = false;
		string text3 = "";
		string path2 = portName + "_SureSupply.xml";
		string text4 = Path.Combine(text2, path2);
		if (!File.Exists(text4))
		{
			return false;
		}
		flag = true;
		string text5 = "";
		if (addSegmentationData)
		{
			string path3 = portName + "SD.xml";
			string text6 = Path.Combine(text2, path3);
			if (File.Exists(text6))
			{
				text5 = text4.Replace("_SureSupply.xml", "_merged.xml");
				if (File.Exists(text5))
				{
					try
					{
						File.Delete(text5);
					}
					catch (Exception)
					{
					}
				}
				if (CreateSingleXML(text4, text6, text5) && File.Exists(text5))
				{
					text3 = GetTextFromXMLFile(text5);
					flag = true;
				}
			}
		}
		if (flag)
		{
			if (text3.Length <= 0)
			{
				text3 = GetTextFromXMLFile(text4);
			}
			string uriString = text;
			Uri uri = new Uri(uriString);
			HttpWebResponse httpWebResponse = null;
			HttpWebRequest httpWebRequest = null;
			try
			{
				Trace.WriteLine("Sending to uri" + uri.AbsoluteUri);
				httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
				httpWebRequest.Method = "POST";
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				UTF8Encoding uTF8Encoding = new UTF8Encoding();
				string s = "XML_string=" + text3;
				byte[] bytes = uTF8Encoding.GetBytes(s);
				httpWebRequest.ContentLength = bytes.Length;
				using (Stream stream = httpWebRequest.GetRequestStream())
				{
					stream.Write(bytes, 0, bytes.Length);
					stream.Close();
				}
				httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
				for (int i = 0; i < httpWebResponse.Headers.Count; i++)
				{
					Trace.WriteLine("\nHeader Name:{" + httpWebResponse.Headers.Keys[i] + "}, Value :{" + httpWebResponse.Headers[i] + "}");
					string text7 = httpWebResponse.Headers[i];
					text7 = text7.ToLower();
					if (text7.Contains("terminate"))
					{
						Trace.WriteLine("Server send a TERMINATE response");
						string scheduleKeeperFile = GetScheduleKeeperFile(productName, portName, isNetworked);
						UpdateScheduleKeeperOptOut(scheduleKeeperFile);
						flag2 = true;
					}
				}
				using (Stream stream2 = httpWebResponse.GetResponseStream())
				{
					using StreamReader streamReader = new StreamReader(stream2, Encoding.UTF8);
					streamReader.ReadToEnd();
					flag2 = true;
				}
				httpWebResponse.Close();
				result = true;
			}
			catch (FormatException)
			{
				flag2 = false;
				result = false;
			}
			catch (WebException)
			{
				flag2 = false;
				result = false;
			}
			catch (Exception)
			{
				flag2 = false;
				result = false;
			}
			finally
			{
				httpWebRequest = null;
				httpWebResponse = null;
			}
		}
		if (flag2)
		{
			Trace.WriteLine("okToDelete <" + text4 + "> and <" + text5 + ">");
			deleteFiles(text4, text5);
		}
		else
		{
			Trace.WriteLine("Not okToDelete");
		}
		return result;
	}

	private void deleteFiles(string suresupplyfile, string mergedfile)
	{
		if (File.Exists(suresupplyfile))
		{
			try
			{
				File.Delete(suresupplyfile);
			}
			catch (Exception)
			{
			}
		}
		if (File.Exists(mergedfile))
		{
			try
			{
				File.Delete(mergedfile);
			}
			catch (Exception)
			{
			}
		}
	}

	private bool MergeXML(string data1File, string data2File, string mergedFile)
	{
		bool result = false;
		try
		{
			XmlTextReader reader = new XmlTextReader(data1File);
			XmlTextReader reader2 = new XmlTextReader(data2File);
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			DataSet dataSet2 = new DataSet();
			dataSet2.ReadXml(reader2);
			dataSet.Merge(dataSet2);
			dataSet.WriteXml(mergedFile);
			result = true;
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	private bool CreateSingleXML(string data1File, string data2File, string mergedFile)
	{
		bool result = false;
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(data1File);
			XmlDocument xmlDocument2 = new XmlDocument();
			xmlDocument2.Load(data2File);
			XmlNode node = xmlDocument2.SelectSingleNode("SegmentationData");
			XmlNode newChild = xmlDocument.ImportNode(node, deep: true);
			xmlDocument.DocumentElement?.AppendChild(newChild);
			xmlDocument.Save(mergedFile);
			result = true;
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	public bool IsNetConnected(string url)
	{
		bool flag = false;
		try
		{
			Uri requestUri = new Uri(url);
			WebRequest webRequest = WebRequest.Create(requestUri);
			WebResponse response = webRequest.GetResponse();
			response.Close();
			webRequest = null;
			return true;
		}
		catch (Exception)
		{
			WebResponse response = null;
			WebRequest webRequest = null;
			return false;
		}
	}

	private string GetTextFromXMLFile(string file)
	{
		StreamReader streamReader = File.OpenText(file);
		string result = streamReader.ReadToEnd();
		streamReader.Close();
		return result;
	}

	private void UpdateScheduleKeeperOptOut(string scheduleKeeperFile)
	{
		SchedulerData schedulerData = new SchedulerData();
		Trace.WriteLine("Entering UpdateScheduleKeeperOptOut");
		try
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(SchedulerData));
			TextReader textReader = new StreamReader(scheduleKeeperFile);
			schedulerData = (SchedulerData)xmlSerializer.Deserialize(textReader);
			textReader.Close();
			Trace.WriteLine("Setting updateData.OptedIn to false");
			schedulerData.OptedIn = false;
			XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(SchedulerData));
			TextWriter textWriter = new StreamWriter(scheduleKeeperFile);
			xmlSerializer2.Serialize(textWriter, schedulerData);
			textWriter.Close();
			Trace.WriteLine("exit UpdateScheduleKeeperOptOut");
		}
		catch (Exception ex)
		{
			Trace.WriteLine("LoadSchedulerData exception error is " + ex.Message);
		}
	}

	private string GetScheduleKeeperFile(string productName, string portName, bool isNetworked)
	{
		Trace.WriteLine("Entering GetScheduleKeeperFile");
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "HP\\HPLJUT");
		string text = Path.Combine(path, productName);
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
			OSUtils.AddDirectorySecurity(text.ToString(), FileSystemRights.FullControl, AccessControlType.Allow);
		}
		string empty = string.Empty;
		empty = portName + ".xml";
		string text2 = Path.Combine(text, empty);
		Trace.Write("Exiting GetScheduleKeeperFile, returning: " + text2);
		return text2;
	}
}
