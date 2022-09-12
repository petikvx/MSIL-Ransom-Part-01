using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

public class PortfoliosViewModel : ViewModelBase
{
	private decimal _TotalValue;

	private decimal _TotalIncome;

	private decimal _Yield;

	private decimal _MonthlyIncome;

	private ListPortfolio _SelectedPortfolio;

	private Holding _SelectedSellAsset;

	private bool _Consolidated;

	private DatabasePrimitives db;

	private StringBuilder SQL;

	private ListPortfolio P;

	[field: AccessedThroughProperty("_Holdings")]
	private virtual HoldingCollection _Holdings
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

	[field: AccessedThroughProperty("_SelectedPortfolios")]
	private virtual ListPortfolioCollection _SelectedPortfolios
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

	public IList SelectedItems
	{
		get
		{
			return _SelectedPortfolios;
		}
		set
		{
			_SelectedPortfolios.Clear();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = value.GetEnumerator();
				while (enumerator.MoveNext())
				{
					P = (ListPortfolio)enumerator.Current;
					_SelectedPortfolios.Add(P);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			PortfolioSelectionChanged();
		}
	}

	public HoldingCollection Holdings => _Holdings;

	public CollectionView GroupedHoldings => _GroupedHoldings;

	public Portfolio SelectedPortfolio
	{
		get
		{
			return _SelectedPortfolio;
		}
		set
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			_SelectedPortfolio = (ListPortfolio)value;
			PopulateHoldings();
			NotifyPropertyChanged("SelectedPortfolio");
			Interaction.MsgBox((object)("'" + _SelectedPortfolio.Name + "'"), (MsgBoxStyle)0, (object)null);
		}
	}

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
			PopulateHoldings();
		}
	}

	public PortfoliosViewModel()
	{
		_Consolidated = false;
		db = new DatabasePrimitives();
		SQL = new StringBuilder();
		PopulatePortfolios();
		PopulateHoldings();
	}

	private void PopulatePortfolios()
	{
		_Portfolios = new ListPortfolioCollection();
		_SelectedPortfolios = new ListPortfolioCollection();
		SQL.Clear();
		SQL.Append("WITH AnnIncome AS (\r\n    SELECT D.Payment,\r\n           D.AssetId,\r\n           D.Amount,\r\n           T.PortfolioId,\r\n           SUM(T.Units) AS Units,\r\n           SUM(T.Units) * D.Amount AS Income\r\n      FROM Dividend D,\r\n           [Transaction] T\r\n     WHERE D.AssetId = T.AssetId AND \r\n           T.Date <= D.ExDividend\r\n           AND D.Exdividend <= Date('Now') \r\n           and D.Exdividend > Date('Now', '-1 Year')\r\n     GROUP BY D.Payment,\r\n              D.AssetId,\r\n              D.Amount,\r\n              T.PortfolioId\r\n     ORDER BY D.Payment DESC\r\n)\r\nSELECT P.Id,\r\n       P.Name,\r\n       P.Units,\r\n       P.Base_UnitPrice,\r\n       P.Date_Unitised,\r\n       P.cash,\r\n       COALESCE( (\r\n                     SELECT SUM(H.Holding * A.OfferPrice / 100) \r\n                       FROM Holding H,\r\n                            Asset A\r\n                      WHERE H.PortfolioId = P.Id AND \r\n                            H.AssetId = A.Id\r\n                 ), 0) AS Value,\r\n       (\r\n           SELECT SUM(Income)/100 \r\n             FROM AnnIncome AI\r\n            WHERE AI.PortfolioId = p.Id\r\n       )\r\n       AS Income\r\n  FROM Portfolio P\r\n ORDER BY P.Name;");
		DataTable dataTable = db.ExecuteQuery(SQL.ToString());
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
		NotifyPropertyChanged("SelectedPortfolio");
		NotifyPropertyChanged("Portfolios");
	}

	private void PopulateHoldings()
	{
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		new DatabaseLayer();
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		bool flag = true;
		string text = Strings.Format((object)DateAndTime.get_Today(), "yyyy-MM-dd");
		string text2 = Strings.Format((object)DateAndTime.get_Today().AddYears(-1), "yyyy-MM-dd");
		_Holdings = new HoldingCollection();
		stringBuilder2.Clear();
		foreach (ListPortfolio selectedPortfolio in _SelectedPortfolios)
		{
			if (flag)
			{
				stringBuilder2.Append(selectedPortfolio.Id.ToString());
				flag = false;
			}
			else
			{
				stringBuilder2.Append("," + selectedPortfolio.Id);
			}
		}
		stringBuilder.Clear();
		if (_Consolidated)
		{
			stringBuilder.Append("WITH SelectedPortfolios AS (Select Id, AssetID FROM Holding H WHERE H.PortfolioID IN (" + stringBuilder2.ToString() + ") ) \r\n       SELECT (SELECT '(' || COUNT(Id) || ' Portfolios)' FROM Portfolio WHERE Id IN (" + stringBuilder2.ToString() + "))  as Portfolio,\r\n       A.Ticker,\r\n       A.Name AS Asset,\r\n       A.Id AS AssetId,\r\n       A.AssetType,\r\n       A.OfferPrice,\r\n       A.BidPrice,\r\n       A.ClosePrice,\r\n       COALESCE( (\r\n                     SELECT SUM(Amount) \r\n                       FROM Dividend D\r\n                      WHERE D.AssetId = A.Id AND \r\n                            D.ExDividend BETWEEN '" + text2 + "' AND '" + text + "'\r\n                 ), 0) AS Dividend,\r\n       (\r\n           SELECT SUM(Holding) \r\n             FROM Holding H\r\n            WHERE H.AssetId = A.Id AND \r\n                  H.Id IN (\r\n                      SELECT Id\r\n                        FROM SELECTEDPortfolios\r\n                  )\r\n       )\r\n       AS Holding,\r\n       (\r\n           SELECT COALESCE(SUM(Amount), 0) \r\n             FROM [Transaction]\r\n            WHERE AssetId = A.Id AND \r\n                  Type = 'Purchase' AND \r\n                  AssetId IN (\r\n                      SELECT AssetId\r\n                        FROM SELECTEDPortfolios\r\n                  )\r\n       )\r\n       AS PurchaseAmount,\r\n       (\r\n           SELECT COALESCE(SUM(Amount), 0) \r\n             FROM [Transaction]\r\n            WHERE AssetId = A.Id AND \r\n                  Type = 'Sale' AND \r\n                  AssetId IN (\r\n                      SELECT AssetId\r\n                        FROM SELECTEDPortfolios\r\n                  )\r\n       )\r\n       AS SaleAmount\r\n  FROM Asset A\r\n WHERE A.iD IN (\r\n           SELECT DISTINCT AssetId\r\n             FROM SelectedPortfolios\r\n       )\r\n ORDER BY A.Ticker;\r\n");
		}
		else
		{
			stringBuilder.Append("SELECT P.Name AS Portfolio,\r\n                           A.Ticker,\r\n                           A.Name AS Asset,\r\n                           A.Id AS AssetId,\r\n                           A.AssetType,\r\n                           A.OfferPrice,\r\n                           A.BidPrice,\r\n                           A.ClosePrice,\r\n                           COALESCE((SELECT SUM(Amount) \r\n                                     FROM    Dividend D \r\n                                     WHERE D.AssetId = A.Id\r\n                                     AND D.ExDividend Between '" + text2 + "' AND '" + text + "'),0) AS Dividend,\r\n                           H.Holding,\r\n                           (\r\n                            SELECT COALESCE(SUM(Amount),0) FROM [Transaction]\r\n                            WHERE AssetId = A.Id \r\n                            AND   PortfolioId = P.Id \r\n                            AND   Type = 'Purchase') AS PurchaseAmount,\r\n                            (SELECT COALESCE(SUM(Amount),0) FROM [Transaction]\r\n                             WHERE AssetId = A.Id AND \r\n                                   PortfolioId = P.Id AND \r\n                                   Type = 'Sale') AS SaleAmount\r\n                            FROM Holding H,\r\n                             Portfolio P,\r\n                            Asset A\r\n                            WHERE H.PortfolioId = P.Id AND \r\n                            H.AssetId = A.Id AND \r\n                            P.Id IN (" + stringBuilder2.ToString() + ") \r\n                            ORDER BY A.Ticker");
		}
		DataTable dataTable = db.ExecuteQuery(stringBuilder.ToString());
		_Holdings.Clear();
		_TotalValue = default(decimal);
		_TotalIncome = default(decimal);
		IEnumerator enumerator2 = default(IEnumerator);
		try
		{
			enumerator2 = dataTable.Rows.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator2.Current;
				Holding holding = new Holding(Conversions.ToString(dataRow["Portfolio"]), Conversions.ToString(dataRow["Ticker"]), Conversions.ToString(dataRow["Asset"]), Conversions.ToString(dataRow["AssetType"]), Conversions.ToInteger(dataRow["AssetId"]), Conversions.ToDecimal(dataRow["Holding"]), Conversions.ToDecimal(dataRow["OfferPrice"]), Conversions.ToDecimal(dataRow["BidPrice"]), Conversions.ToDecimal(dataRow["ClosePrice"]), Conversions.ToDecimal(dataRow["Dividend"]), Conversions.ToDecimal(dataRow["SaleAmount"]), Conversions.ToDecimal(dataRow["PurchaseAmount"]));
				_Holdings.Add(holding);
				ref decimal totalValue = ref _TotalValue;
				totalValue = decimal.Add(totalValue, holding.Value);
				ref decimal totalIncome = ref _TotalIncome;
				totalIncome = decimal.Add(totalIncome, holding.Income);
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				(enumerator2 as IDisposable).Dispose();
			}
		}
		_GroupedHoldings = (CollectionView)CollectionViewSource.GetDefaultView((object)_Holdings);
		_GroupedHoldings.get_GroupDescriptions().Add((GroupDescription)new PropertyGroupDescription("Ticker"));
		NotifyPropertyChanged("Holdings");
		NotifyPropertyChanged("GroupdedHoldings");
		NotifyPropertyChanged("TotalValue");
		NotifyPropertyChanged("TotalIncome");
	}

	public void PortfolioSelectionChanged()
	{
		PopulateHoldings();
	}
}
