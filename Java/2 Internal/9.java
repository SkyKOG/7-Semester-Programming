//Author : SkyKOG

import java.awt.*;
import javax.swing.*;

public class JTableDemo extends JApplet {
	
	public void init() {
		SwingUtilities.invokeAndWait(
			new Runnable() {
				public void run() {
					makeGUI();
				}
			}
		);
	}

	private void makeGUI() {
		String[] colHeads = { "fname", "lname", "age" };
		
		Object[][] data = {
		{ "Sky", "KOG", "21" },
		{ "Vish", "Pand", "21" },
		{ "Shrivar", "Jois", "21" },
		{ "Chris", "Markus", "21" },
		{ "Sagar", "Dev", "15" },
		};

		JTable table = new JTable(data, colHeads);
		JScrollPane jsp = new JScrollPane(table);
		add(jsp);
	}
}

/*
HTML File
<applet code="JTableDemo" width=400 height=200>
</applet>
*/