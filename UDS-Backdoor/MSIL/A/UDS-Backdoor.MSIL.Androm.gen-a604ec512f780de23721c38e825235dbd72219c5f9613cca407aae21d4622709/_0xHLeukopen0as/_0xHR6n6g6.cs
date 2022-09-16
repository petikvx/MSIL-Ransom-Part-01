using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Cct.Services.VirtualMachines;
using Microsoft.VSDesigner.ServerExplorer;
using _0xHCreditabi7ities;
using _0xHHa8kamore;
using _0xHT1boured;

namespace _0xHLeukopen0as;

internal abstract class _0xHR6n6g6 : _0xHK4amseen
{
	private string _0xHCit1ons;

	private string _0xHR8comm8nd8rs;

	private IProgressManager _0xHPe5rl5sh;

	protected INodeSite _0xHEpitomi5e { get; private set; }

	protected virtual void NotifyOnOperationStarted()
	{
	}

	protected virtual void NotifyOnOperationCompleted()
	{
	}

	protected virtual void NotifyOnOperationCompletedWithError()
	{
	}

	protected abstract Task Command();

	protected _0xHR6n6g6(INodeSite nodeSite, IProgressManager progressManager, string confirmationMessage, string commandName)
	{
		if (progressManager == null)
		{
			throw new ArgumentNullException("progressManager");
		}
		if (string.IsNullOrEmpty(commandName))
		{
			throw new ArgumentNullException("commandName");
		}
		_0xHPe5rl5sh = progressManager;
		_0xHEpitomi5e = nodeSite;
		_0xHR8comm8nd8rs = confirmationMessage;
		_0xHCit1ons = commandName;
	}

	public sealed override async void _0xHBlatti0g(EventArgs _0xHDemonst2ability = null)
	{
		if (base._0xHAdsorpti6e && (string.IsNullOrEmpty(_0xHR8comm8nd8rs) || (int)_0xHEpitomi5e.ShowMessageBox(_0xHR8comm8nd8rs, (MessageBoxButtons)4, (MessageBoxIcon)32) == 6))
		{
			NotifyOnOperationStarted();
			base._0xHAdsorpti6e = false;
			_0xHPe5rl5sh.set_OperationInProgress(true);
			try
			{
				await Command().ConfigureAwait(continueOnCapturedContext: true);
				NotifyOnOperationCompleted();
				_0xHPe5rl5sh.set_OperationInProgress(false);
				base._0xHAdsorpti6e = true;
			}
			catch (Exception _0xHS7omper)
			{
				base._0xHAdsorpti6e = true;
				_0xHPe5rl5sh.set_OperationInProgress(false);
				_0xHN2nven2us(_0xHS7omper);
			}
		}
	}

	private void _0xHN2nven2us(Exception _0xHS7omper)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (!_0xHEpitomi5e._0xHSto6ing())
		{
			_0xHEpitomi5e.ShowMessageBox(string.Format(CultureInfo.CurrentCulture, Resources_Common.VirtualMachineOperationFailure, _0xHCit1ons, _0xHS7omper.Message), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else
		{
			NotifyOnOperationCompletedWithError();
		}
	}
}
