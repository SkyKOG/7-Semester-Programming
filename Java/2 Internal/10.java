import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class AlphaBeta extends JApplet {
	JButton jbtnAlpha;
	JButton jbtnBeta;
	JLabel jlab;

	public void init() {
		SwingUtilities.invokeAndWait(new Runnable () {
			public void run() {
				makeGUI(); 
			}
		});
	}

	private void makeGUI() {

		setLayout(new FlowLayout());

		jbtnAlpha = new JButton("Alpha");
		jbtnBeta = new JButton("Beta");

		jbtnAlpha.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent le) {
				jlab.setText("Alpha was pressed.");
			}
		});
		
		jbtnBeta.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent le) {
				jlab.setText("Beta was pressed.");
			}
		});
		
		add(jbtnAlpha);
		add(jbtnBeta);
		
		jlab = new JLabel("Press a button.");
		
		add(jlab);
		}
}

/*
HTML File
<object code="AlphaBeta" width=220 height=90>
</object>
*/