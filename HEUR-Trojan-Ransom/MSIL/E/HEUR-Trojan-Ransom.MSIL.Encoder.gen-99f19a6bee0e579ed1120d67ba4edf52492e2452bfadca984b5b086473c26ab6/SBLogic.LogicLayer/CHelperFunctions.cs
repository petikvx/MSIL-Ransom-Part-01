using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace SBLogic.LogicLayer;

public class CHelperFunctions
{
	[DllImport("KERNEL32.DLL", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	internal static extern bool SetProcessWorkingSetSize(IntPtr pProcess, int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

	[DllImport("KERNEL32.DLL", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	internal static extern IntPtr GetCurrentProcess();

	public void ClearMemory()
	{
	}

	public string GetStringBetween(string strText, string strStartTag, string strEndTag)
	{
		int num = strText.IndexOf(strStartTag);
		if (num != -1)
		{
			num += strStartTag.Length;
			int num2 = strText.IndexOf(strEndTag, num);
			if (num2 > -1)
			{
				string text = strText.Substring(num, num2 - num);
				return text.Replace("\r", "").Replace("\n", "").Replace("\t", "")
					.Trim();
			}
		}
		return "";
	}

	public byte[] ObjectToByteArray(object obj)
	{
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		using MemoryStream memoryStream = new MemoryStream();
		binaryFormatter.Serialize(memoryStream, obj);
		return memoryStream.ToArray();
	}

	public string RemoveHtmlTags(string str)
	{
		int num = 0;
		while (num < str.Length)
		{
			num = str.IndexOf("<", num);
			if (num == -1)
			{
				break;
			}
			int num2 = str.IndexOf(">", num);
			if (num2 == -1)
			{
				break;
			}
			string oldValue = str.Substring(num, num2 - num + 1);
			str = str.Replace(oldValue, " ").Trim();
		}
		Regex regex = new Regex("[ ]{2,}", RegexOptions.None);
		str = regex.Replace(str, " ");
		return str;
	}

	public object ByteArrayToObject(byte[] arrBytes)
	{
		using MemoryStream memoryStream = new MemoryStream();
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		memoryStream.Write(arrBytes, 0, arrBytes.Length);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return binaryFormatter.Deserialize(memoryStream);
	}

	public List<string> GetListFromString(string strCont, string strStart, string strEnd)
	{
		int iStart = 0;
		List<string> list = new List<string>();
		while (true)
		{
			string stringBetween = GetStringBetween(strCont, strStart, strEnd, ref iStart);
			if (iStart == -1)
			{
				break;
			}
			if (stringBetween != "")
			{
				list.Add(stringBetween);
			}
		}
		return list;
	}

	public string GetStringBetween(string strText, string strStartTag, string strEndTag, ref int iStart)
	{
		if (iStart == -1)
		{
			return "";
		}
		iStart = strText.IndexOf(strStartTag, iStart);
		if (iStart != -1)
		{
			iStart += strStartTag.Length;
			int num = strText.IndexOf(strEndTag, iStart);
			if (num > -1)
			{
				string str = strText.Substring(iStart, num - iStart);
				str = HttpUtility.UrlDecode(str);
				str = HttpUtility.HtmlDecode(str);
				iStart = num;
				return str.Replace("\r", "").Replace("\n", "").Replace("\t", "")
					.Trim();
			}
		}
		return "";
	}

	public string ReadResponse(HttpWebResponse response)
	{
		try
		{
			using Stream stream = response.GetResponseStream();
			Stream stream2 = stream;
			if (response.ContentEncoding.ToLower().Contains("gzip"))
			{
				stream2 = new GZipStream(stream2, CompressionMode.Decompress);
			}
			else if (response.ContentEncoding.ToLower().Contains("deflate"))
			{
				stream2 = new DeflateStream(stream2, CompressionMode.Decompress);
			}
			using StreamReader streamReader = new StreamReader(stream2, Encoding.UTF8);
			return streamReader.ReadToEnd();
		}
		catch (Exception)
		{
			return "";
		}
	}
}
