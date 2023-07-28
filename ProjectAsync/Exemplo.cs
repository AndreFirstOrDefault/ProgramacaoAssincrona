using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAsync
{
    public class Exemplo
    {
        // Método com retorno

        bool Task_TResult()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }

        // Método void

        void Task_Void()
        {
            Task.Delay(2000);
            Form1.lstRes.Items.Add("3 - Tarefa longa executada");
        }

        public void Task_LongaDuracao()
        {
            bool isAnoBissexto = Task_TResult();

            Form1.lstRes.Items.Add($"2 - {DateTime.Now.Year} {(isAnoBissexto ? " é " : " não é ")} um Ano Bissexto");
            Task_Void();
        }
    }
}
