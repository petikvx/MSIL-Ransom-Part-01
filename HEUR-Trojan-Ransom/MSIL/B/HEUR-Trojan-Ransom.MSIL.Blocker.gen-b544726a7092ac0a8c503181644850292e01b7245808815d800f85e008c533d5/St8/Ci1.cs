using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using As6;
using Dm9;
using Eb8;
using Js9;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Nk7;
using Nw27;
using Px8;
using Qd4;
using Ws9;

namespace St8;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Ci1
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class f4X
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k6N m_AddCTHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Yw7 m_AddHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k8W m_AddKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c4K m_AddLSP;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public j5H m_AddSp;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k8A m_EditKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wg39 m_Form1;

		private static Sw7 Gs5<Sw7>(Sw7 Dd7) where Sw7 : Form, new()
		{
			if (Dd7 == null || ((Control)Dd7).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Sw7)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Sw7), null);
				try
				{
					return new Sw7();
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
					m_FormBeingCreated.Remove(typeof(Sw7));
				}
			}
			return Dd7;
		}

		private void q0A<e4E>(ref e4E Ft4) where e4E : Form
		{
			((Component)Ft4).Dispose();
			Ft4 = default(e4E);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f4X()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool f8T(object Xs6)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Xs6));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Fp2()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Pz1()
		{
			return typeof(f4X);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string My5()
		{
			return base.ToString();
		}

		[SpecialName]
		public k6N Kn8()
		{
			m_AddCTHD = Gs5(m_AddCTHD);
			return m_AddCTHD;
		}

		[SpecialName]
		public Yw7 y5W()
		{
			m_AddHD = Gs5(m_AddHD);
			return m_AddHD;
		}

		[SpecialName]
		public k8W o5Z()
		{
			m_AddKH = Gs5(m_AddKH);
			return m_AddKH;
		}

		[SpecialName]
		public c4K Ds6()
		{
			m_AddLSP = Gs5(m_AddLSP);
			return m_AddLSP;
		}

		[SpecialName]
		public j5H e9L()
		{
			m_AddSp = Gs5(m_AddSp);
			return m_AddSp;
		}

		[SpecialName]
		public k8A t3Z()
		{
			m_EditKH = Gs5(m_EditKH);
			return m_EditKH;
		}

		[SpecialName]
		public Wg39 Ho5()
		{
			m_Form1 = Gs5(m_Form1);
			return m_Form1;
		}

		[SpecialName]
		public void Jb3(k6N Do8)
		{
			if (Do8 != m_AddCTHD)
			{
				if (Do8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				q0A(ref m_AddCTHD);
			}
		}

		[SpecialName]
		public void Wg5(Yw7 z3F)
		{
			if (z3F != m_AddHD)
			{
				if (z3F != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				q0A(ref m_AddHD);
			}
		}

		[SpecialName]
		public void Nz7(k8W c4M)
		{
			if (c4M != m_AddKH)
			{
				if (c4M != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				q0A(ref m_AddKH);
			}
		}

		[SpecialName]
		public void y8B(c4K j4J)
		{
			if (j4J != m_AddLSP)
			{
				if (j4J != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				q0A(ref m_AddLSP);
			}
		}

		[SpecialName]
		public void w1P(j5H To6)
		{
			if (To6 != m_AddSp)
			{
				if (To6 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				q0A(ref m_AddSp);
			}
		}

		[SpecialName]
		public void Yz1(k8A Nq9)
		{
			if (Nq9 != m_EditKH)
			{
				if (Nq9 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				q0A(ref m_EditKH);
			}
		}

		[SpecialName]
		public void z9F(Wg39 c2D)
		{
			if (c2D != m_Form1)
			{
				if (c2D != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				q0A(ref m_Form1);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class t9S
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool y3X(object Tm3)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Tm3));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int w9E()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type z3H()
		{
			return typeof(t9S);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string y7Z()
		{
			return base.ToString();
		}

		private static Nm9 Fd6<Nm9>(Nm9 j8A) where Nm9 : new()
		{
			if (j8A == null)
			{
				return new Nm9();
			}
			return j8A;
		}

		private void n3G<j7E>(ref j7E i1J)
		{
			i1J = default(j7E);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t9S()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Tn4<Xd6> where Xd6 : new()
	{
		[ThreadStatic]
		private static Xd6 m_ThreadStaticValue;

		[SpecialName]
		internal Xd6 x0L()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new Xd6();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tn4()
		{
		}
	}

	private static readonly Tn4<Ap0> m_ComputerObjectProvider = new Tn4<Ap0>();

	private static readonly Tn4<Nj1> m_AppObjectProvider = new Tn4<Nj1>();

	private static readonly Tn4<User> m_UserObjectProvider = new Tn4<User>();

	private static Tn4<f4X> m_MyFormsObjectProvider = new Tn4<f4X>();

	private static readonly Tn4<t9S> m_MyWebServicesObjectProvider = new Tn4<t9S>();

	[HelpKeyword("My.Computer")]
	internal static Ap0 Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static Nj1 Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static f4X Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static t9S WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
