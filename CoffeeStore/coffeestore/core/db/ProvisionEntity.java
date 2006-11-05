package coffeestore.core.db;

import static com.sleepycat.persist.model.Relationship.*;
import com.sleepycat.persist.model.Entity;
import com.sleepycat.persist.model.PrimaryKey;
import com.sleepycat.persist.model.SecondaryKey;


@Entity
public class ProvisionEntity
{	
	@PrimaryKey(sequence="")
	private long itsId;
	
	private String itsDate;
	private String itsPurchaseBillId;
	private String itsPurchaseBillDate;
	
	@SecondaryKey(relate=MANY_TO_ONE, relatedEntity=VendorEntity.class)
	private String itsVendor;
	
	@SecondaryKey(relate=MANY_TO_ONE, relatedEntity=OriginEntity.class)
	private String itsOrigin;
	
	@SecondaryKey(relate=MANY_TO_ONE, relatedEntity=TypeEntity.class)
	private String itsType;
	
	private String itsTag;
	private int itsTotSackNumber;
	private int itsTotKilos;

	public ProvisionEntity()
	{
		
	}

	public ProvisionEntity(String date, String purchaseBillId, String purchaseBillDate, String vendor, String origin, String type, String tag, int totSackNumber, int totKilos)
	{
		itsDate = date;
		itsPurchaseBillId = purchaseBillId;
		itsPurchaseBillDate = purchaseBillDate;
		itsVendor = vendor;
		itsOrigin = origin;
		itsType = type;
		itsTag = tag;
		itsTotSackNumber = totSackNumber;
		itsTotKilos = totKilos;
	}

	public String getDate()
	{
		return itsDate;
	}

	public long getId()
	{
		return itsId;
	}

	public String getOrigin()
	{
		return itsOrigin;
	}

	public String getPurchaseBillDate()
	{
		return itsPurchaseBillDate;
	}

	public String getPurchaseBillId()
	{
		return itsPurchaseBillId;
	}

	public String getTag()
	{
		return itsTag;
	}

	public int getTotKilos()
	{
		return itsTotKilos;
	}

	public int getTotSackNumber()
	{
		return itsTotSackNumber;
	}

	public String getType()
	{
		return itsType;
	}

	public String getVendor()
	{
		return itsVendor;
	}
}
