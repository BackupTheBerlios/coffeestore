package coffeestore.core.db;

import com.sleepycat.persist.model.Entity;
import com.sleepycat.persist.model.PrimaryKey;

@Entity
public class TypeEntity
{
	@PrimaryKey
	private String type;

	public TypeEntity()
	{
		
	}
	
	public TypeEntity(String type)
	{
		super();
		this.type = type;
	}

	public String getType()
	{
		return type;
	}
}
