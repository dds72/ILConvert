using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ILConvert
{
  public class ApplicationContext : System.Windows.Forms.ApplicationContext
  {
    NotifyIcon notifyIcon = new NotifyIcon();
    Configuration configWindow = new Configuration();

    public ApplicationContext()
    {
      MenuItem configMenuItem = new MenuItem("Configuration", new EventHandler(ShowConfig));
      MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

      notifyIcon.Icon = ILConvert.Properties.Resources.AppIcon;
      notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { configMenuItem, exitMenuItem });
      notifyIcon.Visible = true;
    }

    void ShowConfig(object sender, EventArgs e)
    {
      // If we are already showing the window meerly focus it.
      if (configWindow.Visible)
        configWindow.Focus();
      else
        configWindow.ShowDialog();
    }

    void Exit(object sender, EventArgs e)
    {
      // We must manually tidy up and remove the icon before we exit.
      // Otherwise it will be left behind until the user mouses over.
      notifyIcon.Visible = false;

      Application.Exit();
    }
  }
}
