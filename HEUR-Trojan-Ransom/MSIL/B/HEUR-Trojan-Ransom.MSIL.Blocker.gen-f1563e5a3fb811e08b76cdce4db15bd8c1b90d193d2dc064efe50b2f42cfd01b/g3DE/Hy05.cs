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
using Lw62;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Nb0p;
using Py9j;
using Tr56;
using m3AQ;
using m7Y5;
using n9D6;
using w1F4;
using x1JM;

namespace g3DE;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Hy05
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Ef26
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public r2XZ m_AddCTHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fq78 m_AddHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x0X2 m_AddKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d9LM m_AddLSP;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i7M0 m_AddSp;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fd48 m_EditKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g6DW m_Form1;

		public r2XZ AddCTHD
		{
			[DebuggerHidden]
			get
			{
				m_AddCTHD = Fw0q(m_AddCTHD);
				return m_AddCTHD;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddCTHD)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Xi0k(ref m_AddCTHD);
				}
			}
		}

		public Fq78 AddHD
		{
			[DebuggerHidden]
			get
			{
				m_AddHD = Fw0q(m_AddHD);
				return m_AddHD;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddHD)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Xi0k(ref m_AddHD);
				}
			}
		}

		public x0X2 AddKH
		{
			[DebuggerHidden]
			get
			{
				m_AddKH = Fw0q(m_AddKH);
				return m_AddKH;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddKH)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Xi0k(ref m_AddKH);
				}
			}
		}

		public d9LM AddLSP
		{
			[DebuggerHidden]
			get
			{
				m_AddLSP = Fw0q(m_AddLSP);
				return m_AddLSP;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddLSP)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Xi0k(ref m_AddLSP);
				}
			}
		}

		public i7M0 AddSp
		{
			[DebuggerHidden]
			get
			{
				m_AddSp = Fw0q(m_AddSp);
				return m_AddSp;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddSp)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Xi0k(ref m_AddSp);
				}
			}
		}

		public Fd48 EditKH
		{
			[DebuggerHidden]
			get
			{
				m_EditKH = Fw0q(m_EditKH);
				return m_EditKH;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_EditKH)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Xi0k(ref m_EditKH);
				}
			}
		}

		public g6DW Form1
		{
			[DebuggerHidden]
			get
			{
				m_Form1 = Fw0q(m_Form1);
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
					Xi0k(ref m_Form1);
				}
			}
		}

		[DebuggerHidden]
		private static e1KY Fw0q<e1KY>(e1KY m1E8) where e1KY : Form, new()
		{
			if (m1E8 == null || ((Control)m1E8).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(e1KY)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(e1KY), null);
				try
				{
					return new e1KY();
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
					m_FormBeingCreated.Remove(typeof(e1KY));
				}
			}
			return m1E8;
		}

		[DebuggerHidden]
		private void Xi0k<Zo4x>(ref Zo4x Sj7x) where Zo4x : Form
		{
			((Component)Sj7x).Dispose();
			Sj7x = default(Zo4x);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ef26()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool g4H8(object Yr68)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Yr68));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int d5TK()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type An20()
		{
			return typeof(Ef26);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string s8D6()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class s7EG
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Fy43(object i7E3)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(i7E3));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Rm7y()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Cy1j()
		{
			return typeof(s7EG);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Zq6f()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static n5C7 Zn6y<n5C7>(n5C7 f5LE) where n5C7 : new()
		{
			if (f5LE == null)
			{
				return new n5C7();
			}
			return f5LE;
		}

		[DebuggerHidden]
		private void Jn17<c6B2>(ref c6B2 w2KN)
		{
			w2KN = default(c6B2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public s7EG()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class e6Q9<Fm3k> where Fm3k : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static Fm3k m_ThreadStaticValue;

		internal Fm3k GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Fm3k();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public e6Q9()
		{
		}
	}

	private static readonly e6Q9<q7QA> m_ComputerObjectProvider = new e6Q9<q7QA>();

	private static readonly e6Q9<Yf73> m_AppObjectProvider = new e6Q9<Yf73>();

	private static readonly e6Q9<User> m_UserObjectProvider = new e6Q9<User>();

	private static e6Q9<Ef26> m_MyFormsObjectProvider = new e6Q9<Ef26>();

	private static readonly e6Q9<s7EG> m_MyWebServicesObjectProvider = new e6Q9<s7EG>();

	[HelpKeyword("My.Computer")]
	internal static q7QA Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Yf73 Application
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
	internal static Ef26 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static s7EG WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
