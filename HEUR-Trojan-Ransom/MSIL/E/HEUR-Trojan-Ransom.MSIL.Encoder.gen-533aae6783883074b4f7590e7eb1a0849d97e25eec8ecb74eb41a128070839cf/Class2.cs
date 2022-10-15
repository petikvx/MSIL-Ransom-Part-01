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
using Wana_Decrypt0r_Trojan_Syria_Editi0n;

[GeneratedCode("MyTemplate", "10.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Class2
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
		public Form1 form1_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		public Form1 Form1
		{
			[DebuggerNonUserCode]
			get
			{
				form1_0 = smethod_0(form1_0);
				return form1_0;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != form1_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					method_0(ref form1_0);
				}
			}
		}

		[DebuggerHidden]
		private static fdUa09nMUlMlLFWdf4 smethod_0<fdUa09nMUlMlLFWdf4>(fdUa09nMUlMlLFWdf4 m3CYBDfEQZvEmIwsaX) where fdUa09nMUlMlLFWdf4 : Form, new()
		{
			if ((m3CYBDfEQZvEmIwsaX == null || ((Control)m3CYBDfEQZvEmIwsaX).get_IsDisposed()) ? true : false)
			{
				if (hashtable_0 != null)
				{
					if (hashtable_0.ContainsKey(typeof(fdUa09nMUlMlLFWdf4)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					hashtable_0 = new Hashtable();
				}
				hashtable_0.Add(typeof(fdUa09nMUlMlLFWdf4), null);
				try
				{
					return new fdUa09nMUlMlLFWdf4();
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
					hashtable_0.Remove(typeof(fdUa09nMUlMlLFWdf4));
				}
			}
			return m3CYBDfEQZvEmIwsaX;
		}

		[DebuggerHidden]
		private void method_0<uAx77UZVHlQi7c0E1N>(ref uAx77UZVHlQi7c0E1N gparam_0) where uAx77UZVHlQi7c0E1N : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(uAx77UZVHlQi7c0E1N);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class3()
		{
			Class14.vPNVHkezq0oMI();
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
		internal Type method_1()
		{
			return typeof(Class3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class4
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
		internal Type method_0()
		{
			return typeof(Class4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static eon1FjJ3uIK12Zldt7 smethod_0<eon1FjJ3uIK12Zldt7>(eon1FjJ3uIK12Zldt7 VROo5ZSkICQDxk8Tm3) where eon1FjJ3uIK12Zldt7 : new()
		{
			if (VROo5ZSkICQDxk8Tm3 == null)
			{
				return new eon1FjJ3uIK12Zldt7();
			}
			return VROo5ZSkICQDxk8Tm3;
		}

		[DebuggerHidden]
		private void method_1<qNtG5iedjfKWKfnQj7>(ref qNtG5iedjfKWKfnQj7 gparam_0)
		{
			gparam_0 = default(qNtG5iedjfKWKfnQj7);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
			Class14.vPNVHkezq0oMI();
			base._002Ector();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class5<cT1b7rsPWMGPTAPVLt> where cT1b7rsPWMGPTAPVLt : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static cT1b7rsPWMGPTAPVLt gparam_0;

		[SpecialName]
		[DebuggerHidden]
		internal cT1b7rsPWMGPTAPVLt method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new cT1b7rsPWMGPTAPVLt();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class5()
		{
			Class14.vPNVHkezq0oMI();
			base._002Ector();
		}
	}

	private static readonly Class5<Class1> class5_0;

	private static readonly Class5<Form0> class5_1;

	private static readonly Class5<User> class5_2;

	private static Class5<Class3> class5_3;

	private static readonly Class5<Class4> class5_4;

	[HelpKeyword("My.Computer")]
	internal static Class1 Class1_0
	{
		[DebuggerHidden]
		get
		{
			return class5_0.method_0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			return class5_1.method_0();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class5_2.method_0();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			return class5_3.method_0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			return class5_4.method_0();
		}
	}

	[DebuggerNonUserCode]
	static Class2()
	{
		Class14.vPNVHkezq0oMI();
		class5_0 = new Class5<Class1>();
		class5_1 = new Class5<Form0>();
		class5_2 = new Class5<User>();
		class5_3 = new Class5<Class3>();
		class5_4 = new Class5<Class4>();
	}
}
