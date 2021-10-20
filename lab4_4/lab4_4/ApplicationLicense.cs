using System;

public class ApplicationLicense
{
	private string licensecode;
	public string LicenseCode
    {
        get
        {
			return licensecode;
        }
        set
        {
			licensecode = value;
        }
    }
	public void LicenseCheck(ApplicationLicense license)
    {
		if (String.IsNullOrWhiteSpace(license.LicenseCode))
        {
			Console.WriteLine("You have not entered the license code");
			AllowCommon(license);
		}
        else
        {
			
			if (AllowTrial(license)|| AllowPro(license))
            {

            }
            else
            {
				Console.WriteLine("You have entered the wrong license code");
				AllowCommon(license);
			}
        }
		

	}
	public void AllowCommon(ApplicationLicense license)
	{
		Console.WriteLine("Now you have a free version");
	}
	public bool AllowTrial(ApplicationLicense license) 
	{
		if (license.LicenseCode.Equals("00000000"))
		{
			Console.WriteLine("Now you have a trial version");
			return true;
		}
        else
		{
			return false;
		}
	}
	public bool AllowPro(ApplicationLicense license)
	{
		if (license.LicenseCode.Equals("11111111"))
        {
			Console.WriteLine("Now you have a full version");
			return true;
		}
		else
		{
			return false;
		}
	}
}
