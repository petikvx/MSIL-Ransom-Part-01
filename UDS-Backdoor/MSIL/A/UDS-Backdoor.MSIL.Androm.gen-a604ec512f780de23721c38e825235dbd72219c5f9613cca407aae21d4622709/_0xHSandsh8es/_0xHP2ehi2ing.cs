using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Cct.Services;
using Microsoft.Cct.Services.VirtualMachines;
using Microsoft.Samples.WindowsAzure.ServiceManagement;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Telemetry;
using Microsoft.VisualStudio.WindowsAzure.Authentication;
using Microsoft.VisualStudio.WindowsAzure.Credentials;
using Microsoft.VisualStudio.WindowsAzure.ServiceManagement;
using Microsoft.VisualStudio.WindowsAzure.ServiceManagement.DataContracts;
using Microsoft.VisualStudio.WindowsAzure.ServiceManagement.Infrastructure;
using Microsoft.VisualStudio.WindowsAzure.ServiceManagement.Utilities;
using _0xH2ignifiers;
using _0xH7arquisettes;
using _0xH8ompah;
using _0xHChlo4ofo4ms;
using _0xHCom3lects;
using _0xHD3ats;
using _0xHF3nnily;
using _0xHHa8kamore;
using _0xHN8m8l8gic;
using _0xHNatural1se;
using _0xHO0a;
using _0xHPre2iological;
using _0xHSulphur5us;
using _0xHT0eonomies;
using _0xHUnsolv5ble;

namespace _0xHSandsh8es;

internal class _0xHP2ehi2ing
{
	internal interface ITestAccess
	{
		void OnStatusUpdated(Operation operationStatus);
	}

	[SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "public methods documented on the interface")]
	private class _0xHChafe1s : IWatServiceManagement, ITestAccess
	{
		private static Lazy<string> _0xHSu44ee = new Lazy<string>(_0xHP7sitr7nium);

		private readonly X509Certificate2 _0xHMo6ocli6e;

		private readonly string _0xHImportu0er;

		private IServiceProvider _0xHComfit7 = (IServiceProvider)ServiceProvider.get_GlobalProvider();

		public bool UsesDefaultEndpoint => _0xHMisdemean4r._0xHLo88er._0xHFu3led.Equals(ServiceUri);

		public string SubscriptionId { get; private set; }

		public IServiceManagement Svc { get; private set; }

		public int PollIntervalInSeconds { get; set; }

		public SynchronizationContext Sync { get; set; }

		public Uri ServiceUri { get; private set; }

		public bool IsConnected => Svc != null;

		public event _0xH8eminomad StatusUpdated
		{
			[CompilerGenerated]
			add
			{
				_0xH8eminomad _0xH8eminomad = _0xHEquilib6ates;
				_0xH8eminomad _0xH8eminomad2;
				do
				{
					_0xH8eminomad2 = _0xH8eminomad;
					_0xH8eminomad value2 = (_0xH8eminomad)Delegate.Combine(_0xH8eminomad2, value);
					_0xH8eminomad = Interlocked.CompareExchange(ref _0xHEquilib6ates, value2, _0xH8eminomad2);
				}
				while ((object)_0xH8eminomad != _0xH8eminomad2);
			}
			[CompilerGenerated]
			remove
			{
				_0xH8eminomad _0xH8eminomad = _0xHEquilib6ates;
				_0xH8eminomad _0xH8eminomad2;
				do
				{
					_0xH8eminomad2 = _0xH8eminomad;
					_0xH8eminomad value2 = (_0xH8eminomad)Delegate.Remove(_0xH8eminomad2, value);
					_0xH8eminomad = Interlocked.CompareExchange(ref _0xHEquilib6ates, value2, _0xH8eminomad2);
				}
				while ((object)_0xH8eminomad != _0xH8eminomad2);
			}
		}

		internal _0xHChafe1s(string subscriptionId, X509Certificate2 cert, string authenticationHeader, Uri serviceManagementEndpointUri)
		{
			SubscriptionId = subscriptionId;
			_0xHMo6ocli6e = cert;
			_0xHImportu0er = authenticationHeader;
			ServiceUri = serviceManagementEndpointUri;
			PollIntervalInSeconds = 15;
		}

		public void _0xH5oronic()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			if (IsConnected)
			{
				throw new InvalidOperationException("Already connected");
			}
			WebHttpBinding val = new WebHttpBinding((WebHttpSecurityMode)1);
			val.set_MaxReceivedMessageSize(104857600L);
			val.set_MaxBufferPoolSize(1048576L);
			val.get_ReaderQuotas().set_MaxStringContentLength(1048576);
			val.get_ReaderQuotas().set_MaxBytesPerRead(131072);
			if (_0xHCa2kings._0xHS7vines._0xHDiamo7dback)
			{
				ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, (RemoteCertificateValidationCallback)((object _003Cp0_003E, X509Certificate _003Cp1_003E, X509Chain _003Cp2_003E, SslPolicyErrors _003Cp3_003E) => true));
			}
			if (!string.IsNullOrWhiteSpace(_0xHImportu0er))
			{
				Svc = _0xHRav6n((Binding)(object)val, ServiceUri, _0xHImportu0er, _0xHSu44ee.Value, _0xHPrebind1._0xHDrag7nets);
			}
			else
			{
				Svc = _0xHApp0ecarts(val, ServiceUri, _0xHMo6ocli6e, _0xHSu44ee.Value, _0xHPrebind1._0xHDrag7nets);
			}
		}

		public void _0xHWorkwo0en(string _0xHFru0t0nesses, string _0xH4id, CreateDeploymentInput _0xHH4irpieces)
		{
			_0xHCl1ssier(_0xHFru0t0nesses, _0xH4id, _0xHH4irpieces, _0xHM2rshes._0xHHellac1ous());
		}

		public void _0xHCl1ssier(string _0xHWallyd8aigle, string _0xHHe4rthrugs, CreateDeploymentInput _0xHTem7, _0xHUn0urbing _0xHEpiro7eny)
		{
			_0xHLi8nosulfonates(delegate
			{
				ServiceManagementExtensionMethods.CreateOrUpdateDeployment(Svc, SubscriptionId, _0xHWallyd8aigle, _0xHHe4rthrugs, _0xHTem7);
			}, _0xHEpiro7eny);
		}

		public void _0xHEi6er6owns(string _0xHNe2ertines, string _0xH5eedier, UpgradeDeploymentInput _0xHS4bd4ct, _0xHUn0urbing _0xHIm0licatively)
		{
			_0xHLi8nosulfonates(delegate
			{
				ServiceManagementExtensionMethods.UpgradeDeploymentBySlot(Svc, SubscriptionId, _0xHNe2ertines, _0xH5eedier, _0xHS4bd4ct);
			}, _0xHIm0licatively);
		}

		public void _0xHN3i3des(string _0xHGree3gage, string _0xHN2nlab2r)
		{
			_0xHF6n6ticizes(_0xHGree3gage, _0xHN2nlab2r, _0xHM2rshes._0xHHellac1ous());
		}

		public void _0xHF6n6ticizes(string _0xH7aseated, string _0xH6orruptionist, _0xHUn0urbing _0xHCohe0e)
		{
			_0xHLi8nosulfonates(delegate
			{
				ServiceManagementExtensionMethods.DeleteDeploymentBySlot(Svc, SubscriptionId, _0xH7aseated, _0xH6orruptionist);
			}, _0xHCohe0e);
		}

		public Task _0xHShor8(string _0xHDef2ances, string _0xHL2mphangiogram)
		{
			return Task.Run(async delegate
			{
				await _0xHLaxati6e(delegate
				{
					ServiceManagementExtensionMethods.DeleteDeploymentBySlot(Svc, SubscriptionId, _0xHDef2ances, _0xHL2mphangiogram);
				}, _0xHM2rshes._0xHHellac1ous());
			});
		}

		public void _0xHGroaner1(string _0xHIne3tially)
		{
			_0xHLi8nosulfonates(delegate
			{
				ServiceManagementExtensionMethods.DeleteHostedService(Svc, SubscriptionId, _0xHIne3tially);
			}, _0xHM2rshes._0xHHellac1ous());
		}

		public Task _0xHImmigrat0(string _0xHIc0m0n)
		{
			return Task.Run(async delegate
			{
				await _0xHLaxati6e(delegate
				{
					ServiceManagementExtensionMethods.DeleteHostedService(Svc, SubscriptionId, _0xHIc0m0n);
				}, _0xHM2rshes._0xHHellac1ous());
			});
		}

		public Task<AffinityGroupList> _0xHGl1ssarists()
		{
			return Task.Factory.FromAsync((Func<string, AsyncCallback, object?, IAsyncResult>)Svc.BeginListAffinityGroups, (Func<IAsyncResult, AffinityGroupList>)Svc.EndListAffinityGroups, SubscriptionId, (object?)null);
		}

		public Task<VirtualNetworkSites> _0xHN8ncarcin8gens()
		{
			return Task.Factory.FromAsync((Func<string, AsyncCallback, object?, IAsyncResult>)Svc.BeginListVirtualNetworkSites, (Func<IAsyncResult, VirtualNetworkSites>)Svc.EndListVirtualNetworkSites, SubscriptionId, (object?)null);
		}

		public Task<Subscription> _0xHSe1agine11as()
		{
			return Task.Factory.FromAsync((Func<string, AsyncCallback, object?, IAsyncResult>)Svc.BeginGetSubscription, (Func<IAsyncResult, Subscription>)Svc.EndGetSubscription, SubscriptionId, (object?)null);
		}

		public Task<Stream> _0xHSt4eetscape(string _0xHAirpos6s, string _0xHL1feboats, string _0xH0ryptogamic)
		{
			if (string.IsNullOrWhiteSpace(_0xHAirpos6s))
			{
				throw new ArgumentNullException("serviceName");
			}
			if (string.IsNullOrWhiteSpace(_0xHL1feboats))
			{
				throw new ArgumentNullException("deploymentName");
			}
			if (string.IsNullOrWhiteSpace(_0xH0ryptogamic))
			{
				throw new ArgumentNullException("roleInstanceName");
			}
			TaskCompletionSource<Stream> tcs = new TaskCompletionSource<Stream>();
			Svc.BeginDownloadDeploymentRoleInstanceRemoteDesktopFile(SubscriptionId, _0xHAirpos6s, _0xHL1feboats, _0xH0ryptogamic, (AsyncCallback)delegate(IAsyncResult asyncResult)
			{
				try
				{
					tcs.SetResult(Svc.EndDownloadDeploymentRoleInstanceRemoteDesktopFile(asyncResult));
				}
				catch (Exception exception)
				{
					tcs.SetException(exception);
				}
			}, (object)null);
			return tcs.Task;
		}

		public void _0xHAcqui1sc1(string _0xHOvaln6ss, string _0xHMala1ostra1ans, string _0xHP0gin0l)
		{
			_0xHLi8nosulfonates(delegate
			{
				ServiceManagementExtensionMethods.ShutdownVirtualMachineRole(Svc, SubscriptionId, _0xHOvaln6ss, _0xHMala1ostra1ans, _0xHP0gin0l, true);
			}, _0xHM2rshes._0xHHellac1ous());
		}

		public void _0xHAmph5boles(string _0xHShti6ks, string _0xHFossi4s, string _0xHCon6or)
		{
			_0xHLi8nosulfonates(delegate
			{
				ServiceManagementExtensionMethods.StartVirtualMachineRole(Svc, SubscriptionId, _0xHShti6ks, _0xHFossi4s, _0xHCon6or);
			}, _0xHM2rshes._0xHHellac1ous());
		}

		public void _0xHPlea5uring(string _0xHOv6rscor6, string _0xHTr5nsferrers, string _0xHAl2vin)
		{
			_0xHLi8nosulfonates(delegate
			{
				ServiceManagementExtensionMethods.RestartVirtualMachineRole(Svc, SubscriptionId, _0xHOv6rscor6, _0xHTr5nsferrers, _0xHAl2vin);
			}, _0xHM2rshes._0xHHellac1ous());
		}

		public void _0xHTwinkle8(string _0xHCa8arrhal, string _0xHAc4tylativ4, string _0xHIndigencie2, string _0xHCombin4ds, string _0xHInterfacin3s, string _0xHOrgasm3c, string _0xHLichenin2, string _0xHDado7, string _0xHGrun4s)
		{
			_0xHLi8nosulfonates(delegate
			{
				ServiceManagementExtensionMethods.CaptureVirtualMachineImage(Svc, SubscriptionId, _0xHCa8arrhal, _0xHAc4tylativ4, _0xHIndigencie2, _0xHCombin4ds, _0xHInterfacin3s, _0xHOrgasm3c, _0xHLichenin2, _0xHDado7, _0xHGrun4s);
			}, _0xHM2rshes._0xHHellac1ous());
		}

		public Task _0xH0opscotched(string _0xHDissen6ien6s, string _0xHR3wok3, string _0xHM2velessly, ResourceExtensionReference _0xHC3urters, IEnumerable<InputEndpoint> _0xHD2tz)
		{
			return Task.Run(async delegate
			{
				PersistentVMRole config = ServiceManagementExtensionMethods.GetRole(Svc, SubscriptionId, _0xHDissen6ien6s, _0xHR3wok3, _0xHM2velessly);
				List<ResourceExtensionReference> list = ((config.get_ResourceExtensionReferences() != null) ? new List<ResourceExtensionReference>(config.get_ResourceExtensionReferences()) : new List<ResourceExtensionReference>());
				ResourceExtensionReference val = ((IEnumerable<ResourceExtensionReference>)list).FirstOrDefault((Func<ResourceExtensionReference, bool>)((ResourceExtensionReference ext) => string.Equals(ext.get_ReferenceName(), _0xHC3urters.get_ReferenceName(), StringComparison.Ordinal)));
				if (val != null)
				{
					list.Remove(val);
				}
				list.Add(_0xHC3urters);
				config.set_ResourceExtensionReferences(list.ToArray());
				if (_0xHD2tz != null)
				{
					InputEndpointList inputEndpoints = ((IEnumerable<ConfigurationSet>)config.get_ConfigurationSets()).Where((ConfigurationSet set) => set.get_ConfigurationSetType() == "NetworkConfiguration").Single().get_InputEndpoints();
					foreach (InputEndpoint endpoint in _0xHD2tz)
					{
						InputEndpoint item = ((IEnumerable<InputEndpoint>)inputEndpoints).FirstOrDefault((Func<InputEndpoint, bool>)((InputEndpoint ep) => string.Equals(ep.get_Name(), endpoint.get_Name(), StringComparison.Ordinal)));
						if (endpoint != null)
						{
							((List<InputEndpoint>)(object)inputEndpoints).Remove(item);
						}
						((List<InputEndpoint>)(object)inputEndpoints).Add(endpoint);
					}
				}
				await _0xHLaxati6e(delegate
				{
					ServiceManagementExtensionMethods.UpdatePersistentVMRole(Svc, SubscriptionId, _0xHDissen6ien6s, _0xHR3wok3, _0xHM2velessly, config);
				}, _0xHM2rshes._0xHHellac1ous());
			});
		}

		public Task _0xHDra3ady(string _0xHDy4rchy, string _0xHToxig0nicity, string _0xHPre3ea3on3, string _0xHBeauteou4ne44)
		{
			return Task.Run(async delegate
			{
				PersistentVMRole config = ServiceManagementExtensionMethods.GetRole(Svc, SubscriptionId, _0xHDy4rchy, _0xHToxig0nicity, _0xHPre3ea3on3);
				List<ResourceExtensionReference> list = ((config.get_ResourceExtensionReferences() != null) ? new List<ResourceExtensionReference>(config.get_ResourceExtensionReferences()) : new List<ResourceExtensionReference>());
				ResourceExtensionReference val = ((IEnumerable<ResourceExtensionReference>)list).FirstOrDefault((Func<ResourceExtensionReference, bool>)((ResourceExtensionReference ext) => string.Equals(ext.get_ReferenceName(), _0xHBeauteou4ne44, StringComparison.Ordinal)));
				if (val != null && !string.Equals(val.get_State(), "disable", StringComparison.OrdinalIgnoreCase))
				{
					val.set_State("disable");
					config.set_ResourceExtensionReferences(list.ToArray());
					await _0xHLaxati6e(delegate
					{
						ServiceManagementExtensionMethods.UpdatePersistentVMRole(Svc, SubscriptionId, _0xHDy4rchy, _0xHToxig0nicity, _0xHPre3ea3on3, config);
					}, _0xHM2rshes._0xHHellac1ous());
				}
			});
		}

		public Task _0xH8indows(string _0xHDira7, string _0xHSonne55ed, string _0xH5lema, IVirtualMachineInstance _0xHC6meo)
		{
			return Task.Run(async delegate
			{
				PersistentVMRole role = ServiceManagementExtensionMethods.GetRole(Svc, SubscriptionId, _0xHDira7, _0xHSonne55ed, _0xH5lema);
				IClassicVirtualMachineInstance val = (IClassicVirtualMachineInstance)_0xHC6meo;
				role.set_AvailabilitySetName(val.get_AvailabilitySet());
				role.set_RoleSize(val.get_Size());
				NetworkConfigurationSet obj = ((IEnumerable)role.get_ConfigurationSets()).OfType<NetworkConfigurationSet>().Single();
				((ConfigurationSet)obj).set_InputEndpoints((InputEndpointList)(((object)((ConfigurationSet)obj).get_InputEndpoints()) ?? ((object)new InputEndpointList())));
				((List<InputEndpoint>)(object)((ConfigurationSet)obj).get_InputEndpoints()).Clear();
				((List<InputEndpoint>)(object)((ConfigurationSet)obj).get_InputEndpoints()).AddRange(val.get_Endpoints().Select((Func<IEndpoint, InputEndpoint>)delegate(IEndpoint endpoint)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_0011: Unknown result type (might be due to invalid IL or missing references)
					//IL_001d: Unknown result type (might be due to invalid IL or missing references)
					//IL_0029: Unknown result type (might be due to invalid IL or missing references)
					//IL_0035: Unknown result type (might be due to invalid IL or missing references)
					//IL_0042: Expected O, but got Unknown
					InputEndpoint val6 = new InputEndpoint();
					val6.set_LocalPort(endpoint.get_PrivatePort());
					val6.set_Name(endpoint.get_Name());
					val6.set_Port(endpoint.get_PublicPort());
					val6.set_Protocol(endpoint.get_Protocol());
					val6.set_LoadBalancedEndpointSetName(endpoint.get_LoadBalanceSet());
					return val6;
				}));
				IOSVirtualHardDisk val2 = val.get_VirtualHardDisks().OfType<IOSVirtualHardDisk>().Single();
				PersistentVMRole obj2 = role;
				OSVirtualHardDisk val3 = new OSVirtualHardDisk();
				HostCachingMode hostCaching = ((IVirtualHardDisk)val2).get_HostCaching();
				val3.set_HostCaching(((object)(HostCachingMode)(ref hostCaching)).ToString());
				val3.set_DiskLabel(((IVirtualHardDisk)val2).get_DiskName());
				val3.set_MediaLink(((IVirtualHardDisk)val2).get_MediaLink());
				val3.set_SourceImageName(val2.get_SourceImageName());
				obj2.set_OSVirtualHardDisk(val3);
				role.set_DataVirtualHardDisks(val.get_VirtualHardDisks().OfType<IDataVirtualHardDisk>().Select((Func<IDataVirtualHardDisk, DataVirtualHardDisk>)delegate(IDataVirtualHardDisk dataDisk)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_0007: Unknown result type (might be due to invalid IL or missing references)
					//IL_000c: Unknown result type (might be due to invalid IL or missing references)
					//IL_001f: Unknown result type (might be due to invalid IL or missing references)
					//IL_002b: Unknown result type (might be due to invalid IL or missing references)
					//IL_0047: Unknown result type (might be due to invalid IL or missing references)
					//IL_005b: Unknown result type (might be due to invalid IL or missing references)
					//IL_0068: Expected O, but got Unknown
					DataVirtualHardDisk val5 = new DataVirtualHardDisk();
					HostCachingMode hostCaching2 = ((IVirtualHardDisk)dataDisk).get_HostCaching();
					val5.set_HostCaching(((object)(HostCachingMode)(ref hostCaching2)).ToString());
					val5.set_DiskName(((IVirtualHardDisk)dataDisk).get_DiskName());
					val5.set_Lun((dataDisk.get_Lun() == null) ? null : dataDisk.get_Lun().ToString());
					val5.set_LogicalDiskSizeInGB(dataDisk.get_LogicalDiskSizeInGB().ToString());
					val5.set_MediaLink(((IVirtualHardDisk)dataDisk).get_MediaLink());
					return val5;
				})
					.ToArray());
				role.set_ResourceExtensionReferences((ResourceExtensionReference[])(((object)role.get_ResourceExtensionReferences()) ?? ((object)new ResourceExtensionReference[0])));
				role.set_ResourceExtensionReferences(val.get_ResourceExtensions().Select((Func<IVMResourceExtension, ResourceExtensionReference>)delegate(IVMResourceExtension ext)
				{
					//IL_000d: Unknown result type (might be due to invalid IL or missing references)
					//IL_0012: Unknown result type (might be due to invalid IL or missing references)
					//IL_0023: Unknown result type (might be due to invalid IL or missing references)
					//IL_0034: Unknown result type (might be due to invalid IL or missing references)
					//IL_0045: Unknown result type (might be due to invalid IL or missing references)
					//IL_0082: Unknown result type (might be due to invalid IL or missing references)
					//IL_0098: Unknown result type (might be due to invalid IL or missing references)
					//IL_00aa: Expected O, but got Unknown
					ResourceExtensionReference val4 = new ResourceExtensionReference();
					val4.set_Name(ext.get_Name());
					val4.set_Publisher(ext.get_Publisher());
					val4.set_ReferenceName(ext.get_ReferenceName());
					val4.set_ResourceExtensionParameterValues(_0xHC5nsumptively(ext.get_PublicConfiguration(), ext.get_PrivateConfiguration(), ((IEnumerable<ResourceExtensionReference>)role.get_ResourceExtensionReferences()).FirstOrDefault((Func<ResourceExtensionReference, bool>)((ResourceExtensionReference r) => r.get_ReferenceName() == ext.get_ReferenceName()))));
					val4.set_State(_0xHSub4tantivize4(ext.get_Enabled()));
					val4.set_Version(ext.get_Version());
					return val4;
				}).ToArray());
				await _0xHLaxati6e(delegate
				{
					ServiceManagementExtensionMethods.UpdatePersistentVMRole(Svc, SubscriptionId, _0xHDira7, _0xHSonne55ed, _0xH5lema, role);
				}, _0xHM2rshes._0xHHellac1ous());
			});
		}

		private static string _0xHSub4tantivize4(bool _0xHO2scurants)
		{
			if (!_0xHO2scurants)
			{
				return "disable";
			}
			return "enable";
		}

		private static ResourceExtensionParameterValue[] _0xHC5nsumptively(string _0xHMyx3viral, string _0xH2oriferal, ResourceExtensionReference _0xHA44oyo)
		{
			ResourceExtensionParameterValue[] _0xHPump3rnick3ls = ((_0xHA44oyo != null) ? _0xHA44oyo.get_ResourceExtensionParameterValues() : null);
			_0xHPump3rnick3ls = _0xHS1nit1ry(_0xHMyx3viral, "Public", _0xHPump3rnick3ls);
			return _0xHS1nit1ry(_0xH2oriferal, "Private", _0xHPump3rnick3ls);
		}

		private static ResourceExtensionParameterValue[] _0xHS1nit1ry(string _0xH4nterfusing, string _0xHI6teri6flue6ces, ResourceExtensionParameterValue[] _0xHPump3rnick3ls)
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			List<ResourceExtensionParameterValue> list = new List<ResourceExtensionParameterValue>();
			ResourceExtensionParameterValue val = null;
			if (_0xHPump3rnick3ls != null)
			{
				list = _0xHPump3rnick3ls.ToList();
				val = ((IEnumerable<ResourceExtensionParameterValue>)list).SingleOrDefault((Func<ResourceExtensionParameterValue, bool>)((ResourceExtensionParameterValue p) => p.get_Type() == _0xHI6teri6flue6ces));
				if (val != null)
				{
					if (_0xH4nterfusing != null)
					{
						val.set_Value(Convert.ToBase64String(Encoding.UTF8.GetBytes(_0xH4nterfusing)));
					}
					else
					{
						list.Remove(val);
					}
				}
			}
			if (val == null && _0xH4nterfusing != null)
			{
				ResourceExtensionParameterValue val2 = new ResourceExtensionParameterValue();
				val2.set_Key(_0xHI6teri6flue6ces);
				val2.set_Type(_0xHI6teri6flue6ces);
				val2.set_Value(Convert.ToBase64String(Encoding.UTF8.GetBytes(_0xH4nterfusing)));
				val = val2;
				list.Add(val);
			}
			return list.ToArray();
		}

		public void _0xHSu1tab1l1ty(string _0xHEvicti8n, string _0xHUn4ive, string _0xHEnsna7e7s)
		{
			if (((List<Role>)(object)ServiceManagementExtensionMethods.GetDeployment(Svc, SubscriptionId, _0xHEvicti8n, _0xHUn4ive).get_RoleList()).Count > 1)
			{
				_0xHLi8nosulfonates(delegate
				{
					ServiceManagementExtensionMethods.DeleteVirtualMachineRole(Svc, SubscriptionId, _0xHEvicti8n, _0xHUn4ive, _0xHEnsna7e7s);
				}, _0xHM2rshes._0xHHellac1ous());
			}
			else
			{
				_0xHLi8nosulfonates(delegate
				{
					ServiceManagementExtensionMethods.DeleteDeployment(Svc, SubscriptionId, _0xHEvicti8n, _0xHUn4ive);
				}, _0xHM2rshes._0xHHellac1ous());
			}
		}

		public Deployment _0xHHoldfa5t5(string _0xHGr5ndp5renthood, string _0xHGridin5)
		{
			return _0xHCa0fa0es(_0xHGr5ndp5renthood, _0xHGridin5, _0xHM2rshes._0xHHellac1ous());
		}

		public Deployment _0xHCa0fa0es(string _0xHMelod8amatised, string _0xHT6ustability, _0xHUn0urbing _0xHKe7kle)
		{
			return _0xHYa8dland(() => ServiceManagementExtensionMethods.GetDeploymentBySlot(Svc, SubscriptionId, _0xHMelod8amatised, _0xHT6ustability), _0xHKe7kle);
		}

		public void _0xHCurri4le(string _0xHE2ict, string _0xH8irstly, Action<Deployment> _0xHAna3ogy, Action<Exception> _0xH2ieldfares)
		{
			Deployment deployment;
			Svc.BeginGetDeploymentBySlot(SubscriptionId, _0xHE2ict, _0xH8irstly, (AsyncCallback)delegate(IAsyncResult r)
			{
				try
				{
					deployment = Svc.EndGetDeploymentBySlot(r);
					if (_0xHAna3ogy != null)
					{
						_0xHDr1in(delegate
						{
							_0xHAna3ogy(deployment);
						}, _0xH2ieldfares, "GetDeploymentBySlot: ");
					}
				}
				catch (Exception _0xHRipos0e)
				{
					_0xHSe0oys(_0xHRipos0e, _0xH2ieldfares, "GetDeploymentBySlot: ");
				}
			}, (object)null);
		}

		public Task<Deployment> _0xH2pstared(string _0xHCo4oplums, string _0xHSm3rk3d)
		{
			return ServiceManagementExtensionMethods.GetDeploymentBySlotAsync(Svc, SubscriptionId, _0xHCo4oplums, _0xHSm3rk3d);
		}

		public HostedService _0xHAucub3s(string _0xH3is)
		{
			return ServiceManagementExtensionMethods.GetHostedService(Svc, SubscriptionId, _0xH3is);
		}

		public Task _0xHSpike2s(string _0xHBi8artisanshi8)
		{
			return Task.Factory.FromAsync((Func<string, string, AsyncCallback, object?, IAsyncResult>)Svc.BeginDeleteStorageService, (Func<IAsyncResult, bool>)Svc.EndDeleteStorageService, SubscriptionId, _0xHBi8artisanshi8, (object?)null);
		}

		public HostedService _0xH7mbiance(string _0xH6rantors)
		{
			return ServiceManagementExtensionMethods.GetHostedServiceWithDetails(Svc, SubscriptionId, _0xH6rantors, true);
		}

		public Task<HostedService> _0xH7onjoiners(string _0xHP3ycho)
		{
			return ServiceManagementExtensionMethods.GetHostedServiceWithDetailAsync(Svc, SubscriptionId, _0xHP3ycho);
		}

		public StorageService _0xHPanti0ocracie0(string _0xHHo1ologic)
		{
			return _0xHFrui8fulness(_0xHHo1ologic, _0xHM2rshes._0xHHellac1ous());
		}

		public StorageService _0xHFrui8fulness(string _0xHCa5sarian, _0xHUn0urbing _0xHSti0ettoes)
		{
			return _0xHYa8dland(() => ServiceManagementExtensionMethods.GetStorageKeys(Svc, SubscriptionId, _0xHCa5sarian), _0xHSti0ettoes);
		}

		public void _0xH5ical(string _0xHBe7springs, Action<StorageService> _0xHF0ondeu0, Action<Exception> _0xHLin2m)
		{
			StorageService storageService;
			Svc.BeginGetStorageKeys(SubscriptionId, _0xHBe7springs, (AsyncCallback)delegate(IAsyncResult r)
			{
				try
				{
					storageService = Svc.EndGetStorageKeys(r);
					if (_0xHF0ondeu0 != null)
					{
						_0xHDr1in(delegate
						{
							_0xHF0ondeu0(storageService);
						}, _0xHLin2m, "GetStorageKeys: ");
					}
				}
				catch (Exception _0xHRipos0e)
				{
					_0xHSe0oys(_0xHRipos0e, _0xHLin2m, "GetStorageKeys: ");
				}
			}, (object)null);
		}

		public Task<StorageService> _0xHPri5celi5esses(string _0xHNo5rated)
		{
			return ServiceManagementExtensionMethods.GetStorageKeysAsync(Svc, SubscriptionId, _0xHNo5rated);
		}

		public StorageService _0xHAno0exics(string _0xHEmig4ation)
		{
			return _0xHCommu7a7or(_0xHEmig4ation, _0xHM2rshes._0xHHellac1ous());
		}

		public StorageService _0xHCommu7a7or(string _0xHAm7ndabl7, _0xHUn0urbing _0xHCro66buck)
		{
			return _0xHYa8dland(() => ServiceManagementExtensionMethods.GetStorageService(Svc, SubscriptionId, _0xHAm7ndabl7), _0xHCro66buck);
		}

		public Task<StorageService> _0xHPulchritud8(string _0xHCrossb8rred)
		{
			return ServiceManagementExtensionMethods.GetStorageServiceAsync(Svc, SubscriptionId, _0xHCrossb8rred);
		}

		public HostedServiceList _0xHM0r0()
		{
			return ServiceManagementExtensionMethods.ListHostedServices(Svc, SubscriptionId);
		}

		public void _0xHBatter4(Action<HostedServiceList> _0xHT1l1vi1w1d, Action<Exception> _0xHFl77zie)
		{
			HostedServiceList list;
			Svc.BeginListHostedServices(SubscriptionId, (AsyncCallback)delegate(IAsyncResult r)
			{
				try
				{
					list = Svc.EndListHostedServices(r);
					if (_0xHT1l1vi1w1d != null)
					{
						_0xHDr1in(delegate
						{
							_0xHT1l1vi1w1d(list);
						}, _0xHFl77zie, "ListHostedServices: ");
					}
				}
				catch (Exception _0xHRipos0e)
				{
					_0xHSe0oys(_0xHRipos0e, _0xHFl77zie, "ListHostedServices: ");
				}
			}, (object)null);
		}

		public Task<LocationList> _0xHAgglut8nab8l8ty()
		{
			return Task.Factory.FromAsync((Func<string, AsyncCallback, object?, IAsyncResult>)Svc.BeginListLocations, (Func<IAsyncResult, LocationList>)Svc.EndListLocations, SubscriptionId, (object?)null);
		}

		public void _0xHAmp6itudes(Action<HostedServiceList> _0xHCiphe4e4, Action<Exception> _0xHAnti0ollution)
		{
			HostedServiceList list;
			int remaining;
			ManualResetEvent signal;
			Svc.BeginListHostedServices(SubscriptionId, (AsyncCallback)delegate(IAsyncResult r)
			{
				try
				{
					list = Svc.EndListHostedServices(r);
					remaining = ((List<HostedService>)(object)list).Count;
					if (remaining == 0)
					{
						_0xHDr1in(delegate
						{
							_0xHCiphe4e4(list);
						}, _0xHAnti0ollution, "ListHostedServicesDetails: ");
					}
					else
					{
						signal = new ManualResetEvent(initialState: false);
						for (int j = 0; j < ((List<HostedService>)(object)list).Count; j++)
						{
							int i = j;
							Svc.BeginGetHostedServiceWithDetails(SubscriptionId, ((List<HostedService>)(object)list)[i].get_ServiceName(), true, (AsyncCallback)delegate(IAsyncResult r2)
							{
								try
								{
									HostedService val = Svc.EndGetHostedServiceWithDetails(r2);
									((List<HostedService>)(object)list)[i].set_HostedServiceProperties(val.get_HostedServiceProperties());
									((List<HostedService>)(object)list)[i].set_Deployments(val.get_Deployments());
								}
								catch (Exception _0xHRipos0e2)
								{
									_0xHSe0oys(_0xHRipos0e2, _0xHAnti0ollution, "ListHostedServicesDetails: ");
								}
								if (Interlocked.Decrement(ref remaining) == 0)
								{
									signal.Set();
								}
							}, (object)null);
						}
						if (signal.WaitOne(TimeSpan.FromMinutes(2 * ((List<HostedService>)(object)list).Count)))
						{
							_0xHDr1in(delegate
							{
								_0xHCiphe4e4(list);
							}, _0xHAnti0ollution, "ListHostedServicesDetails: ");
						}
					}
				}
				catch (Exception _0xHRipos0e)
				{
					_0xHSe0oys(_0xHRipos0e, _0xHAnti0ollution, "ListHostedServiceDetails: ");
				}
			}, (object)null);
		}

		public StorageServiceList _0xHCo2doler()
		{
			return ServiceManagementExtensionMethods.ListStorageServices(Svc, SubscriptionId);
		}

		public Task<StorageServiceList> _0xHMildne22e2()
		{
			return ServiceManagementExtensionMethods.ListStorageServicesAsync(Svc, SubscriptionId);
		}

		public void _0xHRe6erge(Action<StorageServiceList> _0xHOve1past, Action<Exception> _0xHA4fakis)
		{
			StorageServiceList list;
			Svc.BeginListStorageServices(SubscriptionId, (AsyncCallback)delegate(IAsyncResult r)
			{
				try
				{
					list = Svc.EndListStorageServices(r);
					if (_0xHOve1past != null)
					{
						_0xHDr1in(delegate
						{
							_0xHOve1past(list);
						}, _0xHA4fakis, "ListStorageServices: ");
					}
				}
				catch (Exception _0xHRipos0e)
				{
					_0xHSe0oys(_0xHRipos0e, _0xHA4fakis, "ListStorageServices: ");
				}
			}, (object)null);
		}

		public void _0xHAcc0stomation(Action<StorageServiceList> _0xHPol3t3cal3zed, Action<Exception> _0xHUn6emembe6ed)
		{
			StorageServiceList list;
			int remaining;
			ManualResetEvent signal;
			Svc.BeginListStorageServices(SubscriptionId, (AsyncCallback)delegate(IAsyncResult r)
			{
				try
				{
					list = Svc.EndListStorageServices(r);
					remaining = ((List<StorageService>)(object)list).Count;
					if (remaining == 0)
					{
						_0xHDr1in(delegate
						{
							_0xHPol3t3cal3zed(list);
						}, _0xHUn6emembe6ed, "ListStorageServicesDetails: ");
					}
					else
					{
						signal = new ManualResetEvent(initialState: false);
						for (int j = 0; j < ((List<StorageService>)(object)list).Count; j++)
						{
							int i = j;
							Svc.BeginGetStorageService(SubscriptionId, ((List<StorageService>)(object)list)[i].get_ServiceName(), (AsyncCallback)delegate(IAsyncResult r2)
							{
								try
								{
									StorageService val = Svc.EndGetStorageService(r2);
									((List<StorageService>)(object)list)[i].set_StorageServiceProperties(val.get_StorageServiceProperties());
								}
								catch (Exception _0xHRipos0e2)
								{
									_0xHSe0oys(_0xHRipos0e2, _0xHUn6emembe6ed, "ListStorageServicesDetails: ");
								}
								if (Interlocked.Decrement(ref remaining) == 0)
								{
									signal.Set();
								}
							}, (object)null);
						}
						if (signal.WaitOne(TimeSpan.FromMinutes(2 * ((List<StorageService>)(object)list).Count)))
						{
							_0xHDr1in(delegate
							{
								_0xHPol3t3cal3zed(list);
							}, _0xHUn6emembe6ed, "ListStorageServicesDetails: ");
						}
					}
				}
				catch (Exception _0xHRipos0e)
				{
					_0xHSe0oys(_0xHRipos0e, _0xHUn6emembe6ed, "ListStorageServiceDetails: ");
				}
			}, (object)null);
		}

		public Deployment _0xHSqu44g44s(string _0xH6auseways, string _0xHLa88upe8)
		{
			try
			{
				return _0xHHoldfa5t5(_0xH6auseways, _0xHLa88upe8);
			}
			catch
			{
				return null;
			}
		}

		public void _0xHAkvavi5(string _0xHDiss6luteness, string _0xHSpol1ate)
		{
			_0xHCh2r2graphy(_0xHDiss6luteness, _0xHSpol1ate, _0xHM2rshes._0xHHellac1ous());
		}

		public void _0xHCh2r2graphy(string _0xH1hammy, string _0xH5ubbed, _0xHUn0urbing _0xHH5llo)
		{
			_0xHLi8nosulfonates(delegate
			{
				//IL_0022: Unknown result type (might be due to invalid IL or missing references)
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected O, but got Unknown
				IServiceManagement svc = Svc;
				string subscriptionId = SubscriptionId;
				string text = _0xH1hammy;
				string text2 = _0xH5ubbed;
				UpdateDeploymentStatusInput val = new UpdateDeploymentStatusInput();
				val.set_Status("Running");
				ServiceManagementExtensionMethods.UpdateDeploymentStatusBySlot(svc, subscriptionId, text, text2, val);
			}, _0xHH5llo);
		}

		public void _0xHPl0smolyzed(string _0xHMu22a, string _0xHRou2he)
		{
			_0xHA0pinists(_0xHMu22a, _0xHRou2he, _0xHM2rshes._0xHHellac1ous());
		}

		public void _0xHA0pinists(string _0xH2leistogamous, string _0xHTe8, _0xHUn0urbing _0xHHyen0s)
		{
			_0xHLi8nosulfonates(delegate
			{
				//IL_0022: Unknown result type (might be due to invalid IL or missing references)
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected O, but got Unknown
				IServiceManagement svc = Svc;
				string subscriptionId = SubscriptionId;
				string text = _0xH2leistogamous;
				string text2 = _0xHTe8;
				UpdateDeploymentStatusInput val = new UpdateDeploymentStatusInput();
				val.set_Status("Suspended");
				ServiceManagementExtensionMethods.UpdateDeploymentStatusBySlot(svc, subscriptionId, text, text2, val);
			}, _0xHHyen0s);
		}

		public Task _0xHCutle7y(string _0xH5od, string _0xHHeloti8m)
		{
			return Task.Run(async delegate
			{
				await _0xHLaxati6e(delegate
				{
					//IL_0022: Unknown result type (might be due to invalid IL or missing references)
					//IL_0027: Unknown result type (might be due to invalid IL or missing references)
					//IL_0037: Expected O, but got Unknown
					IServiceManagement svc = Svc;
					string subscriptionId = SubscriptionId;
					string text = _0xH5od;
					string text2 = _0xHHeloti8m;
					UpdateDeploymentStatusInput val = new UpdateDeploymentStatusInput();
					val.set_Status("Suspended");
					ServiceManagementExtensionMethods.UpdateDeploymentStatusBySlot(svc, subscriptionId, text, text2, val);
				}, _0xHM2rshes._0xHHellac1ous());
			});
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void _0xH1oozing(string _0xHFro6ziest, X509Certificate2 _0xHM55t, _0xHUn0urbing _0xH8emots)
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			char[] array = _0xHPan5os._0xHC0cadae();
			CertificateFile certificateFile = null;
			using (SecureString secureString = new SecureString())
			{
				for (int i = 0; i < array.Length; i++)
				{
					secureString.AppendChar(array[i]);
				}
				CertificateFile val = new CertificateFile();
				val.set_CertificateFormat("Pfx");
				val.set_Password(new string(array));
				val.set_Data(Convert.ToBase64String(_0xHM55t.Export(X509ContentType.Pfx, secureString)));
				certificateFile = val;
			}
			Array.Clear(array, 0, array.Length);
			_0xHLi8nosulfonates(delegate
			{
				ServiceManagementExtensionMethods.AddCertificates(Svc, SubscriptionId, _0xHFro6ziest, certificateFile);
			}, _0xH8emots);
		}

		public CertificateList _0xHS2lutters(string _0xHFan0s, _0xHUn0urbing _0xHSu3ver)
		{
			return _0xHYa8dland(() => ServiceManagementExtensionMethods.ListCertificates(Svc, SubscriptionId, _0xHFan0s), _0xHSu3ver);
		}

		public Certificate _0xHPubi4(string _0xHMega3honed, string _0xHF5oosie, _0xHUn0urbing _0xHPl6b6ian)
		{
			return _0xHYa8dland((Func<Certificate>)delegate
			{
				//IL_0034: Expected O, but got Unknown
				try
				{
					return ServiceManagementExtensionMethods.GetCertificate(Svc, SubscriptionId, _0xHMega3honed, "sha1", _0xHF5oosie);
				}
				catch (EndpointNotFoundException val)
				{
					if (!(((Exception)val).InnerException is WebException ex) || !(ex.Response is HttpWebResponse httpWebResponse) || httpWebResponse.StatusCode != HttpStatusCode.NotFound)
					{
						throw;
					}
					return null;
				}
			}, _0xHPl6b6ian);
		}

		public void _0xHInconvincibl0(string _0xHTaxidermi5t5, string _0xHP0on, WalkUpgradeDomainInput _0xH6uctilely, _0xHUn0urbing _0xHButt6nh66king)
		{
			_0xHLi8nosulfonates(delegate
			{
				ServiceManagementExtensionMethods.WalkUpgradeDomainBySlot(Svc, SubscriptionId, _0xHTaxidermi5t5, _0xHP0on, _0xH6uctilely);
			}, _0xHButt6nh66king);
		}

		public void _0xH3atched(Operation _0xHPlast4ques)
		{
			if (_0xHEquilib6ates != null)
			{
				_0xHEquilib6ates(_0xHPlast4ques);
			}
		}

		public void _0xHMate0asses(Action<_0xHDob8on8, Certificate> _0xHNorlan8s, Action<_0xHDob8on8, Exception> _0xHD4plo4dy, _0xHDob8on8 _0xHA6rl6ne)
		{
			Certificate certificate;
			Svc.BeginGetCertificate(SubscriptionId, _0xHA6rl6ne._0xHConst0llations, "sha1", _0xHA6rl6ne._0xHUncann7ness, (AsyncCallback)delegate(IAsyncResult r)
			{
				//IL_007d: Expected O, but got Unknown
				try
				{
					certificate = Svc.EndGetCertificate(r);
					if (_0xHNorlan8s != null)
					{
						_0xHDr1in(delegate
						{
							_0xHNorlan8s((_0xHDob8on8)r.AsyncState, certificate);
						}, delegate(Exception ex)
						{
							_0xHD4plo4dy((_0xHDob8on8)r.AsyncState, ex);
						}, "GetCertificate: ");
					}
				}
				catch (EndpointNotFoundException val)
				{
					EndpointNotFoundException val2 = val;
					if (((Exception)(object)val2).InnerException is WebException ex2 && ex2.Response is HttpWebResponse httpWebResponse && httpWebResponse.StatusCode == HttpStatusCode.NotFound)
					{
						_0xHDr1in(delegate
						{
							_0xHNorlan8s((_0xHDob8on8)r.AsyncState, null);
						}, delegate(Exception ex)
						{
							_0xHD4plo4dy((_0xHDob8on8)r.AsyncState, ex);
						}, "GetCertificate: ");
					}
					else
					{
						_0xHSe0oys((Exception)(object)val2, delegate(Exception ex)
						{
							_0xHD4plo4dy((_0xHDob8on8)r.AsyncState, ex);
						}, "GetCertificate: ");
					}
				}
				catch (Exception _0xHRipos0e)
				{
					_0xHSe0oys(_0xHRipos0e, delegate(Exception ex)
					{
						_0xHD4plo4dy((_0xHDob8on8)r.AsyncState, ex);
					}, "GetCertificate: ");
				}
			}, (object)_0xHA6rl6ne);
		}

		private void _0xHDr1in(Action _0xHCu7ios, Action<Exception> _0xHGo00ipper0, string _0xHF8g)
		{
			if (Sync != null)
			{
				Sync.Post(delegate
				{
					try
					{
						_0xHCu7ios();
					}
					catch (Exception ex)
					{
						try
						{
							if (_0xHGo00ipper0 != null)
							{
								_0xHGo00ipper0(ex);
							}
							else
							{
								_0xHGnos2icisms._0xHN5wsp5aks(_0xHComfit7, (__ACTIVITYLOG_ENTRYTYPE)2, _0xHF8g + ex.ToString());
							}
						}
						catch (Exception ex2)
						{
							_0xHGnos2icisms._0xHN5wsp5aks(_0xHComfit7, (__ACTIVITYLOG_ENTRYTYPE)2, _0xHF8g + ex2.ToString());
						}
					}
				}, null);
			}
			else
			{
				_0xHCu7ios();
			}
		}

		private void _0xHSe0oys(Exception _0xHRipos0e, Action<Exception> _0xH7issever, string _0xHDiphthonga4)
		{
			if (_0xH7issever == null)
			{
				return;
			}
			if (Sync != null)
			{
				Sync.Post(delegate
				{
					try
					{
						_0xH7issever(_0xHRipos0e);
					}
					catch (Exception ex)
					{
						_0xHGnos2icisms._0xHN5wsp5aks(_0xHComfit7, (__ACTIVITYLOG_ENTRYTYPE)2, _0xHDiphthonga4 + ex.ToString());
					}
				}, null);
			}
			else
			{
				_0xH7issever(_0xHRipos0e);
			}
		}

		[SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1002:SemicolonsMustBeSpacedCorrectly", Justification = "Visual Studio defaults format the for(int xyz = 0; ; xyz++) in this manner.")]
		private T _0xHYa8dland<T>(Func<T> _0xHR1id1ntifi1s, _0xHUn0urbing _0xHM3ndings)
		{
			int num = 0;
			while (true)
			{
				try
				{
					return _0xHR1id1ntifi1s();
				}
				catch (Exception lastException)
				{
					if (!_0xHM3ndings(num, lastException, out var delay))
					{
						throw;
					}
					if (!TimeSpan.Equals(delay, TimeSpan.Zero))
					{
						Thread.Sleep(delay);
					}
				}
				num++;
			}
		}

		private void _0xHAtempor8l(Action _0xHLa5gsy5e, _0xHUn0urbing _0xHNon2eminist)
		{
			_0xHYa8dland(delegate
			{
				_0xHLa5gsy5e();
				return false;
			}, _0xHNon2eminist);
		}

		private void _0xHLi8nosulfonates(Action _0xHCe3, _0xHUn0urbing _0xHSplo3ching)
		{
			if (_0xHV6gin6te != null)
			{
				_0xHV6gin6te(_0xHCe3, _0xHSplo3ching);
			}
			else
			{
				_0xHStereot7pes(_0xHCe3, _0xHSplo3ching);
			}
		}

		private Task _0xHLaxati6e(Action _0xH4akahe, _0xHUn0urbing _0xHPr1m1ditat1dly)
		{
			if (_0xHRepossess2on != null)
			{
				return _0xHRepossess2on(_0xH4akahe, _0xHPr1m1ditat1dly);
			}
			return _0xHB4rses(_0xH4akahe, _0xHPr1m1ditat1dly);
		}

		internal void _0xHStereot7pes(Action _0xHSpecime1s, _0xHUn0urbing _0xHNonst4nd4rd)
		{
			string operationId = null;
			HttpStatusCode? statusCode = null;
			string statusDescription = null;
			_0xHAtempor8l(delegate
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Expected O, but got Unknown
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				OperationContextScope val2 = new OperationContextScope((IContextChannel)Svc);
				try
				{
					try
					{
						_0xHSpecime1s();
					}
					catch (Exception ex)
					{
						ServiceManagementError val3 = null;
						if (ServiceManagementErrorUtilities.TryGetServiceManagementError(ex, ref val3))
						{
							throw ServiceManagementException.Create(val3, ex);
						}
						throw;
					}
					if (WebOperationContext.get_Current().get_IncomingResponse() != null)
					{
						operationId = WebOperationContext.get_Current().get_IncomingResponse().get_Headers()["x-ms-request-id"];
						statusCode = WebOperationContext.get_Current().get_IncomingResponse().get_StatusCode();
						statusDescription = WebOperationContext.get_Current().get_IncomingResponse().get_StatusDescription();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}, _0xHNonst4nd4rd);
			if (operationId == null || !statusCode.HasValue || statusCode != HttpStatusCode.Accepted)
			{
				return;
			}
			Operation val = _0xHYa8dland(() => ServiceManagementExtensionMethods.GetOperationStatus(Svc, SubscriptionId, operationId), _0xHNonst4nd4rd);
			while (val.get_Status() != "Failed" && val.get_Status() != "Succeeded")
			{
				_0xH3atched(val);
				Thread.Sleep(TimeSpan.FromSeconds(PollIntervalInSeconds));
				val = _0xHYa8dland(() => ServiceManagementExtensionMethods.GetOperationStatus(Svc, SubscriptionId, operationId), _0xHNonst4nd4rd);
			}
			_0xHMurd4r44s(_0xHSpecime1s, val);
			_0xH3atched(val);
			if (val.get_Status() == "Failed")
			{
				throw ServiceManagementException.Create(val.get_Error(), (Exception)null);
			}
		}

		internal async Task _0xHB4rses(Action _0xHHogg6ng, _0xHUn0urbing _0xHLulla6y)
		{
			string operationId = null;
			HttpStatusCode? statusCode = null;
			string statusDescription = null;
			_0xHAtempor8l(delegate
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Expected O, but got Unknown
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				OperationContextScope val2 = new OperationContextScope((IContextChannel)Svc);
				try
				{
					try
					{
						_0xHHogg6ng();
					}
					catch (Exception ex)
					{
						ServiceManagementError val3 = null;
						if (ServiceManagementErrorUtilities.TryGetServiceManagementError(ex, ref val3))
						{
							throw ServiceManagementException.Create(val3, ex);
						}
						throw;
					}
					if (WebOperationContext.get_Current().get_IncomingResponse() != null)
					{
						operationId = WebOperationContext.get_Current().get_IncomingResponse().get_Headers()["x-ms-request-id"];
						statusCode = WebOperationContext.get_Current().get_IncomingResponse().get_StatusCode();
						statusDescription = WebOperationContext.get_Current().get_IncomingResponse().get_StatusDescription();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}, _0xHLulla6y);
			if (operationId == null || !statusCode.HasValue || statusCode != HttpStatusCode.Accepted)
			{
				return;
			}
			Operation val = _0xHYa8dland(() => ServiceManagementExtensionMethods.GetOperationStatus(Svc, SubscriptionId, operationId), _0xHLulla6y);
			while (val.get_Status() != "Failed" && val.get_Status() != "Succeeded")
			{
				await Task.Delay(TimeSpan.FromSeconds(PollIntervalInSeconds)).ConfigureAwait(continueOnCapturedContext: false);
				val = _0xHYa8dland(() => ServiceManagementExtensionMethods.GetOperationStatus(Svc, SubscriptionId, operationId), _0xHLulla6y);
			}
			_0xHMurd4r44s(_0xHHogg6ng, val);
			if (val.get_Status() == "Failed")
			{
				throw ServiceManagementException.Create(val.get_Error(), (Exception)null);
			}
		}

		private void _0xHMurd4r44s(Action _0xHNic8, Operation _0xH4ilencer)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			OperationEvent val = new OperationEvent("vs/azuretools/get-watserviceinfo", (TelemetryResult)0, (string)null);
			((TelemetryEvent)val).get_Properties()["VS.AzureTools.WatService.OperationName"] = _0xHNic8.Method.Name;
			((TelemetryEvent)val).get_Properties()["VS.AzureTools.WatService.SubscriptionId"] = SubscriptionId;
			((TelemetryEvent)val).get_Properties()["VS.AzureTools.WatService.OperationId"] = _0xH4ilencer.get_OperationTrackingId();
			((TelemetryEvent)val).get_Properties()["VS.AzureTools.WatService.HttpStatusCode"] = _0xH4ilencer.get_HttpStatusCode();
			((TelemetryEvent)val).get_Properties()["VS.AzureTools.WatService.Status"] = _0xH4ilencer.get_Status();
			_0xHOrc3estrating._0xH6niformness((TelemetryEvent)val);
		}

		private static string _0xHP7sitr7nium()
		{
			Version version = Assembly.GetExecutingAssembly().GetName().Version;
			return ServiceManagementUtilities.GetUserAgentString("Visual Studio SDK for .NET", version);
		}

		public IEnumerable<string> _0xHLargehear0ed(string _0xHMobocra5ic)
		{
			return (from role in _0xHSyncreti1ing(_0xHMobocra5ic)
				select role.get_AvailabilitySetName() into aset
				where !string.IsNullOrWhiteSpace(aset)
				select aset).Distinct().ToArray();
		}

		public IEnumerable<InputEndpoint> _0xHMicr3mete3rite(string _0xHS0cur0m0nt)
		{
			return (from conf in _0xHSyncreti1ing(_0xHS0cur0m0nt).SelectMany((PersistentVMRole role) => (IEnumerable<ConfigurationSet>)role.get_ConfigurationSets()).OfType<NetworkConfigurationSet>()
				where ((ConfigurationSet)conf).get_InputEndpoints() != null
				select conf).SelectMany((NetworkConfigurationSet conf) => (IEnumerable<InputEndpoint>)((ConfigurationSet)conf).get_InputEndpoints()).ToArray();
		}

		public IEnumerable<PersistentVMRole> _0xHSyncreti1ing(string _0xH0woosh)
		{
			return _0xHWhol2som2n2ss(_0xH0woosh).SelectMany((Deployment d) => (IEnumerable<Role>)d.get_RoleList()).OfType<PersistentVMRole>().ToArray();
		}

		public IEnumerable<Deployment> _0xHWhol2som2n2ss(string _0xHR3tatively)
		{
			return (from slot in new string[2] { "Production", "Staging" }.AsParallel()
				select _0xHSqu44g44s(_0xHR3tatively, slot) into d
				where d != null
				select d).ToArray();
		}

		public Task<HostedServiceExtensionList> _0xHOv6rfund6d(string _0xH6empter)
		{
			return ServiceManagementExtensionMethods.ListHostedServiceExtensionsTask(Svc, SubscriptionId, _0xH6empter);
		}

		public Task<ExtensionImageList> _0xHRaker5()
		{
			return ServiceManagementExtensionMethods.ListLatestExtensionsTask(Svc, SubscriptionId);
		}

		public Task<ExtensionImageList> _0xHRattl4ng(string _0xHHoodooi8g, string _0xHBagging0)
		{
			return ServiceManagementExtensionMethods.ListExtensionVersionsTask(Svc, SubscriptionId, _0xHHoodooi8g, _0xHBagging0);
		}

		public Task<HostedServiceExtensionList> _0xHGlanc2d(string _0xHKilow1tt)
		{
			return ServiceManagementExtensionMethods.ListHostedServiceExtensionsTask(Svc, SubscriptionId, _0xHKilow1tt);
		}

		public Task _0xHRebellion8(string _0xHHarpoo7er, string _0xHNoncomp6ex, string _0xHRhy4hmis4, string _0xHTravert5nes, string _0xH5utputted, string _0xH0ib, string _0xHReedi1esses, string _0xHChuckle3, string _0xHCon3nos3)
		{
			return Task.Run(async delegate
			{
				await _0xHLaxati6e(delegate
				{
					//IL_001c: Unknown result type (might be due to invalid IL or missing references)
					//IL_0021: Unknown result type (might be due to invalid IL or missing references)
					//IL_002d: Unknown result type (might be due to invalid IL or missing references)
					//IL_0039: Unknown result type (might be due to invalid IL or missing references)
					//IL_0045: Unknown result type (might be due to invalid IL or missing references)
					//IL_0051: Unknown result type (might be due to invalid IL or missing references)
					//IL_005d: Unknown result type (might be due to invalid IL or missing references)
					//IL_0069: Unknown result type (might be due to invalid IL or missing references)
					//IL_0075: Unknown result type (might be due to invalid IL or missing references)
					//IL_0086: Expected O, but got Unknown
					IServiceManagement svc = Svc;
					string subscriptionId = SubscriptionId;
					string text = _0xHHarpoo7er;
					HostedServiceExtensionInput val = new HostedServiceExtensionInput();
					val.set_Id(_0xHNoncomp6ex);
					val.set_PrivateConfiguration(_0xHRhy4hmis4);
					val.set_ProviderNameSpace(_0xH5utputted);
					val.set_PublicConfiguration(_0xHTravert5nes);
					val.set_Type(_0xH0ib);
					val.set_Version(_0xHReedi1esses);
					val.set_Thumbprint(_0xHChuckle3);
					val.set_ThumbprintAlgorithm(_0xHCon3nos3);
					ServiceManagementExtensionMethods.AddHostedServiceExtension(svc, subscriptionId, text, val);
				}, _0xHM2rshes._0xHHellac1ous());
			});
		}

		public Task _0xH5shcake(string _0xHNe0ros0rgeon, string _0xHS2un2)
		{
			return Task.Run(async delegate
			{
				await _0xHLaxati6e(delegate
				{
					ServiceManagementExtensionMethods.DeleteHostedServiceExtension(Svc, SubscriptionId, _0xHNe0ros0rgeon, _0xHS2un2);
				}, _0xHM2rshes._0xHHellac1ous());
			});
		}

		public Task _0xHS8phen8s(string _0xHSitolo8ies, string _0xH2ochs, ChangeConfigurationInput _0xHJujui6t)
		{
			return Task.Run(async delegate
			{
				await _0xHLaxati6e(delegate
				{
					ServiceManagementExtensionMethods.ChangeConfigurationBySlot(Svc, SubscriptionId, _0xHSitolo8ies, _0xH2ochs, _0xHJujui6t);
				}, _0xHM2rshes._0xHHellac1ous());
			});
		}

		public Task<NamespaceDescription[]> _0xHPlacoi4()
		{
			return _0xHYa8dland(() => ServiceManagementExtensionMethods.ListNamespacesAsync(Svc, SubscriptionId), _0xHM2rshes._0xHHellac1ous());
		}

		public Task<ConnectionDetail[]> _0xHBluis4(string _0xHR6sorb6d)
		{
			return _0xHYa8dland(() => ServiceManagementExtensionMethods.GetNamespaceDetailsAsync(Svc, SubscriptionId, _0xHR6sorb6d), _0xHM2rshes._0xHHellac1ous());
		}

		[CompilerGenerated]
		private Task<NamespaceDescription[]> _0xHHe2rken()
		{
			return ServiceManagementExtensionMethods.ListNamespacesAsync(Svc, SubscriptionId);
		}
	}

	private const string _0xHThermoplasti2 = "vs/azuretools/get-watserviceinfo";

	private const string _0xHC1s = "VS.AzureTools.WatService.OperationName";

	private const string _0xHExtramurall4 = "VS.AzureTools.WatService.SubscriptionId";

	private const string _0xHV8negar = "VS.AzureTools.WatService.OperationId";

	private const string _0xHTh7ws = "VS.AzureTools.WatService.HttpStatusCode";

	private const string _0xHMon3os = "VS.AzureTools.WatService.Status";

	internal static Action<Action, _0xHUn0urbing> _0xHV6gin6te { get; set; }

	internal static Func<Action, _0xHUn0urbing, Task> _0xHRepossess2on { get; set; }

	internal static Func<WebHttpBinding, Uri, X509Certificate2, string, string, IServiceManagement> _0xHApp0ecarts { get; set; }

	internal static Func<Binding, Uri, string, string, string, IServiceManagement> _0xHRav6n { get; set; }

	internal static Func<string, X509Certificate2, Uri, IWatServiceManagement> _0xHSubcate3ory { get; set; }

	internal static Func<string, string, Uri, IWatServiceManagement> _0xHDropk2ck { get; set; }

	static _0xHP2ehi2ing()
	{
		_0xHApp0ecarts = ServiceManagementHelper.CreateServiceManagementChannelWithCertificate;
		_0xHRav6n = ServiceManagementHelper.CreateServiceManagementChannelWithHeader;
		_0xHSubcate3ory = (string subscriptionID, X509Certificate2 certificate, Uri serviceManagementEndpointUri) => new _0xHChafe1s(subscriptionID, certificate, null, serviceManagementEndpointUri);
		_0xHDropk2ck = (string subscriptionID, string authenticationHeader, Uri serviceManagementEndpointUri) => new _0xHChafe1s(subscriptionID, null, authenticationHeader, serviceManagementEndpointUri);
	}

	public static string _0xHPasturela7ds(string _0xHEspyin6)
	{
		if (string.Equals(_0xHEspyin6, "Staging", StringComparison.OrdinalIgnoreCase))
		{
			return "Staging";
		}
		if (string.Equals(_0xHEspyin6, "Production", StringComparison.OrdinalIgnoreCase))
		{
			return "Production";
		}
		return null;
	}

	internal static void _0xHPo2sho2(string _0xHEnclo3ing, X509Certificate2 _0xHS0elling, Uri _0xHV7guishly, Action<string, bool, string, Exception> _0xHPrela1e)
	{
		try
		{
			IWatServiceManagement watServiceManagement = _0xHLympho0raphies(_0xHEnclo3ing, _0xHS0elling, _0xHV7guishly);
			watServiceManagement.Connect();
			watServiceManagement.GetSubscriptionAsync().ContinueWith(delegate(Task<Subscription> task)
			{
				if (task.IsFaulted)
				{
					Exception innerException = task.Exception!.Flatten().InnerException;
					string arg2 = innerException.Message;
					if (innerException is MessageSecurityException || innerException is CommunicationException)
					{
						_0xHL1mniscus._0xHIndividualisin4((object)(WatError)501);
						arg2 = ErrorResources.WaAuthorizationFailed;
					}
					if (_0xHPrela1e != null)
					{
						_0xHPrela1e(_0xHEnclo3ing, arg2: false, arg2, innerException);
					}
				}
				else if (_0xHPrela1e != null)
				{
					_0xHPrela1e(_0xHEnclo3ing, arg2: true, null, null);
				}
			});
		}
		catch (Exception arg)
		{
			if (_0xHPrela1e != null)
			{
				_0xHL1mniscus._0xHIndividualisin4((object)(WatError)502);
				_0xHPrela1e(_0xHEnclo3ing, arg2: false, ErrorResources.WaConnectionFailed, arg);
			}
		}
	}

	internal static IWatServiceManagement _0xHThr4ws(IAzureCredentials _0xHBrib5)
	{
		return _0xHLympho0raphies(_0xHBrib5.get_Subscription().get_SubscriptionId(), _0xHBrib5.GetCertificate(), _0xHBrib5.get_Subscription().get_ServiceManagementEndpoint());
	}

	internal static IWatServiceManagement _0xHLympho0raphies(string _0xHAzure7, X509Certificate2 _0xHPep7um, Uri _0xHUnb0s0mers)
	{
		return _0xHSubcate3ory(_0xHAzure7, _0xHPep7um, _0xHUnb0s0mers);
	}

	internal static IWatServiceManagement _0xHDi2lo2hase(string _0xHUn3ergoers, string _0xHPhotosynth2s2s, Uri _0xH0uskies)
	{
		return _0xHDropk2ck(_0xHUn3ergoers, _0xHPhotosynth2s2s, _0xH0uskies);
	}

	internal static IWatServiceManagement _0xHTe8tatrixe8(string _0xHCircl2s, X509Certificate2 _0xHF8ooey, string _0xHC4bst4nds, Uri _0xHE5siest)
	{
		if (_0xHF8ooey != null)
		{
			return _0xHLympho0raphies(_0xHCircl2s, _0xHF8ooey, _0xHE5siest);
		}
		return _0xHDi2lo2hase(_0xHCircl2s, _0xHC4bst4nds, _0xHE5siest);
	}

	internal static async Task<IWatServiceManagement> _0xHOu5quo5ed(IAzureSubscriptionContext _0xH5ehorning, bool _0xHSha4etail = false)
	{
		if (_0xH5ehorning == null)
		{
			throw new ArgumentNullException("context");
		}
		IAzureUserAccountSubscriptionContext userAccountContext = (IAzureUserAccountSubscriptionContext)(object)((_0xH5ehorning is IAzureUserAccountSubscriptionContext) ? _0xH5ehorning : null);
		if (userAccountContext == null)
		{
			IAzureAuthenticationCertificateSubscriptionContext credentialsContext = (IAzureAuthenticationCertificateSubscriptionContext)(object)((_0xH5ehorning is IAzureAuthenticationCertificateSubscriptionContext) ? _0xH5ehorning : null);
			if (credentialsContext == null)
			{
				throw new ArgumentException(Resources_Common.SubscriptionContextNotSupported, "context");
			}
			X509Certificate2 _0xHPep7um = await credentialsContext.get_AuthenticationCertificate().GetCertificateFromStoreAsync().ConfigureAwait(continueOnCapturedContext: false);
			return _0xHLympho0raphies(((IAzureSubscriptionContext)credentialsContext).get_Subscription().get_SubscriptionId(), _0xHPep7um, ((IAzureSubscriptionContext)credentialsContext).get_Subscription().get_ServiceManagementEndpoint());
		}
		try
		{
			string text = await userAccountContext.GetAuthenticationHeaderAsync(_0xHSha4etail).ConfigureAwait(continueOnCapturedContext: false);
			if (string.IsNullOrEmpty(text))
			{
				throw new _0xHMantels8elves(Resources_Common.FailedToGetLoginResult);
			}
			return _0xHDi2lo2hase(((IAzureSubscriptionContext)userAccountContext).get_Subscription().get_SubscriptionId(), text, ((IAzureSubscriptionContext)userAccountContext).get_Subscription().get_ServiceManagementEndpoint());
		}
		catch (Exception innerException)
		{
			throw new _0xHMantels8elves(Resources_Common.FailedToLogin, innerException);
		}
	}
}
