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
	private File itsEnvHome;
	private boolean itsIsReadOnly;
	
	public DataStore(File envHome, boolean isReadOnly) throws DatabaseException
	{
		itsEnvHome = envHome;
		itsIsReadOnly = isReadOnly;
		open();
	}

	public void open() throws DatabaseException
	{
		EnvironmentConfig envConfig = new EnvironmentConfig();
		StoreConfig storeConfig = new StoreConfig();
		envConfig.setReadOnly(itsIsReadOnly);
		storeConfig.setReadOnly(itsIsReadOnly);
		envConfig.setAllowCreate(!itsIsReadOnly);
		storeConfig.setAllowCreate(!itsIsReadOnly);
		itsEnvironment = new Environment(itsEnvHome, envConfig);
		itsEntityStore = new EntityStore(itsEnvironment, "EntityStore", storeConfig);
	}

    public void close() throws DatabaseException
    {
		if (itsEntityStore != null)
			itsEntityStore.close();
		if (itsEnvironment != null)
			itsEnvironment.close();  	
    }
    
    public EntityStore getEntityStore() 
    {
    	return itsEntityStore;
	}
}
