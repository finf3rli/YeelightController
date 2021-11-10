using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using YeelightAPI;
using System.Windows.Forms;

namespace YeelightController
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Lamp controller;
        Device lamp;
        Bitmap b;
        private NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenu contextMenu;
        private System.Windows.Forms.MenuItem menuItem;
        private System.ComponentModel.IContainer components;
        public MainWindow()
        {
            this.Left = 1635;
            this.Top = 700;

            InitializeComponent();
            this.Hide();
            controller = new Lamp();
            lamp = controller.getLamp;
            b = new Bitmap("C:\\Users\\sante\\source\\repos\\YeelightController\\YeelightController\\spectrum.png");

            this.components = new System.ComponentModel.Container();
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem = new System.Windows.Forms.MenuItem();

            this.contextMenu.MenuItems.AddRange(
                    new System.Windows.Forms.MenuItem[] { this.menuItem });

            this.menuItem.Index = 0;
            this.menuItem.Text = "E&xit";
            this.menuItem.Click += new System.EventHandler(this.MenuItem_Click);

            this.notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new Icon("C:\\Users\\sante\\source\\repos\\YeelightController\\YeelightController\\tray.ico");
            notifyIcon.Visible = true;
            notifyIcon.ContextMenu = this.contextMenu;
            notifyIcon.Click += new EventHandler(this.NotifyIcon_Click);
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lamp.Toggle();
        }

        private void spectrum_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            System.Drawing.Color c = b.GetPixel((int)e.GetPosition(this.spectrum).X, (int)e.GetPosition(this.spectrum).Y);
            lamp.SetRGBColor(c.R, c.G, c.B, 1);
            //Console.WriteLine(c.ToString() + ' ' + (int)e.GetPosition(this.spectrum).X + ' ' + (int)e.GetPosition(this.spectrum).Y);
        }

        private void Window_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Hide();
        }
    }
}
