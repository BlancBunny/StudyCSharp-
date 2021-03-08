using System;
using System.Windows.Forms;

namespace MyWindowApp
{
    class MainApp : Form
    {
        
        public MainApp(string title)
        {
            this.Text = title;
            this.MouseClick += MainApp_MouseClick; 
        }

        private void MainApp_MouseClick(object sender, MouseEventArgs e)
        {
            var result = $"sender : {sender} \r\n" +
                         $"e: {e} \r\n" +
                         $"e.X : {e.X}, e.Y : {e.Y}" +
                         $"Button : {e.Button}, Clicks : {e.Clicks}";
            // throw new NotImplementedException();
            MessageBox.Show(result);
        }

        static void Main(string[] args)
        {
            Application.Run(new MainApp("Mouse Event App"));

        }
    }
}
