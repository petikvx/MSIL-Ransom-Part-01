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
using Fq1;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Xx4q;
using Yn32;
using Zd82;
using a6W4;
using c7DN;
using m8F9;
using n0AL;
using q2AL;
using q8D;
using r0GT;
using r8ND;
using w0XP;
using x5X;
using y1C3;
using y4J;
using z8AQ;

namespace q4F8;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class d7H8
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Bm1r
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n5J m_Decision;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b0D m_Faculty;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t2P m_History;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pb3 m_JimenezPending;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wj1 m_JimenezSchedule;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y3Y4 m_Login;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fe1r m_notify;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w2TA m_OlivaPending;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d1D9 m_Pending;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ee60 m_Reschedule;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cb91 m_Schedule;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s9R8 m_SetSchedule;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Td41 m_Student;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tx0d m_T1Question;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ab7z m_T4Question;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Aw27 m_ViewSchedule;

		private static Ws4r Ys4j<Ws4r>(Ws4r Xa4x) where Ws4r : Form, new()
		{
			if (Xa4x == null || ((Control)Xa4x).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Ws4r)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Ws4r), null);
				try
				{
					return new Ws4r();
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
					m_FormBeingCreated.Remove(typeof(Ws4r));
				}
			}
			return Xa4x;
		}

		private void k7NZ<k2TZ>(ref k2TZ x9H0) where k2TZ : Form
		{
			((Component)x9H0).Dispose();
			x9H0 = default(k2TZ);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bm1r()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool j2QD(object a4WT)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(a4WT));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Gd5j()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type m5LA()
		{
			return typeof(Bm1r);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string n5D0()
		{
			return base.ToString();
		}

		[SpecialName]
		public n5J t8JD()
		{
			m_Decision = Ys4j(m_Decision);
			return m_Decision;
		}

		[SpecialName]
		public b0D Gt79()
		{
			m_Faculty = Ys4j(m_Faculty);
			return m_Faculty;
		}

		[SpecialName]
		public t2P j8SW()
		{
			m_History = Ys4j(m_History);
			return m_History;
		}

		[SpecialName]
		public Pb3 Yd65()
		{
			m_JimenezPending = Ys4j(m_JimenezPending);
			return m_JimenezPending;
		}

		[SpecialName]
		public Wj1 Ly9r()
		{
			m_JimenezSchedule = Ys4j(m_JimenezSchedule);
			return m_JimenezSchedule;
		}

		[SpecialName]
		public y3Y4 b1Y5()
		{
			m_Login = Ys4j(m_Login);
			return m_Login;
		}

		[SpecialName]
		public Fe1r Eg48()
		{
			m_notify = Ys4j(m_notify);
			return m_notify;
		}

		[SpecialName]
		public w2TA a4LE()
		{
			m_OlivaPending = Ys4j(m_OlivaPending);
			return m_OlivaPending;
		}

		[SpecialName]
		public d1D9 Qc8q()
		{
			m_Pending = Ys4j(m_Pending);
			return m_Pending;
		}

		[SpecialName]
		public Ee60 Tb96()
		{
			m_Reschedule = Ys4j(m_Reschedule);
			return m_Reschedule;
		}

		[SpecialName]
		public Cb91 Wz6e()
		{
			m_Schedule = Ys4j(m_Schedule);
			return m_Schedule;
		}

		[SpecialName]
		public s9R8 w9SA()
		{
			m_SetSchedule = Ys4j(m_SetSchedule);
			return m_SetSchedule;
		}

		[SpecialName]
		public Td41 Lp3k()
		{
			m_Student = Ys4j(m_Student);
			return m_Student;
		}

		[SpecialName]
		public Tx0d Ym4c()
		{
			m_T1Question = Ys4j(m_T1Question);
			return m_T1Question;
		}

		[SpecialName]
		public Ab7z Hc4j()
		{
			m_T4Question = Ys4j(m_T4Question);
			return m_T4Question;
		}

		[SpecialName]
		public Aw27 m1F4()
		{
			m_ViewSchedule = Ys4j(m_ViewSchedule);
			return m_ViewSchedule;
		}

		[SpecialName]
		public void y2JG(n5J c6C4)
		{
			if (c6C4 != m_Decision)
			{
				if (c6C4 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_Decision);
			}
		}

		[SpecialName]
		public void Sj3i(b0D Pm32)
		{
			if (Pm32 != m_Faculty)
			{
				if (Pm32 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_Faculty);
			}
		}

		[SpecialName]
		public void Bq52(t2P i2W9)
		{
			if (i2W9 != m_History)
			{
				if (i2W9 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_History);
			}
		}

		[SpecialName]
		public void k1KQ(Pb3 g0EC)
		{
			if (g0EC != m_JimenezPending)
			{
				if (g0EC != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_JimenezPending);
			}
		}

		[SpecialName]
		public void z3JK(Wj1 Pd3z)
		{
			if (Pd3z != m_JimenezSchedule)
			{
				if (Pd3z != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_JimenezSchedule);
			}
		}

		[SpecialName]
		public void Ai1m(y3Y4 n7Q9)
		{
			if (n7Q9 != m_Login)
			{
				if (n7Q9 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_Login);
			}
		}

		[SpecialName]
		public void n1M4(Fe1r Rf01)
		{
			if (Rf01 != m_notify)
			{
				if (Rf01 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_notify);
			}
		}

		[SpecialName]
		public void q9Z6(w2TA Sx6b)
		{
			if (Sx6b != m_OlivaPending)
			{
				if (Sx6b != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_OlivaPending);
			}
		}

		[SpecialName]
		public void Lo7d(d1D9 w4ZX)
		{
			if (w4ZX != m_Pending)
			{
				if (w4ZX != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_Pending);
			}
		}

		[SpecialName]
		public void r9M1(Ee60 Tb73)
		{
			if (Tb73 != m_Reschedule)
			{
				if (Tb73 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_Reschedule);
			}
		}

		[SpecialName]
		public void Lb41(Cb91 m8A2)
		{
			if (m8A2 != m_Schedule)
			{
				if (m8A2 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_Schedule);
			}
		}

		[SpecialName]
		public void j0RA(s9R8 m0CN)
		{
			if (m0CN != m_SetSchedule)
			{
				if (m0CN != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_SetSchedule);
			}
		}

		[SpecialName]
		public void y9PH(Td41 Zo49)
		{
			if (Zo49 != m_Student)
			{
				if (Zo49 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_Student);
			}
		}

		[SpecialName]
		public void Tr2y(Tx0d Qb0o)
		{
			if (Qb0o != m_T1Question)
			{
				if (Qb0o != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_T1Question);
			}
		}

		[SpecialName]
		public void Hd62(Ab7z i3ED)
		{
			if (i3ED != m_T4Question)
			{
				if (i3ED != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_T4Question);
			}
		}

		[SpecialName]
		public void f1KP(Aw27 Cd79)
		{
			if (Cd79 != m_ViewSchedule)
			{
				if (Cd79 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				k7NZ(ref m_ViewSchedule);
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Jn6i
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Xd56(object Jr3i)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Jr3i));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Wd0y()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type k0LW()
		{
			return typeof(Jn6i);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string o3Z1()
		{
			return base.ToString();
		}

		private static Po35 Jz1x<Po35>(Po35 c6HX) where Po35 : new()
		{
			if (c6HX == null)
			{
				return new Po35();
			}
			return c6HX;
		}

		private void i7GC<c2X0>(ref c2X0 Lg35)
		{
			Lg35 = default(c2X0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jn6i()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Cr4w<Sr1w> where Sr1w : new()
	{
		[ThreadStatic]
		private static Sr1w m_ThreadStaticValue;

		[SpecialName]
		internal Sr1w Hi2c()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new Sr1w();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cr4w()
		{
		}
	}

	private static readonly Cr4w<Hs1d> m_ComputerObjectProvider = new Cr4w<Hs1d>();

	private static readonly Cr4w<t9XY> m_AppObjectProvider = new Cr4w<t9XY>();

	private static readonly Cr4w<User> m_UserObjectProvider = new Cr4w<User>();

	private static Cr4w<Bm1r> m_MyFormsObjectProvider = new Cr4w<Bm1r>();

	private static readonly Cr4w<Jn6i> m_MyWebServicesObjectProvider = new Cr4w<Jn6i>();

	[HelpKeyword("My.Computer")]
	internal static Hs1d Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static t9XY Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static Bm1r Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static Jn6i WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
