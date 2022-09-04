using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace EW5H3oYChfNlwZGh;

public class EA0jLFPEQHryw765JJWx8XLNQZDOiTaXdHBUP5y
{
	private string zdZG1VMy_ehxYh;

	public EA0jLFPEQHryw765JJWx8XLNQZDOiTaXdHBUP5y(string vgDdvLHeBF1uwo)
	{
		zdZG1VMy_ehxYh = oNe5f6dgziM.Hz2b2JGxC6a3lIzZ.EA0jLFPEQHryw765JJWx8XLNQZDOiTaXdHBUP5y + Regex.Replace(vgDdvLHeBF1uwo, "\\+$", "") + "\\";
	}

	public EA0jLFPEQHryw765JJWx8XLNQZDOiTaXdHBUP5y()
	{
		zdZG1VMy_ehxYh = oNe5f6dgziM.Hz2b2JGxC6a3lIzZ.EA0jLFPEQHryw765JJWx8XLNQZDOiTaXdHBUP5y;
	}

	public void Write(string dbName, object DataOB)
	{
		try
		{
			Directory.CreateDirectory(zdZG1VMy_ehxYh);
			File.WriteAllBytes(zdZG1VMy_ehxYh + dbName + ".xml", Write(DataOB));
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
			val = Read<T>(File.ReadAllBytes(zdZG1VMy_ehxYh + dbName + ".xml"));
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

	public static T Read<T>(byte[] wiO7DiYujdd3fxX45Bfpd_Nnir2e7yBuYsP) where T : new()
	{
		T val = default(T);
		try
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
			MemoryStream memoryStream = new MemoryStream(wiO7DiYujdd3fxX45Bfpd_Nnir2e7yBuYsP);
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
		wiO7DiYujdd3fxX45Bfpd_Nnir2e7yBuYsP = null;
		if (val != null)
		{
			return val;
		}
		return new T();
	}
}
