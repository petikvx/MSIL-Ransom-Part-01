using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using log4net;

namespace White.Core.Bricks;

public class AssemblyConfiguration
{
	protected readonly Dictionary<string, string> usedValues = new Dictionary<string, string>();

	protected AssemblyConfiguration()
	{
	}

	protected AssemblyConfiguration(string sectionGroup, string sectionName, Dictionary<string, object> defaultValues, ILog logger)
	{
		NameValueCollection nameValueCollection = (NameValueCollection)ConfigurationManager.GetSection(sectionGroup + "/" + sectionName);
		if (logger == null)
		{
			logger = LogManager.GetLogger(typeof(AssemblyConfiguration));
		}
		if (nameValueCollection == null)
		{
			nameValueCollection = new NameValueCollection();
		}
		CreateConfiguration(defaultValues, nameValueCollection);
		foreach (KeyValuePair<string, string> usedValue in usedValues)
		{
			logger.InfoFormat("Using {0}={1} for {2}/{3}", new object[4] { usedValue.Key, usedValue.Value, sectionGroup, sectionName });
		}
	}

	protected AssemblyConfiguration(Dictionary<string, object> defaultValues, ILog logger)
	{
		NameValueCollection appSettings = ConfigurationManager.get_AppSettings();
		CreateConfiguration(defaultValues, appSettings);
		foreach (KeyValuePair<string, string> usedValue in usedValues)
		{
			logger.InfoFormat("Using {0}={1}", (object)usedValue.Key, (object)usedValue.Value);
		}
	}

	private void CreateConfiguration(Dictionary<string, object> defaultValues, NameValueCollection nameValues)
	{
		foreach (KeyValuePair<string, object> defaultValue in defaultValues)
		{
			usedValues.Add(defaultValue.Key, defaultValue.Value.ToString());
		}
		string[] allKeys = nameValues.AllKeys;
		foreach (string text in allKeys)
		{
			string text2 = nameValues.Get(text);
			if (text2 != null)
			{
				usedValues.Remove(text);
				usedValues[text] = text2;
			}
		}
		List<string> list = new List<string>(nameValues.AllKeys);
		list.AddRange(defaultValues.Keys);
		foreach (string item in list)
		{
			string text3 = ConfigurationManager.get_AppSettings()[item];
			if (text3 != null)
			{
				usedValues.Remove(item);
				usedValues[item] = text3;
			}
		}
	}
}
