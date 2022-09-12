using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using An0z;
using Ay2i;
using Bb8;
using Em42;
using Fe9;
using Ge3y;
using Kb5c;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Ms7;
using Pz08;
using Qz2;
using Ti4j;
using Tm7;
using Wa6;
using Wp86;
using Xk4;
using Ze9;
using a6N1;
using b8HP;
using c1X8;
using e0TX;
using e9QR;
using f0F;
using f0S;
using f0W8;
using f4L;
using f8HN;
using f8M;
using g7R;
using n2G9;
using n8S1;
using q2Z7;
using w1G9;
using w1SK;
using w5PK;

namespace Hr4g;

[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class Fo9c
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Mc80
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wf1a m_AddCustomer1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m6Q3 m_AddCustomer2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x2P1 m_AddCustomer3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dq2a m_AddCustomer4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Eq83 m_Cinema1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cn9r m_Cinema2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gi9b m_Cinema3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d2QN m_Cinema4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w9Q m_Customers1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p3H m_Customers2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w7Z m_Customers3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lc1 m_Customers4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public r6C m_LoginInfo;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gz39 m_Menu_Admin;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public So0 m_Menu_Visitor;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qp0w m_MenuVisitor;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Le2f m_MoviesSynopsis2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bj21 m_MovieSynopsis1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cm80 m_MovieSynopsis3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lj98 m_MovieSynopsis4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Db1a m_Receipt1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k9WG m_Receipt2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hj3 m_Receipt3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Yd2 m_Receipt4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jg0 m_ReservedSeats;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hi8 m_ReservedSeats2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y9M m_ReservedSeats3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w0A m_ReservedSeats4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m8Q m_Trailer_1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wj1q m_Trailer_2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xc2g m_Trailer_3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tr68 m_Trailer_4;

		private static f8L1 j5LY<f8L1>(f8L1 La05) where f8L1 : Form, new()
		{
			if (La05 == null || ((Control)La05).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(f8L1)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(f8L1), null);
				try
				{
					return new f8L1();
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
					m_FormBeingCreated.Remove(typeof(f8L1));
				}
			}
			return La05;
		}

		private void Mb8a<Jc67>(ref Jc67 d4AK) where Jc67 : Form
		{
			((Component)d4AK).Dispose();
			d4AK = default(Jc67);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mc80()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool i5LX(object Gp25)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Gp25));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Kw4y()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type t0TP()
		{
			return typeof(Mc80);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Gb3q()
		{
			return base.ToString();
		}

		[SpecialName]
		public Wf1a b1GX()
		{
			m_AddCustomer1 = j5LY(m_AddCustomer1);
			return m_AddCustomer1;
		}

		[SpecialName]
		public m6Q3 Pt86()
		{
			m_AddCustomer2 = j5LY(m_AddCustomer2);
			return m_AddCustomer2;
		}

		[SpecialName]
		public x2P1 q1P5()
		{
			m_AddCustomer3 = j5LY(m_AddCustomer3);
			return m_AddCustomer3;
		}

		[SpecialName]
		public Dq2a f5DJ()
		{
			m_AddCustomer4 = j5LY(m_AddCustomer4);
			return m_AddCustomer4;
		}

		[SpecialName]
		public Eq83 q2Z4()
		{
			m_Cinema1 = j5LY(m_Cinema1);
			return m_Cinema1;
		}

		[SpecialName]
		public Cn9r Te4m()
		{
			m_Cinema2 = j5LY(m_Cinema2);
			return m_Cinema2;
		}

		[SpecialName]
		public Gi9b z1PZ()
		{
			m_Cinema3 = j5LY(m_Cinema3);
			return m_Cinema3;
		}

		[SpecialName]
		public d2QN j3E6()
		{
			m_Cinema4 = j5LY(m_Cinema4);
			return m_Cinema4;
		}

		[SpecialName]
		public w9Q j5BK()
		{
			m_Customers1 = j5LY(m_Customers1);
			return m_Customers1;
		}

		[SpecialName]
		public p3H n7TM()
		{
			m_Customers2 = j5LY(m_Customers2);
			return m_Customers2;
		}

		[SpecialName]
		public w7Z Qy92()
		{
			m_Customers3 = j5LY(m_Customers3);
			return m_Customers3;
		}

		[SpecialName]
		public Lc1 e5C6()
		{
			m_Customers4 = j5LY(m_Customers4);
			return m_Customers4;
		}

		[SpecialName]
		public r6C o5JW()
		{
			m_LoginInfo = j5LY(m_LoginInfo);
			return m_LoginInfo;
		}

		[SpecialName]
		public Gz39 r0QF()
		{
			m_Menu_Admin = j5LY(m_Menu_Admin);
			return m_Menu_Admin;
		}

		[SpecialName]
		public So0 z0XA()
		{
			m_Menu_Visitor = j5LY(m_Menu_Visitor);
			return m_Menu_Visitor;
		}

		[SpecialName]
		public Qp0w Cy1g()
		{
			m_MenuVisitor = j5LY(m_MenuVisitor);
			return m_MenuVisitor;
		}

		[SpecialName]
		public Le2f Ts6d()
		{
			m_MoviesSynopsis2 = j5LY(m_MoviesSynopsis2);
			return m_MoviesSynopsis2;
		}

		[SpecialName]
		public Bj21 p9SP()
		{
			m_MovieSynopsis1 = j5LY(m_MovieSynopsis1);
			return m_MovieSynopsis1;
		}

		[SpecialName]
		public Cm80 Sc47()
		{
			m_MovieSynopsis3 = j5LY(m_MovieSynopsis3);
			return m_MovieSynopsis3;
		}

		[SpecialName]
		public Lj98 m8RM()
		{
			m_MovieSynopsis4 = j5LY(m_MovieSynopsis4);
			return m_MovieSynopsis4;
		}

		[SpecialName]
		public Db1a s7TY()
		{
			m_Receipt1 = j5LY(m_Receipt1);
			return m_Receipt1;
		}

		[SpecialName]
		public k9WG Rp3q()
		{
			m_Receipt2 = j5LY(m_Receipt2);
			return m_Receipt2;
		}

		[SpecialName]
		public Hj3 Yr2j()
		{
			m_Receipt3 = j5LY(m_Receipt3);
			return m_Receipt3;
		}

		[SpecialName]
		public Yd2 Ao7q()
		{
			m_Receipt4 = j5LY(m_Receipt4);
			return m_Receipt4;
		}

		[SpecialName]
		public Jg0 z4T1()
		{
			m_ReservedSeats = j5LY(m_ReservedSeats);
			return m_ReservedSeats;
		}

		[SpecialName]
		public Hi8 Wc9w()
		{
			m_ReservedSeats2 = j5LY(m_ReservedSeats2);
			return m_ReservedSeats2;
		}

		[SpecialName]
		public y9M r5JY()
		{
			m_ReservedSeats3 = j5LY(m_ReservedSeats3);
			return m_ReservedSeats3;
		}

		[SpecialName]
		public w0A Pg0q()
		{
			m_ReservedSeats4 = j5LY(m_ReservedSeats4);
			return m_ReservedSeats4;
		}

		[SpecialName]
		public m8Q Ma60()
		{
			m_Trailer_1 = j5LY(m_Trailer_1);
			return m_Trailer_1;
		}

		[SpecialName]
		public Wj1q Tq53()
		{
			m_Trailer_2 = j5LY(m_Trailer_2);
			return m_Trailer_2;
		}

		[SpecialName]
		public Xc2g i3Y1()
		{
			m_Trailer_3 = j5LY(m_Trailer_3);
			return m_Trailer_3;
		}

		[SpecialName]
		public Tr68 Ho6i()
		{
			m_Trailer_4 = j5LY(m_Trailer_4);
			return m_Trailer_4;
		}

		[SpecialName]
		public void Rw2m(Wf1a q9KE)
		{
			if (q9KE != m_AddCustomer1)
			{
				if (q9KE != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_AddCustomer1);
			}
		}

		[SpecialName]
		public void n3RZ(m6Q3 Wb3z)
		{
			if (Wb3z != m_AddCustomer2)
			{
				if (Wb3z != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_AddCustomer2);
			}
		}

		[SpecialName]
		public void t4S2(x2P1 g4H2)
		{
			if (g4H2 != m_AddCustomer3)
			{
				if (g4H2 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_AddCustomer3);
			}
		}

		[SpecialName]
		public void Cn09(Dq2a Tm7j)
		{
			if (Tm7j != m_AddCustomer4)
			{
				if (Tm7j != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_AddCustomer4);
			}
		}

		[SpecialName]
		public void Jj3p(Eq83 Lc5z)
		{
			if (Lc5z != m_Cinema1)
			{
				if (Lc5z != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Cinema1);
			}
		}

		[SpecialName]
		public void e7S1(Cn9r f8Z9)
		{
			if (f8Z9 != m_Cinema2)
			{
				if (f8Z9 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Cinema2);
			}
		}

		[SpecialName]
		public void z8XC(Gi9b Gz26)
		{
			if (Gz26 != m_Cinema3)
			{
				if (Gz26 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Cinema3);
			}
		}

		[SpecialName]
		public void Hn7g(d2QN p3SE)
		{
			if (p3SE != m_Cinema4)
			{
				if (p3SE != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Cinema4);
			}
		}

		[SpecialName]
		public void Ee6j(w9Q e6B8)
		{
			if (e6B8 != m_Customers1)
			{
				if (e6B8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Customers1);
			}
		}

		[SpecialName]
		public void n1M3(p3H Jx78)
		{
			if (Jx78 != m_Customers2)
			{
				if (Jx78 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Customers2);
			}
		}

		[SpecialName]
		public void Fm78(w7Z e2YC)
		{
			if (e2YC != m_Customers3)
			{
				if (e2YC != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Customers3);
			}
		}

		[SpecialName]
		public void Lp6a(Lc1 o8X7)
		{
			if (o8X7 != m_Customers4)
			{
				if (o8X7 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Customers4);
			}
		}

		[SpecialName]
		public void Kj56(r6C Pz0b)
		{
			if (Pz0b != m_LoginInfo)
			{
				if (Pz0b != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_LoginInfo);
			}
		}

		[SpecialName]
		public void Xx73(Gz39 Ww9e)
		{
			if (Ww9e != m_Menu_Admin)
			{
				if (Ww9e != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Menu_Admin);
			}
		}

		[SpecialName]
		public void Hw5s(So0 Ge65)
		{
			if (Ge65 != m_Menu_Visitor)
			{
				if (Ge65 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Menu_Visitor);
			}
		}

		[SpecialName]
		public void Rm8s(Qp0w Ha31)
		{
			if (Ha31 != m_MenuVisitor)
			{
				if (Ha31 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_MenuVisitor);
			}
		}

		[SpecialName]
		public void Rm7s(Le2f q8BA)
		{
			if (q8BA != m_MoviesSynopsis2)
			{
				if (q8BA != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_MoviesSynopsis2);
			}
		}

		[SpecialName]
		public void e4N7(Bj21 x1FB)
		{
			if (x1FB != m_MovieSynopsis1)
			{
				if (x1FB != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_MovieSynopsis1);
			}
		}

		[SpecialName]
		public void r3K8(Cm80 Gg2t)
		{
			if (Gg2t != m_MovieSynopsis3)
			{
				if (Gg2t != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_MovieSynopsis3);
			}
		}

		[SpecialName]
		public void p2J0(Lj98 z7G5)
		{
			if (z7G5 != m_MovieSynopsis4)
			{
				if (z7G5 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_MovieSynopsis4);
			}
		}

		[SpecialName]
		public void Lt52(Db1a Dx4f)
		{
			if (Dx4f != m_Receipt1)
			{
				if (Dx4f != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Receipt1);
			}
		}

		[SpecialName]
		public void Gn7m(k9WG Mq10)
		{
			if (Mq10 != m_Receipt2)
			{
				if (Mq10 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Receipt2);
			}
		}

		[SpecialName]
		public void Kb84(Hj3 f2TZ)
		{
			if (f2TZ != m_Receipt3)
			{
				if (f2TZ != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Receipt3);
			}
		}

		[SpecialName]
		public void w7P4(Yd2 Qe9b)
		{
			if (Qe9b != m_Receipt4)
			{
				if (Qe9b != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Receipt4);
			}
		}

		[SpecialName]
		public void Ba8e(Jg0 Rm93)
		{
			if (Rm93 != m_ReservedSeats)
			{
				if (Rm93 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_ReservedSeats);
			}
		}

		[SpecialName]
		public void f1L4(Hi8 t9H8)
		{
			if (t9H8 != m_ReservedSeats2)
			{
				if (t9H8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_ReservedSeats2);
			}
		}

		[SpecialName]
		public void Ep20(y9M Lp4i)
		{
			if (Lp4i != m_ReservedSeats3)
			{
				if (Lp4i != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_ReservedSeats3);
			}
		}

		[SpecialName]
		public void Wr1e(w0A Yf39)
		{
			if (Yf39 != m_ReservedSeats4)
			{
				if (Yf39 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_ReservedSeats4);
			}
		}

		[SpecialName]
		public void d5JX(m8Q n4YL)
		{
			if (n4YL != m_Trailer_1)
			{
				if (n4YL != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Trailer_1);
			}
		}

		[SpecialName]
		public void Cd8s(Wj1q g3DY)
		{
			if (g3DY != m_Trailer_2)
			{
				if (g3DY != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Trailer_2);
			}
		}

		[SpecialName]
		public void Rk0f(Xc2g q7H8)
		{
			if (q7H8 != m_Trailer_3)
			{
				if (q7H8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Trailer_3);
			}
		}

		[SpecialName]
		public void Hw6c(Tr68 We1z)
		{
			if (We1z != m_Trailer_4)
			{
				if (We1z != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Mb8a(ref m_Trailer_4);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Kd7y
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool e3F7(object Lm3f)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Lm3f));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int d4XN()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type i2QL()
		{
			return typeof(Kd7y);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Nc62()
		{
			return base.ToString();
		}

		private static s8W9 Dx7e<s8W9>(s8W9 Dx1n) where s8W9 : new()
		{
			if (Dx1n == null)
			{
				return new s8W9();
			}
			return Dx1n;
		}

		private void n6H4<Nf6d>(ref Nf6d Ns1z)
		{
			Ns1z = default(Nf6d);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kd7y()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Zt4b<r9DH> where r9DH : new()
	{
		[ThreadStatic]
		private static r9DH m_ThreadStaticValue;

		[SpecialName]
		internal r9DH Mw94()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new r9DH();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zt4b()
		{
		}
	}

	private static readonly Zt4b<d3KH> m_ComputerObjectProvider = new Zt4b<d3KH>();

	private static readonly Zt4b<i1TQ> m_AppObjectProvider = new Zt4b<i1TQ>();

	private static readonly Zt4b<User> m_UserObjectProvider = new Zt4b<User>();

	private static Zt4b<Mc80> m_MyFormsObjectProvider = new Zt4b<Mc80>();

	private static readonly Zt4b<Kd7y> m_MyWebServicesObjectProvider = new Zt4b<Kd7y>();

	[HelpKeyword("My.Computer")]
	internal static d3KH Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static i1TQ Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static Mc80 Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static Kd7y WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
