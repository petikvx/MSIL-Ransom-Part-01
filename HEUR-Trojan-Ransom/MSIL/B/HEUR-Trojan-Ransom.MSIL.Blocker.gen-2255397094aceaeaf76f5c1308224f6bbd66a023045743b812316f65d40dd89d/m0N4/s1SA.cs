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
using Bj4;
using Kf57;
using Mb8k;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Wi0;
using Zf24;
using j5S;
using n3C4;
using q5D;
using z0F;

namespace m0N4;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class s1SA
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class x9LQ
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zx15 m_AddCTHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gm1x m_AddHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s4H m_AddKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s6R m_AddLSP;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q0E m_AddSp;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tw8 m_EditKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x5C m_Form1;

		public Zx15 AddCTHD
		{
			[DebuggerHidden]
			get
			{
				m_AddCTHD = i5X4(m_AddCTHD);
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
					r1P5(ref m_AddCTHD);
				}
			}
		}

		public Gm1x AddHD
		{
			[DebuggerHidden]
			get
			{
				m_AddHD = i5X4(m_AddHD);
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
					r1P5(ref m_AddHD);
				}
			}
		}

		public s4H AddKH
		{
			[DebuggerHidden]
			get
			{
				m_AddKH = i5X4(m_AddKH);
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
					r1P5(ref m_AddKH);
				}
			}
		}

		public s6R AddLSP
		{
			[DebuggerHidden]
			get
			{
				m_AddLSP = i5X4(m_AddLSP);
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
					r1P5(ref m_AddLSP);
				}
			}
		}

		public q0E AddSp
		{
			[DebuggerHidden]
			get
			{
				m_AddSp = i5X4(m_AddSp);
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
					r1P5(ref m_AddSp);
				}
			}
		}

		public Tw8 EditKH
		{
			[DebuggerHidden]
			get
			{
				m_EditKH = i5X4(m_EditKH);
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
					r1P5(ref m_EditKH);
				}
			}
		}

		public x5C Form1
		{
			[DebuggerHidden]
			get
			{
				m_Form1 = i5X4(m_Form1);
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
					r1P5(ref m_Form1);
				}
			}
		}

		[DebuggerHidden]
		private static Nm3s i5X4<Nm3s>(Nm3s n3SE) where Nm3s : Form, new()
		{
			if (n3SE == null || ((Control)n3SE).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Nm3s)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Nm3s), null);
				try
				{
					return new Nm3s();
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
					m_FormBeingCreated.Remove(typeof(Nm3s));
				}
			}
			return n3SE;
		}

		[DebuggerHidden]
		private void r1P5<t7YZ>(ref t7YZ Ga1c) where t7YZ : Form
		{
			((Component)Ga1c).Dispose();
			Ga1c = default(t7YZ);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public x9LQ()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool t2M3(object Qd7t)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Qd7t));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Tk78()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type s1C3()
		{
			return typeof(x9LQ);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Je20()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class g8ED
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Zg42(object o8YD)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o8YD));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int f8Z3()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type p9YQ()
		{
			return typeof(g8ED);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Lx53()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static y9WZ b4S7<y9WZ>(y9WZ i8Z7) where y9WZ : new()
		{
			if (i8Z7 == null)
			{
				return new y9WZ();
			}
			return i8Z7;
		}

		[DebuggerHidden]
		private void Qy0q<Da6e>(ref Da6e Ga07)
		{
			Ga07 = default(Da6e);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public g8ED()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Zb2p<o6EF> where o6EF : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static o6EF m_ThreadStaticValue;

		internal o6EF GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new o6EF();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zb2p()
		{
		}
	}

	private static readonly Zb2p<g9AM> m_ComputerObjectProvider = new Zb2p<g9AM>();

	private static readonly Zb2p<Ss34> m_AppObjectProvider = new Zb2p<Ss34>();

	private static readonly Zb2p<User> m_UserObjectProvider = new Zb2p<User>();

	private static Zb2p<x9LQ> m_MyFormsObjectProvider = new Zb2p<x9LQ>();

	private static readonly Zb2p<g8ED> m_MyWebServicesObjectProvider = new Zb2p<g8ED>();

	[HelpKeyword("My.Computer")]
	internal static g9AM Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Ss34 Application
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
	internal static x9LQ Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static g8ED WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
