using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Installer;

public class CParams
{
	private bool m_default = true;

	private Dictionary<string, string> m_values;

	public bool isDefault
	{
		get
		{
			return m_default;
		}
		set
		{
			m_default = value;
		}
	}

	public string caption
	{
		get
		{
			if (m_values.ContainsKey("caption"))
			{
				return m_values["caption"];
			}
			return "Instalador";
		}
		set
		{
			if (m_values.ContainsKey("caption"))
			{
				m_values["caption"] = value;
			}
			else
			{
				m_values.Add("caption", value);
			}
		}
	}

	public string confirmCloseCaption
	{
		get
		{
			if (m_values.ContainsKey("confirmCloseCaption"))
			{
				return m_values["confirmCloseCaption"];
			}
			return caption;
		}
		set
		{
			if (m_values.ContainsKey("confirmCloseCaption"))
			{
				m_values["confirmCloseCaption"] = value;
			}
			else
			{
				m_values.Add("confirmCloseCaption", value);
			}
		}
	}

	public string confirmCloseText
	{
		get
		{
			if (m_values.ContainsKey("confirmCloseText"))
			{
				return m_values["confirmCloseText"];
			}
			return "¿Está seguro de que desea salir de la instalación?";
		}
		set
		{
			if (m_values.ContainsKey("confirmCloseText"))
			{
				m_values["confirmCloseText"] = value;
			}
			else
			{
				m_values.Add("confirmCloseText", value);
			}
		}
	}

	public Point acceptLocation
	{
		get
		{
			if (m_values.ContainsKey("acceptLocation"))
			{
				string[] array = m_values["acceptLocation"].Split(new char[1] { ',' });
				return new Point(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Point(331, 328);
		}
		set
		{
			string value2 = value.X + "," + value.Y;
			if (m_values.ContainsKey("acceptLocation"))
			{
				m_values["acceptLocation"] = value2;
			}
			else
			{
				m_values.Add("acceptLocation", value2);
			}
		}
	}

	public Size acceptSize
	{
		get
		{
			if (m_values.ContainsKey("acceptSize"))
			{
				string[] array = m_values["acceptSize"].Split(new char[1] { ',' });
				return new Size(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Size(75, 23);
		}
		set
		{
			string value2 = value.Width + "," + value.Height;
			if (m_values.ContainsKey("acceptSize"))
			{
				m_values["acceptSize"] = value2;
			}
			else
			{
				m_values.Add("acceptSize", value2);
			}
		}
	}

	public string acceptCaption
	{
		get
		{
			if (m_values.ContainsKey("acceptCaption"))
			{
				return m_values["acceptCaption"];
			}
			return "Siguiente >";
		}
		set
		{
			if (m_values.ContainsKey("acceptCaption"))
			{
				m_values["acceptCaption"] = value;
			}
			else
			{
				m_values.Add("acceptCaption", value);
			}
		}
	}

	public Point cancelLocation
	{
		get
		{
			if (m_values.ContainsKey("cancelLocation"))
			{
				string[] array = m_values["cancelLocation"].Split(new char[1] { ',' });
				return new Point(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Point(412, 328);
		}
		set
		{
			string value2 = value.X + "," + value.Y;
			if (m_values.ContainsKey("cancelLocation"))
			{
				m_values["cancelLocation"] = value2;
			}
			else
			{
				m_values.Add("cancelLocation", value2);
			}
		}
	}

	public Size cancelSize
	{
		get
		{
			if (m_values.ContainsKey("cancelSize"))
			{
				string[] array = m_values["cancelSize"].Split(new char[1] { ',' });
				return new Size(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Size(75, 23);
		}
		set
		{
			string value2 = value.Width + "," + value.Height;
			if (m_values.ContainsKey("cancelSize"))
			{
				m_values["cancelSize"] = value2;
			}
			else
			{
				m_values.Add("cancelSize", value2);
			}
		}
	}

	public string cancelCaption
	{
		get
		{
			if (m_values.ContainsKey("cancelCaption"))
			{
				return m_values["cancelCaption"];
			}
			return "Cancelar";
		}
		set
		{
			if (m_values.ContainsKey("cancelCaption"))
			{
				m_values["cancelCaption"] = value;
			}
			else
			{
				m_values.Add("cancelCaption", value);
			}
		}
	}

	public Point textboxLocation
	{
		get
		{
			if (m_values.ContainsKey("textboxLocation"))
			{
				string[] array = m_values["textboxLocation"].Split(new char[1] { ',' });
				return new Point(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Point(170, 125);
		}
		set
		{
			string value2 = value.X + "," + value.Y;
			if (m_values.ContainsKey("textboxLocation"))
			{
				m_values["textboxLocation"] = value2;
			}
			else
			{
				m_values.Add("textboxLocation", value2);
			}
		}
	}

	public Size textboxSize
	{
		get
		{
			if (m_values.ContainsKey("textboxSize"))
			{
				string[] array = m_values["textboxSize"].Split(new char[1] { ',' });
				return new Size(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Size(123, 20);
		}
		set
		{
			string value2 = value.Width + "," + value.Height;
			if (m_values.ContainsKey("textboxSize"))
			{
				m_values["textboxSize"] = value2;
			}
			else
			{
				m_values.Add("textboxSize", value2);
			}
		}
	}

	public string programName
	{
		get
		{
			if (m_values.ContainsKey("programName"))
			{
				return m_values["programName"];
			}
			return "Instalador";
		}
		set
		{
			if (m_values.ContainsKey("programName"))
			{
				m_values["programName"] = value;
			}
			else
			{
				m_values.Add("programName", value);
			}
		}
	}

	public string wrongCodeCaption
	{
		get
		{
			if (m_values.ContainsKey("wrongCodeCaption"))
			{
				return m_values["wrongCodeCaption"];
			}
			return "Código invalido";
		}
		set
		{
			if (m_values.ContainsKey("wrongCodeCaption"))
			{
				m_values["wrongCodeCaption"] = value;
			}
			else
			{
				m_values.Add("wrongCodeCaption", value);
			}
		}
	}

	public string wrongCodeText
	{
		get
		{
			if (m_values.ContainsKey("wrongCodeText"))
			{
				return m_values["wrongCodeText"];
			}
			return "El código introducido no es válido";
		}
		set
		{
			if (m_values.ContainsKey("wrongCodeText"))
			{
				m_values["wrongCodeText"] = value;
			}
			else
			{
				m_values.Add("wrongCodeText", value);
			}
		}
	}

	public string errorConnectionCaption
	{
		get
		{
			if (m_values.ContainsKey("errorConnectionCaption"))
			{
				return m_values["errorConnectionCaption"];
			}
			return "Error de conexión";
		}
		set
		{
			if (m_values.ContainsKey("errorConnectionCaption"))
			{
				m_values["errorConnectionCaption"] = value;
			}
			else
			{
				m_values.Add("errorConnectionCaption", value);
			}
		}
	}

	public string errorConnectionText
	{
		get
		{
			if (m_values.ContainsKey("errorConnectionText"))
			{
				return m_values["errorConnectionText"];
			}
			return "Imposible conectar con el servidor\nAsegurese que tiene conexión con internet\nIntentelo en unos instantes";
		}
		set
		{
			if (m_values.ContainsKey("errorConnectionText"))
			{
				m_values["errorConnectionText"] = value;
			}
			else
			{
				m_values.Add("errorConnectionText", value);
			}
		}
	}

	public bool otherCountriesShow
	{
		get
		{
			if (m_values.ContainsKey("otherCountriesShow"))
			{
				string text = m_values["otherCountriesShow"];
				return text == "1";
			}
			return true;
		}
		set
		{
			string value2 = (value ? "1" : "0");
			if (m_values.ContainsKey("otherCountriesShow"))
			{
				m_values["otherCountriesShow"] = value2;
			}
			else
			{
				m_values.Add("otherCountriesShow", value2);
			}
		}
	}

	public Point otherCountriesLocation
	{
		get
		{
			if (m_values.ContainsKey("otherCountriesLocation"))
			{
				string[] array = m_values["otherCountriesLocation"].Split(new char[1] { ',' });
				return new Point(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Point(331, 328);
		}
		set
		{
			string value2 = value.X + "," + value.Y;
			if (m_values.ContainsKey("otherCountriesLocation"))
			{
				m_values["otherCountriesLocation"] = value2;
			}
			else
			{
				m_values.Add("otherCountriesLocation", value2);
			}
		}
	}

	public string otherCountriesCaption
	{
		get
		{
			if (m_values.ContainsKey("otherCountriesCaption"))
			{
				return m_values["otherCountriesCaption"];
			}
			return "Otros paises";
		}
		set
		{
			if (m_values.ContainsKey("otherCountriesCaption"))
			{
				m_values["otherCountriesCaption"] = value;
			}
			else
			{
				m_values.Add("otherCountriesCaption", value);
			}
		}
	}

	public bool checkBoxShow
	{
		get
		{
			if (m_values.ContainsKey("checkBoxShow"))
			{
				return m_values["checkBoxShow"] == "True";
			}
			return true;
		}
		set
		{
			string value2 = (value ? "True" : "False");
			if (m_values.ContainsKey("checkBoxShow"))
			{
				m_values["checkBoxShow"] = value2;
			}
			else
			{
				m_values.Add("checkBoxShow", value2);
			}
		}
	}

	public Point checkBoxLocation
	{
		get
		{
			if (m_values.ContainsKey("checkBoxLocation"))
			{
				string[] array = m_values["checkBoxLocation"].Split(new char[1] { ',' });
				return new Point(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Point(336, 275);
		}
		set
		{
			string value2 = value.X + "," + value.Y;
			if (m_values.ContainsKey("checkBoxLocation"))
			{
				m_values["checkBoxLocation"] = value2;
			}
			else
			{
				m_values.Add("checkBoxLocation", value2);
			}
		}
	}

	public string checkBoxText
	{
		get
		{
			if (m_values.ContainsKey("checkBoxText"))
			{
				return m_values["checkBoxText"];
			}
			return "Actualización automática";
		}
		set
		{
			if (m_values.ContainsKey("checkBoxText"))
			{
				m_values["checkBoxText"] = value;
			}
			else
			{
				m_values.Add("checkBoxText", value);
			}
		}
	}

	public string captionOtherCountries
	{
		get
		{
			if (m_values.ContainsKey("captionOtherCountries"))
			{
				return m_values["captionOtherCountries"];
			}
			return "Instalador - Other countries";
		}
		set
		{
			if (m_values.ContainsKey("captionOtherCountries"))
			{
				m_values["captionOtherCountries"] = value;
			}
			else
			{
				m_values.Add("captionOtherCountries", value);
			}
		}
	}

	public Point acceptLocationOtherCountries
	{
		get
		{
			if (m_values.ContainsKey("acceptLocationOtherCountries"))
			{
				string[] array = m_values["acceptLocationOtherCountries"].Split(new char[1] { ',' });
				return new Point(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Point(331, 328);
		}
		set
		{
			string value2 = value.X + "," + value.Y;
			if (m_values.ContainsKey("acceptLocationOtherCountries"))
			{
				m_values["acceptLocationOtherCountries"] = value2;
			}
			else
			{
				m_values.Add("acceptLocationOtherCountries", value2);
			}
		}
	}

	public Size acceptSizeOtherCountries
	{
		get
		{
			if (m_values.ContainsKey("acceptSizeOtherCountries"))
			{
				string[] array = m_values["acceptSizeOtherCountries"].Split(new char[1] { ',' });
				return new Size(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Size(75, 23);
		}
		set
		{
			string value2 = value.Width + "," + value.Height;
			if (m_values.ContainsKey("acceptSizeOtherCountries"))
			{
				m_values["acceptSizeOtherCountries"] = value2;
			}
			else
			{
				m_values.Add("acceptSizeOtherCountries", value2);
			}
		}
	}

	public Point cancelLocationOtherCountries
	{
		get
		{
			if (m_values.ContainsKey("cancelLocationOtherCountries"))
			{
				string[] array = m_values["cancelLocationOtherCountries"].Split(new char[1] { ',' });
				return new Point(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Point(412, 328);
		}
		set
		{
			string value2 = value.X + "," + value.Y;
			if (m_values.ContainsKey("cancelLocationOtherCountries"))
			{
				m_values["cancelLocationOtherCountries"] = value2;
			}
			else
			{
				m_values.Add("cancelLocationOtherCountries", value2);
			}
		}
	}

	public Size cancelSizeOtherCountries
	{
		get
		{
			if (m_values.ContainsKey("cancelSizeOtherCountries"))
			{
				string[] array = m_values["cancelSizeOtherCountries"].Split(new char[1] { ',' });
				return new Size(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Size(75, 23);
		}
		set
		{
			string value2 = value.Width + "," + value.Height;
			if (m_values.ContainsKey("cancelSizeOtherCountries"))
			{
				m_values["cancelSizeOtherCountries"] = value2;
			}
			else
			{
				m_values.Add("cancelSizeOtherCountries", value2);
			}
		}
	}

	public Point textboxLocationOtherCountries
	{
		get
		{
			if (m_values.ContainsKey("textboxLocationOtherCountries"))
			{
				string[] array = m_values["textboxLocationOtherCountries"].Split(new char[1] { ',' });
				return new Point(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Point(170, 125);
		}
		set
		{
			string value2 = value.X + "," + value.Y;
			if (m_values.ContainsKey("textboxLocationOtherCountries"))
			{
				m_values["textboxLocationOtherCountries"] = value2;
			}
			else
			{
				m_values.Add("textboxLocationOtherCountries", value2);
			}
		}
	}

	public Size textboxSizeOtherCountries
	{
		get
		{
			if (m_values.ContainsKey("textboxSizeOtherCountries"))
			{
				string[] array = m_values["textboxSizeOtherCountries"].Split(new char[1] { ',' });
				return new Size(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Size(123, 20);
		}
		set
		{
			string value2 = value.Width + "," + value.Height;
			if (m_values.ContainsKey("textboxSizeOtherCountries"))
			{
				m_values["textboxSizeOtherCountries"] = value2;
			}
			else
			{
				m_values.Add("textboxSizeOtherCountries", value2);
			}
		}
	}

	public bool otherCountriesShowOtherCountries
	{
		get
		{
			if (m_values.ContainsKey("otherCountriesShowOtherCountries"))
			{
				string text = m_values["otherCountriesShowOtherCountries"];
				return text == "1";
			}
			return true;
		}
		set
		{
			string value2 = (value ? "1" : "0");
			if (m_values.ContainsKey("otherCountriesShowOtherCountries"))
			{
				m_values["otherCountriesShowOtherCountries"] = value2;
			}
			else
			{
				m_values.Add("otherCountriesShowOtherCountries", value2);
			}
		}
	}

	public Point otherCountriesLocationOtherCountries
	{
		get
		{
			if (m_values.ContainsKey("otherCountriesLocationOtherCountries"))
			{
				string[] array = m_values["otherCountriesLocationOtherCountries"].Split(new char[1] { ',' });
				return new Point(int.Parse(array[0]), int.Parse(array[1]));
			}
			return new Point(331, 328);
		}
		set
		{
			string value2 = value.X + "," + value.Y;
			if (m_values.ContainsKey("otherCountriesLocationOtherCountries"))
			{
				m_values["otherCountriesLocationOtherCountries"] = value2;
			}
			else
			{
				m_values.Add("otherCountriesLocationOtherCountries", value2);
			}
		}
	}

	public string otherCountriesCaptionOtherCountries
	{
		get
		{
			if (m_values.ContainsKey("otherCountriesCaptionOtherCountries"))
			{
				return m_values["otherCountriesCaptionOtherCountries"];
			}
			return "Otros paises";
		}
		set
		{
			if (m_values.ContainsKey("otherCountriesCaptionOtherCountries"))
			{
				m_values["otherCountriesCaptionOtherCountries"] = value;
			}
			else
			{
				m_values.Add("otherCountriesCaptionOtherCountries", value);
			}
		}
	}

	public CParams()
	{
		m_values = new Dictionary<string, string>();
	}

	public CParams(string p)
		: this()
	{
		p = LoadFromString(p);
	}

	private string LoadFromString(string p)
	{
		p = p.Trim();
		string[] array = p.Split(new char[1] { '|' });
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (!(text == ""))
			{
				string text2 = text.Trim().Split(new char[1] { ':' }, 2)[0];
				string text3 = text.Trim().Split(new char[1] { ':' }, 2)[1];
				m_values.Add(text2.Trim(), text3.Trim());
			}
		}
		return p;
	}

	public void LoadFromFile(string file)
	{
		StreamReader streamReader = new StreamReader(File.Open(file, FileMode.Open), Encoding.Default);
		string p = streamReader.ReadToEnd();
		LoadFromString(p);
		m_default = false;
		streamReader.Close();
	}

	public override string ToString()
	{
		return string.Format("caption:{0}|\nprogramName:{1}|\ntextboxLocation:{2},{3}|\ntextboxSize:{4},{5}|\nacceptCaption:{6}|\nacceptLocation:{7},{8}|\nacceptSize:{9},{10}|\ncancelCaption:{11}|\ncancelLocation:{12},{13}|\ncancelSize:{14},{15}|\nconfirmCloseCaption:{16}|\nconfirmCloseText:{17}|\nwrongCodeCaption:{18}|\nwrongCodeText:{19}|\nerrorConnectionCaption:{20}|\nerrorConnectionText:{21}|\notherCountriesShow:{22}|\notherCountriesCaption:{23}|\notherCountriesLocation:{24},{25}|\ncaptionOtherCountries:{26}|\ntextboxLocationOtherCountries:{27},{28}|\ntextboxSizeOtherCountries:{29},{30}|\ncheckBoxShow:{43}|\ncheckBoxLocation:{44},{45}|\ncheckBoxText:{46}|\nacceptLocationOtherCountries:{31},{32}|\nacceptSizeOtherCountries:{33},{34}|\ncancelLocationOtherCountries:{35},{36}|\ncancelSizeOtherCountries:{37},{38}|\notherCountriesShowOtherCountries:{39}|\notherCountriesCaptionOtherCountries:{40}|\notherCountriesLocationOtherCountries:{41},{42}|\n", caption, programName, textboxLocation.X, textboxLocation.Y, textboxSize.Width, textboxSize.Height, acceptCaption, acceptLocation.X, acceptLocation.Y, acceptSize.Width, acceptSize.Height, cancelCaption, cancelLocation.X, cancelLocation.Y, cancelSize.Width, cancelSize.Height, confirmCloseCaption, confirmCloseText, wrongCodeCaption, wrongCodeText, errorConnectionCaption, errorConnectionText, otherCountriesShow ? "1" : "0", otherCountriesCaption, otherCountriesLocation.X, otherCountriesLocation.Y, captionOtherCountries, textboxLocationOtherCountries.X, textboxLocationOtherCountries.Y, textboxSizeOtherCountries.Width, textboxSizeOtherCountries.Height, acceptLocationOtherCountries.X, acceptLocationOtherCountries.Y, acceptSizeOtherCountries.Width, acceptSizeOtherCountries.Height, cancelLocationOtherCountries.X, cancelLocationOtherCountries.Y, cancelSizeOtherCountries.Width, cancelSizeOtherCountries.Height, otherCountriesShowOtherCountries ? "1" : "0", otherCountriesCaptionOtherCountries, otherCountriesLocationOtherCountries.X, otherCountriesLocationOtherCountries.Y, checkBoxShow ? "True" : "False", checkBoxLocation.X, checkBoxLocation.Y, checkBoxText);
	}
}
