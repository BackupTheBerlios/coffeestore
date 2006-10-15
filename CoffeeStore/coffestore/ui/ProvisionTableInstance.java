package coffestore.ui;

import java.awt.GridLayout;
import java.util.ArrayList;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;

import coffestore.core.Provision;
import coffestore.core.test.Factories;

public class ProvisionTableInstance extends JPanel
{
    public ProvisionTableInstance() 
    {
        super(new GridLayout(1,0));

        ArrayList<Provision> provs = new ArrayList<Provision>();
        for (int i = 0 ; i < 200; i++)
        {
        	provs.add(Factories.createProvision(10+i, 20+i));	
        }
        

        
        JTable table = new JTable(new ProvisionTable(provs));
        JScrollPane scrollPane = new JScrollPane(table);
        add(scrollPane);
    }	
	
	private static void createAndShowGUI()
	{
	      //Make sure we have nice window decorations.
        JFrame.setDefaultLookAndFeelDecorated(true);

        //Create and set up the window.
        JFrame frame = new JFrame("HelloWorldSwing");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        //Create and set up the content pane.
        ProvisionTableInstance newContentPane = new ProvisionTableInstance();
        //newContentPane.setOpaque(true); //content panes must be opaque
        frame.setContentPane(newContentPane);

        //Display the window.
        frame.pack();
        frame.setVisible(true);
	}

	public static void main(String[] args)
	{
		javax.swing.SwingUtilities.invokeLater(new Runnable()
		{
			public void run()
			{
				createAndShowGUI();
			}
		});
	}
}