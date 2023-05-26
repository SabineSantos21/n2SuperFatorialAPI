namespace n2SuperFatorial
{
    public class FatorialService
    {
        public FatorialService() { }

        public int SuperFatorial(int n)
        {
            int resultado = 1;

            for (int i = 1; i <= n; i++)
            {
                resultado *= Fatorial(i);
            }

            return resultado;
        }

        public int Fatorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }

            int fatorial = 1;

            for (int i = 2; i <= num; i++)
            {
                fatorial *= i;
            }

            return fatorial;
        }
    }
}
