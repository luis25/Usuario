﻿
using System;
using System.Windows.Forms;

namespace Usuario
{
	
	internal sealed class Program
	{
		
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
