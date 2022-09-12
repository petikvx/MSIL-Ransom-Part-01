using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ar3;
using Cq2e;
using Eb2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Qs7b;
using Xy3m;
using e4PA;
using e7H;
using i2D;
using o3D8;
using q3CD;
using r4CR;
using s9M4;
using t4AQ;
using x5NZ;
using y0R;
using z1F4;
using z7XZ;

namespace Lt35;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Fb9z
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class m5BJ
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lt8o m_AboutBox1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g0W3 m_Form1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zz9s m_Form10;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tf4 m_Form11;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Yg3 m_Form12;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pd2t m_Form2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m8Q3 m_Form3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tb17 m_Form4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Se8q m_Form5;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ky82 m_Form6;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lb0 m_Form7;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nb6 m_Form8;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fx6 m_Form9;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mj02 m_loading;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o9ZJ m_SplashScreen1;

		private static Rp2c s4X1<Rp2c>(Rp2c w6WY) where Rp2c : Form, new()
		{
			if (w6WY == null || ((Control)w6WY).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Rp2c)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Rp2c), null);
				try
				{
					return new Rp2c();
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
					m_FormBeingCreated.Remove(typeof(Rp2c));
				}
			}
			return w6WY;
		}

		private void Ds68<j3Z4>(ref j3Z4 d2RC) where j3Z4 : Form
		{
			((Component)d2RC).Dispose();
			d2RC = default(j3Z4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m5BJ()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Bq6o(object So6n)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(So6n));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int i2K8()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Pm8x()
		{
			return typeof(m5BJ);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Ey80()
		{
			return base.ToString();
		}

		[SpecialName]
		public Lt8o i2QJ()
		{
			m_AboutBox1 = s4X1(m_AboutBox1);
			return m_AboutBox1;
		}

		[SpecialName]
		public g0W3 Ad5o()
		{
			m_Form1 = s4X1(m_Form1);
			return m_Form1;
		}

		[SpecialName]
		public Zz9s Lf03()
		{
			m_Form10 = s4X1(m_Form10);
			return m_Form10;
		}

		[SpecialName]
		public Tf4 Sp72()
		{
			m_Form11 = s4X1(m_Form11);
			return m_Form11;
		}

		[SpecialName]
		public Yg3 Sk78()
		{
			m_Form12 = s4X1(m_Form12);
			return m_Form12;
		}

		[SpecialName]
		public Pd2t n2B5()
		{
			m_Form2 = s4X1(m_Form2);
			return m_Form2;
		}

		[SpecialName]
		public m8Q3 Mr4f()
		{
			m_Form3 = s4X1(m_Form3);
			return m_Form3;
		}

		[SpecialName]
		public Tb17 o1ZY()
		{
			m_Form4 = s4X1(m_Form4);
			return m_Form4;
		}

		[SpecialName]
		public Se8q e5R8()
		{
			m_Form5 = s4X1(m_Form5);
			return m_Form5;
		}

		[SpecialName]
		public Ky82 r8G3()
		{
			m_Form6 = s4X1(m_Form6);
			return m_Form6;
		}

		[SpecialName]
		public Lb0 Wf6k()
		{
			m_Form7 = s4X1(m_Form7);
			return m_Form7;
		}

		[SpecialName]
		public Nb6 Yj25()
		{
			m_Form8 = s4X1(m_Form8);
			return m_Form8;
		}

		[SpecialName]
		public Fx6 Dz1i()
		{
			m_Form9 = s4X1(m_Form9);
			return m_Form9;
		}

		[SpecialName]
		public Mj02 j1CF()
		{
			m_loading = s4X1(m_loading);
			return m_loading;
		}

		[SpecialName]
		public o9ZJ y2B3()
		{
			m_SplashScreen1 = s4X1(m_SplashScreen1);
			return m_SplashScreen1;
		}

		[SpecialName]
		public void Sr91(Lt8o Rc6m)
		{
			if (Rc6m != m_AboutBox1)
			{
				if (Rc6m != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_AboutBox1);
			}
		}

		[SpecialName]
		public void d3RK(g0W3 o5H6)
		{
			if (o5H6 != m_Form1)
			{
				if (o5H6 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_Form1);
			}
		}

		[SpecialName]
		public void Ak41(Zz9s b4YH)
		{
			if (b4YH != m_Form10)
			{
				if (b4YH != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_Form10);
			}
		}

		[SpecialName]
		public void k4J6(Tf4 d4F2)
		{
			if (d4F2 != m_Form11)
			{
				if (d4F2 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_Form11);
			}
		}

		[SpecialName]
		public void t6K1(Yg3 d7WR)
		{
			if (d7WR != m_Form12)
			{
				if (d7WR != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_Form12);
			}
		}

		[SpecialName]
		public void Hc48(Pd2t Aa6o)
		{
			if (Aa6o != m_Form2)
			{
				if (Aa6o != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_Form2);
			}
		}

		[SpecialName]
		public void Gt0r(m8Q3 Hz5q)
		{
			if (Hz5q != m_Form3)
			{
				if (Hz5q != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_Form3);
			}
		}

		[SpecialName]
		public void f2W3(Tb17 z5M3)
		{
			if (z5M3 != m_Form4)
			{
				if (z5M3 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_Form4);
			}
		}

		[SpecialName]
		public void Ej29(Se8q Cx4n)
		{
			if (Cx4n != m_Form5)
			{
				if (Cx4n != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_Form5);
			}
		}

		[SpecialName]
		public void Gc9m(Ky82 y4R5)
		{
			if (y4R5 != m_Form6)
			{
				if (y4R5 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_Form6);
			}
		}

		[SpecialName]
		public void Mw76(Lb0 m3P5)
		{
			if (m3P5 != m_Form7)
			{
				if (m3P5 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_Form7);
			}
		}

		[SpecialName]
		public void Kp7b(Nb6 o4B6)
		{
			if (o4B6 != m_Form8)
			{
				if (o4B6 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_Form8);
			}
		}

		[SpecialName]
		public void Cs9c(Fx6 Jx59)
		{
			if (Jx59 != m_Form9)
			{
				if (Jx59 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_Form9);
			}
		}

		[SpecialName]
		public void k1F9(Mj02 Jb3q)
		{
			if (Jb3q != m_loading)
			{
				if (Jb3q != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_loading);
			}
		}

		[SpecialName]
		public void Ba9p(o9ZJ Re01)
		{
			if (Re01 != m_SplashScreen1)
			{
				if (Re01 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ds68(ref m_SplashScreen1);
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Pq28
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool d3J8(object Rk04)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Rk04));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Ei06()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Nq2n()
		{
			return typeof(Pq28);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Cq16()
		{
			return base.ToString();
		}

		private static o0XY p7HL<o0XY>(o0XY Mi7z) where o0XY : new()
		{
			if (Mi7z == null)
			{
				return new o0XY();
			}
			return Mi7z;
		}

		private void Hw0t<i9QZ>(ref i9QZ Zi3m)
		{
			Zi3m = default(i9QZ);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pq28()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Cm7q<w9H6> where w9H6 : new()
	{
		[ThreadStatic]
		private static w9H6 m_ThreadStaticValue;

		[SpecialName]
		internal w9H6 Ya01()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new w9H6();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cm7q()
		{
		}
	}

	private static readonly Cm7q<c4FN> m_ComputerObjectProvider = new Cm7q<c4FN>();

	private static readonly Cm7q<Di0m> m_AppObjectProvider = new Cm7q<Di0m>();

	private static readonly Cm7q<User> m_UserObjectProvider = new Cm7q<User>();

	private static Cm7q<m5BJ> m_MyFormsObjectProvider = new Cm7q<m5BJ>();

	private static readonly Cm7q<Pq28> m_MyWebServicesObjectProvider = new Cm7q<Pq28>();

	[HelpKeyword("My.Computer")]
	internal static c4FN Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static Di0m Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static m5BJ Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static Pq28 WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
