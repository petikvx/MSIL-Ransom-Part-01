using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Hb3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Mr2;
using i3W;
using m5J7;
using n3EC;
using p9SE;
using r6MX;
using w5P;
using x7KX;
using y0Y;
using y5E6;
using z7W;

namespace Nn5;

[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class i7X
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class o8E
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g2J m_Form10;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e2A m_Form11;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wf6 m_Form2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k8M5 m_Form3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mn97 m_Form4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ls68 m_Form6;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pw8s m_Form7;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public To59 m_Form8;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q7F1 m_Form9;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z1E m_welcome_pg;

		private static b7H i6Y<b7H>(b7H Ai4) where b7H : Form, new()
		{
			if (Ai4 == null || ((Control)Ai4).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(b7H)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(b7H), null);
				try
				{
					return new b7H();
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
					m_FormBeingCreated.Remove(typeof(b7H));
				}
			}
			return Ai4;
		}

		private void Dr7<Ke5>(ref Ke5 q9Z) where Ke5 : Form
		{
			((Component)q9Z).Dispose();
			q9Z = default(Ke5);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o8E()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Zq6(object r2K)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(r2K));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Ww0()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Ze8()
		{
			return typeof(o8E);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Ry1()
		{
			return base.ToString();
		}

		[SpecialName]
		public g2J k1G()
		{
			m_Form10 = i6Y(m_Form10);
			return m_Form10;
		}

		[SpecialName]
		public e2A p7Z()
		{
			m_Form11 = i6Y(m_Form11);
			return m_Form11;
		}

		[SpecialName]
		public Wf6 Cx2()
		{
			m_Form2 = i6Y(m_Form2);
			return m_Form2;
		}

		[SpecialName]
		public k8M5 y8C()
		{
			m_Form3 = i6Y(m_Form3);
			return m_Form3;
		}

		[SpecialName]
		public Mn97 Ek0()
		{
			m_Form4 = i6Y(m_Form4);
			return m_Form4;
		}

		[SpecialName]
		public Ls68 Ly7()
		{
			m_Form6 = i6Y(m_Form6);
			return m_Form6;
		}

		[SpecialName]
		public Pw8s Ny3()
		{
			m_Form7 = i6Y(m_Form7);
			return m_Form7;
		}

		[SpecialName]
		public To59 Fk6()
		{
			m_Form8 = i6Y(m_Form8);
			return m_Form8;
		}

		[SpecialName]
		public q7F1 Yn9()
		{
			m_Form9 = i6Y(m_Form9);
			return m_Form9;
		}

		[SpecialName]
		public z1E Ds7()
		{
			m_welcome_pg = i6Y(m_welcome_pg);
			return m_welcome_pg;
		}

		[SpecialName]
		public void He3(g2J o8A)
		{
			if (o8A != m_Form10)
			{
				if (o8A != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Dr7(ref m_Form10);
			}
		}

		[SpecialName]
		public void x0R(e2A En3)
		{
			if (En3 != m_Form11)
			{
				if (En3 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Dr7(ref m_Form11);
			}
		}

		[SpecialName]
		public void x0M(Wf6 Fj7)
		{
			if (Fj7 != m_Form2)
			{
				if (Fj7 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Dr7(ref m_Form2);
			}
		}

		[SpecialName]
		public void Ls4(k8M5 o5Y)
		{
			if (o5Y != m_Form3)
			{
				if (o5Y != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Dr7(ref m_Form3);
			}
		}

		[SpecialName]
		public void o9N(Mn97 k8P)
		{
			if (k8P != m_Form4)
			{
				if (k8P != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Dr7(ref m_Form4);
			}
		}

		[SpecialName]
		public void r2M(Ls68 m3T)
		{
			if (m3T != m_Form6)
			{
				if (m3T != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Dr7(ref m_Form6);
			}
		}

		[SpecialName]
		public void So5(Pw8s a9G)
		{
			if (a9G != m_Form7)
			{
				if (a9G != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Dr7(ref m_Form7);
			}
		}

		[SpecialName]
		public void Lf4(To59 t4C)
		{
			if (t4C != m_Form8)
			{
				if (t4C != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Dr7(ref m_Form8);
			}
		}

		[SpecialName]
		public void Bw6(q7F1 q1N)
		{
			if (q1N != m_Form9)
			{
				if (q1N != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Dr7(ref m_Form9);
			}
		}

		[SpecialName]
		public void Ye2(z1E Km2)
		{
			if (Km2 != m_welcome_pg)
			{
				if (Km2 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Dr7(ref m_welcome_pg);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Nn6
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool n0K(object w8A)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(w8A));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Qo7()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Gr2()
		{
			return typeof(Nn6);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Ho8()
		{
			return base.ToString();
		}

		private static Lr2 j3Z<Lr2>(Lr2 j7H) where Lr2 : new()
		{
			if (j7H == null)
			{
				return new Lr2();
			}
			return j7H;
		}

		private void f1J<i5K>(ref i5K x3H)
		{
			x3H = default(i5K);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nn6()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Fn8<g9Y> where g9Y : new()
	{
		[ThreadStatic]
		private static g9Y m_ThreadStaticValue;

		[SpecialName]
		internal g9Y Mw0()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new g9Y();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fn8()
		{
		}
	}

	private static readonly Fn8<t5N> m_ComputerObjectProvider = new Fn8<t5N>();

	private static readonly Fn8<Mi5> m_AppObjectProvider = new Fn8<Mi5>();

	private static readonly Fn8<User> m_UserObjectProvider = new Fn8<User>();

	private static Fn8<o8E> m_MyFormsObjectProvider = new Fn8<o8E>();

	private static readonly Fn8<Nn6> m_MyWebServicesObjectProvider = new Fn8<Nn6>();

	[HelpKeyword("My.Computer")]
	internal static t5N Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static Mi5 Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static o8E Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static Nn6 WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
