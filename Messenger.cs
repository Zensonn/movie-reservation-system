using System.Windows.Forms;

namespace movie_reservation_system
{
    internal class Messenger
    {
        public static DialogResult Confirm(string message)
        {
            return MessageBox.Show(message, @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void Error(string message)
        {
            MessageBox.Show(message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Notification(string message)
        {
            MessageBox.Show(message, @"Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}