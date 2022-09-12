using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Ck2;
using Je8;
using Ky21;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;
using Pb3;
using Rk2t;
using Se3;
using Sy3;
using d3BQ;
using e8W;
using g6HS;
using i1W;
using k3WY;
using k9F;
using o8EK;
using s5R;
using t6C;
using y8XC;

namespace j3W;

[HideModuleName]
[StandardModule]
internal sealed class b8D
{
	[MyGroupCollection("System.Windows.Window", "Create__Instance__", "Dispose__Instance__", "My.MyWpfExtenstionModule.Windows")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Xq6
	{
		[ThreadStatic]
		private static Hashtable s_WindowBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ko1 m_Appointment;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cs7 m_BillingDetails;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xt9 m_DoctorsRegister;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a3P4 m_Login;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t0Q m_MainNavigation;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c4L m_MainWindow;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Te1 m_NurseDetails;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wi4 m_PatientDiagnosis;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public j3Q6 m_PatientsRegistration;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mj7 m_Receipt1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p0R1 m_Register_otherStaff;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hx4b m_RegisterUser;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nq6 m_ReportViewer;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d3NW m_test;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gy6b m_WardAdmission;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hg7a m_wardDetails;

		private static r3X Nm5<r3X>(r3X i5Y) where r3X : Window, new()
		{
			if (i5Y == null)
			{
				if (s_WindowBeingCreated != null)
				{
					if (s_WindowBeingCreated.ContainsKey(typeof(r3X)))
					{
						throw new InvalidOperationException("The window cannot be accessed via My.Windows from the Window constructor.");
					}
				}
				else
				{
					s_WindowBeingCreated = new Hashtable();
				}
				s_WindowBeingCreated.Add(typeof(r3X), null);
				return new r3X();
			}
			return i5Y;
		}

		private void Az2<Eg9>(ref Eg9 i7G) where Eg9 : Window
		{
			i7G = default(Eg9);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xq6()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Ac9(object Ek1)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Ek1));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Mm5()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Am4()
		{
			return typeof(Xq6);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Ar4()
		{
			return base.ToString();
		}

		[SpecialName]
		public Ko1 m3A()
		{
			m_Appointment = Nm5(m_Appointment);
			return m_Appointment;
		}

		[SpecialName]
		public Cs7 s4R()
		{
			m_BillingDetails = Nm5(m_BillingDetails);
			return m_BillingDetails;
		}

		[SpecialName]
		public Xt9 j8G()
		{
			m_DoctorsRegister = Nm5(m_DoctorsRegister);
			return m_DoctorsRegister;
		}

		[SpecialName]
		public a3P4 Hf8()
		{
			m_Login = Nm5(m_Login);
			return m_Login;
		}

		[SpecialName]
		public t0Q Qi5()
		{
			m_MainNavigation = Nm5(m_MainNavigation);
			return m_MainNavigation;
		}

		[SpecialName]
		public c4L x8P()
		{
			m_MainWindow = Nm5(m_MainWindow);
			return m_MainWindow;
		}

		[SpecialName]
		public Te1 d6A()
		{
			m_NurseDetails = Nm5(m_NurseDetails);
			return m_NurseDetails;
		}

		[SpecialName]
		public Wi4 Hq6()
		{
			m_PatientDiagnosis = Nm5(m_PatientDiagnosis);
			return m_PatientDiagnosis;
		}

		[SpecialName]
		public j3Q6 Ks4()
		{
			m_PatientsRegistration = Nm5(m_PatientsRegistration);
			return m_PatientsRegistration;
		}

		[SpecialName]
		public Mj7 Cs5()
		{
			m_Receipt1 = Nm5(m_Receipt1);
			return m_Receipt1;
		}

		[SpecialName]
		public p0R1 Kg4()
		{
			m_Register_otherStaff = Nm5(m_Register_otherStaff);
			return m_Register_otherStaff;
		}

		[SpecialName]
		public Hx4b i8A()
		{
			m_RegisterUser = Nm5(m_RegisterUser);
			return m_RegisterUser;
		}

		[SpecialName]
		public Nq6 Ge2()
		{
			m_ReportViewer = Nm5(m_ReportViewer);
			return m_ReportViewer;
		}

		[SpecialName]
		public d3NW n2L()
		{
			m_test = Nm5(m_test);
			return m_test;
		}

		[SpecialName]
		public Gy6b Do1()
		{
			m_WardAdmission = Nm5(m_WardAdmission);
			return m_WardAdmission;
		}

		[SpecialName]
		public Hg7a g3B()
		{
			m_wardDetails = Nm5(m_wardDetails);
			return m_wardDetails;
		}

		[SpecialName]
		public void Rp8(Ko1 n5A)
		{
			if (n5A != m_Appointment)
			{
				if (n5A != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_Appointment);
			}
		}

		[SpecialName]
		public void k6W(Cs7 s8Z)
		{
			if (s8Z != m_BillingDetails)
			{
				if (s8Z != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_BillingDetails);
			}
		}

		[SpecialName]
		public void i3N(Xt9 p1A)
		{
			if (p1A != m_DoctorsRegister)
			{
				if (p1A != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_DoctorsRegister);
			}
		}

		[SpecialName]
		public void Lk2(a3P4 y9L)
		{
			if (y9L != m_Login)
			{
				if (y9L != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_Login);
			}
		}

		[SpecialName]
		public void Xa5(t0Q Ky9)
		{
			if (Ky9 != m_MainNavigation)
			{
				if (Ky9 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_MainNavigation);
			}
		}

		[SpecialName]
		public void w8D(c4L Wd5)
		{
			if (Wd5 != m_MainWindow)
			{
				if (Wd5 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_MainWindow);
			}
		}

		[SpecialName]
		public void n1G(Te1 p3W)
		{
			if (p3W != m_NurseDetails)
			{
				if (p3W != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_NurseDetails);
			}
		}

		[SpecialName]
		public void f5T(Wi4 i3E)
		{
			if (i3E != m_PatientDiagnosis)
			{
				if (i3E != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_PatientDiagnosis);
			}
		}

		[SpecialName]
		public void Tg0(j3Q6 f6E)
		{
			if (f6E != m_PatientsRegistration)
			{
				if (f6E != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_PatientsRegistration);
			}
		}

		[SpecialName]
		public void Jt5(Mj7 o8N)
		{
			if (o8N != m_Receipt1)
			{
				if (o8N != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_Receipt1);
			}
		}

		[SpecialName]
		public void r9M(p0R1 Yp7)
		{
			if (Yp7 != m_Register_otherStaff)
			{
				if (Yp7 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_Register_otherStaff);
			}
		}

		[SpecialName]
		public void Js3(Hx4b s4L)
		{
			if (s4L != m_RegisterUser)
			{
				if (s4L != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_RegisterUser);
			}
		}

		[SpecialName]
		public void q5L(Nq6 n8A)
		{
			if (n8A != m_ReportViewer)
			{
				if (n8A != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_ReportViewer);
			}
		}

		[SpecialName]
		public void Xs1(d3NW f6B)
		{
			if (f6B != m_test)
			{
				if (f6B != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_test);
			}
		}

		[SpecialName]
		public void p6Q(Gy6b a2T)
		{
			if (a2T != m_WardAdmission)
			{
				if (a2T != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_WardAdmission);
			}
		}

		[SpecialName]
		public void Pa3(Hg7a Ys9)
		{
			if (Ys9 != m_wardDetails)
			{
				if (Ys9 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Az2(ref m_wardDetails);
			}
		}
	}

	private static Ew7.d0S<Computer> s_Computer = new Ew7.d0S<Computer>();

	private static Ew7.d0S<User> s_User = new Ew7.d0S<User>();

	private static Ew7.d0S<Xq6> s_Windows = new Ew7.d0S<Xq6>();

	private static Ew7.d0S<Log> s_Log = new Ew7.d0S<Log>();

	[SpecialName]
	internal static Xq6 e2Q()
	{
		return s_Windows.get_GetInstance();
	}
}
