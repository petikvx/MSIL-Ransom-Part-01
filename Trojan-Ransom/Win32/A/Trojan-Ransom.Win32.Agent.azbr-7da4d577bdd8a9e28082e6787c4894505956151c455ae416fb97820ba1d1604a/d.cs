using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CyberProt;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class d
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class a
	{
		[ThreadStatic]
		private static Hashtable m_a;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form1 b;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form2 c;

		[DebuggerHidden]
		private static a e<a>(a A_0) where a : Form, new()
		{
			if (A_0 != null && !((Control)A_0).get_IsDisposed())
			{
				return A_0;
			}
			if (global::d.a.m_a != null)
			{
				if (global::d.a.m_a.ContainsKey(typeof(a)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
				}
			}
			else
			{
				global::d.a.m_a = new Hashtable();
			}
			global::d.a.m_a.Add(typeof(a), null);
			try
			{
				return new a();
			}
			catch (TargetInvocationException ex) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError((Exception)ex);
				return ex.InnerException != null;
			}).Invoke())
			{
				throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message }), ex.InnerException);
			}
			finally
			{
				global::d.a.m_a.Remove(typeof(a));
			}
		}

		[DebuggerHidden]
		private void e<a>(ref a A_0) where a : Form
		{
			((Component)A_0).Dispose();
			A_0 = default(a);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public a()
		{
		}

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
		internal Type e()
		{
			return typeof(a);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[SpecialName]
		public Form1 f()
		{
			b = global::d.a.e<Form1>(b);
			return b;
		}

		[SpecialName]
		public Form2 g()
		{
			c = global::d.a.e<Form2>(c);
			return c;
		}

		[SpecialName]
		public void e(Form1 A_0)
		{
			if (A_0 != b)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				e(ref b);
			}
		}

		[SpecialName]
		public void e(Form2 A_0)
		{
			if (A_0 != c)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				e(ref c);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class b
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type a()
		{
			return typeof(b);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static a a<a>(a A_0) where a : new()
		{
			if (A_0 == null)
			{
				return new a();
			}
			return A_0;
		}

		[DebuggerHidden]
		private void a<a>(ref a A_0)
		{
			A_0 = default(a);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public b()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class c<a> where a : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static a m_a;

		[SpecialName]
		[DebuggerHidden]
		internal a a()
		{
			if (c<a>.a == null)
			{
				c<a>.a = new a();
			}
			return c<a>.a;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public c()
		{
		}
	}

	private static readonly c<c> m_a = new c<c>();

	private static readonly c<global::b> m_b = new c<global::b>();

	private static readonly c<User> m_c = new c<User>();

	private static c<a> m_d = new c<a>();

	private static readonly c<b> m_e = new c<b>();

	[SpecialName]
	[DebuggerHidden]
	internal static c e()
	{
		return global::d.m_a.a();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static global::b d()
	{
		return global::d.m_b.a();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static User c()
	{
		return global::d.m_c.a();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static a b()
	{
		return global::d.m_d.a();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static b a()
	{
		return global::d.m_e.a();
	}
}
