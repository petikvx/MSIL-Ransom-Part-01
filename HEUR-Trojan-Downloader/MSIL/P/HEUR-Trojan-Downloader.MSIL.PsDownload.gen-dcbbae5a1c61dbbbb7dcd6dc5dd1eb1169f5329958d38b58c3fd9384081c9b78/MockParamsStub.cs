using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class MockParamsStub
{
	private static ResourceManager m_Interceptor;

	private static CultureInfo _Model;

	private static MockParamsStub OrderItem;

	internal MockParamsStub()
	{
		if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_84ee2e5a475341d78a53f13f3f565463 == 0)
		{
			switch (0)
			{
			}
		}
	}

	internal static ResourceManager CallFacade()
	{
		ResourceManager interceptor = default(ResourceManager);
		while (true)
		{
			bool flag = m_Interceptor == null;
			while (true)
			{
				int num;
				if (flag)
				{
					num = 4;
					if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_8f2a606f8bea4c7aa0d1133ce995fbaa == 0)
					{
						goto IL_002d;
					}
					goto IL_0040;
				}
				goto IL_007a;
				IL_007a:
				return m_Interceptor;
				IL_0040:
				switch (num)
				{
				case 4:
					interceptor = new ResourceManager("WindowsFormsApp12.Properties.Resources", typeof(MockParamsStub).Assembly);
					break;
				case 2:
					break;
				case 5:
				case 6:
					continue;
				case 7:
					goto end_IL_0067;
				default:
					goto IL_007a;
				}
				goto IL_002d;
				IL_002d:
				m_Interceptor = interceptor;
				num = 0;
				if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_b7c5cdade6ec4bd5997e2e75e0b0b073 == 0)
				{
					goto IL_0040;
				}
				goto IL_007a;
				continue;
				end_IL_0067:
				break;
			}
		}
	}

	internal static CultureInfo IncludeFacade()
	{
		CultureInfo model = _Model;
		if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_685efbeca26b40ca8ff28c5cd33cf6ac != 0)
		{
			switch (0)
			{
			}
		}
		return model;
	}

	internal static void AssetFacade(CultureInfo def)
	{
		_Model = def;
	}

	internal static bool DefineItem()
	{
		return OrderItem == null;
	}

	internal static MockParamsStub CompareItem()
	{
		return OrderItem;
	}
}
