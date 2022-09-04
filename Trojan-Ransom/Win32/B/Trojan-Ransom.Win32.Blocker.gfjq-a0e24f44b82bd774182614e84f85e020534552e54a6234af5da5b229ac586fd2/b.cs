using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

[EditorBrowsable(EditorBrowsableState.Never)]
internal class b : Computer
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public b()
	{
	}
}
[StandardModule]
[HideModuleName]
internal sealed class B
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class a
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type a()
		{
			return typeof(a);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		private static a a<a>(a a) where a : new()
		{
			if (a == null)
			{
				return new a();
			}
			return a;
		}

		private void a<a>(ref a a)
		{
			a = default(a);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class A<a> where a : new()
	{
		[ThreadStatic]
		private static a m_a;

		internal a a
		{
			get
			{
				if (A<a>.a == null)
				{
					A<a>.a = new a();
				}
				return A<a>.a;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public A()
		{
		}
	}

	private static readonly A<b> m_a = new A<b>();

	private static readonly A<A> m_a = new A<A>();

	private static readonly A<User> m_a = new A<User>();

	private static readonly A<a> m_a = new A<a>();

	[HelpKeyword("My.Computer")]
	internal static b a => B.m_a.a;

	[HelpKeyword("My.Application")]
	internal static A a => B.m_a.a;

	[HelpKeyword("My.User")]
	internal static User a => B.m_a.a;

	[HelpKeyword("My.WebServices")]
	internal static a a => B.m_a.a;
}
