package coffeestore.core;

import coffeestore.core.db.ProvisionEntity;

public class ProvisionWrapper
{	
	Provision provision;
	PurchaseBill purchaseBill;
	QualityOrigin qualityOrigin;
	
	public ProvisionWrapper(ProvisionEntity provisionEntity)
	{
		provision = new Provision(provisionEntity.getId(), provisionEntity.getDate(), provisionEntity.getVendor(), provisionEntity.getTotSackNumber(), provisionEntity.getTotKilos());
		purchaseBill = new PurchaseBill(provisionEntity.getPurchaseBillId(), provisionEntity.getPurchaseBillDate());
		qualityOrigin = new QualityOrigin(provisionEntity.getOrigin(), provisionEntity.getType(), provisionEntity.getTag());
	}

	public PurchaseBill getPurchaseBill()
	{
		return purchaseBill;
	}

	public QualityOrigin getQualityOrigin()
	{
		return qualityOrigin;
	}

	public Provision getProvision()
	{
		return provision;
	}
}
