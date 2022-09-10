using CCfpfC7h;
using di1mqJMz;
using iiraiv39;
using qGIjTe0w;

namespace BZJnSPwx;

internal class Class1
{
	private const string Q9WQEzGk = "    ";

	private const string shxtQjV8 = "\r\n";

	private kk3OTTuY v4BiYeDN;

	public Class1(ref kk3OTTuY nUfUSp7h)
	{
		v4BiYeDN = nUfUSp7h;
	}

	public string cgWjzmE9()
	{
		return "#include <windows.h>\r\n#include <winsock2.h>\r\n#include <ws2tcpip.h>\r\n#include <stdlib.h>\r\n#include <stdio.h>\r\n\r\n// Need to link with Ws2_32.lib\r\n#pragma comment (lib, \"Ws2_32.lib\")\r\n// #pragma comment (lib, \"Mswsock.lib\")\r\n";
	}

	public string method_0()
	{
		return FFXb5i9i.MhuSoiDL("#define DEFAULT_BUFLEN 512\r\n#define DEFAULT_PORT \"8000\"\r\n", "#define N_GRAFCET ", v4BiYeDN.fVOQrcbt.ToString(), "\r\n", 9407);
	}

	public string ho7sQAME()
	{
		return ivlgLlId.jnXal2jf(ivlgLlId.jnXal2jf("WSADATA wsaData;\r\nSOCKET ListenSocket = INVALID_SOCKET, \r\n\t   ClientSocket = INVALID_SOCKET;\r\nstruct addrinfo *result = NULL, \r\n\t\t\t\thints;\r\nchar recvbuf[DEFAULT_BUFLEN];\r\nint iResult, iSendResult;\r\nint recvbuflen = DEFAULT_BUFLEN;\r\nint end = 0;\r\nint step = 0;\r\nint csteps = 0;\r\nint cvars = 0;\r\n", "#define TYPE_INT 3\r\n", 28657), "#define TYPE_REAL 10\r\n", 28657);
	}

	public string F1IM8g3Z()
	{
		return FFXb5i9i.Be2UxXd8(new string[11]
		{
			ZTS1MvRz(),
			"\r\n",
			ZvWyhNby(),
			"\r\n",
			QhCtiEqB(),
			"\r\n",
			tiExER0R(),
			"\r\n",
			XYOWV2bM(),
			"\r\n",
			xxtkEenR()
		}, 53581);
	}

	private string ZTS1MvRz()
	{
		return "int wait_for_connection(void)\r\n{\r\n    iResult = WSAStartup(MAKEWORD(2,2), &wsaData);\r\n\r\n    ZeroMemory(&hints, sizeof(hints));\r\n    hints.ai_family = AF_INET;\r\n    hints.ai_socktype = SOCK_STREAM;\r\n    hints.ai_protocol = IPPROTO_TCP;\r\n    hints.ai_flags = AI_PASSIVE;\r\n\r\n    iResult = getaddrinfo(NULL, DEFAULT_PORT, &hints, &result);\r\n    ListenSocket = socket(result->ai_family, result->ai_socktype, result->ai_protocol);\r\n    iResult = bind( ListenSocket, result->ai_addr, (int)result->ai_addrlen);\r\n    freeaddrinfo(result);\r\n    iResult = listen(ListenSocket, SOMAXCONN);\r\n    ClientSocket = accept(ListenSocket, NULL, NULL);\r\n    closesocket(ListenSocket);\r\n\r\n    return 0;\r\n}\r\n";
	}

	private string ZvWyhNby()
	{
		string string_ = "int Response()\r\n{\r\n    if(strcmp(recvbuf, \"end\\r\\n\") == 0) {\r\n\t    end = 1;\r\n";
		string_ = ivlgLlId.jnXal2jf(string_, "    } else if (strcmp(recvbuf, \"RequestActiveSteps\\r\\n\") == 0) {\r\n        char buffer[2];\r\n        int i;\r\n        int isFirst = 1;\r\n        printf(\"RequestActiveSteps %d\\n\", csteps);\r\n        csteps = csteps + 1;\r\n        iSendResult = send(ClientSocket, \"ResponseActiveSteps \", strlen(\"ResponseActiveSteps \"), 0);\r\n        for (i = 0; i < N_GRAFCET; i++) {\r\n            if (!isFirst) {\r\n                iSendResult = send(ClientSocket, \",\", 1, 0);\r\n            } else {\r\n                isFirst = 0;\r\n            }\r\n            itoa(G[i].EtapaActiva.all, buffer, 16);\r\n            iSendResult = send(ClientSocket, buffer, strlen(buffer), 0);\r\n        }\r\n        iSendResult = send(ClientSocket, \"\\r\\n\", 2, 0);\r\n", 28657);
		string_ = ivlgLlId.jnXal2jf(string_, "    } else if (strcmp(recvbuf, \"RequestVariables\\r\\n\") == 0) {\r\n        char buffer[20];\r\n        printf(\"RequestVariables %d\\n\", cvars);\r\n        cvars = cvars + 1;\r\n        iSendResult = send(ClientSocket, \"ResponseVariables \", strlen(\"ResponseVariables \"), 0);\r\n", 28657);
		bool flag = true;
		foreach (vilSnlZy value in v4BiYeDN.h3zupNkI.Values)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				string_ = ivlgLlId.jnXal2jf(string_, "        send(ClientSocket, \",\", 1, 0);\r\n", 28657);
			}
			string string_2 = value.String_2;
			if (ivlgLlId.smethod_3(string_2, "BOOL", bool_0: false, 3221) != 0)
			{
				if (ivlgLlId.smethod_3(string_2, "INT", bool_0: false, 3221) != 0)
				{
					if (ivlgLlId.smethod_3(string_2, "REAL", bool_0: false, 3221) == 0)
					{
						string_ = FFXb5i9i.MhuSoiDL(string_, "        sprintf(buffer, \"%f\", ", value.PYBbtbg6, ");\r\n", 9407);
					}
				}
				else
				{
					string_ = FFXb5i9i.MhuSoiDL(string_, "        itoa(", value.PYBbtbg6, ", buffer, 10);\r\n", 9407);
				}
			}
			else
			{
				string_ = FFXb5i9i.MhuSoiDL(string_, "        itoa(", value.PYBbtbg6, ", buffer, 10);\r\n", 9407);
			}
			string_ = ivlgLlId.jnXal2jf(string_, "        iSendResult = send(ClientSocket, buffer, strlen(buffer), 0);\r\n", 28657);
		}
		string_ = ivlgLlId.jnXal2jf(string_, "        iSendResult = send(ClientSocket, \"\\r\\n\", 2, 0);\r\n", 28657);
		string_ = ivlgLlId.jnXal2jf(string_, "    } else if (strstr(recvbuf, \"SetVariable \") != 0) {\r\n        char buffer[20];\r\n        char * pch;\r\n        char * var; // variable name\r\n        char * val; // variable value as string\r\n", 28657);
		string_ = ivlgLlId.jnXal2jf(string_, "        pch = strtok(recvbuf, \" \"); // skip command\r\n        var = strtok(NULL, \" \"); // variable name is first parameter\r\n        val = strtok(NULL, \" \"); // variable value is second parameter\r\n", 28657);
		string_ = ivlgLlId.jnXal2jf(string_, "        iSendResult = send(ClientSocket, \"SetVariable \", strlen(\"SetVariable \"), 0);\r\n        iSendResult = send(ClientSocket, var, strlen(var), 0);\r\n        iSendResult = send(ClientSocket, \" \", 1, 0);\r\n", 28657);
		flag = true;
		foreach (vilSnlZy value2 in v4BiYeDN.h3zupNkI.Values)
		{
			string_ = ivlgLlId.jnXal2jf(string_, "        ", 28657);
			if (flag)
			{
				flag = false;
			}
			else
			{
				string_ = ivlgLlId.jnXal2jf(string_, "else ", 28657);
			}
			string_ = FFXb5i9i.MhuSoiDL(string_, "if (strcmp(var, \"", value2.PYBbtbg6, "\") == 0) {\r\n", 9407);
			string string_3 = value2.String_2;
			if (ivlgLlId.smethod_3(string_3, "BOOL", bool_0: false, 3221) != 0)
			{
				if (ivlgLlId.smethod_3(string_3, "INT", bool_0: false, 3221) != 0)
				{
					if (ivlgLlId.smethod_3(string_3, "REAL", bool_0: false, 3221) == 0)
					{
						string_ = FFXb5i9i.MhuSoiDL(string_, "            ", value2.PYBbtbg6, " = atof(val);\r\n", 9407);
						string_ = FFXb5i9i.MhuSoiDL(string_, "            sprintf(buffer, \"%f\", ", value2.PYBbtbg6, ");\r\n", 9407);
					}
				}
				else
				{
					string_ = FFXb5i9i.MhuSoiDL(string_, "            ", value2.PYBbtbg6, " = atoi(val);\r\n", 9407);
					string_ = FFXb5i9i.MhuSoiDL(string_, "            itoa(", value2.PYBbtbg6, ", buffer, 10);\r\n", 9407);
				}
			}
			else
			{
				string_ = FFXb5i9i.MhuSoiDL(string_, "            ", value2.PYBbtbg6, " = atoi(val);\r\n", 9407);
				string_ = FFXb5i9i.MhuSoiDL(string_, "            itoa(", value2.PYBbtbg6, ", buffer, 10);\r\n", 9407);
			}
			string_ = ivlgLlId.jnXal2jf(string_, "        }\r\n", 28657);
		}
		string_ = ivlgLlId.jnXal2jf(string_, "        iSendResult = send(ClientSocket, buffer, strlen(buffer), 0);\r\n", 28657);
		string_ = ivlgLlId.jnXal2jf(string_, "        iSendResult = send(ClientSocket, \"\\r\\n\", 2, 0);\r\n", 28657);
		return ivlgLlId.jnXal2jf(string_, "    } else if (strcmp(recvbuf, \"step\\r\\n\") == 0) {\r\n        printf(\"step\\n\");\r\n        step = 1;\r\n    }\r\n\r\n    return 0;\r\n}\r\n", 28657);
	}

	private string QhCtiEqB()
	{
		return "int Attend()\r\n{\r\n    iResult = recv(ClientSocket, recvbuf, recvbuflen, 0);\r\n\r\n    if (iResult > 0) {\r\n        recvbuf[iResult] = 0; // mark end of string\r\n        Response();\r\n    }\r\n\r\n    return 0;\r\n}\r\n";
	}

	private string tiExER0R()
	{
		return "int disconnect()\r\n{\r\n    shutdown(ClientSocket, SD_SEND);\r\n    closesocket(ClientSocket);\r\n    WSACleanup();\r\n    return 0;\r\n}\r\n";
	}

	private string XYOWV2bM()
	{
		return ivlgLlId.jnXal2jf(ivlgLlId.jnXal2jf("int IniciRC()\r\n{\r\n", "    return 0;\r\n", 28657), "}\r\n", 28657);
	}

	private string xxtkEenR()
	{
		return ivlgLlId.jnXal2jf(ivlgLlId.jnXal2jf(ivlgLlId.jnXal2jf(ivlgLlId.jnXal2jf(ivlgLlId.jnXal2jf(ivlgLlId.jnXal2jf(ivlgLlId.jnXal2jf(ivlgLlId.jnXal2jf(ivlgLlId.jnXal2jf(ivlgLlId.jnXal2jf(ivlgLlId.jnXal2jf("LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)\r\n", "{\r\n", 28657), "    switch(message)\r\n", 28657), "    {\r\n", 28657), "        case WM_TIMER:\r\n", 28657), "            printf(\"t\");\r\n", 28657), "            temps_adeq();\r\n", 28657), "            break;\r\n", 28657), "    }\r\n", 28657), "    \r\n\r\n", 28657), "    return 0;\r\n", 28657), "}\r\n", 28657);
	}
}
