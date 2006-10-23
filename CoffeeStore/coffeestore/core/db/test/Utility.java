package coffeestore.core.db.test;

import java.io.File;

import coffeestore.core.db.DataAccessor;
import coffeestore.core.db.DataAccessorHolder;
import coffeestore.core.db.DataStore;
import coffeestore.core.db.VendorEntity;

import com.sleepycat.je.DatabaseException;
import com.sleepycat.persist.EntityCursor;

public class Utility
{
	static DataStore createDataStore() throws Exception
	{
		File file = createDataStoreFile();
		return new DataStore(file);
	}

	static File createDataStoreFile() throws Exception
	{
		File file = new File("dbEnv/");
		file.mkdir();
		return file;
	}

	static void deleteDataStoreFile(File file) throws Exception
	{
		file.delete();
	}
	
	static DataStore createDataStore(File file) throws Exception
	{
		return new DataStore(file);
	}
	
	public static DataAccessor<String, VendorEntity> createVendorDataAccessor(DataStore aDataStore) throws DatabaseException
	{
		return new DataAccessorHolder(aDataStore).getVendorAccessor();
	}
	
	public static <PK, E> void cleanupEntity(DataAccessor<PK, E> aDataAccessor) throws Exception
	{
		EntityCursor<E> cursor = aDataAccessor.getPrimaryIndex().entities();
    	while (cursor.next() != null)
    		cursor.delete();
    	cursor.close();    	
	}
}
