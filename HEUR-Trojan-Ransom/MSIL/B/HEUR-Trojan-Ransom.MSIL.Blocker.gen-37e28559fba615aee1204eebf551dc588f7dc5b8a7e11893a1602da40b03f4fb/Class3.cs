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
using FL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Class3
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class4
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form1 form1_0;

		public Form1 Form1
		{
			[DebuggerHidden]
			get
			{
				form1_0 = smethod_0(form1_0);
				return form1_0;
			}
			[DebuggerHidden]
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
		private static YIWWOeoifbcNyZHJcN smethod_0<YIWWOeoifbcNyZHJcN>(YIWWOeoifbcNyZHJcN QAZEDZNq1ZAD9csa7C) where YIWWOeoifbcNyZHJcN : Form, new()
		{
			if (QAZEDZNq1ZAD9csa7C == null || ((Control)QAZEDZNq1ZAD9csa7C).get_IsDisposed())
			{
				if (hashtable_0 != null)
				{
					if (hashtable_0.ContainsKey(typeof(YIWWOeoifbcNyZHJcN)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					hashtable_0 = new Hashtable();
				}
				hashtable_0.Add(typeof(YIWWOeoifbcNyZHJcN), null);
				try
				{
					return new YIWWOeoifbcNyZHJcN();
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
					hashtable_0.Remove(typeof(YIWWOeoifbcNyZHJcN));
				}
			}
			return QAZEDZNq1ZAD9csa7C;
		}

		[DebuggerHidden]
		private void method_0<Fqp7PtCKVffDW9bqlH>(ref Fqp7PtCKVffDW9bqlH gparam_0) where Fqp7PtCKVffDW9bqlH : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(Fqp7PtCKVffDW9bqlH);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
			Class8.t3hvLuccnmfIO();
			Class8.t3hvLuccnmfIO();
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
			return typeof(Class4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class5
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class5);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static PJcsTQbWyUt7ciZhCU smethod_0<PJcsTQbWyUt7ciZhCU>(PJcsTQbWyUt7ciZhCU W4baBYPlhIBbhtD5sE) where PJcsTQbWyUt7ciZhCU : new()
		{
			if (W4baBYPlhIBbhtD5sE == null)
			{
				return new PJcsTQbWyUt7ciZhCU();
			}
			return W4baBYPlhIBbhtD5sE;
		}

		[DebuggerHidden]
		private void method_1<Xk8ntQO41BGdHWgr4F>(ref Xk8ntQO41BGdHWgr4F gparam_0)
		{
			gparam_0 = default(Xk8ntQO41BGdHWgr4F);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class5()
		{
			Class8.t3hvLuccnmfIO();
			Class8.t3hvLuccnmfIO();
			base._002Ector();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class6<KNF1MwuiZZqhTSxHo8> where KNF1MwuiZZqhTSxHo8 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static KNF1MwuiZZqhTSxHo8 gparam_0;

		[SpecialName]
		[DebuggerHidden]
		internal KNF1MwuiZZqhTSxHo8 method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new KNF1MwuiZZqhTSxHo8();
			}
			return gparam_0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class6()
		{
			Class8.t3hvLuccnmfIO();
			Class8.t3hvLuccnmfIO();
			base._002Ector();
		}
	}

	private static readonly Class6<Class2> class6_0;

	private static readonly Class6<Form0> class6_1;

	private static readonly Class6<User> class6_2;

	private static Class6<Class4> class6_3;

	private static readonly Class6<Class5> class6_4;

	[HelpKeyword("My.Computer")]
	internal static Class2 Class2_0
	{
		[DebuggerHidden]
		get
		{
			return class6_0.method_0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			return class6_1.method_0();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class6_2.method_0();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			return class6_3.method_0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class5 Class5_0
	{
		[DebuggerHidden]
		get
		{
			return class6_4.method_0();
		}
	}

	static Class3()
	{
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		class6_0 = new Class6<Class2>();
		class6_1 = new Class6<Form0>();
		class6_2 = new Class6<User>();
		class6_3 = new Class6<Class4>();
		class6_4 = new Class6<Class5>();
	}
}
