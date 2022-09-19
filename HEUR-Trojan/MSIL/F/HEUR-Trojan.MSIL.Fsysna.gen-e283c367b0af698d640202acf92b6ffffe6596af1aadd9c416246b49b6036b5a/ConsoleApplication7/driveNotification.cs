using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ConsoleApplication7;

public sealed class driveNotification
{
	public class NotificationForm : Form
	{
		private static string _2xM_003D;

		protected override CreateParams CreateParams
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NotificationForm()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _3BM_003D(Regex pattern)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void WndProc(ref Message m)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetText()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetText(string txt)
		{
		}

		static NotificationForm()
		{
			_003CAgileDotNetRT_003E.Initialize();
			_003CAgileDotNetRT_003E.PostInitialize();
			_2xM_003D = GetText();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public driveNotification()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static driveNotification()
	{
		_003CAgileDotNetRT_003E.Initialize();
		_003CAgileDotNetRT_003E.PostInitialize();
	}
}
