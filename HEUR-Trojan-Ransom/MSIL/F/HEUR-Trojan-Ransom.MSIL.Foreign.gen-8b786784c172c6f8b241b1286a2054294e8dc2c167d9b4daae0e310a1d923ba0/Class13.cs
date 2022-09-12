using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

internal sealed class Class13
{
	private sealed class Class14 : IEnumerator<string>, IEnumerable<string>, IEnumerable, IEnumerator, IDisposable
	{
		private int int_0;

		private string string_0;

		private int int_1;

		private string string_1;

		public string string_2;

		public Class13 class13_0;

		private bool bool_0;

		private Queue<string> queue_0;

		private string[] string_3;

		private string[] string_4;

		private int int_2;

		private string string_5;

		private int int_3;

		string IEnumerator<string>.Current
		{
			[DebuggerHidden]
			get
			{
				return string_0;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return string_0;
			}
		}

		[DebuggerHidden]
		public Class14(int int_4)
		{
			int_0 = int_4;
			int_1 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = int_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				int_0 = -1;
				int_3++;
				goto IL_0133;
			}
			int_0 = -1;
			queue_0 = new Queue<string>();
			queue_0.Enqueue(string_1);
			goto IL_004f;
			IL_004f:
			bool_0 = queue_0.Count > 0 && !class13_0.gclass2_0.bool_7;
			if (bool_0)
			{
				string_1 = queue_0.Dequeue();
				try
				{
					string_4 = Directory.GetDirectories(string_1);
					int_2 = 0;
					while (int_2 < string_4.Length)
					{
						string_5 = string_4[int_2];
						if (class13_0.method_5(string_5) && !class13_0.list_1.Contains(string_5.ToLower()))
						{
							queue_0.Enqueue(string_5);
						}
						string_5 = null;
						int_2++;
					}
					string_4 = null;
				}
				catch
				{
				}
				string_3 = Directory.GetFiles(string_1);
				if (string_3 != null)
				{
					int_3 = 0;
					goto IL_0133;
				}
				goto IL_0145;
			}
			return false;
			IL_0145:
			string_3 = null;
			goto IL_004f;
			IL_0133:
			if (int_3 < string_3.Length)
			{
				string_0 = string_3[int_3];
				int_0 = 1;
				return true;
			}
			goto IL_0145;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			Class14 @class;
			if (int_0 == -2 && int_1 == Environment.CurrentManagedThreadId)
			{
				int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class14(0);
				@class.class13_0 = class13_0;
			}
			@class.string_1 = string_2;
			return @class;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<string>)this).GetEnumerator();
		}
	}

	public List<string> list_0 = new List<string>();

	public bool bool_0 = false;

	public string string_0;

	public GClass2 gclass2_0;

	public int int_0 = 0;

	public List<string> list_1 = new List<string>();

	public List<string> list_2 = new List<string>();

	public int int_1 = 0;

	public Class13()
	{
		List<string> list = list_1;
		char[] separator = new char[1] { '|' };
		list.Add(Class11.smethod_0(-2094345772).Split(separator)[0]);
		List<string> list2 = list_1;
		separator = new char[1] { '|' };
		list2.Add(Class11.smethod_0(-2094345970).Split(separator)[0]);
		List<string> list3 = list_1;
		separator = new char[1] { '|' };
		list3.Add(Class11.smethod_0(-2094345967).Split(separator)[0]);
		List<string> list4 = list_1;
		separator = new char[1] { '|' };
		list4.Add(Class11.smethod_0(-2094345932).Split(separator)[0]);
		List<string> list5 = list_1;
		separator = new char[1] { '|' };
		list5.Add(Class11.smethod_0(-2094345901).Split(separator)[0]);
		List<string> list6 = list_1;
		separator = new char[1] { '|' };
		list6.Add(Class11.smethod_0(-2094345860).Split(separator)[0]);
	}

	[IteratorStateMachine(typeof(Class14))]
	public IEnumerable<string> method_0(string string_1)
	{
		return new Class14(-2)
		{
			class13_0 = this,
			string_2 = string_1
		};
	}

	public string method_1(string string_1)
	{
		string text = string.Empty;
		if (Directory.Exists(string_1))
		{
			string[] directories = Directory.GetDirectories(string_1);
			foreach (string text2 in directories)
			{
				if (method_5(text2))
				{
					char[] separator = new char[1] { '|' };
					text = text + text2 + Class11.smethod_0(-2094343391).Split(separator)[0];
				}
			}
		}
		return text;
	}

	public void method_2(string string_1)
	{
		gclass2_0.bool_7 = false;
		list_0.Clear();
		list_2.Clear();
		int_1 = 0;
		int_0 = 0;
		char[] separator = new char[1] { '<' };
		string[] array = string_1.Split(separator);
		if (array.Length <= 1)
		{
			return;
		}
		string text = array[0];
		separator = new char[1] { '>' };
		string[] array2 = text.Split(separator);
		foreach (string text2 in array2)
		{
			if (text2 != string.Empty)
			{
				list_0.Add(text2);
			}
		}
		if (!(array[1] != string.Empty))
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			bool_0 = true;
			DriveInfo[] array3 = drives;
			foreach (DriveInfo driveInfo in array3)
			{
				if (driveInfo.IsReady)
				{
					method_6(driveInfo.Name);
				}
			}
			GClass2 gClass = gclass2_0;
			separator = new char[1] { '!' };
			gClass.method_12(null, Class11.smethod_0(-2094346091).Split(separator)[0], bool_8: false);
			bool_0 = false;
		}
		else
		{
			bool_0 = true;
			method_6(array[1]);
			bool_0 = false;
			GClass2 gClass2 = gclass2_0;
			separator = new char[1] { '!' };
			gClass2.method_12(null, Class11.smethod_0(-2094346045).Split(separator)[0], bool_8: false);
		}
	}

	public string method_3()
	{
		string text = string.Empty;
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.IsReady)
			{
				string name = driveInfo.Name;
				char[] separator = new char[1] { '!' };
				text = text + name + Class11.smethod_0(-2094343649).Split(separator)[0];
			}
		}
		return text;
	}

	public string method_4(string string_1)
	{
		string text = string.Empty;
		if (Directory.Exists(string_1))
		{
			string[] files = Directory.GetFiles(string_1);
			foreach (string text2 in files)
			{
				char[] separator = new char[1] { '|' };
				text = text + text2 + Class11.smethod_0(-2094343391).Split(separator)[0];
			}
		}
		return text;
	}

	public bool method_5(string string_1)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
		try
		{
			directoryInfo.GetDirectories();
			return true;
		}
		catch (Exception ex)
		{
			bool result = false;
			ex.GetType();
			return result;
		}
	}

	public void method_6(string string_1)
	{
		try
		{
			foreach (string item in method_0(string_1))
			{
				char[] separator = new char[1] { '!' };
				int num = item.LastIndexOf(Class11.smethod_0(-2094345510).Split(separator)[0]);
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (list_0.Contains(text.ToLower()))
				{
					string text2 = gclass2_0.gclass1_0.method_5(item, bool_0: true);
					GClass2 gClass = gclass2_0;
					separator = new char[1] { '!' };
					string text3 = Class11.smethod_0(-2094345989).Split(separator)[0];
					separator = new char[1] { '!' };
					gClass.method_12(null, text3 + item + Class11.smethod_0(-2094346213).Split(separator)[0] + text2, bool_8: false);
				}
				if (gclass2_0.bool_7)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}
}
