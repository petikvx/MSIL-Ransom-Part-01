namespace Undergraduate_Home;

public class PersonnelOfficer : Worker
{
	public PersonnelOfficer(string name, string middlename, string surname)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error near IL_0002: Stack underflow*// /*Error near IL_0002: Stack underflow*/;
		_003F val2 = checked(/*Error near IL_0003: Stack underflow*/ - val);
		_ = /*Error near IL_0004: Stack underflow*/- val2;
		/*Error near IL_0004: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public extern void AddStudent(Group group, Student student);

	public extern Student MakeStudent(string name, string middlename, string surname);

	public extern Teacher MakeTeacher(string name, string middlename, string surname);

	public extern Group MakeGroup();
}
