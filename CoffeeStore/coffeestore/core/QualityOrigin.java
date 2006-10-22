package coffeestore.core;

public class QualityOrigin
{
	private String origin;
	private String type;
	private String tag;
	
	public QualityOrigin(String origin, String type, String tag)
	{
		super();
		this.origin = origin;
		this.type = type;
		this.tag = tag;
	}
	
	public String getOrigin()
	{
		return origin;
	}
	
	public String getTag()
	{
		return tag;
	}
	
	public String getType()
	{
		return type;
	}
}
