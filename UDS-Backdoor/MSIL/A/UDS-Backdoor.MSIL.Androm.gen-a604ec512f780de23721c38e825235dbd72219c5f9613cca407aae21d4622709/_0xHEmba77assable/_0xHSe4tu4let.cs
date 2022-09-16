using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using Microsoft.Cct.Services;
using Microsoft.Cct.Services.AzureProjectInternals;
using Microsoft.Cct.Services.Compute;
using Microsoft.Cct.Services.Sqm;
using Microsoft.Cct.Services.StatusWindow;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.WindowsAzure;
using _0xHAne4tru4;
using _0xHHeino3snesses;

namespace _0xHEmba77assable;

internal static class _0xHSe4tu4let
{
	private static IServiceProvider _0xHBook8rs;

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "ServiceProvider is set by unit tests")]
	internal static IServiceProvider _0xHC3nso
	{
		get
		{
			return LazyInitializer.EnsureInitialized(ref _0xHBook8rs, () => (IServiceProvider)ServiceProvider.get_GlobalProvider());
		}
		set
		{
			_0xHBook8rs = value;
		}
	}

	internal static InterfaceType _0xHTug5ik<InterfaceType, ServiceType>() where InterfaceType : class where ServiceType : class
	{
		return ServiceProviderExtensions.GetService<InterfaceType, ServiceType>(_0xHC3nso);
	}

	internal static IWatStatusWindow _0xHA6azonian()
	{
		return _0xHTug5ik<IWatStatusWindow, IWatStatusWindow>() ?? throw new InvalidOperationException();
	}

	internal static IComputeService _0xHJe8t()
	{
		return _0xHTug5ik<IComputeService, IComputeService>();
	}

	internal static ISqm _0xHP3lebotomist(WatErrorLocation _0xHOccul2a2ion)
	{
		return (ISqm)(object)new _0xHOcto8uses();
	}

	internal static ISqm2 _0xHStor8y8d()
	{
		return (ISqm2)(object)new _0xHSeal7kin();
	}

	internal static IStorageCredentialsProvider[] _0xHDic8tyled8n8us()
	{
		return _0xHTug5ik<IAzureProjectInternalsService, IAzureProjectInternalsService>().GetCloudProjectStorageCredentialsProviders().ToArray();
	}
}
