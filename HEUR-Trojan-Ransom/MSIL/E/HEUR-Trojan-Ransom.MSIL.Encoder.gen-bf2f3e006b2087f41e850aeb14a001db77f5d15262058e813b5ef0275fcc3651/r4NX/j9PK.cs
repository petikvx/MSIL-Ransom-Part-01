using System;
using System.Reflection;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using i7F8;
using x7KX;
using z7W;

namespace r4NX;

internal sealed class j9PK
{
	internal sealed class Ae9s
	{
		internal static bool b3T1()
		{
			try
			{
				try
				{
					Type type = k8M5.Ze2s.o1K0((Assembly)z1E.mDic["Ass2"]);
					if (Operators.ConditionalCompareObjectEqual((object)type.Name, z1E.mDic[z1E.tName], false))
					{
						z1E.mDic.Add(z1E.T, type);
						return true;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	private string str;

	public j9PK(string str)
	{
		this.str = str;
	}

	internal void q9TB()
	{
		throw new NotImplementedException();
	}

	internal m3HN Lj1x()
	{
		throw new NotImplementedException();
	}

	internal static string n2R5(string[] y5RT, int q9XG, int m2TH)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = q9XG; i <= m2TH; i = checked(i + 1))
		{
			stringBuilder.Append(y5RT[i]);
		}
		return stringBuilder.ToString();
	}

	internal static void Tb02()
	{
		string[] y5RT = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = n2R5(y5RT, 0, 3);
		string value2 = n2R5(y5RT, 4, 7);
		z1E.mDic.Add(z1E.tName, value);
		z1E.mDic.Add(z1E.mName, value2);
	}
}
