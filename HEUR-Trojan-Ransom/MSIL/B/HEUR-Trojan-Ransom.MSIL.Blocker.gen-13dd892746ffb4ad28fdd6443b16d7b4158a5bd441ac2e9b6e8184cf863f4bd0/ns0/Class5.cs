using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace ns0;

internal sealed class Class5
{
	public static Class2.Delegate0 delegate0_0;

	public static bool smethod_0(BinaryOperationBinder binaryOperationBinder_0, object object_0, out object object_1)
	{
		if (binaryOperationBinder_0.Operation == ExpressionType.AddAssign)
		{
			object_1 = smethod_2(object_0);
			return true;
		}
		if (binaryOperationBinder_0.Operation == ExpressionType.SubtractAssign)
		{
			object_1 = smethod_1(object_0);
			return true;
		}
		object_1 = null;
		return false;
	}

	static Class5()
	{
		delegate0_0 = (Class2.Delegate0)Delegate.CreateDelegate(typeof(Class2.Delegate0), null, Class6.methodInfo_0);
	}

	private static object smethod_1(object object_0)
	{
		return null;
	}

	private static object smethod_2(object object_0)
	{
		return null;
	}
}
