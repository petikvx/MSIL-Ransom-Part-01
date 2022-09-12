namespace xbot_wpf.Models;

public enum ItemsType
{
	[BackgroundIsSelectedColors("#FF2687FB")]
	[BackgroundColors("#00FFFFFF")]
	None,
	[BackgroundColors("#ff1fd41f")]
	[BackgroundIsSelectedColors("#ff1fd41f")]
	ActiveBuy,
	[BackgroundIsSelectedColors("#FF1770da")]
	[BackgroundColors("#FF2687FB")]
	Buy,
	[BackgroundIsSelectedColors("#ffff3300")]
	[BackgroundColors("#ffff3300")]
	Unprofitability,
	[BackgroundColors("#F0BF00")]
	[BackgroundIsSelectedColors("#F0BF00")]
	NoOrders
}
