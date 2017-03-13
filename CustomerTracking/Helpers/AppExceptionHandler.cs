using CustomerTracking.NonRelationalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerTracking.Helpers
{
    public static class AppExceptionHandler
    {
        static Main frmMain = (Main)Application.OpenForms["Main"];
        
        public static void CommonExceptionHandler(object sender, ThreadExceptionEventArgs t)
        {
            DialogResult result = DialogResult.Cancel;

            try
            {
                result = ShowThreadExceptionDialog("Uygulama hatası oluştu! Uygulamayı yeniden başlatınız", t.Exception);
            }
            catch
            {
                try
                {
                    MessageBox.Show(new Form() { TopMost = true }, "Uygulama hatası oluştu! Uygulamayı yeniden başlatınız", "Uygulama hatası oluştu! Uygulamayı yeniden başlatınız", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    new AppException("Uygulama hatası oluştu! Uygulamayı yeniden başlatınız", t.Exception);
                    new AppException("Uygulama hatası oluştu! Uygulamayı yeniden başlatınız", ex);
                    var msgBoxException = new AppException("Uygulama hatası oluştu! Uygulamayı yeniden başlatınız", ex);
                }
                finally
                {
                    Application.Exit();
                }
            }

            if (result == DialogResult.Abort)
            {
                Application.Exit();
            }

            if (!frmMain.Enabled)
            {
                frmMain.Enabled = true;
            }

        }

        public static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;

                new AppException("Uygulama hatası oluştu! Uygulamayı yeniden başlatınız", ex);

            }
            catch (Exception exception)
            {
                try
                {
                    MessageBox.Show(new Form() { TopMost = true }, "Uygulama hatası oluştu! Uygulamayı yeniden başlatınız", "Uygulama hatası oluştu! Uygulamayı yeniden başlatınız", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    new AppException("Uygulama hatası oluştu! Uygulamayı yeniden başlatınız", exception);

                    Application.Exit();
                }
            }
        }

        // Creates the error message and displays it.
        private static DialogResult ShowThreadExceptionDialog(string title, Exception e)
        {
            var appException = new AppException("Unhandled exception occured", e);

            return MessageBox.Show(new Form() { TopMost = true }, title, "Uygulama hatası oluştu! Uygulamayı yeniden başlatınız", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);

        }

    }
}
