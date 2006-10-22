package old.coffestore.core;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.Collection;

public class Provision implements Serializable
{
	private static final long serialVersionUID = 7606315674448690849L;
	
	private String itsId;
	private String itsDate;
	private String itsPurchaseBill;
	private String itsPurchaseBillDate;
	private String itsSeller;
	private String itsOrigin;
	private String itsType;
	private String itsTag;
	private int itsTotSackNumber;
	private int itsTotKilos;
	private int itsRemainingKilos;
	private int itsRemainingSacks;
	private Collection<ProvisionUnload> itsUnloads;
	
	public Provision(String anId, String aDate, String aPurchaseBill, String aPurchaseBillDate, String aSeller, String anOrigin, String aType, String aTag, int aSackNumber, int aTotKilos)
	{
		itsId = anId;
		itsDate = aDate;
		itsPurchaseBill = aPurchaseBill;
		itsPurchaseBillDate = aPurchaseBillDate;
		itsSeller = aSeller;
		itsOrigin = anOrigin;
		itsType = aType;
		itsTag = aTag;
		itsTotSackNumber = aSackNumber;
		itsTotKilos = aTotKilos;
		itsRemainingKilos = itsTotKilos;
		itsRemainingSacks = itsTotSackNumber;
		itsUnloads = new ArrayList<ProvisionUnload>();
	}

	public boolean equals(Object anObject)
	{
		if (anObject == null)
			return false;
		
		if (!(anObject instanceof Provision))
			return false;
		
		Provision aProvision = (Provision) anObject;
		
		return (aProvision.itsId.equals(itsId) &&
				aProvision.itsDate.equals(itsDate) &&
				aProvision.itsOrigin.equals(itsOrigin) && 
				aProvision.itsPurchaseBill.equals(itsPurchaseBill) &&
				aProvision.itsPurchaseBillDate.equals(itsPurchaseBillDate) &&
				aProvision.itsTotSackNumber == itsTotSackNumber &&
				aProvision.itsSeller.equals(itsSeller) &&
				aProvision.itsTag.equals(itsTag) &&
				aProvision.itsTotKilos == itsTotKilos &&
				aProvision.itsType.equals(itsType) &&
				aProvision.itsRemainingKilos == itsRemainingKilos &&
				aProvision.itsUnloads.equals(itsUnloads));
	}
	
	public String getId()
	{
		return itsId;
	}
	
	public String getDate()
	{
		return itsDate;
	}
	
	public String getPurchaseBill()
	{
		return itsPurchaseBill;
	}
	
	public String getOrigin()
	{
		return itsOrigin;
	}

	public int getTotSackNumber()
	{
		return itsTotSackNumber;
	}

	public String getSeller()
	{
		return itsSeller;
	}

	public int getTotKilos()
	{
		return itsTotKilos;
	}
	
	public int getRemainingKilos()
	{
		return itsRemainingKilos;
	}
	
	public int getRemainingSacks()
	{
		return itsRemainingSacks;
	}

	public String getType()
	{
		return itsType;
	}
	
	public String getPurchaseBillDate()
	{
		return itsPurchaseBillDate;
	}
	
	public String getTag()
	{
		return itsTag;
	}
	
	public void addUnload(ProvisionUnload anUnload) throws NotEnoughProvisionException
	{
		if (itsRemainingKilos < anUnload.getKilos() || itsRemainingSacks < anUnload.getSackNumber())
			throw new NotEnoughProvisionException(this, anUnload);
				
		itsRemainingKilos -= anUnload.getKilos();
		itsRemainingSacks -= anUnload.getSackNumber();
		itsUnloads.add(anUnload);
	}
	
	public Collection<ProvisionUnload> getUnloads()
	{
		return itsUnloads;
	}
}
