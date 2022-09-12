using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace LivePortfolio;

public class Dividend : MonitoredClassBase, INotifyPropertyChanged
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PropertyChangedEventHandler PropertyChangedEvent;

	private int _Id;

	private string _Ticker;

	private string _AssetName;

	private int _AssetId;

	private DateTime _ExDividend;

	private DateTime _Payment;

	private decimal _Amount;

	private string _Type;

	private string _Status;

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

	public string AssetName
	{
		get
		{
			return _AssetName;
		}
		set
		{
			_AssetName = value;
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

	public DateTime ExDividend
	{
		get
		{
			return _ExDividend;
		}
		set
		{
			if (DateTime.Compare(value, _ExDividend) != 0)
			{
				_ExDividend = value;
				NotifyPropertyChanged("ExDividend");
			}
		}
	}

	public DateTime Payment
	{
		get
		{
			return _Payment;
		}
		set
		{
			if (DateTime.Compare(value, _Payment) != 0)
			{
				_Payment = value;
				NotifyPropertyChanged("Payment");
			}
		}
	}

	public decimal Amount
	{
		get
		{
			return _Amount;
		}
		set
		{
			_Amount = value;
			NotifyPropertyChanged("Amount");
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
			NotifyPropertyChanged("Type");
		}
	}

	public string Status
	{
		get
		{
			return _Status;
		}
		set
		{
			_Status = value;
			NotifyPropertyChanged("Status");
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

	public Dividend(int NewID, int NewAssetId, string NewTicker, string NewAssetName, DateTime NewExdividend, DateTime NewPayment, decimal NewAmount, string NewType, string NewStatus)
	{
		_Id = NewID;
		_AssetId = NewAssetId;
		_Ticker = NewTicker;
		_AssetName = NewAssetName;
		_ExDividend = NewExdividend;
		_Payment = NewPayment;
		_Amount = NewAmount;
		_Type = NewType;
		_Status = NewStatus;
	}

	private new void NotifyPropertyChanged(string PropertyName)
	{
		OnPropertyChanged(PropertyName);
	}

	protected new void OnPropertyChanged(string Name)
	{
		PropertyChangedEvent?.Invoke(this, new PropertyChangedEventArgs(Name));
	}
}
