package coffeestore.core.db;

import com.sleepycat.je.DatabaseException;

public class DataAccessorHolder
{
	private DataAccessor<String, VendorEntity> itsVendorAccessor;
	private DataAccessor<String, TypeEntity> itsTypeAccessor;
	private DataAccessor<String, OriginEntity> itsOriginAccessor;
	private DataAccessor<Long, ProvisionEntity> itsProvisionAccessor;
	
	public DataAccessorHolder(DataStore dataStore) throws DatabaseException
	{
		itsVendorAccessor = new DataAccessor<String, VendorEntity>(dataStore, String.class, VendorEntity.class); 
		itsTypeAccessor = new DataAccessor<String, TypeEntity>(dataStore, String.class, TypeEntity.class);
		itsOriginAccessor = new DataAccessor<String, OriginEntity>(dataStore, String.class, OriginEntity.class);
		itsProvisionAccessor = new DataAccessor<Long, ProvisionEntity>(dataStore, Long.class, ProvisionEntity.class);
	}

	public DataAccessor<String, OriginEntity> getOriginAccessor()
	{
		return itsOriginAccessor;
	}

	public DataAccessor<String, TypeEntity> getTypeAccessor()
	{
		return itsTypeAccessor;
	}

	public DataAccessor<String, VendorEntity> getVendorAccessor()
	{
		return itsVendorAccessor;
	}
	
	public DataAccessor<Long, ProvisionEntity> getProvisionAccessor()
	{
		return itsProvisionAccessor;
	}
}

