using System;
using System.Collections;
using System.Reflection;
using System.Runtime.Remoting;

namespace OlLP4ANbrNNh;

internal class Class9
{
	internal class ChannelEntry
	{
		internal ArrayList ClientSinkProviders = new ArrayList();

		internal ArrayList ServerSinkProviders = new ArrayList();

		internal string TypeName;

		internal string AssemblyName;

		internal Hashtable Properties;

		internal bool DelayLoad;

		internal ChannelEntry(string typeName, string assemblyName, Hashtable properties)
		{
			TypeName = typeName;
			AssemblyName = assemblyName;
			Properties = properties;
		}
	}

	internal class ClientWellKnownEntry
	{
		internal string TypeName;

		internal string AssemblyName;

		internal string Url;

		internal ClientWellKnownEntry(string typeName, string assemName, string url)
		{
			TypeName = typeName;
			AssemblyName = assemName;
			Url = url;
		}
	}

	internal class ContextAttributeEntry
	{
		internal string TypeName;

		internal string AssemblyName;

		internal Hashtable Properties;

		internal ContextAttributeEntry(string typeName, string assemName, Hashtable properties)
		{
			TypeName = typeName;
			AssemblyName = assemName;
			Properties = properties;
		}
	}

	internal class InteropXmlElementEntry
	{
		internal string XmlElementName;

		internal string XmlElementNamespace;

		internal string UrtTypeName;

		internal string UrtAssemblyName;

		internal InteropXmlElementEntry(string xmlElementName, string xmlElementNamespace, string urtTypeName, string urtAssemblyName)
		{
			XmlElementName = xmlElementName;
			XmlElementNamespace = xmlElementNamespace;
			UrtTypeName = urtTypeName;
			UrtAssemblyName = urtAssemblyName;
		}
	}

	internal class CustomErrorsEntry
	{
		internal CustomErrorsModes Mode;

		internal CustomErrorsEntry(CustomErrorsModes mode)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			Mode = mode;
		}
	}

	internal class InteropXmlTypeEntry
	{
		internal string XmlTypeName;

		internal string XmlTypeNamespace;

		internal string UrtTypeName;

		internal string UrtAssemblyName;

		internal InteropXmlTypeEntry(string xmlTypeName, string xmlTypeNamespace, string urtTypeName, string urtAssemblyName)
		{
			XmlTypeName = xmlTypeName;
			XmlTypeNamespace = xmlTypeNamespace;
			UrtTypeName = urtTypeName;
			UrtAssemblyName = urtAssemblyName;
		}
	}

	internal class LifetimeEntry
	{
		internal bool IsLeaseTimeSet;

		internal bool IsRenewOnCallTimeSet;

		internal bool IsSponsorshipTimeoutSet;

		internal bool IsLeaseManagerPollTimeSet;

		private TimeSpan _leaseTime;

		private TimeSpan _renewOnCallTime;

		private TimeSpan _sponsorshipTimeout;

		private TimeSpan _leaseManagerPollTime;

		internal TimeSpan LeaseTime
		{
			get
			{
				return _leaseTime;
			}
			set
			{
				_leaseTime = value;
				IsLeaseTimeSet = true;
			}
		}

		internal TimeSpan RenewOnCallTime
		{
			get
			{
				return _renewOnCallTime;
			}
			set
			{
				_renewOnCallTime = value;
				IsRenewOnCallTimeSet = true;
			}
		}

		internal TimeSpan SponsorshipTimeout
		{
			get
			{
				return _sponsorshipTimeout;
			}
			set
			{
				_sponsorshipTimeout = value;
				IsSponsorshipTimeoutSet = true;
			}
		}

		internal TimeSpan LeaseManagerPollTime
		{
			get
			{
				return _leaseManagerPollTime;
			}
			set
			{
				_leaseManagerPollTime = value;
				IsLeaseManagerPollTimeSet = true;
			}
		}
	}

	internal class PreLoadEntry
	{
		internal string TypeName;

		internal string AssemblyName;

		public PreLoadEntry(string typeName, string assemblyName)
		{
			TypeName = typeName;
			AssemblyName = assemblyName;
		}
	}

	internal class RemoteAppEntry
	{
		internal ArrayList WellKnownObjects = new ArrayList();

		internal ArrayList ActivatedObjects = new ArrayList();

		internal string AppUri;

		internal RemoteAppEntry(string appUri)
		{
			AppUri = appUri;
		}

		internal void AddWellKnownEntry(string typeName, string assemName, string url)
		{
			WellKnownObjects.Add(new ClientWellKnownEntry(typeName, assemName, url));
		}

		internal void AddActivatedEntry(string typeName, string assemName, ArrayList contextAttributes)
		{
			ActivatedObjects.Add(new TypeEntry(typeName, assemName, contextAttributes));
		}
	}

	internal class ServerWellKnownEntry : TypeEntry
	{
		internal string ObjectUri;

		internal WellKnownObjectMode ObjectMode;

		internal ServerWellKnownEntry(string typeName, string assemName, ArrayList contextAttributes, string objUri, WellKnownObjectMode objMode)
			: base(typeName, assemName, contextAttributes)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			ObjectUri = objUri;
			ObjectMode = objMode;
		}
	}

	internal class SinkProviderEntry
	{
		internal ArrayList ProviderData = new ArrayList();

		internal string TypeName;

		internal string AssemblyName;

		internal Hashtable Properties;

		internal bool IsFormatter;

		internal SinkProviderEntry(string typeName, string assemName, Hashtable properties, bool isFormatter)
		{
			TypeName = typeName;
			AssemblyName = assemName;
			Properties = properties;
			IsFormatter = isFormatter;
		}
	}

	internal class TypeEntry
	{
		internal string TypeName;

		internal string AssemblyName;

		internal ArrayList ContextAttributes;

		internal TypeEntry(string typeName, string assemName, ArrayList contextAttributes)
		{
			TypeName = typeName;
			AssemblyName = assemName;
			ContextAttributes = contextAttributes;
		}
	}

	internal bool bool_0;

	internal ArrayList arrayList_0 = new ArrayList();

	internal ArrayList arrayList_1 = new ArrayList();

	internal ArrayList arrayList_2 = new ArrayList();

	internal ArrayList arrayList_3 = new ArrayList();

	internal ArrayList arrayList_4 = new ArrayList();

	internal ArrayList arrayList_5 = new ArrayList();

	internal ArrayList arrayList_6 = new ArrayList();

	internal static volatile bool bool_1;

	internal string string_0;

	internal LifetimeEntry lifetimeEntry_0;

	internal CustomErrorsEntry customErrorsEntry_0;

	internal static string smethod_0()
	{
		return Class7.smethod_1() + "ma";
	}

	internal void method_0(string string_1, string string_2, string string_3, string string_4)
	{
		arrayList_1.Add(new InteropXmlElementEntry(string_1, string_2, string_3, string_4));
	}

	internal void method_1(string string_1, string string_2, string string_3, string string_4)
	{
		arrayList_2.Add(new InteropXmlTypeEntry(string_1, string_2, string_3, string_4));
	}

	internal void method_2(string string_1, string string_2)
	{
		arrayList_3.Add(new PreLoadEntry(string_1, string_2));
	}

	internal RemoteAppEntry method_3(string string_1)
	{
		RemoteAppEntry remoteAppEntry = new RemoteAppEntry(string_1);
		arrayList_4.Add(remoteAppEntry);
		return remoteAppEntry;
	}

	internal void method_4(string string_1, string string_2, ArrayList arrayList_7)
	{
		arrayList_5.Add(new TypeEntry(string_1, string_2, arrayList_7));
	}

	internal static bool smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0, out Assembly assembly_0)
	{
		AppDomain appDomain_ = (AppDomain)object_0;
		if (Class7.smethod_0(resolveEventArgs_0, out assembly_0, appDomain_))
		{
			return true;
		}
		assembly_0 = null;
		return false;
	}

	internal ServerWellKnownEntry method_5(string string_1, string string_2, ArrayList arrayList_7, string string_3, WellKnownObjectMode wellKnownObjectMode_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		ServerWellKnownEntry serverWellKnownEntry = new ServerWellKnownEntry(string_1, string_2, arrayList_7, string_3, wellKnownObjectMode_0);
		arrayList_6.Add(serverWellKnownEntry);
		return serverWellKnownEntry;
	}
}
