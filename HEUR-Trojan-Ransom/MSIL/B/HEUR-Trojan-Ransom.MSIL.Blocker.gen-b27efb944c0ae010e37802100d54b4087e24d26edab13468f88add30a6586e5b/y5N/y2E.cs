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
using Af20;
using Ff9z;
using Jp3;
using Mf4;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using We09;
using Yp7;
using c3K7;
using d5E0;
using g4PL;
using i6R;
using j8F;
using m4S;
using o9TE;
using x1W;
using x9T5;
using z8R;

namespace y5N;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class y2E
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Rw3
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mz7 m_AddmisionForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c1N m_AddmisionForm1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ry8g m_AddUser;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cy37 m_ClassDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hg74 m_ClassDetail1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cp1b m_Course;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z4B m_Course1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q7E m_LoginForm1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qw5 m_MENUS;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q0N m_SearchForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Si1 m_Startup;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q2X m_Subject;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hf2c m_Subject1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t3G0 m_Viewer;

		public Mz7 AddmisionForm
		{
			[DebuggerHidden]
			get
			{
				m_AddmisionForm = s5H(m_AddmisionForm);
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
					Pj2(ref m_AddmisionForm);
				}
			}
		}

		public c1N AddmisionForm1
		{
			[DebuggerHidden]
			get
			{
				m_AddmisionForm1 = s5H(m_AddmisionForm1);
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
					Pj2(ref m_AddmisionForm1);
				}
			}
		}

		public Ry8g AddUser
		{
			[DebuggerHidden]
			get
			{
				m_AddUser = s5H(m_AddUser);
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
					Pj2(ref m_AddUser);
				}
			}
		}

		public Cy37 ClassDetail
		{
			[DebuggerHidden]
			get
			{
				m_ClassDetail = s5H(m_ClassDetail);
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
					Pj2(ref m_ClassDetail);
				}
			}
		}

		public Hg74 ClassDetail1
		{
			[DebuggerHidden]
			get
			{
				m_ClassDetail1 = s5H(m_ClassDetail1);
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
					Pj2(ref m_ClassDetail1);
				}
			}
		}

		public Cp1b Course
		{
			[DebuggerHidden]
			get
			{
				m_Course = s5H(m_Course);
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
					Pj2(ref m_Course);
				}
			}
		}

		public z4B Course1
		{
			[DebuggerHidden]
			get
			{
				m_Course1 = s5H(m_Course1);
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
					Pj2(ref m_Course1);
				}
			}
		}

		public q7E LoginForm1
		{
			[DebuggerHidden]
			get
			{
				m_LoginForm1 = s5H(m_LoginForm1);
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
					Pj2(ref m_LoginForm1);
				}
			}
		}

		public Qw5 MENUS
		{
			[DebuggerHidden]
			get
			{
				m_MENUS = s5H(m_MENUS);
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
					Pj2(ref m_MENUS);
				}
			}
		}

		public q0N SearchForm
		{
			[DebuggerHidden]
			get
			{
				m_SearchForm = s5H(m_SearchForm);
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
					Pj2(ref m_SearchForm);
				}
			}
		}

		public Si1 Startup
		{
			[DebuggerHidden]
			get
			{
				m_Startup = s5H(m_Startup);
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
					Pj2(ref m_Startup);
				}
			}
		}

		public q2X Subject
		{
			[DebuggerHidden]
			get
			{
				m_Subject = s5H(m_Subject);
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
					Pj2(ref m_Subject);
				}
			}
		}

		public Hf2c Subject1
		{
			[DebuggerHidden]
			get
			{
				m_Subject1 = s5H(m_Subject1);
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
					Pj2(ref m_Subject1);
				}
			}
		}

		public t3G0 Viewer
		{
			[DebuggerHidden]
			get
			{
				m_Viewer = s5H(m_Viewer);
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
					Pj2(ref m_Viewer);
				}
			}
		}

		[DebuggerHidden]
		private static r8Y s5H<r8Y>(r8Y a6K) where r8Y : Form, new()
		{
			if (a6K == null || ((Control)a6K).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(r8Y)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(r8Y), null);
				try
				{
					return new r8Y();
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
					m_FormBeingCreated.Remove(typeof(r8Y));
				}
			}
			return a6K;
		}

		[DebuggerHidden]
		private void Pj2<g5T>(ref g5T Tq6) where g5T : Form
		{
			((Component)Tq6).Dispose();
			Tq6 = default(g5T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Rw3()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool i5X(object De2)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(De2));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int s9E()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type z3G()
		{
			return typeof(Rw3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Gw8()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class f9X
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Pa8(object Pt1)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Pt1));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Kn5()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type a7K()
		{
			return typeof(f9X);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string z5X()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Tj7 b2Q<Tj7>(Tj7 Qz3) where Tj7 : new()
		{
			if (Qz3 == null)
			{
				return new Tj7();
			}
			return Qz3;
		}

		[DebuggerHidden]
		private void Wx0<Qg4>(ref Qg4 b4H)
		{
			b4H = default(Qg4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public f9X()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Lb4<m5F> where m5F : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static m5F m_ThreadStaticValue;

		internal m5F GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new m5F();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Lb4()
		{
		}
	}

	private static readonly Lb4<Jp95> m_ComputerObjectProvider = new Lb4<Jp95>();

	private static readonly Lb4<Li2r> m_AppObjectProvider = new Lb4<Li2r>();

	private static readonly Lb4<User> m_UserObjectProvider = new Lb4<User>();

	private static Lb4<Rw3> m_MyFormsObjectProvider = new Lb4<Rw3>();

	private static readonly Lb4<f9X> m_MyWebServicesObjectProvider = new Lb4<f9X>();

	[HelpKeyword("My.Computer")]
	internal static Jp95 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Li2r Application
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
	internal static Rw3 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static f9X WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
