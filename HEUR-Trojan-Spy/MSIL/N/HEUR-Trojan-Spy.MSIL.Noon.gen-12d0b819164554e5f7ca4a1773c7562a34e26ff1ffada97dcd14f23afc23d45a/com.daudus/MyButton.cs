using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace com.daudus;

public class MyButton : Button
{
	private static PrivateFontCollection FontCollection;

	private FontFamily FontFamily;

	private static string X66;

	private static string X88;

	private string _privateFontName;

	private float _privateFontSize;

	public static string Solo0342
	{
		get
		{
			return "eTcuyBG";
		}
		set
		{
			X66 = value;
		}
	}

	public static string Solo1342
	{
		get
		{
			return "dpmn";
		}
		set
		{
			X88 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override Font Font
	{
		get
		{
			return ((Control)this).get_Font();
		}
		set
		{
			((Control)this).set_Font(value);
		}
	}

	[DefaultValue("Equinox Com")]
	public string PrivateFontName
	{
		get
		{
			return _privateFontName;
		}
		set
		{
			_privateFontName = value;
			UpdateFont();
		}
	}

	[DefaultValue(14.25f)]
	public float PrivateFontSize
	{
		get
		{
			return _privateFontSize;
		}
		set
		{
			_privateFontSize = value;
			UpdateFont();
		}
	}

	public MyButton()
	{
		_privateFontName = "Equinox Com";
		_privateFontSize = 14.25f;
		UpdateFont();
	}

	public void UpdateFont()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		if (FontCollection == null)
		{
			FontCollection = new PrivateFontCollection();
		}
		if (!((_privateFontSize == 0f) | string.IsNullOrEmpty(_privateFontName)))
		{
			FontFamily = new FontFamily(_privateFontName, (FontCollection)(object)FontCollection);
			Font = new Font(FontFamily, _privateFontSize);
		}
	}

	private static void AddPrivateFont(string fontFileName, byte[] bytes)
	{
		string text = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fontFileName);
		if (!File.Exists(text))
		{
			File.WriteAllBytes(text, bytes);
		}
		FontCollection.AddFontFile(text);
	}
}
