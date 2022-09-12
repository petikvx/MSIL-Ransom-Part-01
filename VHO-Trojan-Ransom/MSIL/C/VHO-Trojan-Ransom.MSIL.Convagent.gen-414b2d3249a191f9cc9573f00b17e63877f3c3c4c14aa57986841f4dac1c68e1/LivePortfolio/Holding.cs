using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

public class Holding : INotifyPropertyChanged
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PropertyChangedEventHandler PropertyChangedEvent;

	private string _PortfolioName;

	private string _Ticker;

	private int _AssetID;

	private string _AssetName;

	private string _AssetType;

	private decimal _Holding;

	private decimal _Value;

	private decimal _OpenPrice;

	private decimal _OfferPrice;

	private decimal _ClosePrice;

	private decimal _AveragePurchasePrice;

	private decimal _SaleAmount;

	private decimal _PurchaseAmount;

	private decimal _Bid;

	private decimal _Dividend;

	private decimal _Yield;

	private decimal _Income;

	private decimal _TotalCost;

	private decimal _Gain;

	private decimal _PercentGain;

	public string PortfolioName
	{
		get
		{
			return _PortfolioName;
		}
		set
		{
			_PortfolioName = value;
			NotifyPropertyChanged("PortfolioName");
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
			NotifyPropertyChanged("Ticker");
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
			NotifyPropertyChanged("AssetName");
		}
	}

	public string AssetType
	{
		get
		{
			return _AssetType;
		}
		set
		{
			_AssetType = value;
			NotifyPropertyChanged("AssetType");
		}
	}

	public int AssetId
	{
		get
		{
			return _AssetID;
		}
		set
		{
			_AssetID = value;
			NotifyPropertyChanged("AssetId");
		}
	}

	public string Bid
	{
		get
		{
			return Conversions.ToString(_Bid);
		}
		set
		{
			_Bid = Conversions.ToDecimal(value);
			NotifyPropertyChanged("Bid");
			CalculateDerivedProperties();
		}
	}

	public decimal ClosePrice
	{
		get
		{
			return _ClosePrice;
		}
		set
		{
			_ClosePrice = value;
			NotifyPropertyChanged("ClosePrice");
			CalculateDerivedProperties();
		}
	}

	public decimal OfferPrice
	{
		get
		{
			return _OfferPrice;
		}
		set
		{
			_OfferPrice = value;
			NotifyPropertyChanged("OfferPrice");
			CalculateDerivedProperties();
		}
	}

	public decimal AveragePurchasePrice
	{
		get
		{
			return _AveragePurchasePrice;
		}
		set
		{
			_AveragePurchasePrice = value;
		}
	}

	public decimal Holding
	{
		get
		{
			return _Holding;
		}
		set
		{
			_Holding = value;
			NotifyPropertyChanged("Holding");
			CalculateDerivedProperties();
		}
	}

	public decimal Dividend
	{
		get
		{
			return _Dividend;
		}
		set
		{
			_Dividend = value;
			NotifyPropertyChanged("Dividend");
			CalculateDerivedProperties();
		}
	}

	public decimal Yield => _Yield;

	public decimal Value => _Value;

	public decimal Income => _Income;

	public decimal TotalCost => _TotalCost;

	public decimal PercentGain => _PercentGain;

	public decimal Gain => decimal.Subtract(_Value, _TotalCost);

	public event PropertyChangedEventHandler PropertyChanged
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

	private void NotifyPropertyChanged(string PropertyName)
	{
		OnPropertyChanged(PropertyName);
	}

	protected void OnPropertyChanged(string Name)
	{
		PropertyChangedEvent?.Invoke(this, new PropertyChangedEventArgs(Name));
	}

	public void CalculateDerivedProperties()
	{
		_Value = decimal.Divide(decimal.Multiply(_OfferPrice, _Holding), new decimal(100L));
		NotifyPropertyChanged("Value");
		_Income = decimal.Divide(decimal.Multiply(_Dividend, _Holding), new decimal(100L));
		NotifyPropertyChanged("Income");
		if (decimal.Compare(_OfferPrice, 0m) != 0)
		{
			_Yield = decimal.Divide(_Dividend, _OfferPrice);
		}
		NotifyPropertyChanged("Yield");
		_TotalCost = decimal.Subtract(_PurchaseAmount, _SaleAmount);
		if (decimal.Compare(_TotalCost, 0m) != 0)
		{
			_AveragePurchasePrice = decimal.Divide(_Holding, _TotalCost);
			_PercentGain = decimal.Divide(decimal.Subtract(_Value, _TotalCost), _TotalCost);
		}
		else
		{
			_AveragePurchasePrice = default(decimal);
			_PercentGain = default(decimal);
		}
	}

	public Holding(string NewPortfolioName, string NewTicker, string NewAssetName, string NewAssetType, int NewAssetId, decimal NewHolding, decimal NewOfferPrice, decimal NewBid, decimal NewClose, decimal NewDividend, decimal NewSaleAmount, decimal NewPurchaseAmount)
	{
		_PortfolioName = NewPortfolioName;
		_Ticker = NewTicker;
		_AssetName = NewAssetName;
		_AssetType = NewAssetType;
		_AssetID = NewAssetId;
		_Holding = NewHolding;
		_OfferPrice = NewOfferPrice;
		_Bid = NewBid;
		_ClosePrice = NewClose;
		_Dividend = NewDividend;
		_SaleAmount = NewSaleAmount;
		_PurchaseAmount = NewPurchaseAmount;
		CalculateDerivedProperties();
	}

	public Holding()
	{
	}
}
