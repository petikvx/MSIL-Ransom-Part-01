using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bk0;
using Cy6;
using Ec0;
using En3;
using Lg3;
using Lt8;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Ni0b;
using Pm02;
using Qz7;
using Rs7;
using Tg6;
using We1;
using Yn6q;
using a2ZT;
using c5R;
using d1R;
using e8Z;
using f4L7;
using f5S;
using f8K3;
using g1N5;
using g4C0;
using g6HE;
using i9M;
using j7T;
using k4J5;
using m1G9;
using p1RC;
using q2H;
using q3L6;
using r2M;
using r5F;
using w9X;
using y4T;

namespace Dz5;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Mi0
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class y7R
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bj0b m_AddCustomer1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z9RZ m_AddCustomer2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w7Z m_AddCustomer3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d9P m_AddCustomer4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nx5 m_Cinema1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n7F m_Cinema2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n1F m_Cinema3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lb4r m_Cinema4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kn6q m_Customers1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q5W2 m_Customers2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k8R2 m_Customers3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g3A m_Customers4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ws4 m_LoginInfo;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qc0 m_Menu_Admin;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ki3 m_Menu_Visitor;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n9QH m_MenuVisitor;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jy3 m_MoviesSynopsis2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gx1 m_MovieSynopsis1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fy2 m_MovieSynopsis3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t3A m_MovieSynopsis4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e0E m_Receipt1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bp9 m_Receipt2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kx5 m_Receipt3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sd0 m_Receipt4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m1N m_ReservedSeats;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xr2 m_ReservedSeats2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lp23 m_ReservedSeats3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x2LT m_ReservedSeats4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xj5a m_Trailer_1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q4LT m_Trailer_2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lf1 m_Trailer_3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Rd1 m_Trailer_4;

		private static b3A q7H<b3A>(b3A Ki5) where b3A : Form, new()
		{
			if (Ki5 == null || ((Control)Ki5).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(b3A)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(b3A), null);
				try
				{
					return new b3A();
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
					m_FormBeingCreated.Remove(typeof(b3A));
				}
			}
			return Ki5;
		}

		private void d8W<Bn5>(ref Bn5 b2A) where Bn5 : Form
		{
			((Component)b2A).Dispose();
			b2A = default(Bn5);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y7R()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Ge5(object Lf6)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Lf6));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int z3D()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type c0N()
		{
			return typeof(y7R);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Cg0()
		{
			return base.ToString();
		}

		[SpecialName]
		public Bj0b o3T()
		{
			m_AddCustomer1 = q7H(m_AddCustomer1);
			return m_AddCustomer1;
		}

		[SpecialName]
		public z9RZ e0Q()
		{
			m_AddCustomer2 = q7H(m_AddCustomer2);
			return m_AddCustomer2;
		}

		[SpecialName]
		public w7Z Zm2()
		{
			m_AddCustomer3 = q7H(m_AddCustomer3);
			return m_AddCustomer3;
		}

		[SpecialName]
		public d9P o1H()
		{
			m_AddCustomer4 = q7H(m_AddCustomer4);
			return m_AddCustomer4;
		}

		[SpecialName]
		public Nx5 w0M()
		{
			m_Cinema1 = q7H(m_Cinema1);
			return m_Cinema1;
		}

		[SpecialName]
		public n7F n1J()
		{
			m_Cinema2 = q7H(m_Cinema2);
			return m_Cinema2;
		}

		[SpecialName]
		public n1F Cf4()
		{
			m_Cinema3 = q7H(m_Cinema3);
			return m_Cinema3;
		}

		[SpecialName]
		public Lb4r Dx8()
		{
			m_Cinema4 = q7H(m_Cinema4);
			return m_Cinema4;
		}

		[SpecialName]
		public Kn6q i9P()
		{
			m_Customers1 = q7H(m_Customers1);
			return m_Customers1;
		}

		[SpecialName]
		public q5W2 Ke2()
		{
			m_Customers2 = q7H(m_Customers2);
			return m_Customers2;
		}

		[SpecialName]
		public k8R2 t1F()
		{
			m_Customers3 = q7H(m_Customers3);
			return m_Customers3;
		}

		[SpecialName]
		public g3A Jf1()
		{
			m_Customers4 = q7H(m_Customers4);
			return m_Customers4;
		}

		[SpecialName]
		public Ws4 r8Z()
		{
			m_LoginInfo = q7H(m_LoginInfo);
			return m_LoginInfo;
		}

		[SpecialName]
		public Qc0 Ei3()
		{
			m_Menu_Admin = q7H(m_Menu_Admin);
			return m_Menu_Admin;
		}

		[SpecialName]
		public Ki3 My4()
		{
			m_Menu_Visitor = q7H(m_Menu_Visitor);
			return m_Menu_Visitor;
		}

		[SpecialName]
		public n9QH n2P()
		{
			m_MenuVisitor = q7H(m_MenuVisitor);
			return m_MenuVisitor;
		}

		[SpecialName]
		public Jy3 a3F()
		{
			m_MoviesSynopsis2 = q7H(m_MoviesSynopsis2);
			return m_MoviesSynopsis2;
		}

		[SpecialName]
		public Gx1 k6W()
		{
			m_MovieSynopsis1 = q7H(m_MovieSynopsis1);
			return m_MovieSynopsis1;
		}

		[SpecialName]
		public Fy2 Xp8()
		{
			m_MovieSynopsis3 = q7H(m_MovieSynopsis3);
			return m_MovieSynopsis3;
		}

		[SpecialName]
		public t3A k4Y()
		{
			m_MovieSynopsis4 = q7H(m_MovieSynopsis4);
			return m_MovieSynopsis4;
		}

		[SpecialName]
		public e0E Mf1()
		{
			m_Receipt1 = q7H(m_Receipt1);
			return m_Receipt1;
		}

		[SpecialName]
		public Bp9 Sq5()
		{
			m_Receipt2 = q7H(m_Receipt2);
			return m_Receipt2;
		}

		[SpecialName]
		public Kx5 Wx8()
		{
			m_Receipt3 = q7H(m_Receipt3);
			return m_Receipt3;
		}

		[SpecialName]
		public Sd0 Eb0()
		{
			m_Receipt4 = q7H(m_Receipt4);
			return m_Receipt4;
		}

		[SpecialName]
		public m1N d3S()
		{
			m_ReservedSeats = q7H(m_ReservedSeats);
			return m_ReservedSeats;
		}

		[SpecialName]
		public Xr2 Bb6()
		{
			m_ReservedSeats2 = q7H(m_ReservedSeats2);
			return m_ReservedSeats2;
		}

		[SpecialName]
		public Lp23 z7H()
		{
			m_ReservedSeats3 = q7H(m_ReservedSeats3);
			return m_ReservedSeats3;
		}

		[SpecialName]
		public x2LT n3M()
		{
			m_ReservedSeats4 = q7H(m_ReservedSeats4);
			return m_ReservedSeats4;
		}

		[SpecialName]
		public Xj5a x4D()
		{
			m_Trailer_1 = q7H(m_Trailer_1);
			return m_Trailer_1;
		}

		[SpecialName]
		public q4LT Sz2()
		{
			m_Trailer_2 = q7H(m_Trailer_2);
			return m_Trailer_2;
		}

		[SpecialName]
		public Lf1 Aj7()
		{
			m_Trailer_3 = q7H(m_Trailer_3);
			return m_Trailer_3;
		}

		[SpecialName]
		public Rd1 q1E()
		{
			m_Trailer_4 = q7H(m_Trailer_4);
			return m_Trailer_4;
		}

		[SpecialName]
		public void Ps3(Bj0b i0J)
		{
			if (i0J != m_AddCustomer1)
			{
				if (i0J != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_AddCustomer1);
			}
		}

		[SpecialName]
		public void Ad4(z9RZ Eo4)
		{
			if (Eo4 != m_AddCustomer2)
			{
				if (Eo4 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_AddCustomer2);
			}
		}

		[SpecialName]
		public void x9M(w7Z i7J)
		{
			if (i7J != m_AddCustomer3)
			{
				if (i7J != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_AddCustomer3);
			}
		}

		[SpecialName]
		public void t7N(d9P Ct8)
		{
			if (Ct8 != m_AddCustomer4)
			{
				if (Ct8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_AddCustomer4);
			}
		}

		[SpecialName]
		public void Do2(Nx5 m8J)
		{
			if (m8J != m_Cinema1)
			{
				if (m8J != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Cinema1);
			}
		}

		[SpecialName]
		public void Mq2(n7F Qo4)
		{
			if (Qo4 != m_Cinema2)
			{
				if (Qo4 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Cinema2);
			}
		}

		[SpecialName]
		public void Kb4(n1F p9L)
		{
			if (p9L != m_Cinema3)
			{
				if (p9L != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Cinema3);
			}
		}

		[SpecialName]
		public void Ka5(Lb4r e8D)
		{
			if (e8D != m_Cinema4)
			{
				if (e8D != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Cinema4);
			}
		}

		[SpecialName]
		public void w3N(Kn6q Et8)
		{
			if (Et8 != m_Customers1)
			{
				if (Et8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Customers1);
			}
		}

		[SpecialName]
		public void Lw9(q5W2 p6L)
		{
			if (p6L != m_Customers2)
			{
				if (p6L != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Customers2);
			}
		}

		[SpecialName]
		public void b8W(k8R2 Eo1)
		{
			if (Eo1 != m_Customers3)
			{
				if (Eo1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Customers3);
			}
		}

		[SpecialName]
		public void g3E(g3A y8F)
		{
			if (y8F != m_Customers4)
			{
				if (y8F != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Customers4);
			}
		}

		[SpecialName]
		public void e5Q(Ws4 a8N)
		{
			if (a8N != m_LoginInfo)
			{
				if (a8N != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_LoginInfo);
			}
		}

		[SpecialName]
		public void Bc6(Qc0 Tf9)
		{
			if (Tf9 != m_Menu_Admin)
			{
				if (Tf9 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Menu_Admin);
			}
		}

		[SpecialName]
		public void y6K(Ki3 g4L)
		{
			if (g4L != m_Menu_Visitor)
			{
				if (g4L != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Menu_Visitor);
			}
		}

		[SpecialName]
		public void Ht3(n9QH Gr4)
		{
			if (Gr4 != m_MenuVisitor)
			{
				if (Gr4 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_MenuVisitor);
			}
		}

		[SpecialName]
		public void Fn0(Jy3 Jm3)
		{
			if (Jm3 != m_MoviesSynopsis2)
			{
				if (Jm3 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_MoviesSynopsis2);
			}
		}

		[SpecialName]
		public void Xc9(Gx1 Dz7)
		{
			if (Dz7 != m_MovieSynopsis1)
			{
				if (Dz7 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_MovieSynopsis1);
			}
		}

		[SpecialName]
		public void Hz0(Fy2 w6W)
		{
			if (w6W != m_MovieSynopsis3)
			{
				if (w6W != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_MovieSynopsis3);
			}
		}

		[SpecialName]
		public void Xj6(t3A Tq5)
		{
			if (Tq5 != m_MovieSynopsis4)
			{
				if (Tq5 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_MovieSynopsis4);
			}
		}

		[SpecialName]
		public void z7N(e0E b4W)
		{
			if (b4W != m_Receipt1)
			{
				if (b4W != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Receipt1);
			}
		}

		[SpecialName]
		public void Jx6(Bp9 Gn4)
		{
			if (Gn4 != m_Receipt2)
			{
				if (Gn4 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Receipt2);
			}
		}

		[SpecialName]
		public void Wj9(Kx5 t8N)
		{
			if (t8N != m_Receipt3)
			{
				if (t8N != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Receipt3);
			}
		}

		[SpecialName]
		public void Qc0(Sd0 Jy9)
		{
			if (Jy9 != m_Receipt4)
			{
				if (Jy9 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Receipt4);
			}
		}

		[SpecialName]
		public void Hm3(m1N k7A)
		{
			if (k7A != m_ReservedSeats)
			{
				if (k7A != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_ReservedSeats);
			}
		}

		[SpecialName]
		public void o6L(Xr2 z8D)
		{
			if (z8D != m_ReservedSeats2)
			{
				if (z8D != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_ReservedSeats2);
			}
		}

		[SpecialName]
		public void p1W(Lp23 Si6)
		{
			if (Si6 != m_ReservedSeats3)
			{
				if (Si6 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_ReservedSeats3);
			}
		}

		[SpecialName]
		public void t1E(x2LT Ad4)
		{
			if (Ad4 != m_ReservedSeats4)
			{
				if (Ad4 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_ReservedSeats4);
			}
		}

		[SpecialName]
		public void i3Z(Xj5a y3N)
		{
			if (y3N != m_Trailer_1)
			{
				if (y3N != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Trailer_1);
			}
		}

		[SpecialName]
		public void Fq5(q4LT g7Q)
		{
			if (g7Q != m_Trailer_2)
			{
				if (g7Q != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Trailer_2);
			}
		}

		[SpecialName]
		public void n0Y(Lf1 i7N)
		{
			if (i7N != m_Trailer_3)
			{
				if (i7N != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Trailer_3);
			}
		}

		[SpecialName]
		public void b1Q(Rd1 Ya3)
		{
			if (Ya3 != m_Trailer_4)
			{
				if (Ya3 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				d8W(ref m_Trailer_4);
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Ao6
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool a3B(object e8R)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(e8R));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int d7N()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type q3C()
		{
			return typeof(Ao6);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Cg1()
		{
			return base.ToString();
		}

		private static Lf9 m2P<Lf9>(Lf9 Zq6) where Lf9 : new()
		{
			if (Zq6 == null)
			{
				return new Lf9();
			}
			return Zq6;
		}

		private void Tm4<d3K>(ref d3K Na6)
		{
			Na6 = default(d3K);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ao6()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Hm5<m9D> where m9D : new()
	{
		[ThreadStatic]
		private static m9D m_ThreadStaticValue;

		[SpecialName]
		internal m9D Gq8()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new m9D();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hm5()
		{
		}
	}

	private static readonly Hm5<Da0t> m_ComputerObjectProvider = new Hm5<Da0t>();

	private static readonly Hm5<j7Q3> m_AppObjectProvider = new Hm5<j7Q3>();

	private static readonly Hm5<User> m_UserObjectProvider = new Hm5<User>();

	private static Hm5<y7R> m_MyFormsObjectProvider = new Hm5<y7R>();

	private static readonly Hm5<Ao6> m_MyWebServicesObjectProvider = new Hm5<Ao6>();

	[HelpKeyword("My.Computer")]
	internal static Da0t Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static j7Q3 Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static y7R Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static Ao6 WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
