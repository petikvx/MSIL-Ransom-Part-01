public sealed class GClass63 : GClass9
{
	public enum GEnum5
	{
		Novelist,
		Painter,
		Poet,
		Sculptor,
		Designer,
		Photographer,
		Jeweler,
		Composer,
		Street_Musician,
		Blogger,
		Freelance_Journalist,
		Fisherman,
		Farmer,
		Caterer,
		Confectioner,
		Microbrewer,
		Food_Truck_Operator,
		Personal_Trainer,
		Yoga_Instructor,
		Masseuse,
		Private_Tutor,
		Event_Planner,
		House_Cleaner,
		Landscaper,
		Nanny,
		Hairdresser,
		Beautician,
		Dog_Walker,
		Driver,
		Bodyguard,
		Plumber,
		Electrician,
		Carpenter,
		Mechanic,
		Machinist,
		Welder,
		Glazier,
		Engraver,
		Contractor,
		Locksmith,
		Pest_Exterminator,
		Tailor,
		Dry_Cleaner,
		Traveling_Salesperson,
		Watchmaker,
		Small_Business_Owner,
		Shopkeeper,
		Landlord,
		Consultant,
		Therapist,
		Programmer,
		Lawyer,
		Accountant,
		Realtor,
		Fortune_Teller,
		Gambler,
		Petty_Thief,
		Drug_Dealer,
		EndEnum
	}

	public int int_22;

	public GClass63(int int_23, int int_24, int int_25, int int_26 = 16)
		: base(-2, int_24, int_25, int_26)
	{
		int_22 = -1;
	}

	public string method_24(int int_23)
	{
		GEnum5 gEnum = (GEnum5)int_23;
		string text = gEnum.ToString();
		return text.Replace('_', ' ');
	}

	public void method_25(ref GClass91 gclass91_1)
	{
		if (Class24.smethod_0(1, 100) < gclass91_1.method_1(6))
		{
			int_22 = 57;
		}
		else if (Class24.smethod_0(1, 100) < gclass91_1.method_1(7))
		{
			int_22 = 56;
		}
		else
		{
			int_22 = Class24.smethod_0(0, 57);
		}
	}

	public override string vmethod_5()
	{
		return Class16.smethod_0(-561834294) + method_24(int_22);
	}
}
