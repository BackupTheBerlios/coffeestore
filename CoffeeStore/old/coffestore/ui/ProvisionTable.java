package old.coffestore.ui;

import java.util.Collection;

import javax.swing.table.AbstractTableModel;

import old.coffestore.core.Provision;


public class ProvisionTable extends AbstractTableModel
{
	private static final long serialVersionUID = 1L;
	
	private static final int COLUMS = 12;
	
	private Object[][] itsProvisions;

	private String[] itsColumnNames = { "Id", "DateId", "Seller", "PurchaseBill", "PurchaseBillDate", "Origin", "Type", "Tag", "TotSackNumber", "TotKilos", "RemainingSacks", "RemainingSacks" };
	
	public ProvisionTable(Collection<Provision> someProvision)
	{
		super();
		itsProvisions = new Object[someProvision.size()][COLUMS];
		int i = 0;
		for (Provision provision : someProvision)
		{
			arraifyProvision(provision, itsProvisions[i]);
			i++;
		}
	}

	private void arraifyProvision(Provision aProvision, Object[] array)
	{
		array[0] = aProvision.getId();
		array[1] = aProvision.getDate();
		array[2] = aProvision.getSeller();
		array[3] = aProvision.getPurchaseBill();
		array[4] = aProvision.getPurchaseBillDate();
		array[5] = aProvision.getOrigin();
		array[6] = aProvision.getType();
		array[7] = aProvision.getTag();
		array[8] = aProvision.getTotSackNumber();
		array[9] = aProvision.getTotKilos();
		array[10] = aProvision.getRemainingSacks();
		array[11] = aProvision.getRemainingKilos();
	}
	
	public int getColumnCount()
	{
		return COLUMS;
	}

    public String getColumnName(int col) 
    {
        return itsColumnNames[col];
    }
	
	public int getRowCount()
	{
		return itsProvisions.length;
	}
	
	public Object getValueAt(int arg0, int arg1)
	{
		return itsProvisions[arg0][arg1];
	}
}
