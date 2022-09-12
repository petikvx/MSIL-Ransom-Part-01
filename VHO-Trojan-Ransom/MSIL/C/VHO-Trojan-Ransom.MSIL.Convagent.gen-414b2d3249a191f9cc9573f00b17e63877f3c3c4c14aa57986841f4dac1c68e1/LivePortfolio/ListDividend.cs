using System;
using System.Windows;

namespace LivePortfolio;

public class ListDividend : Dividend
{
	private SVCCommand _DividendPropertiesCommand;

	private decimal _Holding;

	private decimal _Revenue;

	public SVCCommand DividendPropertiesCommand => _DividendPropertiesCommand;

	public decimal Holding => _Holding;

	public decimal Revenue => _Revenue;

	public ListDividend(int New_Id, int New_AssetID, string New_Ticker, string New_AssetName, DateTime New_ExDividend, DateTime New_Payment, decimal New_Amount, decimal New_Holding, string New_Type, string New_Status)
		: base(New_Id, New_AssetID, New_Ticker, New_AssetName, New_ExDividend, New_Payment, New_Amount, New_Type, New_Status)
	{
		_DividendPropertiesCommand = new SVCCommand(DividendProperties);
		_Holding = New_Holding;
		CalculateDerivedValues();
	}

	public void DividendProperties()
	{
		DivEdit divEdit = new DivEdit(this);
		((Window)divEdit).ShowDialog();
	}

	private void CalculateDerivedValues()
	{
		_Revenue = decimal.Divide(decimal.Multiply(_Holding, base.Amount), new decimal(100L));
	}
}
