using System.Data;
using System.Xml;

namespace AnaSayfaDegistirici;

internal class anasayfacek
{
	public string Bos()
	{
		DataSet dataSet = new DataSet();
		XmlReader reader = XmlReader.Create("http://www.anasayfaniz.net/name.xml", new XmlReaderSettings());
		dataSet.ReadXml(reader);
		return dataSet.Tables[0].Rows[0]["site"].ToString();
	}
}
