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
using Gp1m;
using Hc6o;
using Kb8;
using Kq1r;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Wf5;
using a0D2;
using a2E6;
using b1W;
using b1X;
using c1QZ;
using c5AP;
using g3F;
using j7G;
using j8E;
using n4YR;
using x5Q;

namespace Er8z;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Qb36
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class En9f
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sd2 m_AddmisionForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hg5 m_AddmisionForm1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dk3 m_AddUser;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sz3 m_ClassDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bj4 m_ClassDetail1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lq3 m_Course;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d5A m_Course1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gx1m m_LoginForm1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hy50 m_MENUS;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f3ZF m_SearchForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zy95 m_Startup;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b1D7 m_Subject;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jg25 m_Subject1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bk7 m_Viewer;

		public Sd2 AddmisionForm
		{
			[DebuggerHidden]
			get
			{
				m_AddmisionForm = d8JA(m_AddmisionForm);
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
					Nm5g(ref m_AddmisionForm);
				}
			}
		}

		public Hg5 AddmisionForm1
		{
			[DebuggerHidden]
			get
			{
				m_AddmisionForm1 = d8JA(m_AddmisionForm1);
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
					Nm5g(ref m_AddmisionForm1);
				}
			}
		}

		public Dk3 AddUser
		{
			[DebuggerHidden]
			get
			{
				m_AddUser = d8JA(m_AddUser);
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
					Nm5g(ref m_AddUser);
				}
			}
		}

		public Sz3 ClassDetail
		{
			[DebuggerHidden]
			get
			{
				m_ClassDetail = d8JA(m_ClassDetail);
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
					Nm5g(ref m_ClassDetail);
				}
			}
		}

		public Bj4 ClassDetail1
		{
			[DebuggerHidden]
			get
			{
				m_ClassDetail1 = d8JA(m_ClassDetail1);
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
					Nm5g(ref m_ClassDetail1);
				}
			}
		}

		public Lq3 Course
		{
			[DebuggerHidden]
			get
			{
				m_Course = d8JA(m_Course);
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
					Nm5g(ref m_Course);
				}
			}
		}

		public d5A Course1
		{
			[DebuggerHidden]
			get
			{
				m_Course1 = d8JA(m_Course1);
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
					Nm5g(ref m_Course1);
				}
			}
		}

		public Gx1m LoginForm1
		{
			[DebuggerHidden]
			get
			{
				m_LoginForm1 = d8JA(m_LoginForm1);
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
					Nm5g(ref m_LoginForm1);
				}
			}
		}

		public Hy50 MENUS
		{
			[DebuggerHidden]
			get
			{
				m_MENUS = d8JA(m_MENUS);
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
					Nm5g(ref m_MENUS);
				}
			}
		}

		public f3ZF SearchForm
		{
			[DebuggerHidden]
			get
			{
				m_SearchForm = d8JA(m_SearchForm);
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
					Nm5g(ref m_SearchForm);
				}
			}
		}

		public Zy95 Startup
		{
			[DebuggerHidden]
			get
			{
				m_Startup = d8JA(m_Startup);
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
					Nm5g(ref m_Startup);
				}
			}
		}

		public b1D7 Subject
		{
			[DebuggerHidden]
			get
			{
				m_Subject = d8JA(m_Subject);
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
					Nm5g(ref m_Subject);
				}
			}
		}

		public Jg25 Subject1
		{
			[DebuggerHidden]
			get
			{
				m_Subject1 = d8JA(m_Subject1);
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
					Nm5g(ref m_Subject1);
				}
			}
		}

		public Bk7 Viewer
		{
			[DebuggerHidden]
			get
			{
				m_Viewer = d8JA(m_Viewer);
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
					Nm5g(ref m_Viewer);
				}
			}
		}

		[DebuggerHidden]
		private static i9TX d8JA<i9TX>(i9TX q4DT) where i9TX : Form, new()
		{
			if (q4DT == null || ((Control)q4DT).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(i9TX)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(i9TX), null);
				try
				{
					return new i9TX();
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
					m_FormBeingCreated.Remove(typeof(i9TX));
				}
			}
			return q4DT;
		}

		[DebuggerHidden]
		private void Nm5g<Hz0f>(ref Hz0f Xo71) where Hz0f : Form
		{
			((Component)Xo71).Dispose();
			Xo71 = default(Hz0f);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public En9f()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Tq05(object Bd4i)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Bd4i));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int r8N3()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type k4M6()
		{
			return typeof(En9f);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Tm97()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Lj5
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Kg6(object Em3)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Em3));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Hn1()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type t9J()
		{
			return typeof(Lj5);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string x2Z()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static o3D Mj8<o3D>(o3D Dd4) where o3D : new()
		{
			if (Dd4 == null)
			{
				return new o3D();
			}
			return Dd4;
		}

		[DebuggerHidden]
		private void i8J<Tm3>(ref Tm3 Kb5)
		{
			Kb5 = default(Tm3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Lj5()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class z5B<Gi7> where Gi7 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Gi7 m_ThreadStaticValue;

		internal Gi7 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Gi7();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public z5B()
		{
		}
	}

	private static readonly z5B<r0E7> m_ComputerObjectProvider = new z5B<r0E7>();

	private static readonly z5B<d6GX> m_AppObjectProvider = new z5B<d6GX>();

	private static readonly z5B<User> m_UserObjectProvider = new z5B<User>();

	private static z5B<En9f> m_MyFormsObjectProvider = new z5B<En9f>();

	private static readonly z5B<Lj5> m_MyWebServicesObjectProvider = new z5B<Lj5>();

	[HelpKeyword("My.Computer")]
	internal static r0E7 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static d6GX Application
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
	internal static En9f Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Lj5 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
