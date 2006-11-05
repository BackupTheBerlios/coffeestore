package coffeestore.core;

public class PurchaseBill
{
	private String itsPurchaseBillId;
	private String itsPurchaseBillDate;
	
	public PurchaseBill(String purchaseBillId, String purchaseBillDate)
	{
		itsPurchaseBillId = purchaseBillId;
		itsPurchaseBillDate = purchaseBillDate;
	}
	
	public String getPurchaseBillDate()
	{
		return itsPurchaseBillDate;
	}

	public String getPurchaseBillId()
	{
		return itsPurchaseBillId;
	}
}
