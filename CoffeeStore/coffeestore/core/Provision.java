package coffeestore.core;

public class Provision
{
	private long id;
	private String date;
	private String vendor;
	private int totSackNumber;
	private int totKilos;
	
	public Provision(long id, String date, String vendor, int totSackNumber, int totKilos)
	{
		super();
		this.id = id;
		this.date = date;
		this.vendor = vendor;
		this.totSackNumber = totSackNumber;
		this.totKilos = totKilos;
	}

	public long getId()
	{
		return id;
	}
	
	public String getDate()
	{
		return date;
	}
	
	public String getVendor()
	{
		return vendor;
	}
	
	public int getTotKilos()
	{
		return totKilos;
	}
	public int getTotSackNumber()
	{
		return totSackNumber;
	}
}
