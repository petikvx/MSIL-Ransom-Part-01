using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace snake;

public class Score_xml
{
	public string pathFile;

	public ObjectToSerialize obj;

	public Score_xml(string pathFile)
	{
		obj = new ObjectToSerialize();
		this.pathFile = pathFile;
	}

	public Score_xml()
	{
	}

	public string Serialize(int score, List<Element> myList, List<Element> myWalls, Apple myApple)
	{
		obj = new ObjectToSerialize();
		obj.score = score;
		for (int i = 0; i < myList.Count; i++)
		{
		}
		for (int j = 0; j < myWalls.Count; j++)
		{
		}
		obj.myApple = new Position(((Control)myApple.pictureBox1).get_Left(), ((Control)myApple.pictureBox1).get_Top());
		XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
		StringWriter stringWriter = new StringWriter();
		xmlSerializer.Serialize(stringWriter, obj);
		return stringWriter.ToString();
	}

	public void Deserialize(string str)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(this.obj.GetType());
		object obj;
		using (TextReader textReader = new StringReader(str))
		{
			obj = xmlSerializer.Deserialize(textReader);
		}
		this.obj = (ObjectToSerialize)obj;
	}
}
