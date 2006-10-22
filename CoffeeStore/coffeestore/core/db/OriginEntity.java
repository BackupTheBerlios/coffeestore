package coffeestore.core.db;

import com.sleepycat.persist.model.Entity;
import com.sleepycat.persist.model.PrimaryKey;

@Entity
public class OriginEntity
{
	@PrimaryKey
	private String origin;

	public OriginEntity()
	{
		
	}
	
	public OriginEntity(String origin)
	{
		super();
		this.origin = origin;
	}

	public String getOrigin()
	{
		return origin;
	}
}
