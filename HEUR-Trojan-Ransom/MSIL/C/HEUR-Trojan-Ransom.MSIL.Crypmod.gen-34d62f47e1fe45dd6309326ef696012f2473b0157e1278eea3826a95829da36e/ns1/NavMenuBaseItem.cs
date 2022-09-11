using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns1;

[Browsable(false)]
[Bindable(false)]
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class NavMenuBaseItem
{
	private object object_0;

	private bool bool_0;

	private Font font_0;

	private bool bool_1;

	private string string_0;

	private int int_0;

	private Rectangle rectangle_0;

	private bool bool_2;

	internal string string_1;

	internal TabPage tabPage_0;

	internal Rectangle rectangle_1;

	internal Rectangle rectangle_2;

	internal bool bool_3;

	internal NavMenu navMenu_0;

	internal bool bool_4;

	internal Rectangle Rectangle_0
	{
		get
		{
			return rectangle_0;
		}
		set
		{
			rectangle_0 = value;
		}
	}

	internal bool Boolean_0
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	[DefaultValue(true)]
	public bool Enabled
	{
		get
		{
			if (!method_0())
			{
				return false;
			}
			return bool_1;
		}
		set
		{
			bool_1 = value;
			method_5();
		}
	}

	public Font Font
	{
		get
		{
			if (font_0 == null)
			{
				Font val = method_2();
				return (val == null) ? Control.get_DefaultFont() : val;
			}
			return font_0;
		}
		set
		{
			font_0 = value;
			method_6();
		}
	}

	internal NavMenu NavMenu_0 => navMenu_0;

	public Image Image
	{
		get
		{
			ImageList val = method_3();
			if (val != null && val.get_Images().get_Count() > 0)
			{
				return (int_0 <= -1) ? val.get_Images().get_Item(string_0) : val.get_Images().get_Item(Math.Min(val.get_Images().get_Count(), int_0));
			}
			return null;
		}
	}

	internal Rectangle Rectangle_1
	{
		get
		{
			return rectangle_2;
		}
		set
		{
			Rectangle rectangle = (rectangle_2 = value);
		}
	}

	[TypeConverter(typeof(ImageIndexConverter))]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[DefaultValue(-1)]
	public int ImageIndex
	{
		get
		{
			ImageList val = method_3();
			if (int_0 != -1 && val != null && int_0 >= val.get_Images().get_Count())
			{
				return checked(val.get_Images().get_Count() - 1);
			}
			return int_0;
		}
		set
		{
			if (value < -1)
			{
				throw new ArgumentOutOfRangeException(" ");
			}
			string_0 = string.Empty;
			int_0 = value;
			method_5();
		}
	}

	[TypeConverter(typeof(ImageKeyConverter))]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public string ImageKey
	{
		get
		{
			return string_0;
		}
		set
		{
			int_0 = -1;
			string_0 = value;
			method_5();
		}
	}

	[DefaultValue(null)]
	public ImageList ImageList => method_3();

	internal bool Boolean_1 => bool_4;

	internal bool Boolean_2
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool flag = (bool_3 = value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool Selected
	{
		get
		{
			if (!Enabled)
			{
				return false;
			}
			return bool_0;
		}
		set
		{
			if (bool_0 != value)
			{
				bool_0 = value;
				if (bool_0)
				{
					method_8();
				}
				method_5();
			}
		}
	}

	public TabPage TabPage
	{
		get
		{
			return tabPage_0;
		}
		set
		{
			if (tabPage_0 != null)
			{
				((Component)(object)tabPage_0).Disposed -= method_11;
			}
			TabPage val = (tabPage_0 = value);
			if (value != null)
			{
				((Component)(object)value).Disposed += method_11;
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public object Tag
	{
		get
		{
			return object_0;
		}
		set
		{
			object_0 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	[DefaultValue("")]
	public string Text
	{
		get
		{
			if (string_1 != null)
			{
				return string_1;
			}
			return string.Empty;
		}
		set
		{
			string text = (string_1 = value);
			method_6();
		}
	}

	internal Rectangle Rectangle_2
	{
		get
		{
			return rectangle_1;
		}
		set
		{
			Rectangle rectangle = (rectangle_1 = value);
		}
	}

	public NavMenuBaseItem()
	{
		bool_1 = true;
		int_0 = -1;
		string_0 = string.Empty;
	}

	private bool method_0()
	{
		if (navMenu_0 != null)
		{
			return ((Control)navMenu_0).get_Enabled();
		}
		return false;
	}

	private bool method_1()
	{
		bool result = false;
		if (navMenu_0 == null)
		{
			result = true;
		}
		return result;
	}

	private Font method_2()
	{
		if (navMenu_0 == null)
		{
			return null;
		}
		return ((Control)navMenu_0).get_Font();
	}

	private ImageList method_3()
	{
		if (navMenu_0 == null)
		{
			return null;
		}
		return (!bool_4) ? navMenu_0.SubImageList : navMenu_0.ImageList;
	}

	internal MouseState method_4()
	{
		if (!bool_3 && !bool_2)
		{
			return MouseState.const_0;
		}
		return MouseState.const_1;
	}

	protected void method_5()
	{
		if (navMenu_0 != null)
		{
			((Control)navMenu_0).Invalidate();
		}
	}

	protected void method_6()
	{
		if (navMenu_0 != null)
		{
			((Control)navMenu_0).PerformLayout();
		}
	}

	public void method_7()
	{
		Selected = true;
	}

	protected void method_8()
	{
		if (navMenu_0 != null)
		{
			navMenu_0.method_4(this, bool_0: true);
		}
	}

	internal virtual void vmethod_0(NavMenu navMenu_1, bool bool_5)
	{
		NavMenu navMenu = (navMenu_0 = navMenu_1);
		bool flag = (bool_4 = bool_5);
		method_6();
	}

	private bool method_9()
	{
		if (!((object)Font).Equals((object?)method_2()) && !((object)Font).Equals((object?)Control.get_DefaultFont()))
		{
			return true;
		}
		return false;
	}

	private bool method_10()
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			ImageList val = method_3();
			return (val == null || val.get_Images().ContainsKey(ImageKey)) ? true : false;
		}
		return false;
	}

	private void method_11(object sender, EventArgs e)
	{
		TabPage = null;
	}

	public override string vmethod_1()
	{
		return $": {{{Text}}}";
	}
}
