using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Cy5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Qo0e;
using Se4n;
using Sn7;
using Ss8;
using Yj2;
using Zc9;
using a7J;
using g5B;
using n6EF;
using p4C;

namespace Bp6;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class p8H
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class g0Z
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public r9D m_Form1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ct6 m_Form2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fa9 m_Form3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b0Y m_Form4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kq8 m_Form5;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k7N3 m_Form6;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z0Z6 m_Form7;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mq8 m_Form8;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x8B9 m_Form9;

		private static g8K d4Z<g8K>(g8K b2M) where g8K : Form, new()
		{
			if (b2M == null || ((Control)b2M).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(g8K)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(g8K), null);
				try
				{
					return new g8K();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError((Exception)ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message });
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(g8K));
				}
			}
			return b2M;
		}

		private void Fw5<x3X>(ref x3X Jo3) where x3X : Form
		{
			((Component)Jo3).Dispose();
			Jo3 = default(x3X);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g0Z()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool m2S(object Yc2)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Yc2));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Kq6()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Zs7()
		{
			return typeof(g0Z);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string f0X()
		{
			return base.ToString();
		}

		[SpecialName]
		public r9D Tj0()
		{
			m_Form1 = d4Z(m_Form1);
			return m_Form1;
		}

		[SpecialName]
		public Ct6 Kx9()
		{
			m_Form2 = d4Z(m_Form2);
			return m_Form2;
		}

		[SpecialName]
		public Fa9 x3G()
		{
			m_Form3 = d4Z(m_Form3);
			return m_Form3;
		}

		[SpecialName]
		public b0Y Bs5()
		{
			m_Form4 = d4Z(m_Form4);
			return m_Form4;
		}

		[SpecialName]
		public Kq8 Sm7()
		{
			m_Form5 = d4Z(m_Form5);
			return m_Form5;
		}

		[SpecialName]
		public k7N3 Sf6()
		{
			m_Form6 = d4Z(m_Form6);
			return m_Form6;
		}

		[SpecialName]
		public z0Z6 w0P()
		{
			m_Form7 = d4Z(m_Form7);
			return m_Form7;
		}

		[SpecialName]
		public Mq8 Wd9()
		{
			m_Form8 = d4Z(m_Form8);
			return m_Form8;
		}

		[SpecialName]
		public x8B9 n3G()
		{
			m_Form9 = d4Z(m_Form9);
			return m_Form9;
		}

		[SpecialName]
		public void a5L(r9D g5Z)
		{
			if (g5Z != m_Form1)
			{
				if (g5Z != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fw5(ref m_Form1);
			}
		}

		[SpecialName]
		public void c5C(Ct6 Mr8)
		{
			if (Mr8 != m_Form2)
			{
				if (Mr8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fw5(ref m_Form2);
			}
		}

		[SpecialName]
		public void Mj5(Fa9 r6R)
		{
			if (r6R != m_Form3)
			{
				if (r6R != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fw5(ref m_Form3);
			}
		}

		[SpecialName]
		public void i5G(b0Y Dg1)
		{
			if (Dg1 != m_Form4)
			{
				if (Dg1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fw5(ref m_Form4);
			}
		}

		[SpecialName]
		public void g2Q(Kq8 Sm2)
		{
			if (Sm2 != m_Form5)
			{
				if (Sm2 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fw5(ref m_Form5);
			}
		}

		[SpecialName]
		public void i1Z(k7N3 d4Y)
		{
			if (d4Y != m_Form6)
			{
				if (d4Y != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fw5(ref m_Form6);
			}
		}

		[SpecialName]
		public void p8J(z0Z6 Xc2)
		{
			if (Xc2 != m_Form7)
			{
				if (Xc2 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fw5(ref m_Form7);
			}
		}

		[SpecialName]
		public void Le3(Mq8 x4G)
		{
			if (x4G != m_Form8)
			{
				if (x4G != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fw5(ref m_Form8);
			}
		}

		[SpecialName]
		public void Wx5(x8B9 Nm0)
		{
			if (Nm0 != m_Form9)
			{
				if (Nm0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fw5(ref m_Form9);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class w2R
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool o8L(object p3R)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(p3R));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Ee4()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type o0S()
		{
			return typeof(w2R);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Kd7()
		{
			return base.ToString();
		}

		private static d0S o5N<d0S>(d0S Wg3) where d0S : new()
		{
			if (Wg3 == null)
			{
				return new d0S();
			}
			return Wg3;
		}

		private void x5A<Sf7>(ref Sf7 e5Q)
		{
			e5Q = default(Sf7);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w2R()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class f1P<Yy7> where Yy7 : new()
	{
		[ThreadStatic]
		private static Yy7 m_ThreadStaticValue;

		[SpecialName]
		internal Yy7 b6C()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new Yy7();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f1P()
		{
		}
	}

	private static readonly f1P<k2H> m_ComputerObjectProvider = new f1P<k2H>();

	private static readonly f1P<o9Q> m_AppObjectProvider = new f1P<o9Q>();

	private static readonly f1P<User> m_UserObjectProvider = new f1P<User>();

	private static f1P<g0Z> m_MyFormsObjectProvider = new f1P<g0Z>();

	private static readonly f1P<w2R> m_MyWebServicesObjectProvider = new f1P<w2R>();

	[HelpKeyword("My.Computer")]
	internal static k2H Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static o9Q Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static g0Z Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static w2R WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
