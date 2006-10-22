package old.coffestore.ui;

import java.awt.GridLayout;

import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class AddProvisionPanel extends JPanel
{
	private JTextField itsId;
	private JTextField itsDate;
	private JTextField itsPurchaseBill;
	private JTextField itsPurchaseBillDate;
	private JTextField itsSeller;
	private JTextField itsOrigin;
	private JTextField itsType;
	private JTextField itsTag;
	private JTextField itsTotSackNumber;
	private JTextField itsTotKilos;
	
	public AddProvisionPanel()
	{
		super(new GridLayout(10, 2));
		
		itsId = new JTextField();
		itsDate = new JTextField();
		itsPurchaseBill = new JTextField(); 
		itsPurchaseBillDate = new JTextField();
		itsSeller = new JTextField();
		itsOrigin = new JTextField();
		itsType = new JTextField();
		itsTag = new JTextField();
		itsTotSackNumber = new JTextField();
		itsTotKilos = new JTextField();
		
		add(new JLabel("Id"));
		add(itsId);
		add(new JLabel("Date"));
		add(itsDate);
		add(new JLabel("PurchaseBill"));
		add(itsPurchaseBill);
		add(new JLabel("PurchaseBillDate"));
		add(itsPurchaseBillDate);
		add(new JLabel("Seller"));
		add(itsSeller);
		add(new JLabel("Origin"));
		add(itsOrigin);
		add(new JLabel("Type"));
		add(itsType);
		add(new JLabel("Tag"));
		add(itsTag);
		add(new JLabel("TotSackNumber"));
		add(itsTotSackNumber);
		add(new JLabel("TotKilos"));
		add(itsTotKilos);
	}
}
