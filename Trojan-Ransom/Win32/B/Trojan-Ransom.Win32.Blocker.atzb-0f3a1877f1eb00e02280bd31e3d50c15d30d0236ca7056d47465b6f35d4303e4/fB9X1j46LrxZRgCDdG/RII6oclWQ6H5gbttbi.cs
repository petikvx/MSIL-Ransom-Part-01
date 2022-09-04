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
using Eddy;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using fRRx6BicIRcysE8uY6;
using oARW18aUNP1h8hw8qw;
using owHEyiNqBj2nT3DLoS;

namespace fB9X1j46LrxZRgCDdG;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class RII6oclWQ6H5gbttbi
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class OB7MNOqMQtFOhcYmmp
	{
		public Form1 Iqs3QhR3k;

		[ThreadStatic]
		private static Hashtable F8GhOqFe0;

		public Form1 Form1
		{
			get
			{
				Iqs3QhR3k = TxZCRgCDd(Iqs3QhR3k);
				return Iqs3QhR3k;
			}
			set
			{
				if (value != Iqs3QhR3k)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					B1Bu7MNOM(ref Iqs3QhR3k);
				}
			}
		}

		[DebuggerHidden]
		private static T TxZCRgCDd<T>(T Instance) where T : Form, new()
		{
			if (Instance != null && !((Control)Instance).get_IsDisposed())
			{
				return Instance;
			}
			if (F8GhOqFe0 != null)
			{
				if (F8GhOqFe0.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
				}
			}
			else
			{
				F8GhOqFe0 = new Hashtable();
			}
			F8GhOqFe0.Add(typeof(T), null);
			try
			{
				return new T();
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
				F8GhOqFe0.Remove(typeof(T));
			}
		}

		[DebuggerHidden]
		private void B1Bu7MNOM<T>(ref T gparam_0) where T : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public OB7MNOqMQtFOhcYmmp()
		{
			OvK5syuwLncDiFcn3n.whxSeZ6Qumm54();
			base._002Ector();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type dtFiOhcYm()
		{
			return typeof(OB7MNOqMQtFOhcYmmp);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class DCKXVukONON0Zfhyqs
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type ftA6W678O()
		{
			return typeof(DCKXVukONON0Zfhyqs);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T mXrTrPZXl<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void v9nFX715s<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public DCKXVukONON0Zfhyqs()
		{
			OvK5syuwLncDiFcn3n.whxSeZ6Qumm54();
			base._002Ector();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class dhR3kHe8GOqFe0ntAW<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T g3Vc3yYXU;

		[SpecialName]
		[DebuggerHidden]
		internal T cKnbOVJPr()
		{
			if (g3Vc3yYXU == null)
			{
				g3Vc3yYXU = new T();
			}
			return g3Vc3yYXU;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public dhR3kHe8GOqFe0ntAW()
		{
			OvK5syuwLncDiFcn3n.whxSeZ6Qumm54();
			base._002Ector();
		}
	}

	private static readonly dhR3kHe8GOqFe0ntAW<GcCpMKnciNLSh8RshO> FEy8iqBj2;

	private static readonly dhR3kHe8GOqFe0ntAW<fyvB8jQJeAOaEYxtcL> fT39DLoSO;

	private static readonly dhR3kHe8GOqFe0ntAW<User> HI6jocWQ6;

	private static dhR3kHe8GOqFe0ntAW<OB7MNOqMQtFOhcYmmp> F5g7bttbi;

	private static readonly dhR3kHe8GOqFe0ntAW<DCKXVukONON0Zfhyqs> fB9VX1j6L;

	[HelpKeyword("My.Computer")]
	internal static GcCpMKnciNLSh8RshO yhJaUgHIL
	{
		[DebuggerHidden]
		get
		{
			return FEy8iqBj2.cKnbOVJPr();
		}
	}

	[HelpKeyword("My.Application")]
	internal static fyvB8jQJeAOaEYxtcL wZONnyvB8
	{
		[DebuggerHidden]
		get
		{
			return fT39DLoSO.cKnbOVJPr();
		}
	}

	[HelpKeyword("My.User")]
	internal static User ttc4L7ARW
	{
		[DebuggerHidden]
		get
		{
			return HI6jocWQ6.cKnbOVJPr();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static OB7MNOqMQtFOhcYmmp vw8kqwtcC
	{
		[DebuggerHidden]
		get
		{
			return F5g7bttbi.cKnbOVJPr();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static DCKXVukONON0Zfhyqs v8RZshOjw
	{
		[DebuggerHidden]
		get
		{
			return fB9VX1j6L.cKnbOVJPr();
		}
	}

	static RII6oclWQ6H5gbttbi()
	{
		OvK5syuwLncDiFcn3n.whxSeZ6Qumm54();
		FEy8iqBj2 = new dhR3kHe8GOqFe0ntAW<GcCpMKnciNLSh8RshO>();
		fT39DLoSO = new dhR3kHe8GOqFe0ntAW<fyvB8jQJeAOaEYxtcL>();
		HI6jocWQ6 = new dhR3kHe8GOqFe0ntAW<User>();
		F5g7bttbi = new dhR3kHe8GOqFe0ntAW<OB7MNOqMQtFOhcYmmp>();
		fB9VX1j6L = new dhR3kHe8GOqFe0ntAW<DCKXVukONON0Zfhyqs>();
	}
}
