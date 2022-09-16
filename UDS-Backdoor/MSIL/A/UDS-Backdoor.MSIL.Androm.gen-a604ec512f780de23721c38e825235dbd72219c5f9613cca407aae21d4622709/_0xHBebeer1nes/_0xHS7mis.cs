using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace _0xHBebeer1nes;

internal static class _0xHS7mis
{
	public static bool _0xHRueful5esses(string _0xHPle5d5ble, string _0xHN6net6es, out IList<string> _0xH6nseminators)
	{
		_0xH6nseminators = new List<string>();
		XDocument val;
		try
		{
			val = XDocument.Parse(_0xHPle5d5ble);
		}
		catch (Exception ex)
		{
			_0xH6nseminators.Add(ex.Message);
			return false;
		}
		bool isValid = true;
		XmlSchemaSet xmlSchemaSet = new XmlSchemaSet();
		xmlSchemaSet.Add(((object)val.get_Root().GetDefaultNamespace()).ToString(), XmlReader.Create(new StringReader(_0xHN6net6es)));
		List<string> tempErrorList = new List<string>();
		Extensions.Validate(val, xmlSchemaSet, (ValidationEventHandler)delegate(object sender, ValidationEventArgs e)
		{
			tempErrorList.Add(e.Message);
			isValid = false;
		});
		foreach (string item in tempErrorList)
		{
			_0xH6nseminators.Add(item);
		}
		return isValid;
	}
}
