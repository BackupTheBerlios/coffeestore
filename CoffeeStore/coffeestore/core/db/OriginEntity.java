package coffeestore.core.db;

import com.sleepycat.persist.model.Entity;
import com.sleepycat.persist.model.PrimaryKey;

@Entity
public class OriginEntity
{
	@PrimaryKey
	private String itsOrigin;

	public OriginEntity()
	{
		
	}
	
	public OriginEntity(String anOrigin)
	{
		itsOrigin = anOrigin;
	}

	public String getOrigin()
	{
		return itsOrigin;
	}
}
