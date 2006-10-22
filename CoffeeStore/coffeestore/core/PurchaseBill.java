package coffeestore.core;

import java.util.Date;

public class PurchaseBill
{
	private String purchaseBillId;
	private Date purchaseBillDate;
	
	public PurchaseBill(String purchaseBillId, Date purchaseBillDate)
	{
		super();
		this.purchaseBillId = purchaseBillId;
		this.purchaseBillDate = purchaseBillDate;
	}
	
	public Date getPurchaseBillDate()
	{
		return purchaseBillDate;
	}

	public String getPurchaseBillId()
	{
		return purchaseBillId;
	}
}
