package coffestore.core.test;

import coffestore.core.Provision;

public class Factories
{
	public static Provision createProvision(int aTotSackNumber, int aTotKilos)
	{
		return new Provision("Id", "Date", "PurchaseBill", "PurchaseBillDate", "Seller", "Origin", "Type", "Tag", aTotSackNumber, aTotKilos);
	}
}
