package coffeestore.core.db;

import com.sleepycat.persist.model.Entity;
import com.sleepycat.persist.model.PrimaryKey;

@Entity
public class TypeEntity
{
	@PrimaryKey
	private String itsType;

	public TypeEntity()
	{
		
	}
	
	public TypeEntity(String type)
	{
		itsType = type;
	}

	public String getType()
	{
		return itsType;
	}
}
