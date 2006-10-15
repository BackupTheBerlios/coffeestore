package coffestore.core;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.Collection;

public class WareHouse implements Serializable
{
	private static final long serialVersionUID = 4780065307472115064L;
	
	private Collection<Provision> itsProvisions;
	
	public WareHouse()
	{
		itsProvisions = new ArrayList<Provision>();
	}
	
	public void add(Provision aProvision)
	{
		itsProvisions.add(aProvision);
	}
	
	public Collection<Provision> getProvisions()
	{
		return itsProvisions;
	}
}
