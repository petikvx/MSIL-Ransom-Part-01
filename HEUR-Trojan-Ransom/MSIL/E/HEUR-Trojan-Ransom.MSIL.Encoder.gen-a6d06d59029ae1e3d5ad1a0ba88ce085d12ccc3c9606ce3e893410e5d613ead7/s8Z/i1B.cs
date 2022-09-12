using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ag2;
using Bz3;
using Cc92;
using Ja7;
using Jq75;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Nr9s;
using Sg0;
using Sg8c;
using d5D;
using n5N;
using q0CT;
using r5W;
using t1G;
using w8DA;

namespace s8Z;

[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class i1B
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class m0W
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s2F m_Form10;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mc4 m_Form11;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ea0 m_Form12;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y0J m_Form3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a6N5 m_Form4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sj1 m_Form5;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n1R9 m_Form6;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z7DJ m_Form7;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qd38 m_Form8;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p8B m_Form9;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p6G m_Login;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fx0 m_Main;

		private static e9G k0T<e9G>(e9G e7W) where e9G : Form, new()
		{
			if (e7W == null || ((Control)e7W).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(e9G)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(e9G), null);
				try
				{
					return new e9G();
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
					m_FormBeingCreated.Remove(typeof(e9G));
				}
			}
			return e7W;
		}

		private void Ts5<Hi2>(ref Hi2 Rb7) where Hi2 : Form
		{
			((Component)Rb7).Dispose();
			Rb7 = default(Hi2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m0W()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool p3E(object w1J)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(w1J));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Le2()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type g1W()
		{
			return typeof(m0W);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string n6P()
		{
			return base.ToString();
		}

		[SpecialName]
		public s2F Ty3()
		{
			m_Form10 = k0T(m_Form10);
			return m_Form10;
		}

		[SpecialName]
		public Mc4 Tg0()
		{
			m_Form11 = k0T(m_Form11);
			return m_Form11;
		}

		[SpecialName]
		public Ea0 c2Y()
		{
			m_Form12 = k0T(m_Form12);
			return m_Form12;
		}

		[SpecialName]
		public y0J j5W()
		{
			m_Form3 = k0T(m_Form3);
			return m_Form3;
		}

		[SpecialName]
		public a6N5 g5X()
		{
			m_Form4 = k0T(m_Form4);
			return m_Form4;
		}

		[SpecialName]
		public Sj1 Gx4()
		{
			m_Form5 = k0T(m_Form5);
			return m_Form5;
		}

		[SpecialName]
		public n1R9 Ms1()
		{
			m_Form6 = k0T(m_Form6);
			return m_Form6;
		}

		[SpecialName]
		public z7DJ z5Z()
		{
			m_Form7 = k0T(m_Form7);
			return m_Form7;
		}

		[SpecialName]
		public Qd38 Bf8()
		{
			m_Form8 = k0T(m_Form8);
			return m_Form8;
		}

		[SpecialName]
		public p8B r2W()
		{
			m_Form9 = k0T(m_Form9);
			return m_Form9;
		}

		[SpecialName]
		public p6G y1Y()
		{
			m_Login = k0T(m_Login);
			return m_Login;
		}

		[SpecialName]
		public Fx0 i5C()
		{
			m_Main = k0T(m_Main);
			return m_Main;
		}

		[SpecialName]
		public void Dc6(s2F Gw2)
		{
			if (Gw2 != m_Form10)
			{
				if (Gw2 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ts5(ref m_Form10);
			}
		}

		[SpecialName]
		public void Mj0(Mc4 o7A)
		{
			if (o7A != m_Form11)
			{
				if (o7A != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ts5(ref m_Form11);
			}
		}

		[SpecialName]
		public void o7Z(Ea0 Cb2)
		{
			if (Cb2 != m_Form12)
			{
				if (Cb2 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ts5(ref m_Form12);
			}
		}

		[SpecialName]
		public void Zk7(y0J Mz9)
		{
			if (Mz9 != m_Form3)
			{
				if (Mz9 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ts5(ref m_Form3);
			}
		}

		[SpecialName]
		public void Pi4(a6N5 Gw8)
		{
			if (Gw8 != m_Form4)
			{
				if (Gw8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ts5(ref m_Form4);
			}
		}

		[SpecialName]
		public void d5N(Sj1 We0)
		{
			if (We0 != m_Form5)
			{
				if (We0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ts5(ref m_Form5);
			}
		}

		[SpecialName]
		public void c0J(n1R9 g0J)
		{
			if (g0J != m_Form6)
			{
				if (g0J != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ts5(ref m_Form6);
			}
		}

		[SpecialName]
		public void Rf4(z7DJ Ef8)
		{
			if (Ef8 != m_Form7)
			{
				if (Ef8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ts5(ref m_Form7);
			}
		}

		[SpecialName]
		public void t2X(Qd38 Ea4)
		{
			if (Ea4 != m_Form8)
			{
				if (Ea4 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ts5(ref m_Form8);
			}
		}

		[SpecialName]
		public void s2Q(p8B e6Q)
		{
			if (e6Q != m_Form9)
			{
				if (e6Q != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ts5(ref m_Form9);
			}
		}

		[SpecialName]
		public void g0T(p6G q2N)
		{
			if (q2N != m_Login)
			{
				if (q2N != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ts5(ref m_Login);
			}
		}

		[SpecialName]
		public void e8X(Fx0 r7C)
		{
			if (r7C != m_Main)
			{
				if (r7C != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ts5(ref m_Main);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Wk2
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool w2E(object Kz0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Kz0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int i2N()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Gw8()
		{
			return typeof(Wk2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Yy3()
		{
			return base.ToString();
		}

		private static x8K Tt4<x8K>(x8K b3J) where x8K : new()
		{
			if (b3J == null)
			{
				return new x8K();
			}
			return b3J;
		}

		private void Ao9<f4W>(ref f4W Ki4)
		{
			Ki4 = default(f4W);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wk2()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class q6C<j1D> where j1D : new()
	{
		[ThreadStatic]
		private static j1D m_ThreadStaticValue;

		[SpecialName]
		internal j1D d8W()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new j1D();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q6C()
		{
		}
	}

	private static readonly q6C<s2NB> m_ComputerObjectProvider = new q6C<s2NB>();

	private static readonly q6C<Gj45> m_AppObjectProvider = new q6C<Gj45>();

	private static readonly q6C<User> m_UserObjectProvider = new q6C<User>();

	private static q6C<m0W> m_MyFormsObjectProvider = new q6C<m0W>();

	private static readonly q6C<Wk2> m_MyWebServicesObjectProvider = new q6C<Wk2>();

	[HelpKeyword("My.Computer")]
	internal static s2NB Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static Gj45 Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static m0W Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static Wk2 WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
