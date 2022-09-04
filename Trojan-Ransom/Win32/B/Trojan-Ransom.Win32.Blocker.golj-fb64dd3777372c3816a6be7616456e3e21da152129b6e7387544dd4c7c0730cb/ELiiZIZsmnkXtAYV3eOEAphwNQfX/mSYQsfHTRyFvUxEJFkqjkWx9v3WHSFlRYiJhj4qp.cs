using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace ELiiZIZsmnkXtAYV3eOEAphwNQfX;

public class mSYQsfHTRyFvUxEJFkqjkWx9v3WHSFlRYiJhj4qp
{
	private string Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr;

	public mSYQsfHTRyFvUxEJFkqjkWx9v3WHSFlRYiJhj4qp(string xnc4vgbyheFh3_COSTSke)
	{
		Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr = fgzwSHfzo27vSA4ihw.pkPWf0u2AXgM60ebUvOERK.mSYQsfHTRyFvUxEJFkqjkWx9v3WHSFlRYiJhj4qp + Regex.Replace(xnc4vgbyheFh3_COSTSke, "\\+$", "") + "\\";
	}

	public mSYQsfHTRyFvUxEJFkqjkWx9v3WHSFlRYiJhj4qp()
	{
		Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr = fgzwSHfzo27vSA4ihw.pkPWf0u2AXgM60ebUvOERK.mSYQsfHTRyFvUxEJFkqjkWx9v3WHSFlRYiJhj4qp;
	}

	public void Write(string dbName, object DataOB)
	{
		try
		{
			Directory.CreateDirectory(Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr);
			File.WriteAllBytes(Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr + dbName + ".xml", Write(DataOB));
		}
		catch
		{
		}
		dbName = null;
		DataOB = null;
	}

	public static byte[] Write(object DataOB)
	{
		byte[] result = null;
		try
		{
			XmlSerializer xmlSerializer = new XmlSerializer(DataOB.GetType());
			StringWriter stringWriter = new StringWriter();
			xmlSerializer.Serialize(stringWriter, DataOB);
			result = Encoding.UTF8.GetBytes(stringWriter.ToString());
			stringWriter.Close();
			stringWriter.Dispose();
			stringWriter = null;
			xmlSerializer = null;
		}
		catch
		{
		}
		DataOB = null;
		return result;
	}

	public T Read<T>(string dbName) where T : new()
	{
		T val = default(T);
		try
		{
			val = Read<T>(File.ReadAllBytes(Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr + dbName + ".xml"));
		}
		catch
		{
		}
		dbName = null;
		if (val != null)
		{
			return val;
		}
		return new T();
	}

	public static T Read<T>(byte[] w57CZefGqLN_iElcDPMbWkc7ETYvLC) where T : new()
	{
		T val = default(T);
		try
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
			MemoryStream memoryStream = new MemoryStream(w57CZefGqLN_iElcDPMbWkc7ETYvLC);
			TextReader textReader = new StreamReader(memoryStream);
			val = (T)xmlSerializer.Deserialize(textReader);
			textReader.Close();
			textReader.Dispose();
			textReader = null;
			memoryStream.Close();
			memoryStream.Dispose();
			memoryStream = null;
			xmlSerializer = null;
		}
		catch
		{
		}
		w57CZefGqLN_iElcDPMbWkc7ETYvLC = null;
		if (val != null)
		{
			return val;
		}
		return new T();
	}
}
