using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class PropertysRun : Propertys
{
	public bool nadoProigrat;

	private Uri ur;

	private Form f;

	public new string Enabled
	{
		get
		{
			return base.Enabled;
		}
		set
		{
			base.Enabled = value;
			if (!Iz.IsW(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "myobj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				NewLateBinding.LateSet(obj, (Type)null, "Enabled", new object[1] { peremens.DaOrNet(base.Enabled) }, (string[])null, (Type[])null);
			}
		}
	}

	public new string Visible
	{
		get
		{
			return base.Visible;
		}
		set
		{
			base.Visible = value;
			NewLateBinding.LateSet(obj, (Type)null, "Visible", new object[1] { peremens.DaOrNet(base.Visible) }, (string[])null, (Type[])null);
		}
	}

	public new string ContextMenu
	{
		get
		{
			return base.ContextMenu;
		}
		set
		{
			base.ContextMenu = value;
			if (!fromLoad)
			{
				AddContextMenu();
			}
		}
	}

	public new string ContextMenu1
	{
		get
		{
			return base.ContextMenu1;
		}
		set
		{
			base.ContextMenu1 = value;
			if (!fromLoad)
			{
				AddContextMenu("panel1");
			}
		}
	}

	public new string ContextMenu2
	{
		get
		{
			return base.ContextMenu2;
		}
		set
		{
			base.ContextMenu2 = value;
			if (!fromLoad)
			{
				AddContextMenu("panel2");
			}
		}
	}

	public new int Height
	{
		get
		{
			if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				return Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)CaptionHeight));
			}
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				value = checked(value + CaptionHeight);
			}
			NewLateBinding.LateSet(obj, (Type)null, "Height", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public new int Width
	{
		get
		{
			if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				return Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), (object)CaptionWidth));
			}
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				value = checked(value + CaptionWidth);
			}
			NewLateBinding.LateSet(obj, (Type)null, "Width", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public new int MaximumHeight
	{
		get
		{
			if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				if (Operators.ConditionalCompareObjectGreater(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "MaximumSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)CaptionHeight), (object)0, false))
				{
					return Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "MaximumSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)CaptionHeight));
				}
				return 0;
			}
			return Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "MaximumSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(base.obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))) && value != 0)
			{
				object obj = base.obj;
				object[] array = new object[1];
				object[] array2 = array;
				Size size = checked(new Size(MaximumWidth + CaptionWidth, value + CaptionHeight));
				array2[0] = size;
				NewLateBinding.LateSet(obj, (Type)null, "MaximumSize", array, (string[])null, (Type[])null);
			}
			else
			{
				object obj2 = base.obj;
				object[] array = new object[1];
				object[] array3 = array;
				Size size = new Size(MaximumWidth, value);
				array3[0] = size;
				NewLateBinding.LateSet(obj2, (Type)null, "MaximumSize", array, (string[])null, (Type[])null);
			}
		}
	}

	public new int MaximumWidth
	{
		get
		{
			if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				if (Operators.ConditionalCompareObjectGreater(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "MaximumSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), (object)CaptionWidth), (object)0, false))
				{
					return Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "MaximumSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), (object)CaptionWidth));
				}
				return 0;
			}
			return Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "MaximumSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(base.obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))) && value != 0)
			{
				object obj = base.obj;
				object[] array = new object[1];
				object[] array2 = array;
				Size size = checked(new Size(value + CaptionWidth, MaximumHeight + CaptionHeight));
				array2[0] = size;
				NewLateBinding.LateSet(obj, (Type)null, "MaximumSize", array, (string[])null, (Type[])null);
			}
			else
			{
				object obj2 = base.obj;
				object[] array = new object[1];
				object[] array3 = array;
				Size size = new Size(value, MaximumHeight);
				array3[0] = size;
				NewLateBinding.LateSet(obj2, (Type)null, "MaximumSize", array, (string[])null, (Type[])null);
			}
		}
	}

	public new int X
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "left", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "left", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public new int Y
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "top", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "top", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public new int SplitterDistance
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "SplitterDistance", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SplitterDistance", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public new string Played
	{
		get
		{
			string lpszReturnString = Strings.Space(128);
			string lpszCommand = "STATUS " + strAlias + " MODE";
			if (peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, Strings.Len(lpszReturnString), IntPtr.Zero) == 0)
			{
				lpszReturnString = Strings.Replace(Strings.Trim(lpszReturnString), "\0", "", 1, -1, (CompareMethod)0);
				return peremens.DaOrNet(Operators.CompareString(lpszReturnString, "playing", false) == 0);
			}
			return peremens.trans("Нет");
		}
		set
		{
			if (peremens.DaOrNet(value))
			{
				if (MediaWindow == null)
				{
					nadoProigrat = true;
				}
				else
				{
					PlayMovie();
				}
			}
		}
	}

	public new string Url
	{
		get
		{
			if (NewLateBinding.LateGet(obj, (Type)null, "url", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
			{
				return ur.AbsoluteUri;
			}
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Url", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AbsoluteUri", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			ur = peremens.GetUrlFromString(value);
			if ((object)ur != null)
			{
				NewLateBinding.LateSet(obj, (Type)null, "Url", new object[1] { ur }, (string[])null, (Type[])null);
			}
		}
	}

	public new string MainMenuStrip
	{
		get
		{
			return base.MainMenuStrip;
		}
		set
		{
			base.MainMenuStrip = value;
			if (!fromLoad)
			{
				AddContextMenu("", mainmenu: true);
			}
		}
	}

	public new string Icon
	{
		get
		{
			return base.Icon;
		}
		set
		{
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			base.Icon = value;
			if (!peremens.IsHttpCompil)
			{
				if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) != 0)
				{
					try
					{
						NewLateBinding.LateSet(obj, (Type)null, "Icon", new object[1] { (object)new Icon(value) }, (string[])null, (Type[])null);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						NewLateBinding.LateSet(obj, (Type)null, "Icon", new object[1] { null }, (string[])null, (Type[])null);
						if (!peremens.IgnorEr)
						{
							Errors.MessangeCritic(ex2.Message + Errors.notIcon(value));
						}
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					NewLateBinding.LateSet(obj, (Type)null, "Icon", new object[1] { null }, (string[])null, (Type[])null);
				}
			}
			if (Iz.IsFORMRunObj(RuntimeHelpers.GetObjectValue(obj)))
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "ni", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "icon", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Icon", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public new string StartPosition
	{
		get
		{
			return base.StartPosition;
		}
		set
		{
			base.StartPosition = value;
			NewLateBinding.LateSet(obj, (Type)null, "StartPosition", new object[1] { RuntimeHelpers.GetObjectValue(peremens.StartPositions.GetByIndex(peremens.StartPositions.IndexOfKey(Strings.LCase(value)))) }, (string[])null, (Type[])null);
		}
	}

	public new string WindowState
	{
		get
		{
			return Conversions.ToString(peremens.WindowStates.GetKey(peremens.WindowStates.IndexOfValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "WindowState", new object[0], (string[])null, (Type[])null, (bool[])null)))));
		}
		set
		{
			base.WindowState = value;
			NewLateBinding.LateSet(obj, (Type)null, "WindowState", new object[1] { RuntimeHelpers.GetObjectValue(peremens.WindowStates.GetByIndex(peremens.WindowStates.IndexOfKey(Strings.LCase(value)))) }, (string[])null, (Type[])null);
		}
	}

	public new string FormBorderStyle
	{
		get
		{
			return base.FormBorderStyle;
		}
		set
		{
			base.FormBorderStyle = value;
			NewLateBinding.LateSet(obj, (Type)null, "FormBorderStyle", new object[1] { RuntimeHelpers.GetObjectValue(peremens.FormBorderStyles.GetByIndex(peremens.FormBorderStyles.IndexOfKey(Strings.LCase(value)))) }, (string[])null, (Type[])null);
		}
	}

	public new int Opacity
	{
		get
		{
			return base.Opacity;
		}
		set
		{
			base.Opacity = value;
			NewLateBinding.LateSet(obj, (Type)null, "Opacity", new object[1] { (double)value / 100.0 }, (string[])null, (Type[])null);
		}
	}

	public new string ShowIcon
	{
		get
		{
			return base.ShowIcon;
		}
		set
		{
			base.ShowIcon = value;
			NewLateBinding.LateSet(obj, (Type)null, "ShowIcon", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public new string ShowInTaskbar
	{
		get
		{
			return base.ShowInTaskbar;
		}
		set
		{
			base.ShowInTaskbar = value;
			NewLateBinding.LateSet(obj, (Type)null, "ShowInTaskbar", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public new string ControlBox
	{
		get
		{
			return base.ControlBox;
		}
		set
		{
			base.ControlBox = value;
			NewLateBinding.LateSet(obj, (Type)null, "ControlBox", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public new string TopMost
	{
		get
		{
			return base.TopMost;
		}
		set
		{
			base.TopMost = value;
			NewLateBinding.LateSet(obj, (Type)null, "TopMost", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public new string TransparentcyKey
	{
		get
		{
			return base.TransparentcyKey;
		}
		set
		{
			base.TransparentcyKey = value;
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				NewLateBinding.LateSet(obj, (Type)null, "TransparencyKey", new object[1] { null }, (string[])null, (Type[])null);
			}
			else
			{
				NewLateBinding.LateSet(obj, (Type)null, "TransparencyKey", new object[1] { peremens.FromMyColor(value) }, (string[])null, (Type[])null);
			}
		}
	}

	public new int SelectedTabPosition
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "selectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "selectedIndex", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public new string ReadOnlyTable
	{
		get
		{
			return base.ReadOnlyTable;
		}
		set
		{
			base.ReadOnlyTable = value;
			NewLateBinding.LateSet(obj, (Type)null, "ReadOnly", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public new int SelectedIndex
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			base.SelectedIndex = value;
			if (!Iz.IsL(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "myobj", new object[0], (string[])null, (Type[])null, (bool[])null))) || !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "selectionmode", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectedIndex", new object[1] { value }, (string[])null, (Type[])null);
			}
		}
	}

	public new string SelectedItem
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			base.SelectedItem = value;
			if (!Iz.IsL(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "myobj", new object[0], (string[])null, (Type[])null, (bool[])null))) || !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "selectionmode", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectedItem", new object[1] { value }, (string[])null, (Type[])null);
			}
		}
	}

	public new string Text
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			base.Text = value;
			NewLateBinding.LateSet(obj, (Type)null, "Text", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public new string DialogColor
	{
		get
		{
			object obj = NewLateBinding.LateGet(base.obj, (Type)null, "Color", new object[0], (string[])null, (Type[])null, (bool[])null);
			Color color = default(Color);
			return peremens.ToMyColor((obj != null) ? ((Color)obj) : color);
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				try
				{
					NewLateBinding.LateSet(obj, (Type)null, "color", new object[1] { Color.Transparent }, (string[])null, (Type[])null);
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeExclamen(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			NewLateBinding.LateSet(obj, (Type)null, "Color", new object[1] { peremens.FromMyColor(value) }, (string[])null, (Type[])null);
		}
	}

	public new string ShowColor
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = base.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "ShowColor", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "ShowColor", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ShowColor", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public new string ShowEffects
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = base.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "ShowEffects", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "ShowEffects", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ShowEffects", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "ShowColor", new object[1] { true }, (string[])null, (Type[])null);
		}
	}

	public new string Description
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Description", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Description", new object[1] { value }, (string[])null, (Type[])null, false, true);
		}
	}

	public new string SelectedPath
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedPath", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedPath", new object[1] { value }, (string[])null, (Type[])null, false, true);
		}
	}

	public new string DefaultExt
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultExt", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultExt", new object[1] { value }, (string[])null, (Type[])null, false, true);
		}
	}

	public new string CheckFileExists
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = base.obj;
			object[] array2 = new object[0];
			string[] array3 = null;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "dialog", array2, array3, (Type[])null, (bool[])null), (Type)null, "CheckFileExists", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array4 = array;
			bool[] array5 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array4, (string[])null, (Type[])null, array5);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", array2, array3, (Type[])null, (bool[])null), (Type)null, "CheckFileExists", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, true);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CheckFileExists", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null, false, true);
		}
	}

	public new string CheckPathExists
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = base.obj;
			object[] array2 = new object[0];
			string[] array3 = null;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "dialog", array2, array3, (Type[])null, (bool[])null), (Type)null, "CheckPathExists", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array4 = array;
			bool[] array5 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array4, (string[])null, (Type[])null, array5);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", array2, array3, (Type[])null, (bool[])null), (Type)null, "CheckPathExists", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, true);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CheckPathExists", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null, false, true);
		}
	}

	public new string FileName
	{
		get
		{
			Type typeFromHandle = typeof(Strings);
			object[] array = new object[2];
			object obj = base.obj;
			object[] array2 = new object[0];
			string[] array3 = null;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "dialog", array2, array3, (Type[])null, (bool[])null), (Type)null, "FileNames", new object[0], (string[])null, (Type[])null, (bool[])null));
			array[1] = "; ";
			object[] array4 = array;
			bool[] array5 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "Join", array4, (string[])null, (Type[])null, array5);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", array2, array3, (Type[])null, (bool[])null), (Type)null, "FileNames", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, true);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileName", new object[1] { value }, (string[])null, (Type[])null, false, true);
		}
	}

	public new string Filter
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Filter", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			try
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Filter", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Errors.MessangeCritic(ex2.Message);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public new string FilterIndex
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FilterIndex", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			try
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FilterIndex", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Errors.MessangeCritic(ex2.Message);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public new string InitialDirectory
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "InitialDirectory", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "InitialDirectory", new object[1] { value }, (string[])null, (Type[])null, false, true);
		}
	}

	public new string Title
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Title", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Title", new object[1] { value }, (string[])null, (Type[])null, false, true);
		}
	}

	public new string MultiSelectFiles
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = base.obj;
			object[] array2 = new object[0];
			string[] array3 = null;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "dialog", array2, array3, (Type[])null, (bool[])null), (Type)null, "MultiSelect", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array4 = array;
			bool[] array5 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array4, (string[])null, (Type[])null, array5);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", array2, array3, (Type[])null, (bool[])null), (Type)null, "MultiSelect", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, true);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MultiSelect", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null, false, true);
		}
	}

	public new int Interval
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "Interval", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			base.Interval = value;
			NewLateBinding.LateSet(obj, (Type)null, "Interval", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public new string AssociateWithExtensions
	{
		get
		{
			return base.AssociateWithExtensions;
		}
		set
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Conversions.ToString(NewLateBinding.LateGet(peremens2.proj, (Type)null, "pFileName", new object[0], (string[])null, (Type[])null, (bool[])null)));
			string[] array = value.Replace("\"", "").Split(new char[1] { ',' });
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array[i] = array[i].Trim();
					if (Operators.CompareString(array[i], "", false) != 0)
					{
						peremens.AssociateMyApp(fileNameWithoutExtension, Environment.GetCommandLineArgs()[0], array[i], Icon);
					}
				}
			}
		}
	}

	public new string AssociationPassedFile
	{
		get
		{
			checked
			{
				if (Environment.GetCommandLineArgs().Length >= 2)
				{
					string text = "";
					int num = Environment.GetCommandLineArgs().Length - 1;
					for (int i = 1; i <= num; i++)
					{
						text = text + Environment.GetCommandLineArgs()[i] + " ";
					}
					return text.Trim();
				}
				return "";
			}
		}
		set
		{
		}
	}

	public new string ForbidMaximize
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet((object)null, typeof(peremens), "DaOrNet", new object[1] { Operators.NotObject(NewLateBinding.LateGet(obj, (Type)null, "MaximizeBox", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "MaximizeBox", new object[1] { !peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public new string ForbidMinimize
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet((object)null, typeof(peremens), "DaOrNet", new object[1] { Operators.NotObject(NewLateBinding.LateGet(obj, (Type)null, "MinimizeBox", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "MinimizeBox", new object[1] { !peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public new string OnFullScreen
	{
		get
		{
			return base.OnFullScreen;
		}
		set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			base.OnFullScreen = value;
			if (peremens.DaOrNet(value))
			{
				f = new Form();
				f.set_WindowState((FormWindowState)2);
				f.set_BackColor(Color.Black);
				f.set_FormBorderStyle((FormBorderStyle)0);
				f.set_ShowInTaskbar(false);
				f.set_TopMost(true);
				PlayInNewHandle((Control)(object)f);
				((Control)f).Show();
			}
			else if (f != null)
			{
				PlayInNewHandle((Control)obj);
				f.Close();
			}
		}
	}

	public PropertysRun(object ob)
		: base(RuntimeHelpers.GetObjectValue(ob))
	{
		nadoProigrat = false;
	}

	public void AddContextMenu(string panel = "", bool mainmenu = false)
	{
		string text = this.get_ContextMenu(fromLoad: false);
		if (mainmenu)
		{
			text = this.get_MainMenuStrip(fromLoad: false);
		}
		if (Operators.CompareString(panel, "panel1", false) == 0)
		{
			text = this.get_ContextMenu1(fromLoad: false);
		}
		else if (Operators.CompareString(panel, "panel2", false) == 0)
		{
			text = this.get_ContextMenu2(fromLoad: false);
		}
		if (Operators.CompareString(peremens.NikakoiEsli(text), peremens.trans("Никакой"), false) != 0)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (objectValue == null)
			{
				return;
			}
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (objectValue2 == null)
			{
				return;
			}
			object objectValue3 = RuntimeHelpers.GetObjectValue(peremens.GetContextMenu(RuntimeHelpers.GetObjectValue(objectValue), text));
			if (objectValue3 != null)
			{
				switch (panel)
				{
				case null:
				case "":
					if (mainmenu)
					{
						NewLateBinding.LateSet(obj, (Type)null, "MainMenuStrip", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
						break;
					}
					NewLateBinding.LateSet(obj, (Type)null, "ContextMenuStrip", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CnMn", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					if (Iz.IsFORMRunObj(RuntimeHelpers.GetObjectValue(obj)))
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "ni", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContextMenuStrip", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "ContextMenuStrip", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
					}
					break;
				case "panel1":
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContextMenuStrip", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CnMn", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
					break;
				case "panel2":
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContextMenuStrip", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CnMn", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
					break;
				}
			}
			else if (NewLateBinding.LateGet(objectValue2, (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
			{
				Errors.MessangeExclamen(Errors.InvalidContextMenu(text, Name));
			}
			return;
		}
		switch (panel)
		{
		case null:
		case "":
			if (mainmenu)
			{
				NewLateBinding.LateSet(obj, (Type)null, "MainMenuStrip", new object[1] { null }, (string[])null, (Type[])null);
			}
			else
			{
				NewLateBinding.LateSet(obj, (Type)null, "ContextMenuStrip", new object[1] { null }, (string[])null, (Type[])null);
			}
			break;
		case "panel1":
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContextMenuStrip", new object[1] { null }, (string[])null, (Type[])null, false, true);
			break;
		case "panel2":
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContextMenuStrip", new object[1] { null }, (string[])null, (Type[])null, false, true);
			break;
		}
	}
}
