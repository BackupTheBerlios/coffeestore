package coffeestore.core.db;

import java.util.Iterator;

import com.sleepycat.je.DatabaseException;
import com.sleepycat.persist.PrimaryIndex;

public class DataAccessor<PK, E>
{
	private DataStore itsDataStore;
	private PrimaryIndex<PK, E> itsPrimaryIndex;
	
	public DataAccessor(DataStore dataStore, Class<PK> primaryKeyClass, Class<E> entityClass) throws DatabaseException
	{
		itsDataStore = dataStore;
		itsPrimaryIndex = dataStore.getEntityStore().getPrimaryIndex(primaryKeyClass, entityClass);
	}
	
	public void put(E entity) throws DatabaseException
	{
		itsPrimaryIndex.put(entity);
	}
	
	public E get(PK primaryKey) throws DatabaseException
	{
		return itsPrimaryIndex.get(primaryKey);
	}
	
	public Iterator<E> items() throws DatabaseException
	{
		return itsPrimaryIndex.entities().iterator();
	}

	public DataStore getDataStore()
	{
		return itsDataStore;
	}

	public PrimaryIndex<PK, E> getPrimaryIndex()
	{
		return itsPrimaryIndex;
	}
}
