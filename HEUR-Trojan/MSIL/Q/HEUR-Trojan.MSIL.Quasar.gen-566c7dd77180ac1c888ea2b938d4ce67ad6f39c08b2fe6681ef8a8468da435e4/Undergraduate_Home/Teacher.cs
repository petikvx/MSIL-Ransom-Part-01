namespace Undergraduate_Home;

public class Teacher : Worker
{
	private int lecture;

	private Group group;

	public extern int Lecture { get; set; }

	public extern Teacher(string name, string middlename, string surname);

	public extern void Lectured();

	public void SetGroup(Group group)
	{
		//Discarded unreachable code: IL_0004, IL_000f
		/*Error near IL_0003: Unknown opcode: 0xFA*/;
	}
}
