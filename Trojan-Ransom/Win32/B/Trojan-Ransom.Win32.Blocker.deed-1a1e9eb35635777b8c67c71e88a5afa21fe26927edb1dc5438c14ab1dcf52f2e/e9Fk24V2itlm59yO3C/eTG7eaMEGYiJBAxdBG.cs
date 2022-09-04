using System;
using System.Reflection;
using System.Security.Cryptography;
using e1t9ZoIMs7pU1MfVBaV;
using elRV9N3vPjJN4FNmtXC;

namespace e9Fk24V2itlm59yO3C;

internal sealed class eTG7eaMEGYiJBAxdBG : IDisposable
{
	private readonly Type exwyp4bAY;

	private readonly object e9IgDZCnQ;

	public eTG7eaMEGYiJBAxdBG()
	{
		eCMTNhLCKkc0ewUWKXH(this);
		Assembly assembly = default(Assembly);
		try
		{
			assembly = (Assembly)eqJe7nLZEReWDgBKBjG(eDuaTU3TDhsqeVkuTG8.eulODlten(1328));
			eAqLGuLj9rtOuDw33f8();
			if (!eta058L59XafDGCEPoS())
			{
				if (eAqLGuLj9rtOuDw33f8())
				{
				}
				exwyp4bAY = eEyCvXLg2VXGT9vf2Hr(assembly, eDuaTU3TDhsqeVkuTG8.eulODlten(1348));
			}
			e9IgDZCnQ = e6EphDL2StmKtAAc1jT(exwyp4bAY);
		}
		catch (Exception object_)
		{
			esBqy8LikFLtPgQnmVX(object_, assembly, this);
			throw;
		}
	}

	public ICryptoTransform e4ZIbpnTa(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		object[] object_3 = default(object[]);
		MethodInfo method = default(MethodInfo);
		try
		{
			object object_ = eh4wD1LEPVgWHFLqTAw(exwyp4bAY.GetProperty(eDuaTU3TDhsqeVkuTG8.eulODlten(1458)));
			object object_2 = e9IgDZCnQ;
			object_3 = new object[1] { byte_0 };
			emWYy1LY0KMSBfVI0FF(object_, object_2, object_3);
			_ = 1;
			if (!eta058L59XafDGCEPoS())
			{
				object object_4 = eh4wD1LEPVgWHFLqTAw(exwyp4bAY.GetProperty(eDuaTU3TDhsqeVkuTG8.eulODlten(1468)));
				object object_5 = e9IgDZCnQ;
				object_3 = new object[1] { byte_1 };
				emWYy1LY0KMSBfVI0FF(object_4, object_5, object_3);
				method = exwyp4bAY.GetMethod(bool_0 ? eDuaTU3TDhsqeVkuTG8.eulODlten(1510) : eDuaTU3TDhsqeVkuTG8.eulODlten(1476), new Type[0]);
			}
			return (ICryptoTransform)emWYy1LY0KMSBfVI0FF(method, e9IgDZCnQ, new object[0]);
		}
		catch (Exception object_6)
		{
			ee4iL0LfZmTrmn4ueeU(object_6, method, object_3, this, byte_0, byte_1, bool_0);
			throw;
		}
	}

	public void eKb3AYt8Z()
	{
		try
		{
			emWYy1LY0KMSBfVI0FF(exwyp4bAY.GetMethod(eDuaTU3TDhsqeVkuTG8.eulODlten(1544)), e9IgDZCnQ, new object[0]);
		}
		catch (Exception object_)
		{
			ebVEteLokyHkabahF86(object_, this);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			eKb3AYt8Z();
		}
		catch (Exception object_)
		{
			ebVEteLokyHkabahF86(object_, this);
			throw;
		}
	}

	internal static void eCMTNhLCKkc0ewUWKXH(object object_0)
	{
		object_0._002Ector();
	}

	internal static object eqJe7nLZEReWDgBKBjG(object object_0)
	{
		return Assembly.Load((string)object_0);
	}

	internal static Type eEyCvXLg2VXGT9vf2Hr(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetType((string)object_1);
	}

	internal static object e6EphDL2StmKtAAc1jT(Type type_0)
	{
		return Activator.CreateInstance(type_0);
	}

	internal static void esBqy8LikFLtPgQnmVX(object object_0, object object_1, object object_2)
	{
		eEJNauItTVW1j8pluTb.e9jslfSvk((Exception)object_0, object_1, object_2);
	}

	internal static bool eAqLGuLj9rtOuDw33f8()
	{
		return true;
	}

	internal static bool eta058L59XafDGCEPoS()
	{
		return false;
	}

	internal static object eh4wD1LEPVgWHFLqTAw(object object_0)
	{
		return ((PropertyInfo)object_0).GetSetMethod();
	}

	internal static object emWYy1LY0KMSBfVI0FF(object object_0, object object_1, object object_2)
	{
		return ((MethodBase)object_0).Invoke(object_1, (object?[]?)object_2);
	}

	internal static void ee4iL0LfZmTrmn4ueeU(object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		eEJNauItTVW1j8pluTb.euXHswL8F((Exception)object_0, object_1, object_2, object_3, object_4, object_5, object_6);
	}

	internal static void ebVEteLokyHkabahF86(object object_0, object object_1)
	{
		eEJNauItTVW1j8pluTb.ecs0D1Zdd((Exception)object_0, object_1);
	}
}
