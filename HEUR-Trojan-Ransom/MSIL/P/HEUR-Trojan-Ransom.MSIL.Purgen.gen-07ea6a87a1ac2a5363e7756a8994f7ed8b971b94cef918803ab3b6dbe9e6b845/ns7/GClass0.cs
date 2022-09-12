using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ns7;

public class GClass0 : Button
{
	private static PrivateFontCollection privateFontCollection_0;

	private FontFamily fontFamily_0;

	private static string string_0;

	private static string string_1;

	private string string_2;

	private float float_0;

	public static string Solo0342
	{
		get
		{
			return "EVzQYSq";
		}
		set
		{
			string_0 = value;
		}
	}

	public static string Solo1342
	{
		get
		{
			return "ftSX";
		}
		set
		{
			string_1 = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
			return string_2;
		}
		set
		{
			string_2 = value;
			UpdateFont();
		}
	}

	[DefaultValue(14.25f)]
	public float PrivateFontSize
	{
		get
		{
			return float_0;
		}
		set
		{
			float_0 = value;
			UpdateFont();
		}
	}

	public GClass0()
	{
		string_2 = "Equinox Com";
		float_0 = 14.25f;
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
		if (privateFontCollection_0 == null)
		{
			privateFontCollection_0 = new PrivateFontCollection();
		}
		if (!((float_0 == 0f) | string.IsNullOrEmpty(string_2)))
		{
			fontFamily_0 = new FontFamily(string_2, (FontCollection)(object)privateFontCollection_0);
			Font = new Font(fontFamily_0, float_0);
		}
	}
}
