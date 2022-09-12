using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

public class DividendViewModel : ViewModelBase
{
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

	public DividendViewModel()
	{
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
		PopulateDividends();
		PopulateAssets();
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

	private void PopulateAssets()
	{
		DatabaseLayer databaseLayer = new DatabaseLayer();
		DataTable dataTable = new DataTable();
		dataTable = databaseLayer.GetAssetList();
		_Assets.Clear();
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
		NotifyPropertyChanged("Assets");
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
}
