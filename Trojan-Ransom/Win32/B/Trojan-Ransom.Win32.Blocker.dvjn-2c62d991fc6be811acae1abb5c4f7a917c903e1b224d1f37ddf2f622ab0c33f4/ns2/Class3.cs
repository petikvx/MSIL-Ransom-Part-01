using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.ApplicationServices;
using ns0;
using ns1;
using ns3;

namespace ns2;

[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class3
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class4
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		bool object.Equals(object obj)
		{
			try
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(obj));
			}
			catch (Exception exception_)
			{
				bool flag = default(bool);
				Class38.smethod_3(exception_, flag, this, obj);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		int object.GetHashCode()
		{
			try
			{
				return base.GetHashCode();
			}
			catch (Exception exception_)
			{
				int num = default(int);
				Class38.smethod_2(exception_, num, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			try
			{
				return base.ToString();
			}
			catch (Exception exception_)
			{
				string object_ = default(string);
				Class38.smethod_2(exception_, object_, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class5<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;

		[SpecialName]
		internal T method_0()
		{
			try
			{
				if (gparam_0 == null)
				{
					gparam_0 = new T();
				}
				return gparam_0;
			}
			catch (Exception exception_)
			{
				T val = default(T);
				Class38.smethod_2(exception_, val, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class5()
		{
		}
	}

	private static readonly Class5<Class2> class5_0;

	private static readonly Class5<Class1> class5_1;

	private static readonly Class5<User> class5_2;

	private static readonly Class5<Class4> class5_3;

	static Class3()
	{
		try
		{
			class5_0 = new Class5<Class2>();
			class5_1 = new Class5<Class1>();
			class5_2 = new Class5<User>();
			class5_3 = new Class5<Class4>();
		}
		catch (Exception exception_)
		{
			Class38.smethod_0(exception_);
			throw;
		}
	}

	[SpecialName]
	internal static Class2 smethod_0()
	{
		try
		{
			return class5_0.method_0();
		}
		catch (Exception exception_)
		{
			Class2 object_ = default(Class2);
			Class38.smethod_1(exception_, object_);
			throw;
		}
	}
}
