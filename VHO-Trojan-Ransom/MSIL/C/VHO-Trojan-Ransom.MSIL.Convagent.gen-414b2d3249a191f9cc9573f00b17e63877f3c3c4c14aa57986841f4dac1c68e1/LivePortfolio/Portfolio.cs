using System;

namespace LivePortfolio;

public class Portfolio : MonitoredClassBase
{
	private string _Name;

	private int _Id;

	private decimal _EquityValue;

	private decimal _Income;

	private decimal _Yield;

	private decimal _UnitPrice;

	private int _Units;

	private DateTime _DateUnitised;

	private decimal _BaseUnitPrice;

	private decimal _Change;

	private decimal _PercentChange;

	private decimal _AnnualisedChange;

	private bool _Selected;

	private decimal _Cash;

	private decimal _TotalValue;

	public int Id
	{
		get
		{
			return _Id;
		}
		set
		{
			_Id = value;
			NotifyPropertyChanged("Id");
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
			_Name = value;
			NotifyPropertyChanged("Name");
		}
	}

	public decimal EquityValue
	{
		get
		{
			return _EquityValue;
		}
		set
		{
			_EquityValue = value;
			NotifyPropertyChanged("Value");
		}
	}

	public decimal Income => _Income;

	public decimal TotalValue => _TotalValue;

	public decimal Yield => _Yield;

	public bool Selected
	{
		get
		{
			return _Selected;
		}
		set
		{
			_Selected = value;
			NotifyPropertyChanged("Selected");
		}
	}

	public decimal UnitPrice
	{
		get
		{
			return _UnitPrice;
		}
		set
		{
			_UnitPrice = value;
			NotifyPropertyChanged("UnitPrice");
		}
	}

	public DateTime DateUnitised
	{
		get
		{
			return _DateUnitised;
		}
		set
		{
			_DateUnitised = value;
			NotifyPropertyChanged("DateUnitised");
		}
	}

	public decimal BaseUnitPrice
	{
		get
		{
			return _BaseUnitPrice;
		}
		set
		{
			_BaseUnitPrice = value;
			NotifyPropertyChanged("BaseUnitPrice");
		}
	}

	public decimal Change
	{
		get
		{
			return _Change;
		}
		set
		{
			_Change = value;
			NotifyPropertyChanged("Change");
		}
	}

	public decimal PercentChange
	{
		get
		{
			return _PercentChange;
		}
		set
		{
			_PercentChange = value;
			NotifyPropertyChanged("PercentChange");
		}
	}

	public decimal AnnualisedChange
	{
		get
		{
			return _AnnualisedChange;
		}
		set
		{
			_AnnualisedChange = value;
			NotifyPropertyChanged("AnnualisedChange");
		}
	}

	public decimal Cash
	{
		get
		{
			return _Cash;
		}
		set
		{
			_Cash = value;
		}
	}

	public Portfolio(int New_Id, string New_Name, decimal New_Value, int New_Units, DateTime New_Date_Unitised, decimal New_Cash, decimal New_Income)
	{
		_Id = New_Id;
		_Name = New_Name;
		_EquityValue = New_Value;
		_Selected = true;
		_Units = New_Units;
		_DateUnitised = New_Date_Unitised;
		_Cash = New_Cash;
		_Income = New_Income;
		_TotalValue = _EquityValue;
		if (decimal.Compare(TotalValue, 0m) != 0)
		{
			_Yield = decimal.Divide(_Income, TotalValue);
		}
		else
		{
			_Yield = default(decimal);
		}
	}
}
