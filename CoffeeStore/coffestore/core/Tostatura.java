package coffestore.core;

public class Tostatura
{
	private String itsProvisionId;
	private String itsProvisionDate;
	private String itsKilosCrudo;
	private String itsKilosTostato;
	private String itsDestinationSilos;
	
	public Tostatura(String aProvisionId, String aProvisionDate, String aKilosCrudo, String aKilosTostato, String aDestinationSilos)
	{
		itsProvisionId = itsProvisionId;
		itsProvisionDate = itsKilosCrudo;
		itsKilosCrudo = itsKilosCrudo;
		itsKilosTostato = itsKilosTostato;
		itsDestinationSilos = itsDestinationSilos;
	}
	
	public boolean equals(Object anObject)
	{
		if (anObject == null)
			return false;
		
		if (!(anObject instanceof Tostatura))
			return false;
		
		Tostatura aTostatura = (Tostatura) anObject;
		
		return (aTostatura.itsProvisionId.equals(itsProvisionId) &&
				aTostatura.itsProvisionDate.equals(itsProvisionDate) &&
				aTostatura.itsKilosCrudo == itsKilosCrudo && 
				aTostatura.itsKilosTostato == itsKilosTostato &&
				aTostatura.itsDestinationSilos == itsDestinationSilos);
	}
}

