using System.Windows.Forms;

namespace Server.Helper;

public class RegistryValueLstItem : ListViewItem
{
	private string _type { get; set; }

	private string _data { get; set; }

	public string RegName
	{
		get
		{
			return ((ListViewItem)this).get_Name();
		}
		set
		{
			((ListViewItem)this).set_Name(value);
			((ListViewItem)this).set_Text(RegValueHelper.GetName(value));
		}
	}

	public string Type
	{
		get
		{
			return _type;
		}
		set
		{
			_type = value;
			if (((ListViewItem)this).get_SubItems().get_Count() < 2)
			{
				((ListViewItem)this).get_SubItems().Add(_type);
			}
			else
			{
				((ListViewItem)this).get_SubItems().get_Item(1).set_Text(_type);
			}
			((ListViewItem)this).set_ImageIndex(GetRegistryValueImgIndex(_type));
		}
	}

	public string Data
	{
		get
		{
			return _data;
		}
		set
		{
			_data = value;
			if (((ListViewItem)this).get_SubItems().get_Count() < 3)
			{
				((ListViewItem)this).get_SubItems().Add(_data);
			}
			else
			{
				((ListViewItem)this).get_SubItems().get_Item(2).set_Text(_data);
			}
		}
	}

	public RegistryValueLstItem(RegistrySeeker.RegValueData value)
	{
		RegName = value.Name;
		Type = value.Kind.RegistryTypeToString();
		Data = RegValueHelper.RegistryValueToString(value);
	}

	private int GetRegistryValueImgIndex(string type)
	{
		switch (type)
		{
		default:
			return 1;
		case "REG_MULTI_SZ":
		case "REG_SZ":
		case "REG_EXPAND_SZ":
			return 0;
		}
	}
}
