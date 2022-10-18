using System.Text;

namespace Proxor
{
    public sealed class CalculatorHistory
    {
        private string[] history = new string[1];
        private int index;

        public void Append(string record)
        {
            history[index] = record;
            index++;
            if (index >= history.Length)
            {
                string[] newHistory = new string[history.Length + 1];
                for (int i = 0; i < history.Length; i++)
                {
                   newHistory[i] = history[i];
                }

                history = newHistory;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < history.Length; i++)
            {
                history[i] = null;
            }
            
        }

        public string GetAllHistory()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("История калькулирования:\n");
            for (int i = 0; i < history.Length; i++)
            {
                sb.AppendLine(history[i]);
            }
            return sb.ToString();
        }
    }
}