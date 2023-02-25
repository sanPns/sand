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
using System.Security.Permissions;
using System.Windows.Threading;

namespace WpfApp4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var args = buttons.Margin;
            for (int i = 0; i < 1000; i++)
            {
                args.Left = args.Left + 1;
                buttons.Margin = args;
                text.Text = args.Left.ToString();
                if(args.Left == 800)
                {
                    args.Left = -47;
                }

                Delay(20);
            }
        }
      
            public void Delay(double delayTime)
            {
                DateTime now = DateTime.Now;
                double s;
                do
                {
                    TimeSpan spand = DateTime.Now - now;
                    s = spand.Milliseconds;  
                    DispatcherHelper.DoEvents();
                }
                while (s < delayTime);
            }
        
    }
    public static class DispatcherHelper
    {
        [SecurityPermissionAttribute(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        public static void DoEvents()
        {
            DispatcherFrame frame = new DispatcherFrame();
            Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Background, new DispatcherOperationCallback(ExitFrames), frame);
            try { Dispatcher.PushFrame(frame); }
            catch (InvalidOperationException) { }
        }
        private static object ExitFrames(object frame)
        {
            ((DispatcherFrame)frame).Continue = false;
            return null;
        }
    }
}
