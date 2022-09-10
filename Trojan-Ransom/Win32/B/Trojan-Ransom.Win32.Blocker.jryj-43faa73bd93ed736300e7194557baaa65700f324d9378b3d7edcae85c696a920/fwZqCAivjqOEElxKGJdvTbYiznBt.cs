using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal class fwZqCAivjqOEElxKGJdvTbYiznBt
{
	private static ResourceManager HLXqbltONbrNuiAGhgqGNIOkaDfB;

	private static CultureInfo jDODPRfGwDYyZjezrvGzokPIAysDb;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager GopEjHAdDJYnGiKFQgXRAvukJoNSA
	{
		get
		{
			if (fwZqCAivjqOEElxKGJdvTbYiznBt.OpxGtaJOUPOawfQCjKozcUzajVVPA((object)HLXqbltONbrNuiAGhgqGNIOkaDfB, (object)null))
			{
				ResourceManager hLXqbltONbrNuiAGhgqGNIOkaDfB = default(ResourceManager);
				while (true)
				{
					int num = 1385490032;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((~(-num2 - -1493096709) ^ 0x4EC72BD9) + 1779202322)) % 4u)
						{
						case 2u:
							HLXqbltONbrNuiAGhgqGNIOkaDfB = hLXqbltONbrNuiAGhgqGNIOkaDfB;
							num = ((int)num3 * -476776162) ^ -1584842134;
							continue;
						case 1u:
							hLXqbltONbrNuiAGhgqGNIOkaDfB = fwZqCAivjqOEElxKGJdvTbYiznBt.DdSUvjzTMmdwRnMydbgwWNlRRMD(_003CModule_003E.vCgetZRAfwOfXDFjqBKEQPxCexnFA<string>(3933522218u), fwZqCAivjqOEElxKGJdvTbYiznBt.UlEpSziOdDLiIqCWeviBZbGFDvPGA(fwZqCAivjqOEElxKGJdvTbYiznBt.NZNnfXCsvmfXQSUdgRPAsVUJNizl(typeof(fwZqCAivjqOEElxKGJdvTbYiznBt).TypeHandle)));
							num = ((int)num3 * -1256825469) ^ -47979668;
							continue;
						case 0u:
							break;
						default:
							goto end_IL_0081;
						}
						break;
					}
					continue;
					end_IL_0081:
					break;
				}
			}
			return HLXqbltONbrNuiAGhgqGNIOkaDfB;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo zfAiUwGdazKjPeoIKUEaLMLLBwfxB
	{
		get
		{
			return jDODPRfGwDYyZjezrvGzokPIAysDb;
		}
		set
		{
			jDODPRfGwDYyZjezrvGzokPIAysDb = value;
		}
	}

	internal fwZqCAivjqOEElxKGJdvTbYiznBt()
	{
	}

	static bool OpxGtaJOUPOawfQCjKozcUzajVVPA(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	static Type NZNnfXCsvmfXQSUdgRPAsVUJNizl(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static Assembly UlEpSziOdDLiIqCWeviBZbGFDvPGA(Type type_0)
	{
		return type_0.Assembly;
	}

	static ResourceManager DdSUvjzTMmdwRnMydbgwWNlRRMD(string string_0, Assembly assembly_0)
	{
		return new ResourceManager(string_0, assembly_0);
	}
}
