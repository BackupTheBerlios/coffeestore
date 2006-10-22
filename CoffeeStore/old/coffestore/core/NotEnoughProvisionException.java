package old.coffestore.core;

public class NotEnoughProvisionException extends Exception
{
	private static final long serialVersionUID = 1L;
	
	private Provision itsProvision;
	private ProvisionUnload itsUnload;
	
	public NotEnoughProvisionException(Provision aProvision, ProvisionUnload anUnload)
	{
		itsProvision = aProvision;
		itsUnload = anUnload;
	}

	public Provision getProvision()
	{
		return itsProvision;
	}

	public ProvisionUnload getUnload()
	{
		return itsUnload;
	}
}
