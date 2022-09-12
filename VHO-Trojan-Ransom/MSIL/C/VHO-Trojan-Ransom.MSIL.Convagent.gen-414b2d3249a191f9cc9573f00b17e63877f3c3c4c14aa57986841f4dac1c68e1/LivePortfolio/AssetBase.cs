using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

public class AssetBase : MonitoredClassBase
{
	private int _Id;

	private string _Ticker;

	private string _Name;

	public int Id
	{
		get
		{
			return _Id;
		}
		set
		{
			if (value != _Id)
			{
				_Id = value;
				NotifyPropertyChanged("Id");
			}
		}
	}

	public string Ticker
	{
		get
		{
			return _Ticker;
		}
		set
		{
			if (Operators.CompareString(value, _Ticker, false) != 0)
			{
				_Ticker = value;
				NotifyPropertyChanged("Ticker");
			}
		}
	}

	public string Name
	{
		get
		{
			return _Name;
		}
		set
		{
			if (Operators.CompareString(value, _Name, false) != 0)
			{
				_Name = value;
				NotifyPropertyChanged("Name");
			}
		}
	}

	public string LongName => _Ticker + " " + _Name;

	public AssetBase(int NewId, string Newticker, string NewName)
	{
		Id = NewId;
		Ticker = Newticker;
		Name = NewName;
	}

	public AssetBase()
	{
	}
}
