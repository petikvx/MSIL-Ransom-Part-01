using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Cg6;
using Dw9;
using Ez5;
using Kb3d;
using Kc71;
using Md2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Pt8;
using Qq3;
using Xc5;
using Zt6;
using k3Z;
using o6D;
using r8C;
using x5BP;

namespace Qm3;

[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class Db5
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class s7B
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g9L m_Form10;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ya7 m_Form11;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e9B m_Form12;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k7E m_Form3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y6F m_Form4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b8R m_Form5;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kb2 m_Form6;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Em23 m_Form7;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xt6k m_Form8;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bn17 m_Form9;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wg8 m_Login;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g0Z m_Main;

		private static Yi7 m3S<Yi7>(Yi7 Qf8) where Yi7 : Form, new()
		{
			if (Qf8 == null || ((Control)Qf8).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Yi7)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Yi7), null);
				try
				{
					return new Yi7();
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
					m_FormBeingCreated.Remove(typeof(Yi7));
				}
			}
			return Qf8;
		}

		private void Fy3<o0G>(ref o0G Lc0) where o0G : Form
		{
			((Component)Lc0).Dispose();
			Lc0 = default(o0G);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s7B()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool o5D(object Pn2)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Pn2));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Ff0()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Do4()
		{
			return typeof(s7B);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string y3L()
		{
			return base.ToString();
		}

		[SpecialName]
		public g9L Zj7()
		{
			m_Form10 = m3S(m_Form10);
			return m_Form10;
		}

		[SpecialName]
		public Ya7 Ys6()
		{
			m_Form11 = m3S(m_Form11);
			return m_Form11;
		}

		[SpecialName]
		public e9B Ly8()
		{
			m_Form12 = m3S(m_Form12);
			return m_Form12;
		}

		[SpecialName]
		public k7E i1D()
		{
			m_Form3 = m3S(m_Form3);
			return m_Form3;
		}

		[SpecialName]
		public y6F Wq3()
		{
			m_Form4 = m3S(m_Form4);
			return m_Form4;
		}

		[SpecialName]
		public b8R a3S()
		{
			m_Form5 = m3S(m_Form5);
			return m_Form5;
		}

		[SpecialName]
		public Kb2 i8Y()
		{
			m_Form6 = m3S(m_Form6);
			return m_Form6;
		}

		[SpecialName]
		public Em23 Eo0()
		{
			m_Form7 = m3S(m_Form7);
			return m_Form7;
		}

		[SpecialName]
		public Xt6k Wa2()
		{
			m_Form8 = m3S(m_Form8);
			return m_Form8;
		}

		[SpecialName]
		public Bn17 Ap3()
		{
			m_Form9 = m3S(m_Form9);
			return m_Form9;
		}

		[SpecialName]
		public Wg8 Ek3()
		{
			m_Login = m3S(m_Login);
			return m_Login;
		}

		[SpecialName]
		public g0Z Ft0()
		{
			m_Main = m3S(m_Main);
			return m_Main;
		}

		[SpecialName]
		public void k4T(g9L a4S)
		{
			if (a4S != m_Form10)
			{
				if (a4S != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fy3(ref m_Form10);
			}
		}

		[SpecialName]
		public void p4Q(Ya7 n9S)
		{
			if (n9S != m_Form11)
			{
				if (n9S != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fy3(ref m_Form11);
			}
		}

		[SpecialName]
		public void x2W(e9B Sf1)
		{
			if (Sf1 != m_Form12)
			{
				if (Sf1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fy3(ref m_Form12);
			}
		}

		[SpecialName]
		public void Tc7(k7E y7X)
		{
			if (y7X != m_Form3)
			{
				if (y7X != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fy3(ref m_Form3);
			}
		}

		[SpecialName]
		public void g2L(y6F x4H)
		{
			if (x4H != m_Form4)
			{
				if (x4H != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fy3(ref m_Form4);
			}
		}

		[SpecialName]
		public void Kx3(b8R i7G)
		{
			if (i7G != m_Form5)
			{
				if (i7G != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fy3(ref m_Form5);
			}
		}

		[SpecialName]
		public void Ko4(Kb2 Px5)
		{
			if (Px5 != m_Form6)
			{
				if (Px5 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fy3(ref m_Form6);
			}
		}

		[SpecialName]
		public void s9Y(Em23 i8X)
		{
			if (i8X != m_Form7)
			{
				if (i8X != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fy3(ref m_Form7);
			}
		}

		[SpecialName]
		public void Qe5(Xt6k Ef1)
		{
			if (Ef1 != m_Form8)
			{
				if (Ef1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fy3(ref m_Form8);
			}
		}

		[SpecialName]
		public void Dr9(Bn17 c7Y)
		{
			if (c7Y != m_Form9)
			{
				if (c7Y != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fy3(ref m_Form9);
			}
		}

		[SpecialName]
		public void r1D(Wg8 r1B)
		{
			if (r1B != m_Login)
			{
				if (r1B != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fy3(ref m_Login);
			}
		}

		[SpecialName]
		public void s1E(g0Z e1L)
		{
			if (e1L != m_Main)
			{
				if (e1L != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Fy3(ref m_Main);
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Kj4
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool e5Y(object Rg4)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Rg4));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Pw0()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type t7B()
		{
			return typeof(Kj4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string f7K()
		{
			return base.ToString();
		}

		private static Pj5 d8C<Pj5>(Pj5 Dw1) where Pj5 : new()
		{
			if (Dw1 == null)
			{
				return new Pj5();
			}
			return Dw1;
		}

		private void Qd6<k4P>(ref k4P o2K)
		{
			o2K = default(k4P);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kj4()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class y2A<Ax5> where Ax5 : new()
	{
		[ThreadStatic]
		private static Ax5 m_ThreadStaticValue;

		[SpecialName]
		internal Ax5 Az6()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new Ax5();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y2A()
		{
		}
	}

	private static readonly y2A<Wx6> m_ComputerObjectProvider = new y2A<Wx6>();

	private static readonly y2A<De0> m_AppObjectProvider = new y2A<De0>();

	private static readonly y2A<User> m_UserObjectProvider = new y2A<User>();

	private static y2A<s7B> m_MyFormsObjectProvider = new y2A<s7B>();

	private static readonly y2A<Kj4> m_MyWebServicesObjectProvider = new y2A<Kj4>();

	[HelpKeyword("My.Computer")]
	internal static Wx6 Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static De0 Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static s7B Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static Kj4 WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
