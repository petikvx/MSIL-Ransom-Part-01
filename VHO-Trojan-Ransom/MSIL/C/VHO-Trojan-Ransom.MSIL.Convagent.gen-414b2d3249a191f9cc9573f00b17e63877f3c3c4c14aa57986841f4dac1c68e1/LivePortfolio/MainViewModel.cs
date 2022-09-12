using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SVCSharedCode;

namespace LivePortfolio;

public class MainViewModel : ViewModelBase
{
	public class SumDate
	{
		public DateTime SumDate { get; set; }

		public decimal Sum { get; set; }
	}

	public enum DivMonth
	{
		JAN,
		FEB,
		MAR,
		APR,
		MAY,
		JUN,
		JUL,
		AUG,
		SEP,
		OCT,
		NOV,
		DEC
	}

	private string Errorlog;

	private string _StatusbarText;

	private int _StatusBarProgress;

	private DispatcherTimer StatusbarTimer;

	private decimal _CashValue;

	private decimal _EquityValue;

	private decimal _SummaryIncome;

	private decimal _SummaryYield;

	private decimal _TotalValue;

	private decimal _TotalIncome;

	private decimal _Yield;

	private decimal _MonthlyIncome;

	private int _SelectedPortfolioCount;

	private Portfolio _SelectedPortfolio;

	private Holding _SelectedSellAsset;

	private SVCCommand _PortfoliosCommand;

	private bool _Consolidated;

	private Portfolio _CurrentPortfolio;

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

	private CultureInfo Provider;

	private Dividend _SelectedDividend;

	private AssetCollection _Assets;

	private CollectionView _GroupedDividends;

	private decimal _TotalRevenue;

	private decimal _TotalRevenueAnnual;

	private DateTime _LatestDividendDate;

	private DateTime _EarliestDividendDate;

	private SVCCommand _NewDividend;

	private SVCCommand _EditDividend;

	private SVCCommand _DeleteDividend;

	private KeyValuePair<string, int> DividendMonth;

	private decimal _OneYearRevenue;

	private decimal _NextYearRevenue;

	private int _ThisYear;

	private int _LastYear;

	private Dictionary<string, int> _MonthlyTotals;

	private List<SumDate> _CumulativeTotals;

	private decimal _ForwardMonthTotal;

	private DateTime _NextDividendDate;

	private string _NextDividendTicker;

	private decimal _NextDividendAmount;

	private decimal[] _ThisYearsMonthlyRevenue;

	private decimal[] _LastYearsMonthlyRevenue;

	private int ElapsedDays;

	private string _ProgressMessage;

	private int _ProgressPercent;

	private SVCCommand _Go;

	private SVCCommand _Stop;

	private DateTime _DataLastRefreshed;

	private const string APIKEY = "PEODTXYELUPWZAOC";

	private bool _IsBusy;

	private bool _IsNotBusy;

	public string StatusbarText => _StatusbarText;

	public int StatusBarProgress
	{
		get
		{
			return _StatusBarProgress;
		}
		set
		{
			_StatusBarProgress = value;
		}
	}

	public decimal CashValue
	{
		get
		{
			return _CashValue;
		}
		set
		{
			_CashValue = value;
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
		}
	}

	public decimal SummaryIncome
	{
		get
		{
			return _SummaryIncome;
		}
		set
		{
			_SummaryIncome = value;
		}
	}

	public decimal SummaryYield
	{
		get
		{
			return _SummaryIncome;
		}
		set
		{
			_SummaryIncome = value;
		}
	}

	[field: AccessedThroughProperty("_Holdings")]
	private virtual HoldingCollection _Holdings
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	private virtual ListPortfolioCollection _Portfolios
	{
		[CompilerGenerated]
		get
		{
			return __Portfolios;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ListPortfolioCollection.ItemPropertyChangedEventHandler value2 = Portfolios_SelectionChanged;
			ListPortfolioCollection listPortfolioCollection = __Portfolios;
			if (listPortfolioCollection != null)
			{
				listPortfolioCollection.ItemPropertyChanged -= value2;
			}
			__Portfolios = value;
			listPortfolioCollection = __Portfolios;
			if (listPortfolioCollection != null)
			{
				listPortfolioCollection.ItemPropertyChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("_PortfolioHoldings")]
	private virtual HoldingCollection _PortfolioHoldings
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("_GroupedHoldings")]
	private virtual CollectionView _GroupedHoldings
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("_SellHoldings")]
	private virtual HoldingCollection _SellHoldings
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public ListPortfolioCollection Portfolios
	{
		get
		{
			return _Portfolios;
		}
		set
		{
			_Portfolios = value;
		}
	}

	public Portfolio SelectedPortfolio
	{
		get
		{
			return _SelectedPortfolio;
		}
		set
		{
			_SelectedPortfolio = value;
		}
	}

	public HoldingCollection Holdings => _Holdings;

	public CollectionView GroupedHoldings => _GroupedHoldings;

	public bool Consolidated
	{
		get
		{
			return _Consolidated;
		}
		set
		{
			_Consolidated = value;
			NotifyPropertyChanged("Consolidated");
			RePopulate();
		}
	}

	public int SelectedPortfolioCount => _SelectedPortfolioCount;

	public decimal TotalValue
	{
		get
		{
			return _TotalValue;
		}
		set
		{
			_TotalValue = value;
			NotifyPropertyChanged("TotalValue");
		}
	}

	public decimal TotalIncome
	{
		get
		{
			return _TotalIncome;
		}
		set
		{
			_TotalIncome = value;
			NotifyPropertyChanged("Income");
		}
	}

	public decimal Yield
	{
		get
		{
			return _Yield;
		}
		set
		{
			_Yield = value;
			NotifyPropertyChanged("Yield");
		}
	}

	public decimal MonthlyIncome => decimal.Divide(_TotalIncome, new decimal(12L));

	public SVCCommand PortfoliosCommand => _PortfoliosCommand;

	[field: AccessedThroughProperty("_Transactions")]
	private virtual TransactionCollection _Transactions
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public TransactionCollection Transactions => _Transactions;

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

	[field: AccessedThroughProperty("_Dividends")]
	private virtual DividendCollection _Dividends
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public CollectionView GroupedDividends => _GroupedDividends;

	public DividendCollection Dividends
	{
		get
		{
			return _Dividends;
		}
		set
		{
			_Dividends = value;
			NotifyPropertyChanged("Dividends");
		}
	}

	public Dividend SelectedDividend
	{
		get
		{
			return _SelectedDividend;
		}
		set
		{
			_SelectedDividend = value;
			NotifyPropertyChanged("SelectedDividend");
		}
	}

	public SVCCommand NewDividendCommand => _NewDividend;

	public SVCCommand EditDividendCommand => _EditDividend;

	public SVCCommand DeleteDividendCommand => _DeleteDividend;

	public decimal TotalRevenue
	{
		get
		{
			return _TotalRevenue;
		}
		set
		{
			_TotalRevenue = value;
		}
	}

	public decimal TotalRevenueAnnual
	{
		get
		{
			if (ElapsedDays != 0)
			{
				return decimal.Multiply(new decimal(365L), decimal.Divide(_TotalRevenue, new decimal(ElapsedDays)));
			}
			return default(decimal);
		}
	}

	public string EarliestDividendDate => Strings.Format((object)_EarliestDividendDate, "yyyy-MM-dd");

	public string LatestDividendDate => Strings.Format((object)_LatestDividendDate, "yyyy-MM-dd");

	public decimal OneYearRevenue => _OneYearRevenue;

	public decimal NextYearRevenue => _NextYearRevenue;

	public decimal OneYearMonthlyRevenue => decimal.Divide(_OneYearRevenue, new decimal(12L));

	public decimal[] ThisYearsMonthlyRevenue => _ThisYearsMonthlyRevenue;

	public decimal[] LastYearsMonthlyRevenue => _LastYearsMonthlyRevenue;

	public Dictionary<string, int> MonthlyTotals => _MonthlyTotals;

	public List<SumDate> CumulativeTotal => _CumulativeTotals;

	public decimal ForwardMonthTotal => _ForwardMonthTotal;

	public DateTime NextDividendDate => _NextDividendDate;

	public string NextDividendTicker => _NextDividendTicker;

	public decimal NextDividendAmount => _NextDividendAmount;

	private virtual BackgroundWorker Worker
	{
		[CompilerGenerated]
		get
		{
			return _Worker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			RunWorkerCompletedEventHandler value2 = delegate
			{
				WorkerCompleted();
			};
			ProgressChangedEventHandler value3 = WorkerProgressChanged;
			DoWorkEventHandler value4 = DoWork;
			BackgroundWorker worker = _Worker;
			if (worker != null)
			{
				worker.RunWorkerCompleted -= value2;
				worker.ProgressChanged -= value3;
				worker.DoWork -= value4;
			}
			_Worker = value;
			worker = _Worker;
			if (worker != null)
			{
				worker.RunWorkerCompleted += value2;
				worker.ProgressChanged += value3;
				worker.DoWork += value4;
			}
		}
	}

	public bool IsBusy => _IsBusy;

	public bool IsNotBusy => _IsNotBusy;

	public SVCCommand Go => _Go;

	public SVCCommand Cancel => _Stop;

	public string ProgressMessage
	{
		get
		{
			return _ProgressMessage;
		}
		set
		{
			_ProgressMessage = value;
		}
	}

	public int ProgressPercent
	{
		get
		{
			return _ProgressPercent;
		}
		set
		{
			_ProgressPercent = value;
		}
	}

	public MainViewModel()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		StatusbarTimer = new DispatcherTimer();
		_PortfoliosCommand = new SVCCommand(ShowPortfolios);
		_Consolidated = false;
		_Transactions = new TransactionCollection();
		_Detailed = true;
		_PurchaseDate = DateTime.Today;
		_UnitsPurchased = default(decimal);
		_UnitPrice = default(decimal);
		_TotalPurchaseCost = default(decimal);
		_Commission = 12.5m;
		_StampDuty = default(decimal);
		_UnitsSold = default(decimal);
		_SaleDate = DateTime.Today;
		_TotalSaleCost = default(decimal);
		_RecordSaleCommand = new SVCCommand(RecordSale);
		_RecordPurchaseCommand = new SVCCommand(RecordPurchase);
		_UpdateCashCommand = new SVCCommand(UpdateCashPosition);
		Provider = CultureInfo.InvariantCulture;
		_Dividends = new DividendCollection();
		_Assets = new AssetCollection();
		_LatestDividendDate = DateTime.ParseExact("1900-01-01", "yyyy-MM-dd", Provider);
		_EarliestDividendDate = DateTime.Today;
		_NewDividend = new SVCCommand(AddDividend);
		_EditDividend = new SVCCommand(EditDividend);
		_DeleteDividend = new SVCCommand(DeleteDividend);
		_MonthlyTotals = new Dictionary<string, int>();
		_CumulativeTotals = new List<SumDate>();
		_ThisYearsMonthlyRevenue = new decimal[12];
		_LastYearsMonthlyRevenue = new decimal[12];
		Worker = new BackgroundWorker();
		_ProgressMessage = "Busy";
		_Go = new SVCCommand(RefreshPrices);
		_Stop = new SVCCommand(CancelWorker);
		_IsBusy = false;
		_IsNotBusy = true;
		PopulatePortfolios();
		PopulateDividends();
		PopulateAssets();
		InitialiseTimer();
		RefreshPrices();
	}

	private void InitialiseTimer()
	{
		StatusbarTimer.add_Tick((EventHandler)delegate
		{
			ClearStatusMessage();
		});
		StatusbarTimer.set_Interval(new TimeSpan(0, 0, 3));
	}

	private void Status(string Text)
	{
		_StatusbarText = Text;
		StatusbarTimer.Start();
		NotifyPropertyChanged("StatusbarText");
	}

	private void StatusProgress(int Progress)
	{
		_StatusBarProgress = Progress;
		NotifyPropertyChanged("StatusbarProgress");
	}

	private void ClearStatusMessage()
	{
		_StatusbarText = "";
		NotifyPropertyChanged("StatusbarText");
		StatusbarTimer.Stop();
	}

	private void PopulateSummary(string INClause)
	{
		DatabasePrimitives databasePrimitives = new DatabasePrimitives();
		string sQL = "SELECT COALESCE(SUM(H.Holding * A.OfferPrice / 100) ,0)\r\n                       FROM Holding H,\r\n                            Asset A\r\n                      WHERE H.AssetId = A.Id\r\n                      AND H.PortfolioID In (" + INClause + ");";
		string sQL2 = "SELECT COALESCE(SUM(Cash) ,0)\r\n                         FROM   Portfolio WHERE Id In (" + INClause + ");";
		string sQL3 = "WITH AnnIncome AS (\r\n                                              SELECT D.Payment,\r\n                                                       D.AssetId,\r\n                                                       D.Amount,\r\n                                                       T.PortfolioId,\r\n                                                       SUM(T.Units) AS Units,\r\n                                                       SUM(T.Units) * D.Amount AS Income\r\n                                                  FROM Dividend D,\r\n                                                       [Transaction] T\r\n                                                 WHERE D.AssetId = T.AssetId AND \r\n                                                       T.Date <= D.ExDividend\r\n                                                       AND D.Exdividend <= Date('Now') \r\n                                                       and D.Exdividend > Date('Now', '-1 Year')\r\n                                                 GROUP BY D.Payment,\r\n                                                          D.AssetId,\r\n                                                          D.Amount,\r\n                                                          T.PortfolioId\r\n                                                 ORDER BY D.Payment DESC\r\n                                            )\r\n                                            SELECT COALESCE(SUM(Income),0)/100 FROM AnnIncome\r\n                                            WHERE PortfolioId IN  (" + INClause + ");";
		_EquityValue = Conversions.ToDecimal(databasePrimitives.ExecuteScalar(sQL));
		_CashValue = Conversions.ToDecimal(databasePrimitives.ExecuteScalar(sQL2));
		_TotalValue = decimal.Add(_EquityValue, _CashValue);
		_SummaryIncome = Conversions.ToDecimal(databasePrimitives.ExecuteScalar(sQL3));
		_SummaryYield = decimal.Divide(decimal.Multiply(new decimal(100L), _SummaryIncome), _TotalValue);
		NotifyPropertyChanged("EquityValue");
		NotifyPropertyChanged("CashValue");
		NotifyPropertyChanged("TotalValue");
		NotifyPropertyChanged("SummaryIncome");
	}

	private void PopulatePortfolios()
	{
		DatabasePrimitives databasePrimitives = new DatabasePrimitives();
		string sQL = "WITH AnnIncome AS (\r\n    SELECT D.Payment,\r\n           D.AssetId,\r\n           D.Amount,\r\n           T.PortfolioId,\r\n           SUM(T.Units) AS Units,\r\n           SUM(T.Units) * D.Amount AS Income\r\n      FROM Dividend D,\r\n           [Transaction] T\r\n     WHERE D.AssetId = T.AssetId AND \r\n           T.Date <= D.ExDividend\r\n           AND D.Exdividend <= Date('Now') \r\n           and D.Exdividend > Date('Now', '-1 Year')\r\n     GROUP BY D.Payment,\r\n              D.AssetId,\r\n              D.Amount,\r\n              T.PortfolioId\r\n     ORDER BY D.Payment DESC\r\n)\r\nSELECT P.Id,\r\n       P.Name,\r\n       P.Units,\r\n       P.Base_UnitPrice,\r\n       P.Date_Unitised,\r\n       P.cash,\r\n       COALESCE( (\r\n                     SELECT SUM(H.Holding * A.OfferPrice / 100) \r\n                       FROM Holding H,\r\n                            Asset A\r\n                      WHERE H.PortfolioId = P.Id AND \r\n                            H.AssetId = A.Id\r\n                 ), 0) AS Value,\r\n       (\r\n           SELECT SUM(Income)/100 \r\n             FROM AnnIncome AI\r\n            WHERE AI.PortfolioId = p.Id\r\n       )\r\n       AS Income\r\n  FROM Portfolio P\r\n ORDER BY P.Name;";
		_Portfolios = new ListPortfolioCollection();
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
		NotifyPropertyChanged("Portfolios");
		NotifyPropertyChanged("SelectedPortfolio");
		RePopulate();
	}

	private void PopulateHoldings(string INClause)
	{
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		new DatabaseLayer();
		StringBuilder stringBuilder = new StringBuilder();
		string text = Strings.Format((object)DateTime.Today, "yyyy-MM-dd");
		string text2 = Strings.Format((object)DateTime.Today.AddYears(-1), "yyyy-MM-dd");
		DatabasePrimitives databasePrimitives = new DatabasePrimitives();
		_Holdings = new HoldingCollection();
		NotifyPropertyChanged("SelectedPortfolioCount");
		stringBuilder.Clear();
		if (_Consolidated)
		{
			stringBuilder.Append("WITH SelectedPortfolios AS (Select Id, AssetID FROM Holding H WHERE H.PortfolioID IN (" + INClause.ToString() + ") ) \r\n       SELECT (SELECT '(' || COUNT(Id) || ' Portfolios)' FROM Portfolio WHERE Id IN (" + INClause + "))  as Portfolio,\r\n       A.Ticker,\r\n       A.Name AS Asset,\r\n       A.Id AS AssetId,\r\n       A.AssetType,\r\n       A.OfferPrice,\r\n       A.BidPrice,\r\n       A.ClosePrice,\r\n       COALESCE( (\r\n                     SELECT SUM(Amount) \r\n                       FROM Dividend D\r\n                      WHERE D.AssetId = A.Id AND \r\n                            D.ExDividend BETWEEN '" + text2 + "' AND '" + text + "'\r\n                 ), 0) AS Dividend,\r\n       (\r\n           SELECT SUM(Holding) \r\n             FROM Holding H\r\n            WHERE H.AssetId = A.Id AND \r\n                  H.Id IN (\r\n                      SELECT Id\r\n                        FROM SELECTEDPortfolios\r\n                  )\r\n       )\r\n       AS Holding,\r\n       (\r\n           SELECT COALESCE(SUM(Amount), 0) \r\n             FROM [Transaction]\r\n            WHERE AssetId = A.Id AND \r\n                  Type = 'Purchase' AND \r\n                  AssetId IN (\r\n                      SELECT AssetId\r\n                        FROM SELECTEDPortfolios\r\n                  )\r\n       )\r\n       AS PurchaseAmount,\r\n       (\r\n           SELECT COALESCE(SUM(Amount), 0) \r\n             FROM [Transaction]\r\n            WHERE AssetId = A.Id AND \r\n                  Type = 'Sale' AND \r\n                  AssetId IN (\r\n                      SELECT AssetId\r\n                        FROM SELECTEDPortfolios\r\n                  )\r\n       )\r\n       AS SaleAmount\r\n  FROM Asset A\r\n WHERE A.iD IN (\r\n           SELECT DISTINCT AssetId\r\n             FROM SelectedPortfolios\r\n       )\r\n ORDER BY A.Ticker;\r\n");
		}
		else
		{
			stringBuilder.Append("SELECT P.Name AS Portfolio,\r\n                           A.Ticker,\r\n                           A.Name AS Asset,\r\n                           A.Id AS AssetId,\r\n                           A.AssetType,\r\n                           A.OfferPrice,\r\n                           A.BidPrice,\r\n                           A.ClosePrice,\r\n                           COALESCE((SELECT SUM(Amount) \r\n                                     FROM    Dividend D \r\n                                     WHERE D.AssetId = A.Id\r\n                                     AND D.ExDividend Between '" + text2 + "' AND '" + text + "'),0) AS Dividend,\r\n                           H.Holding,\r\n                           (\r\n                            SELECT COALESCE(SUM(Amount),0) FROM [Transaction]\r\n                            WHERE AssetId = A.Id \r\n                            AND   PortfolioId = P.Id \r\n                            AND   Type = 'Purchase') AS PurchaseAmount,\r\n                            (SELECT COALESCE(SUM(Amount),0) FROM [Transaction]\r\n                             WHERE AssetId = A.Id AND \r\n                                   PortfolioId = P.Id AND \r\n                                   Type = 'Sale') AS SaleAmount\r\n                            FROM Holding H,\r\n                             Portfolio P,\r\n                            Asset A\r\n                            WHERE H.PortfolioId = P.Id AND \r\n                            H.AssetId = A.Id AND \r\n                            P.Id IN (" + INClause + ") \r\n                            ORDER BY A.Ticker");
		}
		DataTable dataTable = databasePrimitives.ExecuteQuery(stringBuilder.ToString());
		_Holdings.Clear();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Holding item = new Holding(Conversions.ToString(dataRow["Portfolio"]), Conversions.ToString(dataRow["Ticker"]), Conversions.ToString(dataRow["Asset"]), Conversions.ToString(dataRow["AssetType"]), Conversions.ToInteger(dataRow["AssetId"]), Conversions.ToDecimal(dataRow["Holding"]), Conversions.ToDecimal(dataRow["OfferPrice"]), Conversions.ToDecimal(dataRow["BidPrice"]), Conversions.ToDecimal(dataRow["ClosePrice"]), Conversions.ToDecimal(dataRow["Dividend"]), Conversions.ToDecimal(dataRow["SaleAmount"]), Conversions.ToDecimal(dataRow["PurchaseAmount"]));
				_Holdings.Add(item);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		_GroupedHoldings = (CollectionView)CollectionViewSource.GetDefaultView((object)_Holdings);
		_GroupedHoldings.get_GroupDescriptions().Add((GroupDescription)new PropertyGroupDescription("Ticker"));
		NotifyPropertyChanged("Holdings");
		NotifyPropertyChanged("GroupdedHoldings");
	}

	private void Portfolios_SelectionChanged(ListPortfolio Portfolio, PropertyChangedEventArgs e)
	{
		if (Operators.CompareString(e.PropertyName, "Selected", false) == 0)
		{
			RePopulate();
		}
	}

	public void RePopulate()
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		stringBuilder.Clear();
		_SelectedPortfolioCount = 0;
		checked
		{
			foreach (ListPortfolio portfolio in _Portfolios)
			{
				if (portfolio.Selected)
				{
					_SelectedPortfolioCount++;
					if (flag)
					{
						stringBuilder.Append(portfolio.Id.ToString());
						flag = false;
					}
					else
					{
						stringBuilder.Append("," + portfolio.Id);
					}
				}
			}
			PopulateSummary(stringBuilder.ToString());
			PopulateHoldings(stringBuilder.ToString());
			PopulateTransactions(stringBuilder.ToString());
		}
	}

	private void ShowPortfolios()
	{
		PortFolioWindow portFolioWindow = new PortFolioWindow();
		((Window)portFolioWindow).ShowDialog();
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

	private void UpdateCashPosition()
	{
		DatabaseLayer databaseLayer = new DatabaseLayer();
		databaseLayer.SetCashHolding(_SelectedPortfolio.Id, _CashPosition);
	}

	private void PopulateTransactions(string INClause)
	{
		DatabasePrimitives databasePrimitives = new DatabasePrimitives();
		string sQL = "SELECT * FROM vAllTransactions\r\n                     WHERE  [Date] <= Date('Now') \r\n                     AND PortfolioId IN (" + INClause + ")\r\n                     ORDER BY [Date] Desc ";
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
				Transaction item = new Transaction(Conversions.ToInteger(dataRow["Id"]), Conversions.ToDate(dataRow["Date"]), Conversions.ToString(dataRow["Type"]), Conversions.ToInteger(dataRow["PortfolioId"]), Conversions.ToString(dataRow["PortfolioId"]), Conversions.ToString(dataRow["Ticker"]), Conversions.ToDecimal(dataRow["Amount"]), Conversions.ToDecimal(dataRow["Units"]), Conversions.ToDecimal(dataRow["StampDuty"]), Conversions.ToDecimal(dataRow["Commission"]), Conversions.ToString(dataRow["Remarks"]));
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

	private void PopulateDividends()
	{
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		_ = DateTime.Today;
		DatabasePrimitives databasePrimitives = new DatabasePrimitives();
		decimal num = default(decimal);
		DateTime dateTime = Conversions.ToDate("01/01/1900");
		DateTime t = DateTime.Today.AddYears(-1);
		DateTime t2 = DateTime.Today.AddYears(1);
		DateTime t3 = DateTime.Today.AddMonths(1);
		_ThisYear = DateTime.Today.Year;
		checked
		{
			_LastYear = _ThisYear - 1;
			string sQL = "SELECT        D.Id,\r\n                                  A.Ticker,\r\n                                  A.Id AS AssetId,\r\n                                  A.Name AS AssetName,\r\n                                  D.ExDividend,\r\n                                  D.Payment,\r\n                                  D.Amount,\r\n                                  (SELECT COALESCE(SUM(Units),0) \r\n                                   FROM [Transaction] T\r\n                                   WHERE T.AssetId = D.AssetId \r\n                                   AND   T.DATE < D.ExDividend) AS Holding  ,\r\n                                   Type,\r\n                                  Status\r\n                    FROM          Dividend D,\r\n                                  Asset A\r\n                    WHERE         A.ID = D.AssetId\r\n                    ORDER BY      D.Payment DESC";
			dataTable.Clear();
			dataTable = databasePrimitives.ExecuteQuery(sQL);
			_Dividends.Clear();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					ListDividend listDividend = new ListDividend(Conversions.ToInteger(dataRow["Id"]), Conversions.ToInteger(dataRow["AssetId"]), Conversions.ToString(dataRow["Ticker"]), Conversions.ToString(dataRow["AssetName"]), Conversions.ToDate(dataRow["ExDividend"]), Conversions.ToDate(dataRow["Payment"]), Conversions.ToDecimal(dataRow["Amount"]), Conversions.ToDecimal(dataRow["Holding"]), Conversions.ToString(dataRow["Type"]), Conversions.ToString(dataRow["Status"]));
					_Dividends.Add(listDividend);
					_TotalRevenue = decimal.Add(_TotalRevenue, listDividend.Revenue);
					if ((DateTime.Compare(listDividend.Payment, t) >= 0) & (DateTime.Compare(listDividend.Payment, DateTime.Today) <= 0))
					{
						_OneYearRevenue = decimal.Add(_OneYearRevenue, listDividend.Revenue);
					}
					if ((DateTime.Compare(listDividend.Payment, t2) <= 0) & (DateTime.Compare(listDividend.Payment, DateTime.Today) > 0))
					{
						_NextYearRevenue = decimal.Add(_NextYearRevenue, listDividend.Revenue);
					}
					if ((DateTime.Compare(listDividend.Payment, t3) <= 0) & (DateTime.Compare(listDividend.Payment, DateTime.Today) > 0))
					{
						_ForwardMonthTotal = decimal.Add(_ForwardMonthTotal, listDividend.Revenue);
					}
					int year = listDividend.Payment.Year;
					int num2 = listDividend.Payment.Month - 1;
					int num3 = year;
					if (num3 == _ThisYear)
					{
						_ThisYearsMonthlyRevenue[num2] = decimal.Add(_ThisYearsMonthlyRevenue[num2], listDividend.Revenue);
					}
					else if (num3 == _LastYear)
					{
						_LastYearsMonthlyRevenue[num2] = decimal.Add(_LastYearsMonthlyRevenue[num2], listDividend.Revenue);
					}
					if (DateTime.Compare(listDividend.Payment, _EarliestDividendDate) < 0)
					{
						_EarliestDividendDate = listDividend.Payment;
					}
					if (DateTime.Compare(listDividend.Payment, _LatestDividendDate) > 0)
					{
						_LatestDividendDate = listDividend.Payment;
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			dataTable.DefaultView.Sort = "Payment ASC";
			DataView defaultView = dataTable.DefaultView;
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = defaultView.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRowView dataRowView = (DataRowView)enumerator2.Current;
					if (DateTime.Compare(Conversions.ToDate(dataRowView["Payment"]), dateTime) != 0)
					{
						if (decimal.Compare(num, 0m) > 0)
						{
							SumDate item = new SumDate
							{
								SumDate = dateTime,
								Sum = num
							};
							_CumulativeTotals.Add(item);
						}
						dateTime = Conversions.ToDate(dataRowView["Payment"]);
						num = decimal.Add(num, decimal.Divide(decimal.Multiply(Conversions.ToDecimal(dataRowView["Holding"]), Conversions.ToDecimal(dataRowView["Amount"])), new decimal(100L)));
					}
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			_GroupedDividends = (CollectionView)CollectionViewSource.GetDefaultView((object)_Dividends);
			_GroupedDividends.get_GroupDescriptions().Add((GroupDescription)new PropertyGroupDescription("Payment"));
			ElapsedDays = _LatestDividendDate.Subtract(_EarliestDividendDate).Days;
			NotifyPropertyChanged("Dividends");
			NotifyPropertyChanged("TotalRevenue");
			NotifyPropertyChanged("TotalRevenueAnnual");
			NotifyPropertyChanged("CumulativeTotal");
			sQL = "SELECT strftime(\"%m\",Payment) AS MM,\r\n                      strftime(\"%Y\",Payment) AS YYYY,\r\n                      SUM(Income) AS Income\r\n               FROM vDividendS\r\n               GROUP By strftime(\"%m\",Payment),\r\n                        strftime(\"%Y\",Payment)\r\n                        ORDER BY YYYY,MM";
			dataTable.Clear();
			dataTable = databasePrimitives.ExecuteQuery(sQL);
			_MonthlyTotals.Clear();
			IEnumerator enumerator3 = default(IEnumerator);
			try
			{
				enumerator3 = dataTable.Rows.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator3.Current;
					_MonthlyTotals.Add(dataRow["MM"].ToString() + " " + dataRow["YYYY"].ToString(), Conversions.ToInteger(dataRow["Income"]));
				}
			}
			finally
			{
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			_SelectedDividend = _Dividends[0];
			NotifyPropertyChanged("SelectedDividend");
			sQL = "SELECT D.Payment,\r\n                      A.Ticker,\r\n                      D.Amount * (\r\n                      SELECT COALESCE(SUM(Units), 0) \r\n                        FROM [Transaction] T\r\n                       WHERE T.AssetId = D.AssetId AND \r\n                             T.DATE < D.ExDividend\r\n                       )\r\n                       AS Revenue\r\n               FROM Dividend D,\r\n                    Asset A\r\n               WHERE A.ID = D.AssetId AND \r\n                     D.Payment > Date(\"Now\") \r\n               ORDER BY D.Payment\r\n               LIMIT 1;";
			DataTable dataTable2 = new DataTable();
			dataTable2.Clear();
			dataTable2 = databasePrimitives.ExecuteQuery(sQL);
			DataRow dataRow2 = dataTable2.Rows[0];
			_NextDividendDate = Conversions.ToDate(dataRow2["Payment"]);
			_NextDividendTicker = dataRow2["Ticker"].ToString();
			_NextDividendAmount = Conversions.ToDecimal(Operators.DivideObject(dataRow2["Revenue"], (object)100));
		}
	}

	private void AddDividend()
	{
		ListDividend d = new ListDividend(1, 1, "", "", DateTime.Today, DateTime.Today, 0m, 0m, "Final", "Actual");
		DivEdit divEdit = new DivEdit(d);
		((Window)divEdit).ShowDialog();
		PopulateDividends();
	}

	private void EditDividend()
	{
		DivEdit divEdit = new DivEdit(_SelectedDividend);
		((Window)divEdit).ShowDialog();
		PopulateDividends();
	}

	private void DeleteDividend()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		string text = SelectedDividend.AssetName + " " + Conversions.ToString(SelectedDividend.Amount) + "p\r\nDelete this Dividend?";
		if ((int)Interaction.MsgBox((object)text, (MsgBoxStyle)4, (object)null) == 6)
		{
			DatabaseLayer databaseLayer = new DatabaseLayer();
			databaseLayer.DeleteDividend(SelectedDividend.Id);
			PopulateDividends();
		}
	}

	public void RefreshPrices()
	{
		BackgroundWorker worker = Worker;
		worker.WorkerSupportsCancellation = true;
		worker.WorkerReportsProgress = true;
		worker = null;
		Worker.RunWorkerAsync();
	}

	private void WorkerCompleted()
	{
		_ProgressMessage = "Done";
		NotifyPropertyChanged("ProgressMessage");
		_ProgressPercent = 100;
		NotifyPropertyChanged("ProgressPercent");
		DatabaseLayer databaseLayer = new DatabaseLayer();
		databaseLayer.PutReferenceValue("Setting", "Last Data Refresh", Strings.Format((object)DateTime.Today, "yyyy-MM-dd"));
		BusyState(State: false);
	}

	private void CancelWorker()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"Cancelled", (MsgBoxStyle)0, (object)null);
		_ProgressMessage = "Cancelling ...";
		NotifyPropertyChanged("ProgressMessage");
		Worker.CancelAsync();
	}

	private void WorkerProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		_ProgressMessage = Conversions.ToString(e.UserState);
		_ProgressPercent = e.ProgressPercentage;
		NotifyPropertyChanged("ProgressMessage");
		NotifyPropertyChanged("ProgressPercent");
		if (e.ProgressPercentage == 100)
		{
			RePopulate();
		}
	}

	private void DoWork(object sender, DoWorkEventArgs e)
	{
		int num = 0;
		DatabaseLayer databaseLayer = new DatabaseLayer();
		new DatabaseLayer();
		DataTable assetList = databaseLayer.GetAssetList();
		_ = assetList.Rows.Count;
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			try
			{
				enumerator = assetList.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					string text = Conversions.ToString(dataRow["Ticker"]);
					Worker.ReportProgress(0, "Retrieving Data for " + text);
					int num2 = Conversions.ToInteger(dataRow["Id"]);
					DateTime t = DateTime.Now.AddSeconds(30.0);
					Worker.ReportProgress(0, "Getting data for " + text);
					List<string> priceHistory = GetPriceHistory(num2, text, "PEODTXYELUPWZAOC");
					Worker.ReportProgress(0, "Parsing " + text);
					List<AssetPrice> list = ParseCSV(priceHistory, num2);
					if (!Information.IsNothing((object)list))
					{
						Worker.ReportProgress(0, "Updating " + text);
						databaseLayer.ReplacePriceHistory(list);
					}
					num = checked(num + 1);
					Worker.ReportProgress(100, "Update complete ... ");
					if (Worker.CancellationPending)
					{
						break;
					}
					while (DateTime.Compare(DateTime.Now, t) <= 0)
					{
						Worker.ReportProgress(0, "Sleeping");
						Thread.Sleep(500);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Worker.ReportProgress(100, "Update Cycle complete ... ");
		}
	}

	public List<string> GetPriceHistory(int AssetId, string Ticker, string API_KEY)
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		new AssetPrice();
		List<string> list = new List<string>();
		string requestUriString = "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol=" + Ticker + ".LON&apikey=" + API_KEY + "&outputsize=full&datatype=csv";
		string text = default(string);
		while (!(Operators.CompareString(text, "OK", false) == 0 || num > 5))
		{
			WebRequest webRequest = WebRequest.Create(requestUriString);
			WebResponse response;
			try
			{
				response = webRequest.GetResponse();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				text = ex2.Message;
				ProjectData.ClearProjectError();
				break;
			}
			text = ((HttpWebResponse)response).StatusDescription;
			if (Operators.CompareString(text, "OK", false) == 0)
			{
				try
				{
					Stream responseStream = response.GetResponseStream();
					StreamReader streamReader = new StreamReader(responseStream);
					while (!streamReader.EndOfStream)
					{
						list.Add(streamReader.ReadLine());
					}
					streamReader.Close();
					response.Close();
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					((ClassBase)this).ExceptionHandler.HandleError(ex4);
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				num = checked(num + 1);
			}
		}
		if (Operators.CompareString(text, "OK", false) != 0)
		{
			Interaction.MsgBox((object)("Could not retrieve data from Alpha Vantage for " + Ticker + ". Reason: " + text), (MsgBoxStyle)0, (object)null);
			List<string> result = default(List<string>);
			return result;
		}
		return list;
	}

	public List<AssetPrice> ParseCSV(List<string> CSV, int Assetid)
	{
		List<AssetPrice> list = new List<AssetPrice>();
		bool flag = true;
		string text = CSV[0];
		if (Operators.CompareString(text, "timestamp,open,high,low,close,volume", false) != 0)
		{
			return null;
		}
		foreach (string item2 in CSV)
		{
			if (!flag)
			{
				AssetPrice item = ParsePrice(Assetid, item2);
				list.Add(item);
			}
			else
			{
				flag = false;
			}
		}
		return list;
	}

	public AssetPrice ParsePrice(int AssetId, string CSVPrice)
	{
		Progress("Parsing...");
		string[] array = CSVPrice.Split(new char[1] { ',' });
		AssetPrice assetPrice;
		if (decimal.TryParse(array[4], out var _))
		{
			assetPrice = new AssetPrice();
			AssetPrice assetPrice2 = assetPrice;
			assetPrice2.AssetID = AssetId;
			assetPrice2.PriceDate = Conversions.ToDate(array[0]);
			assetPrice2.Price = Conversions.ToDecimal(array[4]);
			assetPrice2 = null;
		}
		else
		{
			assetPrice = null;
		}
		return assetPrice;
	}

	public void BusyState(bool State)
	{
		_IsBusy = State;
		_IsNotBusy = !State;
		NotifyPropertyChanged("IsBusy");
		NotifyPropertyChanged("IsNotBusy");
	}

	private void Progress(string Msg)
	{
		_ProgressMessage = Msg;
		NotifyPropertyChanged("ProgressMessage");
	}
}
