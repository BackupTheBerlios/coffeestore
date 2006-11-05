package coffeestore.core.db.test;

import java.io.File;

import coffeestore.core.db.DataAccessor;
import coffeestore.core.db.DataAccessorHolder;
import coffeestore.core.db.DataStore;
import coffeestore.core.db.VendorEntity;

import com.sleepycat.je.DatabaseException;


public class Utility
{
	public static DataStore createDataStore() throws Exception
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
}
