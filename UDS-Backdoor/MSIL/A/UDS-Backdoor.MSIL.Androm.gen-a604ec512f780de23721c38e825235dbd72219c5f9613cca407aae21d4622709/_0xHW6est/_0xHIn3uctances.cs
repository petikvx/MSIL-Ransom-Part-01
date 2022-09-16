using System;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualStudio.PlatformUI;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.WindowsAzure;
using _0xHBou88ees;
using _0xHHor1e1hoe1;

namespace _0xHW6est;

internal static class _0xHIn3uctances
{
	public static TResult _0xHC2edito2s<TResult>(Func<TResult> _0xHVi7wy, string _0xHUnbekn7wnst, string _0xHDebug6, string _0xHCou3terploys, out bool _0xH2edub, bool _0xHKnigh2hood = true)
	{
		_0xH4rboretum viewModel = new _0xH4rboretum(_0xHUnbekn7wnst, _0xHDebug6, _0xHCou3terploys, _0xHKnigh2hood);
		_0xHConserva2ionis2 progressDialog = new _0xHConserva2ionis2(viewModel);
		TResult result = default(TResult);
		Task task = Task.Factory.StartNew(delegate
		{
			try
			{
				result = _0xHVi7wy();
			}
			finally
			{
				ThreadHelper.get_Generic().BeginInvoke((Action)delegate
				{
					if (!((Window)progressDialog).get_DialogResult().HasValue)
					{
						progressDialog._0xHTr1ag1ng(_0xHSte3osaurus: true);
					}
				});
			}
		});
		bool? flag = ((DialogWindow)progressDialog).ShowModal();
		if (!flag.Value)
		{
			TaskExtensions.IgnoreResultWhenFaulted(task);
		}
		else if (task.IsFaulted)
		{
			task.Wait();
		}
		_0xH2edub = !flag.Value;
		return result;
	}

	public static void _0xHThraso6ical(Action _0xHHa4ebell, string _0xHMineralogi7, string _0xHDisa3owing, string _0xHSk33d, out bool _0xHProd1gy, bool _0xH8utshot = true)
	{
		_0xHC2edito2s((Func<object>)delegate
		{
			_0xHHa4ebell();
			return null;
		}, _0xHMineralogi7, _0xHDisa3owing, _0xHSk33d, out _0xHProd1gy, _0xH8utshot);
	}
}
