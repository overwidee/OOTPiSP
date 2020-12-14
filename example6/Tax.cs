namespace example6
{
    public interface ITax
    {
        double GetTaxSum();
    }

    public class Income
    {
        protected string _name;
        private readonly double _value;

        protected Income(double value)
        {
            _value = value;
        }

        protected double GetMoney() => _value;
        public string GetName() => _name;
    }
    
    public class MainWork : Income, ITax
    {
        public MainWork(double value) : base(value)
        {
            _name = "Основная работа";
        }

        public double GetTaxSum()
        {
            return GetMoney() * 0.25;
        }
    }
    public class SecondWork : Income, ITax
    {
        public SecondWork(double value) : base(value)
        {
            _name = "Доп. работа";
        }

        public double GetTaxSum()
        {
            return GetMoney() * 0.15;
        }
    }

    public class Royalty : Income, ITax
    {
        public Royalty(double value) : base(value)
        {
            _name = "Авторские вознаграждения";
        }

        public double GetTaxSum()
        {
            return GetMoney() * 0.17;
        }
    }

    public class Sales : Income, ITax
    {
        public Sales(double value) : base(value)
        {
            _name = "Продажи";
        }

        public double GetTaxSum()
        {
            return GetMoney() * 0.09;
        }
    }

    public class Gift : Income, ITax
    {
        public Gift(double value) : base(value)
        {
            _name = "Подарки денежных сумм и имущества";
        }

        public double GetTaxSum()
        {
            return GetMoney() * 0.3;
        }
    }

    public class Transfer : Income, ITax
    {
        public Transfer(double value) : base(value)
        {
            _name = "Переводов из-за границы";
        }

        public double GetTaxSum()
        {
            return GetMoney() * 0.23;
        }
    }

    public class Privilege : Income, ITax
    {
        public Privilege(double value) : base(value)
        {
            _name = "Льгот на детей и материальной помощи";
        }

        public double GetTaxSum()
        {
            return GetMoney() * 0.2;
        }
    }
}