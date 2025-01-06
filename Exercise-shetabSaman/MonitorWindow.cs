using System.Windows;

namespace Exercise_shetabSaman
{
    public class MonitorWindow : Window
    {
        public MonitorWindow(Screen screen)
        {
            this.Width = screen.Bounds.Width / 2;
            this.Height = screen.Bounds.Height / 2;
            this.Left = screen.Bounds.Left + (screen.Bounds.Width - this.Width) / 2;
            this.Top = screen.Bounds.Top + (screen.Bounds.Height - this.Height) / 2;

            var button = new System.Windows.Controls.Button
            {
                Content = "Close",
                Width = 100,
                Height = 50,
            };
            button.Click += (s, e) => this.Close();
            this.Content = button;
        }
    }
}