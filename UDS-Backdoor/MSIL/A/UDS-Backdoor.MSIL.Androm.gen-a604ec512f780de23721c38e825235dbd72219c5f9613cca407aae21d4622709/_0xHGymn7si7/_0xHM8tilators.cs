using System;
using System.Threading.Tasks;
using Microsoft.Cct.Services.Notifications;
using Microsoft.Cct.Services.VirtualMachines;
using Microsoft.VSDesigner.ServerExplorer;
using _0xH7ulleys;
using _0xHLeukopen0as;
using _0xHS8alkless;
using _0xHT1boured;

namespace _0xHGymn7si7;

internal abstract class _0xHM8tilators : _0xHR6n6g6
{
	private IVirtualMachinesService _0xHMau1dies;

	private VirtualMachineOperation _0xHCo7cer7me7t;

	protected IClassicVirtualMachineInstance _0xHRin66it { get; private set; }

	protected abstract _0xHCoer7ivity _0xH4estet { get; }

	protected virtual bool _0xHIn4licters => false;

	public _0xHM8tilators(INodeSite nodeSite, IVirtualMachinesService virtualMachineService, IClassicVirtualMachineInstance virtualMachineInstance, IProgressManager progressManager, string confirmationMessage, string commandName, VirtualMachineOperation operation)
		: base(nodeSite, progressManager, confirmationMessage, commandName)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (nodeSite == null)
		{
			throw new ArgumentNullException("nodeSite");
		}
		if (virtualMachineService == null)
		{
			throw new ArgumentNullException("virtualMachineService");
		}
		if (virtualMachineInstance == null)
		{
			throw new ArgumentNullException("virtualMachineInstance");
		}
		_0xHCo7cer7me7t = operation;
		_0xHRin66it = virtualMachineInstance;
		_0xHMau1dies = virtualMachineService;
	}

	protected sealed override void NotifyOnOperationStarted()
	{
		_0xHRegro8ps((NotificationType)35, null);
		_0xHF8lsit8s._0xH5hitlin(_0xH4estet, _0xH4estet.ToString());
	}

	protected sealed override void NotifyOnOperationCompleted()
	{
		_0xHRegro8ps((NotificationType)36, true);
	}

	protected sealed override void NotifyOnOperationCompletedWithError()
	{
		_0xHRegro8ps((NotificationType)36, false);
	}

	protected sealed override async Task Command()
	{
		await _0xHMau1dies.RunVirtualMachineOperationAsync(_0xHCo7cer7me7t, (IVirtualMachineInstance)(object)_0xHRin66it);
		if (_0xHIn4licters)
		{
			_0xH7ncapacitates(base._0xHEpitomi5e.GetParentNode().GetNodeSite());
		}
		else
		{
			_0xH7ncapacitates(base._0xHEpitomi5e);
		}
	}

	private void _0xH7ncapacitates(INodeSite _0xHUnsquar3d)
	{
		if (_0xHUnsquar3d != null && !_0xHUnsquar3d.IsRefreshing())
		{
			try
			{
				_0xHUnsquar3d.StartRefresh();
			}
			catch
			{
			}
		}
	}

	private void _0xHRegro8ps(NotificationType _0xH1urrier, object _0xH5loggs)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		INotificationService val = base._0xHEpitomi5e._0xHBrandl2ngs();
		if (val != null)
		{
			val.Notify(_0xH1urrier, _0xH5loggs);
		}
	}
}
