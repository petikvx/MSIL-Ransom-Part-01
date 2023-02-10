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
using Cf4r;
using Mi5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Rx5;
using Wo12;
using d6P;
using p8YJ;
using t8F;
using w5K4;
using x6E5;
using y7TZ;
using z0R2;
using z5S;

namespace g2H;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Gw5
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Wk0
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p7E m_DashBoard;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e5F0 m_Gallery;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a4MK m_Gross_Fees_Paid;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gk6p m_Home;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c2S m_LoginForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x0S9 m_SplashScreen;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ax6c m_Student_Profile;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w0R9 m_StudentList;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zn74 m_Stundentform;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cr6 m_Teacher_Dashboard;

		public p7E DashBoard
		{
			[DebuggerHidden]
			get
			{
				m_DashBoard = x6E(m_DashBoard);
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
					f8H(ref m_DashBoard);
				}
			}
		}

		public e5F0 Gallery
		{
			[DebuggerHidden]
			get
			{
				m_Gallery = x6E(m_Gallery);
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
					f8H(ref m_Gallery);
				}
			}
		}

		public a4MK Gross_Fees_Paid
		{
			[DebuggerHidden]
			get
			{
				m_Gross_Fees_Paid = x6E(m_Gross_Fees_Paid);
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
					f8H(ref m_Gross_Fees_Paid);
				}
			}
		}

		public Gk6p Home
		{
			[DebuggerHidden]
			get
			{
				m_Home = x6E(m_Home);
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
					f8H(ref m_Home);
				}
			}
		}

		public c2S LoginForm
		{
			[DebuggerHidden]
			get
			{
				m_LoginForm = x6E(m_LoginForm);
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
					f8H(ref m_LoginForm);
				}
			}
		}

		public x0S9 SplashScreen
		{
			[DebuggerHidden]
			get
			{
				m_SplashScreen = x6E(m_SplashScreen);
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
					f8H(ref m_SplashScreen);
				}
			}
		}

		public Ax6c Student_Profile
		{
			[DebuggerHidden]
			get
			{
				m_Student_Profile = x6E(m_Student_Profile);
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
					f8H(ref m_Student_Profile);
				}
			}
		}

		public w0R9 StudentList
		{
			[DebuggerHidden]
			get
			{
				m_StudentList = x6E(m_StudentList);
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
					f8H(ref m_StudentList);
				}
			}
		}

		public Zn74 Stundentform
		{
			[DebuggerHidden]
			get
			{
				m_Stundentform = x6E(m_Stundentform);
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
					f8H(ref m_Stundentform);
				}
			}
		}

		public Cr6 Teacher_Dashboard
		{
			[DebuggerHidden]
			get
			{
				m_Teacher_Dashboard = x6E(m_Teacher_Dashboard);
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
					f8H(ref m_Teacher_Dashboard);
				}
			}
		}

		[DebuggerHidden]
		private static e3N x6E<e3N>(e3N y4C) where e3N : Form, new()
		{
			if (y4C == null || ((Control)y4C).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(e3N)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(e3N), null);
				try
				{
					return new e3N();
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
					m_FormBeingCreated.Remove(typeof(e3N));
				}
			}
			return y4C;
		}

		[DebuggerHidden]
		private void f8H<Wp5>(ref Wp5 j0X) where Wp5 : Form
		{
			((Component)j0X).Dispose();
			j0X = default(Wp5);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wk0()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool k1Q(object Xf2)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Xf2));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int p9T()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type s4M()
		{
			return typeof(Wk0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Xw3()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class f4B
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Mj9(object Wk0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Wk0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int a2D()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type Qd6()
		{
			return typeof(f4B);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string f6Y()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static z2J k7F<z2J>(z2J Zp9) where z2J : new()
		{
			if (Zp9 == null)
			{
				return new z2J();
			}
			return Zp9;
		}

		[DebuggerHidden]
		private void f3Q<Xp8>(ref Xp8 Gr1)
		{
			Gr1 = default(Xp8);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public f4B()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Yt9<Dt8> where Dt8 : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static Dt8 m_ThreadStaticValue;

		internal Dt8 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Dt8();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Yt9()
		{
		}
	}

	private static readonly Yt9<g2R> m_ComputerObjectProvider = new Yt9<g2R>();

	private static readonly Yt9<Hw1> m_AppObjectProvider = new Yt9<Hw1>();

	private static readonly Yt9<User> m_UserObjectProvider = new Yt9<User>();

	private static Yt9<Wk0> m_MyFormsObjectProvider = new Yt9<Wk0>();

	private static readonly Yt9<f4B> m_MyWebServicesObjectProvider = new Yt9<f4B>();

	[HelpKeyword("My.Computer")]
	internal static g2R Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.get_GetInstance();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Hw1 Application
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
	internal static Wk0 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.get_GetInstance();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static f4B WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.get_GetInstance();
		}
	}
}
