using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using _0xH1nvocates;
using _0xHCoagulate0;

namespace _0xHShift4ess;

[SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1400:AccessModifierMustBeDeclared", Justification = "Not duplicating access modifier")]
internal static class _0xHC5rus5
{
	private static IAzureToolsVersionInfo _0xHInkwell0;

	private static IAzureToolsVersionInfo _0xH2uzzled;

	private static bool? _0xH3ope;

	private static IAzureToolsVersionInfo[] _0xHTape3ike;

	private static string[] _0xHMalnourishe6;

	internal static IAzureToolsVersionInfo[] _0xHSpavi1s()
	{
		return new IAzureToolsVersionInfo[13]
		{
			_0xHHomeschoo2ed._0xH0ecay,
			_0xHHomeschoo2ed._0xHD1saff1rm1ng,
			_0xHHomeschoo2ed._0xHPesti4ences,
			_0xHHomeschoo2ed._0xH3ruxes,
			_0xHHomeschoo2ed._0xHUnr7sponsiv7ly,
			_0xHHomeschoo2ed._0xHRu33ednesses,
			_0xHHomeschoo2ed._0xHAmo3ally,
			_0xHHomeschoo2ed._0xHT7ims,
			_0xHHomeschoo2ed._0xHHolome1abolous,
			_0xHHomeschoo2ed._0xHM8t8r,
			_0xHHomeschoo2ed._0xHCar0ogonial,
			_0xHHomeschoo2ed._0xHGesticu6ant,
			_0xHHomeschoo2ed._0xHSpec6a6ors
		};
	}

	internal static IAzureToolsVersionInfo _0xHSuperl8tive()
	{
		if (_0xH2uzzled == null)
		{
			IAzureToolsVersionInfo[] allProducts = _0xHSpavi1s();
			_0xH2uzzled = allProducts.Where((IAzureToolsVersionInfo knownProduct) => knownProduct.ProductVersion == allProducts.Max((IAzureToolsVersionInfo productVersionInfo) => productVersionInfo.ProductVersion)).First();
		}
		return _0xH2uzzled;
	}

	internal static IAzureToolsVersionInfo _0xHNorthwar5(IServiceProvider _0xHH5mps55ds)
	{
		if (_0xHInkwell0 == null)
		{
			_0xHInkwell0 = (from knownProducts in _0xHSpavi1s()
				orderby knownProducts.ProductVersion descending
				select knownProducts).FirstOrDefault((IAzureToolsVersionInfo knownProduct) => knownProduct.IsToolsInstalled(_0xHH5mps55ds));
		}
		return _0xHInkwell0;
	}

	internal static IAzureToolsVersionInfo _0xHR3actionary(Version _0xHN1nreading)
	{
		return _0xHSpavi1s().FirstOrDefault((IAzureToolsVersionInfo productVersionInfo) => productVersionInfo.ProductVersion == _0xHN1nreading);
	}

	internal static bool _0xHInnova3ory(IServiceProvider _0xHAn7rak)
	{
		if (!_0xH3ope.HasValue)
		{
			_0xH3ope = _0xHNorthwar5(_0xHAn7rak) != null;
		}
		return _0xH3ope.Value;
	}

	internal static IAzureToolsVersionInfo[] _0xHUnl3ke(IServiceProvider _0xHMicrosur6eries)
	{
		if (_0xHTape3ike == null)
		{
			_0xHTape3ike = (from azureToolsVersionInfo in _0xHSpavi1s()
				where azureToolsVersionInfo.IsToolsInstalled(_0xHMicrosur6eries)
				select azureToolsVersionInfo).ToArray();
		}
		return _0xHTape3ike;
	}

	internal static string[] _0xHCh6lecystitis(IServiceProvider _0xHBoo8y)
	{
		if (_0xHMalnourishe6 == null)
		{
			_0xHMalnourishe6 = _0xHUnl3ke(_0xHBoo8y).SelectMany((IAzureToolsVersionInfo azureToolsVersionInfo) => azureToolsVersionInfo.SupportedFrameworkVersions).Distinct().ToArray();
		}
		return _0xHMalnourishe6;
	}

	internal static IEnumerable<IAzureToolsVersionInfo> _0xHOff8rtory<T>(IServiceProvider _0xHG7wned) where T : class
	{
		return from knownProduct in _0xHSpavi1s()
			where knownProduct.IsToolsInstalled(_0xHG7wned) && knownProduct.ImplementedInterfaces.Contains(typeof(T))
			select knownProduct;
	}

	internal static T _0xHFa7ts<T>(IServiceProvider _0xHSp44di4r) where T : class
	{
		IAzureToolsVersionInfo azureToolsVersionInfo = (from version in _0xHOff8rtory<T>(_0xHSp44di4r)
			orderby version.ProductVersion descending
			select version).FirstOrDefault();
		if (azureToolsVersionInfo == null)
		{
			return null;
		}
		object? service = _0xHSp44di4r.GetService(typeof(SVsShell));
		IVsShell val = (IVsShell)((service is IVsShell) ? service : null);
		if (val == null)
		{
			throw new InvalidOperationException();
		}
		return (_0xHRa4agers(azureToolsVersionInfo.PackageGuid, val) as T) ?? throw new NotSupportedException();
	}

	internal static IVsPackage _0xHRa4agers(Guid _0xHMisclassi2ies, IVsShell _0xHConferent3al)
	{
		Guid guid = _0xHMisclassi2ies;
		IVsPackage result = default(IVsPackage);
		ErrorHandler.ThrowOnFailure(_0xHConferent3al.LoadPackage(ref guid, ref result));
		return result;
	}
}
