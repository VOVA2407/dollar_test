/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 19.05.2017
 * Time: 17:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dollar_test
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		

		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= '0') && (e.KeyChar <= '9'))
			{
				return;
			}
			
			if (e.KeyChar == '.')
			{
				e.KeyChar = ',';
			}
			if(e.KeyChar == ',')
			{
				if ((textBox1.Text.IndexOf(',') != -1) || textBox1.Text.Length == 0)
				{
					e.Handled = true;
				}
				return;
			}
			if (Char.IsControl(e.KeyChar))
			{
				if(e.KeyChar == (char)Keys.Enter)
				{
					if(sender.Equals(textBox1))
					{
						textBox2.Focus();
					}
					else
					{
						button1.Focus();
					}
					return;
				}
				e.Handled = true;
			}
			
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			label3.Text = "";
			if((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0))
			{button1.Enabled = false;}
			else
			{
				button1.Enabled = true;
			}
			
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			double usd;
			double k;
			double rub;
			usd = Convert.ToDouble(textBox1.Text);
			k = Convert.ToDouble(textBox2.Text);
			rub = usd * k;
			label3.Text = rub.ToString("C");
						}
	}
}
