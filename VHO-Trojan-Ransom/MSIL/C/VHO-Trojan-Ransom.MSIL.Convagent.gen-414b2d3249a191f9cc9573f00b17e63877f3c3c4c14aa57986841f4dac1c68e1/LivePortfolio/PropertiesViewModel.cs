using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

public class PropertiesViewModel : ViewModelBase
{
	private Portfolio _CurrentPortfolio;

	private HoldingCollection _Holdings;

	private List<AssetBase> _Assets;

	private decimal _StampDuty;

	private decimal _TransactionCost;

	private decimal _CashAmount;

	private decimal _CashHolding;

	private List<string> _Actions;

	private decimal _SharePrice;

	private AssetBase _SelectedAsset;

	private decimal _Cost;

	private decimal _Units;

	private SVCCommand _TradeCommand;

	private SVCCommand _UnitiseCommand;

	private bool Loading;

	private SVCParamCommand _CashCommand;

	public Portfolio SelectedPortfolio
	{
		get
		{
			return _CurrentPortfolio;
		}
		set
		{
			_CurrentPortfolio = value;
			GetCashBalance();
		}
	}

	public HoldingCollection Holdings => _Holdings;

	public decimal CashAmount
	{
		get
		{
			return _CashAmount;
		}
		set
		{
			_CashAmount = value;
			_StampDuty = new decimal(Convert.ToDouble(_CashAmount) * 0.05);
			NotifyPropertyChanged("StampDuty");
		}
	}

	public decimal CashHolding
	{
		get
		{
			return _CashHolding;
		}
		set
		{
			_CashHolding = value;
			NotifyPropertyChanged("CashHolding");
		}
	}

	public string PortfolioName => _CurrentPortfolio.Name;

	public decimal MonthlyIncome => decimal.Divide(SelectedPortfolio.Income, new decimal(12L));

	public decimal DailyIncome => decimal.Divide(SelectedPortfolio.Income, new decimal(365L));

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

	public decimal TransactionCost
	{
		get
		{
			return _TransactionCost;
		}
		set
		{
			_TransactionCost = value;
		}
	}

	public List<AssetBase> Assets => _Assets;

	public decimal SharePrice
	{
		get
		{
			return _SharePrice;
		}
		set
		{
			_SharePrice = value;
		}
	}

	public AssetBase SelectedAsset
	{
		get
		{
			return _SelectedAsset;
		}
		set
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			_SelectedAsset = value;
			Interaction.MsgBox((object)("Selected Asset now " + _SelectedAsset.Name), (MsgBoxStyle)0, (object)null);
			NotifyPropertyChanged("Asset");
		}
	}

	public decimal Cost
	{
		get
		{
			return _Cost;
		}
		set
		{
			_Cost = value;
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

	public SVCCommand TradeCommand => _TradeCommand;

	public ICommand cmdCash => _CashCommand;

	public PropertiesViewModel(Portfolio P)
	{
		_Holdings = new HoldingCollection();
		_Assets = new List<AssetBase>();
		_TradeCommand = new SVCCommand(RecordTrade);
		_UnitiseCommand = new SVCCommand(Unitise);
		Loading = false;
		_CashCommand = new SVCParamCommand(CashTransaction);
		SelectedPortfolio = P;
		PopulateHoldings();
		PopulateAssets();
		PopulateView();
		GetCashBalance();
	}

	private void CashTransaction(string CmdType)
	{
		decimal num = _CashAmount;
		switch (CmdType)
		{
		case "OtherMoneyOut":
			num = decimal.Multiply(num, -1m);
			break;
		case "Withdrawal":
			num = decimal.Multiply(num, -1m);
			break;
		}
		DatabaseLayer databaseLayer = new DatabaseLayer();
		databaseLayer.UpdateCash(_CurrentPortfolio.Id, num);
	}

	private void PopulateHoldings()
	{
		StringBuilder stringBuilder = new StringBuilder();
		DatabasePrimitives databasePrimitives = new DatabasePrimitives();
		stringBuilder.Clear();
		stringBuilder.Append(" SELECT   A.Ticker,  \r\n                              A.Name,     \r\n                              A.AssetType, \r\n                              A.Id AS AssetId,  \r\n                              A.BidPrice,  \r\n                              A.OpenPrice,  \r\n                              A.ClosePrice,\r\n                              H.Holding, \r\n                              A.Dividend,\r\n                              (\r\n                              SELECT COALESCE(SUM(Amount),0) FROM [Transaction]\r\n                              WHERE AssetId = A.Id AND \r\n                              PortfolioId = " + Conversions.ToString(_CurrentPortfolio.Id) + " AND \r\n                              Type = 'Purchase'\r\n                              ) AS PurchaseAmount,\r\n                              (\r\n                              SELECT COALESCE(SUM(Amount),0) FROM [Transaction]\r\n                              WHERE AssetId = A.Id AND \r\n                              PortfolioId = " + Conversions.ToString(_CurrentPortfolio.Id) + " AND \r\n                              Type = 'Sale'\r\n                              ) AS SaleAmount\r\n                     FROM     Holding H,  \r\n                              Asset A \r\n                              WHERE     H.AssetId = A.Id ");
		DataTable dataTable = databasePrimitives.ExecuteQuery(stringBuilder.ToString());
		Loading = true;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Holding item = new Holding(_CurrentPortfolio.Name, Conversions.ToString(dataRow["Ticker"]), Conversions.ToString(dataRow["Name"]), Conversions.ToString(dataRow["AssetType"]), Conversions.ToInteger(dataRow["AssetId"]), Conversions.ToDecimal(dataRow["Holding"]), Conversions.ToDecimal(dataRow["OpenPrice"]), Conversions.ToDecimal(dataRow["BidPrice"]), Conversions.ToDecimal(dataRow["ClosePrice"]), Conversions.ToDecimal(dataRow["Dividend"]), Conversions.ToDecimal(dataRow["PurchaseAmount"]), Conversions.ToDecimal(dataRow["SaleAmount"]));
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
	}

	private void PopulateAssets()
	{
		StringBuilder stringBuilder = new StringBuilder();
		DatabasePrimitives databasePrimitives = new DatabasePrimitives();
		stringBuilder.Clear();
		stringBuilder.Append(" SELECT   A.Id, ");
		stringBuilder.Append("          A.Ticker, ");
		stringBuilder.Append("          A.Name  ");
		stringBuilder.Append("FROM      Asset A ");
		stringBuilder.Append("ORDER BY  A.Ticker ");
		DataTable dataTable = databasePrimitives.ExecuteQuery(stringBuilder.ToString());
		Loading = true;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				AssetBase item = new AssetBase(Conversions.ToInteger(dataRow["Id"]), Conversions.ToString(dataRow["Ticker"]), Conversions.ToString(dataRow["Name"]));
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
	}

	private void GetCashBalance()
	{
		DatabaseLayer databaseLayer = new DatabaseLayer();
		if (!Loading)
		{
			CashHolding = databaseLayer.GetCashHolding(_CurrentPortfolio.Id);
		}
	}

	private void PopulateView()
	{
		_TransactionCost = 12.5m;
	}

	private void RecordTrade()
	{
		TradeWindow tradeWindow = new TradeWindow(SelectedPortfolio);
		((Window)tradeWindow).ShowDialog();
	}

	private void Unitise()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		DatabasePrimitives databasePrimitives = new DatabasePrimitives();
		if ((int)Interaction.MsgBox((object)"Unitising erases any previous unit data. Proceed", (MsgBoxStyle)4, (object)null) == 6)
		{
			int num = Convert.ToInt32(Conversion.Int(decimal.Add(_CurrentPortfolio.EquityValue, _CurrentPortfolio.Cash)));
			string sQL = "UPDATE Portfolio SET Units= " + num + ", Date_Unitised = date('now') WHERE  Id = " + Conversions.ToString(_CurrentPortfolio.Id) + ";";
			databasePrimitives.ExecuteScalar(sQL);
		}
	}
}
