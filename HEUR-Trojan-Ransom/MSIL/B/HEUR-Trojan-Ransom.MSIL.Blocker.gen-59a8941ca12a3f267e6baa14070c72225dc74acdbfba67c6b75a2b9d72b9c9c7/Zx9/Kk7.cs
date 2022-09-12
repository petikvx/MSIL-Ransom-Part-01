using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gf9;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using t6B;

namespace Zx9;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class Kk7
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Bs8
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool j4C(object object_0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(object_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int z8Y()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type t6K()
		{
			IReflect typeFromHandle = typeof(Bs8);
			return typeFromHandle as Type;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string En5()
		{
			IEquatable<string> equatable = base.ToString();
			return (string)equatable;
		}

		private static x7D n2T<x7D>(x7D gparam_0) where x7D : new()
		{
			if (gparam_0 == null)
			{
				return new x7D();
			}
			return gparam_0;
		}

		private void Ao2<Lc9>(ref Lc9 gparam_0)
		{
			gparam_0 = default(Lc9);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bs8()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Jt9<t0J> where t0J : new()
	{
		[ThreadStatic]
		private static t0J i;

		internal t0J O
		{
			get
			{
				if (i == null)
				{
					i = new t0J();
				}
				return i;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jt9()
		{
		}
	}

	private static readonly Jt9<q6L> m_x = new Jt9<q6L>();

	private static readonly Jt9<Hx0> m_x = new Jt9<Hx0>();

	private static readonly Jt9<User> m_h = new Jt9<User>();

	private static readonly Jt9<Bs8> Y = new Jt9<Bs8>();

	[HelpKeyword("My.Computer")]
	internal static q6L O
	{
		get
		{
			object obj = Kk7.m_x.G();
			return (q6L)obj;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Hx0 x
	{
		get
		{
			object obj = Kk7.m_x.G();
			return (Hx0)obj;
		}
	}

	[HelpKeyword("My.User")]
	internal static User x
	{
		get
		{
			object obj = Kk7.m_h.G();
			return (User)((obj is User) ? obj : null);
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Bs8 h
	{
		get
		{
			object obj = Y.G();
			return obj as Bs8;
		}
	}
}
