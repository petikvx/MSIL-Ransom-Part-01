using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Samples.WindowsAzure.ServiceManagement;
using Microsoft.VisualStudio.WindowsAzure.ServiceManagement.DataContracts;
using _0xH8ompah;
using _0xHBebeer1nes;
using _0xHN8m8l8gic;
using _0xHP1een;
using _0xHSui4able;
using _0xHSulphur5us;
using _0xHUnderprice0;

namespace _0xHGluc8ses;

internal class _0xHS3ns
{
	private const string _0xHHyperboli1t1 = "{0}-{1}-{2}-{3}";

	private const string _0xHWorld6iew = "MSVSAZ";

	private const string _0xHMinitr0ck = "Windows Azure Tools Encryption Certificate for Extensions";

	private const string _0xHHumi2or = "DC=Windows Azure Tools Encryption Certificate for Extensions";

	private IWatServiceManagement _0xHS4lsill4s;

	public _0xHS3ns(IWatServiceManagement serviceManagement)
	{
		_0xHS4lsill4s = serviceManagement;
	}

	public Task _0xH5eglegged(string _0xH1orb, string _0xHL0ris, string _0xHOutpour0r, string _0xHWi66lin6, bool _0xHIs0chr0nally)
	{
		if (_0xHIs0chr0nally)
		{
			return _0xHR8indictm8nts(_0xH1orb, _0xHL0ris, _0xHOutpour0r, _0xHWi66lin6);
		}
		return _0xHRepu7able(_0xH1orb, _0xHL0ris, _0xHOutpour0r, _0xHWi66lin6);
	}

	public async Task<IEnumerable<string>> _0xHFlame4(string _0xHThr6wing)
	{
		List<string> extensionIds = new List<string>();
		HostedServiceExtensionList val;
		try
		{
			val = await _0xHS4lsill4s.ListServiceExtensions(_0xHThr6wing);
		}
		catch (EndpointNotFoundException)
		{
			return extensionIds;
		}
		if (val != null)
		{
			extensionIds.AddRange(from ext in (IEnumerable<HostedServiceExtension>)val
				where _0xHL1teral1sm(ext.get_Id())
				select ext.get_Id());
		}
		return extensionIds;
	}

	public async Task _0xHGri00y(string _0xHSith4nc4, IEnumerable<string> _0xH3askmasters)
	{
		List<Task> list = new List<Task>();
		foreach (string _0xH3askmaster in _0xH3askmasters)
		{
			list.Add(_0xHS4lsill4s.DeleteServiceExtension(_0xHSith4nc4, _0xH3askmaster));
		}
		try
		{
			await Task.WhenAll(list);
		}
		catch
		{
		}
	}

	internal Task<_0xHSh4ngh4ier> _0xHArr3ww33ds(string _0xHUpligh0, string _0xHFl6swatters, string _0xH4massers, string _0xHPos3t3ons, string _0xHUnde8a8ms, int _0xHNe3s, int _0xHUnpe5s, bool _0xHType4rote, string _0xHAlve3li, string _0xHPharmac7st, string _0xHPolyphyleti5, string _0xHHur1ers, string _0xHWidthway5)
	{
		return _0xHEl7viate(_0xHUpligh0, _0xHFl6swatters, _0xH4massers, _0xHPos3t3ons, _0xHUnde8a8ms, _0xHNe3s, _0xHUnpe5s, _0xHType4rote, _0xHAlve3li, _0xHPharmac7st, _0xHPolyphyleti5, null, _0xHHur1ers, _0xHWidthway5);
	}

	public Task<_0xHSh4ngh4ier> _0xHSauce3(string _0xHD2scourag2ngly, string _0xHProsecuti4g, string _0xHInv4gorat4ng, string _0xH5auper, string _0xH4ain, int _0xHOr5inal, int _0xHFemt3sec3nd, bool _0xH4oeticize, string _0xHStan88own, string _0xHSest4ne, string _0xHRe7ublicanizes, IEnumerable<HostedServiceExtension> _0xHEndga6es = null)
	{
		return _0xHEl7viate(_0xHD2scourag2ngly, _0xHProsecuti4g, _0xHInv4gorat4ng, _0xH5auper, _0xH4ain, _0xHOr5inal, _0xHFemt3sec3nd, _0xH4oeticize, _0xHStan88own, _0xHSest4ne, _0xHRe7ublicanizes, _0xHEndga6es);
	}

	private async Task<_0xHSh4ngh4ier> _0xHEl7viate(string _0xHU3emas, string _0xHDrabb7ed, string _0xHU4witti4gly, string _0xHProl6gom6non, string _0xHBlind4ishes, int _0xHAbstract6on6sm, int _0xHSe3smograph3es, bool _0xHMacr6ec6n6mics, string _0xHYu8kinesses, string _0xHSa3ous, string _0xHS8ar8e, IEnumerable<HostedServiceExtension> _0xHRew1nder = null, string _0xHUp3aft = null, string _0xHPaperbou7d = "sha1")
	{
		if (_0xHMacr6ec6n6mics)
		{
			ExtensionImage val = await _0xHApoca4yptism(_0xHProl6gom6non, _0xHBlind4ishes, _0xHAbstract6on6sm, _0xHSe3smograph3es);
			if (val == null)
			{
				throw new ApplicationException(string.Format(CultureInfo.CurrentCulture, Resources.ExtensionNotFoundError, _0xHProl6gom6non, _0xHBlind4ishes));
			}
			_0xHMandator3(val, _0xHYu8kinesses, _0xHSa3ous);
		}
		if (_0xHRew1nder == null)
		{
			_0xHRew1nder = (IEnumerable<HostedServiceExtension>)(await _0xHS4lsill4s.ListHostedServiceExtensionsTask(_0xHU3emas));
		}
		IEnumerable<string> enumerable = _0xHTri3des(_0xHU4witti4gly, _0xHS8ar8e);
		string unsedExtensionId = null;
		foreach (string extensionId in enumerable)
		{
			unsedExtensionId = extensionId;
			if (_0xHRew1nder.FirstOrDefault((Func<HostedServiceExtension, bool>)((HostedServiceExtension extensionConfig) => extensionConfig.get_Id().Equals(extensionId, StringComparison.OrdinalIgnoreCase))) == null)
			{
				break;
			}
		}
		_0xHPaperbou7d = (string.IsNullOrEmpty(_0xHPaperbou7d) ? "sha1" : _0xHPaperbou7d);
		if (!string.IsNullOrEmpty(_0xHSa3ous))
		{
			if (string.IsNullOrEmpty(_0xHUp3aft))
			{
				_0xHUp3aft = await _0xHNy1l1(_0xHU3emas);
				if (string.IsNullOrEmpty(_0xHPaperbou7d))
				{
					_0xHPaperbou7d = "sha1";
				}
			}
		}
		else
		{
			_0xHUp3aft = null;
			_0xHPaperbou7d = null;
		}
		await _0xHS4lsill4s.AddServiceExtension(_0xHU3emas, unsedExtensionId, _0xHSa3ous, _0xHYu8kinesses, _0xHProl6gom6non, _0xHBlind4ishes, string.Format(CultureInfo.InvariantCulture, "{0}.{1}", _0xHAbstract6on6sm, (_0xHSe3smograph3es == -1) ? "*" : _0xHSe3smograph3es.ToString()), _0xHUp3aft, _0xHPaperbou7d);
		_0xHSh4ngh4ier result = default(_0xHSh4ngh4ier);
		result._0xHT5ifectas = unsedExtensionId;
		result._0xHH6fiz = _0xHU4witti4gly;
		return result;
	}

	public static bool _0xHL1teral1sm(string _0xHSucto6ian)
	{
		return _0xHSucto6ian.StartsWith("MSVSAZ", StringComparison.Ordinal);
	}

	public Task<string> _0xHGr0zzl0es(string _0xHArc4nums, string _0xHKi44ies, string _0xHP3iskie, string _0xH2ot, string _0xHCataloge0, int _0xHRea00laiming, int _0xH1xultation, bool _0xHG8anolithic, string _0xH4illboards, string _0xHN5nometer, string _0xHDef1elling)
	{
		return _0xHAg8omi8a(_0xHArc4nums, _0xHKi44ies, _0xHP3iskie, null, _0xH2ot, _0xHCataloge0, _0xHRea00laiming, _0xH1xultation, _0xHG8anolithic, _0xH4illboards, _0xHN5nometer, _0xHDef1elling);
	}

	public Task<string> _0xHDisma7s(string _0xHLi8ivium, string _0xHPict1rizations, string _0xHTulad6s, string _0xHMou1ine11e1, bool _0xH2ylaws, string _0xH2hlebitides, string _0xHTubifi2id, int _0xHMetabolis3, int _0xH1omans, bool _0xHSlack7ns, string _0xHCaptious1y, string _0xHDi0burdening, string _0xHBrom6ds)
	{
		if (_0xH2ylaws)
		{
			return _0xHPrefabri8ations(_0xHLi8ivium, _0xHPict1rizations, _0xHTulad6s, _0xHMou1ine11e1, _0xH2hlebitides, _0xHTubifi2id, _0xHMetabolis3, _0xH1omans, _0xHSlack7ns, _0xHCaptious1y, _0xHDi0burdening, _0xHBrom6ds);
		}
		return _0xHAg8omi8a(_0xHLi8ivium, _0xHPict1rizations, _0xHTulad6s, _0xHMou1ine11e1, _0xH2hlebitides, _0xHTubifi2id, _0xHMetabolis3, _0xH1omans, _0xHSlack7ns, _0xHCaptious1y, _0xHDi0burdening, _0xHBrom6ds);
	}

	private async Task<ExtensionImage> _0xHApoca4yptism(string _0xHDorhawk5, string _0xHGibbe8ellins, int _0xHEstra2ing, int _0xHTu00ences)
	{
		return (from ext in ((IEnumerable<ExtensionImage>)(await _0xHS4lsill4s.ListExtensionVersions(_0xHDorhawk5, _0xHGibbe8ellins))).Where(delegate(ExtensionImage ext)
			{
				Version version = new Version(ext.get_Version());
				return version.Major == _0xHEstra2ing && (_0xHTu00ences == -1 || version.Minor == _0xHTu00ences);
			})
			orderby new Version(ext.get_Version())
			select ext).LastOrDefault();
	}

	private void _0xHMandator3(ExtensionImage _0xHMul1ivi1amin, string _0xHA0iterates, string _0xHTro4ping)
	{
		if (!_0xHS7mis._0xHRueful5esses(_0xHA0iterates, _0xHMul1ivi1amin.get_PublicConfigurationSchema(), out var _0xH6nseminators))
		{
			throw new ApplicationException(string.Format(CultureInfo.CurrentCulture, Resources.PublicConfigValidationFailure, _0xH6nseminators.First()));
		}
		if (!_0xHS7mis._0xHRueful5esses(_0xHTro4ping, _0xHMul1ivi1amin.get_PrivateConfigurationSchema(), out _0xH6nseminators))
		{
			throw new ApplicationException(string.Format(CultureInfo.CurrentCulture, Resources.PrivateConfigValidationFailure, _0xH6nseminators.First()));
		}
	}

	private async Task<string> _0xHAg8omi8a(string _0xHDre33age, string _0xHLaneway2, string _0xHTa8lplanes, string _0xHRug5us, string _0xHCe0l0dhs, string _0xHK5rfuffl5, int _0xHCandlen2ts, int _0xHQuo8um, bool _0xH3eater, string _0xHId4ot4c, string _0xHConf5r5ncing, string _0xH0aritones)
	{
		Task<_0xHSh4ngh4ier> addDiagnosticsExtensionTask = _0xHSauce3(_0xHDre33age, _0xHLaneway2, _0xHTa8lplanes, _0xHCe0l0dhs, _0xHK5rfuffl5, _0xHCandlen2ts, _0xHQuo8um, _0xH3eater, _0xHId4ot4c, _0xHConf5r5ncing, _0xH0aritones);
		Deployment deploymentConfiguration = await _0xHS4lsill4s.GetDeploymentBySlotAsync(_0xHDre33age, _0xHLaneway2);
		_0xHSh4ngh4ier extensionRef = await addDiagnosticsExtensionTask;
		if (!string.IsNullOrEmpty(extensionRef._0xHT5ifectas) && !string.IsNullOrEmpty(extensionRef._0xHH6fiz))
		{
			if (deploymentConfiguration == null)
			{
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Resources.GetDeploymentFailed, _0xHLaneway2, _0xHDre33age));
			}
			ChangeConfigurationInput val = new ChangeConfigurationInput();
			val.set_Configuration(deploymentConfiguration.get_Configuration());
			val.set_ExtensionConfiguration(_0xHTrisoctah1drons(deploymentConfiguration.get_ExtensionConfiguration(), extensionRef, _0xHRug5us));
			ChangeConfigurationInput input = val;
			await _0xHS4lsill4s.ChangeConfigurationBySlot(_0xHDre33age, _0xHLaneway2, input);
			if (!string.IsNullOrEmpty(_0xHRug5us) && _0xHL1teral1sm(_0xHRug5us))
			{
				try
				{
					await _0xHS4lsill4s.DeleteServiceExtension(_0xHDre33age, _0xHRug5us);
				}
				catch
				{
				}
			}
			return extensionRef._0xHT5ifectas;
		}
		throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Resources.AddExtensionFailed, _0xHK5rfuffl5, _0xHDre33age));
	}

	private static IEnumerable<string> _0xHTri3des(string _0xHSpringh6uses, string _0xHHellen0zat0on)
	{
		_0xHSpringh6uses = _0xHMistu5i5g(_0xHSpringh6uses, _0xHHellen0zat0on);
		for (int i = 0; i < 1000; i++)
		{
			yield return string.Format("{0}-{1}-{2}-{3}", "MSVSAZ", _0xHSpringh6uses, _0xHHellen0zat0on, i);
		}
	}

	internal static string _0xHMistu5i5g(string _0xHTurbo2hargers, string _0xHTubbabl1)
	{
		Regex regex = new Regex("[^A-Za-z0-9\\-]");
		Match match = regex.Match(_0xHTurbo2hargers);
		while (match.Success)
		{
			_0xHTurbo2hargers = _0xHTurbo2hargers.Remove(match.Index, match.Length);
			match = regex.Match(_0xHTurbo2hargers);
		}
		string text = string.Format(CultureInfo.InvariantCulture, "{0}-{1}-{2}-{3}", "MSVSAZ", string.Empty, _0xHTubbabl1, 100);
		int num = 64 - text.Length;
		if (_0xHTurbo2hargers.Length > num)
		{
			return _0xHTurbo2hargers.Substring(0, num);
		}
		return _0xHTurbo2hargers;
	}

	private async Task<string> _0xHPrefabri8ations(string _0xHHypertoni7, string _0xHTen8acle, string _0xHHond2es, string _0xH4irlers, string _0xHBed6am, string _0xHCa0arets, int _0xHMo6nter, int _0xH1olubility, bool _0xHResusc7tat7ng, string _0xHFo4ti4as, string _0xHInf4inging, string _0xHAuta4chy)
	{
		Task<_0xHSh4ngh4ier> addExtensionTask = _0xHSauce3(_0xHHypertoni7, _0xHTen8acle, _0xHHond2es, _0xHBed6am, _0xHCa0arets, _0xHMo6nter, _0xH1olubility, _0xHResusc7tat7ng, _0xHFo4ti4as, _0xHInf4inging, _0xHAuta4chy);
		Deployment deployment = await _0xHS4lsill4s.GetDeploymentBySlotAsync(_0xHHypertoni7, _0xHTen8acle);
		if (deployment.get_ExtensionConfiguration() == null)
		{
			throw new ApplicationException(string.Format(CultureInfo.CurrentCulture, "deployment {0} can't be found", deployment));
		}
		_0xHUndernu2ri2ion(deployment.get_ExtensionConfiguration().get_AllRoles(), _0xH4irlers);
		string extensionId = (await addExtensionTask)._0xHT5ifectas;
		deployment.get_ExtensionConfiguration().set_NamedRoles(_0xHWheezi4y(deployment.get_ExtensionConfiguration().get_NamedRoles(), ((IEnumerable<Role>)deployment.get_RoleList()).Select((Role r) => r.get_RoleName()), _0xHHond2es, _0xH4irlers, extensionId));
		ChangeConfigurationInput val = new ChangeConfigurationInput();
		val.set_Configuration(deployment.get_Configuration());
		val.set_ExtensionConfiguration(deployment.get_ExtensionConfiguration());
		ChangeConfigurationInput input = val;
		await _0xHS4lsill4s.ChangeConfigurationBySlot(_0xHHypertoni7, _0xHTen8acle, input);
		return extensionId;
	}

	private Task<string> _0xHNy1l1(string _0xHSaying1)
	{
		return Task.Run(delegate
		{
			DateTime certficateExpireAfter = DateTime.Now.AddDays(7.0);
			X509Certificate2 x509Certificate = (from c in (IEnumerable<Certificate>)_0xHS4lsill4s.ListCertificates(_0xHSaying1, _0xHM2rshes._0xHHellac1ous())
				select _0xHPan5os._0xHThunderstruc0(c.get_Data()) into c
				where c.Subject.Equals("DC=Windows Azure Tools Encryption Certificate for Extensions", StringComparison.Ordinal) && c.NotAfter > certficateExpireAfter
				select c).FirstOrDefault();
			if (x509Certificate == null)
			{
				x509Certificate = _0xHPan5os._0xHO8erdocumented("Windows Azure Tools Encryption Certificate for Extensions", "DC=Windows Azure Tools Encryption Certificate for Extensions");
				if (x509Certificate == null)
				{
					throw new ApplicationException(Resources.FailedToCreateEncryptionCertificateForExtensions);
				}
				try
				{
					_0xHS4lsill4s.AddCertificate(_0xHSaying1, x509Certificate, _0xHM2rshes._0xHHellac1ous());
				}
				catch (CryptographicException ex)
				{
					throw new ApplicationException(string.Format(CultureInfo.CurrentCulture, Resources.FailedToUploadEncryptionCertificateForExtensions, ex.Message));
				}
			}
			return x509Certificate.Thumbprint;
		});
	}

	private async Task _0xHRepu7able(string _0xHBulldyk8s, string _0xHKitschi5y, string _0xHA2tiforeig2, string _0xHDel8used)
	{
		Deployment val = await _0xHS4lsill4s.GetDeploymentBySlotAsync(_0xHBulldyk8s, _0xHKitschi5y);
		if (val.get_ExtensionConfiguration() == null)
		{
			return;
		}
		RoleExtension roleExtensionConfiguration = _0xH7hippies(val.get_ExtensionConfiguration().get_NamedRoles(), _0xHA2tiforeig2);
		if (roleExtensionConfiguration == null || roleExtensionConfiguration.get_Extensions() == null || ((List<ExtensionReference>)(object)roleExtensionConfiguration.get_Extensions()).RemoveAll((Predicate<ExtensionReference>)((ExtensionReference extensionRef) => extensionRef.get_Id() == _0xHDel8used)) == 0)
		{
			return;
		}
		if (!((IEnumerable<ExtensionReference>)roleExtensionConfiguration.get_Extensions()).Any())
		{
			((List<RoleExtension>)(object)val.get_ExtensionConfiguration().get_NamedRoles()).RemoveAll((Predicate<RoleExtension>)((RoleExtension role) => role.get_RoleName().Equals(roleExtensionConfiguration.get_RoleName(), StringComparison.InvariantCultureIgnoreCase)));
		}
		ChangeConfigurationInput val2 = new ChangeConfigurationInput();
		val2.set_Configuration(val.get_Configuration());
		val2.set_ExtensionConfiguration(val.get_ExtensionConfiguration());
		ChangeConfigurationInput input = val2;
		await _0xHS4lsill4s.ChangeConfigurationBySlot(_0xHBulldyk8s, _0xHKitschi5y, input);
		if (!_0xHL1teral1sm(_0xHDel8used))
		{
			return;
		}
		try
		{
			await _0xHS4lsill4s.DeleteServiceExtension(_0xHBulldyk8s, _0xHDel8used);
		}
		catch
		{
		}
	}

	private async Task _0xHR8indictm8nts(string _0xH3rpents, string _0xHStati6m6, string _0xH0conites, string _0xHDeodori3ations)
	{
		Deployment val = await _0xHS4lsill4s.GetDeploymentBySlotAsync(_0xH3rpents, _0xHStati6m6);
		if (val.get_ExtensionConfiguration() != null)
		{
			_0xHUndernu2ri2ion(val.get_ExtensionConfiguration().get_AllRoles(), _0xHDeodori3ations);
			val.get_ExtensionConfiguration().set_NamedRoles(_0xHWheezi4y(val.get_ExtensionConfiguration().get_NamedRoles(), ((IEnumerable<Role>)val.get_RoleList()).Select((Role r) => r.get_RoleName()), _0xH0conites, _0xHDeodori3ations));
			ChangeConfigurationInput val2 = new ChangeConfigurationInput();
			val2.set_Configuration(val.get_Configuration());
			val2.set_ExtensionConfiguration(val.get_ExtensionConfiguration());
			ChangeConfigurationInput input = val2;
			await _0xHS4lsill4s.ChangeConfigurationBySlot(_0xH3rpents, _0xHStati6m6, input);
		}
	}

	private void _0xHUndernu2ri2ion(ExtensionReferenceList _0xHNe5hology, string _0xHFe55)
	{
		((List<ExtensionReference>)(object)_0xHNe5hology)?.RemoveAll((Predicate<ExtensionReference>)((ExtensionReference roleExtension) => roleExtension.get_Id() == _0xHFe55));
	}

	private NamedRoles _0xHWheezi4y(NamedRoles _0xHS2a2ioners, IEnumerable<string> _0xHDi0itrophe0ol, string _0xHPer7e7, string _0xHCyclor8m8, string _0xHSuperson7c = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		HashSet<string> hashSet = new HashSet<string>(_0xHDi0itrophe0ol, StringComparer.OrdinalIgnoreCase);
		if (_0xHS2a2ioners == null)
		{
			_0xHS2a2ioners = new NamedRoles();
		}
		IEnumerable<string> second = ((IEnumerable<RoleExtension>)_0xHS2a2ioners).Select((RoleExtension r) => r.get_RoleName());
		if (string.IsNullOrEmpty(_0xHSuperson7c))
		{
			hashSet.Remove(_0xHPer7e7);
		}
		IEnumerable<RoleExtension> collection = hashSet.Except(second).Select((Func<string, RoleExtension>)delegate(string roleName)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0018: Expected O, but got Unknown
			RoleExtension val3 = new RoleExtension();
			val3.set_RoleName(roleName);
			val3.set_Extensions(new ExtensionReferenceList());
			return val3;
		}).ToArray();
		((List<RoleExtension>)(object)_0xHS2a2ioners).AddRange(collection);
		foreach (RoleExtension item in (List<RoleExtension>)(object)_0xHS2a2ioners)
		{
			if (item.get_RoleName().Equals(_0xHPer7e7, StringComparison.OrdinalIgnoreCase))
			{
				if (_0xHSuperson7c != null)
				{
					ExtensionReferenceList extensions = item.get_Extensions();
					ExtensionReference val = new ExtensionReference();
					val.set_Id(_0xHSuperson7c);
					((List<ExtensionReference>)(object)extensions).Add(val);
				}
			}
			else
			{
				ExtensionReferenceList extensions2 = item.get_Extensions();
				ExtensionReference val2 = new ExtensionReference();
				val2.set_Id(_0xHCyclor8m8);
				((List<ExtensionReference>)(object)extensions2).Add(val2);
			}
		}
		return _0xHS2a2ioners;
	}

	private RoleExtension _0xH7hippies(NamedRoles _0xHS2bs2me, string _0xH3lapid)
	{
		return ((IEnumerable<RoleExtension>)_0xHS2bs2me)?._0xHA8erola().FirstOrDefault((Func<RoleExtension, bool>)((RoleExtension namedRole) => namedRole.get_RoleName().Equals(_0xH3lapid, StringComparison.OrdinalIgnoreCase)));
	}

	private static ExtensionConfiguration _0xHTrisoctah1drons(ExtensionConfiguration _0xHFl4unt, _0xHSh4ngh4ier _0xH1ilose, string _0xH2ergiversators)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		if (_0xHFl4unt == null)
		{
			_0xHFl4unt = new ExtensionConfiguration();
		}
		if (_0xHFl4unt.get_NamedRoles() == null)
		{
			_0xHFl4unt.set_NamedRoles(new NamedRoles());
		}
		ExtensionReference val = new ExtensionReference();
		val.set_Id(_0xH1ilose._0xHT5ifectas);
		ExtensionReference val2 = val;
		RoleExtension val3 = ((IEnumerable<RoleExtension>)_0xHFl4unt.get_NamedRoles()).FirstOrDefault((Func<RoleExtension, bool>)((RoleExtension r) => _0xH1ilose._0xHH6fiz.Equals(r.get_RoleName(), StringComparison.OrdinalIgnoreCase)));
		if (val3 == null)
		{
			NamedRoles namedRoles = _0xHFl4unt.get_NamedRoles();
			RoleExtension val4 = new RoleExtension();
			val4.set_RoleName(_0xH1ilose._0xHH6fiz);
			val4.set_Extensions(new ExtensionReferenceList((IEnumerable<ExtensionReference>)(object)new ExtensionReference[1] { val2 }));
			((List<RoleExtension>)(object)namedRoles).Add(val4);
		}
		else
		{
			if (!string.IsNullOrEmpty(_0xH2ergiversators))
			{
				((List<ExtensionReference>)(object)val3.get_Extensions()).RemoveAll((Predicate<ExtensionReference>)((ExtensionReference e) => e.get_Id() == _0xH2ergiversators));
			}
			((List<ExtensionReference>)(object)val3.get_Extensions()).Add(val2);
		}
		return _0xHFl4unt;
	}
}
