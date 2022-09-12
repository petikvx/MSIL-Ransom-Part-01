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
using Fw2i;
using Jq7;
using Ls5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Qa3e;
using Yc5;
using Yd5;
using a6L;
using c9N;
using d5R;
using i4A7;
using i6N;
using k0C5;
using o0QX;
using p2N6;
using r6N;
using w0C;

namespace Es9r;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class We04
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class j2LM
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b2R9 m_AddmisionForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z8YW m_AddmisionForm1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k7G m_AddUser;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jq1j m_ClassDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o3M6 m_ClassDetail1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lp7 m_Course;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i2M m_Course1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d0Z m_LoginForm1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x2N m_MENUS;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nk2 m_SearchForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Te7 m_Startup;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p6S m_Subject;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e6A m_Subject1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dj8 m_Viewer;

		public b2R9 AddmisionForm
		{
			[DebuggerHidden]
			get
			{
				m_AddmisionForm = g1A7(m_AddmisionForm);
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
					Ef5t(ref m_AddmisionForm);
				}
			}
		}

		public z8YW AddmisionForm1
		{
			[DebuggerHidden]
			get
			{
				m_AddmisionForm1 = g1A7(m_AddmisionForm1);
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
					Ef5t(ref m_AddmisionForm1);
				}
			}
		}

		public k7G AddUser
		{
			[DebuggerHidden]
			get
			{
				m_AddUser = g1A7(m_AddUser);
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
					Ef5t(ref m_AddUser);
				}
			}
		}

		public Jq1j ClassDetail
		{
			[DebuggerHidden]
			get
			{
				m_ClassDetail = g1A7(m_ClassDetail);
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
					Ef5t(ref m_ClassDetail);
				}
			}
		}

		public o3M6 ClassDetail1
		{
			[DebuggerHidden]
			get
			{
				m_ClassDetail1 = g1A7(m_ClassDetail1);
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
					Ef5t(ref m_ClassDetail1);
				}
			}
		}

		public Lp7 Course
		{
			[DebuggerHidden]
			get
			{
				m_Course = g1A7(m_Course);
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
					Ef5t(ref m_Course);
				}
			}
		}

		public i2M Course1
		{
			[DebuggerHidden]
			get
			{
				m_Course1 = g1A7(m_Course1);
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
					Ef5t(ref m_Course1);
				}
			}
		}

		public d0Z LoginForm1
		{
			[DebuggerHidden]
			get
			{
				m_LoginForm1 = g1A7(m_LoginForm1);
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
					Ef5t(ref m_LoginForm1);
				}
			}
		}

		public x2N MENUS
		{
			[DebuggerHidden]
			get
			{
				m_MENUS = g1A7(m_MENUS);
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
					Ef5t(ref m_MENUS);
				}
			}
		}

		public Nk2 SearchForm
		{
			[DebuggerHidden]
			get
			{
				m_SearchForm = g1A7(m_SearchForm);
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
					Ef5t(ref m_SearchForm);
				}
			}
		}

		public Te7 Startup
		{
			[DebuggerHidden]
			get
			{
				m_Startup = g1A7(m_Startup);
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
					Ef5t(ref m_Startup);
				}
			}
		}

		public p6S Subject
		{
			[DebuggerHidden]
			get
			{
				m_Subject = g1A7(m_Subject);
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
					Ef5t(ref m_Subject);
				}
			}
		}

		public e6A Subject1
		{
			[DebuggerHidden]
			get
			{
				m_Subject1 = g1A7(m_Subject1);
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
					Ef5t(ref m_Subject1);
				}
			}
		}

		public Dj8 Viewer
		{
			[DebuggerHidden]
			get
			{
				m_Viewer = g1A7(m_Viewer);
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
					Ef5t(ref m_Viewer);
				}
			}
		}

		[DebuggerHidden]
		private static Mf90 g1A7<Mf90>(Mf90 i5H4) where Mf90 : Form, new()
		{
			if (i5H4 == null || ((Control)i5H4).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Mf90)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Mf90), null);
				try
				{
					return new Mf90();
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
					m_FormBeingCreated.Remove(typeof(Mf90));
				}
			}
			return i5H4;
		}

		[DebuggerHidden]
		private void Ef5t<Fe48>(ref Fe48 k2FZ) where Fe48 : Form
		{
			((Component)k2FZ).Dispose();
			k2FZ = default(Fe48);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public j2LM()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Gz45(object i7RT)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(i7RT));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Rn95()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Tc92()
		{
			return typeof(j2LM);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string s6KC()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Bk0p
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool i3R5(object Hg68)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Hg68));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Ss2j()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Hj6k()
		{
			return typeof(Bk0p);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string k5YP()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Ks60 Mf24<Ks60>(Ks60 j2CX) where Ks60 : new()
		{
			if (j2CX == null)
			{
				return new Ks60();
			}
			return j2CX;
		}

		[DebuggerHidden]
		private void y7BM<Hm23>(ref Hm23 Pa65)
		{
			Pa65 = default(Hm23);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Bk0p()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class a7ZT<Rq82> where Rq82 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Rq82 m_ThreadStaticValue;

		internal Rq82 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Rq82();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public a7ZT()
		{
		}
	}

	private static readonly a7ZT<Qc60> m_ComputerObjectProvider = new a7ZT<Qc60>();

	private static readonly a7ZT<g8PC> m_AppObjectProvider = new a7ZT<g8PC>();

	private static readonly a7ZT<User> m_UserObjectProvider = new a7ZT<User>();

	private static a7ZT<j2LM> m_MyFormsObjectProvider = new a7ZT<j2LM>();

	private static readonly a7ZT<Bk0p> m_MyWebServicesObjectProvider = new a7ZT<Bk0p>();

	[HelpKeyword("My.Computer")]
	internal static Qc60 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static g8PC Application
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
	internal static j2LM Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Bk0p WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
