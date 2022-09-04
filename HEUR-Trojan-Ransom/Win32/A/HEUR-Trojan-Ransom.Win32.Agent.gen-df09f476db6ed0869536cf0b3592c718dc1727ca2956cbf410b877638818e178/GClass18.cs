using System;

public class GClass18
{
	private class Class49
	{
		public ulong ulong_0;

		public ulong ulong_1;

		public ulong ulong_2;

		public ulong ulong_3;

		public ulong ulong_4;

		public ulong ulong_5;

		private DateTime dateTime_0;

		public void method_0(ulong ulong_6)
		{
			ulong_0 += ulong_6;
			while (ulong_0 > 1024L)
			{
				ulong_1++;
				ulong_0 -= 1024uL;
			}
			while (ulong_1 > 1024L)
			{
				ulong_2++;
				ulong_1 -= 1024uL;
			}
			while (ulong_2 > 1024L)
			{
				ulong_3++;
				ulong_2 -= 1024uL;
			}
			while (ulong_3 > 1024L)
			{
				ulong_4++;
				ulong_3 -= 1024uL;
			}
			while (ulong_4 > 1024L)
			{
				ulong_5++;
				ulong_4 -= 1024uL;
			}
		}

		public override string ToString()
		{
			if (ulong_5 > 0L)
			{
				double num = (double)ulong_5 + (double)ulong_4 / 1024.0;
				num /= (DateTime.Now - dateTime_0).TotalSeconds;
				dateTime_0 = DateTime.Now;
				string text = num.ToString();
				if (text.Length > 6)
				{
					text = text.Substring(0, 6);
				}
				return text + " PB";
			}
			if (ulong_4 > 0L)
			{
				double num2 = (double)ulong_4 + (double)ulong_3 / 1024.0;
				num2 /= (DateTime.Now - dateTime_0).TotalSeconds;
				dateTime_0 = DateTime.Now;
				string text2 = num2.ToString();
				if (text2.Length > 6)
				{
					text2 = text2.Substring(0, 6);
				}
				return text2 + " TB";
			}
			if (ulong_3 > 0L)
			{
				double num3 = (double)ulong_3 + (double)ulong_2 / 1024.0;
				num3 /= (DateTime.Now - dateTime_0).TotalSeconds;
				dateTime_0 = DateTime.Now;
				string text3 = num3.ToString();
				if (text3.Length > 6)
				{
					text3 = text3.Substring(0, 6);
				}
				return text3 + " GB";
			}
			if (ulong_2 > 0L)
			{
				double num4 = (double)ulong_2 + (double)ulong_1 / 1024.0;
				num4 /= (DateTime.Now - dateTime_0).TotalSeconds;
				dateTime_0 = DateTime.Now;
				string text4 = num4.ToString();
				if (text4.Length > 6)
				{
					text4 = text4.Substring(0, 6);
				}
				return text4 + " MB";
			}
			if (ulong_1 > 0L)
			{
				double num5 = (double)ulong_1 + (double)ulong_0 / 1024.0;
				num5 /= (DateTime.Now - dateTime_0).TotalSeconds;
				dateTime_0 = DateTime.Now;
				string text5 = num5.ToString();
				if (text5.Length > 6)
				{
					text5 = text5.Substring(0, 6);
				}
				return text5 + " KB";
			}
			double num6 = ulong_0;
			num6 /= (DateTime.Now - dateTime_0).TotalSeconds;
			dateTime_0 = DateTime.Now;
			string text6 = num6.ToString();
			if (text6.Length > 6)
			{
				text6 = text6.Substring(0, 6);
			}
			return text6 + " B";
		}

		public Class49()
		{
			Class51.smethod_0();
			dateTime_0 = DateTime.Now;
			base._002Ector();
		}
	}

	private ulong ulong_0;

	private ulong ulong_1;

	private ulong ulong_2;

	private ulong ulong_3;

	private ulong ulong_4;

	private ulong ulong_5;

	private Class49 class49_0;

	public GClass18()
	{
		Class51.smethod_0();
		class49_0 = new Class49();
		base._002Ector();
	}

	public string method_0()
	{
		string result = class49_0.ToString() + "/s";
		class49_0 = new Class49();
		return result;
	}

	public void method_1(ulong ulong_6)
	{
		class49_0.method_0(ulong_6);
		ulong_0 += ulong_6;
		while (ulong_0 > 1024L)
		{
			ulong_1++;
			ulong_0 -= 1024uL;
		}
		while (ulong_1 > 1024L)
		{
			ulong_2++;
			ulong_1 -= 1024uL;
		}
		while (ulong_2 > 1024L)
		{
			ulong_3++;
			ulong_2 -= 1024uL;
		}
		while (ulong_3 > 1024L)
		{
			ulong_4++;
			ulong_3 -= 1024uL;
		}
		while (ulong_4 > 1024L)
		{
			ulong_5++;
			ulong_4 -= 1024uL;
		}
	}

	public override string ToString()
	{
		if (ulong_5 > 0L)
		{
			string text = ((double)ulong_5 + (double)ulong_4 / 1024.0).ToString();
			if (text.Length > 6)
			{
				text = text.Substring(0, 6);
			}
			return text + " Pb";
		}
		if (ulong_4 > 0L)
		{
			string text2 = ((double)ulong_4 + (double)ulong_3 / 1024.0).ToString();
			if (text2.Length > 6)
			{
				text2 = text2.Substring(0, 6);
			}
			return text2 + " TB";
		}
		if (ulong_3 > 0L)
		{
			string text3 = ((double)ulong_3 + (double)ulong_2 / 1024.0).ToString();
			if (text3.Length > 6)
			{
				text3 = text3.Substring(0, 6);
			}
			return text3 + " GB";
		}
		if (ulong_2 > 0L)
		{
			string text4 = ((double)ulong_2 + (double)ulong_1 / 1024.0).ToString();
			if (text4.Length > 6)
			{
				text4 = text4.Substring(0, 6);
			}
			return text4 + " MB";
		}
		if (ulong_1 > 0L)
		{
			string text5 = ((double)ulong_1 + (double)ulong_0 / 1024.0).ToString();
			if (text5.Length > 6)
			{
				text5 = text5.Substring(0, 6);
			}
			return text5 + " KB";
		}
		string text6 = ulong_0.ToString();
		if (text6.Length > 6)
		{
			text6 = text6.Substring(0, 6);
		}
		return text6 + " b";
	}
}
