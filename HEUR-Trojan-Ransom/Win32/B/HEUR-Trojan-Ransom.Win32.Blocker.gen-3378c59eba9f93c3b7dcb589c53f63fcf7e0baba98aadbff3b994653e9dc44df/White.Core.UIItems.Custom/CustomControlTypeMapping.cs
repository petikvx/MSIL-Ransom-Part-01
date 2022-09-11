using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;

namespace White.Core.UIItems.Custom;

public class CustomControlTypeMapping
{
	private static readonly Dictionary<CustomUIItemType, ControlType> Mappings;

	static CustomControlTypeMapping()
	{
		Mappings = new Dictionary<CustomUIItemType, ControlType>();
		Mappings[CustomUIItemType.Pane] = ControlType.Pane;
		Mappings[CustomUIItemType.Custom] = ControlType.Custom;
		Mappings[CustomUIItemType.Group] = ControlType.Group;
		Mappings[CustomUIItemType.Window] = ControlType.Window;
		Mappings[CustomUIItemType.Table] = ControlType.Table;
		Mappings[CustomUIItemType.Button] = ControlType.Button;
		Mappings[CustomUIItemType.Calendar] = ControlType.Calendar;
		Mappings[CustomUIItemType.CheckBox] = ControlType.CheckBox;
		Mappings[CustomUIItemType.ComboBox] = ControlType.ComboBox;
		Mappings[CustomUIItemType.DataGrid] = ControlType.DataGrid;
		Mappings[CustomUIItemType.DataItem] = ControlType.DataItem;
		Mappings[CustomUIItemType.Document] = ControlType.Document;
		Mappings[CustomUIItemType.Edit] = ControlType.Edit;
		Mappings[CustomUIItemType.Header] = ControlType.Header;
		Mappings[CustomUIItemType.HeaderItem] = ControlType.HeaderItem;
		Mappings[CustomUIItemType.Hyperlink] = ControlType.Hyperlink;
		Mappings[CustomUIItemType.Image] = ControlType.Image;
		Mappings[CustomUIItemType.List] = ControlType.List;
		Mappings[CustomUIItemType.ListItem] = ControlType.ListItem;
		Mappings[CustomUIItemType.Menu] = ControlType.Menu;
		Mappings[CustomUIItemType.MenuBar] = ControlType.MenuBar;
		Mappings[CustomUIItemType.MenuItem] = ControlType.MenuItem;
		Mappings[CustomUIItemType.ProgressBar] = ControlType.ProgressBar;
		Mappings[CustomUIItemType.RadioButton] = ControlType.RadioButton;
		Mappings[CustomUIItemType.ScrollBar] = ControlType.ScrollBar;
		Mappings[CustomUIItemType.Separator] = ControlType.Separator;
		Mappings[CustomUIItemType.Slider] = ControlType.Slider;
		Mappings[CustomUIItemType.Spinner] = ControlType.Spinner;
		Mappings[CustomUIItemType.SplitButton] = ControlType.SplitButton;
		Mappings[CustomUIItemType.StatusBar] = ControlType.StatusBar;
		Mappings[CustomUIItemType.Tab] = ControlType.Tab;
		Mappings[CustomUIItemType.TabItem] = ControlType.TabItem;
		Mappings[CustomUIItemType.Text] = ControlType.Text;
		Mappings[CustomUIItemType.Thumb] = ControlType.Thumb;
		Mappings[CustomUIItemType.TitleBar] = ControlType.TitleBar;
		Mappings[CustomUIItemType.ToolBar] = ControlType.ToolBar;
		Mappings[CustomUIItemType.ToolTip] = ControlType.ToolTip;
		Mappings[CustomUIItemType.Tree] = ControlType.Tree;
		Mappings[CustomUIItemType.TreeItem] = ControlType.TreeItem;
	}

	public static ControlType ControlType(CustomUIItemType customUIItemType)
	{
		return Mappings[customUIItemType];
	}

	public static ControlType ControlType(Type type)
	{
		ControlTypeMappingAttribute controlTypeMappingAttribute = (ControlTypeMappingAttribute)type.GetCustomAttributes(typeof(ControlTypeMappingAttribute), inherit: true).FirstOrDefault();
		if (controlTypeMappingAttribute == null)
		{
			throw new CustomUIItemException("ControlTypeMappingAttribute needs to be defined for this type: " + type.FullName);
		}
		return ControlType(controlTypeMappingAttribute.CustomUIItemType);
	}
}
