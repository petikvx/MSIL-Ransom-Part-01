using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace LivePortfolio;

public class Transaction : MonitoredClassBase, INotifyPropertyChanged
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PropertyChangedEventHandler PropertyChangedEvent;

	private int _Id;

	private int _AssetId;

	private DateTime _Transaction_Date;

	private string _Type;

	private int _PortfolioId;

	private string _Portfolio;

	private string _Ticker;

	private decimal _Units;

	private int _Amount;

	private decimal _StampDuty;

	private decimal _Commission;

	private string _Remarks;

	public int Id
	{
		get
		{
			return _Id;
		}
		set
		{
			_Id = value;
		}
	}

	public int AssetId
	{
		get
		{
			return _AssetId;
		}
		set
		{
			_AssetId = value;
		}
	}

	public int PortfolioId
	{
		get
		{
			return _PortfolioId;
		}
		set
		{
			_PortfolioId = value;
		}
	}

	public string Portfolio
	{
		get
		{
			return _Portfolio;
		}
		set
		{
			_Portfolio = value;
		}
	}

	public string Type
	{
		get
		{
			return _Type;
		}
		set
		{
			_Type = value;
		}
	}

	public DateTime Transaction_Date
	{
		get
		{
			return _Transaction_Date;
		}
		set
		{
			_Transaction_Date = value;
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
			_Ticker = value;
		}
	}

	public decimal Amount
	{
		get
		{
			return new decimal(_Amount);
		}
		set
		{
			_Amount = Convert.ToInt32(value);
		}
	}

	public decimal Units
	{
		get
		{
			return _Units;
		}
		set
		{
			_Units = value;
		}
	}

	public decimal Commission
	{
		get
		{
			return _Commission;
		}
		set
		{
			_Commission = value;
		}
	}

	public decimal StampDuty
	{
		get
		{
			return _StampDuty;
		}
		set
		{
			_StampDuty = value;
		}
	}

	public string Remarks
	{
		get
		{
			return _Remarks;
		}
		set
		{
			_Remarks = value;
		}
	}

	public new event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = PropertyChangedEvent;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref PropertyChangedEvent, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = PropertyChangedEvent;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref PropertyChangedEvent, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public Transaction()
	{
	}

	public Transaction(int New_Id, DateTime New_Transaction_Date, string New_Type, int New_PortfolioId, string New_Portfolio, string New_Ticker, decimal New_Amount, decimal New_Units, decimal New_StampDuty, decimal New_Commission, string New_Remarks)
	{
		_Id = New_Id;
		_Transaction_Date = New_Transaction_Date;
		_Type = New_Type;
		_PortfolioId = New_PortfolioId;
		_Portfolio = New_Portfolio;
		_Ticker = New_Ticker;
		_Amount = Convert.ToInt32(New_Amount);
		_Units = New_Units;
		_Commission = New_Commission;
		_StampDuty = New_StampDuty;
		_Remarks = New_Remarks;
	}
}
