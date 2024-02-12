using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinApp2
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.Run(new Form1());
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = e.ExceptionObject as Exception;
            if (exception != null)
            {
                Form1 form1Instance = new Form1();

                // Добавление элемента в listBox1 через публичный метод
                form1Instance.AddItemToListBox($"Необработанная ошибка: {exception.Message}");

                // Отображение формы (если это необходимо)
                form1Instance.ShowDialog();
                // Если требуется завершить приложение после необработанной ошибки
                Environment.Exit(1);
            }
        }
    }
}
