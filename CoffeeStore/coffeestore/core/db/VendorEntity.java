package coffeestore.core.db;

import com.sleepycat.persist.model.Entity;
import com.sleepycat.persist.model.PrimaryKey;

@Entity
public class VendorEntity
{
	@PrimaryKey
	private String vendor;

	public VendorEntity()
	{
		
	}
	
	public VendorEntity(String vendor)
	{
		super();
		this.vendor = vendor;
	}

	public String getVendor()
	{
		return vendor;
	}
}
