using System;
using System.Windows;

namespace LivePortfolio;

public class ListPortfolio : Portfolio
{
	private SVCCommand _PortfolioPropertiesCommand;

	private SVCCommand _TradeCommand;

	private decimal _TotalValue;

	public SVCCommand PortfolioPropertiesCommand => _PortfolioPropertiesCommand;

	public SVCCommand TradeCommand => _TradeCommand;

	public new decimal TotalValue => _TotalValue;

	public ListPortfolio(int New_Id, string New_Name, decimal New_Value, int Units, DateTime Date_Unitised, decimal Cash, decimal Income)
		: base(New_Id, New_Name, New_Value, Units, Date_Unitised, Cash, Income)
	{
		_PortfolioPropertiesCommand = new SVCCommand(PortfolioProperties);
		_TradeCommand = new SVCCommand(RecordTrade);
		_TotalValue = decimal.Add(New_Value, Cash);
	}

	public void PortfolioProperties()
	{
		PropertiesDialog propertiesDialog = new PropertiesDialog(this);
		((Window)propertiesDialog).ShowDialog();
	}

	private void RecordTrade()
	{
		TradeWindow tradeWindow = new TradeWindow(this);
		((Window)tradeWindow).ShowDialog();
	}
}
