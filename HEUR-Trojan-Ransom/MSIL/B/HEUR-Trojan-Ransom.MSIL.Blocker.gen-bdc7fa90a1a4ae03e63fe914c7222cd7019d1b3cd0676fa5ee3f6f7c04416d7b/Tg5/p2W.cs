using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ct5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Mk6;
using e7Q;
using r2D;
using x9X;
using y4S;

namespace Tg5;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class p2W
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Ss7
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zx0 m_Form2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Rs8 m_Form3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x7N m_Form4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y4S.Cj0 m_MainForm;

		private static Kf7 k1S<Kf7>(Kf7 Kn5) where Kf7 : Form, new()
		{
			if (Kn5 == null || ((Control)Kn5).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Kf7)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Kf7), null);
				try
				{
					return new Kf7();
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
					m_FormBeingCreated.Remove(typeof(Kf7));
				}
			}
			return Kn5;
		}

		private void g9Z<i3H>(ref i3H Wf6) where i3H : Form
		{
			((Component)Wf6).Dispose();
			Wf6 = default(i3H);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ss7()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool b9G(object An1)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(An1));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Gi0()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type x3Y()
		{
			return typeof(Ss7);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string y6N()
		{
			return base.ToString();
		}

		[SpecialName]
		public Zx0 k2Q()
		{
			m_Form2 = k1S(m_Form2);
			return m_Form2;
		}

		[SpecialName]
		public Rs8 p1H()
		{
			m_Form3 = k1S(m_Form3);
			return m_Form3;
		}

		[SpecialName]
		public x7N Cs0()
		{
			m_Form4 = k1S(m_Form4);
			return m_Form4;
		}

		[SpecialName]
		public y4S.Cj0 Mw8()
		{
			m_MainForm = k1S(m_MainForm);
			return m_MainForm;
		}

		[SpecialName]
		public void y4F(Zx0 Mp2)
		{
			if (Mp2 != m_Form2)
			{
				if (Mp2 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				g9Z(ref m_Form2);
			}
		}

		[SpecialName]
		public void Nb2(Rs8 Tz1)
		{
			if (Tz1 != m_Form3)
			{
				if (Tz1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				g9Z(ref m_Form3);
			}
		}

		[SpecialName]
		public void m6Y(x7N r5R)
		{
			if (r5R != m_Form4)
			{
				if (r5R != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				g9Z(ref m_Form4);
			}
		}

		[SpecialName]
		public void x6K(y4S.Cj0 Kz4)
		{
			if (Kz4 != m_MainForm)
			{
				if (Kz4 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				g9Z(ref m_MainForm);
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Cj0
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool b0J(object Xo9)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Xo9));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int e5Q()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Gz0()
		{
			return typeof(Cj0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Ec4()
		{
			return base.ToString();
		}

		private static Tx6 e1J<Tx6>(Tx6 t9L) where Tx6 : new()
		{
			if (t9L == null)
			{
				return new Tx6();
			}
			return t9L;
		}

		private void y3E<j9D>(ref j9D w7S)
		{
			w7S = default(j9D);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cj0()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Kd3<Hs9> where Hs9 : new()
	{
		[ThreadStatic]
		private static Hs9 m_ThreadStaticValue;

		[SpecialName]
		internal Hs9 Wz6()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new Hs9();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kd3()
		{
		}
	}

	private static readonly Kd3<Wb3> m_ComputerObjectProvider = new Kd3<Wb3>();

	private static readonly Kd3<j2K> m_AppObjectProvider = new Kd3<j2K>();

	private static readonly Kd3<User> m_UserObjectProvider = new Kd3<User>();

	private static Kd3<Ss7> m_MyFormsObjectProvider = new Kd3<Ss7>();

	private static readonly Kd3<Cj0> m_MyWebServicesObjectProvider = new Kd3<Cj0>();

	[HelpKeyword("My.Computer")]
	internal static Wb3 Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static j2K Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static Ss7 Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static Cj0 WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
