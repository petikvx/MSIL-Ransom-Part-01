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
using Ha9;
using Jo5;
using Lp53;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Mj8;
using Qq4g;
using Qw8;
using Sp0;
using Te3;
using Zi3;
using a2A;
using d5Y4;
using f9E;
using j8H;
using m2P;
using s1A;
using y4H;

namespace i5WJ;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Qk2o
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Re58
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f6P7 m_AddmisionForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hz6 m_AddmisionForm1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kt4 m_AddUser;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lo0 m_ClassDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s4W m_ClassDetail1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pc10 m_Course;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gm1z m_Course1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e3Z m_LoginForm1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lc0 m_MENUS;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wn6 m_SearchForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g3N m_Startup;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Yw0 m_Subject;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public r1D m_Subject1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t4Z m_Viewer;

		public f6P7 AddmisionForm
		{
			[DebuggerHidden]
			get
			{
				m_AddmisionForm = Jm57(m_AddmisionForm);
				return m_AddmisionForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddmisionForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_AddmisionForm);
				}
			}
		}

		public Hz6 AddmisionForm1
		{
			[DebuggerHidden]
			get
			{
				m_AddmisionForm1 = Jm57(m_AddmisionForm1);
				return m_AddmisionForm1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddmisionForm1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_AddmisionForm1);
				}
			}
		}

		public Kt4 AddUser
		{
			[DebuggerHidden]
			get
			{
				m_AddUser = Jm57(m_AddUser);
				return m_AddUser;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddUser)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_AddUser);
				}
			}
		}

		public Lo0 ClassDetail
		{
			[DebuggerHidden]
			get
			{
				m_ClassDetail = Jm57(m_ClassDetail);
				return m_ClassDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ClassDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_ClassDetail);
				}
			}
		}

		public s4W ClassDetail1
		{
			[DebuggerHidden]
			get
			{
				m_ClassDetail1 = Jm57(m_ClassDetail1);
				return m_ClassDetail1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ClassDetail1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_ClassDetail1);
				}
			}
		}

		public Pc10 Course
		{
			[DebuggerHidden]
			get
			{
				m_Course = Jm57(m_Course);
				return m_Course;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Course)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_Course);
				}
			}
		}

		public Gm1z Course1
		{
			[DebuggerHidden]
			get
			{
				m_Course1 = Jm57(m_Course1);
				return m_Course1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Course1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_Course1);
				}
			}
		}

		public e3Z LoginForm1
		{
			[DebuggerHidden]
			get
			{
				m_LoginForm1 = Jm57(m_LoginForm1);
				return m_LoginForm1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_LoginForm1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_LoginForm1);
				}
			}
		}

		public Lc0 MENUS
		{
			[DebuggerHidden]
			get
			{
				m_MENUS = Jm57(m_MENUS);
				return m_MENUS;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_MENUS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_MENUS);
				}
			}
		}

		public Wn6 SearchForm
		{
			[DebuggerHidden]
			get
			{
				m_SearchForm = Jm57(m_SearchForm);
				return m_SearchForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_SearchForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_SearchForm);
				}
			}
		}

		public g3N Startup
		{
			[DebuggerHidden]
			get
			{
				m_Startup = Jm57(m_Startup);
				return m_Startup;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Startup)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_Startup);
				}
			}
		}

		public Yw0 Subject
		{
			[DebuggerHidden]
			get
			{
				m_Subject = Jm57(m_Subject);
				return m_Subject;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Subject)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_Subject);
				}
			}
		}

		public r1D Subject1
		{
			[DebuggerHidden]
			get
			{
				m_Subject1 = Jm57(m_Subject1);
				return m_Subject1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Subject1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_Subject1);
				}
			}
		}

		public t4Z Viewer
		{
			[DebuggerHidden]
			get
			{
				m_Viewer = Jm57(m_Viewer);
				return m_Viewer;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Viewer)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m2QH(ref m_Viewer);
				}
			}
		}

		[DebuggerHidden]
		private static k0G4 Jm57<k0G4>(k0G4 k1A5) where k0G4 : Form, new()
		{
			if (k1A5 == null || ((Control)k1A5).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(k0G4)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(k0G4), null);
				try
				{
					return new k0G4();
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
					m_FormBeingCreated.Remove(typeof(k0G4));
				}
			}
			return k1A5;
		}

		[DebuggerHidden]
		private void m2QH<Dm13>(ref Dm13 a3B7) where Dm13 : Form
		{
			((Component)a3B7).Dispose();
			a3B7 = default(Dm13);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Re58()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool e4N6(object Gd29)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Gd29));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int La5k()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Pj7o()
		{
			return typeof(Re58);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string d1S8()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Ay9c
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool g0CJ(object Pz68)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Pz68));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int e8S6()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type s7DP()
		{
			return typeof(Ay9c);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Zx78()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static a3Q9 Gn15<a3Q9>(a3Q9 x1ZR) where a3Q9 : new()
		{
			if (x1ZR == null)
			{
				return new a3Q9();
			}
			return x1ZR;
		}

		[DebuggerHidden]
		private void Rr4a<Mo96>(ref Mo96 j7RH)
		{
			j7RH = default(Mo96);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Ay9c()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class d0DW<d9S3> where d9S3 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static d9S3 m_ThreadStaticValue;

		internal d9S3 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new d9S3();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public d0DW()
		{
		}
	}

	private static readonly d0DW<Zn0> m_ComputerObjectProvider = new d0DW<Zn0>();

	private static readonly d0DW<Wk1> m_AppObjectProvider = new d0DW<Wk1>();

	private static readonly d0DW<User> m_UserObjectProvider = new d0DW<User>();

	private static d0DW<Re58> m_MyFormsObjectProvider = new d0DW<Re58>();

	private static readonly d0DW<Ay9c> m_MyWebServicesObjectProvider = new d0DW<Ay9c>();

	[HelpKeyword("My.Computer")]
	internal static Zn0 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Wk1 Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Re58 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Ay9c WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
