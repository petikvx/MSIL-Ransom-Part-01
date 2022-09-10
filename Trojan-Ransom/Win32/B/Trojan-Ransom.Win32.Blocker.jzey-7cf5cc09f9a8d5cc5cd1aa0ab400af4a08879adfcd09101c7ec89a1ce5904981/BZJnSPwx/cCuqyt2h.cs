using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Y7FbhctW;
using di1mqJMz;
using iiraiv39;
using ns0;
using qGIjTe0w;

namespace BZJnSPwx;

internal class cCuqyt2h
{
	private const string U6XMppKm = "    ";

	private const string k7lc9SCa = "\r\n";

	private bool bool_0;

	private int PlUVNi5U;

	private string FH9vtqVs;

	private Class1 sE9DD6f1;

	private Class2 class2_0;

	public cCuqyt2h(ref GEBbAG79 gebbAG79_0, ref gMotwPfU VNHuV9do, ref kk3OTTuY iutEuHVe, bool CkPzD4SB, string w8KODW9m)
	{
		bool_0 = CkPzD4SB;
		PlUVNi5U = 200;
		FH9vtqVs = w8KODW9m;
		if (CkPzD4SB)
		{
			sE9DD6f1 = new Class1(ref iutEuHVe);
		}
		class2_0 = new Class2(ref VNHuV9do, PlUVNi5U);
	}

	public bool jiy3Brdl()
	{
		FileSystemProxy fileSystemProxy_ = O4s9Dog1.jghAQYJA((ServerComputer)(object)c.B_0, 18821);
		O4s9Dog1.kPowsRxh(fileSystemProxy_, ivlgLlId.jnXal2jf(FH9vtqVs, "\\bit.h", 28657), class2_0.wfXBZItI(), bool_0: false, 50635);
		O4s9Dog1.kPowsRxh(fileSystemProxy_, ivlgLlId.jnXal2jf(FH9vtqVs, "\\parametres.h", 28657), class2_0.c3v6QDdG(), bool_0: false, 50635);
		O4s9Dog1.kPowsRxh(fileSystemProxy_, ivlgLlId.jnXal2jf(FH9vtqVs, "\\main.h", 28657), class2_0.hll6zG8h(), bool_0: false, 50635);
		O4s9Dog1.kPowsRxh(fileSystemProxy_, ivlgLlId.jnXal2jf(FH9vtqVs, "\\main.c", 28657), Rd0uLYjo(), bool_0: false, 50635);
		O4s9Dog1.kPowsRxh(fileSystemProxy_, ivlgLlId.jnXal2jf(FH9vtqVs, "\\EvolucioGrafcet.c", 28657), FFXb5i9i.F6ODWxg3(class2_0.AQzx4MeA(), 22851), bool_0: false, 50635);
		O4s9Dog1.kPowsRxh(fileSystemProxy_, ivlgLlId.jnXal2jf(FH9vtqVs, "\\AvaluaReceptivitats.c", 28657), class2_0.kcxeUlCm(), bool_0: false, 50635);
		O4s9Dog1.kPowsRxh(fileSystemProxy_, ivlgLlId.jnXal2jf(FH9vtqVs, "\\AccionsContinues.c", 28657), class2_0.EU0wjb7D(), bool_0: false, 50635);
		O4s9Dog1.kPowsRxh(fileSystemProxy_, ivlgLlId.jnXal2jf(FH9vtqVs, "\\AccionsPuntuals.c", 28657), class2_0.Oy9S0btP(), bool_0: false, 50635);
		O4s9Dog1.kPowsRxh(fileSystemProxy_, ivlgLlId.jnXal2jf(FH9vtqVs, "\\ES.c", 28657), class2_0.method_0(), bool_0: false, 50635);
		O4s9Dog1.kPowsRxh(fileSystemProxy_, ivlgLlId.jnXal2jf(FH9vtqVs, "\\AltresRutines.c", 28657), FFXb5i9i.F6ODWxg3(class2_0.PUME6ZLV(), 22851), bool_0: false, 50635);
		if (false)
		{
		}
		return true;
	}

	private string Rd0uLYjo()
	{
		string string_ = "";
		if (bool_0)
		{
			string_ = FFXb5i9i.smethod_0("#undef UNICODE\r\n\r\n#define WIN32_LEAN_AND_MEAN\r\n\r\n", sE9DD6f1.cgWjzmE9(), "\r\n", 52605);
		}
		string_ = FFXb5i9i.smethod_0(string_, class2_0.g2ereli3(), "\r\n", 52605);
		if (bool_0)
		{
			string_ = FFXb5i9i.smethod_0(string_, sE9DD6f1.method_0(), "\r\n", 52605);
		}
		if (bool_0)
		{
			string_ = FFXb5i9i.smethod_0(string_, sE9DD6f1.ho7sQAME(), "\r\n", 52605);
		}
		if (bool_0)
		{
			string_ = FFXb5i9i.smethod_0(string_, sE9DD6f1.F1IM8g3Z(), "\r\n", 52605);
		}
		string_ = ivlgLlId.jnXal2jf(string_, "void main(void)\r\n{\r\n    unsigned char i;\r\n\r\n", 28657);
		if (bool_0)
		{
			string_ = ivlgLlId.jnXal2jf(string_, "    wait_for_connection();\r\n\r\n", 28657);
			string_ = ivlgLlId.jnXal2jf(string_, "    IniciRC();\r\n\r\n", 28657);
			string_ = FFXb5i9i.MhuSoiDL(string_, "    SetTimer(NULL, 1234, ", PlUVNi5U.ToString(), ", (TIMERPROC) NULL);\r\n\r\n", 9407);
		}
		string_ = ivlgLlId.jnXal2jf(string_, "    IniciMicro();\r\n\r\n    IniciGrafcet();\r\n\r\n", 28657);
		string_ = FFXb5i9i.MhuSoiDL(string_, "    while (", TH8QgoCQ(), ")\r\n    {\r\n", 9407);
		if (bool_0)
		{
			string_ = ivlgLlId.jnXal2jf(string_, "        while (!end && !step) Attend();\r\n", 28657);
		}
		string_ = ivlgLlId.jnXal2jf(string_, "        LecturaEntrades();\r\n        GestioTempo();\r\n        for (i = 0; i < N; i++)\r\n        {\r\n            AssignaAux();\r\n            EvolucioGrafcet();\r\n            AccionsPuntuals();\r\n            if (GrafcetEstable())\r\n                i = N + 1;\r\n        }\r\n        AccionsContinues();\r\n        SortidesFisiques();\r\n", 28657);
		if (bool_0)
		{
			string_ = ivlgLlId.jnXal2jf(string_, "        step = 0;\r\n", 28657);
		}
		string_ = ivlgLlId.jnXal2jf(string_, "    } // fwhile\r\n", 28657);
		if (bool_0)
		{
			string_ = ivlgLlId.jnXal2jf(string_, "    disconnect();\r\n", 28657);
			string_ = ivlgLlId.jnXal2jf(string_, "    KillTimer(NULL, 1234);\r\n", 28657);
		}
		return ivlgLlId.jnXal2jf(string_, "} // fmain\r\n", 28657);
	}

	private string TH8QgoCQ()
	{
		if (bool_0)
		{
			return "!end";
		}
		return "1";
	}
}
