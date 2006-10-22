package coffeestore.core.db;

import java.util.Date;

import com.sleepycat.persist.model.Entity;
import com.sleepycat.persist.model.PrimaryKey;
import com.sleepycat.persist.model.SecondaryKey;
import static com.sleepycat.persist.model.Relationship.*;


@Entity
public class ProvisionEntity
{	
	@PrimaryKey(sequence="")
	private long id;
	
	private Date date;
	private String purchaseBillId;
	private Date purchaseBillDate;
	
	@SecondaryKey(relate=MANY_TO_ONE, relatedEntity=VendorEntity.class)
	private String vendor;
	
	@SecondaryKey(relate=MANY_TO_ONE, relatedEntity=OriginEntity.class)
	private String origin;
	
	@SecondaryKey(relate=MANY_TO_ONE, relatedEntity=TypeEntity.class)
	private String type;
	
	private String tag;
	private int totSackNumber;
	private int totKilos;

	public ProvisionEntity()
	{
		
	}

	public ProvisionEntity(Date date, String purchaseBillId, Date purchaseBillDate, String vendor, String origin, String type, String tag, int totSackNumber, int totKilos)
	{
		super();
		this.date = date;
		this.purchaseBillId = purchaseBillId;
		this.purchaseBillDate = purchaseBillDate;
		this.vendor = vendor;
		this.origin = origin;
		this.type = type;
		this.tag = tag;
		this.totSackNumber = totSackNumber;
		this.totKilos = totKilos;
	}

	public Date getDate()
	{
		return date;
	}

	public long getId()
	{
		return id;
	}

	public String getOrigin()
	{
		return origin;
	}

	public Date getPurchaseBillDate()
	{
		return purchaseBillDate;
	}

	public String getPurchaseBillId()
	{
		return purchaseBillId;
	}

	public String getTag()
	{
		return tag;
	}

	public int getTotKilos()
	{
		return totKilos;
	}

	public int getTotSackNumber()
	{
		return totSackNumber;
	}

	public String getType()
	{
		return type;
	}

	public String getVendor()
	{
		return vendor;
	}
}
