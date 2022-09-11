using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

public class GClass0
{
	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private string string_9;

	private string string_10;

	private string string_11;

	private string string_12;

	private string string_13;

	public string String_0
	{
		get
		{
			return (string)Class29.smethod_0(7576464, this, null);
		}
		set
		{
			Class29.smethod_0(7576456, this, value);
		}
	}

	public string String_1
	{
		get
		{
			return (string)Class29.smethod_0(7576556, this, null);
		}
		set
		{
			Class29.smethod_0(7576516, this, value);
		}
	}

	public string String_2
	{
		get
		{
			return (string)Class29.smethod_0(7576376, this, null);
		}
		set
		{
			Class29.smethod_0(7576336, this, value);
		}
	}

	public string String_3
	{
		get
		{
			return (string)Class29.smethod_0(7576436, this, null);
		}
		set
		{
			Class29.smethod_0(7576428, this, value);
		}
	}

	public string String_4
	{
		get
		{
			return (string)Class29.smethod_0(7576384, this, null);
		}
		set
		{
			Class29.smethod_0(7576248, this, value);
		}
	}

	public string String_5
	{
		get
		{
			return (string)Class29.smethod_0(7576220, this, null);
		}
		set
		{
			Class29.smethod_0(7576308, this, value);
		}
	}

	public string String_6
	{
		get
		{
			return (string)Class29.smethod_0(7576296, this, null);
		}
		set
		{
			Class29.smethod_0(7576256, this, value);
		}
	}

	public string String_7
	{
		get
		{
			return (string)Class29.smethod_0(7576100, this, null);
		}
		set
		{
			Class29.smethod_0(7576092, this, value);
		}
	}

	public string String_8
	{
		get
		{
			return (string)Class29.smethod_0(7576176, this, null);
		}
		set
		{
			Class29.smethod_0(7576168, this, value);
		}
	}

	public string String_9
	{
		get
		{
			return (string)Class29.smethod_0(7576140, this, null);
		}
		set
		{
			Class29.smethod_0(7575972, this, value);
		}
	}

	public string String_10
	{
		get
		{
			return (string)Class29.smethod_0(7575960, this, null);
		}
		set
		{
			Class29.smethod_0(7576048, this, value);
		}
	}

	public string String_11
	{
		get
		{
			return (string)Class29.smethod_0(7576020, this, null);
		}
		set
		{
			Class29.smethod_0(7576012, this, value);
		}
	}

	public string String_12 => (string)Class29.smethod_0(7575840, this, null);

	public GClass0()
		: this(Environment.CurrentDirectory + "\\winscp.com", Environment.CurrentDirectory + "\\log.xml")
	{
	}

	public GClass0(string string_14)
		: this(string_14, Environment.CurrentDirectory + "\\log.xml")
	{
	}

	public GClass0(string string_14, string string_15)
	{
		string_0 = "";
		string_1 = "";
		string_2 = "";
		string_3 = "";
		string_4 = "";
		string_5 = "";
		string_6 = "";
		string_7 = "";
		string_8 = "";
		string_9 = "";
		string_10 = "";
		string_11 = "";
		string_12 = "";
		string_13 = "";
		string_0 = string_14;
		string_12 = string_15;
	}

	public Collection method_0()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return (Collection)Class29.smethod_0(7575832, this, null);
	}

	public Collection method_1(string string_14)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		return (Collection)Class29.smethod_0(7575904, this, string_14);
	}

	private string method_2()
	{
		return (string)Class29.smethod_0(7595238, this, null);
	}

	private string method_3()
	{
		return (string)Class29.smethod_0(7594166, this, null);
	}

	public bool method_4()
	{
		return (bool)Class29.smethod_0(7597986, this, null);
	}

	public static object smethod_0(string string_14, byte[] byte_0, Cursor cursor_0)
	{
		return Class29.smethod_0(7598064, null, string_14, byte_0, cursor_0);
	}

	public bool method_5(string string_14, string string_15)
	{
		return (bool)Class29.smethod_0(7597913, this, string_14, string_15);
	}

	public bool method_6(string[] string_14)
	{
		return (bool)Class29.smethod_0(7597135, this, new object[1] { string_14 });
	}

	public bool method_7(string[] string_14, string string_15)
	{
		return (bool)Class29.smethod_0(7596945, this, string_14, string_15);
	}

	public bool method_8(string string_14)
	{
		return (bool)Class29.smethod_0(7596485, this, string_14);
	}

	public bool method_9(string string_14, string string_15)
	{
		return (bool)Class29.smethod_0(7596311, this, string_14, string_15);
	}

	public bool method_10()
	{
		return (bool)Class29.smethod_0(7599646, this, null);
	}

	public bool method_11()
	{
		return (bool)Class29.smethod_0(7599738, this, null);
	}

	public bool method_12()
	{
		return (bool)Class29.smethod_0(7599686, this, null);
	}

	public bool method_13(string string_14)
	{
		return (bool)Class29.smethod_0(7599522, this, string_14);
	}

	public static byte[] smethod_1(int int_0, Bitmap bitmap_0, IntPtr intptr_0)
	{
		return (byte[])Class29.smethod_0(7598769, null, int_0, bitmap_0, intptr_0);
	}

	private bool method_14()
	{
		return (bool)Class29.smethod_0(7602005, this, null);
	}

	private bool method_15(Collection collection_0)
	{
		return (bool)Class29.smethod_0(7601328, this, collection_0);
	}
}
