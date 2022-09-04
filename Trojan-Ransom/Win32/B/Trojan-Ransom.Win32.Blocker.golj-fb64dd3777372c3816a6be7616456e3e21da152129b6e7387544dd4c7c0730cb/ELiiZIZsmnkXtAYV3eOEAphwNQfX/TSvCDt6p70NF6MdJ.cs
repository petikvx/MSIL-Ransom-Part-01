using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace ELiiZIZsmnkXtAYV3eOEAphwNQfX;

public class TSvCDt6p70NF6MdJ
{
	private string Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr;

	private GZipStream UnDMas3YhzE5fJmXFfTrAdLTEu;

	private MemoryStream CQLN2jqcckF5pZ5GDkethQ8bfnAB6yStivv2eLpjn;

	private StreamReader sr;

	private CryptoStream bVeAscBN4lxoAcGAaOT8diZLWN7ol1ZW6GEjJ;

	private static Rijndael aes = y9YggH5unn5n02f2vfQcC("defaultAESkey256");

	public TSvCDt6p70NF6MdJ()
		: this("")
	{
	}

	public TSvCDt6p70NF6MdJ(string xnc4vgbyheFh3_COSTSke)
	{
		Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr = fgzwSHfzo27vSA4ihw.pkPWf0u2AXgM60ebUvOERK.TSvCDt6p70NF6MdJ + Regex.Replace(xnc4vgbyheFh3_COSTSke, "\\+$", "") + "\\";
		Directory.CreateDirectory(Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr);
	}

	private void Dispose()
	{
		if (bVeAscBN4lxoAcGAaOT8diZLWN7ol1ZW6GEjJ != null)
		{
			try
			{
				bVeAscBN4lxoAcGAaOT8diZLWN7ol1ZW6GEjJ.FlushFinalBlock();
			}
			catch
			{
			}
			bVeAscBN4lxoAcGAaOT8diZLWN7ol1ZW6GEjJ = null;
		}
		if (UnDMas3YhzE5fJmXFfTrAdLTEu != null)
		{
			try
			{
				UnDMas3YhzE5fJmXFfTrAdLTEu.Close();
				UnDMas3YhzE5fJmXFfTrAdLTEu.Dispose();
				UnDMas3YhzE5fJmXFfTrAdLTEu = null;
			}
			catch
			{
			}
		}
		if (CQLN2jqcckF5pZ5GDkethQ8bfnAB6yStivv2eLpjn != null)
		{
			try
			{
				CQLN2jqcckF5pZ5GDkethQ8bfnAB6yStivv2eLpjn.Close();
				CQLN2jqcckF5pZ5GDkethQ8bfnAB6yStivv2eLpjn.Dispose();
				CQLN2jqcckF5pZ5GDkethQ8bfnAB6yStivv2eLpjn = null;
			}
			catch
			{
			}
		}
		if (sr != null)
		{
			try
			{
				sr.Close();
				sr.Dispose();
				sr = null;
			}
			catch
			{
			}
		}
	}

	private static Rijndael y9YggH5unn5n02f2vfQcC(string AXESepyJpZhIW)
	{
		byte[] array = new byte[13]
		{
			11, 12, 13, 14, 15, 17, 17, 18, 19, 20,
			14, 22, 23
		};
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Encoding.UTF8.GetString(array, 0, array.Length), Encoding.UTF8.GetBytes(AXESepyJpZhIW));
		Rijndael rijndael = new RijndaelManaged();
		rijndael.Key = rfc2898DeriveBytes.GetBytes(16);
		rijndael.IV = rijndael.Key;
		array = null;
		rfc2898DeriveBytes = null;
		return rijndael;
	}

	public void Write(string dbName, object data)
	{
		try
		{
			File.WriteAllBytes(Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr + dbName, Write(data));
		}
		catch
		{
		}
		dbName = null;
		data = null;
	}

	public static byte[] Write(object data)
	{
		TSvCDt6p70NF6MdJ tSvCDt6p70NF6MdJ = new TSvCDt6p70NF6MdJ();
		byte[] result = null;
		try
		{
			XmlSerializer xmlSerializer = new XmlSerializer(data.GetType());
			StringWriter stringWriter = new StringWriter();
			xmlSerializer.Serialize(stringWriter, data);
			tSvCDt6p70NF6MdJ.CQLN2jqcckF5pZ5GDkethQ8bfnAB6yStivv2eLpjn = new MemoryStream();
			tSvCDt6p70NF6MdJ.bVeAscBN4lxoAcGAaOT8diZLWN7ol1ZW6GEjJ = new CryptoStream(tSvCDt6p70NF6MdJ.CQLN2jqcckF5pZ5GDkethQ8bfnAB6yStivv2eLpjn, aes.CreateEncryptor(), CryptoStreamMode.Write);
			tSvCDt6p70NF6MdJ.UnDMas3YhzE5fJmXFfTrAdLTEu = new GZipStream(tSvCDt6p70NF6MdJ.bVeAscBN4lxoAcGAaOT8diZLWN7ol1ZW6GEjJ, CompressionMode.Compress);
			byte[] bytes = Encoding.UTF8.GetBytes(stringWriter.ToString());
			tSvCDt6p70NF6MdJ.UnDMas3YhzE5fJmXFfTrAdLTEu.Write(bytes, 0, bytes.Length);
			tSvCDt6p70NF6MdJ.UnDMas3YhzE5fJmXFfTrAdLTEu.Close();
			tSvCDt6p70NF6MdJ.UnDMas3YhzE5fJmXFfTrAdLTEu.Dispose();
			tSvCDt6p70NF6MdJ.UnDMas3YhzE5fJmXFfTrAdLTEu = null;
			tSvCDt6p70NF6MdJ.bVeAscBN4lxoAcGAaOT8diZLWN7ol1ZW6GEjJ.Close();
			tSvCDt6p70NF6MdJ.bVeAscBN4lxoAcGAaOT8diZLWN7ol1ZW6GEjJ.Dispose();
			tSvCDt6p70NF6MdJ.bVeAscBN4lxoAcGAaOT8diZLWN7ol1ZW6GEjJ = null;
			bytes = null;
			result = tSvCDt6p70NF6MdJ.CQLN2jqcckF5pZ5GDkethQ8bfnAB6yStivv2eLpjn.ToArray();
			stringWriter.Close();
			stringWriter.Flush();
			stringWriter.Dispose();
			stringWriter = null;
			xmlSerializer = null;
		}
		catch
		{
		}
		tSvCDt6p70NF6MdJ.Dispose();
		tSvCDt6p70NF6MdJ = null;
		data = null;
		return result;
	}

	public T Read<T>(string dbName) where T : new()
	{
		T val = default(T);
		try
		{
			val = Read<T>(File.ReadAllBytes(Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr + dbName));
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
		TSvCDt6p70NF6MdJ tSvCDt6p70NF6MdJ = new TSvCDt6p70NF6MdJ();
		T val = default(T);
		try
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
			tSvCDt6p70NF6MdJ.CQLN2jqcckF5pZ5GDkethQ8bfnAB6yStivv2eLpjn = new MemoryStream(w57CZefGqLN_iElcDPMbWkc7ETYvLC);
			tSvCDt6p70NF6MdJ.bVeAscBN4lxoAcGAaOT8diZLWN7ol1ZW6GEjJ = new CryptoStream(tSvCDt6p70NF6MdJ.CQLN2jqcckF5pZ5GDkethQ8bfnAB6yStivv2eLpjn, aes.CreateDecryptor(), CryptoStreamMode.Read);
			tSvCDt6p70NF6MdJ.UnDMas3YhzE5fJmXFfTrAdLTEu = new GZipStream(tSvCDt6p70NF6MdJ.bVeAscBN4lxoAcGAaOT8diZLWN7ol1ZW6GEjJ, CompressionMode.Decompress, leaveOpen: true);
			tSvCDt6p70NF6MdJ.sr = new StreamReader(tSvCDt6p70NF6MdJ.UnDMas3YhzE5fJmXFfTrAdLTEu);
			val = (T)xmlSerializer.Deserialize(tSvCDt6p70NF6MdJ.sr);
			xmlSerializer = null;
		}
		catch
		{
		}
		tSvCDt6p70NF6MdJ.Dispose();
		tSvCDt6p70NF6MdJ = null;
		w57CZefGqLN_iElcDPMbWkc7ETYvLC = null;
		if (val != null)
		{
			return val;
		}
		return new T();
	}
}
