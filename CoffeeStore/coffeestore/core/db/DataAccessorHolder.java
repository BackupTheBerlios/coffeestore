package coffeestore.core.db;

import com.sleepycat.je.DatabaseException;

public class DataAccessorHolder
{
	DataStore itsDataStore;
	
	private DataAccessor<String, VendorEntity> itsVendorAccessor;
	private DataAccessor<String, TypeEntity> itsTypeAccessor;
	private DataAccessor<String, OriginEntity> itsOriginAccessor;
	private DataAccessor<Long, ProvisionEntity> itsProvisionAccessor;
	
	public DataAccessorHolder(DataStore aDataStore) throws DatabaseException
	{
		itsDataStore = aDataStore;
		createDataAccessors();
	}

	public void createDataAccessors() throws DatabaseException
	{
		itsVendorAccessor = new DataAccessor<String, VendorEntity>(itsDataStore, String.class, VendorEntity.class); 
		itsTypeAccessor = new DataAccessor<String, TypeEntity>(itsDataStore, String.class, TypeEntity.class);
		itsOriginAccessor = new DataAccessor<String, OriginEntity>(itsDataStore, String.class, OriginEntity.class);
		itsProvisionAccessor = new DataAccessor<Long, ProvisionEntity>(itsDataStore, Long.class, ProvisionEntity.class);
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
	
	public DataStore getDataStore()
	{
		return itsDataStore;
	}
}

