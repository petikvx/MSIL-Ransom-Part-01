using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using ns13;
using ns3;
using ns4;
using ns5;
using ns8;

namespace ns14;

internal class Class132 : SerializationBinder, Interface6
{
	internal static readonly Class132 class132_0 = new Class132();

	internal readonly Class110<Struct5<string?, string>, Type> class110_0;

	public Class132()
	{
		class110_0 = new Class110<Struct5<string, string>, Type>(method_0);
	}

	private Type method_0(Struct5<string?, string> struct5_0)
	{
		string gparam_ = struct5_0.gparam_0;
		string gparam_2 = struct5_0.gparam_1;
		if (gparam_ != null)
		{
			Assembly assembly = Assembly.LoadWithPartialName(gparam_);
			if (assembly == null)
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				foreach (Assembly assembly2 in assemblies)
				{
					if (assembly2.FullName == gparam_ || assembly2.GetName().Name == gparam_)
					{
						assembly = assembly2;
						break;
					}
				}
			}
			if (assembly == null)
			{
				throw new JsonSerializationException("Could not load assembly '{0}'.".smethod_1(CultureInfo.InvariantCulture, gparam_));
			}
			Type type = assembly.GetType(gparam_2);
			if (type == null)
			{
				if (gparam_2.IndexOf('`') >= 0)
				{
					try
					{
						type = Class131.smethod_23(assembly, gparam_2, this);
					}
					catch (Exception innerException)
					{
						throw new JsonSerializationException("Could not find type '{0}' in assembly '{1}'.".smethod_2(CultureInfo.InvariantCulture, gparam_2, assembly.FullName), innerException);
					}
				}
				if (type == null)
				{
					throw new JsonSerializationException("Could not find type '{0}' in assembly '{1}'.".smethod_2(CultureInfo.InvariantCulture, gparam_2, assembly.FullName));
				}
			}
			return type;
		}
		return Type.GetType(gparam_2);
	}

	public override Type BindToType(string? assemblyName, string typeName)
	{
		return Class131.smethod_670(this, new Struct5<string, string>(assemblyName, typeName));
	}

	public override void BindToName(Type serializedType, out string? assemblyName, out string? typeName)
	{
		assemblyName = serializedType.Assembly.FullName;
		typeName = serializedType.FullName;
	}
}
