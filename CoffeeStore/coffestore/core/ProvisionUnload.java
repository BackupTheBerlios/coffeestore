package coffestore.core;

import java.io.Serializable;

public class ProvisionUnload implements Serializable
{
	private static final long serialVersionUID = -5601192750437057322L;
	
	private int itsSackNumber;
	private int itsKilos;
	
	public ProvisionUnload(int aSackNumber, int aKilos)
	{
		itsSackNumber = aSackNumber;
		itsKilos = aKilos;
	}
	
	public boolean equals(Object anObject)
	{
		if (anObject == null)
			return false;
		
		if (!(anObject instanceof ProvisionUnload))
			return false;
		
		ProvisionUnload aSingleProvision = (ProvisionUnload) anObject;
		
		return (aSingleProvision.itsKilos == itsKilos && 
				aSingleProvision.itsSackNumber == itsSackNumber);
	}
	
	public int getKilos()
	{
		return itsKilos;
	}
	
	public int getSackNumber()
	{
		return itsSackNumber;
	}	
}
