using System;

namespace ConsoleApp1
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T o);
    }

    public class Specification<T> : ISpecification<T>
    {
        private Func<T, bool> expression;
        public Specification(Func<T, bool> expression)
        {
            if (expression == null)
                throw new ArgumentNullException();
            else
                this.expression = expression;
        }

        public bool IsSatisfiedBy(T o)
        {
            return this.expression(o);
        }
    }
}
