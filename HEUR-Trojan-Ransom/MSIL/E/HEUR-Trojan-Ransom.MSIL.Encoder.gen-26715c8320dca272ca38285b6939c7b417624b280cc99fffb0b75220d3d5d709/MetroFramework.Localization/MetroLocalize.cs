using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MetroFramework.Localization;

internal class MetroLocalize
{
	private DataSet languageDataset;

	public string DefaultLanguage()
	{
		return "en";
	}

	public string CurrentLanguage()
	{
		string text = Application.get_CurrentCulture().TwoLetterISOLanguageName;
		if (text.Length == 0)
		{
			text = DefaultLanguage();
		}
		return text.ToLower();
	}

	public MetroLocalize(string ctrlName)
	{
		importManifestResource(ctrlName);
	}

	public MetroLocalize(Control ctrl)
	{
		importManifestResource(ctrl.get_Name());
	}

	private void importManifestResource(string ctrlName)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		string name = callingAssembly.GetName().Name + ".Localization." + CurrentLanguage() + "." + ctrlName + ".xml";
		Stream manifestResourceStream = callingAssembly.GetManifestResourceStream(name);
		if (manifestResourceStream == null)
		{
			name = callingAssembly.GetName().Name + ".Localization." + DefaultLanguage() + "." + ctrlName + ".xml";
			manifestResourceStream = callingAssembly.GetManifestResourceStream(name);
		}
		if (languageDataset == null)
		{
			languageDataset = new DataSet();
		}
		if (manifestResourceStream != null)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(manifestResourceStream);
			languageDataset.Merge(dataSet);
			manifestResourceStream.Close();
		}
	}

	private string convertVar(object var)
	{
		if (var == null)
		{
			return "";
		}
		return var.ToString();
	}

	public string translate(string key)
	{
		if (string.IsNullOrEmpty(key))
		{
			return "";
		}
		if (languageDataset == null)
		{
			return "~" + key;
		}
		if (languageDataset.Tables["Localization"] == null)
		{
			return "~" + key;
		}
		DataRow[] array = languageDataset.Tables["Localization"]!.Select("Key='" + key + "'");
		if (array.Length <= 0)
		{
			return "~" + key;
		}
		return array[0]["Value"].ToString();
	}

	public string translate(string key, object var1)
	{
		string text = translate(key);
		return text.Replace("#1", convertVar(var1));
	}

	public string translate(string key, object var1, object var2)
	{
		string text = translate(key);
		text = text.Replace("#1", convertVar(var1));
		return text.Replace("#2", convertVar(var2));
	}

	public string getValue(string key, object var1, object var2, object var3)
	{
		string text = translate(key);
		text = text.Replace("#1", convertVar(var1));
		text = text.Replace("#2", convertVar(var2));
		return text.Replace("#3", convertVar(var3));
	}

	public string getValue(string key, object var1, object var2, object var3, object var4)
	{
		string text = translate(key);
		text = text.Replace("#1", convertVar(var1));
		text = text.Replace("#2", convertVar(var2));
		text = text.Replace("#3", convertVar(var3));
		return text.Replace("#4", convertVar(var4));
	}

	public string getValue(string key, object var1, object var2, object var3, object var4, object var5)
	{
		string text = translate(key);
		text = text.Replace("#1", convertVar(var1));
		text = text.Replace("#2", convertVar(var2));
		text = text.Replace("#3", convertVar(var3));
		text = text.Replace("#4", convertVar(var4));
		return text.Replace("#5", convertVar(var5));
	}
}
