using System;
using Gtk;

namespace DroneClient
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
			// If the chat server uses an irc protocol, here's a potential
			// client we can pull from: http://code.google.com/p/monc/
			//
			
			//Here's a generic list of things we should probably accomplish
			//
			// 1. check to see if we have login credentials stored on the disk
			//		1a. if so, 
			//			1a1. login
			//			1a2. download current master task list
			//			1a3. generate today's task list
			//
		}
	}
}
