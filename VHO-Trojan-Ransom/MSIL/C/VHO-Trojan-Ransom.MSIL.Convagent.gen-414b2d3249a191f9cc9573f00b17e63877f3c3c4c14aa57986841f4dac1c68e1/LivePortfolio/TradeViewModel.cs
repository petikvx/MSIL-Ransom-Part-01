using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

public class TradeViewModel : ViewModelBase
{
	private Portfolio _CurrentPortfolio;

	private Asset _SelectedAsset;

	private Portfolio _SelectedPortfolio;

	private DateTime _PurchaseDate;

	private decimal _UnitsPurchased;

	private decimal _UnitPrice;

	private decimal _TotalPurchaseCost;

	private decimal _Commission;

	private decimal _StampDuty;

	private bool _Detailed;

	private SVCCommand _RecordPurchaseCommand;

	[field: AccessedThroughProperty("_Portfolios")]
	private virtual PortfolioCollection _Portfolios
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("_PortfolioHoldings")]
	private virtual HoldingCollection _PortfolioHoldings
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("_Assets")]
	private virtual AssetCollection _Assets
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Portfolio SelectedPortfolio => _SelectedPortfolio;

	public Asset SelectedAsset
	{
		get
		{
			return _SelectedAsset;
		}
		set
		{
			_SelectedAsset = value;
		}
	}

	public AssetCollection Assets
	{
		get
		{
			return _Assets;
		}
		set
		{
			_Assets = value;
		}
	}

	public DateTime PurchaseDate
	{
		get
		{
			return _PurchaseDate;
		}
		set
		{
			_PurchaseDate = value;
		}
	}

	public decimal UnitsPurchased
	{
		get
		{
			return _UnitsPurchased;
		}
		set
		{
			_UnitsPurchased = value;
			ReCalcPurchase();
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
			ReCalcPurchase();
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
			ReCalcPurchase();
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
			ReCalcPurchase();
		}
	}

	public decimal TotalPurchaseCost
	{
		get
		{
			return _TotalPurchaseCost;
		}
		set
		{
			_TotalPurchaseCost = value;
		}
	}

	public SVCCommand RecordPurchaseCommand => _RecordPurchaseCommand;

	public TradeViewModel(Portfolio SelectedPortfolio)
	{
		_PurchaseDate = DateAndTime.get_Today();
		_UnitsPurchased = default(decimal);
		_UnitPrice = default(decimal);
		_TotalPurchaseCost = default(decimal);
		_Commission = 12.5m;
		_StampDuty = default(decimal);
		_RecordPurchaseCommand = new SVCCommand(RecordPurchase);
		PopulateAssets();
		_SelectedPortfolio = SelectedPortfolio;
		NotifyPropertyChanged("UnitsPurchased");
	}

	private void PopulateAssets()
	{
		new StringBuilder();
		_Assets = new AssetCollection();
		DatabaseLayer databaseLayer = new DatabaseLayer();
		DataTable dataTable = new DataTable();
		dataTable = databaseLayer.GetAssetList();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Asset item = new Asset(Conversions.ToInteger(dataRow["Id"]), Conversions.ToString(dataRow["Ticker"]), Conversions.ToString(dataRow["Name"]));
				_Assets.Add(item);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		_SelectedAsset = _Assets[0];
		NotifyPropertyChanged("SelectedAsset");
		NotifyPropertyChanged("Assets");
	}

	private void RecordPurchase()
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		DatabaseLayer databaseLayer = new DatabaseLayer();
		databaseLayer.AssetPurchase(_SelectedPortfolio.Id, _SelectedAsset.Id, UnitsPurchased);
		if (_Detailed)
		{
			databaseLayer.AddTransaction(_PurchaseDate, _SelectedPortfolio.Id, _SelectedAsset.Id, UnitsPurchased, _UnitPrice, _TotalPurchaseCost, _StampDuty, _Commission, "Purchase", "");
		}
		else
		{
			databaseLayer.AddTransaction(_PurchaseDate, _SelectedPortfolio.Id, _SelectedAsset.Id, UnitsPurchased, _TotalPurchaseCost, "Purchase", "");
		}
		Interaction.MsgBox((object)"Purchase Logged!", (MsgBoxStyle)0, (object)null);
	}

	private void ReCalcPurchase()
	{
		decimal num = decimal.Multiply(_UnitPrice, _UnitsPurchased);
		_StampDuty = new decimal(Convert.ToDouble(num) * 0.005);
		_TotalPurchaseCost = decimal.Add(decimal.Add(num, _StampDuty), _Commission);
		NotifyPropertyChanged("TotalPurchaseCost");
		NotifyPropertyChanged("StampDuty");
	}
}
