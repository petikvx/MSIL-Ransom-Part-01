using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Co2;
using Gi23;
using Lm9e;
using Lq12;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Yo17;
using d4K;
using f4G;
using i4N3;
using k1B;
using k9W;
using n8G;
using q7Y0;
using s7YR;
using y3Z6;
using y7R;
using y8SN;
using z6P5;
using z7F;

namespace Yt3k;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class Eo05
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Bg79
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x4F m_Decision;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ry8 m_Faculty;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jp0 m_History;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ly3 m_JimenezPending;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tj4 m_JimenezSchedule;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y5A7 m_Login;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f1PK m_notify;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d1H6 m_OlivaPending;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mf15 m_Pending;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b0X2 m_Reschedule;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dp84 m_Schedule;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i9S4 m_SetSchedule;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Da2i m_Student;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i6G m_T1Question;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s8G m_T4Question;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g9Q m_ViewSchedule;

		private static p5MN j8H3<p5MN>(p5MN o1SP) where p5MN : Form, new()
		{
			if (o1SP == null || ((Control)o1SP).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(p5MN)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(p5MN), null);
				try
				{
					return new p5MN();
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
					m_FormBeingCreated.Remove(typeof(p5MN));
				}
			}
			return o1SP;
		}

		private void Tb7a<k7QH>(ref k7QH Mr39) where k7QH : Form
		{
			((Component)Mr39).Dispose();
			Mr39 = default(k7QH);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bg79()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool b0SB(object Xp4k)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Xp4k));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Gb5n()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type s9CW()
		{
			return typeof(Bg79);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string b5J7()
		{
			return base.ToString();
		}

		[SpecialName]
		public x4F Fj8g()
		{
			m_Decision = j8H3(m_Decision);
			return m_Decision;
		}

		[SpecialName]
		public Ry8 Rb03()
		{
			m_Faculty = j8H3(m_Faculty);
			return m_Faculty;
		}

		[SpecialName]
		public Jp0 t3PA()
		{
			m_History = j8H3(m_History);
			return m_History;
		}

		[SpecialName]
		public Ly3 Rg3a()
		{
			m_JimenezPending = j8H3(m_JimenezPending);
			return m_JimenezPending;
		}

		[SpecialName]
		public Tj4 Jd6k()
		{
			m_JimenezSchedule = j8H3(m_JimenezSchedule);
			return m_JimenezSchedule;
		}

		[SpecialName]
		public y5A7 Hp69()
		{
			m_Login = j8H3(m_Login);
			return m_Login;
		}

		[SpecialName]
		public f1PK Pe60()
		{
			m_notify = j8H3(m_notify);
			return m_notify;
		}

		[SpecialName]
		public d1H6 Xw90()
		{
			m_OlivaPending = j8H3(m_OlivaPending);
			return m_OlivaPending;
		}

		[SpecialName]
		public Mf15 c5BS()
		{
			m_Pending = j8H3(m_Pending);
			return m_Pending;
		}

		[SpecialName]
		public b0X2 k0M4()
		{
			m_Reschedule = j8H3(m_Reschedule);
			return m_Reschedule;
		}

		[SpecialName]
		public Dp84 Ze2o()
		{
			m_Schedule = j8H3(m_Schedule);
			return m_Schedule;
		}

		[SpecialName]
		public i9S4 a2WZ()
		{
			m_SetSchedule = j8H3(m_SetSchedule);
			return m_SetSchedule;
		}

		[SpecialName]
		public Da2i Tk5w()
		{
			m_Student = j8H3(m_Student);
			return m_Student;
		}

		[SpecialName]
		public i6G f3D7()
		{
			m_T1Question = j8H3(m_T1Question);
			return m_T1Question;
		}

		[SpecialName]
		public s8G Ji57()
		{
			m_T4Question = j8H3(m_T4Question);
			return m_T4Question;
		}

		[SpecialName]
		public g9Q Rc13()
		{
			m_ViewSchedule = j8H3(m_ViewSchedule);
			return m_ViewSchedule;
		}

		[SpecialName]
		public void p3A7(x4F Af09)
		{
			if (Af09 != m_Decision)
			{
				if (Af09 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_Decision);
			}
		}

		[SpecialName]
		public void Xj8p(Ry8 t9LH)
		{
			if (t9LH != m_Faculty)
			{
				if (t9LH != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_Faculty);
			}
		}

		[SpecialName]
		public void r1X2(Jp0 j3X8)
		{
			if (j3X8 != m_History)
			{
				if (j3X8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_History);
			}
		}

		[SpecialName]
		public void Bq7i(Ly3 Hi91)
		{
			if (Hi91 != m_JimenezPending)
			{
				if (Hi91 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_JimenezPending);
			}
		}

		[SpecialName]
		public void Wm7y(Tj4 m6R1)
		{
			if (m6R1 != m_JimenezSchedule)
			{
				if (m6R1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_JimenezSchedule);
			}
		}

		[SpecialName]
		public void y0WQ(y5A7 Sg4k)
		{
			if (Sg4k != m_Login)
			{
				if (Sg4k != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_Login);
			}
		}

		[SpecialName]
		public void w8SW(f1PK k0QY)
		{
			if (k0QY != m_notify)
			{
				if (k0QY != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_notify);
			}
		}

		[SpecialName]
		public void Ga61(d1H6 q6M1)
		{
			if (q6M1 != m_OlivaPending)
			{
				if (q6M1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_OlivaPending);
			}
		}

		[SpecialName]
		public void d2R7(Mf15 x1RZ)
		{
			if (x1RZ != m_Pending)
			{
				if (x1RZ != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_Pending);
			}
		}

		[SpecialName]
		public void k4JQ(b0X2 Fs5g)
		{
			if (Fs5g != m_Reschedule)
			{
				if (Fs5g != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_Reschedule);
			}
		}

		[SpecialName]
		public void o2RA(Dp84 Sc5g)
		{
			if (Sc5g != m_Schedule)
			{
				if (Sc5g != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_Schedule);
			}
		}

		[SpecialName]
		public void y4MX(i9S4 b5XE)
		{
			if (b5XE != m_SetSchedule)
			{
				if (b5XE != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_SetSchedule);
			}
		}

		[SpecialName]
		public void Zf9k(Da2i Eg74)
		{
			if (Eg74 != m_Student)
			{
				if (Eg74 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_Student);
			}
		}

		[SpecialName]
		public void Jm6p(i6G Ej2b)
		{
			if (Ej2b != m_T1Question)
			{
				if (Ej2b != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_T1Question);
			}
		}

		[SpecialName]
		public void Db4e(s8G Gt51)
		{
			if (Gt51 != m_T4Question)
			{
				if (Gt51 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_T4Question);
			}
		}

		[SpecialName]
		public void p2R7(g9Q Ho01)
		{
			if (Ho01 != m_ViewSchedule)
			{
				if (Ho01 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Tb7a(ref m_ViewSchedule);
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Gz1m
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool d6D0(object Cj1r)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Cj1r));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Cp4g()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type z3CJ()
		{
			return typeof(Gz1m);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Tk3w()
		{
			return base.ToString();
		}

		private static a6X4 y8JF<a6X4>(a6X4 Mj72) where a6X4 : new()
		{
			if (Mj72 == null)
			{
				return new a6X4();
			}
			return Mj72;
		}

		private void Qf8d<p8SJ>(ref p8SJ Lq5s)
		{
			Lq5s = default(p8SJ);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gz1m()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class c8G4<e0DA> where e0DA : new()
	{
		[ThreadStatic]
		private static e0DA m_ThreadStaticValue;

		[SpecialName]
		internal e0DA j7HW()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new e0DA();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c8G4()
		{
		}
	}

	private static readonly c8G4<Ac08> m_ComputerObjectProvider = new c8G4<Ac08>();

	private static readonly c8G4<e2PD> m_AppObjectProvider = new c8G4<e2PD>();

	private static readonly c8G4<User> m_UserObjectProvider = new c8G4<User>();

	private static c8G4<Bg79> m_MyFormsObjectProvider = new c8G4<Bg79>();

	private static readonly c8G4<Gz1m> m_MyWebServicesObjectProvider = new c8G4<Gz1m>();

	[HelpKeyword("My.Computer")]
	internal static Ac08 Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static e2PD Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static Bg79 Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static Gz1m WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
