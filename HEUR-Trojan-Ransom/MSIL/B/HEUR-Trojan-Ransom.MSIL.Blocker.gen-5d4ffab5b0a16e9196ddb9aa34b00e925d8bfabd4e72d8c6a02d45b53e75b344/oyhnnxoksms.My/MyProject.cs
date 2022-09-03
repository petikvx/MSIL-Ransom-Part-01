using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace oyhnnxoksms.My;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyProject
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class p
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
		internal Type y()
		{
			return typeof(p);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		private static x l<x>(x gparam_0) where x : new()
		{
			if (gparam_0 == null)
			{
				return new x();
			}
			return gparam_0;
		}

		private void i<l>(ref l gparam_0)
		{
			gparam_0 = default(l);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p()
		{
			MyApplication.w.h();
		}

		static p()
		{
			MyApplication.w.a();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class a<v> where v : new()
	{
		[ThreadStatic]
		private static v j;

		[SpecialName]
		internal v t()
		{
			if (j == null)
			{
				j = new v();
			}
			return j;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a()
		{
			MyApplication.k();
		}

		static a()
		{
			MyApplication.w.a();
		}
	}

	private static readonly a<MyComputer> d;

	private static readonly a<MyApplication> d;

	private static readonly a<User> u;

	private static readonly a<p> l;

	[HelpKeyword("My.Computer")]
	internal static MyComputer i
	{
		get
		{
			MyComputer result = MyProject.d.t();
			MyApplication.s();
			return result;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication h
	{
		get
		{
			MyApplication result = d.t();
			MyComputer.e();
			return result;
		}
	}

	[HelpKeyword("My.User")]
	internal static User r
	{
		get
		{
			User result = u.t();
			MyApplication.x.k();
			return result;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static p j
	{
		get
		{
			p result = l.t();
			MyComputer.y.n();
			return result;
		}
	}

	static MyProject()
	{
		MyApplication.w.a();
		MyProject.d = new a<MyComputer>();
		d = new a<MyApplication>();
		u = new a<User>();
		l = new a<p>();
	}
}
