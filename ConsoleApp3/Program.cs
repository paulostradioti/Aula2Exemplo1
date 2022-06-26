namespace ConsoleApp3
{
    public class ClasseBase
    {
        public virtual void MostraMensagem()
        {
            Console.WriteLine("Mensagem da classe base");
        }
        public void NovoMostraMensagem()
        {
            Console.WriteLine("Mensagem da classe base - NOVO método - ClasseBase");
        }

        public virtual void Derivado()
        {
            Console.WriteLine("Método pertencente a ClasseBase");
        }
    }

    public class ClasseDerivada : ClasseBase
    {
        override public void MostraMensagem()
        {
            Console.WriteLine("Mensagem da classe derivada");
        }
        new public void NovoMostraMensagem()
        {
            Console.WriteLine("Mensagem da classe base - NOVO método - ClasseDerivada");
        }

        //override public void NovoMostraMensagem()
        //{
        //    Console.WriteLine("Mensagem da classe base - NOVO método");
        //}

        //public void NovoMostraMensagem()
        //{
        //    Console.WriteLine("Mensagem da classe base - NOVO método");
        //}

        public override void Derivado()
        {
            Console.WriteLine("Método pertencente a ClasseDerivada");
        }
    }

    public class ClasseDerivadaDuasVezes : ClasseDerivada
    {
        public override void Derivado()
        {
            Console.WriteLine("Método pertencente a ClasseDerivadaDuasVezes");
        }
        new public void NovoMostraMensagem()
        {
            Console.WriteLine("Mensagem da classe base - NOVO método - ClasseDerivadaDuasVezes");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Referência e Objeto do mesmo tipo (ClasseBase)");
            ClasseBase baseOjb = new ClasseBase();
            baseOjb.MostraMensagem();
            baseOjb.NovoMostraMensagem();

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Referência e Objeto do mesmo tipo (ClasseDerivada)");
            ClasseDerivada derivadaOjb = new ClasseDerivada();
            derivadaOjb.MostraMensagem();
            derivadaOjb.NovoMostraMensagem();

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Referência e Objeto do mesmo tipo (ClasseDerivada)");
            ClasseBase derivadaOjbBaseRef = new ClasseDerivada();
            derivadaOjbBaseRef.MostraMensagem();
            derivadaOjbBaseRef.NovoMostraMensagem();

            ClasseBase derivadaOjbBaseRefCast = new ClasseDerivada();
            derivadaOjb.MostraMensagem();
            derivadaOjb.NovoMostraMensagem();
            ((ClasseBase)derivadaOjbBaseRefCast).MostraMensagem();
            ((ClasseBase)derivadaOjbBaseRefCast).NovoMostraMensagem();

            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");

            ClasseBase a = new ClasseBase();
            a.Derivado();
            a.NovoMostraMensagem();

            ClasseDerivada b = new ClasseDerivada();
            b.Derivado();
            b.NovoMostraMensagem();

            ClasseDerivadaDuasVezes c = new ClasseDerivadaDuasVezes();
            c.Derivado();
            c.NovoMostraMensagem();

            Console.WriteLine("--------------------------------------------------");
            ClasseBase b_base = b;
            b_base.Derivado();
            b_base.NovoMostraMensagem();

            ClasseBase c_base = c;
            c_base.Derivado();
            c_base.NovoMostraMensagem();

            ClasseDerivada c_derivada = c;
            c_derivada.Derivado();
            c_derivada.NovoMostraMensagem();
        }

    }
}