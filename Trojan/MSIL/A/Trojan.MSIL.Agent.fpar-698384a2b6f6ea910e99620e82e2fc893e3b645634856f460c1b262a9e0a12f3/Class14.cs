using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using NanoCore.ClientPlugin;
using NanoCore.ClientPluginHost;

[StandardModule]
internal sealed class Class14
{
	public static void smethod_0(byte[] byte_0, GClass2 gclass2_0)
	{
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		try
		{
			GClass3 gClass = (gclass2_0.gclass3_0 = new GClass3(gclass2_0.guid_0, gclass2_0.string_0));
			Type type = Class18.smethod_0(byte_0, Class6.type_0, Class6.type_1);
			if ((object)type == null)
			{
				throw new Exception("Client assembly does not meet plugin type requirements.");
			}
			List<object> list = new List<object>();
			ConstructorInfo constructorInfo = type.GetConstructors()[0];
			ParameterInfo[] parameters = constructorInfo.GetParameters();
			foreach (ParameterInfo parameterInfo in parameters)
			{
				if (typeof(IClientDataHost).Equals(parameterInfo.ParameterType))
				{
					list.Add(new GClass1(gClass));
				}
				else if (typeof(IClientNetworkHost).Equals(parameterInfo.ParameterType))
				{
					list.Add(new GClass4(gClass));
				}
				else if (typeof(IClientUIHost).Equals(parameterInfo.ParameterType))
				{
					list.Add(new GClass9(gClass));
				}
				else if (typeof(IClientLoggingHost).Equals(parameterInfo.ParameterType))
				{
					list.Add(new GClass7(gClass));
				}
				else if (typeof(IClientAppHost).Equals(parameterInfo.ParameterType))
				{
					list.Add(new GClass10(gClass));
				}
				else
				{
					list.Add(null);
				}
			}
			object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type, list.ToArray()));
			Type[] interfaces = type.GetInterfaces();
			foreach (Type o in interfaces)
			{
				if (typeof(IClientData).Equals(o))
				{
					gClass.iclientData_0 = (IClientData)objectValue;
				}
				else if (typeof(IClientNetwork).Equals(o))
				{
					gClass.iclientNetwork_0 = (IClientNetwork)objectValue;
				}
				else if (typeof(IClientApp).Equals(o))
				{
					gClass.iclientApp_0 = (IClientApp)objectValue;
				}
			}
			Class8.smethod_87($"Plugin: {gclass2_0.string_0}, Cache: {gclass2_0.bool_0}");
			if (!Class8.list_2.Contains(gclass2_0))
			{
				Class8.list_2.Add(gclass2_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			Class8.smethod_85(gclass2_0.gclass3_0, exception_, "InitializePlugin");
			ProjectData.ClearProjectError();
		}
	}

	public static GClass2 smethod_1(Guid guid_0)
	{
		int num = Class8.list_2.Count - 1;
		int num2 = 0;
		while (true)
		{
			if (num2 <= num)
			{
				if (Class8.list_2[num2].guid_0 == guid_0)
				{
					break;
				}
				num2++;
				continue;
			}
			return null;
		}
		return Class8.list_2[num2];
	}
}
