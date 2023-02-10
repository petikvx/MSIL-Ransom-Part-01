using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dg7p;
using Gp7;
using Hj34;
using Hz0;
using Jq45;
using Mi5m;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Ng0w;
using Rp4;
using Rr08;
using Sr8;
using Wc7y;
using Xk1r;
using c5T;
using d6M;
using g5QX;
using i0QN;
using j4K;
using k2H;
using k7S4;
using m3DA;
using x1W;

namespace d6D;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class b8G
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Fj5
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g8J m_Admin_Function;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Yw2 m_Alert_Notification;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m4T m_Apartment_Details;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z6P m_Block_A;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xt3 m_Block_B;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w4L m_Block_C;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g8XB m_Booking_Info;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Es83 m_E_Bill_Info;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jk7i m_Event_Hall;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y6H2 m_first_page;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qt53 m_Flat_Rent;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public My5 m_Form1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Je96 m_House_Entry;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z5B9 m_Pay_eletricity;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ni73 m_Problem_Report;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fy8t m_Rent_Info;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Yc81 m_Tenant_Function;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sr86 m_Tenant_Login;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Rw21 m_Tenant_Registration;

		public g8J Admin_Function
		{
			[DebuggerHidden]
			get
			{
				m_Admin_Function = Zz0(m_Admin_Function);
				return m_Admin_Function;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Admin_Function)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Admin_Function);
				}
			}
		}

		public Yw2 Alert_Notification
		{
			[DebuggerHidden]
			get
			{
				m_Alert_Notification = Zz0(m_Alert_Notification);
				return m_Alert_Notification;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Alert_Notification)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Alert_Notification);
				}
			}
		}

		public m4T Apartment_Details
		{
			[DebuggerHidden]
			get
			{
				m_Apartment_Details = Zz0(m_Apartment_Details);
				return m_Apartment_Details;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Apartment_Details)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Apartment_Details);
				}
			}
		}

		public z6P Block_A
		{
			[DebuggerHidden]
			get
			{
				m_Block_A = Zz0(m_Block_A);
				return m_Block_A;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Block_A)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Block_A);
				}
			}
		}

		public Xt3 Block_B
		{
			[DebuggerHidden]
			get
			{
				m_Block_B = Zz0(m_Block_B);
				return m_Block_B;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Block_B)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Block_B);
				}
			}
		}

		public w4L Block_C
		{
			[DebuggerHidden]
			get
			{
				m_Block_C = Zz0(m_Block_C);
				return m_Block_C;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Block_C)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Block_C);
				}
			}
		}

		public g8XB Booking_Info
		{
			[DebuggerHidden]
			get
			{
				m_Booking_Info = Zz0(m_Booking_Info);
				return m_Booking_Info;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Booking_Info)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Booking_Info);
				}
			}
		}

		public Es83 E_Bill_Info
		{
			[DebuggerHidden]
			get
			{
				m_E_Bill_Info = Zz0(m_E_Bill_Info);
				return m_E_Bill_Info;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_E_Bill_Info)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_E_Bill_Info);
				}
			}
		}

		public Jk7i Event_Hall
		{
			[DebuggerHidden]
			get
			{
				m_Event_Hall = Zz0(m_Event_Hall);
				return m_Event_Hall;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Event_Hall)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Event_Hall);
				}
			}
		}

		public y6H2 first_page
		{
			[DebuggerHidden]
			get
			{
				m_first_page = Zz0(m_first_page);
				return m_first_page;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_first_page)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_first_page);
				}
			}
		}

		public Qt53 Flat_Rent
		{
			[DebuggerHidden]
			get
			{
				m_Flat_Rent = Zz0(m_Flat_Rent);
				return m_Flat_Rent;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Flat_Rent)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Flat_Rent);
				}
			}
		}

		public My5 Form1
		{
			[DebuggerHidden]
			get
			{
				m_Form1 = Zz0(m_Form1);
				return m_Form1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Form1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Form1);
				}
			}
		}

		public Je96 House_Entry
		{
			[DebuggerHidden]
			get
			{
				m_House_Entry = Zz0(m_House_Entry);
				return m_House_Entry;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_House_Entry)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_House_Entry);
				}
			}
		}

		public z5B9 Pay_eletricity
		{
			[DebuggerHidden]
			get
			{
				m_Pay_eletricity = Zz0(m_Pay_eletricity);
				return m_Pay_eletricity;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Pay_eletricity)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Pay_eletricity);
				}
			}
		}

		public Ni73 Problem_Report
		{
			[DebuggerHidden]
			get
			{
				m_Problem_Report = Zz0(m_Problem_Report);
				return m_Problem_Report;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Problem_Report)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Problem_Report);
				}
			}
		}

		public Fy8t Rent_Info
		{
			[DebuggerHidden]
			get
			{
				m_Rent_Info = Zz0(m_Rent_Info);
				return m_Rent_Info;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Rent_Info)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Rent_Info);
				}
			}
		}

		public Yc81 Tenant_Function
		{
			[DebuggerHidden]
			get
			{
				m_Tenant_Function = Zz0(m_Tenant_Function);
				return m_Tenant_Function;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Tenant_Function)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Tenant_Function);
				}
			}
		}

		public Sr86 Tenant_Login
		{
			[DebuggerHidden]
			get
			{
				m_Tenant_Login = Zz0(m_Tenant_Login);
				return m_Tenant_Login;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Tenant_Login)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Tenant_Login);
				}
			}
		}

		public Rw21 Tenant_Registration
		{
			[DebuggerHidden]
			get
			{
				m_Tenant_Registration = Zz0(m_Tenant_Registration);
				return m_Tenant_Registration;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Tenant_Registration)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					q0D(ref m_Tenant_Registration);
				}
			}
		}

		[DebuggerHidden]
		private static Zp3 Zz0<Zp3>(Zp3 Hd8) where Zp3 : Form, new()
		{
			if (Hd8 == null || ((Control)Hd8).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Zp3)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Zp3), null);
				try
				{
					return new Zp3();
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
					m_FormBeingCreated.Remove(typeof(Zp3));
				}
			}
			return Hd8;
		}

		[DebuggerHidden]
		private void q0D<Wa5>(ref Wa5 i0B) where Wa5 : Form
		{
			((Component)i0B).Dispose();
			i0B = default(Wa5);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fj5()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Ny1(object e9R)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(e9R));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Bo8()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Eg4()
		{
			return typeof(Fj5);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string p5H()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Sm5
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool b9G(object Hm0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Hm0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int We3()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type Qr0()
		{
			return typeof(Sm5);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string d9M()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Sb9 Rp5<Sb9>(Sb9 Cq2) where Sb9 : new()
		{
			if (Cq2 == null)
			{
				return new Sb9();
			}
			return Cq2;
		}

		[DebuggerHidden]
		private void x0S<y8Z>(ref y8Z t4B)
		{
			t4B = default(y8Z);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sm5()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class a7A<Tw7> where Tw7 : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static Tw7 m_ThreadStaticValue;

		internal Tw7 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Tw7();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public a7A()
		{
		}
	}

	private static readonly a7A<k6E> m_ComputerObjectProvider = new a7A<k6E>();

	private static readonly a7A<Zq5> m_AppObjectProvider = new a7A<Zq5>();

	private static readonly a7A<User> m_UserObjectProvider = new a7A<User>();

	private static a7A<Fj5> m_MyFormsObjectProvider = new a7A<Fj5>();

	private static readonly a7A<Sm5> m_MyWebServicesObjectProvider = new a7A<Sm5>();

	[HelpKeyword("My.Computer")]
	internal static k6E Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.get_GetInstance();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Zq5 Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.get_GetInstance();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.get_GetInstance();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Fj5 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.get_GetInstance();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Sm5 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.get_GetInstance();
		}
	}
}
