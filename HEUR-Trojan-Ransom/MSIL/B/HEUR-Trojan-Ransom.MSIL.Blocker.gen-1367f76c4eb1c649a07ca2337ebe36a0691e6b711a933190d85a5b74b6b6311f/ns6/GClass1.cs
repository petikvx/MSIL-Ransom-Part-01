using System;
using System.IO.IsolatedStorage;
using System.Text;

namespace ns6;

public abstract class GClass1 : MarshalByRefObject
{
	private IsolatedStorageScope m_Scope;

	public char SeparatorInternal { get; set; }

	internal static bool smethod_0(IsolatedStorageScope scope)
	{
		return (scope & IsolatedStorageScope.Roaming) != 0;
	}

	internal bool method_0()
	{
		return (m_Scope & IsolatedStorageScope.Roaming) != 0;
	}

	internal static bool smethod_1(IsolatedStorageScope scope)
	{
		return (scope & IsolatedStorageScope.Domain) != 0;
	}

	internal bool method_1()
	{
		return (m_Scope & IsolatedStorageScope.Domain) != 0;
	}

	internal static bool smethod_2(IsolatedStorageScope scope)
	{
		return (scope & IsolatedStorageScope.Machine) != 0;
	}

	internal bool method_2()
	{
		return (m_Scope & IsolatedStorageScope.Assembly) != 0;
	}

	internal static bool smethod_3(IsolatedStorageScope scope)
	{
		return (scope & IsolatedStorageScope.Application) != 0;
	}

	internal bool method_3()
	{
		return (m_Scope & IsolatedStorageScope.Application) != 0;
	}

	private string method_4(string typeID, string instanceID)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(typeID);
		stringBuilder.Append(SeparatorInternal);
		stringBuilder.Append(instanceID);
		return stringBuilder.ToString();
	}
}
