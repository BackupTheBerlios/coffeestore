package coffeestore.core.db;

import java.io.File;

import com.sleepycat.je.DatabaseException;
import com.sleepycat.je.Environment;
import com.sleepycat.je.EnvironmentConfig;
import com.sleepycat.persist.EntityStore;
import com.sleepycat.persist.StoreConfig;

public class DataStore
{
	private EntityStore itsStore;

	public DataStore(File envHome) throws DatabaseException
	{
		EnvironmentConfig envConfig = new EnvironmentConfig();
		StoreConfig storeConfig = new StoreConfig();
		envConfig.setReadOnly(false);
		storeConfig.setReadOnly(false);
		envConfig.setAllowCreate(true);
		storeConfig.setAllowCreate(true);
		Environment env = new Environment(envHome, envConfig);
		itsStore = new EntityStore(env, "EntityStore", storeConfig);
	}
    
    public EntityStore getEntityStore() 
    {
    	return itsStore;
	}
}
