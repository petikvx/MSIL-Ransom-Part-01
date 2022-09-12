using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Gecko.Certificates;
using Gecko.Events;
using Gecko.Interop;

namespace Gecko;

public sealed class CertOverrideService : ComPtr<nsICertOverrideService>, nsICertOverrideService
{
	private sealed class CertOverrideServiceFactory : nsIFactory
	{
		private CertOverrideService _instance;

		public CertOverrideServiceFactory(CertOverrideService instance)
		{
			_instance = instance;
		}

		public IntPtr CreateInstance(nsISupports aOuter, ref Guid iid)
		{
			if (aOuter != null)
			{
				Marshal.ThrowExceptionForHR(-2147221232);
			}
			IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(_instance);
			IntPtr ppv;
			try
			{
				Marshal.ThrowExceptionForHR(Marshal.QueryInterface(iUnknownForObject, ref iid, out ppv));
			}
			finally
			{
				Marshal.Release(iUnknownForObject);
			}
			return ppv;
		}

		public void LockFactory(bool @lock)
		{
			throw new NotImplementedException();
		}
	}

	private EventHandler<CertOverrideEventArgs> validityOverrideEvent;

	private IntPtr _pUnknown;

	private CertOverrideServiceFactory _factory;

	public event EventHandler<CertOverrideEventArgs> ValidityOverride
	{
		add
		{
			if (_factory == null)
			{
				_factory = new CertOverrideServiceFactory(this);
				Xpcom.RegisterFactory(typeof(nsICertOverrideService).GUID, GetType().Name, "@mozilla.org/security/certoverride;1", _factory);
			}
			validityOverrideEvent = (EventHandler<CertOverrideEventArgs>)Delegate.Combine(validityOverrideEvent, value);
		}
		remove
		{
			validityOverrideEvent = (EventHandler<CertOverrideEventArgs>)Delegate.Remove(validityOverrideEvent, value);
		}
	}

	public static CertOverrideService GetService()
	{
		nsICertOverrideService service = Xpcom.GetService<nsICertOverrideService>("@mozilla.org/security/certoverride;1");
		if (service is CertOverrideService certOverrideService)
		{
			Marshal.Release(certOverrideService._pUnknown);
			return certOverrideService;
		}
		return service.Wrap(Create);
	}

	private static CertOverrideService Create(nsICertOverrideService instance)
	{
		return new CertOverrideService(instance);
	}

	private CertOverrideService(nsICertOverrideService instance)
		: base(instance, releaseRCW: true)
	{
		_pUnknown = Marshal.GetIUnknownForObject(this);
		Marshal.Release(_pUnknown);
	}

	[Obsolete("RememberRecentBadCert is deprecated, please use RememberValidityOverride instead.")]
	public bool RememberRecentBadCert(Uri url, SSLStatus sslStatus)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (sslStatus == null)
		{
			throw new ArgumentNullException("sslStatus");
		}
		Certificate serverCert = sslStatus.ServerCert;
		if (HasMatchingOverride(url, serverCert))
		{
			return false;
		}
		CertOverride certOverride = (CertOverride)0;
		if (sslStatus.IsUntrusted)
		{
			certOverride |= CertOverride.Untrusted;
		}
		if (sslStatus.IsDomainMismatch)
		{
			certOverride |= CertOverride.Mismatch;
		}
		if (sslStatus.IsNotValidAtThisTime)
		{
			certOverride |= CertOverride.Time;
		}
		RememberValidityOverride(url, serverCert, certOverride, temporary: true);
		return true;
	}

	public bool HasMatchingOverride(Uri url, Certificate cert)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IdnMapping idnMapping = new IdnMapping();
		using nsACString aHostName = new nsACString(idnMapping.GetAscii(url.Host));
		uint aOverrideBits = 0u;
		bool aIsTemporary = false;
		return base.Instance.HasMatchingOverride(aHostName, url.Port, cert._cert.Instance, ref aOverrideBits, ref aIsTemporary);
	}

	public void RememberValidityOverride(Uri url, Certificate cert, CertOverride flags, bool temporary)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (cert == null)
		{
			throw new ArgumentNullException("cert");
		}
		IdnMapping idnMapping = new IdnMapping();
		using nsACString aHostName = new nsACString(idnMapping.GetAscii(url.Host));
		base.Instance.RememberValidityOverride(aHostName, url.Port, cert._cert.Instance, (uint)flags, temporary);
	}

	public void ClearValidityOverride(Uri url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IdnMapping idnMapping = new IdnMapping();
		using nsACString aHostName = new nsACString((url.Scheme != "all") ? idnMapping.GetAscii(url.Host) : url.OriginalString);
		base.Instance.ClearValidityOverride(aHostName, url.Port);
	}

	void nsICertOverrideService.RememberValidityOverride(nsACStringBase aHostName, int aPort, nsIX509Cert aCert, uint aOverrideBits, bool aTemporary)
	{
		base.Instance.RememberValidityOverride(aHostName, aPort, aCert, aOverrideBits, aTemporary);
	}

	bool nsICertOverrideService.HasMatchingOverride(nsACStringBase aHostName, int aPort, nsIX509Cert aCert, ref uint aOverrideBits, ref bool aIsTemporary)
	{
		if (validityOverrideEvent != null)
		{
			CertOverrideEventArgs certOverrideEventArgs = new CertOverrideEventArgs(aHostName.ToString(), aPort, Xpcom.QueryInterface<nsIX509Cert>(aCert).Wrap(Certificate.Create));
			validityOverrideEvent(this, certOverrideEventArgs);
			if (certOverrideEventArgs.Handled)
			{
				aOverrideBits = (uint)certOverrideEventArgs.OverrideResult;
				aIsTemporary = certOverrideEventArgs.Temporary;
				return true;
			}
		}
		return base.Instance.HasMatchingOverride(aHostName, aPort, aCert, ref aOverrideBits, ref aIsTemporary);
	}

	bool nsICertOverrideService.GetValidityOverride(nsACStringBase aHostName, int aPort, nsACStringBase aHashAlg, nsACStringBase aFingerprint, ref uint aOverrideBits, ref bool aIsTemporary)
	{
		return base.Instance.GetValidityOverride(aHostName, aPort, aHashAlg, aFingerprint, ref aOverrideBits, ref aIsTemporary);
	}

	void nsICertOverrideService.ClearValidityOverride(nsACStringBase aHostName, int aPort)
	{
		base.Instance.ClearValidityOverride(aHostName, aPort);
	}

	uint nsICertOverrideService.IsCertUsedForOverrides(nsIX509Cert aCert, bool aCheckTemporaries, bool aCheckPermanents)
	{
		return base.Instance.IsCertUsedForOverrides(aCert, aCheckTemporaries, aCheckPermanents);
	}
}
