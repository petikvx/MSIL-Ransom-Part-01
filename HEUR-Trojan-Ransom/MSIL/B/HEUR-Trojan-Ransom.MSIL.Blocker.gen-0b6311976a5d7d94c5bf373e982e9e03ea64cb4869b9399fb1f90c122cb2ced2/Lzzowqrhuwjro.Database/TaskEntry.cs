using System;
using System.Reflection;
using AMD.Containers;

namespace Lzzowqrhuwjro.Database;

internal class TaskEntry
{
	internal delegate void ObserverAttributeStub(object o);

	internal static Module m_Container;

	internal static TaskEntry ValidateExporter;

	internal static void ConcatCollection(int typemdt)
	{
		int num = 1;
		int num3 = default(int);
		FieldInfo[] fields = default(FieldInfo[]);
		FieldInfo fieldInfo = default(FieldInfo);
		while (true)
		{
			Type type = m_Container.ResolveType(33554432 + typemdt);
			int num2 = 0;
			if (TestExporter())
			{
				goto IL_0089;
			}
			goto IL_0094;
			IL_0094:
			switch (num2)
			{
			case 6:
				break;
			case 3:
				goto IL_0035;
			case 5:
				goto IL_007c;
			case 4:
				num3++;
				break;
			default:
				goto IL_0089;
			case 1:
				continue;
			case 2:
				return;
			}
			goto IL_000e;
			IL_0089:
			fields = type.GetFields();
			goto IL_007c;
			IL_007c:
			num3 = 0;
			goto IL_000e;
			IL_000e:
			if (num3 >= fields.Length)
			{
				num2 = 2;
				if (!TestExporter())
				{
					goto IL_0076;
				}
				goto IL_0094;
			}
			fieldInfo = fields[num3];
			num = 3;
			goto IL_0035;
			IL_0035:
			MethodInfo method = (MethodInfo)m_Container.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			num2 = 4;
			if (!TestExporter())
			{
				goto IL_0076;
			}
			goto IL_0094;
			IL_0076:
			num2 = num;
			goto IL_0094;
		}
	}

	public TaskEntry()
	{
		NewExporter();
		base._002Ector();
	}

	static TaskEntry()
	{
		CreatorStrategyContainer.PopCollection();
		m_Container = PrepareExporter(typeof(TaskEntry).TypeHandle).Assembly.ManifestModule;
	}

	internal static bool TestExporter()
	{
		return ValidateExporter == null;
	}

	internal static TaskEntry SortExporter()
	{
		return ValidateExporter;
	}

	internal static void NewExporter()
	{
		CreatorStrategyContainer.PopCollection();
	}

	internal static Type PrepareExporter(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
