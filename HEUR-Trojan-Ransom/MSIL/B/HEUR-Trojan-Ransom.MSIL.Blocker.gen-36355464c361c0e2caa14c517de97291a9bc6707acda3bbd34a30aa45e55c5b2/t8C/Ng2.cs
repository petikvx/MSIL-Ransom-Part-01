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
using Cf6;
using Ex8;
using Hr60;
using Jz38;
using Lp2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Rx43;
using Tn6;
using Wa2;
using Xj2;
using c1F9;
using g3E7;
using i9AG;

namespace t8C;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Ng2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Gt3
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c8N m_DashBoard;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public r6P m_Gallery;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m4F m_Gross_Fees_Paid;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zj4 m_Home;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t0S8 m_LoginForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o9CM m_SplashScreen;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xd8b m_Student_Profile;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kb17 m_StudentList;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cs9g m_Stundentform;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public r2Z4 m_Teacher_Dashboard;

		public c8N DashBoard
		{
			[DebuggerHidden]
			get
			{
				m_DashBoard = Ng7(m_DashBoard);
				return m_DashBoard;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_DashBoard)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					s1G(ref m_DashBoard);
				}
			}
		}

		public r6P Gallery
		{
			[DebuggerHidden]
			get
			{
				m_Gallery = Ng7(m_Gallery);
				return m_Gallery;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Gallery)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					s1G(ref m_Gallery);
				}
			}
		}

		public m4F Gross_Fees_Paid
		{
			[DebuggerHidden]
			get
			{
				m_Gross_Fees_Paid = Ng7(m_Gross_Fees_Paid);
				return m_Gross_Fees_Paid;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Gross_Fees_Paid)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					s1G(ref m_Gross_Fees_Paid);
				}
			}
		}

		public Zj4 Home
		{
			[DebuggerHidden]
			get
			{
				m_Home = Ng7(m_Home);
				return m_Home;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Home)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					s1G(ref m_Home);
				}
			}
		}

		public t0S8 LoginForm
		{
			[DebuggerHidden]
			get
			{
				m_LoginForm = Ng7(m_LoginForm);
				return m_LoginForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_LoginForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					s1G(ref m_LoginForm);
				}
			}
		}

		public o9CM SplashScreen
		{
			[DebuggerHidden]
			get
			{
				m_SplashScreen = Ng7(m_SplashScreen);
				return m_SplashScreen;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_SplashScreen)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					s1G(ref m_SplashScreen);
				}
			}
		}

		public Xd8b Student_Profile
		{
			[DebuggerHidden]
			get
			{
				m_Student_Profile = Ng7(m_Student_Profile);
				return m_Student_Profile;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Student_Profile)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					s1G(ref m_Student_Profile);
				}
			}
		}

		public Kb17 StudentList
		{
			[DebuggerHidden]
			get
			{
				m_StudentList = Ng7(m_StudentList);
				return m_StudentList;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_StudentList)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					s1G(ref m_StudentList);
				}
			}
		}

		public Cs9g Stundentform
		{
			[DebuggerHidden]
			get
			{
				m_Stundentform = Ng7(m_Stundentform);
				return m_Stundentform;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Stundentform)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					s1G(ref m_Stundentform);
				}
			}
		}

		public r2Z4 Teacher_Dashboard
		{
			[DebuggerHidden]
			get
			{
				m_Teacher_Dashboard = Ng7(m_Teacher_Dashboard);
				return m_Teacher_Dashboard;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Teacher_Dashboard)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					s1G(ref m_Teacher_Dashboard);
				}
			}
		}

		[DebuggerHidden]
		private static Qa5 Ng7<Qa5>(Qa5 e9L) where Qa5 : Form, new()
		{
			if (e9L == null || ((Control)e9L).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Qa5)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Qa5), null);
				try
				{
					return new Qa5();
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
					m_FormBeingCreated.Remove(typeof(Qa5));
				}
			}
			return e9L;
		}

		[DebuggerHidden]
		private void s1G<Qr0>(ref Qr0 g4E) where Qr0 : Form
		{
			((Component)g4E).Dispose();
			g4E = default(Qr0);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gt3()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool o5P(object a7D)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(a7D));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int o9A()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Do3()
		{
			return typeof(Gt3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Aa8()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Ls3
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Ge6(object Hx0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Hx0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Df3()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type z4H()
		{
			return typeof(Ls3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string b4D()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Dq7 m3C<Dq7>(Dq7 Np3) where Dq7 : new()
		{
			if (Np3 == null)
			{
				return new Dq7();
			}
			return Np3;
		}

		[DebuggerHidden]
		private void At8<Xj0>(ref Xj0 Kr4)
		{
			Kr4 = default(Xj0);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ls3()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Jc7<e8S> where e8S : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static e8S m_ThreadStaticValue;

		internal e8S GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new e8S();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jc7()
		{
		}
	}

	private static readonly Jc7<Py8> m_ComputerObjectProvider = new Jc7<Py8>();

	private static readonly Jc7<k9Q> m_AppObjectProvider = new Jc7<k9Q>();

	private static readonly Jc7<User> m_UserObjectProvider = new Jc7<User>();

	private static Jc7<Gt3> m_MyFormsObjectProvider = new Jc7<Gt3>();

	private static readonly Jc7<Ls3> m_MyWebServicesObjectProvider = new Jc7<Ls3>();

	[HelpKeyword("My.Computer")]
	internal static Py8 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.get_GetInstance();
		}
	}

	[HelpKeyword("My.Application")]
	internal static k9Q Application
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
	internal static Gt3 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.get_GetInstance();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Ls3 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.get_GetInstance();
		}
	}
}
