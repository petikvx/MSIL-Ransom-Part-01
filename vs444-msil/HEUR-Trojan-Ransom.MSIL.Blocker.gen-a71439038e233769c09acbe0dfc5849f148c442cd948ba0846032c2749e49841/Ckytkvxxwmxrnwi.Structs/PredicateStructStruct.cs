using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Ckytkvxxwmxrnwi.Structs;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class PredicateStructStruct
{
	private static ResourceManager m_Predicate;

	private static CultureInfo _Filter;

	private static PredicateStructStruct InsertParams;

	internal PredicateStructStruct()
	{
		int num = 0;
		if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_8c71188096404ef98c4d68ed23286c67 == 0)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	internal static ResourceManager UpdateDispatcher()
	{
		int num = 5;
		ResourceManager predicate = default(ResourceManager);
		ResourceManager predicate2 = default(ResourceManager);
		while (true)
		{
			bool flag = m_Predicate == null;
			while (true)
			{
				if (flag)
				{
					goto IL_000b;
				}
				goto IL_005d;
				IL_005d:
				predicate = m_Predicate;
				int num2 = 6;
				if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_7ab9bbc6588b4754b6dbc46353a9f994 == 0)
				{
					num2 = num;
				}
				goto IL_0032;
				IL_0056:
				m_Predicate = predicate2;
				goto IL_005d;
				IL_0032:
				switch (num2)
				{
				case 3:
					break;
				default:
					goto IL_0056;
				case 2:
					goto IL_005d;
				case 4:
					continue;
				case 5:
					goto end_IL_0077;
				case 6:
					return predicate;
				}
				goto IL_000b;
				IL_000b:
				predicate2 = new ResourceManager("Ckytkvxxwmxrnwi.Properties.Resources", CancelParams(typeof(PredicateStructStruct).TypeHandle).Assembly);
				num2 = 0;
				if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_e79ddfe5b5764a13a8274f32f4f07353 == 0)
				{
					goto IL_0032;
				}
				goto IL_0056;
				continue;
				end_IL_0077:
				break;
			}
		}
	}

	internal static CultureInfo GetDispatcher()
	{
		CultureInfo filter = _Filter;
		if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_8c71188096404ef98c4d68ed23286c67 != 0)
		{
			switch (0)
			{
			}
		}
		return filter;
	}

	internal static void MapDispatcher(CultureInfo res)
	{
		_Filter = res;
		if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_ee158e831e9d413585d29726429d3761 != 0)
		{
			switch (1)
			{
			}
		}
	}

	internal static bool LoginParams()
	{
		return InsertParams == null;
	}

	internal static PredicateStructStruct StopParams()
	{
		return InsertParams;
	}

	internal static Type CancelParams(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
