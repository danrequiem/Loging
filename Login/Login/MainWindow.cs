using System;
using Gtk;


public partial class MainWindow: Gtk.Window
{
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnIngresarClicked (object sender, EventArgs e)
	{
		string user = "Daniel";
		string pass = "m49wap";
		if ( usuario.Text == user && Pass.Text == pass) {

			Console.WriteLine ("Bienvenido");
		
		} else {

			Console.WriteLine ("Acceso denegado");

		}
	
	}

	protected void OnSalirClicked (object sender, EventArgs e)
	{
		Application.Quit ();
	}
}
