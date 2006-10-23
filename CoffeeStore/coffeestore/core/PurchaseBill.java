package coffeestore.core;

import java.util.Date;

public class PurchaseBill
{
	private String itsPurchaseBillId;
	private Date itsPurchaseBillDate;
	
	public PurchaseBill(String purchaseBillId, Date purchaseBillDate)
	{
		itsPurchaseBillId = purchaseBillId;
		itsPurchaseBillDate = purchaseBillDate;
	}
	
	public Date getPurchaseBillDate()
	{
		return itsPurchaseBillDate;
	}

	public String getPurchaseBillId()
	{
		return itsPurchaseBillId;
	}
}
