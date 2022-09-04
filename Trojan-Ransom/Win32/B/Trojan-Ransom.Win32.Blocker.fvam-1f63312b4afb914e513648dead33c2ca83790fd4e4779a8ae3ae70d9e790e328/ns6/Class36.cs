using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;

namespace ns6;

[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class36
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class37
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class37()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class38<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T gparam_0;

		[SpecialName]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class38()
		{
		}
	}

	private static readonly Class38<Class35> class38_0 = new Class38<Class35>();

	private static readonly Class38<Class34> class38_1 = new Class38<Class34>();

	private static readonly Class38<User> class38_2 = new Class38<User>();

	private static readonly Class38<Class37> class38_3 = new Class38<Class37>();

	[SpecialName]
	internal static Class35 smethod_0()
	{
		return class38_0.method_0();
	}
}
