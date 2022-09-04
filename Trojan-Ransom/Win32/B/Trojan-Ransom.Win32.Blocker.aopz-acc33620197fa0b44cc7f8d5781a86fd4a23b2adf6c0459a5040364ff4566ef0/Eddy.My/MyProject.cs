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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using eJnHnFFEpEmlCQmkVB;

namespace Eddy.My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		public object m_Form1;

		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		public Form1 Form1
		{
			get
			{
				m_Form1 = Create__Instance__<Form1>(m_Form1);
				return (Form1)m_Form1;
			}
			set
			{
				if (value == m_Form1)
				{
					_ = 0;
					if (Hhd9BAtULMSG2p6jYk())
					{
						return;
					}
				}
				else if (value == null)
				{
					Dispose__Instance__(ref System.Runtime.CompilerServices.Unsafe.As<object, Form1>(ref m_Form1));
					return;
				}
				throw new ArgumentException("Property can only be set to Nothing");
			}
		}

		[DebuggerHidden]
		private unsafe static T Create__Instance__<T>(object Instance) where T : Form, new()
		{
			if (Instance != null && !((Control)(*(T*)(&Instance))).get_IsDisposed())
			{
				return (T)Instance;
			}
			if (m_FormBeingCreated != null)
			{
				if (m_FormBeingCreated.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
				}
			}
			else
			{
				m_FormBeingCreated = new Hashtable();
			}
			m_FormBeingCreated.Add(typeof(T), null);
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
				m_FormBeingCreated.Remove(typeof(T));
			}
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			((Component)instance).Dispose();
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyForms()
		{
			OkmkUfQI7AG2CUwXWa();
			ejRqpCDt0dkIRMsbSR(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return B1V1guG8PMS3N6a1Ty(this, qRmY8Ksg04RfB6Ai29(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return QdQtRbADsq0IuUl0oD(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return itMm5dWPwwHtRjtR4j(typeof(MyForms).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)lc5U5JnLMUuc1Hd4LR(this);
		}

		internal static bool Hhd9BAtULMSG2p6jYk()
		{
			return true;
		}

		internal static bool cyE59IYRX5JX2Koosv()
		{
			return false;
		}

		internal static void OkmkUfQI7AG2CUwXWa()
		{
			eWK97ZHZd8El3E8K9m.FwXDxNafX7Lru();
		}

		internal static void ejRqpCDt0dkIRMsbSR(object object_0)
		{
			object_0._002Ector();
		}

		internal static object qRmY8Ksg04RfB6Ai29(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static bool B1V1guG8PMS3N6a1Ty(object object_0, object object_1)
		{
			return object_0.Equals(object_1);
		}

		internal static int QdQtRbADsq0IuUl0oD(object object_0)
		{
			return object_0.GetHashCode();
		}

		internal static Type itMm5dWPwwHtRjtR4j(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static object lc5U5JnLMUuc1Hd4LR(object object_0)
		{
			return object_0.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyWebServices
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return N7SEnMm8MicXRllN46(this, w9sUFR8fV9ldcMcGXH(o));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return L1d5wJUujs9iJIx0jX(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return MfwSUKMkaBOGVUYVK8(typeof(MyWebServices).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return (string)LesR7jglCe8KFAbpTc(this);
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(object instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return (T)instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyWebServices()
		{
			tXTAH06I9dI1BicDP4();
			PYvpU4iImnI4iKAHoU(this);
		}

		internal static object w9sUFR8fV9ldcMcGXH(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static bool N7SEnMm8MicXRllN46(object object_0, object object_1)
		{
			return object_0.Equals(object_1);
		}

		internal static bool u3Ytsw4dKOVYBVMfpR()
		{
			return true;
		}

		internal static bool YaSiv1jAmPVV7ymgd5()
		{
			return false;
		}

		internal static int L1d5wJUujs9iJIx0jX(object object_0)
		{
			return object_0.GetHashCode();
		}

		internal static Type MfwSUKMkaBOGVUYVK8(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static object LesR7jglCe8KFAbpTc(object object_0)
		{
			return object_0.ToString();
		}

		internal static void tXTAH06I9dI1BicDP4()
		{
			eWK97ZHZd8El3E8K9m.FwXDxNafX7Lru();
		}

		internal static void PYvpU4iImnI4iKAHoU(object object_0)
		{
			object_0._002Ector();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public ThreadSafeObjectProvider()
		{
			eWK97ZHZd8El3E8K9m.FwXDxNafX7Lru();
			base._002Ector();
		}

		internal static bool jXDolalMB7M55tgRTh()
		{
			return true;
		}

		internal static bool K3GlAgKl5bByDTtdMG()
		{
			return false;
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider;

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider;

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider;

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider;

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider;

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
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
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}

	static MyProject()
	{
		hGiWHeJ3DJoULu9CY6();
		m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();
		m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
		m_UserObjectProvider = new ThreadSafeObjectProvider<User>();
		_ = 0;
		if (pxsF7gCsP1IJ1wVSHU())
		{
			m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();
		}
		m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
	}

	internal static void hGiWHeJ3DJoULu9CY6()
	{
		eWK97ZHZd8El3E8K9m.FwXDxNafX7Lru();
	}

	internal static bool pxsF7gCsP1IJ1wVSHU()
	{
		return true;
	}

	internal static bool f2dB2yFaVfPMjTmfr1()
	{
		return false;
	}
}
