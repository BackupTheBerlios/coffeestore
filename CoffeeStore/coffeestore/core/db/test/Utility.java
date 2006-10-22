package coffeestore.core.db.test;

import java.io.File;


import coffeestore.core.db.DataAccessor;
import coffeestore.core.db.DataStore;
import coffeestore.core.db.VendorEntity;

import com.sleepycat.je.DatabaseException;
import com.sleepycat.persist.EntityCursor;

public class Utility
{
	static DataStore createDataStore() throws Exception
	{
		File file = new File("dbEnv/");
		file.mkdir();
		
		return new DataStore(file);
	}

	public static DataAccessor<String, VendorEntity> createVendorDataAccessor(DataStore aDataStore) throws DatabaseException
	{
		return new DataAccessor<String, VendorEntity>(aDataStore, String.class, VendorEntity.class);
	}	
	
	public static void cleanupVendorEntity(DataAccessor<String, VendorEntity> vendorDataAccessor) throws Exception
	{
		EntityCursor<VendorEntity> cursor = vendorDataAccessor.getPrimaryIndex().entities();
    	while (cursor.next() != null)
    		cursor.delete();
    	cursor.close();    	
	}
}
