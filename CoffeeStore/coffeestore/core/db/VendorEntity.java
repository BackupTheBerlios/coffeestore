package coffeestore.core.db;

import com.sleepycat.persist.model.Entity;
import com.sleepycat.persist.model.PrimaryKey;

@Entity
public class VendorEntity
{
	@PrimaryKey
	private String itsVendor;

	public VendorEntity()
	{
		
	}
	
	public VendorEntity(String vendor)
	{
		itsVendor = vendor;
	}

	public String getVendor()
	{
		return itsVendor;
	}
}
