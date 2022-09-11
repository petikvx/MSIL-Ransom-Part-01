using System;
using System.Reflection;

namespace VjMQkoKRLykc;

internal sealed class Class4
{
	internal sealed class Class5
	{
		internal Delegate delegate_0;

		internal bool bool_0;

		internal int int_0;

		internal Type[] type_0;

		public Delegate Delegate_0
		{
			get
			{
				return delegate_0;
			}
			set
			{
				Delegate @delegate = (delegate_0 = value);
			}
		}

		public Class5(Delegate delegate_1)
		{
			Delegate @delegate = (delegate_0 = delegate_1);
		}

		public object method_0(object[] object_0)
		{
			if ((object)delegate_0 == null)
			{
				return null;
			}
			if (!bool_0)
			{
				method_1();
				bool_0 = true;
			}
			if (type_0 != null && int_0 == object_0.Length)
			{
				for (int i = 0; i < int_0; i++)
				{
					if (type_0[i] != null)
					{
						object_0[i] = Enum.ToObject(type_0[i], object_0[i]);
					}
				}
			}
			return delegate_0.DynamicInvoke(object_0);
		}

		private void method_1()
		{
			ParameterInfo[] parameters = delegate_0.Method.GetParameters();
			int num = (int_0 = parameters.Length);
			Type[] array = new Type[int_0];
			bool flag = false;
			for (int i = 0; i < int_0; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				if (parameterInfo.ParameterType.IsByRef && parameterInfo.ParameterType.HasElementType && parameterInfo.ParameterType.GetElementType()!.IsEnum)
				{
					flag = true;
					array[i] = parameterInfo.ParameterType.GetElementType();
				}
			}
			if (flag)
			{
				Type[] array2 = (type_0 = array);
			}
		}
	}

	private Class5[] class5_0;

	internal int int_0;

	internal Class4 class4_0;

	internal int Int32_0 => int_0;

	internal bool Boolean_0
	{
		get
		{
			if (class5_0 != null)
			{
				return class5_0.Length == 0;
			}
			return true;
		}
	}

	internal Class4(int int_1)
	{
		class5_0 = null;
		int num = (int_0 = int_1);
	}

	internal static Class4 smethod_0(Class4 class4_1, int int_1)
	{
		while (class4_1 != null && class4_1.int_0 != int_1)
		{
			class4_1 = class4_1.class4_0;
		}
		return class4_1;
	}

	internal static Class4 smethod_1(Class4 class4_1, Class4 class4_2)
	{
		Class4 @class = (class4_2.class4_0 = class4_1);
		return class4_2;
	}

	internal static void smethod_2()
	{
		AppDomain.CurrentDomain.AssemblyResolve += (object object_0, ResolveEventArgs resolveEventArgs_0) => Class13.smethod_2(object_0, resolveEventArgs_0, out var assembly_) ? assembly_ : null;
	}

	internal static Class4 smethod_3(Class4 class4_1, Class4 class4_2)
	{
		if (class4_1 == class4_2)
		{
			class4_1 = class4_1.class4_0;
		}
		else
		{
			Class4 @class = class4_1;
			while (@class != null && @class.class4_0 != class4_2)
			{
				@class = @class.class4_0;
			}
			if (@class != null)
			{
				Class4 class2 = (@class.class4_0 = class4_2.class4_0);
			}
		}
		return class4_1;
	}

	internal void method_0(Delegate delegate_0)
	{
		int num = 0;
		if (class5_0 != null)
		{
			num = class5_0.Length;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				if (class5_0[num2].Delegate_0.GetType() == delegate_0.GetType())
				{
					break;
				}
				num2++;
				continue;
			}
			Class5[] array = new Class5[num + 1];
			if (num > 0)
			{
				class5_0.CopyTo(array, 0);
			}
			Class5 @class = (array[num] = new Class5(delegate_0));
			class5_0 = array;
			return;
		}
		class5_0[num2].Delegate_0 = Delegate.Combine(class5_0[num2].Delegate_0, delegate_0);
	}

	internal void method_1(Delegate delegate_0)
	{
		int num = class5_0.Length;
		int num2 = -1;
		for (int i = 0; i < num; i++)
		{
			if (class5_0[i].Delegate_0.GetType() == delegate_0.GetType())
			{
				num2 = i;
				break;
			}
		}
		if (num2 < 0)
		{
			return;
		}
		Delegate @delegate = Delegate.Remove(class5_0[num2].Delegate_0, delegate_0);
		if ((object)@delegate != null)
		{
			class5_0[num2].Delegate_0 = @delegate;
			return;
		}
		if (num == 1)
		{
			class5_0 = null;
			return;
		}
		Class5[] array = new Class5[num - 1];
		int j;
		for (j = 0; j < num2; j++)
		{
			array[j] = class5_0[j];
		}
		for (; j < num - 1; j++)
		{
			array[j] = class5_0[j + 1];
		}
		class5_0 = array;
	}

	internal object method_2(object[] object_0)
	{
		object result = null;
		Class5[] array = class5_0;
		foreach (Class5 @class in array)
		{
			if (@class != null && (object)@class.Delegate_0 != null)
			{
				result = @class.method_0(object_0);
			}
		}
		return result;
	}
}
