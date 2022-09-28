using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ec7;
using Lb5n;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Mw03;
using Sp4a;
using Sz3t;
using Wi84;
using b9NH;
using o8G9;
using q8R9;
using w9Z7;
using x5X;

namespace m5GN;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Lg27
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Be1p
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f2W9 m_DeleteRecord;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q9QN m_DisplayRecord;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i2RH m_DisplaysingleRecord;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z8L1 m_EditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p1RD m_Form1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t9L5 m_Form2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zy4k m_Form3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bf2 m_Form4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ts5 m_Form5;

		private static w0ZL Sx15<w0ZL>(w0ZL d3ZR) where w0ZL : Form, new()
		{
			if (d3ZR == null || ((Control)d3ZR).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(w0ZL)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(w0ZL), null);
				try
				{
					return new w0ZL();
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
					m_FormBeingCreated.Remove(typeof(w0ZL));
				}
			}
			return d3ZR;
		}

		private void Ha7e<Ca83>(ref Ca83 Jn7e) where Ca83 : Form
		{
			((Component)Jn7e).Dispose();
			Jn7e = default(Ca83);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Be1p()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Tp45(object i7T9)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(i7T9));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Wo71()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Xk0w()
		{
			return typeof(Be1p);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string x0PQ()
		{
			return base.ToString();
		}

		[SpecialName]
		public f2W9 Yc98()
		{
			m_DeleteRecord = Sx15(m_DeleteRecord);
			return m_DeleteRecord;
		}

		[SpecialName]
		public q9QN Re3d()
		{
			m_DisplayRecord = Sx15(m_DisplayRecord);
			return m_DisplayRecord;
		}

		[SpecialName]
		public i2RH n1X9()
		{
			m_DisplaysingleRecord = Sx15(m_DisplaysingleRecord);
			return m_DisplaysingleRecord;
		}

		[SpecialName]
		public z8L1 Qo97()
		{
			m_EditForm = Sx15(m_EditForm);
			return m_EditForm;
		}

		[SpecialName]
		public p1RD b3SG()
		{
			m_Form1 = Sx15(m_Form1);
			return m_Form1;
		}

		[SpecialName]
		public t9L5 x8R2()
		{
			m_Form2 = Sx15(m_Form2);
			return m_Form2;
		}

		[SpecialName]
		public Zy4k o3SQ()
		{
			m_Form3 = Sx15(m_Form3);
			return m_Form3;
		}

		[SpecialName]
		public Bf2 i4J2()
		{
			m_Form4 = Sx15(m_Form4);
			return m_Form4;
		}

		[SpecialName]
		public Ts5 Af9x()
		{
			m_Form5 = Sx15(m_Form5);
			return m_Form5;
		}

		[SpecialName]
		public void Yz74(f2W9 d3BZ)
		{
			if (d3BZ != m_DeleteRecord)
			{
				if (d3BZ != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ha7e(ref m_DeleteRecord);
			}
		}

		[SpecialName]
		public void Zx1y(q9QN i7A4)
		{
			if (i7A4 != m_DisplayRecord)
			{
				if (i7A4 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ha7e(ref m_DisplayRecord);
			}
		}

		[SpecialName]
		public void f1PQ(i2RH Eb43)
		{
			if (Eb43 != m_DisplaysingleRecord)
			{
				if (Eb43 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ha7e(ref m_DisplaysingleRecord);
			}
		}

		[SpecialName]
		public void o2K9(z8L1 Hg3f)
		{
			if (Hg3f != m_EditForm)
			{
				if (Hg3f != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ha7e(ref m_EditForm);
			}
		}

		[SpecialName]
		public void Jp9x(p1RD Ga63)
		{
			if (Ga63 != m_Form1)
			{
				if (Ga63 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ha7e(ref m_Form1);
			}
		}

		[SpecialName]
		public void o1Y8(t9L5 Qe0f)
		{
			if (Qe0f != m_Form2)
			{
				if (Qe0f != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ha7e(ref m_Form2);
			}
		}

		[SpecialName]
		public void z5A1(Zy4k Ce49)
		{
			if (Ce49 != m_Form3)
			{
				if (Ce49 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ha7e(ref m_Form3);
			}
		}

		[SpecialName]
		public void w6FA(Bf2 Ts3x)
		{
			if (Ts3x != m_Form4)
			{
				if (Ts3x != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ha7e(ref m_Form4);
			}
		}

		[SpecialName]
		public void Yd7e(Ts5 Hq8b)
		{
			if (Hq8b != m_Form5)
			{
				if (Hq8b != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ha7e(ref m_Form5);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Hc4f
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool b2T4(object Hc3o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Hc3o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int w2F1()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type a9ZR()
		{
			return typeof(Hc4f);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Yo61()
		{
			return base.ToString();
		}

		private static De0m t0J7<De0m>(De0m x3PB) where De0m : new()
		{
			if (x3PB == null)
			{
				return new De0m();
			}
			return x3PB;
		}

		private void Ti0t<r0D4>(ref r0D4 y6Q3)
		{
			y6Q3 = default(r0D4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hc4f()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Gs79<Fd3y> where Fd3y : new()
	{
		[ThreadStatic]
		private static Fd3y m_ThreadStaticValue;

		[SpecialName]
		internal Fd3y j9JW()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new Fd3y();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gs79()
		{
		}
	}

	private static readonly Gs79<Ks6z> m_ComputerObjectProvider = new Gs79<Ks6z>();

	private static readonly Gs79<Em51> m_AppObjectProvider = new Gs79<Em51>();

	private static readonly Gs79<User> m_UserObjectProvider = new Gs79<User>();

	private static Gs79<Be1p> m_MyFormsObjectProvider = new Gs79<Be1p>();

	private static readonly Gs79<Hc4f> m_MyWebServicesObjectProvider = new Gs79<Hc4f>();

	[HelpKeyword("My.Computer")]
	internal static Ks6z Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static Em51 Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static Be1p Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static Hc4f WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
