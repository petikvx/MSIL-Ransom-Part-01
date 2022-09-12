using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

public class TransactionsViewModel : ViewModelBase
{
	private Portfolio _CurrentPortfolio;

	private ListPortfolio _SelectedPortfolio;

	private bool _Detailed;

	private DateTime _PurchaseDate;

	private decimal _UnitsPurchased;

	private decimal _UnitPrice;

	private decimal _AssetHolding;

	private decimal _TotalPurchaseCost;

	private decimal _Commission;

	private decimal _StampDuty;

	private Asset _SelectedAsset;

	private decimal _UnitsSold;

	private Asset _SelectedSaleAsset;

	private decimal _SaleUnitPrice;

	private decimal _SaleAssetHolding;

	private DateTime _SaleDate;

	private decimal _TotalSaleCost;

	private decimal _SaleCommission;

	private decimal _CashPosition;

	private decimal _CRDR;

	private SVCCommand _RecordSaleCommand;

	private SVCCommand _RecordPurchaseCommand;

	private SVCCommand _UpdateCashCommand;

	private SVCCommand _DepositCommand;

	private SVCCommand _WithdrawalCommand;

	[field: AccessedThroughProperty("_Transactions")]
	private virtual TransactionCollection _Transactions
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("_Portfolios")]
	private virtual ListPortfolioCollection _Portfolios
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

	[field: AccessedThroughProperty("_SaleAssets")]
	private virtual AssetCollection _SaleAssets
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public TransactionCollection Transactions => _Transactions;

	public ListPortfolioCollection Portfolios => _Portfolios;

	public ListPortfolio SelectedPortfolio
	{
		get
		{
			return _SelectedPortfolio;
		}
		set
		{
			_SelectedPortfolio = value;
			RebuildSaleAssetList(_SelectedPortfolio.Id);
			RefreshCashPosition();
		}
	}

	public Asset SelectedAsset
	{
		get
		{
			return _SelectedAsset;
		}
		set
		{
			_SelectedAsset = value;
			UpdateAssetDetails(_SelectedPortfolio.Id, _SelectedAsset.Id, "Purchase");
		}
	}

	public Asset SelectedSaleAsset
	{
		get
		{
			return _SelectedSaleAsset;
		}
		set
		{
			if (value != null)
			{
				_SelectedSaleAsset = value;
				UpdateAssetDetails(_SelectedPortfolio.Id, _SelectedSaleAsset.Id, "Sale");
			}
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

	public AssetCollection SaleAssets
	{
		get
		{
			return _SaleAssets;
		}
		set
		{
			_SaleAssets = value;
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

	public decimal AssetHolding
	{
		get
		{
			return _AssetHolding;
		}
		set
		{
			_AssetHolding = value;
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

	public DateTime SaleDate
	{
		get
		{
			return _SaleDate;
		}
		set
		{
			_SaleDate = value;
		}
	}

	public decimal SaleUnitPrice
	{
		get
		{
			return _SaleUnitPrice;
		}
		set
		{
			_SaleUnitPrice = value;
			ReCalcSale();
		}
	}

	public decimal TotalSaleCost
	{
		get
		{
			return _TotalSaleCost;
		}
		set
		{
			_TotalSaleCost = value;
		}
	}

	public decimal UnitsSold
	{
		get
		{
			return _UnitsSold;
		}
		set
		{
			_UnitsSold = value;
			ReCalcSale();
		}
	}

	public decimal SaleCommission
	{
		get
		{
			return _SaleCommission;
		}
		set
		{
			_SaleCommission = value;
			ReCalcSale();
		}
	}

	public decimal SaleAssetHolding => _SaleAssetHolding;

	public decimal CashPosition
	{
		get
		{
			return _CashPosition;
		}
		set
		{
			_CashPosition = value;
		}
	}

	public decimal CRDR
	{
		get
		{
			return _CRDR;
		}
		set
		{
			_CRDR = value;
		}
	}

	public SVCCommand RecordSaleCommand => _RecordSaleCommand;

	public SVCCommand RecordPurchaseCommand => _RecordPurchaseCommand;

	public SVCCommand UpdateCashCommand => _UpdateCashCommand;

	public SVCCommand DepositCommand => _DepositCommand;

	public SVCCommand WithdrawalCommand => _WithdrawalCommand;

	public TransactionsViewModel()
	{
		_Transactions = new TransactionCollection();
		_Portfolios = new ListPortfolioCollection();
		_PortfolioHoldings = new HoldingCollection();
		_Assets = new AssetCollection();
		_SaleAssets = new AssetCollection();
		_Detailed = true;
		_PurchaseDate = DateAndTime.get_Today();
		_UnitsPurchased = default(decimal);
		_UnitPrice = default(decimal);
		_TotalPurchaseCost = default(decimal);
		_Commission = 12.5m;
		_StampDuty = default(decimal);
		_UnitsSold = default(decimal);
		_SaleDate = DateAndTime.get_Today();
		_TotalSaleCost = default(decimal);
		_RecordSaleCommand = new SVCCommand(RecordSale);
		_RecordPurchaseCommand = new SVCCommand(RecordPurchase);
		_UpdateCashCommand = new SVCCommand(UpdateCashPosition);
		_DepositCommand = new SVCCommand(Deposit);
		_WithdrawalCommand = new SVCCommand(Withdrawal);
		PopulateTransactions();
		PopulateAssets();
		PopulatePortfolios();
	}

	private void PopulateAssets()
	{
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

	private void RecordSale()
	{
		DatabaseLayer databaseLayer = new DatabaseLayer();
		databaseLayer.AssetSale(_SelectedPortfolio.Id, _SelectedSaleAsset.Id, UnitsSold);
		if (_Detailed)
		{
			databaseLayer.AddTransaction(_SaleDate, _SelectedPortfolio.Id, _SelectedSaleAsset.Id, decimal.Multiply(-1m, UnitsSold), _SaleUnitPrice, _TotalSaleCost, 0m, _SaleCommission, "Sale", "");
		}
		else
		{
			databaseLayer.AddTransaction(_SaleDate, _SelectedPortfolio.Id, _SelectedSaleAsset.Id, decimal.Multiply(-1m, UnitsSold), _TotalSaleCost, "Sale", "");
		}
		PopulateTransactions();
	}

	private void RecordPurchase()
	{
		DatabaseLayer databaseLayer = new DatabaseLayer();
		databaseLayer.AssetPurchase(_SelectedPortfolio.Id, _SelectedAsset.Id, _UnitsPurchased);
		databaseLayer.AddTransaction(_PurchaseDate, _SelectedPortfolio.Id, _SelectedAsset.Id, _UnitsPurchased, _UnitPrice, _TotalPurchaseCost, _StampDuty, _Commission, "Purchase", "");
		PopulateTransactions();
	}

	private void ReCalcPurchase()
	{
		decimal num = decimal.Multiply(decimal.Divide(_UnitPrice, new decimal(100L)), _UnitsPurchased);
		_StampDuty = new decimal(Convert.ToDouble(num) * 0.005);
		_TotalPurchaseCost = decimal.Add(decimal.Add(num, _StampDuty), _Commission);
		NotifyPropertyChanged("TotalPurchaseCost");
		NotifyPropertyChanged("StampDuty");
	}

	private void ReCalcSale()
	{
		decimal d = decimal.Multiply(decimal.Divide(_SaleUnitPrice, new decimal(100L)), _UnitsSold);
		_TotalSaleCost = decimal.Add(d, _SaleCommission);
		NotifyPropertyChanged("TotalSaleCost");
	}

	private void PopulatePortfolios()
	{
		DatabasePrimitives databasePrimitives = new DatabasePrimitives();
		_Portfolios = new ListPortfolioCollection();
		string sQL = "WITH AnnIncome AS (\r\n    SELECT D.Payment,\r\n           D.AssetId,\r\n           D.Amount,\r\n           T.PortfolioId,\r\n           SUM(T.Units) AS Units,\r\n           SUM(T.Units) * D.Amount AS Income\r\n      FROM Dividend D,\r\n           [Transaction] T\r\n     WHERE D.AssetId = T.AssetId AND \r\n           T.Date <= D.ExDividend\r\n           AND D.Exdividend <= Date('Now') \r\n           and D.Exdividend > Date('Now', '-1 Year')\r\n     GROUP BY D.Payment,\r\n              D.AssetId,\r\n              D.Amount,\r\n              T.PortfolioId\r\n     ORDER BY D.Payment DESC\r\n)\r\nSELECT P.Id,\r\n       P.Name,\r\n       P.Units,\r\n       P.Base_UnitPrice,\r\n       P.Date_Unitised,\r\n       P.cash,\r\n       COALESCE( (\r\n                     SELECT SUM(H.Holding * A.OfferPrice / 100) \r\n                       FROM Holding H,\r\n                            Asset A\r\n                      WHERE H.PortfolioId = P.Id AND \r\n                            H.AssetId = A.Id\r\n                 ), 0) AS Value,\r\n       (\r\n           SELECT SUM(Income)/100 \r\n             FROM AnnIncome AI\r\n            WHERE AI.PortfolioId = p.Id\r\n       )\r\n       AS Income\r\n  FROM Portfolio P\r\n ORDER BY P.Name;";
		DataTable dataTable = databasePrimitives.ExecuteQuery(sQL);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				ListPortfolio item = new ListPortfolio(Conversions.ToInteger(dataRow["Id"]), Conversions.ToString(dataRow["Name"]), Conversions.ToDecimal(dataRow["Value"]), Conversions.ToInteger(dataRow["Units"]), Conversions.ToDate(dataRow["Date_Unitised"]), Conversions.ToDecimal(dataRow["Cash"]), Conversions.ToDecimal(dataRow["Income"]));
				_Portfolios.Add(item);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		_SelectedPortfolio = _Portfolios[0];
		PortfolioChanged();
		NotifyPropertyChanged("SelectedPortfolio");
		NotifyPropertyChanged("Portfolios");
	}

	private void RebuildSaleAssetList(int PortfolioId)
	{
		DatabasePrimitives databasePrimitives = new DatabasePrimitives();
		DataTable dataTable = new DataTable();
		_SaleAssets.Clear();
		string sQL = "SELECT A.Id,\r\n                      A.Ticker,\r\n                      A.Name\r\n               FROM Asset A,\r\n                    Holding H\r\n               WHERE H.PortfolioId = " + Conversions.ToString(PortfolioId) + " AND \r\n               H.AssetId = A.Id\r\n               ORDER BY A.Ticker;";
		dataTable = databasePrimitives.ExecuteQuery(sQL);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Asset item = new Asset(Conversions.ToInteger(dataRow["Id"]), Conversions.ToString(dataRow["Ticker"]), Conversions.ToString(dataRow["Name"]));
				_SaleAssets.Add(item);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		_SelectedSaleAsset = _SaleAssets[0];
		UpdateAssetDetails(PortfolioId, _SelectedSaleAsset.Id, "Sale");
		NotifyPropertyChanged("SelectedSaleAsset");
		NotifyPropertyChanged("SaleAssets");
	}

	private void UpdateAssetDetails(int PortfolioId, int AssetId, string SalePurchase)
	{
		DatabaseLayer databaseLayer = new DatabaseLayer();
		decimal assetPrice = databaseLayer.GetAssetPrice(Conversions.ToString(AssetId));
		decimal num = Conversions.ToDecimal(databaseLayer.GetHolding(PortfolioId.ToString(), AssetId.ToString()));
		if (Operators.CompareString(SalePurchase, "Purchase", false) != 0)
		{
			if (Operators.CompareString(SalePurchase, "Sale", false) == 0)
			{
				_SaleUnitPrice = assetPrice;
				_SaleAssetHolding = num;
				NotifyPropertyChanged("SaleAssetHolding");
				NotifyPropertyChanged("SaleUnitPrice");
			}
		}
		else
		{
			_UnitPrice = assetPrice;
			_AssetHolding = num;
			NotifyPropertyChanged("AssetHolding");
			NotifyPropertyChanged("UnitPrice");
		}
		NotifyPropertyChanged("AssetHolding");
		NotifyPropertyChanged("UnitPrice");
	}

	private void PortfolioChanged()
	{
		RebuildSaleAssetList(_SelectedPortfolio.Id);
		RefreshCashPosition();
	}

	private void RefreshCashPosition()
	{
		DatabaseLayer databaseLayer = new DatabaseLayer();
		_CashPosition = databaseLayer.GetCashHolding(_SelectedPortfolio.Id);
		NotifyPropertyChanged("CashPosition");
	}

	private void UpdateCashPosition()
	{
		DatabaseLayer databaseLayer = new DatabaseLayer();
		databaseLayer.SetCashHolding(_SelectedPortfolio.Id, _CashPosition);
	}

	private void Deposit()
	{
		AdjustCashPosition(SelectedPortfolio.Id, _CRDR);
	}

	private void Withdrawal()
	{
		AdjustCashPosition(SelectedPortfolio.Id, decimal.Multiply(-1m, _CRDR));
	}

	private void AdjustCashPosition(int PortfolioId, decimal Amount)
	{
		DatabaseLayer databaseLayer = new DatabaseLayer();
		databaseLayer.AdjustCashPosition(PortfolioId, Amount);
		PopulateTransactions();
		NotifyPropertyChanged("CashPosition");
	}

	private void PopulateTransactions()
	{
		DatabasePrimitives databasePrimitives = new DatabasePrimitives();
		string sQL = "SELECT * FROM vAllTransactions\r\n                     WHERE  [Date] <= Date('Now') \r\n                     ORDER BY [Date] Desc ";
		DataTable dataTable = databasePrimitives.ExecuteQuery(sQL);
		_Transactions.Clear();
		NotifyPropertyChanged("Transactions");
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Transaction item = new Transaction(Conversions.ToInteger(dataRow["Id"]), Conversions.ToDate(dataRow["Date"]), Conversions.ToString(dataRow["Type"]), Conversions.ToInteger(dataRow["PortfolioId"]), Conversions.ToString(dataRow["Portfolio"]), Conversions.ToString(dataRow["Ticker"]), Conversions.ToDecimal(dataRow["Amount"]), Conversions.ToDecimal(dataRow["Units"]), Conversions.ToDecimal(dataRow["StampDuty"]), Conversions.ToDecimal(dataRow["Commission"]), Conversions.ToString(dataRow["Remarks"]));
				_Transactions.Add(item);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		NotifyPropertyChanged("Transactions");
	}
}
