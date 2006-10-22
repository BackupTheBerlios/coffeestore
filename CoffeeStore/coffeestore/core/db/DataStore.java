package coffeestore.core.db;

import java.io.File;

import com.sleepycat.je.DatabaseException;
import com.sleepycat.je.Environment;
import com.sleepycat.je.EnvironmentConfig;
import com.sleepycat.persist.EntityStore;
import com.sleepycat.persist.StoreConfig;

public class DataStore
{
	private EntityStore itsEntityStore;
	private Environment itsEnvironment; 
	
	public DataStore(File envHome) throws DatabaseException
	{
		EnvironmentConfig envConfig = new EnvironmentConfig();
		StoreConfig storeConfig = new StoreConfig();
		envConfig.setReadOnly(false);
		storeConfig.setReadOnly(false);
		envConfig.setAllowCreate(true);
		storeConfig.setAllowCreate(true);
		itsEnvironment = new Environment(envHome, envConfig);
		itsEntityStore = new EntityStore(itsEnvironment, "EntityStore", storeConfig);
	}
    
    public EntityStore getEntityStore() 
    {
    	return itsEntityStore;
	}
    
    public void close() throws DatabaseException
    {
		if (itsEntityStore != null)
			itsEntityStore.close();
		if (itsEnvironment != null)
			itsEnvironment.close();  	
    }
}
