using System;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

public class Asset : AssetBase
{
	private string _AssetType;

	private decimal _OpenPrice;

	private decimal _Bid;

	private decimal _Offer;

	private decimal _AveragePrice;

	private decimal _Yield;

	private decimal _Dividend;

	private bool _InPortfolio;

	public string AssetType
	{
		get
		{
			return _AssetType;
		}
		set
		{
			if (Operators.CompareString(value, _AssetType, false) != 0)
			{
				_AssetType = value;
				NotifyPropertyChanged("AssetType");
			}
		}
	}

	public decimal OpenPrice
	{
		get
		{
			return _OpenPrice;
		}
		set
		{
			if (decimal.Compare(value, _OpenPrice) != 0)
			{
				_OpenPrice = value;
				NotifyPropertyChanged("OpenPrice");
			}
		}
	}

	public decimal Bid
	{
		get
		{
			return _Bid;
		}
		set
		{
			if (decimal.Compare(value, _Bid) != 0)
			{
				_Bid = value;
				NotifyPropertyChanged("Bid");
			}
		}
	}

	public decimal Offer
	{
		get
		{
			return _Offer;
		}
		set
		{
			if (decimal.Compare(value, _Offer) != 0)
			{
				_Offer = value;
				NotifyPropertyChanged("Offer");
			}
			_Offer = value;
		}
	}

	public decimal AveragePrice => _AveragePrice;

	public decimal Yield => _Yield;

	public decimal Dividend
	{
		get
		{
			return _Dividend;
		}
		set
		{
			if (decimal.Compare(value, _Dividend) != 0)
			{
				_Dividend = value;
				CalculateDerivedProperties();
				NotifyPropertyChanged("Dividend");
			}
		}
	}

	public bool InPortfolio
	{
		get
		{
			return _InPortfolio;
		}
		set
		{
			_InPortfolio = value;
		}
	}

	public decimal PriceEarnings { get; set; }

	public DateTime Updated { get; set; }

	public Asset()
	{
	}

	public Asset(int NewId, string Newticker, string NewName, string NewAssetType, decimal NewBid, decimal NewOffer, decimal NewDividend, decimal NewPriceEarnings, DateTime NewUpdated, bool NewInportfolio)
	{
		base.Id = NewId;
		base.Ticker = Newticker;
		base.Name = NewName;
		AssetType = NewAssetType;
		Bid = NewBid;
		Offer = NewOffer;
		Dividend = NewDividend;
		PriceEarnings = NewPriceEarnings;
		Updated = NewUpdated;
		InPortfolio = NewInportfolio;
		CalculateDerivedProperties();
	}

	public Asset(int NewId, string NewTicker, string NewName)
	{
		base.Id = NewId;
		base.Ticker = NewTicker;
		base.Name = NewName;
	}

	public void CalculateDerivedProperties()
	{
		_AveragePrice = decimal.Divide(decimal.Add(Bid, Offer), new decimal(2L));
		NotifyPropertyChanged("AveragePrice");
		if (decimal.Compare(_AveragePrice, 0m) != 0)
		{
			_Yield = decimal.Divide(Dividend, AveragePrice);
			NotifyPropertyChanged("Yield");
		}
		else
		{
			_Yield = default(decimal);
		}
	}
}
