using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dz2;
using Jc0a;
using Km2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Mj26;
using Tq87;
using Tx27;
using Wc2f;
using Xg4;
using Zi72;
using b3NB;
using b3S;
using d5N;
using d7Z;
using f7R9;
using k2N;
using o9F5;
using x6P;
using z2W;

namespace g7N;

[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class Rt9
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class q7Y
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sp1 m_Decision;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cm7 m_Faculty;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Rf6 m_History;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z4W m_JimenezPending;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n4D m_JimenezSchedule;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d9D m_Login;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s0X4 m_notify;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q3K6 m_OlivaPending;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gs7x m_Pending;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kk04 m_Reschedule;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g4A7 m_Schedule;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kj05 m_SetSchedule;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z9T1 m_Student;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qe54 m_T1Question;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jz8 m_T4Question;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k7G0 m_ViewSchedule;

		private static Et5 c7P<Et5>(Et5 Aw5) where Et5 : Form, new()
		{
			if (Aw5 == null || ((Control)Aw5).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Et5)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Et5), null);
				try
				{
					return new Et5();
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
					m_FormBeingCreated.Remove(typeof(Et5));
				}
			}
			return Aw5;
		}

		private void z5E<Ey4>(ref Ey4 Sf1) where Ey4 : Form
		{
			((Component)Sf1).Dispose();
			Sf1 = default(Ey4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q7Y()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Pf2(object a7H)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(a7H));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Qx0()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Lo6()
		{
			return typeof(q7Y);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string c7C()
		{
			return base.ToString();
		}

		[SpecialName]
		public Sp1 Wi9()
		{
			m_Decision = c7P(m_Decision);
			return m_Decision;
		}

		[SpecialName]
		public Cm7 Qb8()
		{
			m_Faculty = c7P(m_Faculty);
			return m_Faculty;
		}

		[SpecialName]
		public Rf6 An4()
		{
			m_History = c7P(m_History);
			return m_History;
		}

		[SpecialName]
		public z4W b5S()
		{
			m_JimenezPending = c7P(m_JimenezPending);
			return m_JimenezPending;
		}

		[SpecialName]
		public n4D Ay0()
		{
			m_JimenezSchedule = c7P(m_JimenezSchedule);
			return m_JimenezSchedule;
		}

		[SpecialName]
		public d9D e1Z()
		{
			m_Login = c7P(m_Login);
			return m_Login;
		}

		[SpecialName]
		public s0X4 Wg6()
		{
			m_notify = c7P(m_notify);
			return m_notify;
		}

		[SpecialName]
		public q3K6 m6B()
		{
			m_OlivaPending = c7P(m_OlivaPending);
			return m_OlivaPending;
		}

		[SpecialName]
		public Gs7x d9Y()
		{
			m_Pending = c7P(m_Pending);
			return m_Pending;
		}

		[SpecialName]
		public Kk04 Fn3()
		{
			m_Reschedule = c7P(m_Reschedule);
			return m_Reschedule;
		}

		[SpecialName]
		public g4A7 Ym1()
		{
			m_Schedule = c7P(m_Schedule);
			return m_Schedule;
		}

		[SpecialName]
		public Kj05 Ww9()
		{
			m_SetSchedule = c7P(m_SetSchedule);
			return m_SetSchedule;
		}

		[SpecialName]
		public z9T1 Yj7()
		{
			m_Student = c7P(m_Student);
			return m_Student;
		}

		[SpecialName]
		public Qe54 y1M()
		{
			m_T1Question = c7P(m_T1Question);
			return m_T1Question;
		}

		[SpecialName]
		public Jz8 n1B()
		{
			m_T4Question = c7P(m_T4Question);
			return m_T4Question;
		}

		[SpecialName]
		public k7G0 Xi0()
		{
			m_ViewSchedule = c7P(m_ViewSchedule);
			return m_ViewSchedule;
		}

		[SpecialName]
		public void m9F(Sp1 An3)
		{
			if (An3 != m_Decision)
			{
				if (An3 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_Decision);
			}
		}

		[SpecialName]
		public void Hc9(Cm7 i1K)
		{
			if (i1K != m_Faculty)
			{
				if (i1K != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_Faculty);
			}
		}

		[SpecialName]
		public void Zg0(Rf6 j0B)
		{
			if (j0B != m_History)
			{
				if (j0B != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_History);
			}
		}

		[SpecialName]
		public void Mf6(z4W Qa0)
		{
			if (Qa0 != m_JimenezPending)
			{
				if (Qa0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_JimenezPending);
			}
		}

		[SpecialName]
		public void f8Y(n4D Ke5)
		{
			if (Ke5 != m_JimenezSchedule)
			{
				if (Ke5 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_JimenezSchedule);
			}
		}

		[SpecialName]
		public void w8N(d9D Ns1)
		{
			if (Ns1 != m_Login)
			{
				if (Ns1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_Login);
			}
		}

		[SpecialName]
		public void c8T(s0X4 Qf2)
		{
			if (Qf2 != m_notify)
			{
				if (Qf2 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_notify);
			}
		}

		[SpecialName]
		public void Yy1(q3K6 m6P)
		{
			if (m6P != m_OlivaPending)
			{
				if (m6P != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_OlivaPending);
			}
		}

		[SpecialName]
		public void Rs1(Gs7x m2S)
		{
			if (m2S != m_Pending)
			{
				if (m2S != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_Pending);
			}
		}

		[SpecialName]
		public void Yj0(Kk04 n0J)
		{
			if (n0J != m_Reschedule)
			{
				if (n0J != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_Reschedule);
			}
		}

		[SpecialName]
		public void w0D(g4A7 Pq1)
		{
			if (Pq1 != m_Schedule)
			{
				if (Pq1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_Schedule);
			}
		}

		[SpecialName]
		public void Sr9(Kj05 k4N)
		{
			if (k4N != m_SetSchedule)
			{
				if (k4N != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_SetSchedule);
			}
		}

		[SpecialName]
		public void j7M(z9T1 r0Z)
		{
			if (r0Z != m_Student)
			{
				if (r0Z != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_Student);
			}
		}

		[SpecialName]
		public void c8D(Qe54 w6M)
		{
			if (w6M != m_T1Question)
			{
				if (w6M != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_T1Question);
			}
		}

		[SpecialName]
		public void Qa2(Jz8 Jz6)
		{
			if (Jz6 != m_T4Question)
			{
				if (Jz6 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_T4Question);
			}
		}

		[SpecialName]
		public void Yt7(k7G0 Qe9)
		{
			if (Qe9 != m_ViewSchedule)
			{
				if (Qe9 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z5E(ref m_ViewSchedule);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class p6X
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool o8L(object Fo5)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Fo5));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int t4X()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Ts6()
		{
			return typeof(p6X);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string m5T()
		{
			return base.ToString();
		}

		private static Qx7 Je8<Qx7>(Qx7 f4P) where Qx7 : new()
		{
			if (f4P == null)
			{
				return new Qx7();
			}
			return f4P;
		}

		private void r5Y<a4Q>(ref a4Q q9T)
		{
			q9T = default(a4Q);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p6X()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Kc2<Kn4> where Kn4 : new()
	{
		[ThreadStatic]
		private static Kn4 m_ThreadStaticValue;

		[SpecialName]
		internal Kn4 x3R()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new Kn4();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kc2()
		{
		}
	}

	private static readonly Kc2<Ro8> m_ComputerObjectProvider = new Kc2<Ro8>();

	private static readonly Kc2<p2H> m_AppObjectProvider = new Kc2<p2H>();

	private static readonly Kc2<User> m_UserObjectProvider = new Kc2<User>();

	private static Kc2<q7Y> m_MyFormsObjectProvider = new Kc2<q7Y>();

	private static readonly Kc2<p6X> m_MyWebServicesObjectProvider = new Kc2<p6X>();

	[HelpKeyword("My.Computer")]
	internal static Ro8 Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static p2H Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static q7Y Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static p6X WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
