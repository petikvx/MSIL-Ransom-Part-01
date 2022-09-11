using System.Collections.Generic;

namespace Undergraduate_Home;

public class Group
{
	private string namegroup;

	private Teacher teacher;

	private List<Student> students;

	public extern string NameGroup { get; set; }

	public unsafe void SetTeacher(Teacher teacher)
	{
		//Discarded unreachable code: IL_0013, IL_001d, IL_0026
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected F8, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			_003F val = /*Error near IL_0001: Stack underflow*// /*Error near IL_0001: Stack underflow*/;
			((short[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (short)(ushort)val;
		}
		while (/*Error near IL_0009: Stack underflow*/ < /*Error near IL_0009: Stack underflow*/);
		*(double*)(int)(byte)/*Error near IL_000b: Stack underflow*/ = (double)/*Error near IL_000b: ldarg 3 (out-of-bounds)*/;
		checked
		{
			_ = (ushort)/*Error near IL_000e: Stack underflow*/;
			/*Error near IL_000e: Invalid metadata token*/;
		}
	}

	public extern void AddStudent(Student student);

	public extern int GetNumber();

	public extern void UpData();

	public extern List<Student> GroupList();

	public extern Group();
}
