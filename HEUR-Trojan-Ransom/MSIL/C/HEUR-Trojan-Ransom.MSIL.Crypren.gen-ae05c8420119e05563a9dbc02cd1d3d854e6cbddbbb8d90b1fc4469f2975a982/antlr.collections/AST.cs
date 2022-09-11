using System;
using System.Collections;

namespace antlr.collections;

public interface AST : ICloneable
{
	int Type { get; set; }

	void imethod_0(AST ast_0);

	bool Equals(AST t);

	bool imethod_1(AST ast_0);

	bool imethod_2(AST ast_0);

	bool imethod_3(AST ast_0);

	bool imethod_4(AST ast_0);

	IEnumerator imethod_5(AST ast_0);

	IEnumerator imethod_6(AST ast_0);

	AST imethod_7();

	AST imethod_8();

	string imethod_9();

	int imethod_10();

	void imethod_11(int int_0, string string_0);

	void imethod_12(AST ast_0);

	void imethod_13(GInterface17 ginterface17_0);

	void imethod_14(AST ast_0);

	void imethod_15(AST ast_0);

	void imethod_16(string string_0);

	void imethod_17(int int_0);

	new string ToString();

	string imethod_18();

	string imethod_19();
}
