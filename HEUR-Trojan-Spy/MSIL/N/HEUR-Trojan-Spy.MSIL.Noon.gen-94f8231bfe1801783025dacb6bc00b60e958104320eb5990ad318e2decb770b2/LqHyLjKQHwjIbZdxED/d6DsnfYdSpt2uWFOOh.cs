using System;

namespace LqHyLjKQHwjIbZdxED;

internal class d6DsnfYdSpt2uWFOOh : AUujKXqHjrUbM8PTWd
{
	public gqwXETpwnDkT95pqZe frUKNsX2al;

	private gqwXETpwnDkT95pqZe dOGKUlDmtl;

	private gqwXETpwnDkT95pqZe KyIKi3csH4;

	private static int xRKKYmRfsv;

	private static d6DsnfYdSpt2uWFOOh c1K7wmI7H5DPvPFevn;

	public d6DsnfYdSpt2uWFOOh(string string_0)
	{
		R8TayKhW8eikpukIpe.piUZpdWzJZMua();
		base._002Ector();
		img4gcelx3 = string_0;
		YCN4ER413p = "engine off";
		Console.WriteLine(img4gcelx3 + " is " + YCN4ER413p);
		xRKKYmRfsv++;
	}

	public int cx3K4SXngM()
	{
		return xRKKYmRfsv;
	}

	public void edWKwKC2ZV(gqwXETpwnDkT95pqZe gqwXETpwnDkT95pqZe_0, string[,] string_0)
	{
		int num;
		if (frUKNsX2al != null)
		{
			Console.WriteLine((string?)xXC0D9M44IkK0iclDy("There already is a gunner in ", img4gcelx3));
			num = 1;
			if (!WbgLpKEKYPMS9lAAi4())
			{
				goto IL_005a;
			}
		}
		else
		{
			frUKNsX2al = gqwXETpwnDkT95pqZe_0;
			idBR0uvskqgaKmixq5(string_0, gqwXETpwnDkT95pqZe_0.VKe4UNOFOm, gqwXETpwnDkT95pqZe_0.hp14iUVDbS, "");
			num = 0;
			if (!WbgLpKEKYPMS9lAAi4())
			{
				goto IL_005a;
			}
		}
		goto IL_005e;
		IL_005a:
		int num2 = default(int);
		num = num2;
		goto IL_005e;
		IL_005e:
		switch (num)
		{
		case 1:
			return;
		}
		gqwXETpwnDkT95pqZe_0.VKe4UNOFOm = u2v4V6Vhat;
		gqwXETpwnDkT95pqZe_0.hp14iUVDbS = J4Z4IMDuLf;
		Console.WriteLine(gqwXETpwnDkT95pqZe_0.rb942KVTmy + " mounted the gun of " + img4gcelx3);
	}

	public void ryQKvVBbIn(gqwXETpwnDkT95pqZe gqwXETpwnDkT95pqZe_0, string[,] string_0)
	{
		if (frUKNsX2al == null)
		{
			swgoxjKfCNq9PtcU0W("No one is in the gunner seat of " + img4gcelx3);
			return;
		}
		bool flag = frUKNsX2al.rb942KVTmy == gqwXETpwnDkT95pqZe_0.rb942KVTmy;
		int num = 0;
		if (UaOo8hjVlkY9VhbSSV() != null)
		{
			goto IL_005d;
		}
		goto IL_0061;
		IL_0061:
		do
		{
			switch (num)
			{
			default:
				if (!flag)
				{
					Console.WriteLine(gqwXETpwnDkT95pqZe_0.rb942KVTmy + " is not in " + img4gcelx3);
					return;
				}
				break;
			case 1:
				string_0[gqwXETpwnDkT95pqZe_0.VKe4UNOFOm, gqwXETpwnDkT95pqZe_0.hp14iUVDbS] = "";
				gqwXETpwnDkT95pqZe_0.VKe4UNOFOm = u2v4V6Vhat - 1;
				gqwXETpwnDkT95pqZe_0.hp14iUVDbS = J4Z4IMDuLf;
				Console.WriteLine(gqwXETpwnDkT95pqZe_0.rb942KVTmy + " got out of " + img4gcelx3);
				return;
			}
			num = 1;
		}
		while (WbgLpKEKYPMS9lAAi4());
		goto IL_005d;
		IL_005d:
		int num2 = default(int);
		num = num2;
		goto IL_0061;
	}

	public void w8HK9Bv7Xr(gqwXETpwnDkT95pqZe gqwXETpwnDkT95pqZe_0, string[,] string_0)
	{
		int num;
		if (dOGKUlDmtl == null)
		{
			dOGKUlDmtl = gqwXETpwnDkT95pqZe_0;
			gqwXETpwnDkT95pqZe_0.UZ94YXSsxk = this;
			num = 3;
			if (UaOo8hjVlkY9VhbSSV() != null)
			{
				goto IL_0099;
			}
			goto IL_009d;
		}
		if (KyIKi3csH4 == null)
		{
			KyIKi3csH4 = gqwXETpwnDkT95pqZe_0;
			gqwXETpwnDkT95pqZe_0.UZ94YXSsxk = this;
			string_0[gqwXETpwnDkT95pqZe_0.VKe4UNOFOm, gqwXETpwnDkT95pqZe_0.hp14iUVDbS] = "";
			goto IL_00b4;
		}
		swgoxjKfCNq9PtcU0W("there is no room in " + img4gcelx3);
		return;
		IL_009d:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 2:
				goto end_IL_009d;
			default:
				goto IL_00cd;
			case 1:
				Console.WriteLine(gqwXETpwnDkT95pqZe_0.rb942KVTmy + " is in passenger seat 1 of " + img4gcelx3);
				return;
			}
			string_0[gqwXETpwnDkT95pqZe_0.VKe4UNOFOm, gqwXETpwnDkT95pqZe_0.hp14iUVDbS] = "";
			gqwXETpwnDkT95pqZe_0.VKe4UNOFOm = u2v4V6Vhat;
			gqwXETpwnDkT95pqZe_0.hp14iUVDbS = J4Z4IMDuLf;
			num = 1;
			if (UaOo8hjVlkY9VhbSSV() == null)
			{
				continue;
			}
			goto IL_0099;
			continue;
			end_IL_009d:
			break;
		}
		goto IL_00b4;
		IL_00cd:
		gqwXETpwnDkT95pqZe_0.hp14iUVDbS = J4Z4IMDuLf;
		Console.WriteLine((string?)PEqUi2zCZ9ZF8mYbFW(gqwXETpwnDkT95pqZe_0.rb942KVTmy, " is in passenger seat 2 of ", img4gcelx3));
		return;
		IL_0099:
		int num2 = default(int);
		num = num2;
		goto IL_009d;
		IL_00b4:
		gqwXETpwnDkT95pqZe_0.VKe4UNOFOm = u2v4V6Vhat;
		num = 0;
		if (!WbgLpKEKYPMS9lAAi4())
		{
			goto IL_009d;
		}
		goto IL_00cd;
	}

	public void NXOK2dN605(gqwXETpwnDkT95pqZe gqwXETpwnDkT95pqZe_0, string[,] string_0)
	{
		int num;
		if (dOGKUlDmtl != null)
		{
			if (dOGKUlDmtl.rb942KVTmy == gqwXETpwnDkT95pqZe_0.rb942KVTmy)
			{
				dOGKUlDmtl = null;
				gqwXETpwnDkT95pqZe_0.UZ94YXSsxk = null;
				string_0[gqwXETpwnDkT95pqZe_0.VKe4UNOFOm, gqwXETpwnDkT95pqZe_0.hp14iUVDbS] = "";
				gqwXETpwnDkT95pqZe_0.VKe4UNOFOm = u2v4V6Vhat + 1;
				gqwXETpwnDkT95pqZe_0.hp14iUVDbS = J4Z4IMDuLf;
				num = 1;
				if (!WbgLpKEKYPMS9lAAi4())
				{
					goto IL_00ed;
				}
				goto IL_01ad;
			}
			Console.WriteLine(gqwXETpwnDkT95pqZe_0.rb942KVTmy + " is not in " + img4gcelx3);
			return;
		}
		bool flag = KyIKi3csH4 != null;
		goto IL_012a;
		IL_0124:
		bool flag2 = default(bool);
		if (!flag2)
		{
			swgoxjKfCNq9PtcU0W(gqwXETpwnDkT95pqZe_0.rb942KVTmy + " is not in " + img4gcelx3);
			num = 0;
			if (!WbgLpKEKYPMS9lAAi4())
			{
				int num2 = default(int);
				num = num2;
			}
		}
		else
		{
			KyIKi3csH4 = null;
			num = 1;
			if (UaOo8hjVlkY9VhbSSV() == null)
			{
				goto IL_0137;
			}
		}
		goto IL_00ed;
		IL_01eb:
		Console.WriteLine((string?)PEqUi2zCZ9ZF8mYbFW("all passenger seats in ", img4gcelx3, " are empty"));
		return;
		IL_0137:
		gqwXETpwnDkT95pqZe_0.UZ94YXSsxk = null;
		string_0[gqwXETpwnDkT95pqZe_0.VKe4UNOFOm, gqwXETpwnDkT95pqZe_0.hp14iUVDbS] = "";
		gqwXETpwnDkT95pqZe_0.VKe4UNOFOm = u2v4V6Vhat - 1;
		gqwXETpwnDkT95pqZe_0.hp14iUVDbS = J4Z4IMDuLf;
		string_0[gqwXETpwnDkT95pqZe_0.VKe4UNOFOm, gqwXETpwnDkT95pqZe_0.hp14iUVDbS] = gqwXETpwnDkT95pqZe_0.rb942KVTmy ?? "";
		Console.WriteLine(gqwXETpwnDkT95pqZe_0.rb942KVTmy + " got out of passenger seat 2 on " + img4gcelx3);
		return;
		IL_01ad:
		idBR0uvskqgaKmixq5(string_0, gqwXETpwnDkT95pqZe_0.VKe4UNOFOm, gqwXETpwnDkT95pqZe_0.hp14iUVDbS, gqwXETpwnDkT95pqZe_0.rb942KVTmy ?? "");
		swgoxjKfCNq9PtcU0W(gqwXETpwnDkT95pqZe_0.rb942KVTmy + " got out of passenger seat 1 on " + img4gcelx3);
		return;
		IL_012a:
		if (flag)
		{
			flag2 = KyIKi3csH4.rb942KVTmy == gqwXETpwnDkT95pqZe_0.rb942KVTmy;
			goto IL_0124;
		}
		goto IL_01eb;
		IL_00ed:
		switch (num)
		{
		default:
			return;
		case 2:
			break;
		case 3:
			goto IL_012a;
		case 4:
			goto IL_0137;
		case 5:
			goto IL_01ad;
		case 1:
			goto IL_01eb;
		case 0:
			return;
		}
		goto IL_0124;
	}

	internal static bool WbgLpKEKYPMS9lAAi4()
	{
		return c1K7wmI7H5DPvPFevn == null;
	}

	internal static d6DsnfYdSpt2uWFOOh UaOo8hjVlkY9VhbSSV()
	{
		return c1K7wmI7H5DPvPFevn;
	}

	internal static object xXC0D9M44IkK0iclDy(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static void idBR0uvskqgaKmixq5(object object_0, int int_0, int int_1, object object_1)
	{
		((string[,])object_0)[int_0, int_1] = (string)object_1;
	}

	internal static void swgoxjKfCNq9PtcU0W(object object_0)
	{
		Console.WriteLine((string?)object_0);
	}

	internal static object PEqUi2zCZ9ZF8mYbFW(object object_0, object object_1, object object_2)
	{
		return (string?)object_0 + (string?)object_1 + (string?)object_2;
	}
}
